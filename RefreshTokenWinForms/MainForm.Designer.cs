using System.Windows.Forms;

namespace RefreshTokenWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labAccessToken = new System.Windows.Forms.Label();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.txtRefreshToken = new System.Windows.Forms.TextBox();
            this.txtExpiresIn = new System.Windows.Forms.TextBox();
            this.labExpiresIn = new System.Windows.Forms.Label();
            this.panButtonArea = new System.Windows.Forms.Panel();
            this.btnGetNewAccessToken = new System.Windows.Forms.Button();
            this.picSeparator = new System.Windows.Forms.PictureBox();
            this.labRefreshToken = new System.Windows.Forms.Label();
            this.labRefreshTokenNew = new System.Windows.Forms.Label();
            this.txtRefreshTokenNew = new System.Windows.Forms.TextBox();
            this.panButtonArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // labAccessToken
            // 
            this.labAccessToken.AutoSize = true;
            this.labAccessToken.BackColor = System.Drawing.Color.Transparent;
            this.labAccessToken.Location = new System.Drawing.Point(19, 83);
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
            this.txtAccessToken.Location = new System.Drawing.Point(95, 80);
            this.txtAccessToken.Multiline = true;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.ReadOnly = true;
            this.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAccessToken.Size = new System.Drawing.Size(893, 251);
            this.txtAccessToken.TabIndex = 4;
            // 
            // txtRefreshToken
            // 
            this.txtRefreshToken.Location = new System.Drawing.Point(95, 16);
            this.txtRefreshToken.Name = "txtRefreshToken";
            this.txtRefreshToken.Size = new System.Drawing.Size(362, 20);
            this.txtRefreshToken.TabIndex = 2;
            // 
            // txtExpiresIn
            // 
            this.txtExpiresIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExpiresIn.Location = new System.Drawing.Point(95, 350);
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
            this.labExpiresIn.Location = new System.Drawing.Point(34, 353);
            this.labExpiresIn.Name = "labExpiresIn";
            this.labExpiresIn.Size = new System.Drawing.Size(55, 13);
            this.labExpiresIn.TabIndex = 9;
            this.labExpiresIn.Text = "Expires in:";
            // 
            // panButtonArea
            // 
            this.panButtonArea.BackgroundImage = global::RefreshTokenWinForms.Properties.Resources.Botonera;
            this.panButtonArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panButtonArea.Controls.Add(this.btnGetNewAccessToken);
            this.panButtonArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtonArea.Location = new System.Drawing.Point(0, 391);
            this.panButtonArea.Name = "panButtonArea";
            this.panButtonArea.Size = new System.Drawing.Size(1008, 60);
            this.panButtonArea.TabIndex = 20;
            // 
            // btnGetNewAccessToken
            // 
            this.btnGetNewAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetNewAccessToken.Location = new System.Drawing.Point(838, 16);
            this.btnGetNewAccessToken.Name = "btnGetNewAccessToken";
            this.btnGetNewAccessToken.Size = new System.Drawing.Size(150, 28);
            this.btnGetNewAccessToken.TabIndex = 5;
            this.btnGetNewAccessToken.Text = "Get New Access Token";
            this.btnGetNewAccessToken.UseVisualStyleBackColor = true;
            this.btnGetNewAccessToken.Click += new System.EventHandler(this.btnGetNewAccessToken_Click);
            // 
            // picSeparator
            // 
            this.picSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSeparator.BackColor = System.Drawing.Color.Transparent;
            this.picSeparator.BackgroundImage = global::RefreshTokenWinForms.Properties.Resources.Separador;
            this.picSeparator.Location = new System.Drawing.Point(0, 55);
            this.picSeparator.Name = "picSeparator";
            this.picSeparator.Size = new System.Drawing.Size(1008, 6);
            this.picSeparator.TabIndex = 21;
            this.picSeparator.TabStop = false;
            // 
            // labRefreshToken
            // 
            this.labRefreshToken.AutoSize = true;
            this.labRefreshToken.BackColor = System.Drawing.Color.Transparent;
            this.labRefreshToken.Location = new System.Drawing.Point(12, 19);
            this.labRefreshToken.Name = "labRefreshToken";
            this.labRefreshToken.Size = new System.Drawing.Size(77, 13);
            this.labRefreshToken.TabIndex = 30;
            this.labRefreshToken.Text = "Refresh token:";
            // 
            // labRefreshTokenNew
            // 
            this.labRefreshTokenNew.AutoSize = true;
            this.labRefreshTokenNew.BackColor = System.Drawing.Color.Transparent;
            this.labRefreshTokenNew.Location = new System.Drawing.Point(543, 353);
            this.labRefreshTokenNew.Name = "labRefreshTokenNew";
            this.labRefreshTokenNew.Size = new System.Drawing.Size(77, 13);
            this.labRefreshTokenNew.TabIndex = 32;
            this.labRefreshTokenNew.Text = "Refresh token:";
            // 
            // txtRefreshTokenNew
            // 
            this.txtRefreshTokenNew.Location = new System.Drawing.Point(626, 350);
            this.txtRefreshTokenNew.Name = "txtRefreshTokenNew";
            this.txtRefreshTokenNew.ReadOnly = true;
            this.txtRefreshTokenNew.Size = new System.Drawing.Size(362, 20);
            this.txtRefreshTokenNew.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGetNewAccessToken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RefreshTokenWinForms.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 451);
            this.Controls.Add(this.labRefreshTokenNew);
            this.Controls.Add(this.txtRefreshTokenNew);
            this.Controls.Add(this.labRefreshToken);
            this.Controls.Add(this.picSeparator);
            this.Controls.Add(this.panButtonArea);
            this.Controls.Add(this.txtExpiresIn);
            this.Controls.Add(this.labExpiresIn);
            this.Controls.Add(this.txtRefreshToken);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.labAccessToken);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wolters Kluwer España";
            this.panButtonArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSeparator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label labAccessToken;
        private TextBox txtAccessToken;
        private TextBox txtRefreshToken;
        private TextBox txtExpiresIn;
        private Label labExpiresIn;
        private Panel panButtonArea;
        private Button btnGetNewAccessToken;
        private PictureBox picSeparator;
        private Label labRefreshToken;
        private Label labRefreshTokenNew;
        private TextBox txtRefreshTokenNew;

        #endregion
    }
}

