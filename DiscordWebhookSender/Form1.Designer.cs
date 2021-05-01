namespace DiscordWebhookSender
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtURL = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.txtMsg = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.txtName = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveURL = new Siticone.UI.WinForms.SiticoneButton();
            this.btnLoad = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.txtURLName = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURL.DefaultText = "";
            this.txtURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtURL.DisabledState.Parent = this.txtURL;
            this.txtURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtURL.FocusedState.Parent = this.txtURL;
            this.txtURL.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtURL.HoveredState.Parent = this.txtURL;
            this.txtURL.Location = new System.Drawing.Point(64, 91);
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.PlaceholderText = "";
            this.txtURL.SelectedText = "";
            this.txtURL.ShadowDecoration.Parent = this.txtURL;
            this.txtURL.Size = new System.Drawing.Size(205, 22);
            this.txtURL.TabIndex = 0;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(142, 305);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(127, 35);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "Send";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(5, 93);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(28, 15);
            this.siticoneLabel1.TabIndex = 2;
            this.siticoneLabel1.Text = "URL:";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(5, 173);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(49, 15);
            this.siticoneLabel2.TabIndex = 3;
            this.siticoneLabel2.Text = "Message:";
            // 
            // txtMsg
            // 
            this.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMsg.DefaultText = "";
            this.txtMsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMsg.DisabledState.Parent = this.txtMsg;
            this.txtMsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMsg.FocusedState.Parent = this.txtMsg;
            this.txtMsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMsg.HoveredState.Parent = this.txtMsg;
            this.txtMsg.Location = new System.Drawing.Point(64, 173);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.PasswordChar = '\0';
            this.txtMsg.PlaceholderText = "";
            this.txtMsg.SelectedText = "";
            this.txtMsg.ShadowDecoration.Parent = this.txtMsg;
            this.txtMsg.Size = new System.Drawing.Size(205, 126);
            this.txtMsg.TabIndex = 4;
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.Location = new System.Drawing.Point(5, 147);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(51, 15);
            this.siticoneLabel3.TabIndex = 6;
            this.siticoneLabel3.Text = "Bot name:";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoveredState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(64, 145);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(205, 22);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Made by";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(80, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Laugny";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Discord webhook sender";
            // 
            // btnSaveURL
            // 
            this.btnSaveURL.CheckedState.Parent = this.btnSaveURL;
            this.btnSaveURL.CustomImages.Parent = this.btnSaveURL;
            this.btnSaveURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveURL.ForeColor = System.Drawing.Color.White;
            this.btnSaveURL.HoveredState.Parent = this.btnSaveURL;
            this.btnSaveURL.Location = new System.Drawing.Point(195, 119);
            this.btnSaveURL.Name = "btnSaveURL";
            this.btnSaveURL.ShadowDecoration.Parent = this.btnSaveURL;
            this.btnSaveURL.Size = new System.Drawing.Size(74, 19);
            this.btnSaveURL.TabIndex = 10;
            this.btnSaveURL.Text = "Save";
            this.btnSaveURL.Click += new System.EventHandler(this.btnSaveURL_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.CheckedState.Parent = this.btnLoad;
            this.btnLoad.CustomImages.Parent = this.btnLoad;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.HoveredState.Parent = this.btnLoad;
            this.btnLoad.Location = new System.Drawing.Point(115, 119);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowDecoration.Parent = this.btnLoad;
            this.btnLoad.Size = new System.Drawing.Size(74, 19);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.Location = new System.Drawing.Point(5, 67);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(34, 15);
            this.siticoneLabel4.TabIndex = 12;
            this.siticoneLabel4.Text = "Name:";
            // 
            // txtURLName
            // 
            this.txtURLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtURLName.DefaultText = "";
            this.txtURLName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtURLName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtURLName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtURLName.DisabledState.Parent = this.txtURLName;
            this.txtURLName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtURLName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtURLName.FocusedState.Parent = this.txtURLName;
            this.txtURLName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtURLName.HoveredState.Parent = this.txtURLName;
            this.txtURLName.Location = new System.Drawing.Point(64, 65);
            this.txtURLName.Name = "txtURLName";
            this.txtURLName.PasswordChar = '\0';
            this.txtURLName.PlaceholderText = "";
            this.txtURLName.SelectedText = "";
            this.txtURLName.ShadowDecoration.Parent = this.txtURLName;
            this.txtURLName.Size = new System.Drawing.Size(205, 22);
            this.txtURLName.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 359);
            this.Controls.Add(this.txtURLName);
            this.Controls.Add(this.siticoneLabel4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.txtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Webhook Sender V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtURL;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneTextBox txtMsg;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton btnSaveURL;
        private Siticone.UI.WinForms.SiticoneButton btnLoad;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtURLName;
    }
}

