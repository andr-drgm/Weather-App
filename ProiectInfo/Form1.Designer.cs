namespace ProiectInfo
{
    partial class MainPage
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
            this.searchCityBox = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.Label();
            this.temperatureText = new System.Windows.Forms.Label();
            this.weatherText = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.searchBoxButton = new System.Windows.Forms.PictureBox();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.countryText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCityBox
            // 
            this.searchCityBox.BackColor = System.Drawing.Color.LightBlue;
            this.searchCityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchCityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCityBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchCityBox.Location = new System.Drawing.Point(266, 12);
            this.searchCityBox.Name = "searchCityBox";
            this.searchCityBox.Size = new System.Drawing.Size(188, 42);
            this.searchCityBox.TabIndex = 0;
            this.searchCityBox.Text = "Search";
            // 
            // cityText
            // 
            this.cityText.AutoSize = true;
            this.cityText.BackColor = System.Drawing.Color.Transparent;
            this.cityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityText.ForeColor = System.Drawing.Color.White;
            this.cityText.Location = new System.Drawing.Point(12, 23);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(0, 39);
            this.cityText.TabIndex = 1;
            // 
            // temperatureText
            // 
            this.temperatureText.AutoSize = true;
            this.temperatureText.BackColor = System.Drawing.Color.Transparent;
            this.temperatureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureText.ForeColor = System.Drawing.Color.White;
            this.temperatureText.Location = new System.Drawing.Point(78, 185);
            this.temperatureText.Name = "temperatureText";
            this.temperatureText.Size = new System.Drawing.Size(0, 108);
            this.temperatureText.TabIndex = 4;
            // 
            // weatherText
            // 
            this.weatherText.AutoSize = true;
            this.weatherText.BackColor = System.Drawing.Color.Transparent;
            this.weatherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherText.ForeColor = System.Drawing.Color.White;
            this.weatherText.Location = new System.Drawing.Point(201, 91);
            this.weatherText.Name = "weatherText";
            this.weatherText.Size = new System.Drawing.Size(159, 42);
            this.weatherText.TabIndex = 5;
            this.weatherText.Text = "Weather";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.BackColor = System.Drawing.Color.Transparent;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.Color.White;
            this.statusText.Location = new System.Drawing.Point(350, 215);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 42);
            this.statusText.TabIndex = 7;
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::ProiectInfo.Properties.Resources.baseline_exit_to_app_black_48dp;
            this.exitButton.Location = new System.Drawing.Point(516, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchBoxButton
            // 
            this.searchBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.searchBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBoxButton.Image = global::ProiectInfo.Properties.Resources.baseline_search_black_48dp;
            this.searchBoxButton.Location = new System.Drawing.Point(460, 12);
            this.searchBoxButton.Name = "searchBoxButton";
            this.searchBoxButton.Size = new System.Drawing.Size(50, 50);
            this.searchBoxButton.TabIndex = 2;
            this.searchBoxButton.TabStop = false;
            this.searchBoxButton.Click += new System.EventHandler(this.searchBoxButton_Click);
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon.Location = new System.Drawing.Point(176, 311);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(214, 175);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherIcon.TabIndex = 8;
            this.weatherIcon.TabStop = false;
            // 
            // countryText
            // 
            this.countryText.AutoSize = true;
            this.countryText.BackColor = System.Drawing.Color.Transparent;
            this.countryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryText.ForeColor = System.Drawing.Color.White;
            this.countryText.Location = new System.Drawing.Point(491, 486);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(0, 42);
            this.countryText.TabIndex = 9;
            this.countryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProiectInfo.Properties.Resources.baseline_info_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(19, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ProiectInfo.Properties.Resources._3fa4bbe9_b722_4596_85c6_41e08c93afc3;
            this.ClientSize = new System.Drawing.Size(573, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.weatherText);
            this.Controls.Add(this.temperatureText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchBoxButton);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.searchCityBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vremea";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBoxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchCityBox;
        private System.Windows.Forms.Label cityText;
        private System.Windows.Forms.PictureBox searchBoxButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label temperatureText;
        private System.Windows.Forms.Label weatherText;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label countryText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

