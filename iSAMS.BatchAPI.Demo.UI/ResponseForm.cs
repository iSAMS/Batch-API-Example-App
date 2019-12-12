using System.Windows.Forms;
using iSAMS.BatchAPI.Demo.Core.DTOs;
using iSAMS.BatchAPI.Demo.UI.Properties;

namespace iSAMS.BatchAPI.Demo.UI
{
    /// <summary>
    /// Represents the Response Form.
    /// </summary>
    public partial class ResponseForm : Form
    {
        /// <summary>
        /// Response Form constructor.
        /// </summary>
        public ResponseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Process the API response by updating this form with the appropriate values.
        /// </summary>
        /// <param name="response">DTO representing the API response data.</param>
        public void ProcessResponse(ApiResponseDto response)
        {
            lblResponseCode.Text = $"{(int)response.StatusCode} - {response.StatusCode}";
            lblMediaType.Text = response.MediaType;

            switch (response.MediaType)
            {
                case "application/zip":
                {
                    txtResponseData.Text = $"Binary file {response.FileName}";
                    break;
                }
                case "application/xml":
                case "text/html":
                {
                    txtResponseData.Text = response.Xml;
                    break;
                }
                default:
                {
                    txtResponseData.Text = Resources.ResponseForm_ProcessResponse_Unexpected_Media_Type;
                    break;
                }
            }
        }
    }
}