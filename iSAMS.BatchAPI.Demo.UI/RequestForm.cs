using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using iSAMS.BatchAPI.Demo.Core.DTOs;
using iSAMS.BatchAPI.Demo.Core.Enumerations;
using iSAMS.BatchAPI.Demo.Core.Services.Interfaces;
using iSAMS.BatchAPI.Demo.UI.Properties;

namespace iSAMS.BatchAPI.Demo.UI
{
    /// <summary>
    /// Represents the Request Form.
    /// </summary>
    public partial class RequestForm : Form
    {
        //Service dependencies.
        private readonly IFiltersXmlService _filtersXmlService;
        private readonly IRequestService _requestService;

        //Response form to be displayed as child form of this form as required.
        private readonly ResponseForm _responseForm = new ResponseForm();

        /// <summary>
        /// Request Form constructor
        /// </summary>
        /// <param name="filtersXmlService">FiltersXMLService as injected by IoC container.</param>
        /// <param name="requestService">RequestService as injected by IoC container.</param>
        public RequestForm(IFiltersXmlService filtersXmlService, IRequestService requestService)
        {
            if (filtersXmlService == null || requestService == null)
            {
                MessageBox.Show(Resources.RequestForm_RequestForm_Unable_To_Inject_Service_Dependencies);
                Load += (s, e) => Close();
            }
            else
            {
                _filtersXmlService = filtersXmlService;
                _requestService = requestService;

                InitializeComponent();
            }
        }

        /// <summary>
        /// Sets the initial state of this form's controls.
        /// </summary>
        private void InitFormValues()
        {
            cmbEndpoint.DataSource = new BindingSource { DataSource = _requestService.Endpoints };
            cmbEndpoint.ValueMember = "Id";
            cmbEndpoint.DisplayMember = "DisplayName";
            cmbEndpoint.SelectedIndex = 0;
            cmbEndpoint.SelectedIndexChanged += cmbEndpoint_SelectedIndexChanged;

            cmbHttpVerb.DataSource = new BindingSource { DataSource = Enum.GetValues(typeof (HttpVerb)) };

            cmbApiVersion.DataSource = new BindingSource { DataSource = _requestService.Versions };

            UpdateUrlText();
        }

