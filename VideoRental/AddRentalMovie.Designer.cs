namespace VideoRental
{
    partial class AddRentalMovie
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
            this.label2 = new System.Windows.Forms.Label();
            this.customerid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movieid = new System.Windows.Forms.TextBox();
            this.datereturned = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.daterented = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // useradd
            // 
            this.useradd.Location = new System.Drawing.Point(355, 179);
            this.useradd.Name = "useradd";
            this.useradd.Size = new System.Drawing.Size(100, 23);
            this.useradd.TabIndex = 27;
            this.useradd.Text = "AddRentalMovie";
            this.useradd.UseVisualStyleBackColor = true;
            this.useradd.Click += new System.EventHandler(this.useradd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "CustomerId";
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(355, 54);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(100, 20);
            this.customerid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "MovieId";
            // 
            // movieid
            // 
            this.movieid.Location = new System.Drawing.Point(355, 12);
            this.movieid.Name = "movieid";
            this.movieid.Size = new System.Drawing.Size(100, 20);
            this.movieid.TabIndex = 19;
            // 
            // datereturned
            // 
            this.datereturned.Location = new System.Drawing.Point(355, 136);
            this.datereturned.Name = "datereturned";
            this.datereturned.Size = new System.Drawing.Size(100, 20);
            this.datereturned.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "DateReturned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "DateRented";
            // 
            // daterented
            // 
            this.daterented.Location = new System.Drawing.Point(355, 97);
            this.daterented.Name = "daterented";
            this.daterented.Size = new System.Drawing.Size(100, 20);
            this.daterented.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRentalMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.useradd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datereturned);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.daterented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieid);
            this.Name = "AddRentalMovie";
            this.Text = "AddRentalMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button useradd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieid;
        private System.Windows.Forms.TextBox datereturned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox daterented;
        private System.Windows.Forms.Button button1;
    }
}