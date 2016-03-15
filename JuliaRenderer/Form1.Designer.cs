namespace JuliaRenderer
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.renderButton = new System.Windows.Forms.Button();
            this.JCW_In = new System.Windows.Forms.TextBox();
            this.JCZ_In = new System.Windows.Forms.TextBox();
            this.JCY_In = new System.Windows.Forms.TextBox();
            this.JCX_In = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.JPlaneW_In = new System.Windows.Forms.TextBox();
            this.JPlaneZ_In = new System.Windows.Forms.TextBox();
            this.JPlaneY_In = new System.Windows.Forms.TextBox();
            this.JPlaneX_In = new System.Windows.Forms.TextBox();
            this.Iteration_Count = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.Epsilon_In = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Iteration_Count)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Open Picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 494);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(987, 497);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // renderButton
            // 
            this.renderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.renderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renderButton.Location = new System.Drawing.Point(243, 323);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(114, 45);
            this.renderButton.TabIndex = 10;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click_1);
            // 
            // JCW_In
            // 
            this.JCW_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCW_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCW_In.Location = new System.Drawing.Point(363, 165);
            this.JCW_In.MaxLength = 10;
            this.JCW_In.Name = "JCW_In";
            this.JCW_In.Size = new System.Drawing.Size(114, 30);
            this.JCW_In.TabIndex = 19;
            this.JCW_In.Text = "0";
            // 
            // JCZ_In
            // 
            this.JCZ_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCZ_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCZ_In.Location = new System.Drawing.Point(363, 125);
            this.JCZ_In.MaxLength = 10;
            this.JCZ_In.Name = "JCZ_In";
            this.JCZ_In.Size = new System.Drawing.Size(114, 30);
            this.JCZ_In.TabIndex = 18;
            this.JCZ_In.Text = "0";
            // 
            // JCY_In
            // 
            this.JCY_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCY_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCY_In.Location = new System.Drawing.Point(363, 85);
            this.JCY_In.MaxLength = 10;
            this.JCY_In.Name = "JCY_In";
            this.JCY_In.Size = new System.Drawing.Size(114, 30);
            this.JCY_In.TabIndex = 17;
            this.JCY_In.Text = "0";
            // 
            // JCX_In
            // 
            this.JCX_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCX_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCX_In.Location = new System.Drawing.Point(363, 45);
            this.JCX_In.MaxLength = 10;
            this.JCX_In.Name = "JCX_In";
            this.JCX_In.Size = new System.Drawing.Size(114, 30);
            this.JCX_In.TabIndex = 16;
            this.JCX_In.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(243, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "JuliaC.W:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(243, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "JuliaC.Z:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(243, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "JuliaC.Y:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(243, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "JuliaC.X:";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(3, 323);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(114, 45);
            this.OutputBox.TabIndex = 11;
            this.OutputBox.Text = "";
            // 
            // JPlaneW_In
            // 
            this.JPlaneW_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneW_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneW_In.Location = new System.Drawing.Point(123, 165);
            this.JPlaneW_In.MaxLength = 10;
            this.JPlaneW_In.Name = "JPlaneW_In";
            this.JPlaneW_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneW_In.TabIndex = 9;
            this.JPlaneW_In.Text = "0";
            // 
            // JPlaneZ_In
            // 
            this.JPlaneZ_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneZ_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneZ_In.Location = new System.Drawing.Point(123, 125);
            this.JPlaneZ_In.MaxLength = 10;
            this.JPlaneZ_In.Name = "JPlaneZ_In";
            this.JPlaneZ_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneZ_In.TabIndex = 8;
            this.JPlaneZ_In.Text = "0";
            // 
            // JPlaneY_In
            // 
            this.JPlaneY_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneY_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneY_In.Location = new System.Drawing.Point(123, 85);
            this.JPlaneY_In.MaxLength = 10;
            this.JPlaneY_In.Name = "JPlaneY_In";
            this.JPlaneY_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneY_In.TabIndex = 7;
            this.JPlaneY_In.Text = "0";
            this.JPlaneY_In.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // JPlaneX_In
            // 
            this.JPlaneX_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneX_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneX_In.Location = new System.Drawing.Point(123, 45);
            this.JPlaneX_In.MaxLength = 10;
            this.JPlaneX_In.Name = "JPlaneX_In";
            this.JPlaneX_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneX_In.TabIndex = 6;
            this.JPlaneX_In.Text = "0";
            // 
            // Iteration_Count
            // 
            this.Iteration_Count.AutoSize = true;
            this.Iteration_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Iteration_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Iteration_Count.Location = new System.Drawing.Point(123, 3);
            this.Iteration_Count.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Iteration_Count.Name = "Iteration_Count";
            this.Iteration_Count.Size = new System.Drawing.Size(114, 30);
            this.Iteration_Count.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "JPlane.W:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "JPlane.Z:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "JPlane.Y:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "JPlane.X:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iterations:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Epsilon_In, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Iteration_Count, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneX_In, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneY_In, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneZ_In, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneW_In, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.OutputBox, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.JCX_In, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.JCY_In, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.JCZ_In, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.JCW_In, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.renderButton, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(503, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 371);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(243, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Epsilon:";
            // 
            // Epsilon_In
            // 
            this.Epsilon_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Epsilon_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Epsilon_In.Location = new System.Drawing.Point(363, 5);
            this.Epsilon_In.MaxLength = 10;
            this.Epsilon_In.Name = "Epsilon_In";
            this.Epsilon_In.Size = new System.Drawing.Size(114, 30);
            this.Epsilon_In.TabIndex = 21;
            this.Epsilon_In.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 499);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.Text = "Julia Renderer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Iteration_Count)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Iteration_Count;
        private System.Windows.Forms.TextBox JPlaneX_In;
        private System.Windows.Forms.TextBox JPlaneY_In;
        private System.Windows.Forms.TextBox JPlaneZ_In;
        private System.Windows.Forms.TextBox JPlaneW_In;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox JCX_In;
        private System.Windows.Forms.TextBox JCY_In;
        private System.Windows.Forms.TextBox JCZ_In;
        private System.Windows.Forms.TextBox JCW_In;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.TextBox Epsilon_In;
        private System.Windows.Forms.Label label10;
    }
}

