namespace VideoRental
{
    partial class AddMovie
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
            this.useradd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rentalcost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.TextBox();
            this.copies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.plot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // useradd
            // 
            this.useradd.Location = new System.Drawing.Point(339, 295);
            this.useradd.Name = "useradd";
            this.useradd.Size = new System.Drawing.Size(75, 23);
            this.useradd.TabIndex = 12;
            this.useradd.Text = "AddMovie";
            this.useradd.UseVisualStyleBackColor = true;
            this.useradd.Click += new System.EventHandler(this.useradd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "RentalCost";
            // 
            // rentalcost
            // 
            this.rentalcost.Location = new System.Drawing.Point(339, 145);
            this.rentalcost.Name = "rentalcost";
            this.rentalcost.Size = new System.Drawing.Size(100, 20);
            this.rentalcost.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(339, 106);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(339, 63);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rating";
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(339, 21);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(100, 20);
            this.rating.TabIndex = 7;
            // 
            // copies
            // 
            this.copies.Location = new System.Drawing.Point(339, 184);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(100, 20);
            this.copies.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Copies";
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(339, 213);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(100, 20);
            this.plot.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Plot";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(339, 250);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 20);
            this.genre.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Genre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.useradd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.rentalcost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rating);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button useradd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rentalcost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}