
namespace MovieDatabase
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.addMovieButton = new System.Windows.Forms.Button();
            this.getMovieButton = new System.Windows.Forms.Button();
            this.buyMovieButton = new System.Windows.Forms.Button();
            this.dataBaseProgress = new System.Windows.Forms.ProgressBar();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(64, 555);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(181, 78);
            this.addMovieButton.TabIndex = 0;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // getMovieButton
            // 
            this.getMovieButton.Location = new System.Drawing.Point(295, 555);
            this.getMovieButton.Name = "getMovieButton";
            this.getMovieButton.Size = new System.Drawing.Size(181, 78);
            this.getMovieButton.TabIndex = 1;
            this.getMovieButton.Text = "Get Movie";
            this.getMovieButton.UseVisualStyleBackColor = true;
            this.getMovieButton.Click += new System.EventHandler(this.getMovieButton_Click);
            // 
            // buyMovieButton
            // 
            this.buyMovieButton.Location = new System.Drawing.Point(180, 439);
            this.buyMovieButton.Name = "buyMovieButton";
            this.buyMovieButton.Size = new System.Drawing.Size(181, 78);
            this.buyMovieButton.TabIndex = 2;
            this.buyMovieButton.Text = "Buy Movie";
            this.buyMovieButton.UseVisualStyleBackColor = true;
            this.buyMovieButton.Click += new System.EventHandler(this.buyMovieButton_Click);
            // 
            // dataBaseProgress
            // 
            this.dataBaseProgress.Location = new System.Drawing.Point(455, 650);
            this.dataBaseProgress.Name = "dataBaseProgress";
            this.dataBaseProgress.Size = new System.Drawing.Size(100, 23);
            this.dataBaseProgress.TabIndex = 3;
            // 
            // picBox
            // 
            this.picBox.Image = global::MovieDatabase.Properties.Resources.camera;
            this.picBox.InitialImage = global::MovieDatabase.Properties.Resources.camera;
            this.picBox.Location = new System.Drawing.Point(190, 149);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(161, 210);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 685);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.dataBaseProgress);
            this.Controls.Add(this.buyMovieButton);
            this.Controls.Add(this.getMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieForm";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button getMovieButton;
        private System.Windows.Forms.Button buyMovieButton;
        private System.Windows.Forms.ProgressBar dataBaseProgress;
        private System.Windows.Forms.PictureBox picBox;
    }
}

