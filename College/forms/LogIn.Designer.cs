namespace College.forms
{
    partial class LogIn
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
            textBox_name = new TextBox();
            textBox_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_log = new Button();
            button_new = new Button();
            SuspendLayout();
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(264, 176);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(269, 27);
            textBox_name.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(264, 311);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(269, 27);
            textBox_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 128);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 2;
            label1.Text = "שם";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 260);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "סיסמא";
            // 
            // button_log
            // 
            button_log.Location = new Point(355, 364);
            button_log.Name = "button_log";
            button_log.Size = new Size(94, 29);
            button_log.TabIndex = 4;
            button_log.Text = "כניסה";
            button_log.UseVisualStyleBackColor = true;
            button_log.Click += button_log_Click;
            // 
            // button_new
            // 
            button_new.Location = new Point(12, 409);
            button_new.Name = "button_new";
            button_new.Size = new Size(94, 29);
            button_new.TabIndex = 5;
            button_new.Text = "תלמיד חדש";
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += button_new_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_new);
            Controls.Add(button_log);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_name);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_name;
        private TextBox textBox_password;
        private Label label1;
        private Label label2;
        private Button button_log;
        private Button button_new;
    }
}