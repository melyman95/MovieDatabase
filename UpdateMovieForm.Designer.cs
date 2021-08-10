
namespace MovieDatabase
{
    partial class UpdateMovieForm
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
            this.movieListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.Label();
            this.releaseYearBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.runtimeBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(230, 25);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(152, 21);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select A Movie To Update";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(409, 282);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 57);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Release Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Runtime";
            // 
            // priceBox
            // 
            this.priceBox.AutoSize = true;
            this.priceBox.Location = new System.Drawing.Point(62, 305);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(31, 13);
            this.priceBox.TabIndex = 8;
            this.priceBox.Text = "Price";
            // 
            // releaseYearBox
            // 
            this.releaseYearBox.Location = new System.Drawing.Point(204, 124);
            this.releaseYearBox.Name = "releaseYearBox";
            this.releaseYearBox.Size = new System.Drawing.Size(159, 20);
            this.releaseYearBox.TabIndex = 10;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(204, 171);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(158, 20);
            this.ratingBox.TabIndex = 11;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(204, 218);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(157, 20);
            this.genreBox.TabIndex = 12;
            // 
            // runtimeBox
            // 
            this.runtimeBox.Location = new System.Drawing.Point(204, 261);
            this.runtimeBox.Name = "runtimeBox";
            this.runtimeBox.Size = new System.Drawing.Size(160, 20);
            this.runtimeBox.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(204, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 20);
            this.textBox6.TabIndex = 14;
            // 
            // UpdateMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 351);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.runtimeBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.releaseYearBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieListBox);
            this.Name = "UpdateMovieForm";
            this.Text = "UpdateMovieForm";
            this.Load += new System.EventHandler(this.UpdateMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox movieListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priceBox;
        private System.Windows.Forms.TextBox releaseYearBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox runtimeBox;
        private System.Windows.Forms.TextBox textBox6;
    }
}