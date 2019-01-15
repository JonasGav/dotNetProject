namespace dotNetProject
{
    partial class Form1
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
            this.GetApi = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TimestampLabel = new System.Windows.Forms.Label();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.TimestampTextBox = new System.Windows.Forms.TextBox();
            this.LatitudeTextBox = new System.Windows.Forms.TextBox();
            this.LongitudeTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Country = new System.Windows.Forms.Label();
            this.CountryTag = new System.Windows.Forms.Label();
            this.CountryTagTxt = new System.Windows.Forms.TextBox();
            this.CountryNameTxt = new System.Windows.Forms.TextBox();
            this.ErrorTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetApi
            // 
            this.GetApi.Location = new System.Drawing.Point(35, 301);
            this.GetApi.Margin = new System.Windows.Forms.Padding(2);
            this.GetApi.Name = "GetApi";
            this.GetApi.Size = new System.Drawing.Size(304, 38);
            this.GetApi.TabIndex = 0;
            this.GetApi.Text = "Get data";
            this.GetApi.UseVisualStyleBackColor = true;
            this.GetApi.Click += new System.EventHandler(this.GetApi_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(54, 128);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message";
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.AutoSize = true;
            this.TimestampLabel.Location = new System.Drawing.Point(46, 154);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(58, 13);
            this.TimestampLabel.TabIndex = 3;
            this.TimestampLabel.Text = "Timestamp";
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.AutoSize = true;
            this.LatitudeLabel.Location = new System.Drawing.Point(59, 180);
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.LatitudeLabel.TabIndex = 4;
            this.LatitudeLabel.Text = "Latitude";
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.Location = new System.Drawing.Point(50, 206);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(54, 13);
            this.LongitudeLabel.TabIndex = 5;
            this.LongitudeLabel.Text = "Longitude";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(110, 128);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(100, 20);
            this.MessageTextBox.TabIndex = 6;
            // 
            // TimestampTextBox
            // 
            this.TimestampTextBox.Location = new System.Drawing.Point(110, 154);
            this.TimestampTextBox.Name = "TimestampTextBox";
            this.TimestampTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimestampTextBox.TabIndex = 7;
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.Location = new System.Drawing.Point(110, 180);
            this.LatitudeTextBox.Name = "LatitudeTextBox";
            this.LatitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.LatitudeTextBox.TabIndex = 8;
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.Location = new System.Drawing.Point(110, 206);
            this.LongitudeTextBox.Name = "LongitudeTextBox";
            this.LongitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudeTextBox.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Raw Timestamp",
            "Formated Timestamp"});
            this.listBox1.Location = new System.Drawing.Point(231, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 30);
            this.listBox1.TabIndex = 12;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(32, 105);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(72, 13);
            this.Country.TabIndex = 13;
            this.Country.Text = "Country name";
            this.Country.Click += new System.EventHandler(this.Country_Click);
            // 
            // CountryTag
            // 
            this.CountryTag.AutoSize = true;
            this.CountryTag.Location = new System.Drawing.Point(40, 80);
            this.CountryTag.Name = "CountryTag";
            this.CountryTag.Size = new System.Drawing.Size(61, 13);
            this.CountryTag.TabIndex = 14;
            this.CountryTag.Text = "Country tag";
            // 
            // CountryTagTxt
            // 
            this.CountryTagTxt.Location = new System.Drawing.Point(110, 77);
            this.CountryTagTxt.Name = "CountryTagTxt";
            this.CountryTagTxt.Size = new System.Drawing.Size(100, 20);
            this.CountryTagTxt.TabIndex = 15;
            // 
            // CountryNameTxt
            // 
            this.CountryNameTxt.Location = new System.Drawing.Point(110, 102);
            this.CountryNameTxt.Name = "CountryNameTxt";
            this.CountryNameTxt.Size = new System.Drawing.Size(100, 20);
            this.CountryNameTxt.TabIndex = 16;
            // 
            // ErrorTxt
            // 
            this.ErrorTxt.AutoSize = true;
            this.ErrorTxt.Location = new System.Drawing.Point(160, 9);
            this.ErrorTxt.Name = "ErrorTxt";
            this.ErrorTxt.Size = new System.Drawing.Size(50, 13);
            this.ErrorTxt.TabIndex = 17;
            this.ErrorTxt.Text = "No errors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 366);
            this.Controls.Add(this.ErrorTxt);
            this.Controls.Add(this.CountryNameTxt);
            this.Controls.Add(this.CountryTagTxt);
            this.Controls.Add(this.CountryTag);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LongitudeTextBox);
            this.Controls.Add(this.LatitudeTextBox);
            this.Controls.Add(this.TimestampTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.LongitudeLabel);
            this.Controls.Add(this.LatitudeLabel);
            this.Controls.Add(this.TimestampLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.GetApi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetApi;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label TimestampLabel;
        private System.Windows.Forms.Label LatitudeLabel;
        private System.Windows.Forms.Label LongitudeLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox TimestampTextBox;
        private System.Windows.Forms.TextBox LatitudeTextBox;
        private System.Windows.Forms.TextBox LongitudeTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label CountryTag;
        private System.Windows.Forms.TextBox CountryTagTxt;
        private System.Windows.Forms.TextBox CountryNameTxt;
        private System.Windows.Forms.Label ErrorTxt;
    }
}