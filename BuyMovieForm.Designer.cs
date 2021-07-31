
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
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(98, 63);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(213, 28);
            this.movieListBox.TabIndex = 0;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(98, 144);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(218, 70);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // BuyMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 240);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.movieListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyMovieForm";
            this.Text = "Buy Movie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox movieListBox;
        private System.Windows.Forms.Button buyButton;
    }
}