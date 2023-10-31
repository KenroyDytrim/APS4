namespace APS4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clone = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PrototypeBox = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.Button();
            this.textVIN = new System.Windows.Forms.TextBox();
            this.textColor = new System.Windows.Forms.TextBox();
            this.listCars = new System.Windows.Forms.ListBox();
            this.textTypeC = new System.Windows.Forms.TextBox();
            this.textYearCr = new System.Windows.Forms.TextBox();
            this.textEnginePower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AllDelete = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.Button();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPrototype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clone
            // 
            this.Clone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Clone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clone.Location = new System.Drawing.Point(83, 78);
            this.Clone.Name = "Clone";
            this.Clone.Size = new System.Drawing.Size(145, 42);
            this.Clone.TabIndex = 0;
            this.Clone.Text = "Clone";
            this.Clone.UseVisualStyleBackColor = false;
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(30, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(411, 208);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // PrototypeBox
            // 
            this.PrototypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrototypeBox.FormattingEnabled = true;
            this.PrototypeBox.Items.AddRange(new object[] {
            "BMW X5",
            "Toyota Camry",
            "Kia Rio",
            "Subaru Legacy"});
            this.PrototypeBox.Location = new System.Drawing.Point(26, 30);
            this.PrototypeBox.Name = "PrototypeBox";
            this.PrototypeBox.Size = new System.Drawing.Size(264, 33);
            this.PrototypeBox.TabIndex = 3;
            this.PrototypeBox.SelectedIndexChanged += new System.EventHandler(this.PrototypeBox_SelectedIndexChanged);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(207, 222);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(145, 42);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // textVIN
            // 
            this.textVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textVIN.Location = new System.Drawing.Point(276, 18);
            this.textVIN.Name = "textVIN";
            this.textVIN.Size = new System.Drawing.Size(265, 30);
            this.textVIN.TabIndex = 6;
            // 
            // textColor
            // 
            this.textColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textColor.Location = new System.Drawing.Point(276, 126);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(265, 30);
            this.textColor.TabIndex = 7;
            // 
            // listCars
            // 
            this.listCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listCars.FormattingEnabled = true;
            this.listCars.ItemHeight = 25;
            this.listCars.Location = new System.Drawing.Point(13, 20);
            this.listCars.Name = "listCars";
            this.listCars.Size = new System.Drawing.Size(428, 154);
            this.listCars.TabIndex = 8;
            this.listCars.SelectedIndexChanged += new System.EventHandler(this.listCars_SelectedIndexChanged);
            // 
            // textTypeC
            // 
            this.textTypeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTypeC.Location = new System.Drawing.Point(276, 54);
            this.textTypeC.Name = "textTypeC";
            this.textTypeC.Size = new System.Drawing.Size(265, 30);
            this.textTypeC.TabIndex = 9;
            // 
            // textYearCr
            // 
            this.textYearCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textYearCr.Location = new System.Drawing.Point(276, 90);
            this.textYearCr.Name = "textYearCr";
            this.textYearCr.Size = new System.Drawing.Size(265, 30);
            this.textYearCr.TabIndex = 10;
            // 
            // textEnginePower
            // 
            this.textEnginePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEnginePower.Location = new System.Drawing.Point(276, 162);
            this.textEnginePower.Name = "textEnginePower";
            this.textEnginePower.Size = new System.Drawing.Size(265, 30);
            this.textEnginePower.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Тип ТС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Цвет кузова";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Мощность двигателя";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Edit);
            this.groupBox1.Controls.Add(this.textVIN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textTypeC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textYearCr);
            this.groupBox1.Controls.Add(this.textEnginePower);
            this.groupBox1.Location = new System.Drawing.Point(830, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 270);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(355, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 270);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.PrototypeBox);
            this.groupBox3.Controls.Add(this.Clone);
            this.groupBox3.Location = new System.Drawing.Point(12, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 157);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прототипы";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(13, 180);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(145, 42);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.AllDelete);
            this.groupBox4.Controls.Add(this.listCars);
            this.groupBox4.Controls.Add(this.Delete);
            this.groupBox4.Location = new System.Drawing.Point(355, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 245);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Автомобили";
            // 
            // AllDelete
            // 
            this.AllDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AllDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllDelete.Location = new System.Drawing.Point(296, 180);
            this.AllDelete.Name = "AllDelete";
            this.AllDelete.Size = new System.Drawing.Size(145, 42);
            this.AllDelete.TabIndex = 22;
            this.AllDelete.Text = "AllDelete";
            this.AllDelete.UseVisualStyleBackColor = false;
            this.AllDelete.Click += new System.EventHandler(this.AllDelete_Click);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(90, 72);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(145, 42);
            this.Address.TabIndex = 22;
            this.Address.Text = "Адрес";
            this.Address.UseVisualStyleBackColor = false;
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAddress.Location = new System.Drawing.Point(34, 21);
            this.textAddress.Name = "textAddress";
            this.textAddress.ReadOnly = true;
            this.textAddress.Size = new System.Drawing.Size(265, 30);
            this.textAddress.TabIndex = 23;
            // 
            // textPrototype
            // 
            this.textPrototype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrototype.Location = new System.Drawing.Point(6, 62);
            this.textPrototype.Name = "textPrototype";
            this.textPrototype.ReadOnly = true;
            this.textPrototype.Size = new System.Drawing.Size(265, 30);
            this.textPrototype.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Адрес прототипа";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox5.Controls.Add(this.textPrototype);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(12, 188);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 103);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Данные прототипа";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox6.Controls.Add(this.textAddress);
            this.groupBox6.Controls.Add(this.Address);
            this.groupBox6.Location = new System.Drawing.Point(944, 317);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(328, 136);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Данные копии";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 564);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clone;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox PrototypeBox;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox textVIN;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.ListBox listCars;
        private System.Windows.Forms.TextBox textTypeC;
        private System.Windows.Forms.TextBox textYearCr;
        private System.Windows.Forms.TextBox textEnginePower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AllDelete;
        private System.Windows.Forms.Button Address;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPrototype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

