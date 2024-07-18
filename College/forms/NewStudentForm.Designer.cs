namespace College.forms
{
    partial class NewStudentForm
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
            textBox_phonNum = new TextBox();
            textBox_Hnum = new TextBox();
            textBox_street = new TextBox();
            textBox_city = new TextBox();
            textBox_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_add = new Button();
            textBox_password = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox_phonNum
            // 
            textBox_phonNum.Location = new Point(74, 296);
            textBox_phonNum.Name = "textBox_phonNum";
            textBox_phonNum.Size = new Size(567, 27);
            textBox_phonNum.TabIndex = 0;
            // 
            // textBox_Hnum
            // 
            textBox_Hnum.Location = new Point(74, 238);
            textBox_Hnum.Name = "textBox_Hnum";
            textBox_Hnum.Size = new Size(567, 27);
            textBox_Hnum.TabIndex = 1;
            // 
            // textBox_street
            // 
            textBox_street.Location = new Point(74, 185);
            textBox_street.Name = "textBox_street";
            textBox_street.Size = new Size(567, 27);
            textBox_street.TabIndex = 2;
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(74, 127);
            textBox_city.Name = "textBox_city";
            textBox_city.Size = new Size(567, 27);
            textBox_city.TabIndex = 3;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(74, 69);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(567, 27);
            textBox_name.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(686, 299);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "מספר טלפון";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(731, 192);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 6;
            label2.Text = "רחוב";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(741, 134);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 7;
            label3.Text = "עיר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(708, 76);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "שם מלא";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(697, 245);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 9;
            label5.Text = "מספר בית";
            // 
            // button_add
            // 
            button_add.Location = new Point(24, 379);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 59);
            button_add.TabIndex = 10;
            button_add.Text = "אישור";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(74, 346);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(567, 27);
            textBox_password.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(718, 353);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 12;
            label6.Text = "סיסמא";
            // 
            // NewStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox_password);
            Controls.Add(button_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_name);
            Controls.Add(textBox_city);
            Controls.Add(textBox_street);
            Controls.Add(textBox_Hnum);
            Controls.Add(textBox_phonNum);
            Name = "NewStudentForm";
            Text = "NewStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_phonNum;
        private TextBox textBox_Hnum;
        private TextBox textBox_street;
        private TextBox textBox_city;
        private TextBox textBox_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_add;
        private TextBox textBox_password;
        private Label label6;
    }
}