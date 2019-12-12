namespace iSAMS.BatchAPI.Demo.UI
{
    partial class ResponseForm
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
            this.grpHttpResponse = new System.Windows.Forms.GroupBox();
            this.lblResponseCode = new System.Windows.Forms.Label();
            this.grpResponseData = new System.Windows.Forms.GroupBox();
            this.txtResponseData = new System.Windows.Forms.TextBox();
            this.grpMediaType = new System.Windows.Forms.GroupBox();
            this.lblMediaType = new System.Windows.Forms.Label();
            this.grpHttpResponse.SuspendLayout();
            this.grpResponseData.SuspendLayout();
            this.grpMediaType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHttpResponse
            // 
            this.grpHttpResponse.Controls.Add(this.lblResponseCode);
            this.grpHttpResponse.Location = new System.Drawing.Point(13, 12);
            this.grpHttpResponse.Name = "grpHttpResponse";
            this.grpHttpResponse.Size = new System.Drawing.Size(354, 42);
            this.grpHttpResponse.TabIndex = 0;
            this.grpHttpResponse.TabStop = false;
            this.grpHttpResponse.Text = "Response Code";
            // 
            // lblResponseCode
            // 
            this.lblResponseCode.Location = new System.Drawing.Point(6, 16);
            this.lblResponseCode.Name = "lblResponseCode";
            this.lblResponseCode.Size = new System.Drawing.Size(342, 16);
            this.lblResponseCode.TabIndex = 0;
            this.lblResponseCode.Text = "Processing...";
            this.lblResponseCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpResponseData
            // 
            this.grpResponseData.Controls.Add(this.txtResponseData);
            this.grpResponseData.Location = new System.Drawing.Point(13, 108);
            this.grpResponseData.Name = "grpResponseData";
            this.grpResponseData.Size = new System.Drawing.Size(354, 273);
            this.grpResponseData.TabIndex = 1;
            this.grpResponseData.TabStop = false;
            this.grpResponseData.Text = "Response Data";
            // 
            // txtResponseData
            // 
            this.txtResponseData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponseData.Location = new System.Drawing.Point(7, 20);
            this.txtResponseData.Multiline = true;
            this.txtResponseData.Name = "txtResponseData";
            this.txtResponseData.ReadOnly = true;
            this.txtResponseData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponseData.Size = new System.Drawing.Size(341, 247);
            this.txtResponseData.TabIndex = 0;
            this.txtResponseData.WordWrap = false;
            // 
            // grpMediaType
            // 
            this.grpMediaType.Controls.Add(this.lblMediaType);
            this.grpMediaType.Location = new System.Drawing.Point(13, 60);
            this.grpMediaType.Name = "grpMediaType";
            this.grpMediaType.Size = new System.Drawing.Size(354, 42);
            this.grpMediaType.TabIndex = 2;
            this.grpMediaType.TabStop = false;
            this.grpMediaType.Text = "Media Type";
            // 
            // lblMediaType
            // 
            this.lblMediaType.Location = new System.Drawing.Point(6, 16);
            this.lblMediaType.Name = "lblMediaType";
            this.lblMediaType.Size = new System.Drawing.Size(342, 16);
            this.lblMediaType.TabIndex = 0;
            this.lblMediaType.Text = "Processing...";
            this.lblMediaType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 394);
            this.Controls.Add(this.grpMediaType);
            this.Controls.Add(this.grpResponseData);
            this.Controls.Add(this.grpHttpResponse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResponseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batch API Response";
            this.grpHttpResponse.ResumeLayout(false);
            this.grpResponseData.ResumeLayout(false);
            this.grpResponseData.PerformLayout();
            this.grpMediaType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHttpResponse;
        private System.Windows.Forms.Label lblResponseCode;
        private System.Windows.Forms.GroupBox grpResponseData;
        private System.Windows.Forms.GroupBox grpMediaType;
        private System.Windows.Forms.Label lblMediaType;
        private System.Windows.Forms.TextBox txtResponseData;
    }
}