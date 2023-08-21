using System;
using System.Windows.Forms;

namespace LoginWinForms.Forms
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.labAccessToken = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.txtExpiresIn = new System.Windows.Forms.TextBox();
            this.labExpiresIn = new System.Windows.Forms.Label();
            this.labRefreshToken = new System.Windows.Forms.Label();
            this.txtRefreshToken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labAccessToken
            // 
            this.labAccessToken.AutoSize = true;
            this.labAccessToken.BackColor = System.Drawing.Color.Transparent;
            this.labAccessToken.Location = new System.Drawing.Point(19, 25);
            this.labAccessToken.Name = "labAccessToken";
            this.labAccessToken.Size = new System.Drawing.Size(70, 13);
            this.labAccessToken.TabIndex = 0;
            this.labAccessToken.Text = "Acces token:";
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessToken.Location = new System.Drawing.Point(95, 22);
            this.txtAccessToken.Multiline = true;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.ReadOnly = true;
            this.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAccessToken.Size = new System.Drawing.Size(893, 132);
            this.txtAccessToken.TabIndex = 4;
            // 
            // txtExpiresIn
            // 
            this.txtExpiresIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExpiresIn.Location = new System.Drawing.Point(95, 173);
            this.txtExpiresIn.Name = "txtExpiresIn";
            this.txtExpiresIn.ReadOnly = true;
            this.txtExpiresIn.Size = new System.Drawing.Size(80, 20);
            this.txtExpiresIn.TabIndex = 5;
            // 
            // labExpiresIn
            // 
            this.labExpiresIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labExpiresIn.AutoSize = true;
            this.labExpiresIn.BackColor = System.Drawing.Color.Transparent;
            this.labExpiresIn.Location = new System.Drawing.Point(34, 176);
            this.labExpiresIn.Name = "labExpiresIn";
            this.labExpiresIn.Size = new System.Drawing.Size(55, 13);
            this.labExpiresIn.TabIndex = 9;
            this.labExpiresIn.Text = "Expires in:";
            // 
            // labRefreshToken
            // 
            this.labRefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labRefreshToken.AutoSize = true;
            this.labRefreshToken.BackColor = System.Drawing.Color.Transparent;
            this.labRefreshToken.Location = new System.Drawing.Point(543, 176);
            this.labRefreshToken.Name = "labRefreshToken";
            this.labRefreshToken.Size = new System.Drawing.Size(77, 13);
            this.labRefreshToken.TabIndex = 32;
            this.labRefreshToken.Text = "Refresh token:";
            // 
            // txtRefreshToken
            // 
            this.txtRefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefreshToken.Location = new System.Drawing.Point(626, 173);
            this.txtRefreshToken.Name = "txtRefreshToken";
            this.txtRefreshToken.ReadOnly = true;
            this.txtRefreshToken.Size = new System.Drawing.Size(362, 20);
            this.txtRefreshToken.TabIndex = 31;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginWinForms.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 214);
            this.Controls.Add(this.labRefreshToken);
            this.Controls.Add(this.txtRefreshToken);
            this.Controls.Add(this.txtExpiresIn);
            this.Controls.Add(this.labExpiresIn);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.labAccessToken);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wolters Kluwer España";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label   labAccessToken;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.TextBox txtExpiresIn;
        private System.Windows.Forms.Label   labExpiresIn;
        private System.Windows.Forms.Label   labRefreshToken;
        private System.Windows.Forms.TextBox txtRefreshToken;

        #endregion
    }
}