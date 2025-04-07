
namespace Kursach_Shop
{
    partial class Upravlenie
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
            this.listBox_Upravlenie_g = new System.Windows.Forms.ListBox();
            this.button_in = new System.Windows.Forms.Button();
            this.button_add_g = new System.Windows.Forms.Button();
            this.button_red_g = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.button_del_g = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clcityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clcityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Upravlenie_g
            // 
            this.listBox_Upravlenie_g.FormattingEnabled = true;
            this.listBox_Upravlenie_g.Location = new System.Drawing.Point(175, 24);
            this.listBox_Upravlenie_g.Name = "listBox_Upravlenie_g";
            this.listBox_Upravlenie_g.Size = new System.Drawing.Size(613, 407);
            this.listBox_Upravlenie_g.TabIndex = 0;
            // 
            // button_in
            // 
            this.button_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_in.Location = new System.Drawing.Point(6, 19);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(143, 44);
            this.button_in.TabIndex = 1;
            this.button_in.Text = "Выбрать";
            this.button_in.UseVisualStyleBackColor = true;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // button_add_g
            // 
            this.button_add_g.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_g.Location = new System.Drawing.Point(6, 19);
            this.button_add_g.Name = "button_add_g";
            this.button_add_g.Size = new System.Drawing.Size(143, 44);
            this.button_add_g.TabIndex = 2;
            this.button_add_g.Text = "Добавить";
            this.button_add_g.UseVisualStyleBackColor = true;
            this.button_add_g.Click += new System.EventHandler(this.button_add_g_Click);
            // 
            // button_red_g
            // 
            this.button_red_g.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_red_g.Location = new System.Drawing.Point(6, 69);
            this.button_red_g.Name = "button_red_g";
            this.button_red_g.Size = new System.Drawing.Size(143, 44);
            this.button_red_g.TabIndex = 3;
            this.button_red_g.Text = "Редактировать";
            this.button_red_g.UseVisualStyleBackColor = true;
            this.button_red_g.Click += new System.EventHandler(this.button_red_g_Click);
            // 
            // button_info
            // 
            this.button_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info.Location = new System.Drawing.Point(6, 19);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(142, 44);
            this.button_info.TabIndex = 5;
            this.button_info.Text = "Инфо";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_del_g
            // 
            this.button_del_g.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_del_g.Location = new System.Drawing.Point(6, 118);
            this.button_del_g.Name = "button_del_g";
            this.button_del_g.Size = new System.Drawing.Size(143, 44);
            this.button_del_g.TabIndex = 6;
            this.button_del_g.Text = "Удалить";
            this.button_del_g.UseVisualStyleBackColor = true;
            this.button_del_g.Click += new System.EventHandler(this.button_del_g_Click);
            // 
            // button_back
            // 
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Location = new System.Drawing.Point(7, 69);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(143, 44);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_back);
            this.groupBox1.Controls.Add(this.button_in);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перемещение";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_info);
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_add_g);
            this.groupBox3.Controls.Add(this.button_red_g);
            this.groupBox3.Controls.Add(this.button_del_g);
            this.groupBox3.Location = new System.Drawing.Point(13, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 168);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // clcityBindingSource
            // 
            this.clcityBindingSource.DataSource = typeof(Kursach_Shop.cl_city);
            // 
            // Upravlenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Upravlenie_g);
            this.Name = "Upravlenie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravlenie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clcityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Upravlenie_g;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Button button_add_g;
        private System.Windows.Forms.Button button_red_g;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_del_g;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource clcityBindingSource;
    }
}