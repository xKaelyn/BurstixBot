namespace BurstixBot
{
    partial class BurstixBotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurstixBotForm));
            this.initialiseBotButton = new System.Windows.Forms.Button();
            this.formLogBox = new System.Windows.Forms.RichTextBox();
            this.icaoFrom = new System.Windows.Forms.TextBox();
            this.icaoTo = new System.Windows.Forms.TextBox();
            this.submitICAO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialiseBotButton
            // 
            this.initialiseBotButton.BackColor = System.Drawing.Color.HotPink;
            this.initialiseBotButton.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.initialiseBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.initialiseBotButton.Location = new System.Drawing.Point(12, 12);
            this.initialiseBotButton.Name = "initialiseBotButton";
            this.initialiseBotButton.Size = new System.Drawing.Size(489, 23);
            this.initialiseBotButton.TabIndex = 0;
            this.initialiseBotButton.Text = "Initialize Bot";
            this.initialiseBotButton.UseVisualStyleBackColor = false;
            this.initialiseBotButton.Click += new System.EventHandler(this.initialiseBotButton_Click);
            // 
            // formLogBox
            // 
            this.formLogBox.Location = new System.Drawing.Point(12, 124);
            this.formLogBox.Name = "formLogBox";
            this.formLogBox.Size = new System.Drawing.Size(489, 301);
            this.formLogBox.TabIndex = 1;
            this.formLogBox.Text = "";
            // 
            // icaoFrom
            // 
            this.icaoFrom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.icaoFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.icaoFrom.Location = new System.Drawing.Point(13, 42);
            this.icaoFrom.Name = "icaoFrom";
            this.icaoFrom.Size = new System.Drawing.Size(488, 20);
            this.icaoFrom.TabIndex = 2;
            this.icaoFrom.Text = "FROM";
            this.icaoFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // icaoTo
            // 
            this.icaoTo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.icaoTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.icaoTo.Location = new System.Drawing.Point(13, 69);
            this.icaoTo.Name = "icaoTo";
            this.icaoTo.Size = new System.Drawing.Size(488, 20);
            this.icaoTo.TabIndex = 3;
            this.icaoTo.Text = "TO";
            this.icaoTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitICAO
            // 
            this.submitICAO.BackColor = System.Drawing.Color.HotPink;
            this.submitICAO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.submitICAO.FlatAppearance.BorderSize = 0;
            this.submitICAO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitICAO.Location = new System.Drawing.Point(13, 95);
            this.submitICAO.Name = "submitICAO";
            this.submitICAO.Size = new System.Drawing.Size(488, 23);
            this.submitICAO.TabIndex = 4;
            this.submitICAO.Text = "Submit ICAO";
            this.submitICAO.UseVisualStyleBackColor = false;
            this.submitICAO.Click += new System.EventHandler(this.submitICAO_Click);
            // 
            // BurstixBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(513, 437);
            this.Controls.Add(this.submitICAO);
            this.Controls.Add(this.icaoTo);
            this.Controls.Add(this.icaoFrom);
            this.Controls.Add(this.formLogBox);
            this.Controls.Add(this.initialiseBotButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BurstixBotForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "BurstixBot | Version 0.1 | Developed by iKaelyn_xo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initialiseBotButton;
        private System.Windows.Forms.RichTextBox formLogBox;
        private System.Windows.Forms.TextBox icaoFrom;
        private System.Windows.Forms.TextBox icaoTo;
        private System.Windows.Forms.Button submitICAO;
    }
}

