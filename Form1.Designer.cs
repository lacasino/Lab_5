﻿
namespace LAB5
{
    partial class Lab5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Create_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CircleRadius_TextBox = new System.Windows.Forms.TextBox();
            this.SquareSideLenght_TextBox = new System.Windows.Forms.TextBox();
            this.RhombHorizontalDiagonalLenght_TextBox = new System.Windows.Forms.TextBox();
            this.RhombVerticalDiagonalLenght_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 477);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Create_Button
            // 
            this.Create_Button.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.Create_Button.Location = new System.Drawing.Point(785, 451);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(227, 38);
            this.Create_Button.TabIndex = 1;
            this.Create_Button.Text = "Створити фігуру";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(850, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CircleRadius_TextBox
            // 
            this.CircleRadius_TextBox.Location = new System.Drawing.Point(850, 170);
            this.CircleRadius_TextBox.Name = "CircleRadius_TextBox";
            this.CircleRadius_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CircleRadius_TextBox.TabIndex = 3;
            this.CircleRadius_TextBox.Visible = false;
            this.CircleRadius_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // SquareSideLenght_TextBox
            // 
            this.SquareSideLenght_TextBox.Location = new System.Drawing.Point(850, 170);
            this.SquareSideLenght_TextBox.Name = "SquareSideLenght_TextBox";
            this.SquareSideLenght_TextBox.Size = new System.Drawing.Size(100, 20);
            this.SquareSideLenght_TextBox.TabIndex = 4;
            this.SquareSideLenght_TextBox.Visible = false;
            this.SquareSideLenght_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // RhombHorizontalDiagonalLenght_TextBox
            // 
            this.RhombHorizontalDiagonalLenght_TextBox.Location = new System.Drawing.Point(850, 260);
            this.RhombHorizontalDiagonalLenght_TextBox.Name = "RhombHorizontalDiagonalLenght_TextBox";
            this.RhombHorizontalDiagonalLenght_TextBox.Size = new System.Drawing.Size(100, 20);
            this.RhombHorizontalDiagonalLenght_TextBox.TabIndex = 5;
            this.RhombHorizontalDiagonalLenght_TextBox.Visible = false;
            this.RhombHorizontalDiagonalLenght_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // RhombVerticalDiagonalLenght_TextBox
            // 
            this.RhombVerticalDiagonalLenght_TextBox.Location = new System.Drawing.Point(850, 170);
            this.RhombVerticalDiagonalLenght_TextBox.Name = "RhombVerticalDiagonalLenght_TextBox";
            this.RhombVerticalDiagonalLenght_TextBox.Size = new System.Drawing.Size(100, 20);
            this.RhombVerticalDiagonalLenght_TextBox.TabIndex = 6;
            this.RhombVerticalDiagonalLenght_TextBox.Visible = false;
            this.RhombVerticalDiagonalLenght_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(829, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оберіть фігуру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(829, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Радіус кола";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(814, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "Довжина сторони \r\n        квадрата";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(778, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "Довжина горизонтальної \r\n         сторони ромба";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(781, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 48);
            this.label5.TabIndex = 11;
            this.label5.Text = "Довжина вертикальної \r\n         сторони ромба";
            this.label5.Visible = false;
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RhombVerticalDiagonalLenght_TextBox);
            this.Controls.Add(this.RhombHorizontalDiagonalLenght_TextBox);
            this.Controls.Add(this.SquareSideLenght_TextBox);
            this.Controls.Add(this.CircleRadius_TextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1040, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1040, 540);
            this.Name = "Lab5";
            this.ShowIcon = false;
            this.Text = "Jaba_5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox CircleRadius_TextBox;
        private System.Windows.Forms.TextBox SquareSideLenght_TextBox;
        private System.Windows.Forms.TextBox RhombHorizontalDiagonalLenght_TextBox;
        private System.Windows.Forms.TextBox RhombVerticalDiagonalLenght_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

