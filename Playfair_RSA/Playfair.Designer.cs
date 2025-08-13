namespace Playfair_RSA
{
    partial class Playfair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playfair));
            this.NamePanel = new System.Windows.Forms.Panel();
            this.BackPic = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.Openbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OutputText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.radio6x6 = new System.Windows.Forms.RadioButton();
            this.radio5x5 = new System.Windows.Forms.RadioButton();
            this.MatrixLbl = new System.Windows.Forms.Label();
            this.MatrixPnl = new System.Windows.Forms.Panel();
            this.A36 = new System.Windows.Forms.TextBox();
            this.A35 = new System.Windows.Forms.TextBox();
            this.A34 = new System.Windows.Forms.TextBox();
            this.A33 = new System.Windows.Forms.TextBox();
            this.A32 = new System.Windows.Forms.TextBox();
            this.A31 = new System.Windows.Forms.TextBox();
            this.A30 = new System.Windows.Forms.TextBox();
            this.A29 = new System.Windows.Forms.TextBox();
            this.A28 = new System.Windows.Forms.TextBox();
            this.A27 = new System.Windows.Forms.TextBox();
            this.A26 = new System.Windows.Forms.TextBox();
            this.A25 = new System.Windows.Forms.TextBox();
            this.A24 = new System.Windows.Forms.TextBox();
            this.A23 = new System.Windows.Forms.TextBox();
            this.A22 = new System.Windows.Forms.TextBox();
            this.A21 = new System.Windows.Forms.TextBox();
            this.A20 = new System.Windows.Forms.TextBox();
            this.A19 = new System.Windows.Forms.TextBox();
            this.A18 = new System.Windows.Forms.TextBox();
            this.A17 = new System.Windows.Forms.TextBox();
            this.A16 = new System.Windows.Forms.TextBox();
            this.A15 = new System.Windows.Forms.TextBox();
            this.A14 = new System.Windows.Forms.TextBox();
            this.A13 = new System.Windows.Forms.TextBox();
            this.A12 = new System.Windows.Forms.TextBox();
            this.A11 = new System.Windows.Forms.TextBox();
            this.A10 = new System.Windows.Forms.TextBox();
            this.A9 = new System.Windows.Forms.TextBox();
            this.A8 = new System.Windows.Forms.TextBox();
            this.A7 = new System.Windows.Forms.TextBox();
            this.A6 = new System.Windows.Forms.TextBox();
            this.A5 = new System.Windows.Forms.TextBox();
            this.A4 = new System.Windows.Forms.TextBox();
            this.A3 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.EnterKeyText = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MatrixPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NamePanel.Controls.Add(this.BackPic);
            this.NamePanel.Controls.Add(this.NameLabel);
            this.NamePanel.Location = new System.Drawing.Point(12, 12);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(911, 87);
            this.NamePanel.TabIndex = 1;
            // 
            // BackPic
            // 
            this.BackPic.BackgroundImage = global::Playfair_RSA.Properties.Resources.icons8_back_100;
            this.BackPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackPic.Location = new System.Drawing.Point(21, 16);
            this.BackPic.Name = "BackPic";
            this.BackPic.Size = new System.Drawing.Size(56, 53);
            this.BackPic.TabIndex = 1;
            this.BackPic.TabStop = false;
            this.BackPic.Click += new System.EventHandler(this.BackPic_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(90, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(343, 52);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Playfair Cipher";
            // 
            // SwapBtn
            // 
            this.SwapBtn.BackColor = System.Drawing.SystemColors.Window;
            this.SwapBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SwapBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SwapBtn.Location = new System.Drawing.Point(181, 5);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(162, 38);
            this.SwapBtn.TabIndex = 13;
            this.SwapBtn.Text = "Swap to Decrypt";
            this.SwapBtn.UseVisualStyleBackColor = false;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExportBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ExportBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExportBtn.Location = new System.Drawing.Point(349, 5);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(94, 38);
            this.ExportBtn.TabIndex = 12;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // Openbtn
            // 
            this.Openbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Openbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Openbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Openbtn.Location = new System.Drawing.Point(351, 4);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(81, 38);
            this.Openbtn.TabIndex = 15;
            this.Openbtn.Text = "Open";
            this.Openbtn.UseVisualStyleBackColor = false;
            this.Openbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InputText);
            this.panel1.Controls.Add(this.Openbtn);
            this.panel1.Location = new System.Drawing.Point(15, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 243);
            this.panel1.TabIndex = 16;
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.Color.AliceBlue;
            this.InputText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.InputText.Location = new System.Drawing.Point(6, 48);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(426, 182);
            this.InputText.TabIndex = 16;
            this.InputText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Input";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.OutputText);
            this.panel2.Controls.Add(this.SwapBtn);
            this.panel2.Controls.Add(this.ExportBtn);
            this.panel2.Location = new System.Drawing.Point(464, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 612);
            this.panel2.TabIndex = 19;
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.Color.AliceBlue;
            this.OutputText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.OutputText.Location = new System.Drawing.Point(12, 48);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(431, 550);
            this.OutputText.TabIndex = 17;
            this.OutputText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(494, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Output";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DecryptBtn);
            this.panel3.Controls.Add(this.EncryptBtn);
            this.panel3.Controls.Add(this.radio6x6);
            this.panel3.Controls.Add(this.radio5x5);
            this.panel3.Controls.Add(this.MatrixLbl);
            this.panel3.Controls.Add(this.MatrixPnl);
            this.panel3.Controls.Add(this.EnterKeyText);
            this.panel3.Controls.Add(this.Key);
            this.panel3.Location = new System.Drawing.Point(15, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 352);
            this.panel3.TabIndex = 17;
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DecryptBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DecryptBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DecryptBtn.Location = new System.Drawing.Point(321, 215);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(108, 38);
            this.DecryptBtn.TabIndex = 23;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = false;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EncryptBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.EncryptBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EncryptBtn.Location = new System.Drawing.Point(320, 171);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(108, 38);
            this.EncryptBtn.TabIndex = 22;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = false;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // radio6x6
            // 
            this.radio6x6.AutoSize = true;
            this.radio6x6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio6x6.Location = new System.Drawing.Point(320, 123);
            this.radio6x6.Name = "radio6x6";
            this.radio6x6.Size = new System.Drawing.Size(57, 25);
            this.radio6x6.TabIndex = 21;
            this.radio6x6.Text = "6x6";
            this.radio6x6.UseVisualStyleBackColor = true;
            this.radio6x6.CheckedChanged += new System.EventHandler(this.radio6x6_CheckedChanged);
            // 
            // radio5x5
            // 
            this.radio5x5.AutoSize = true;
            this.radio5x5.Checked = true;
            this.radio5x5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radio5x5.Location = new System.Drawing.Point(320, 92);
            this.radio5x5.Name = "radio5x5";
            this.radio5x5.Size = new System.Drawing.Size(57, 25);
            this.radio5x5.TabIndex = 20;
            this.radio5x5.TabStop = true;
            this.radio5x5.Text = "5x5";
            this.radio5x5.UseVisualStyleBackColor = true;
            this.radio5x5.CheckedChanged += new System.EventHandler(this.radio5x5_CheckedChanged);
            // 
            // MatrixLbl
            // 
            this.MatrixLbl.AutoSize = true;
            this.MatrixLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MatrixLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MatrixLbl.Location = new System.Drawing.Point(21, 68);
            this.MatrixLbl.Name = "MatrixLbl";
            this.MatrixLbl.Size = new System.Drawing.Size(56, 21);
            this.MatrixLbl.TabIndex = 19;
            this.MatrixLbl.Text = "Matrix";
            // 
            // MatrixPnl
            // 
            this.MatrixPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatrixPnl.Controls.Add(this.A36);
            this.MatrixPnl.Controls.Add(this.A35);
            this.MatrixPnl.Controls.Add(this.A34);
            this.MatrixPnl.Controls.Add(this.A33);
            this.MatrixPnl.Controls.Add(this.A32);
            this.MatrixPnl.Controls.Add(this.A31);
            this.MatrixPnl.Controls.Add(this.A30);
            this.MatrixPnl.Controls.Add(this.A29);
            this.MatrixPnl.Controls.Add(this.A28);
            this.MatrixPnl.Controls.Add(this.A27);
            this.MatrixPnl.Controls.Add(this.A26);
            this.MatrixPnl.Controls.Add(this.A25);
            this.MatrixPnl.Controls.Add(this.A24);
            this.MatrixPnl.Controls.Add(this.A23);
            this.MatrixPnl.Controls.Add(this.A22);
            this.MatrixPnl.Controls.Add(this.A21);
            this.MatrixPnl.Controls.Add(this.A20);
            this.MatrixPnl.Controls.Add(this.A19);
            this.MatrixPnl.Controls.Add(this.A18);
            this.MatrixPnl.Controls.Add(this.A17);
            this.MatrixPnl.Controls.Add(this.A16);
            this.MatrixPnl.Controls.Add(this.A15);
            this.MatrixPnl.Controls.Add(this.A14);
            this.MatrixPnl.Controls.Add(this.A13);
            this.MatrixPnl.Controls.Add(this.A12);
            this.MatrixPnl.Controls.Add(this.A11);
            this.MatrixPnl.Controls.Add(this.A10);
            this.MatrixPnl.Controls.Add(this.A9);
            this.MatrixPnl.Controls.Add(this.A8);
            this.MatrixPnl.Controls.Add(this.A7);
            this.MatrixPnl.Controls.Add(this.A6);
            this.MatrixPnl.Controls.Add(this.A5);
            this.MatrixPnl.Controls.Add(this.A4);
            this.MatrixPnl.Controls.Add(this.A3);
            this.MatrixPnl.Controls.Add(this.A2);
            this.MatrixPnl.Controls.Add(this.A1);
            this.MatrixPnl.Location = new System.Drawing.Point(7, 84);
            this.MatrixPnl.Name = "MatrixPnl";
            this.MatrixPnl.Size = new System.Drawing.Size(299, 254);
            this.MatrixPnl.TabIndex = 18;
            // 
            // A36
            // 
            this.A36.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A36.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A36.Location = new System.Drawing.Point(243, 212);
            this.A36.Name = "A36";
            this.A36.Size = new System.Drawing.Size(40, 35);
            this.A36.TabIndex = 36;
            this.A36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A35
            // 
            this.A35.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A35.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A35.Location = new System.Drawing.Point(197, 212);
            this.A35.Name = "A35";
            this.A35.Size = new System.Drawing.Size(40, 35);
            this.A35.TabIndex = 35;
            this.A35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A34
            // 
            this.A34.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A34.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A34.Location = new System.Drawing.Point(151, 212);
            this.A34.Name = "A34";
            this.A34.Size = new System.Drawing.Size(40, 35);
            this.A34.TabIndex = 34;
            this.A34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A33
            // 
            this.A33.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A33.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A33.Location = new System.Drawing.Point(105, 212);
            this.A33.Name = "A33";
            this.A33.Size = new System.Drawing.Size(40, 35);
            this.A33.TabIndex = 33;
            this.A33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A32
            // 
            this.A32.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A32.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A32.Location = new System.Drawing.Point(59, 212);
            this.A32.Name = "A32";
            this.A32.Size = new System.Drawing.Size(40, 35);
            this.A32.TabIndex = 32;
            this.A32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A31
            // 
            this.A31.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A31.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A31.Location = new System.Drawing.Point(13, 212);
            this.A31.Name = "A31";
            this.A31.Size = new System.Drawing.Size(40, 35);
            this.A31.TabIndex = 31;
            this.A31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A30
            // 
            this.A30.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A30.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A30.Location = new System.Drawing.Point(243, 171);
            this.A30.Name = "A30";
            this.A30.Size = new System.Drawing.Size(40, 35);
            this.A30.TabIndex = 30;
            this.A30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A29
            // 
            this.A29.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A29.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A29.Location = new System.Drawing.Point(197, 171);
            this.A29.Name = "A29";
            this.A29.Size = new System.Drawing.Size(40, 35);
            this.A29.TabIndex = 29;
            this.A29.Text = "Z";
            this.A29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A28
            // 
            this.A28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A28.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A28.Location = new System.Drawing.Point(151, 171);
            this.A28.Name = "A28";
            this.A28.Size = new System.Drawing.Size(40, 35);
            this.A28.TabIndex = 28;
            this.A28.Text = "Y";
            this.A28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A27
            // 
            this.A27.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A27.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A27.Location = new System.Drawing.Point(105, 171);
            this.A27.Name = "A27";
            this.A27.Size = new System.Drawing.Size(40, 35);
            this.A27.TabIndex = 27;
            this.A27.Text = "X";
            this.A27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A26
            // 
            this.A26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A26.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A26.Location = new System.Drawing.Point(59, 171);
            this.A26.Name = "A26";
            this.A26.Size = new System.Drawing.Size(40, 35);
            this.A26.TabIndex = 26;
            this.A26.Text = "W";
            this.A26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A25
            // 
            this.A25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A25.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A25.Location = new System.Drawing.Point(13, 171);
            this.A25.Name = "A25";
            this.A25.Size = new System.Drawing.Size(40, 35);
            this.A25.TabIndex = 25;
            this.A25.Tag = "";
            this.A25.Text = "V";
            this.A25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A24
            // 
            this.A24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A24.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A24.Location = new System.Drawing.Point(243, 130);
            this.A24.Name = "A24";
            this.A24.Size = new System.Drawing.Size(40, 35);
            this.A24.TabIndex = 24;
            this.A24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A23
            // 
            this.A23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A23.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A23.Location = new System.Drawing.Point(197, 130);
            this.A23.Name = "A23";
            this.A23.Size = new System.Drawing.Size(40, 35);
            this.A23.TabIndex = 23;
            this.A23.Text = "U";
            this.A23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A22
            // 
            this.A22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A22.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A22.Location = new System.Drawing.Point(151, 130);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(40, 35);
            this.A22.TabIndex = 22;
            this.A22.Text = "T";
            this.A22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A21
            // 
            this.A21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A21.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A21.Location = new System.Drawing.Point(105, 130);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(40, 35);
            this.A21.TabIndex = 21;
            this.A21.Text = "S";
            this.A21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A20
            // 
            this.A20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A20.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A20.Location = new System.Drawing.Point(59, 130);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(40, 35);
            this.A20.TabIndex = 20;
            this.A20.Text = "R";
            this.A20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A19
            // 
            this.A19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A19.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A19.Location = new System.Drawing.Point(13, 130);
            this.A19.Name = "A19";
            this.A19.Size = new System.Drawing.Size(40, 35);
            this.A19.TabIndex = 19;
            this.A19.Text = "Q";
            this.A19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A18
            // 
            this.A18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A18.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A18.Location = new System.Drawing.Point(243, 89);
            this.A18.Name = "A18";
            this.A18.Size = new System.Drawing.Size(40, 35);
            this.A18.TabIndex = 18;
            this.A18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A17
            // 
            this.A17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A17.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A17.Location = new System.Drawing.Point(197, 89);
            this.A17.Name = "A17";
            this.A17.Size = new System.Drawing.Size(40, 35);
            this.A17.TabIndex = 17;
            this.A17.Text = "P";
            this.A17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A16
            // 
            this.A16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A16.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A16.Location = new System.Drawing.Point(151, 89);
            this.A16.Name = "A16";
            this.A16.Size = new System.Drawing.Size(40, 35);
            this.A16.TabIndex = 16;
            this.A16.Text = "O";
            this.A16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A15
            // 
            this.A15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A15.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A15.Location = new System.Drawing.Point(105, 89);
            this.A15.Name = "A15";
            this.A15.Size = new System.Drawing.Size(40, 35);
            this.A15.TabIndex = 15;
            this.A15.Text = "N";
            this.A15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A14
            // 
            this.A14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A14.Location = new System.Drawing.Point(59, 89);
            this.A14.Name = "A14";
            this.A14.Size = new System.Drawing.Size(40, 35);
            this.A14.TabIndex = 14;
            this.A14.Text = "M";
            this.A14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A13
            // 
            this.A13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A13.Location = new System.Drawing.Point(13, 89);
            this.A13.Name = "A13";
            this.A13.Size = new System.Drawing.Size(40, 35);
            this.A13.TabIndex = 13;
            this.A13.Text = "L";
            this.A13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A12
            // 
            this.A12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A12.Location = new System.Drawing.Point(243, 48);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(40, 35);
            this.A12.TabIndex = 12;
            this.A12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A11
            // 
            this.A11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A11.Location = new System.Drawing.Point(197, 48);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(40, 35);
            this.A11.TabIndex = 11;
            this.A11.Text = "K";
            this.A11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A10
            // 
            this.A10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A10.Location = new System.Drawing.Point(151, 48);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(40, 35);
            this.A10.TabIndex = 10;
            this.A10.Text = "I";
            this.A10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A9
            // 
            this.A9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A9.Location = new System.Drawing.Point(105, 48);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(40, 35);
            this.A9.TabIndex = 9;
            this.A9.Text = "H";
            this.A9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A8
            // 
            this.A8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A8.Location = new System.Drawing.Point(59, 48);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(40, 35);
            this.A8.TabIndex = 8;
            this.A8.Text = "G";
            this.A8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A7
            // 
            this.A7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A7.Location = new System.Drawing.Point(13, 48);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(40, 35);
            this.A7.TabIndex = 7;
            this.A7.Text = "F";
            this.A7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A6
            // 
            this.A6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A6.Location = new System.Drawing.Point(243, 7);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(40, 35);
            this.A6.TabIndex = 6;
            this.A6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A5
            // 
            this.A5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A5.Location = new System.Drawing.Point(197, 7);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(40, 35);
            this.A5.TabIndex = 5;
            this.A5.Text = "E";
            this.A5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A4.Location = new System.Drawing.Point(151, 7);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(40, 35);
            this.A4.TabIndex = 4;
            this.A4.Text = "D";
            this.A4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.A3.Location = new System.Drawing.Point(105, 7);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(40, 35);
            this.A3.TabIndex = 3;
            this.A3.Text = "C";
            this.A3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A2.Location = new System.Drawing.Point(59, 7);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(40, 35);
            this.A2.TabIndex = 2;
            this.A2.Text = "B";
            this.A2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A1.Location = new System.Drawing.Point(13, 7);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(40, 35);
            this.A1.TabIndex = 1;
            this.A1.Text = "A";
            this.A1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterKeyText
            // 
            this.EnterKeyText.AutoSize = true;
            this.EnterKeyText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.EnterKeyText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EnterKeyText.Location = new System.Drawing.Point(3, 11);
            this.EnterKeyText.Name = "EnterKeyText";
            this.EnterKeyText.Size = new System.Drawing.Size(109, 21);
            this.EnterKeyText.TabIndex = 18;
            this.EnterKeyText.Text = "Enter the key";
            // 
            // Key
            // 
            this.Key.BackColor = System.Drawing.Color.AliceBlue;
            this.Key.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Key.Location = new System.Drawing.Point(6, 33);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(423, 32);
            this.Key.TabIndex = 1;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(31, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Playfair Key";
            // 
            // Playfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 752);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Playfair";
            this.Text = "Playfair";
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.MatrixPnl.ResumeLayout(false);
            this.MatrixPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox BackPic;
        private System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox OutputText;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label EnterKeyText;
        private System.Windows.Forms.Panel MatrixPnl;
        private System.Windows.Forms.TextBox A24;
        private System.Windows.Forms.TextBox A23;
        private System.Windows.Forms.TextBox A22;
        private System.Windows.Forms.TextBox A21;
        private System.Windows.Forms.TextBox A20;
        private System.Windows.Forms.TextBox A19;
        private System.Windows.Forms.TextBox A18;
        private System.Windows.Forms.TextBox A17;
        private System.Windows.Forms.TextBox A16;
        private System.Windows.Forms.TextBox A15;
        private System.Windows.Forms.TextBox A14;
        private System.Windows.Forms.TextBox A13;
        private System.Windows.Forms.TextBox A12;
        private System.Windows.Forms.TextBox A11;
        private System.Windows.Forms.TextBox A10;
        private System.Windows.Forms.TextBox A9;
        private System.Windows.Forms.TextBox A8;
        private System.Windows.Forms.TextBox A7;
        private System.Windows.Forms.TextBox A6;
        private System.Windows.Forms.TextBox A5;
        private System.Windows.Forms.TextBox A4;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox A36;
        private System.Windows.Forms.TextBox A35;
        private System.Windows.Forms.TextBox A34;
        private System.Windows.Forms.TextBox A33;
        private System.Windows.Forms.TextBox A32;
        private System.Windows.Forms.TextBox A31;
        private System.Windows.Forms.TextBox A30;
        private System.Windows.Forms.TextBox A29;
        private System.Windows.Forms.TextBox A28;
        private System.Windows.Forms.TextBox A27;
        private System.Windows.Forms.TextBox A26;
        private System.Windows.Forms.TextBox A25;
        private System.Windows.Forms.Label MatrixLbl;
        private System.Windows.Forms.RadioButton radio6x6;
        private System.Windows.Forms.RadioButton radio5x5;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Button EncryptBtn;
    }
}