
namespace MovieDatabase
{
    partial class GetMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetMovieForm));
            this.movieListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movieInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(132, 95);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(274, 28);
            this.movieListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie List";
            // 
            // movieInfoButton
            // 
            this.movieInfoButton.Location = new System.Drawing.Point(202, 162);
            this.movieInfoButton.Name = "movieInfoButton";
            this.movieInfoButton.Size = new System.Drawing.Size(125, 48);
            this.movieInfoButton.TabIndex = 2;
            this.movieInfoButton.Text = "Info";
            this.movieInfoButton.UseVisualStyleBackColor = true;
            this.movieInfoButton.Click += new System.EventHandler(this.movieInfoButton_Click);
            // 
            // GetMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 251);
            this.Controls.Add(this.movieInfoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetMovieForm";
            this.Text = "Preview Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox movieListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button movieInfoButton;
    }
}