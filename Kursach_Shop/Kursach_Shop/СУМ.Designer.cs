
namespace Kursach_Shop
{
    partial class СУМ
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveExcel = new System.Windows.Forms.Button();
            this.LoadExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "просмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "управление";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursach_Shop.Properties.Resources.SUM;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SaveExcel
            // 
            this.SaveExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveExcel.Location = new System.Drawing.Point(12, 273);
            this.SaveExcel.Name = "SaveExcel";
            this.SaveExcel.Size = new System.Drawing.Size(146, 32);
            this.SaveExcel.TabIndex = 3;
            this.SaveExcel.Text = "Сохранить";
            this.SaveExcel.UseVisualStyleBackColor = true;
            this.SaveExcel.Click += new System.EventHandler(this.SaveExcel_Click);
            // 
            // LoadExcel
            // 
            this.LoadExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadExcel.Location = new System.Drawing.Point(169, 273);
            this.LoadExcel.Name = "LoadExcel";
            this.LoadExcel.Size = new System.Drawing.Size(146, 32);
            this.LoadExcel.TabIndex = 4;
            this.LoadExcel.Text = "Загрузить";
            this.LoadExcel.UseVisualStyleBackColor = true;
            this.LoadExcel.Click += new System.EventHandler(this.LoadExcel_Click);
            // 
            // СУМ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(327, 317);
            this.Controls.Add(this.LoadExcel);
            this.Controls.Add(this.SaveExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "СУМ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУМ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveExcel;
        private System.Windows.Forms.Button LoadExcel;
    }
}