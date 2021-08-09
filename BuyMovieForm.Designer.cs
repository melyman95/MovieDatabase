
namespace MovieDatabase
{
    partial class BuyMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyMovieForm));
            this.movieListBox = new System.Windows.Forms.ComboBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(65, 41);
            this.movieListBox.Margin = new System.Windows.Forms.Padding(2);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(143, 21);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.movieListBox_SelectedIndexChanged);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(65, 94);
            this.buyButton.Margin = new System.Windows.Forms.Padding(2);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(66, 45);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "yes";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(135, 94);
            this.noButton.Margin = new System.Windows.Forms.Padding(2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(66, 45);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Are You Sure You Want To Buy This Book?";
            // 
            // BuyMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.movieListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuyMovieForm";
            this.Text = "Buy Movie";
            this.Load += new System.EventHandler(this.BuyMovieForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox movieListBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label label1;
    }
}