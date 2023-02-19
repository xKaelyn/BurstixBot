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
            this.submitICAO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.icaoTo = new BurstixBot.PlaceHolderTextBox();
            this.icaoFrom = new BurstixBot.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // initialiseBotButton
            // 
            this.initialiseBotButton.BackColor = System.Drawing.Color.HotPink;
            this.initialiseBotButton.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.initialiseBotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initialiseBotButton.Font = new System.Drawing.Font("Gilroy-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialiseBotButton.ForeColor = System.Drawing.Color.White;
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
            this.formLogBox.BackColor = System.Drawing.Color.SteelBlue;
            this.formLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formLogBox.Font = new System.Drawing.Font("QualityWings787DispS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLogBox.ForeColor = System.Drawing.Color.HotPink;
            this.formLogBox.Location = new System.Drawing.Point(12, 150);
            this.formLogBox.Name = "formLogBox";
            this.formLogBox.ReadOnly = true;
            this.formLogBox.Size = new System.Drawing.Size(489, 275);
            this.formLogBox.TabIndex = 1;
            this.formLogBox.Text = "";
            // 
            // submitICAO
            // 
            this.submitICAO.BackColor = System.Drawing.Color.HotPink;
            this.submitICAO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.submitICAO.FlatAppearance.BorderSize = 0;
            this.submitICAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitICAO.Font = new System.Drawing.Font("Gilroy-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitICAO.ForeColor = System.Drawing.Color.White;
            this.submitICAO.Location = new System.Drawing.Point(13, 93);
            this.submitICAO.Name = "submitICAO";
            this.submitICAO.Size = new System.Drawing.Size(488, 23);
            this.submitICAO.TabIndex = 4;
            this.submitICAO.Text = "Submit ICAO Information";
            this.submitICAO.UseVisualStyleBackColor = false;
            this.submitICAO.Click += new System.EventHandler(this.submitICAO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy-Light", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(55, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Below is the log box - certain information will be posted here";
            // 
            // icaoTo
            // 
            this.icaoTo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.icaoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.icaoTo.ForeColor = System.Drawing.Color.Gray;
            this.icaoTo.Location = new System.Drawing.Point(12, 67);
            this.icaoTo.Name = "icaoTo";
            this.icaoTo.PlaceHolderText = "Airport ICAO you\'re flying towards...";
            this.icaoTo.Size = new System.Drawing.Size(489, 20);
            this.icaoTo.TabIndex = 9;
            this.icaoTo.Text = "Airport ICAO you\'re flying towards...";
            this.icaoTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // icaoFrom
            // 
            this.icaoFrom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.icaoFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.icaoFrom.ForeColor = System.Drawing.Color.Gray;
            this.icaoFrom.Location = new System.Drawing.Point(12, 41);
            this.icaoFrom.Name = "icaoFrom";
            this.icaoFrom.PlaceHolderText = "Airport ICAO you\'re flying from...";
            this.icaoFrom.Size = new System.Drawing.Size(489, 20);
            this.icaoFrom.TabIndex = 8;
            this.icaoFrom.Text = "Airport ICAO you\'re flying from...";
            this.icaoFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BurstixBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(513, 437);
            this.Controls.Add(this.icaoTo);
            this.Controls.Add(this.icaoFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitICAO);
            this.Controls.Add(this.formLogBox);
            this.Controls.Add(this.initialiseBotButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BurstixBotForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "BurstixBot | Version 0.2 | Developed by iKaelyn_xo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initialiseBotButton;
        private System.Windows.Forms.RichTextBox formLogBox;
        private System.Windows.Forms.Button submitICAO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PlaceHolderTextBox icaoFrom;
        private PlaceHolderTextBox icaoTo;
    }
}

