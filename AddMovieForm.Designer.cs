
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
            this.addMovieButton.Location = new System.Drawing.Point(79, 370);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(214, 68);
            this.addMovieButton.TabIndex = 0;
            this.addMovieButton.Text = "Add";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(79, 41);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(215, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // releaseYearBox
            // 
            this.releaseYearBox.Location = new System.Drawing.Point(79, 98);
            this.releaseYearBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.releaseYearBox.Name = "releaseYearBox";
            this.releaseYearBox.Size = new System.Drawing.Size(215, 20);
            this.releaseYearBox.TabIndex = 2;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(79, 162);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(215, 20);
            this.ratingBox.TabIndex = 3;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(79, 220);
            this.genreBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(215, 20);
            this.genreBox.TabIndex = 4;
            // 
            // runtimeBox
            // 
            this.runtimeBox.Location = new System.Drawing.Point(79, 280);
            this.runtimeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runtimeBox.Name = "runtimeBox";
            this.runtimeBox.Size = new System.Drawing.Size(215, 20);
            this.runtimeBox.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(22, 41);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 6;
            this.Title.Text = "Title";
            // 
            // releaseYear
            // 
            this.releaseYear.AutoSize = true;
            this.releaseYear.Location = new System.Drawing.Point(4, 98);
            this.releaseYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(71, 13);
            this.releaseYear.TabIndex = 7;
            this.releaseYear.Text = "Release Year";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(22, 162);
            this.Rating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 8;
            this.Rating.Text = "Rating";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(22, 220);
            this.Genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 9;
            this.Genre.Text = "Genre";
            // 
            // Runtime
            // 
            this.Runtime.AutoSize = true;
            this.Runtime.Location = new System.Drawing.Point(22, 280);
            this.Runtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Runtime.Name = "Runtime";
            this.Runtime.Size = new System.Drawing.Size(46, 13);
            this.Runtime.TabIndex = 10;
            this.Runtime.Text = "Runtime";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(79, 331);
            this.priceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(215, 20);
            this.priceBox.TabIndex = 11;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(22, 331);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 12;
            this.Price.Text = "Price";
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 445);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
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