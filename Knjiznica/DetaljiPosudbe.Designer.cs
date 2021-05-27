
namespace Knjiznica
{
    partial class DetaljiPosudbe
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
            this.DPUcenik = new System.Windows.Forms.Label();
            this.textBoxUcenik = new System.Windows.Forms.TextBox();
            this.DPKnjiga = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DPDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DPNumeric = new System.Windows.Forms.NumericUpDown();
            this.DPBrojDana = new System.Windows.Forms.Label();
            this.DPOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DPNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DPUcenik
            // 
            this.DPUcenik.AutoSize = true;
            this.DPUcenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPUcenik.Location = new System.Drawing.Point(27, 32);
            this.DPUcenik.Name = "DPUcenik";
            this.DPUcenik.Size = new System.Drawing.Size(62, 20);
            this.DPUcenik.TabIndex = 0;
            this.DPUcenik.Text = "Ucenik:";
            this.DPUcenik.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUcenik
            // 
            this.textBoxUcenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUcenik.Location = new System.Drawing.Point(31, 55);
            this.textBoxUcenik.Multiline = true;
            this.textBoxUcenik.Name = "textBoxUcenik";
            this.textBoxUcenik.Size = new System.Drawing.Size(379, 180);
            this.textBoxUcenik.TabIndex = 1;
            // 
            // DPKnjiga
            // 
            this.DPKnjiga.AutoSize = true;
            this.DPKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPKnjiga.Location = new System.Drawing.Point(27, 272);
            this.DPKnjiga.Name = "DPKnjiga";
            this.DPKnjiga.Size = new System.Drawing.Size(56, 20);
            this.DPKnjiga.TabIndex = 2;
            this.DPKnjiga.Text = "Knjiga:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 295);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 180);
            this.textBox1.TabIndex = 3;
            // 
            // DPDateTimePicker
            // 
            this.DPDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPDateTimePicker.Location = new System.Drawing.Point(529, 78);
            this.DPDateTimePicker.Name = "DPDateTimePicker";
            this.DPDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.DPDateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum posudbe:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DPNumeric
            // 
            this.DPNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DPNumeric.Location = new System.Drawing.Point(529, 187);
            this.DPNumeric.Name = "DPNumeric";
            this.DPNumeric.Size = new System.Drawing.Size(120, 26);
            this.DPNumeric.TabIndex = 7;
            this.DPNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DPNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // DPBrojDana
            // 
            this.DPBrojDana.AutoSize = true;
            this.DPBrojDana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPBrojDana.Location = new System.Drawing.Point(526, 164);
            this.DPBrojDana.Name = "DPBrojDana";
            this.DPBrojDana.Size = new System.Drawing.Size(81, 20);
            this.DPBrojDana.TabIndex = 8;
            this.DPBrojDana.Text = "Broj dana:";
            // 
            // DPOK
            // 
            this.DPOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPOK.Location = new System.Drawing.Point(529, 366);
            this.DPOK.Name = "DPOK";
            this.DPOK.Size = new System.Drawing.Size(91, 44);
            this.DPOK.TabIndex = 9;
            this.DPOK.Text = "OK";
            this.DPOK.UseVisualStyleBackColor = true;
            // 
            // DetaljiPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.DPOK);
            this.Controls.Add(this.DPBrojDana);
            this.Controls.Add(this.DPNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DPDateTimePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DPKnjiga);
            this.Controls.Add(this.textBoxUcenik);
            this.Controls.Add(this.DPUcenik);
            this.Name = "DetaljiPosudbe";
            this.Text = "DetaljiPosudbe";
            ((System.ComponentModel.ISupportInitialize)(this.DPNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DPUcenik;
        private System.Windows.Forms.TextBox textBoxUcenik;
        private System.Windows.Forms.Label DPKnjiga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DPDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DPNumeric;
        private System.Windows.Forms.Label DPBrojDana;
        private System.Windows.Forms.Button DPOK;
    }
}