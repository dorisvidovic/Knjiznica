
namespace Knjiznica
{
    partial class Knjiznica
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
            this.KnjUcenici = new System.Windows.Forms.Label();
            this.KnjKnjige = new System.Windows.Forms.Label();
            this.KnjPosudene = new System.Windows.Forms.Label();
            this.ButtonUcenici = new System.Windows.Forms.Button();
            this.ButtonKnjige = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonPosudi = new System.Windows.Forms.Button();
            this.ButtonIzmijeni = new System.Windows.Forms.Button();
            this.ButtonVrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KnjUcenici
            // 
            this.KnjUcenici.AutoSize = true;
            this.KnjUcenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnjUcenici.Location = new System.Drawing.Point(24, 13);
            this.KnjUcenici.Name = "KnjUcenici";
            this.KnjUcenici.Size = new System.Drawing.Size(61, 20);
            this.KnjUcenici.TabIndex = 0;
            this.KnjUcenici.Text = "Ucenici";
            this.KnjUcenici.Click += new System.EventHandler(this.label1_Click);
            // 
            // KnjKnjige
            // 
            this.KnjKnjige.AutoSize = true;
            this.KnjKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnjKnjige.Location = new System.Drawing.Point(109, 13);
            this.KnjKnjige.Name = "KnjKnjige";
            this.KnjKnjige.Size = new System.Drawing.Size(52, 20);
            this.KnjKnjige.TabIndex = 1;
            this.KnjKnjige.Text = "Knjige";
            this.KnjKnjige.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // KnjPosudene
            // 
            this.KnjPosudene.AutoSize = true;
            this.KnjPosudene.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnjPosudene.Location = new System.Drawing.Point(24, 56);
            this.KnjPosudene.Name = "KnjPosudene";
            this.KnjPosudene.Size = new System.Drawing.Size(157, 24);
            this.KnjPosudene.TabIndex = 2;
            this.KnjPosudene.Text = "Posudene knjige:";
            // 
            // ButtonUcenici
            // 
            this.ButtonUcenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUcenici.Location = new System.Drawing.Point(198, 50);
            this.ButtonUcenici.Name = "ButtonUcenici";
            this.ButtonUcenici.Size = new System.Drawing.Size(103, 36);
            this.ButtonUcenici.TabIndex = 3;
            this.ButtonUcenici.Text = "Ucenici";
            this.ButtonUcenici.UseVisualStyleBackColor = true;
            // 
            // ButtonKnjige
            // 
            this.ButtonKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonKnjige.Location = new System.Drawing.Point(307, 50);
            this.ButtonKnjige.Name = "ButtonKnjige";
            this.ButtonKnjige.Size = new System.Drawing.Size(75, 36);
            this.ButtonKnjige.TabIndex = 4;
            this.ButtonKnjige.Text = "Knjige";
            this.ButtonKnjige.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 294);
            this.textBox1.TabIndex = 5;
            // 
            // ButtonPosudi
            // 
            this.ButtonPosudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPosudi.Location = new System.Drawing.Point(595, 108);
            this.ButtonPosudi.Name = "ButtonPosudi";
            this.ButtonPosudi.Size = new System.Drawing.Size(111, 48);
            this.ButtonPosudi.TabIndex = 6;
            this.ButtonPosudi.Text = "Posudi";
            this.ButtonPosudi.UseVisualStyleBackColor = true;
            // 
            // ButtonIzmijeni
            // 
            this.ButtonIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonIzmijeni.Location = new System.Drawing.Point(595, 178);
            this.ButtonIzmijeni.Name = "ButtonIzmijeni";
            this.ButtonIzmijeni.Size = new System.Drawing.Size(111, 48);
            this.ButtonIzmijeni.TabIndex = 7;
            this.ButtonIzmijeni.Text = "Izmijeni";
            this.ButtonIzmijeni.UseVisualStyleBackColor = true;
            // 
            // ButtonVrati
            // 
            this.ButtonVrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVrati.Location = new System.Drawing.Point(595, 288);
            this.ButtonVrati.Name = "ButtonVrati";
            this.ButtonVrati.Size = new System.Drawing.Size(111, 48);
            this.ButtonVrati.TabIndex = 8;
            this.ButtonVrati.Text = "Vrati";
            this.ButtonVrati.UseVisualStyleBackColor = true;
            // 
            // Knjiznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonVrati);
            this.Controls.Add(this.ButtonIzmijeni);
            this.Controls.Add(this.ButtonPosudi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonKnjige);
            this.Controls.Add(this.ButtonUcenici);
            this.Controls.Add(this.KnjPosudene);
            this.Controls.Add(this.KnjKnjige);
            this.Controls.Add(this.KnjUcenici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Knjiznica";
            this.Text = "Knjiznica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KnjUcenici;
        private System.Windows.Forms.Label KnjKnjige;
        private System.Windows.Forms.Label KnjPosudene;
        private System.Windows.Forms.Button ButtonUcenici;
        private System.Windows.Forms.Button ButtonKnjige;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonPosudi;
        private System.Windows.Forms.Button ButtonIzmijeni;
        private System.Windows.Forms.Button ButtonVrati;
    }
}