namespace WinFormsApp1
{
    partial class KarZarar1
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(488, 214);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 283);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(131, 329);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 28);
            comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 283);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 3;
            label1.Text = "Ay :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 332);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 4;
            label2.Text = "Yıl :";
            // 
            // button1
            // 
            button1.Location = new Point(344, 329);
            button1.Name = "button1";
            button1.Size = new Size(121, 28);
            button1.TabIndex = 5;
            button1.Text = "SEÇ";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(673, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(589, 54);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 7;
            label3.Text = "Brüt Gelir :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(629, 105);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Kar :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(673, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 9;
            // 
            // KarZarar1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 453);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "KarZarar1";
            Text = "Kar Zarar Bilgileri";
            Load += KarZarar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
    }
}