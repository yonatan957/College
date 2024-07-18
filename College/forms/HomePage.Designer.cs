namespace College.forms
{
    partial class HomePage
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
            button_data = new Button();
            button_curse = new Button();
            SuspendLayout();
            // 
            // button_data
            // 
            button_data.Location = new Point(312, 247);
            button_data.Name = "button_data";
            button_data.Size = new Size(169, 93);
            button_data.TabIndex = 0;
            button_data.Text = "המידע שלי";
            button_data.UseVisualStyleBackColor = true;
            button_data.Click += button_data_Click;
            // 
            // button_curse
            // 
            button_curse.Location = new Point(312, 108);
            button_curse.Name = "button_curse";
            button_curse.Size = new Size(169, 92);
            button_curse.TabIndex = 1;
            button_curse.Text = "רישום לקורס";
            button_curse.UseVisualStyleBackColor = true;
            button_curse.Click += button_curse_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_curse);
            Controls.Add(button_data);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button button_data;
        private Button button_curse;
    }
}