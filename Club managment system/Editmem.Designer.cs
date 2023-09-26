namespace Club_managment_system
{
    partial class Editmem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editmem));
            this.Valid = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.pos = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.province = new System.Windows.Forms.ComboBox();
            this.Dep = new System.Windows.Forms.ComboBox();
            this.Dob = new System.Windows.Forms.DateTimePicker();
            this.Pmail = new System.Windows.Forms.TextBox();
            this.ContNum = new System.Windows.Forms.TextBox();
            this.KDUmail = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.FullN = new System.Windows.Forms.TextBox();
            this.intake = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.indexNum = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Valid
            // 
            this.Valid.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Valid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Valid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valid.ForeColor = System.Drawing.Color.White;
            this.Valid.Location = new System.Drawing.Point(659, 235);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(128, 38);
            this.Valid.TabIndex = 54;
            this.Valid.Text = "Vaildity";
            this.Valid.UseVisualStyleBackColor = false;
            this.Valid.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(414, 240);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(219, 28);
            this.search.TabIndex = 53;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // pos
            // 
            this.pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.FormattingEnabled = true;
            this.pos.Items.AddRange(new object[] {
            "President",
            "Vice President",
            "Secretary",
            "Vice Securetary",
            "Treasurer",
            "Executive Commitee",
            "District Leaders",
            "General Member",
            "Prospect"});
            this.pos.Location = new System.Drawing.Point(491, 417);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(170, 26);
            this.pos.TabIndex = 89;
            this.pos.Text = "----Select----";
            this.pos.SelectedIndexChanged += new System.EventHandler(this.pos_SelectedIndexChanged);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(570, 628);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(128, 37);
            this.reset.TabIndex = 87;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(411, 628);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(128, 37);
            this.Submit.TabIndex = 86;
            this.Submit.Text = "Update";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(166, 457);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(532, 111);
            this.Address.TabIndex = 85;
            this.Address.Text = "";
            // 
            // province
            // 
            this.province.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province.FormattingEnabled = true;
            this.province.Items.AddRange(new object[] {
            "Northern ",
            "North Central",
            "North Western",
            "Western",
            "Southern",
            "Sabaragamuwa",
            "Central",
            "Uva",
            "Eastern"});
            this.province.Location = new System.Drawing.Point(830, 464);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(208, 26);
            this.province.TabIndex = 84;
            this.province.Text = "----Select----";
            // 
            // Dep
            // 
            this.Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep.FormattingEnabled = true;
            this.Dep.Items.AddRange(new object[] {
            "Information Technology",
            "Information System",
            "Information and Communication Technology",
            "Quantity Surveying ",
            "Surveying Sciences",
            "Architecture"});
            this.Dep.Location = new System.Drawing.Point(586, 373);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(241, 26);
            this.Dep.TabIndex = 83;
            this.Dep.Text = "----Select----";
            // 
            // Dob
            // 
            this.Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dob.Location = new System.Drawing.Point(166, 417);
            this.Dob.Name = "Dob";
            this.Dob.Size = new System.Drawing.Size(208, 24);
            this.Dob.TabIndex = 82;
            // 
            // Pmail
            // 
            this.Pmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pmail.Location = new System.Drawing.Point(490, 578);
            this.Pmail.Name = "Pmail";
            this.Pmail.Size = new System.Drawing.Size(208, 28);
            this.Pmail.TabIndex = 79;
            // 
            // ContNum
            // 
            this.ContNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContNum.Location = new System.Drawing.Point(830, 415);
            this.ContNum.Name = "ContNum";
            this.ContNum.Size = new System.Drawing.Size(208, 28);
            this.ContNum.TabIndex = 78;
            // 
            // KDUmail
            // 
            this.KDUmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KDUmail.Location = new System.Drawing.Point(129, 578);
            this.KDUmail.Name = "KDUmail";
            this.KDUmail.Size = new System.Drawing.Size(208, 28);
            this.KDUmail.TabIndex = 77;
            // 
            // zip
            // 
            this.zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zip.Location = new System.Drawing.Point(830, 544);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(208, 28);
            this.zip.TabIndex = 76;
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(830, 504);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(208, 28);
            this.City.TabIndex = 75;
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(518, 328);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(208, 28);
            this.Lname.TabIndex = 74;
            // 
            // FullN
            // 
            this.FullN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullN.Location = new System.Drawing.Point(518, 286);
            this.FullN.Name = "FullN";
            this.FullN.Size = new System.Drawing.Size(520, 28);
            this.FullN.TabIndex = 73;
            // 
            // intake
            // 
            this.intake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intake.Location = new System.Drawing.Point(167, 370);
            this.intake.Name = "intake";
            this.intake.Size = new System.Drawing.Size(208, 28);
            this.intake.TabIndex = 72;
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(166, 328);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(208, 28);
            this.Fname.TabIndex = 71;
            // 
            // indexNum
            // 
            this.indexNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexNum.Location = new System.Drawing.Point(166, 286);
            this.indexNum.Name = "indexNum";
            this.indexNum.Size = new System.Drawing.Size(208, 28);
            this.indexNum.TabIndex = 70;
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(886, 328);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(152, 28);
            this.Gender.TabIndex = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1088, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1088, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 98;
            this.label2.Text = "Date of Birth";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(29, 373);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 22);
            this.label19.TabIndex = 97;
            this.label19.Text = "Intake";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(29, 458);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 22);
            this.label20.TabIndex = 96;
            this.label20.Text = "Address";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(29, 582);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 22);
            this.label21.TabIndex = 95;
            this.label21.Text = "KDU Mail";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(28, 331);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 22);
            this.label22.TabIndex = 94;
            this.label22.Text = "First Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(282, 241);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 22);
            this.label23.TabIndex = 93;
            this.label23.Text = "Index Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 99;
            this.label1.Text = "Index Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 103;
            this.label3.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 22);
            this.label5.TabIndex = 102;
            this.label5.Text = "Department Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 101;
            this.label7.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(399, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 22);
            this.label13.TabIndex = 100;
            this.label13.Text = " Full Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(800, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 22);
            this.label15.TabIndex = 104;
            this.label15.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 108;
            this.label4.Text = " Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(732, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 107;
            this.label10.Text = "Zip Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(731, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 22);
            this.label14.TabIndex = 106;
            this.label14.Text = "Province";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(731, 505);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 22);
            this.label16.TabIndex = 105;
            this.label16.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 22);
            this.label11.TabIndex = 111;
            this.label11.Text = "Personal Mail";
            // 
            // Editmem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 688);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.province);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.Dob);
            this.Controls.Add(this.Pmail);
            this.Controls.Add(this.ContNum);
            this.Controls.Add(this.KDUmail);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.FullN);
            this.Controls.Add(this.intake);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.indexNum);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editmem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details Update Form";
            this.Load += new System.EventHandler(this.Editmem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.ComboBox province;
        private System.Windows.Forms.ComboBox Dep;
        private System.Windows.Forms.DateTimePicker Dob;
        private System.Windows.Forms.TextBox Pmail;
        private System.Windows.Forms.TextBox ContNum;
        private System.Windows.Forms.TextBox KDUmail;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox FullN;
        private System.Windows.Forms.TextBox intake;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox indexNum;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
    }
}