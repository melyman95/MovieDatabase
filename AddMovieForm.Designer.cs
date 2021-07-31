
namespace MovieDatabase
{
    partial class AddMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovieForm));
            this.addMovieButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.releaseYearBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.runtimeBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.releaseYear = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Runtime = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(118, 569);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(321, 104);
            this.addMovieButton.TabIndex = 0;
            this.addMovieButton.Text = "Add";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(118, 63);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(321, 26);
            this.titleBox.TabIndex = 1;
            // 
            // releaseYearBox
            // 
            this.releaseYearBox.Location = new System.Drawing.Point(118, 151);
            this.releaseYearBox.Name = "releaseYearBox";
            this.releaseYearBox.Size = new System.Drawing.Size(321, 26);
            this.releaseYearBox.TabIndex = 2;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(118, 250);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(321, 26);
            this.ratingBox.TabIndex = 3;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(118, 338);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(321, 26);
            this.genreBox.TabIndex = 4;
            // 
            // runtimeBox
            // 
            this.runtimeBox.Location = new System.Drawing.Point(118, 431);
            this.runtimeBox.Name = "runtimeBox";
            this.runtimeBox.Size = new System.Drawing.Size(321, 26);
            this.runtimeBox.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(33, 63);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(38, 20);
            this.Title.TabIndex = 6;
            this.Title.Text = "Title";
            // 
            // releaseYear
            // 
            this.releaseYear.AutoSize = true;
            this.releaseYear.Location = new System.Drawing.Point(6, 151);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(106, 20);
            this.releaseYear.TabIndex = 7;
            this.releaseYear.Text = "Release Year";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(33, 250);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(56, 20);
            this.Rating.TabIndex = 8;
            this.Rating.Text = "Rating";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(33, 338);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(54, 20);
            this.Genre.TabIndex = 9;
            this.Genre.Text = "Genre";
            // 
            // Runtime
            // 
            this.Runtime.AutoSize = true;
            this.Runtime.Location = new System.Drawing.Point(33, 431);
            this.Runtime.Name = "Runtime";
            this.Runtime.Size = new System.Drawing.Size(69, 20);
            this.Runtime.TabIndex = 10;
            this.Runtime.Text = "Runtime";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(118, 509);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(321, 26);
            this.priceBox.TabIndex = 11;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(33, 509);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 12;
            this.Price.Text = "Price";
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 685);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.Runtime);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.releaseYear);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.runtimeBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.releaseYearBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.addMovieButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox releaseYearBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox runtimeBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label releaseYear;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Runtime;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label Price;
    }
}