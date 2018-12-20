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
            this.ApiData = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TimestampLabel = new System.Windows.Forms.Label();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.TimestampTextBox = new System.Windows.Forms.TextBox();
            this.LatitudeTextBox = new System.Windows.Forms.TextBox();
            this.LongitudeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GetApi
            // 
            this.GetApi.Location = new System.Drawing.Point(19, 186);
            this.GetApi.Margin = new System.Windows.Forms.Padding(2);
            this.GetApi.Name = "GetApi";
            this.GetApi.Size = new System.Drawing.Size(163, 38);
            this.GetApi.TabIndex = 0;
            this.GetApi.Text = "Get data";
            this.GetApi.UseVisualStyleBackColor = true;
            this.GetApi.Click += new System.EventHandler(this.GetApi_Click);
            // 
            // ApiData
            // 
            this.ApiData.Location = new System.Drawing.Point(82, 15);
            this.ApiData.Margin = new System.Windows.Forms.Padding(2);
            this.ApiData.Multiline = true;
            this.ApiData.Name = "ApiData";
            this.ApiData.Size = new System.Drawing.Size(269, 54);
            this.ApiData.TabIndex = 1;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(26, 74);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message";
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.AutoSize = true;
            this.TimestampLabel.Location = new System.Drawing.Point(18, 100);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(58, 13);
            this.TimestampLabel.TabIndex = 3;
            this.TimestampLabel.Text = "Timestamp";
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.AutoSize = true;
            this.LatitudeLabel.Location = new System.Drawing.Point(31, 126);
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.LatitudeLabel.TabIndex = 4;
            this.LatitudeLabel.Text = "Latitude";
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.Location = new System.Drawing.Point(22, 152);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(54, 13);
            this.LongitudeLabel.TabIndex = 5;
            this.LongitudeLabel.Text = "Longitude";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(82, 74);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(100, 20);
            this.MessageTextBox.TabIndex = 6;
            // 
            // TimestampTextBox
            // 
            this.TimestampTextBox.Location = new System.Drawing.Point(82, 100);
            this.TimestampTextBox.Name = "TimestampTextBox";
            this.TimestampTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimestampTextBox.TabIndex = 7;
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.Location = new System.Drawing.Point(82, 126);
            this.LatitudeTextBox.Name = "LatitudeTextBox";
            this.LatitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.LatitudeTextBox.TabIndex = 8;
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.Location = new System.Drawing.Point(82, 152);
            this.LongitudeTextBox.Name = "LongitudeTextBox";
            this.LongitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudeTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Raw JSON";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Raw Timestamp",
            "Formated Timestamp"});
            this.listBox1.Location = new System.Drawing.Point(197, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 30);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 366);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LongitudeTextBox);
            this.Controls.Add(this.LatitudeTextBox);
            this.Controls.Add(this.TimestampTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.LongitudeLabel);
            this.Controls.Add(this.LatitudeLabel);
            this.Controls.Add(this.TimestampLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ApiData);
            this.Controls.Add(this.GetApi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetApi;
        private System.Windows.Forms.TextBox ApiData;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label TimestampLabel;
        private System.Windows.Forms.Label LatitudeLabel;
        private System.Windows.Forms.Label LongitudeLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox TimestampTextBox;
        private System.Windows.Forms.TextBox LatitudeTextBox;
        private System.Windows.Forms.TextBox LongitudeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}