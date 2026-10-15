namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewLibrary = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrary).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLibrary
            // 
            dataGridViewLibrary.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewLibrary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibrary.GridColor = SystemColors.InactiveCaption;
            dataGridViewLibrary.Location = new Point(227, 99);
            dataGridViewLibrary.Name = "dataGridViewLibrary";
            dataGridViewLibrary.Size = new Size(1052, 455);
            dataGridViewLibrary.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(642, 35);
            button1.Name = "button1";
            button1.Size = new Size(227, 36);
            button1.TabIndex = 2;
            button1.Text = "Показати дані";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1529, 580);
            Controls.Add(button1);
            Controls.Add(dataGridViewLibrary);
            ForeColor = Color.FromArgb(0, 0, 64);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLibrary;
        private Button button1;
    }
}