        /// <summary>
        /// Updates the URL text control based on the values in this form's controls.
        /// </summary>
        private void UpdateUrlText()
        {
            try
            {
                txtUrl.Text = _requestService.BuildUrl(txtHost.Text, cmbApiVersion.Text,
                    (int) cmbEndpoint.SelectedValue, txtApiKey.Text, chkUseSsl.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Gets this form's current selected filter value.
        /// </summary>
        /// <returns>
        /// The form's current selected filter value as a string.
        /// </returns>
        private string GetSelectedFilterValue()
        {
            //Find the current selected filter value control.
            var selectedFilterValueControl = grpFilterValue?.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            //Return the appropriate filter value string.
            switch (selectedFilterValueControl?.Name)
            {
                case "rdoFilterValueCsvString":
                    {
                        return txtFilterValueCsvString.Text;
                    }
                case "rdoFilterValueDate":
                    {
                        return dtpFilterValueDate.Value.ToString("yyyy-MM-dd");
                    }
                case "rdoFilterValueBoolean":
                    {
                        return chkFilterValueBoolean.Checked.ToString().ToLower();
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        /// <summary>
        /// Click Event Handler for the Send Request button.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param>
        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                //Show wait cursor and disable Send Request button.
                Cursor.Current = Cursors.WaitCursor;
                btnSendRequest.Enabled = false;

                //Populate request DTO to send to request service.
                var apiRequest = new ApiRequestDto
                {
                    ApiKey = txtApiKey.Text,
                    EndpointId = (int) cmbEndpoint.SelectedValue,
                    Verb = (HttpVerb)cmbHttpVerb.SelectedItem,
                    Version = cmbApiVersion.Text,
                    Host = txtHost.Text,
                    Ssl = chkUseSsl.Checked,
                    FilterXml = txtFilterXML.Text
                };

                //Call request service to make API request.
                var apiResponse = await _requestService.MakeApiRequest(apiRequest);

                //Process API response in response form.
                _responseForm.ProcessResponse(apiResponse);

                //Show response form.
                _responseForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Show default cursor and enable Send Request button.
                Cursor.Current = Cursors.Default;
                btnSendRequest.Enabled = true;
            }
        }

        /// <summary>
        /// Click Event Handler for the Clear Filters button.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param>  
        private void btnFilterXMLClear_Click(object sender, EventArgs e)
        {
            txtFilterXML.Clear();
        }

        /// <summary>
        /// CheckedChanged Event Handler for the CSV/String Filter Value radio button.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param>
        private void rdoFilterValueCsvString_CheckedChanged(object sender, EventArgs e)
        {
            txtFilterValueCsvString.Enabled = true;
            dtpFilterValueDate.Enabled = false;
            chkFilterValueBoolean.Enabled = false;

            dtpFilterValueDate.Text = string.Empty;
            chkFilterValueBoolean.Checked = false;
        }

        /// <summary>
        /// CheckedChanged Event Handler for the Date Filter Value radio button.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param>
        private void rdoFilterValueDate_CheckedChanged(object sender, EventArgs e)
        {
            txtFilterValueCsvString.Enabled = false;
            dtpFilterValueDate.Enabled = true;
            chkFilterValueBoolean.Enabled = false;

            txtFilterValueCsvString.Text = string.Empty;
            chkFilterValueBoolean.Checked = false;
        }

        /// <summary>
        /// CheckedChanged Event Handler for the Boolean Filter Value radio button.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param>
        private void rdoFilterValueBoolean_CheckedChanged(object sender, EventArgs e)
        {
            txtFilterValueCsvString.Enabled = false;
            dtpFilterValueDate.Enabled = false;
            chkFilterValueBoolean.Enabled = true;

            txtFilterValueCsvString.Text = string.Empty;
            dtpFilterValueDate.Text = string.Empty;
        }

        /// <summary>
        /// Click Event Handler for the Create/Update Filter button.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param>  
        private void btnCreateUpdateFilter_Click(object sender, EventArgs e)
        {
            var filterValue = GetSelectedFilterValue();
            if (filterValue != null)
            {
                try
                {
                    txtFilterXML.Text = _filtersXmlService.AddUpdateFilter(txtFilterPropertyModule.Text,
                        txtFilterPropertyMethod.Text,
                        txtFilterPropertyFilter.Text, filterValue, txtFilterXML.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(Resources.RequestForm_btnCreateFilter_Click_Invalid_Filter_Value_Type);
            }
        }

        /// <summary>
        /// Click Event Handler for the Remove Filter button.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                txtFilterXML.Text = _filtersXmlService.RemoveFilter(txtFilterPropertyModule.Text,
                    txtFilterPropertyMethod.Text,
                    txtFilterPropertyFilter.Text, txtFilterXML.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextChanged Event Handler for the Host text box.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            UpdateUrlText();
        }

        /// <summary>
        /// SelectedIndexChanged Event Handler for the API Version combo box.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void cmbApiVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUrlText();
        }

        /// <summary>
        /// CheckedChanged Event Handler for the SSL checkbox.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void chkUseSsl_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUrlText();
        }

        /// <summary>
        /// TextChanged Event Handler for the API Key text box.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void txtApiKey_TextChanged(object sender, EventArgs e)
        {
            UpdateUrlText();
        }

        /// <summary>
        /// SelectedIndexChanged Event Handler for the HTTP Verb combo box.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void cmbHttpVerb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUrlText();
        }

        /// <summary>
        /// SelectedIndexChanged Event Handler for the Endpoint combo box.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void cmbEndpoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUrlText();
        }

        /// <summary>
        /// Load Event Handler for the form.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void RequestForm_Load(object sender, EventArgs e)
        {
            InitFormValues();
        }

        /// <summary>
        /// LinkClicked Event Handler for the Filtering Help link label.
        /// </summary>
        /// <param name="sender">The control raising the event.</param>
        /// <param name="e">The event data.</param> 
        private void libFilteringHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Get the link from the control and call the appropriate handling process (default web browser).
            var processStartInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(processStartInfo);
        }
    }
}