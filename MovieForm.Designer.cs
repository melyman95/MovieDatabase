
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
            this.newCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(43, 361);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(121, 51);
            this.addMovieButton.TabIndex = 0;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // getMovieButton
            // 
            this.getMovieButton.Location = new System.Drawing.Point(197, 361);
            this.getMovieButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getMovieButton.Name = "getMovieButton";
            this.getMovieButton.Size = new System.Drawing.Size(121, 51);
            this.getMovieButton.TabIndex = 1;
            this.getMovieButton.Text = "Get Movie";
            this.getMovieButton.UseVisualStyleBackColor = true;
            this.getMovieButton.Click += new System.EventHandler(this.getMovieButton_Click);
            // 
            // buyMovieButton
            // 
            this.buyMovieButton.Location = new System.Drawing.Point(120, 285);
            this.buyMovieButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buyMovieButton.Name = "buyMovieButton";
            this.buyMovieButton.Size = new System.Drawing.Size(121, 51);
            this.buyMovieButton.TabIndex = 2;
            this.buyMovieButton.Text = "Buy Movie";
            this.buyMovieButton.UseVisualStyleBackColor = true;
            this.buyMovieButton.Click += new System.EventHandler(this.buyMovieButton_Click);
            // 
            // dataBaseProgress
            // 
            this.dataBaseProgress.Location = new System.Drawing.Point(303, 422);
            this.dataBaseProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataBaseProgress.Name = "dataBaseProgress";
            this.dataBaseProgress.Size = new System.Drawing.Size(67, 15);
            this.dataBaseProgress.TabIndex = 3;
            // 
            // picBox
            // 
            this.picBox.Image = global::MovieDatabase.Properties.Resources.camera;
            this.picBox.InitialImage = global::MovieDatabase.Properties.Resources.camera;
            this.picBox.Location = new System.Drawing.Point(112, 102);
            this.picBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(150, 136);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(112, 22);
            this.newCustomerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(145, 48);
            this.newCustomerButton.TabIndex = 5;
            this.newCustomerButton.Text = "Update Movies";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 445);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.dataBaseProgress);
            this.Controls.Add(this.buyMovieButton);
            this.Controls.Add(this.getMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button newCustomerButton;
    }
}

