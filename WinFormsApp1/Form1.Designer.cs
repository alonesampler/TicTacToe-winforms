namespace WinFormsApp1
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
            field1 = new Button();
            field2 = new Button();
            field3 = new Button();
            field6 = new Button();
            field5 = new Button();
            field4 = new Button();
            field9 = new Button();
            field8 = new Button();
            field7 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            restartKey = new Button();
            recordBox1 = new TextBox();
            recordBox2 = new TextBox();
            SuspendLayout();
            // 
            // field1
            // 
            field1.Enabled = false;
            field1.FlatAppearance.BorderSize = 0;
            field1.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field1.Location = new Point(23, 12);
            field1.Name = "field1";
            field1.Size = new Size(200, 200);
            field1.TabIndex = 2;
            field1.TextAlign = ContentAlignment.TopRight;
            field1.UseVisualStyleBackColor = true;
            field1.Click += ButtonClick;
            // 
            // field2
            // 
            field2.BackgroundImageLayout = ImageLayout.None;
            field2.Enabled = false;
            field2.FlatAppearance.BorderSize = 0;
            field2.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field2.Location = new Point(229, 12);
            field2.Name = "field2";
            field2.Size = new Size(200, 200);
            field2.TabIndex = 3;
            field2.TextAlign = ContentAlignment.TopLeft;
            field2.UseVisualStyleBackColor = true;
            field2.Click += ButtonClick;
            // 
            // field3
            // 
            field3.Enabled = false;
            field3.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field3.Location = new Point(435, 12);
            field3.Name = "field3";
            field3.Size = new Size(200, 200);
            field3.TabIndex = 4;
            field3.TextAlign = ContentAlignment.TopLeft;
            field3.UseVisualStyleBackColor = true;
            field3.Click += ButtonClick;
            // 
            // field6
            // 
            field6.Enabled = false;
            field6.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field6.Location = new Point(435, 218);
            field6.Name = "field6";
            field6.Size = new Size(200, 200);
            field6.TabIndex = 7;
            field6.TextAlign = ContentAlignment.TopLeft;
            field6.UseVisualStyleBackColor = true;
            field6.Click += ButtonClick;
            // 
            // field5
            // 
            field5.Enabled = false;
            field5.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field5.Location = new Point(229, 218);
            field5.Name = "field5";
            field5.Size = new Size(200, 200);
            field5.TabIndex = 6;
            field5.TextAlign = ContentAlignment.TopLeft;
            field5.UseVisualStyleBackColor = true;
            field5.Click += ButtonClick;
            // 
            // field4
            // 
            field4.Enabled = false;
            field4.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field4.Location = new Point(23, 218);
            field4.Name = "field4";
            field4.Size = new Size(200, 200);
            field4.TabIndex = 5;
            field4.TextAlign = ContentAlignment.TopLeft;
            field4.UseVisualStyleBackColor = true;
            field4.Click += ButtonClick;
            // 
            // field9
            // 
            field9.Enabled = false;
            field9.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field9.Location = new Point(435, 424);
            field9.Name = "field9";
            field9.Size = new Size(200, 200);
            field9.TabIndex = 10;
            field9.TextAlign = ContentAlignment.TopLeft;
            field9.UseVisualStyleBackColor = true;
            field9.Click += ButtonClick;
            // 
            // field8
            // 
            field8.Enabled = false;
            field8.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field8.Location = new Point(229, 424);
            field8.Name = "field8";
            field8.Size = new Size(200, 200);
            field8.TabIndex = 9;
            field8.TextAlign = ContentAlignment.TopLeft;
            field8.UseVisualStyleBackColor = true;
            field8.Click += ButtonClick;
            // 
            // field7
            // 
            field7.Enabled = false;
            field7.Font = new Font("Microsoft Sans Serif", 138F, FontStyle.Regular, GraphicsUnit.Point, 204);
            field7.Location = new Point(23, 424);
            field7.Name = "field7";
            field7.Size = new Size(200, 200);
            field7.TabIndex = 8;
            field7.TextAlign = ContentAlignment.TopLeft;
            field7.UseVisualStyleBackColor = true;
            field7.Click += ButtonClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(641, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 17);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += PrepareGame;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(641, 43);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 17);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += PrepareGame;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(658, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 21);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(658, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 21);
            textBox2.TabIndex = 14;
            // 
            // restartKey
            // 
            restartKey.Font = new Font("MV Boli", 10.25F);
            restartKey.Location = new Point(641, 66);
            restartKey.Name = "restartKey";
            restartKey.Size = new Size(117, 27);
            restartKey.TabIndex = 15;
            restartKey.Text = "Restart";
            restartKey.TextAlign = ContentAlignment.TopCenter;
            restartKey.UseVisualStyleBackColor = true;
            restartKey.Click += RestartGame;
            // 
            // recordBox1
            // 
            recordBox1.Enabled = false;
            recordBox1.Location = new Point(641, 191);
            recordBox1.Name = "recordBox1";
            recordBox1.Size = new Size(117, 21);
            recordBox1.TabIndex = 16;
            // 
            // recordBox2
            // 
            recordBox2.Enabled = false;
            recordBox2.Location = new Point(641, 218);
            recordBox2.Name = "recordBox2";
            recordBox2.Size = new Size(117, 21);
            recordBox2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(804, 637);
            Controls.Add(recordBox2);
            Controls.Add(recordBox1);
            Controls.Add(restartKey);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(field9);
            Controls.Add(field8);
            Controls.Add(field7);
            Controls.Add(field6);
            Controls.Add(field5);
            Controls.Add(field4);
            Controls.Add(field3);
            Controls.Add(field2);
            Controls.Add(field1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button field1;
        private Button field2;
        private Button field3;
        private Button field4;
        private Button field5;
        private Button field6;
        private Button field7;
        private Button field8;
        private Button field9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button restartKey;
        private TextBox recordBox1;
        private TextBox recordBox2;
    }
}
