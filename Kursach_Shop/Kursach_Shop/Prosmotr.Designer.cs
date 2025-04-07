
namespace Kursach_Shop
{
    partial class Prosmotr
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_prosmotr = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_m3 = new System.Windows.Forms.ComboBox();
            this.comboBox_m2 = new System.Windows.Forms.ComboBox();
            this.comboBox_m1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_tMax = new System.Windows.Forms.TextBox();
            this.textBox_tMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_t2 = new System.Windows.Forms.ComboBox();
            this.comboBox_t1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clcityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clcityBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(87, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "инфо";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_prosmotr
            // 
            this.listBox_prosmotr.FormattingEnabled = true;
            this.listBox_prosmotr.Location = new System.Drawing.Point(191, 8);
            this.listBox_prosmotr.Name = "listBox_prosmotr";
            this.listBox_prosmotr.Size = new System.Drawing.Size(597, 446);
            this.listBox_prosmotr.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_m3);
            this.groupBox2.Controls.Add(this.comboBox_m2);
            this.groupBox2.Controls.Add(this.comboBox_m1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 144);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Магазин";
            // 
            // comboBox_m3
            // 
            this.comboBox_m3.FormattingEnabled = true;
            this.comboBox_m3.Location = new System.Drawing.Point(41, 117);
            this.comboBox_m3.Name = "comboBox_m3";
            this.comboBox_m3.Size = new System.Drawing.Size(121, 21);
            this.comboBox_m3.TabIndex = 6;
            // 
            // comboBox_m2
            // 
            this.comboBox_m2.FormattingEnabled = true;
            this.comboBox_m2.Location = new System.Drawing.Point(41, 76);
            this.comboBox_m2.Name = "comboBox_m2";
            this.comboBox_m2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_m2.TabIndex = 5;
            // 
            // comboBox_m1
            // 
            this.comboBox_m1.FormattingEnabled = true;
            this.comboBox_m1.Items.AddRange(new object[] {
            "Все",
            "Минская",
            "Витебская",
            "Могилёвская",
            "Гомельская",
            "Брестская",
            "Гродненская"});
            this.comboBox_m1.Location = new System.Drawing.Point(41, 35);
            this.comboBox_m1.Name = "comboBox_m1";
            this.comboBox_m1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_m1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Магазин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Область";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_tMax);
            this.groupBox3.Controls.Add(this.textBox_tMin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox_t2);
            this.groupBox3.Controls.Add(this.comboBox_t1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 172);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Товар";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "До";
            // 
            // textBox_tMax
            // 
            this.textBox_tMax.Location = new System.Drawing.Point(70, 143);
            this.textBox_tMax.Name = "textBox_tMax";
            this.textBox_tMax.Size = new System.Drawing.Size(71, 20);
            this.textBox_tMax.TabIndex = 8;
            this.textBox_tMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tMax_KeyPress);
            // 
            // textBox_tMin
            // 
            this.textBox_tMin.Location = new System.Drawing.Point(70, 117);
            this.textBox_tMin.Name = "textBox_tMin";
            this.textBox_tMin.Size = new System.Drawing.Size(71, 20);
            this.textBox_tMin.TabIndex = 7;
            this.textBox_tMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tMin_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "От";
            // 
            // comboBox_t2
            // 
            this.comboBox_t2.FormattingEnabled = true;
            this.comboBox_t2.Location = new System.Drawing.Point(41, 76);
            this.comboBox_t2.Name = "comboBox_t2";
            this.comboBox_t2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_t2.TabIndex = 5;
            // 
            // comboBox_t1
            // 
            this.comboBox_t1.FormattingEnabled = true;
            this.comboBox_t1.Location = new System.Drawing.Point(41, 35);
            this.comboBox_t1.Name = "comboBox_t1";
            this.comboBox_t1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_t1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Производитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Название";
            // 
            // clcityBindingSource
            // 
            this.clcityBindingSource.DataSource = typeof(Kursach_Shop.cl_city);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "прямая",
            "обратная"});
            this.comboBox1.Location = new System.Drawing.Point(9, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 44);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сортировка";
            // 
            // Prosmotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_prosmotr);
            this.Name = "Prosmotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prosmotr";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clcityBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_prosmotr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_m3;
        private System.Windows.Forms.ComboBox comboBox_m2;
        private System.Windows.Forms.ComboBox comboBox_m1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_t2;
        private System.Windows.Forms.ComboBox comboBox_t1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_tMax;
        private System.Windows.Forms.TextBox textBox_tMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource clcityBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}