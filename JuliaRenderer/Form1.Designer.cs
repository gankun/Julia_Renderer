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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Parameters = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EyeX_In = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Iteration_Count = new System.Windows.Forms.NumericUpDown();
            this.JPlaneX_In = new System.Windows.Forms.TextBox();
            this.JPlaneY_In = new System.Windows.Forms.TextBox();
            this.JPlaneZ_In = new System.Windows.Forms.TextBox();
            this.JPlaneW_In = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.JCX_In = new System.Windows.Forms.TextBox();
            this.JCY_In = new System.Windows.Forms.TextBox();
            this.JCZ_In = new System.Windows.Forms.TextBox();
            this.JCW_In = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UseCPU = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EyeY_In = new System.Windows.Forms.TextBox();
            this.EyeZ_In = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Epsilon_In = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Delta_In = new System.Windows.Forms.TextBox();
            this.RayTracing = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Amp_In = new System.Windows.Forms.TextBox();
            this.Shine_In = new System.Windows.Forms.TextBox();
            this.Colors = new System.Windows.Forms.TabPage();
            this.Animations = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.frames_count = new System.Windows.Forms.NumericUpDown();
            this.JPlaneX_Ani = new System.Windows.Forms.TextBox();
            this.JPlaneY_Ani = new System.Windows.Forms.TextBox();
            this.JPlaneZ_Ani = new System.Windows.Forms.TextBox();
            this.JCY_Ani = new System.Windows.Forms.TextBox();
            this.JCZ_Ani = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.JPlaneW_Ani = new System.Windows.Forms.TextBox();
            this.JCW_Ani = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.JCX_Ani = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.animateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.renderButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.LightY_In = new System.Windows.Forms.TextBox();
            this.LightZ_In = new System.Windows.Forms.TextBox();
            this.LightX_In = new System.Windows.Forms.TextBox();
            this.UseShadow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Parameters.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Iteration_Count)).BeginInit();
            this.RayTracing.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Animations.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frames_count)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.OutputBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1016, 605);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.Parameters);
            this.tabControl1.Controls.Add(this.RayTracing);
            this.tabControl1.Controls.Add(this.Colors);
            this.tabControl1.Controls.Add(this.Animations);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(510, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 478);
            this.tabControl1.TabIndex = 2;
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.tableLayoutPanel2);
            this.Parameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Parameters.Location = new System.Drawing.Point(4, 33);
            this.Parameters.Name = "Parameters";
            this.Parameters.Padding = new System.Windows.Forms.Padding(3);
            this.Parameters.Size = new System.Drawing.Size(488, 441);
            this.Parameters.TabIndex = 0;
            this.Parameters.Text = "Parameters";
            this.Parameters.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.EyeX_In, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Iteration_Count, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneX_In, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneY_In, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneZ_In, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.JPlaneW_In, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.JCX_In, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.JCY_In, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.JCZ_In, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.JCW_In, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UseCPU, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.EyeY_In, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.EyeZ_In, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.Epsilon_In, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.label22, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.Delta_In, 3, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 452);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // EyeX_In
            // 
            this.EyeX_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeX_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EyeX_In.Location = new System.Drawing.Point(127, 205);
            this.EyeX_In.MaxLength = 10;
            this.EyeX_In.Name = "EyeX_In";
            this.EyeX_In.Size = new System.Drawing.Size(114, 30);
            this.EyeX_In.TabIndex = 26;
            this.EyeX_In.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(3, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Eye.X:";
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
            // Iteration_Count
            // 
            this.Iteration_Count.AutoSize = true;
            this.Iteration_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Iteration_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Iteration_Count.Location = new System.Drawing.Point(126, 3);
            this.Iteration_Count.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Iteration_Count.Name = "Iteration_Count";
            this.Iteration_Count.Size = new System.Drawing.Size(117, 30);
            this.Iteration_Count.TabIndex = 5;
            this.Iteration_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JPlaneX_In
            // 
            this.JPlaneX_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneX_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneX_In.Location = new System.Drawing.Point(127, 45);
            this.JPlaneX_In.MaxLength = 10;
            this.JPlaneX_In.Name = "JPlaneX_In";
            this.JPlaneX_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneX_In.TabIndex = 6;
            this.JPlaneX_In.Text = "0";
            // 
            // JPlaneY_In
            // 
            this.JPlaneY_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneY_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneY_In.Location = new System.Drawing.Point(127, 85);
            this.JPlaneY_In.MaxLength = 10;
            this.JPlaneY_In.Name = "JPlaneY_In";
            this.JPlaneY_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneY_In.TabIndex = 7;
            this.JPlaneY_In.Text = "0";
            this.JPlaneY_In.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // JPlaneZ_In
            // 
            this.JPlaneZ_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneZ_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneZ_In.Location = new System.Drawing.Point(127, 125);
            this.JPlaneZ_In.MaxLength = 10;
            this.JPlaneZ_In.Name = "JPlaneZ_In";
            this.JPlaneZ_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneZ_In.TabIndex = 8;
            this.JPlaneZ_In.Text = "0";
            // 
            // JPlaneW_In
            // 
            this.JPlaneW_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneW_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneW_In.Location = new System.Drawing.Point(127, 165);
            this.JPlaneW_In.MaxLength = 10;
            this.JPlaneW_In.Name = "JPlaneW_In";
            this.JPlaneW_In.Size = new System.Drawing.Size(114, 30);
            this.JPlaneW_In.TabIndex = 9;
            this.JPlaneW_In.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(249, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "JuliaC.X:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(249, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "JuliaC.Y:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(249, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "JuliaC.Z:";
            // 
            // JCX_In
            // 
            this.JCX_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCX_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCX_In.Location = new System.Drawing.Point(373, 45);
            this.JCX_In.MaxLength = 10;
            this.JCX_In.Name = "JCX_In";
            this.JCX_In.Size = new System.Drawing.Size(114, 30);
            this.JCX_In.TabIndex = 16;
            this.JCX_In.Text = "0";
            // 
            // JCY_In
            // 
            this.JCY_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCY_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCY_In.Location = new System.Drawing.Point(373, 85);
            this.JCY_In.MaxLength = 10;
            this.JCY_In.Name = "JCY_In";
            this.JCY_In.Size = new System.Drawing.Size(114, 30);
            this.JCY_In.TabIndex = 17;
            this.JCY_In.Text = "0";
            // 
            // JCZ_In
            // 
            this.JCZ_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCZ_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCZ_In.Location = new System.Drawing.Point(373, 125);
            this.JCZ_In.MaxLength = 10;
            this.JCZ_In.Name = "JCZ_In";
            this.JCZ_In.Size = new System.Drawing.Size(114, 30);
            this.JCZ_In.TabIndex = 18;
            this.JCZ_In.Text = "0";
            // 
            // JCW_In
            // 
            this.JCW_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCW_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCW_In.Location = new System.Drawing.Point(373, 165);
            this.JCW_In.MaxLength = 10;
            this.JCW_In.Name = "JCW_In";
            this.JCW_In.Size = new System.Drawing.Size(114, 30);
            this.JCW_In.TabIndex = 19;
            this.JCW_In.Text = "0";
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
            // UseCPU
            // 
            this.UseCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UseCPU.AutoSize = true;
            this.UseCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UseCPU.Location = new System.Drawing.Point(251, 285);
            this.UseCPU.Name = "UseCPU";
            this.UseCPU.Size = new System.Drawing.Size(113, 29);
            this.UseCPU.TabIndex = 22;
            this.UseCPU.Text = "Use CPU";
            this.UseCPU.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(3, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Eye.Y:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(3, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Eye.Z:";
            // 
            // EyeY_In
            // 
            this.EyeY_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeY_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EyeY_In.Location = new System.Drawing.Point(127, 245);
            this.EyeY_In.MaxLength = 10;
            this.EyeY_In.Name = "EyeY_In";
            this.EyeY_In.Size = new System.Drawing.Size(114, 30);
            this.EyeY_In.TabIndex = 27;
            this.EyeY_In.Text = "0";
            // 
            // EyeZ_In
            // 
            this.EyeZ_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EyeZ_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EyeZ_In.Location = new System.Drawing.Point(127, 285);
            this.EyeZ_In.MaxLength = 10;
            this.EyeZ_In.Name = "EyeZ_In";
            this.EyeZ_In.Size = new System.Drawing.Size(114, 30);
            this.EyeZ_In.TabIndex = 28;
            this.EyeZ_In.Text = "4";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(249, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "JuliaC.W:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(249, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Epsilon:";
            // 
            // Epsilon_In
            // 
            this.Epsilon_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Epsilon_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Epsilon_In.Location = new System.Drawing.Point(373, 205);
            this.Epsilon_In.MaxLength = 10;
            this.Epsilon_In.Name = "Epsilon_In";
            this.Epsilon_In.Size = new System.Drawing.Size(114, 30);
            this.Epsilon_In.TabIndex = 21;
            this.Epsilon_In.Text = "0.01";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label22.Location = new System.Drawing.Point(249, 248);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 24);
            this.label22.TabIndex = 29;
            this.label22.Text = "Delta:";
            // 
            // Delta_In
            // 
            this.Delta_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delta_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delta_In.Location = new System.Drawing.Point(373, 245);
            this.Delta_In.MaxLength = 10;
            this.Delta_In.Name = "Delta_In";
            this.Delta_In.Size = new System.Drawing.Size(114, 30);
            this.Delta_In.TabIndex = 30;
            this.Delta_In.Text = "0.01";
            // 
            // RayTracing
            // 
            this.RayTracing.Controls.Add(this.tableLayoutPanel4);
            this.RayTracing.Location = new System.Drawing.Point(4, 33);
            this.RayTracing.Name = "RayTracing";
            this.RayTracing.Size = new System.Drawing.Size(488, 441);
            this.RayTracing.TabIndex = 2;
            this.RayTracing.Text = "RayTracing";
            this.RayTracing.UseVisualStyleBackColor = true;
            this.RayTracing.Click += new System.EventHandler(this.RayTracing_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Amp_In, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Shine_In, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label27, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label28, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label29, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.LightX_In, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.LightY_In, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.LightZ_In, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.UseShadow, 2, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 10;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(492, 452);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(3, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 24);
            this.label16.TabIndex = 1;
            this.label16.Text = "Amplitude:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(3, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "Shine:";
            // 
            // Amp_In
            // 
            this.Amp_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Amp_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Amp_In.Location = new System.Drawing.Point(127, 45);
            this.Amp_In.MaxLength = 10;
            this.Amp_In.Name = "Amp_In";
            this.Amp_In.Size = new System.Drawing.Size(114, 30);
            this.Amp_In.TabIndex = 6;
            this.Amp_In.Text = "0.4";
            // 
            // Shine_In
            // 
            this.Shine_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Shine_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Shine_In.Location = new System.Drawing.Point(127, 85);
            this.Shine_In.MaxLength = 10;
            this.Shine_In.Name = "Shine_In";
            this.Shine_In.Size = new System.Drawing.Size(114, 30);
            this.Shine_In.TabIndex = 7;
            this.Shine_In.Text = "6";
            // 
            // Colors
            // 
            this.Colors.Location = new System.Drawing.Point(4, 33);
            this.Colors.Name = "Colors";
            this.Colors.Padding = new System.Windows.Forms.Padding(3);
            this.Colors.Size = new System.Drawing.Size(488, 441);
            this.Colors.TabIndex = 1;
            this.Colors.Text = "Colors";
            this.Colors.UseVisualStyleBackColor = true;
            // 
            // Animations
            // 
            this.Animations.Controls.Add(this.tableLayoutPanel5);
            this.Animations.Location = new System.Drawing.Point(4, 33);
            this.Animations.Name = "Animations";
            this.Animations.Size = new System.Drawing.Size(488, 441);
            this.Animations.TabIndex = 3;
            this.Animations.Text = "Animations";
            this.Animations.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.frames_count, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.JPlaneX_Ani, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.JPlaneY_Ani, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.JPlaneZ_Ani, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.JCY_Ani, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.JCZ_Ani, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.JPlaneW_Ani, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.JCW_Ani, 3, 5);
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label21, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label25, 2, 5);
            this.tableLayoutPanel5.Controls.Add(this.label23, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.label24, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.JCX_Ani, 3, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 11;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(492, 434);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(3, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "END";
            // 
            // frames_count
            // 
            this.frames_count.AutoSize = true;
            this.frames_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frames_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.frames_count.Location = new System.Drawing.Point(126, 3);
            this.frames_count.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.frames_count.Name = "frames_count";
            this.frames_count.Size = new System.Drawing.Size(117, 30);
            this.frames_count.TabIndex = 5;
            // 
            // JPlaneX_Ani
            // 
            this.JPlaneX_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneX_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneX_Ani.Location = new System.Drawing.Point(127, 85);
            this.JPlaneX_Ani.MaxLength = 10;
            this.JPlaneX_Ani.Name = "JPlaneX_Ani";
            this.JPlaneX_Ani.Size = new System.Drawing.Size(114, 30);
            this.JPlaneX_Ani.TabIndex = 7;
            this.JPlaneX_Ani.Text = "0";
            // 
            // JPlaneY_Ani
            // 
            this.JPlaneY_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneY_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneY_Ani.Location = new System.Drawing.Point(127, 125);
            this.JPlaneY_Ani.MaxLength = 10;
            this.JPlaneY_Ani.Name = "JPlaneY_Ani";
            this.JPlaneY_Ani.Size = new System.Drawing.Size(114, 30);
            this.JPlaneY_Ani.TabIndex = 8;
            this.JPlaneY_Ani.Text = "0";
            // 
            // JPlaneZ_Ani
            // 
            this.JPlaneZ_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneZ_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneZ_Ani.Location = new System.Drawing.Point(127, 165);
            this.JPlaneZ_Ani.MaxLength = 10;
            this.JPlaneZ_Ani.Name = "JPlaneZ_Ani";
            this.JPlaneZ_Ani.Size = new System.Drawing.Size(114, 30);
            this.JPlaneZ_Ani.TabIndex = 9;
            this.JPlaneZ_Ani.Text = "0";
            // 
            // JCY_Ani
            // 
            this.JCY_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCY_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCY_Ani.Location = new System.Drawing.Point(373, 125);
            this.JCY_Ani.MaxLength = 10;
            this.JCY_Ani.Name = "JCY_Ani";
            this.JCY_Ani.Size = new System.Drawing.Size(114, 30);
            this.JCY_Ani.TabIndex = 18;
            this.JCY_Ani.Text = "0";
            // 
            // JCZ_Ani
            // 
            this.JCZ_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCZ_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCZ_Ani.Location = new System.Drawing.Point(373, 165);
            this.JCZ_Ani.MaxLength = 10;
            this.JCZ_Ani.Name = "JCZ_Ani";
            this.JCZ_Ani.Size = new System.Drawing.Size(114, 30);
            this.JCZ_Ani.TabIndex = 19;
            this.JCZ_Ani.Text = "0";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label26.Location = new System.Drawing.Point(3, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 24);
            this.label26.TabIndex = 0;
            this.label26.Text = "Frames:";
            // 
            // JPlaneW_Ani
            // 
            this.JPlaneW_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JPlaneW_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JPlaneW_Ani.Location = new System.Drawing.Point(127, 205);
            this.JPlaneW_Ani.MaxLength = 10;
            this.JPlaneW_Ani.Name = "JPlaneW_Ani";
            this.JPlaneW_Ani.Size = new System.Drawing.Size(114, 30);
            this.JPlaneW_Ani.TabIndex = 21;
            this.JPlaneW_Ani.Text = "0";
            // 
            // JCW_Ani
            // 
            this.JCW_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCW_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCW_Ani.Location = new System.Drawing.Point(373, 205);
            this.JCW_Ani.MaxLength = 10;
            this.JCW_Ani.Name = "JCW_Ani";
            this.JCW_Ani.Size = new System.Drawing.Size(114, 30);
            this.JCW_Ani.TabIndex = 23;
            this.JCW_Ani.Text = "0";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(3, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 24);
            this.label20.TabIndex = 3;
            this.label20.Text = "JPlane.Z:";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(3, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "JPlane.Y:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(3, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "JPlane.X:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(3, 208);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 24);
            this.label21.TabIndex = 4;
            this.label21.Text = "JPlane.W:";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label25.Location = new System.Drawing.Point(249, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 24);
            this.label25.TabIndex = 15;
            this.label25.Text = "JuliaC.W:";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(249, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 24);
            this.label23.TabIndex = 13;
            this.label23.Text = "JuliaC.Y:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(249, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "JuliaC.X:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label24.Location = new System.Drawing.Point(249, 168);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 24);
            this.label24.TabIndex = 14;
            this.label24.Text = "JuliaC.Z:";
            // 
            // JCX_Ani
            // 
            this.JCX_Ani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JCX_Ani.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JCX_Ani.Location = new System.Drawing.Point(373, 85);
            this.JCX_Ani.MaxLength = 10;
            this.JCX_Ani.Name = "JCX_Ani";
            this.JCX_Ani.Size = new System.Drawing.Size(114, 30);
            this.JCX_Ani.TabIndex = 17;
            this.JCX_Ani.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.animateButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.renderButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(503, 503);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 99);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // animateButton
            // 
            this.animateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.animateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animateButton.Location = new System.Drawing.Point(3, 52);
            this.animateButton.Name = "animateButton";
            this.animateButton.Size = new System.Drawing.Size(249, 43);
            this.animateButton.TabIndex = 12;
            this.animateButton.Text = "Animate";
            this.animateButton.UseVisualStyleBackColor = true;
            this.animateButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(258, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(249, 43);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // renderButton
            // 
            this.renderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.renderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.renderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renderButton.Location = new System.Drawing.Point(3, 3);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(249, 43);
            this.renderButton.TabIndex = 10;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click_1);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(3, 503);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(494, 99);
            this.OutputBox.TabIndex = 11;
            this.OutputBox.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ppm";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label27.Location = new System.Drawing.Point(3, 168);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 24);
            this.label27.TabIndex = 8;
            this.label27.Text = "Light.X:";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label28.Location = new System.Drawing.Point(3, 208);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 24);
            this.label28.TabIndex = 9;
            this.label28.Text = "Light.Y:";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label29.Location = new System.Drawing.Point(3, 248);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 24);
            this.label29.TabIndex = 10;
            this.label29.Text = "Light.Z:";
            // 
            // LightY_In
            // 
            this.LightY_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightY_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LightY_In.Location = new System.Drawing.Point(127, 205);
            this.LightY_In.MaxLength = 10;
            this.LightY_In.Name = "LightY_In";
            this.LightY_In.Size = new System.Drawing.Size(114, 30);
            this.LightY_In.TabIndex = 11;
            this.LightY_In.Text = "2";
            // 
            // LightZ_In
            // 
            this.LightZ_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightZ_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LightZ_In.Location = new System.Drawing.Point(127, 245);
            this.LightZ_In.MaxLength = 10;
            this.LightZ_In.Name = "LightZ_In";
            this.LightZ_In.Size = new System.Drawing.Size(114, 30);
            this.LightZ_In.TabIndex = 12;
            this.LightZ_In.Text = "3";
            // 
            // LightX_In
            // 
            this.LightX_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightX_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LightX_In.Location = new System.Drawing.Point(127, 165);
            this.LightX_In.MaxLength = 10;
            this.LightX_In.Name = "LightX_In";
            this.LightX_In.Size = new System.Drawing.Size(114, 30);
            this.LightX_In.TabIndex = 13;
            this.LightX_In.Text = "2";
            // 
            // UseShadow
            // 
            this.UseShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UseShadow.AutoSize = true;
            this.UseShadow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UseShadow.Location = new System.Drawing.Point(251, 45);
            this.UseShadow.Name = "UseShadow";
            this.UseShadow.Size = new System.Drawing.Size(113, 29);
            this.UseShadow.TabIndex = 23;
            this.UseShadow.Text = "Use CPU";
            this.UseShadow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 629);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.Text = "Julia Renderer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Parameters.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Iteration_Count)).EndInit();
            this.RayTracing.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.Animations.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frames_count)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox UseCPU;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Parameters;
        private System.Windows.Forms.TextBox EyeX_In;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EyeY_In;
        private System.Windows.Forms.TextBox EyeZ_In;
        private System.Windows.Forms.TabPage Colors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage RayTracing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Amp_In;
        private System.Windows.Forms.TextBox Shine_In;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage Animations;
        private System.Windows.Forms.Button animateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown frames_count;
        private System.Windows.Forms.TextBox JPlaneX_Ani;
        private System.Windows.Forms.TextBox JPlaneY_Ani;
        private System.Windows.Forms.TextBox JPlaneZ_Ani;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox JCX_Ani;
        private System.Windows.Forms.TextBox JCY_Ani;
        private System.Windows.Forms.TextBox JCZ_Ani;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox JPlaneW_Ani;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox JCW_Ani;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Delta_In;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox LightX_In;
        private System.Windows.Forms.TextBox LightY_In;
        private System.Windows.Forms.TextBox LightZ_In;
        private System.Windows.Forms.CheckBox UseShadow;
    }
}

