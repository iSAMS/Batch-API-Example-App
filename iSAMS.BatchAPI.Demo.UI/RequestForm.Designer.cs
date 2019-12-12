namespace iSAMS.BatchAPI.Demo.UI
{
    partial class RequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRequestDetails = new System.Windows.Forms.GroupBox();
            this.cmbApiVersion = new System.Windows.Forms.ComboBox();
            this.lblApiVersion = new System.Windows.Forms.Label();
            this.chkUseSsl = new System.Windows.Forms.CheckBox();
            this.cmbEndpoint = new System.Windows.Forms.ComboBox();
            this.lblEndpoint = new System.Windows.Forms.Label();
            this.cmbHttpVerb = new System.Windows.Forms.ComboBox();
            this.lblHttpVerb = new System.Windows.Forms.Label();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.grpFilterBuilder = new System.Windows.Forms.GroupBox();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.btnCreateUpdateFilter = new System.Windows.Forms.Button();
            this.grpFilterValue = new System.Windows.Forms.GroupBox();
            this.chkFilterValueBoolean = new System.Windows.Forms.CheckBox();
            this.dtpFilterValueDate = new System.Windows.Forms.DateTimePicker();
            this.txtFilterValueCsvString = new System.Windows.Forms.TextBox();
            this.rdoFilterValueBoolean = new System.Windows.Forms.RadioButton();
            this.rdoFilterValueDate = new System.Windows.Forms.RadioButton();
            this.rdoFilterValueCsvString = new System.Windows.Forms.RadioButton();
            this.grpFilterProperties = new System.Windows.Forms.GroupBox();
            this.txtFilterPropertyFilter = new System.Windows.Forms.TextBox();
            this.txtFilterPropertyMethod = new System.Windows.Forms.TextBox();
            this.txtFilterPropertyModule = new System.Windows.Forms.TextBox();
            this.lblFilterPropertyFIlter = new System.Windows.Forms.Label();
            this.lblFilterPropertyMethod = new System.Windows.Forms.Label();
            this.lblFilterPropertyModule = new System.Windows.Forms.Label();
            this.grpFilterXML = new System.Windows.Forms.GroupBox();
            this.txtFilterXML = new System.Windows.Forms.TextBox();
            this.btnFilterXMLClear = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.grpRequestDetails.SuspendLayout();
            this.grpFilterBuilder.SuspendLayout();
            this.grpFilterValue.SuspendLayout();
            this.grpFilterProperties.SuspendLayout();
            this.grpFilterXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRequestDetails
            // 
            this.grpRequestDetails.Controls.Add(this.cmbApiVersion);
            this.grpRequestDetails.Controls.Add(this.lblApiVersion);
            this.grpRequestDetails.Controls.Add(this.chkUseSsl);
            this.grpRequestDetails.Controls.Add(this.cmbEndpoint);
            this.grpRequestDetails.Controls.Add(this.lblEndpoint);
            this.grpRequestDetails.Controls.Add(this.cmbHttpVerb);
            this.grpRequestDetails.Controls.Add(this.lblHttpVerb);
            this.grpRequestDetails.Controls.Add(this.lblApiKey);
            this.grpRequestDetails.Controls.Add(this.lblHost);
            this.grpRequestDetails.Controls.Add(this.txtApiKey);
            this.grpRequestDetails.Controls.Add(this.txtHost);
            this.grpRequestDetails.Location = new System.Drawing.Point(12, 12);
            this.grpRequestDetails.Name = "grpRequestDetails";
            this.grpRequestDetails.Size = new System.Drawing.Size(415, 109);
            this.grpRequestDetails.TabIndex = 0;
            this.grpRequestDetails.TabStop = false;
            this.grpRequestDetails.Text = "Request Details";
            // 
            // cmbApiVersion
            // 
            this.cmbApiVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApiVersion.FormattingEnabled = true;
            this.cmbApiVersion.Location = new System.Drawing.Point(358, 20);
            this.cmbApiVersion.MaxDropDownItems = 2;
            this.cmbApiVersion.Name = "cmbApiVersion";
            this.cmbApiVersion.Size = new System.Drawing.Size(42, 21);
            this.cmbApiVersion.TabIndex = 7;
            this.cmbApiVersion.SelectedIndexChanged += new System.EventHandler(this.cmbApiVersion_SelectedIndexChanged);
            // 
            // lblApiVersion
            // 
            this.lblApiVersion.AutoSize = true;
            this.lblApiVersion.Location = new System.Drawing.Point(283, 23);
            this.lblApiVersion.Name = "lblApiVersion";
            this.lblApiVersion.Size = new System.Drawing.Size(65, 13);
            this.lblApiVersion.TabIndex = 8;
            this.lblApiVersion.Text = "API Version:";
            // 
            // chkUseSsl
            // 
            this.chkUseSsl.AutoSize = true;
            this.chkUseSsl.Location = new System.Drawing.Point(354, 76);
            this.chkUseSsl.Name = "chkUseSsl";
            this.chkUseSsl.Size = new System.Drawing.Size(46, 17);
            this.chkUseSsl.TabIndex = 4;
            this.chkUseSsl.Text = "SSL";
            this.chkUseSsl.UseVisualStyleBackColor = true;
            this.chkUseSsl.CheckedChanged += new System.EventHandler(this.chkUseSsl_CheckedChanged);
            // 
            // cmbEndpoint
            // 
            this.cmbEndpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndpoint.FormattingEnabled = true;
            this.cmbEndpoint.Location = new System.Drawing.Point(227, 72);
            this.cmbEndpoint.MaxDropDownItems = 3;
            this.cmbEndpoint.Name = "cmbEndpoint";
            this.cmbEndpoint.Size = new System.Drawing.Size(111, 21);
            this.cmbEndpoint.TabIndex = 3;
            // 
            // lblEndpoint
            // 
            this.lblEndpoint.AutoSize = true;
            this.lblEndpoint.Location = new System.Drawing.Point(169, 75);
            this.lblEndpoint.Name = "lblEndpoint";
            this.lblEndpoint.Size = new System.Drawing.Size(52, 13);
            this.lblEndpoint.TabIndex = 6;
            this.lblEndpoint.Text = "Endpoint:";
            // 
            // cmbHttpVerb
            // 
            this.cmbHttpVerb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHttpVerb.FormattingEnabled = true;
            this.cmbHttpVerb.Location = new System.Drawing.Point(85, 72);
            this.cmbHttpVerb.MaxDropDownItems = 2;
            this.cmbHttpVerb.Name = "cmbHttpVerb";
            this.cmbHttpVerb.Size = new System.Drawing.Size(74, 21);
            this.cmbHttpVerb.TabIndex = 2;
            this.cmbHttpVerb.SelectedIndexChanged += new System.EventHandler(this.cmbHttpVerb_SelectedIndexChanged);
            // 
            // lblHttpVerb
            // 
            this.lblHttpVerb.AutoSize = true;
            this.lblHttpVerb.Location = new System.Drawing.Point(19, 75);
            this.lblHttpVerb.Name = "lblHttpVerb";
            this.lblHttpVerb.Size = new System.Drawing.Size(64, 13);
            this.lblHttpVerb.TabIndex = 4;
            this.lblHttpVerb.Text = "HTTP Verb:";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(19, 49);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(48, 13);
            this.lblApiKey.TabIndex = 3;
            this.lblApiKey.Text = "API Key:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(19, 23);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host:";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(85, 46);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(315, 20);
            this.txtApiKey.TabIndex = 1;
            this.txtApiKey.TextChanged += new System.EventHandler(this.txtApiKey_TextChanged);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(85, 20);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(192, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // grpFilterBuilder
            // 
            this.grpFilterBuilder.Controls.Add(this.btnRemoveFilter);
            this.grpFilterBuilder.Controls.Add(this.btnCreateUpdateFilter);
            this.grpFilterBuilder.Controls.Add(this.grpFilterValue);
            this.grpFilterBuilder.Controls.Add(this.grpFilterProperties);
            this.grpFilterBuilder.Location = new System.Drawing.Point(12, 127);
            this.grpFilterBuilder.Name = "grpFilterBuilder";
            this.grpFilterBuilder.Size = new System.Drawing.Size(415, 169);
            this.grpFilterBuilder.TabIndex = 1;
            this.grpFilterBuilder.TabStop = false;
            this.grpFilterBuilder.Text = "Filter Builder";
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Location = new System.Drawing.Point(183, 134);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveFilter.TabIndex = 16;
            this.btnRemoveFilter.Text = "Remove Filter";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // btnCreateUpdateFilter
            // 
            this.btnCreateUpdateFilter.Location = new System.Drawing.Point(275, 134);
            this.btnCreateUpdateFilter.Name = "btnCreateUpdateFilter";
            this.btnCreateUpdateFilter.Size = new System.Drawing.Size(125, 23);
            this.btnCreateUpdateFilter.TabIndex = 14;
            this.btnCreateUpdateFilter.Text = "Create / Update Filter";
            this.btnCreateUpdateFilter.UseVisualStyleBackColor = true;
            this.btnCreateUpdateFilter.Click += new System.EventHandler(this.btnCreateUpdateFilter_Click);
            // 
            // grpFilterValue
            // 
            this.grpFilterValue.Controls.Add(this.chkFilterValueBoolean);
            this.grpFilterValue.Controls.Add(this.dtpFilterValueDate);
            this.grpFilterValue.Controls.Add(this.txtFilterValueCsvString);
            this.grpFilterValue.Controls.Add(this.rdoFilterValueBoolean);
            this.grpFilterValue.Controls.Add(this.rdoFilterValueDate);
            this.grpFilterValue.Controls.Add(this.rdoFilterValueCsvString);
            this.grpFilterValue.Location = new System.Drawing.Point(196, 20);
            this.grpFilterValue.Name = "grpFilterValue";
            this.grpFilterValue.Size = new System.Drawing.Size(204, 108);
            this.grpFilterValue.TabIndex = 1;
            this.grpFilterValue.TabStop = false;
            this.grpFilterValue.Text = "Value";
            // 
            // chkFilterValueBoolean
            // 
            this.chkFilterValueBoolean.AutoSize = true;
            this.chkFilterValueBoolean.Enabled = false;
            this.chkFilterValueBoolean.Location = new System.Drawing.Point(107, 74);
            this.chkFilterValueBoolean.Name = "chkFilterValueBoolean";
            this.chkFilterValueBoolean.Size = new System.Drawing.Size(15, 14);
            this.chkFilterValueBoolean.TabIndex = 13;
            this.chkFilterValueBoolean.UseVisualStyleBackColor = true;
            // 
            // dtpFilterValueDate
            // 
            this.dtpFilterValueDate.CustomFormat = "";
            this.dtpFilterValueDate.Enabled = false;
            this.dtpFilterValueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterValueDate.Location = new System.Drawing.Point(107, 45);
            this.dtpFilterValueDate.Name = "dtpFilterValueDate";
            this.dtpFilterValueDate.Size = new System.Drawing.Size(90, 20);
            this.dtpFilterValueDate.TabIndex = 11;
            // 
            // txtFilterValueCsvString
            // 
            this.txtFilterValueCsvString.Location = new System.Drawing.Point(107, 19);
            this.txtFilterValueCsvString.Name = "txtFilterValueCsvString";
            this.txtFilterValueCsvString.Size = new System.Drawing.Size(90, 20);
            this.txtFilterValueCsvString.TabIndex = 9;
            // 
            // rdoFilterValueBoolean
            // 
            this.rdoFilterValueBoolean.AutoSize = true;
            this.rdoFilterValueBoolean.Location = new System.Drawing.Point(17, 72);
            this.rdoFilterValueBoolean.Name = "rdoFilterValueBoolean";
            this.rdoFilterValueBoolean.Size = new System.Drawing.Size(64, 17);
            this.rdoFilterValueBoolean.TabIndex = 12;
            this.rdoFilterValueBoolean.Text = "Boolean";
            this.rdoFilterValueBoolean.UseVisualStyleBackColor = true;
            this.rdoFilterValueBoolean.CheckedChanged += new System.EventHandler(this.rdoFilterValueBoolean_CheckedChanged);
            // 
            // rdoFilterValueDate
            // 
            this.rdoFilterValueDate.AutoSize = true;
            this.rdoFilterValueDate.Location = new System.Drawing.Point(17, 46);
            this.rdoFilterValueDate.Name = "rdoFilterValueDate";
            this.rdoFilterValueDate.Size = new System.Drawing.Size(48, 17);
            this.rdoFilterValueDate.TabIndex = 10;
            this.rdoFilterValueDate.Text = "Date";
            this.rdoFilterValueDate.UseVisualStyleBackColor = true;
            this.rdoFilterValueDate.CheckedChanged += new System.EventHandler(this.rdoFilterValueDate_CheckedChanged);
            // 
            // rdoFilterValueCsvString
            // 
            this.rdoFilterValueCsvString.AutoSize = true;
            this.rdoFilterValueCsvString.Checked = true;
            this.rdoFilterValueCsvString.Location = new System.Drawing.Point(17, 20);
            this.rdoFilterValueCsvString.Name = "rdoFilterValueCsvString";
            this.rdoFilterValueCsvString.Size = new System.Drawing.Size(84, 17);
            this.rdoFilterValueCsvString.TabIndex = 8;
            this.rdoFilterValueCsvString.TabStop = true;
            this.rdoFilterValueCsvString.Text = "CSV / String";
            this.rdoFilterValueCsvString.UseVisualStyleBackColor = true;
            this.rdoFilterValueCsvString.CheckedChanged += new System.EventHandler(this.rdoFilterValueCsvString_CheckedChanged);
            // 
            // grpFilterProperties
            // 
            this.grpFilterProperties.Controls.Add(this.txtFilterPropertyFilter);
            this.grpFilterProperties.Controls.Add(this.txtFilterPropertyMethod);
            this.grpFilterProperties.Controls.Add(this.txtFilterPropertyModule);
            this.grpFilterProperties.Controls.Add(this.lblFilterPropertyFIlter);
            this.grpFilterProperties.Controls.Add(this.lblFilterPropertyMethod);
            this.grpFilterProperties.Controls.Add(this.lblFilterPropertyModule);
            this.grpFilterProperties.Location = new System.Drawing.Point(17, 20);
            this.grpFilterProperties.Name = "grpFilterProperties";
            this.grpFilterProperties.Size = new System.Drawing.Size(173, 108);
            this.grpFilterProperties.TabIndex = 0;
            this.grpFilterProperties.TabStop = false;
            this.grpFilterProperties.Text = "Properties";
            // 
            // txtFilterPropertyFilter
            // 
            this.txtFilterPropertyFilter.Location = new System.Drawing.Point(68, 71);
            this.txtFilterPropertyFilter.Name = "txtFilterPropertyFilter";
            this.txtFilterPropertyFilter.Size = new System.Drawing.Size(95, 20);
            this.txtFilterPropertyFilter.TabIndex = 7;
            // 
            // txtFilterPropertyMethod
            // 
            this.txtFilterPropertyMethod.Location = new System.Drawing.Point(68, 45);
            this.txtFilterPropertyMethod.Name = "txtFilterPropertyMethod";
            this.txtFilterPropertyMethod.Size = new System.Drawing.Size(95, 20);
            this.txtFilterPropertyMethod.TabIndex = 6;
            // 
            // txtFilterPropertyModule
            // 
            this.txtFilterPropertyModule.Location = new System.Drawing.Point(68, 19);
            this.txtFilterPropertyModule.Name = "txtFilterPropertyModule";
            this.txtFilterPropertyModule.Size = new System.Drawing.Size(95, 20);
            this.txtFilterPropertyModule.TabIndex = 5;
            // 
            // lblFilterPropertyFIlter
            // 
            this.lblFilterPropertyFIlter.AutoSize = true;
            this.lblFilterPropertyFIlter.Location = new System.Drawing.Point(16, 74);
            this.lblFilterPropertyFIlter.Name = "lblFilterPropertyFIlter";
            this.lblFilterPropertyFIlter.Size = new System.Drawing.Size(32, 13);
            this.lblFilterPropertyFIlter.TabIndex = 2;
            this.lblFilterPropertyFIlter.Text = "Filter:";
            // 
            // lblFilterPropertyMethod
            // 
            this.lblFilterPropertyMethod.AutoSize = true;
            this.lblFilterPropertyMethod.Location = new System.Drawing.Point(16, 48);
            this.lblFilterPropertyMethod.Name = "lblFilterPropertyMethod";
            this.lblFilterPropertyMethod.Size = new System.Drawing.Size(46, 13);
            this.lblFilterPropertyMethod.TabIndex = 1;
            this.lblFilterPropertyMethod.Text = "Method:";
            // 
            // lblFilterPropertyModule
            // 
            this.lblFilterPropertyModule.AutoSize = true;
            this.lblFilterPropertyModule.Location = new System.Drawing.Point(16, 22);
            this.lblFilterPropertyModule.Name = "lblFilterPropertyModule";
            this.lblFilterPropertyModule.Size = new System.Drawing.Size(45, 13);
            this.lblFilterPropertyModule.TabIndex = 0;
            this.lblFilterPropertyModule.Text = "Module:";
            // 
            // grpFilterXML
            // 
            this.grpFilterXML.Controls.Add(this.txtFilterXML);
            this.grpFilterXML.Controls.Add(this.btnFilterXMLClear);
            this.grpFilterXML.Location = new System.Drawing.Point(12, 302);
            this.grpFilterXML.Name = "grpFilterXML";
            this.grpFilterXML.Size = new System.Drawing.Size(415, 216);
            this.grpFilterXML.TabIndex = 2;
            this.grpFilterXML.TabStop = false;
            this.grpFilterXML.Text = "Filter XML";
            // 
            // txtFilterXML
            // 
            this.txtFilterXML.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterXML.Location = new System.Drawing.Point(17, 19);
            this.txtFilterXML.Multiline = true;
            this.txtFilterXML.Name = "txtFilterXML";
            this.txtFilterXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilterXML.Size = new System.Drawing.Size(383, 162);
            this.txtFilterXML.TabIndex = 15;
            this.txtFilterXML.WordWrap = false;
            // 
            // btnFilterXMLClear
            // 
            this.btnFilterXMLClear.Location = new System.Drawing.Point(325, 187);
            this.btnFilterXMLClear.Name = "btnFilterXMLClear";
            this.btnFilterXMLClear.Size = new System.Drawing.Size(75, 23);
            this.btnFilterXMLClear.TabIndex = 16;
            this.btnFilterXMLClear.Text = "Clear Filters";
            this.btnFilterXMLClear.UseVisualStyleBackColor = true;
            this.btnFilterXMLClear.Click += new System.EventHandler(this.btnFilterXMLClear_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(325, 524);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(102, 30);
            this.btnSendRequest.TabIndex = 18;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(48, 530);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(271, 20);
            this.txtUrl.TabIndex = 17;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 533);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "URL:";
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 566);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.grpFilterXML);
            this.Controls.Add(this.grpFilterBuilder);
            this.Controls.Add(this.grpRequestDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RequestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch API Request Demonstration";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.grpRequestDetails.ResumeLayout(false);
            this.grpRequestDetails.PerformLayout();
            this.grpFilterBuilder.ResumeLayout(false);
            this.grpFilterValue.ResumeLayout(false);
            this.grpFilterValue.PerformLayout();
            this.grpFilterProperties.ResumeLayout(false);
            this.grpFilterProperties.PerformLayout();
            this.grpFilterXML.ResumeLayout(false);
            this.grpFilterXML.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRequestDetails;
        private System.Windows.Forms.ComboBox cmbHttpVerb;
        private System.Windows.Forms.Label lblHttpVerb;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.GroupBox grpFilterBuilder;
        private System.Windows.Forms.GroupBox grpFilterXML;
        private System.Windows.Forms.ComboBox cmbEndpoint;
        private System.Windows.Forms.Label lblEndpoint;
        private System.Windows.Forms.CheckBox chkUseSsl;
        private System.Windows.Forms.GroupBox grpFilterProperties;
        private System.Windows.Forms.Button btnCreateUpdateFilter;
        private System.Windows.Forms.GroupBox grpFilterValue;
        private System.Windows.Forms.CheckBox chkFilterValueBoolean;
        private System.Windows.Forms.DateTimePicker dtpFilterValueDate;
        private System.Windows.Forms.TextBox txtFilterValueCsvString;
        private System.Windows.Forms.RadioButton rdoFilterValueBoolean;
        private System.Windows.Forms.RadioButton rdoFilterValueDate;
        private System.Windows.Forms.RadioButton rdoFilterValueCsvString;
        private System.Windows.Forms.TextBox txtFilterPropertyFilter;
        private System.Windows.Forms.TextBox txtFilterPropertyMethod;
        private System.Windows.Forms.TextBox txtFilterPropertyModule;
        private System.Windows.Forms.Label lblFilterPropertyFIlter;
        private System.Windows.Forms.Label lblFilterPropertyMethod;
        private System.Windows.Forms.Label lblFilterPropertyModule;
        private System.Windows.Forms.TextBox txtFilterXML;
        private System.Windows.Forms.Button btnFilterXMLClear;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.ComboBox cmbApiVersion;
        private System.Windows.Forms.Label lblApiVersion;
        private System.Windows.Forms.Button btnRemoveFilter;
    }
}

