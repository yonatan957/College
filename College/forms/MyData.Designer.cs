namespace College.forms
{
    partial class MyData
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
            dataGridView_payment = new DataGridView();
            dataGridView_curse = new DataGridView();
            dataGridView_data = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_payment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_curse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_payment
            // 
            dataGridView_payment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_payment.Location = new Point(73, 113);
            dataGridView_payment.Name = "dataGridView_payment";
            dataGridView_payment.RowHeadersWidth = 51;
            dataGridView_payment.Size = new Size(300, 188);
            dataGridView_payment.TabIndex = 0;
            // 
            // dataGridView_curse
            // 
            dataGridView_curse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_curse.Location = new Point(466, 113);
            dataGridView_curse.Name = "dataGridView_curse";
            dataGridView_curse.RowHeadersWidth = 51;
            dataGridView_curse.Size = new Size(300, 188);
            dataGridView_curse.TabIndex = 1;
            // 
            // dataGridView_data
            // 
            dataGridView_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_data.Location = new Point(827, 113);
            dataGridView_data.Name = "dataGridView_data";
            dataGridView_data.RowHeadersWidth = 51;
            dataGridView_data.Size = new Size(300, 188);
            dataGridView_data.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(932, 65);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "הפרטים שלי";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 65);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 4;
            label2.Text = "קורסים שלקחתי";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(186, 65);
            label.Name = "label";
            label.Size = new Size(68, 20);
            label.TabIndex = 5;
            label.Text = "תשלומים";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(42, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "חזרה";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(601, 348);
            label3.Name = "label3";
            label3.Size = new Size(96, 38);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // MyData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 450);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView_data);
            Controls.Add(dataGridView_curse);
            Controls.Add(dataGridView_payment);
            Name = "MyData";
            Text = "MyData";
            ((System.ComponentModel.ISupportInitialize)dataGridView_payment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_curse).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_payment;
        private DataGridView dataGridView_curse;
        private DataGridView dataGridView_data;
        private Label label1;
        private Label label2;
        private Label label;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}