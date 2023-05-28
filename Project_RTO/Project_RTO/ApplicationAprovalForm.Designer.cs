namespace Project_RTO
{
    partial class ApplicationAprovalForm
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
            this.ApplStatus_label = new System.Windows.Forms.Label();
            this.aprovalfrm_appstatuslabel = new System.Windows.Forms.Label();
            this.aprovalfrm_regnogenbutton = new System.Windows.Forms.Button();
            this.aprovalfrm_regnotextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm_applnocomboBox = new System.Windows.Forms.ComboBox();
            this.aprovalfrm_selappnolable = new System.Windows.Forms.Label();
            this.aprovalfrm_canclebutton = new System.Windows.Forms.Button();
            this.aprovalfrm_regdatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aprovalfrm_pantextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm__standcaplable = new System.Windows.Forms.Label();
            this.aprovalfrm_emailtextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm_RTOlabel = new System.Windows.Forms.Label();
            this.aprovalfrm_aadhartextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm__seatcaplable = new System.Windows.Forms.Label();
            this.aprovalfrm__insurancenolable = new System.Windows.Forms.Label();
            this.aprovalfrm_modeltextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm__modelnamelable = new System.Windows.Forms.Label();
            this.aprovalfrm_vehicletypetextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm__vehicleclasslable = new System.Windows.Forms.Label();
            this.aprovalfrm_colortextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm_colorlable = new System.Windows.Forms.Label();
            this.aprovalfrm_ownernametextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm_ownernamelable = new System.Windows.Forms.Label();
            this.aprovalfrm_mobnotextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm__chassisnolable = new System.Windows.Forms.Label();
            this.aprovalfrm_chassistextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm_fueltypelable = new System.Windows.Forms.Label();
            this.aprovalfrm_engnotextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm_enginnolable = new System.Windows.Forms.Label();
            this.aprovalfrm_owneraddrstextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm_owneraddlable = new System.Windows.Forms.Label();
            this.aprovalfrm_companytextBox = new System.Windows.Forms.TextBox();
            this.aprovalfrm__makenamelable = new System.Windows.Forms.Label();
            this.aprovalfrm_titlelable3 = new System.Windows.Forms.Label();
            this.aprovalfrm_issuedatelable = new System.Windows.Forms.Label();
            this.aprovalfrm_rejectbutton = new System.Windows.Forms.Button();
            this.aprovalfrm_approvebutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ApplStatus_label
            // 
            this.ApplStatus_label.AutoSize = true;
            this.ApplStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplStatus_label.ForeColor = System.Drawing.Color.Red;
            this.ApplStatus_label.Location = new System.Drawing.Point(1328, 121);
            this.ApplStatus_label.Name = "ApplStatus_label";
            this.ApplStatus_label.Size = new System.Drawing.Size(63, 20);
            this.ApplStatus_label.TabIndex = 164;
            this.ApplStatus_label.Text = "Status";
            // 
            // aprovalfrm_appstatuslabel
            // 
            this.aprovalfrm_appstatuslabel.AutoSize = true;
            this.aprovalfrm_appstatuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_appstatuslabel.Location = new System.Drawing.Point(1039, 121);
            this.aprovalfrm_appstatuslabel.Name = "aprovalfrm_appstatuslabel";
            this.aprovalfrm_appstatuslabel.Size = new System.Drawing.Size(257, 20);
            this.aprovalfrm_appstatuslabel.TabIndex = 163;
            this.aprovalfrm_appstatuslabel.Text = "Selected Application Statues:";
            // 
            // aprovalfrm_regnogenbutton
            // 
            this.aprovalfrm_regnogenbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_regnogenbutton.Location = new System.Drawing.Point(813, 827);
            this.aprovalfrm_regnogenbutton.Name = "aprovalfrm_regnogenbutton";
            this.aprovalfrm_regnogenbutton.Size = new System.Drawing.Size(152, 52);
            this.aprovalfrm_regnogenbutton.TabIndex = 162;
            this.aprovalfrm_regnogenbutton.Text = "Generate Vehicle Reg. No.";
            this.aprovalfrm_regnogenbutton.UseVisualStyleBackColor = true;
            this.aprovalfrm_regnogenbutton.Click += new System.EventHandler(this.aprovalfrm_regnogenbutton_Click);
            // 
            // aprovalfrm_regnotextBox
            // 
            this.aprovalfrm_regnotextBox.Location = new System.Drawing.Point(1011, 839);
            this.aprovalfrm_regnotextBox.Name = "aprovalfrm_regnotextBox";
            this.aprovalfrm_regnotextBox.Size = new System.Drawing.Size(214, 22);
            this.aprovalfrm_regnotextBox.TabIndex = 161;
            // 
            // aprovalfrm_applnocomboBox
            // 
            this.aprovalfrm_applnocomboBox.DisplayMember = "APPLICATION_ID";
            this.aprovalfrm_applnocomboBox.FormattingEnabled = true;
            this.aprovalfrm_applnocomboBox.Location = new System.Drawing.Point(559, 121);
            this.aprovalfrm_applnocomboBox.Name = "aprovalfrm_applnocomboBox";
            this.aprovalfrm_applnocomboBox.Size = new System.Drawing.Size(301, 24);
            this.aprovalfrm_applnocomboBox.TabIndex = 120;
            this.aprovalfrm_applnocomboBox.ValueMember = "APPLICATION_ID";
            this.aprovalfrm_applnocomboBox.SelectedValueChanged += new System.EventHandler(this.aprovalfrm_applnocomboBox_SelectedValueChanged);
            // 
            // aprovalfrm_selappnolable
            // 
            this.aprovalfrm_selappnolable.AutoSize = true;
            this.aprovalfrm_selappnolable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_selappnolable.Location = new System.Drawing.Point(345, 121);
            this.aprovalfrm_selappnolable.Name = "aprovalfrm_selappnolable";
            this.aprovalfrm_selappnolable.Size = new System.Drawing.Size(195, 20);
            this.aprovalfrm_selappnolable.TabIndex = 160;
            this.aprovalfrm_selappnolable.Text = "Select Application No.";
            // 
            // aprovalfrm_canclebutton
            // 
            this.aprovalfrm_canclebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_canclebutton.Location = new System.Drawing.Point(1158, 724);
            this.aprovalfrm_canclebutton.Name = "aprovalfrm_canclebutton";
            this.aprovalfrm_canclebutton.Size = new System.Drawing.Size(95, 32);
            this.aprovalfrm_canclebutton.TabIndex = 159;
            this.aprovalfrm_canclebutton.Text = "Close";
            this.aprovalfrm_canclebutton.UseVisualStyleBackColor = true;
            this.aprovalfrm_canclebutton.Click += new System.EventHandler(this.aprovalfrm_canclebutton_Click);
            // 
            // aprovalfrm_regdatedateTimePicker
            // 
            this.aprovalfrm_regdatedateTimePicker.Enabled = false;
            this.aprovalfrm_regdatedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aprovalfrm_regdatedateTimePicker.Location = new System.Drawing.Point(1227, 367);
            this.aprovalfrm_regdatedateTimePicker.Name = "aprovalfrm_regdatedateTimePicker";
            this.aprovalfrm_regdatedateTimePicker.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_regdatedateTimePicker.TabIndex = 157;
            this.aprovalfrm_regdatedateTimePicker.Value = new System.DateTime(2022, 4, 23, 10, 59, 25, 0);
            // 
            // aprovalfrm_pantextBox
            // 
            this.aprovalfrm_pantextBox.Enabled = false;
            this.aprovalfrm_pantextBox.Location = new System.Drawing.Point(1227, 487);
            this.aprovalfrm_pantextBox.Name = "aprovalfrm_pantextBox";
            this.aprovalfrm_pantextBox.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_pantextBox.TabIndex = 130;
            // 
            // aprovalfrm__standcaplable
            // 
            this.aprovalfrm__standcaplable.AutoSize = true;
            this.aprovalfrm__standcaplable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm__standcaplable.Location = new System.Drawing.Point(1039, 486);
            this.aprovalfrm__standcaplable.Name = "aprovalfrm__standcaplable";
            this.aprovalfrm__standcaplable.Size = new System.Drawing.Size(140, 20);
            this.aprovalfrm__standcaplable.TabIndex = 154;
            this.aprovalfrm__standcaplable.Text = "Owner PAN No.";
            // 
            // aprovalfrm_emailtextBox
            // 
            this.aprovalfrm_emailtextBox.Enabled = false;
            this.aprovalfrm_emailtextBox.Location = new System.Drawing.Point(563, 487);
            this.aprovalfrm_emailtextBox.Name = "aprovalfrm_emailtextBox";
            this.aprovalfrm_emailtextBox.Size = new System.Drawing.Size(297, 22);
            this.aprovalfrm_emailtextBox.TabIndex = 129;
            // 
            // aprovalfrm_RTOlabel
            // 
            this.aprovalfrm_RTOlabel.AutoSize = true;
            this.aprovalfrm_RTOlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_RTOlabel.Location = new System.Drawing.Point(345, 487);
            this.aprovalfrm_RTOlabel.Name = "aprovalfrm_RTOlabel";
            this.aprovalfrm_RTOlabel.Size = new System.Drawing.Size(141, 20);
            this.aprovalfrm_RTOlabel.TabIndex = 153;
            this.aprovalfrm_RTOlabel.Text = "Owner Email ID";
            // 
            // aprovalfrm_aadhartextBox
            // 
            this.aprovalfrm_aadhartextBox.Enabled = false;
            this.aprovalfrm_aadhartextBox.Location = new System.Drawing.Point(1231, 425);
            this.aprovalfrm_aadhartextBox.Name = "aprovalfrm_aadhartextBox";
            this.aprovalfrm_aadhartextBox.Size = new System.Drawing.Size(297, 22);
            this.aprovalfrm_aadhartextBox.TabIndex = 128;
            // 
            // aprovalfrm__seatcaplable
            // 
            this.aprovalfrm__seatcaplable.AutoSize = true;
            this.aprovalfrm__seatcaplable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm__seatcaplable.Location = new System.Drawing.Point(1039, 424);
            this.aprovalfrm__seatcaplable.Name = "aprovalfrm__seatcaplable";
            this.aprovalfrm__seatcaplable.Size = new System.Drawing.Size(162, 20);
            this.aprovalfrm__seatcaplable.TabIndex = 152;
            this.aprovalfrm__seatcaplable.Text = "Owner Aadhar No.";
            // 
            // aprovalfrm__insurancenolable
            // 
            this.aprovalfrm__insurancenolable.AutoSize = true;
            this.aprovalfrm__insurancenolable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm__insurancenolable.Location = new System.Drawing.Point(1039, 551);
            this.aprovalfrm__insurancenolable.Name = "aprovalfrm__insurancenolable";
            this.aprovalfrm__insurancenolable.Size = new System.Drawing.Size(243, 20);
            this.aprovalfrm__insurancenolable.TabIndex = 151;
            this.aprovalfrm__insurancenolable.Text = "Document Submition Status";
            // 
            // aprovalfrm_modeltextBox
            // 
            this.aprovalfrm_modeltextBox.Enabled = false;
            this.aprovalfrm_modeltextBox.Location = new System.Drawing.Point(1227, 175);
            this.aprovalfrm_modeltextBox.Name = "aprovalfrm_modeltextBox";
            this.aprovalfrm_modeltextBox.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_modeltextBox.TabIndex = 122;
            // 
            // aprovalfrm__modelnamelable
            // 
            this.aprovalfrm__modelnamelable.AutoSize = true;
            this.aprovalfrm__modelnamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm__modelnamelable.Location = new System.Drawing.Point(1039, 177);
            this.aprovalfrm__modelnamelable.Name = "aprovalfrm__modelnamelable";
            this.aprovalfrm__modelnamelable.Size = new System.Drawing.Size(59, 20);
            this.aprovalfrm__modelnamelable.TabIndex = 149;
            this.aprovalfrm__modelnamelable.Text = "Model";
            // 
            // aprovalfrm_vehicletypetextBox
            // 
            this.aprovalfrm_vehicletypetextBox.Enabled = false;
            this.aprovalfrm_vehicletypetextBox.Location = new System.Drawing.Point(559, 239);
            this.aprovalfrm_vehicletypetextBox.Name = "aprovalfrm_vehicletypetextBox";
            this.aprovalfrm_vehicletypetextBox.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_vehicletypetextBox.TabIndex = 126;
            this.aprovalfrm_vehicletypetextBox.TextChanged += new System.EventHandler(this.aprovalfrm_vehicleclastextBox_TextChanged);
            // 
            // aprovalfrm__vehicleclasslable
            // 
            this.aprovalfrm__vehicleclasslable.AutoSize = true;
            this.aprovalfrm__vehicleclasslable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm__vehicleclasslable.Location = new System.Drawing.Point(345, 239);
            this.aprovalfrm__vehicleclasslable.Name = "aprovalfrm__vehicleclasslable";
            this.aprovalfrm__vehicleclasslable.Size = new System.Drawing.Size(117, 20);
            this.aprovalfrm__vehicleclasslable.TabIndex = 148;
            this.aprovalfrm__vehicleclasslable.Text = "Vehicle Type";
            this.aprovalfrm__vehicleclasslable.Click += new System.EventHandler(this.aprovalfrm__vehicleclasslable_Click);
            // 
            // aprovalfrm_colortextBox
            // 
            this.aprovalfrm_colortextBox.Enabled = false;
            this.aprovalfrm_colortextBox.Location = new System.Drawing.Point(1227, 239);
            this.aprovalfrm_colortextBox.Name = "aprovalfrm_colortextBox";
            this.aprovalfrm_colortextBox.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_colortextBox.TabIndex = 125;
            // 
            // aprovalfrm_colorlable
            // 
            this.aprovalfrm_colorlable.AutoSize = true;
            this.aprovalfrm_colorlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_colorlable.Location = new System.Drawing.Point(1039, 239);
            this.aprovalfrm_colorlable.Name = "aprovalfrm_colorlable";
            this.aprovalfrm_colorlable.Size = new System.Drawing.Size(64, 20);
            this.aprovalfrm_colorlable.TabIndex = 147;
            this.aprovalfrm_colorlable.Text = "Colour";
            // 
            // aprovalfrm_ownernametextBox
            // 
            this.aprovalfrm_ownernametextBox.Enabled = false;
            this.aprovalfrm_ownernametextBox.Location = new System.Drawing.Point(563, 367);
            this.aprovalfrm_ownernametextBox.Name = "aprovalfrm_ownernametextBox";
            this.aprovalfrm_ownernametextBox.Size = new System.Drawing.Size(297, 22);
            this.aprovalfrm_ownernametextBox.TabIndex = 133;
            // 
            // aprovalfrm_ownernamelable
            // 
            this.aprovalfrm_ownernamelable.AutoSize = true;
            this.aprovalfrm_ownernamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_ownernamelable.Location = new System.Drawing.Point(345, 367);
            this.aprovalfrm_ownernamelable.Name = "aprovalfrm_ownernamelable";
            this.aprovalfrm_ownernamelable.Size = new System.Drawing.Size(117, 20);
            this.aprovalfrm_ownernamelable.TabIndex = 146;
            this.aprovalfrm_ownernamelable.Text = "Owner Name";
            // 
            // aprovalfrm_mobnotextBox
            // 
            this.aprovalfrm_mobnotextBox.Enabled = false;
            this.aprovalfrm_mobnotextBox.Location = new System.Drawing.Point(563, 425);
            this.aprovalfrm_mobnotextBox.Name = "aprovalfrm_mobnotextBox";
            this.aprovalfrm_mobnotextBox.Size = new System.Drawing.Size(297, 22);
            this.aprovalfrm_mobnotextBox.TabIndex = 127;
            // 
            // aprovalfrm__chassisnolable
            // 
            this.aprovalfrm__chassisnolable.AutoSize = true;
            this.aprovalfrm__chassisnolable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm__chassisnolable.Location = new System.Drawing.Point(345, 304);
            this.aprovalfrm__chassisnolable.Name = "aprovalfrm__chassisnolable";
            this.aprovalfrm__chassisnolable.Size = new System.Drawing.Size(148, 20);
            this.aprovalfrm__chassisnolable.TabIndex = 145;
            this.aprovalfrm__chassisnolable.Text = "Chassis Number";
            // 
            // aprovalfrm_chassistextBox
            // 
            this.aprovalfrm_chassistextBox.Enabled = false;
            this.aprovalfrm_chassistextBox.Location = new System.Drawing.Point(559, 304);
            this.aprovalfrm_chassistextBox.Name = "aprovalfrm_chassistextBox";
            this.aprovalfrm_chassistextBox.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_chassistextBox.TabIndex = 124;
            // 
            // aprovalfrm_fueltypelable
            // 
            this.aprovalfrm_fueltypelable.AutoSize = true;
            this.aprovalfrm_fueltypelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_fueltypelable.Location = new System.Drawing.Point(345, 425);
            this.aprovalfrm_fueltypelable.Name = "aprovalfrm_fueltypelable";
            this.aprovalfrm_fueltypelable.Size = new System.Drawing.Size(158, 20);
            this.aprovalfrm_fueltypelable.TabIndex = 144;
            this.aprovalfrm_fueltypelable.Text = "Owner Mobile No.";
            // 
            // aprovalfrm_engnotextBox
            // 
            this.aprovalfrm_engnotextBox.Enabled = false;
            this.aprovalfrm_engnotextBox.Location = new System.Drawing.Point(1227, 304);
            this.aprovalfrm_engnotextBox.Name = "aprovalfrm_engnotextBox";
            this.aprovalfrm_engnotextBox.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_engnotextBox.TabIndex = 123;
            // 
            // aprovalfrm_enginnolable
            // 
            this.aprovalfrm_enginnolable.AutoSize = true;
            this.aprovalfrm_enginnolable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_enginnolable.Location = new System.Drawing.Point(1039, 304);
            this.aprovalfrm_enginnolable.Name = "aprovalfrm_enginnolable";
            this.aprovalfrm_enginnolable.Size = new System.Drawing.Size(137, 20);
            this.aprovalfrm_enginnolable.TabIndex = 143;
            this.aprovalfrm_enginnolable.Text = "Engine Number";
            // 
            // aprovalfrm_owneraddrstextBox
            // 
            this.aprovalfrm_owneraddrstextBox.Enabled = false;
            this.aprovalfrm_owneraddrstextBox.Location = new System.Drawing.Point(563, 551);
            this.aprovalfrm_owneraddrstextBox.Multiline = true;
            this.aprovalfrm_owneraddrstextBox.Name = "aprovalfrm_owneraddrstextBox";
            this.aprovalfrm_owneraddrstextBox.Size = new System.Drawing.Size(297, 81);
            this.aprovalfrm_owneraddrstextBox.TabIndex = 134;
            // 
            // aprovalfrm_owneraddlable
            // 
            this.aprovalfrm_owneraddlable.AutoSize = true;
            this.aprovalfrm_owneraddlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_owneraddlable.Location = new System.Drawing.Point(345, 551);
            this.aprovalfrm_owneraddlable.Name = "aprovalfrm_owneraddlable";
            this.aprovalfrm_owneraddlable.Size = new System.Drawing.Size(138, 20);
            this.aprovalfrm_owneraddlable.TabIndex = 142;
            this.aprovalfrm_owneraddlable.Text = "Owner Address";
            // 
            // aprovalfrm_companytextBox
            // 
            this.aprovalfrm_companytextBox.Enabled = false;
            this.aprovalfrm_companytextBox.Location = new System.Drawing.Point(559, 177);
            this.aprovalfrm_companytextBox.Name = "aprovalfrm_companytextBox";
            this.aprovalfrm_companytextBox.Size = new System.Drawing.Size(301, 22);
            this.aprovalfrm_companytextBox.TabIndex = 121;
            // 
            // aprovalfrm__makenamelable
            // 
            this.aprovalfrm__makenamelable.AutoSize = true;
            this.aprovalfrm__makenamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm__makenamelable.Location = new System.Drawing.Point(345, 177);
            this.aprovalfrm__makenamelable.Name = "aprovalfrm__makenamelable";
            this.aprovalfrm__makenamelable.Size = new System.Drawing.Size(86, 20);
            this.aprovalfrm__makenamelable.TabIndex = 141;
            this.aprovalfrm__makenamelable.Text = "Company";
            // 
            // aprovalfrm_titlelable3
            // 
            this.aprovalfrm_titlelable3.AutoSize = true;
            this.aprovalfrm_titlelable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_titlelable3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.aprovalfrm_titlelable3.Location = new System.Drawing.Point(616, 22);
            this.aprovalfrm_titlelable3.Name = "aprovalfrm_titlelable3";
            this.aprovalfrm_titlelable3.Size = new System.Drawing.Size(663, 51);
            this.aprovalfrm_titlelable3.TabIndex = 140;
            this.aprovalfrm_titlelable3.Text = "Vehicle Registration Application";
            // 
            // aprovalfrm_issuedatelable
            // 
            this.aprovalfrm_issuedatelable.AutoSize = true;
            this.aprovalfrm_issuedatelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_issuedatelable.Location = new System.Drawing.Point(1039, 370);
            this.aprovalfrm_issuedatelable.Name = "aprovalfrm_issuedatelable";
            this.aprovalfrm_issuedatelable.Size = new System.Drawing.Size(145, 20);
            this.aprovalfrm_issuedatelable.TabIndex = 138;
            this.aprovalfrm_issuedatelable.Text = "Reg. Apply Date";
            // 
            // aprovalfrm_rejectbutton
            // 
            this.aprovalfrm_rejectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_rejectbutton.Location = new System.Drawing.Point(951, 724);
            this.aprovalfrm_rejectbutton.Name = "aprovalfrm_rejectbutton";
            this.aprovalfrm_rejectbutton.Size = new System.Drawing.Size(95, 32);
            this.aprovalfrm_rejectbutton.TabIndex = 137;
            this.aprovalfrm_rejectbutton.Text = "Reject";
            this.aprovalfrm_rejectbutton.UseVisualStyleBackColor = true;
            this.aprovalfrm_rejectbutton.Click += new System.EventHandler(this.aprovalfrm_rejectbutton_Click);
            // 
            // aprovalfrm_approvebutton
            // 
            this.aprovalfrm_approvebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprovalfrm_approvebutton.Location = new System.Drawing.Point(748, 724);
            this.aprovalfrm_approvebutton.Name = "aprovalfrm_approvebutton";
            this.aprovalfrm_approvebutton.Size = new System.Drawing.Size(88, 32);
            this.aprovalfrm_approvebutton.TabIndex = 136;
            this.aprovalfrm_approvebutton.Text = "Approve";
            this.aprovalfrm_approvebutton.UseVisualStyleBackColor = true;
            this.aprovalfrm_approvebutton.Click += new System.EventHandler(this.aprovalfrm_approvebutton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(1331, 553);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 165;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ApplicationAprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1003);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ApplStatus_label);
            this.Controls.Add(this.aprovalfrm_appstatuslabel);
            this.Controls.Add(this.aprovalfrm_regnogenbutton);
            this.Controls.Add(this.aprovalfrm_regnotextBox);
            this.Controls.Add(this.aprovalfrm_applnocomboBox);
            this.Controls.Add(this.aprovalfrm_selappnolable);
            this.Controls.Add(this.aprovalfrm_canclebutton);
            this.Controls.Add(this.aprovalfrm_regdatedateTimePicker);
            this.Controls.Add(this.aprovalfrm_pantextBox);
            this.Controls.Add(this.aprovalfrm__standcaplable);
            this.Controls.Add(this.aprovalfrm_emailtextBox);
            this.Controls.Add(this.aprovalfrm_RTOlabel);
            this.Controls.Add(this.aprovalfrm_aadhartextBox);
            this.Controls.Add(this.aprovalfrm__seatcaplable);
            this.Controls.Add(this.aprovalfrm__insurancenolable);
            this.Controls.Add(this.aprovalfrm_modeltextBox);
            this.Controls.Add(this.aprovalfrm__modelnamelable);
            this.Controls.Add(this.aprovalfrm_vehicletypetextBox);
            this.Controls.Add(this.aprovalfrm__vehicleclasslable);
            this.Controls.Add(this.aprovalfrm_colortextBox);
            this.Controls.Add(this.aprovalfrm_colorlable);
            this.Controls.Add(this.aprovalfrm_ownernametextBox);
            this.Controls.Add(this.aprovalfrm_ownernamelable);
            this.Controls.Add(this.aprovalfrm_mobnotextBox);
            this.Controls.Add(this.aprovalfrm__chassisnolable);
            this.Controls.Add(this.aprovalfrm_chassistextBox);
            this.Controls.Add(this.aprovalfrm_fueltypelable);
            this.Controls.Add(this.aprovalfrm_engnotextBox);
            this.Controls.Add(this.aprovalfrm_enginnolable);
            this.Controls.Add(this.aprovalfrm_owneraddrstextBox);
            this.Controls.Add(this.aprovalfrm_owneraddlable);
            this.Controls.Add(this.aprovalfrm_companytextBox);
            this.Controls.Add(this.aprovalfrm__makenamelable);
            this.Controls.Add(this.aprovalfrm_titlelable3);
            this.Controls.Add(this.aprovalfrm_issuedatelable);
            this.Controls.Add(this.aprovalfrm_rejectbutton);
            this.Controls.Add(this.aprovalfrm_approvebutton);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "ApplicationAprovalForm";
            this.Text = "Application Approval Tab";
            this.Load += new System.EventHandler(this.ApplicationAprovalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplStatus_label;
        private System.Windows.Forms.Label aprovalfrm_appstatuslabel;
        private System.Windows.Forms.Button aprovalfrm_regnogenbutton;
        private System.Windows.Forms.TextBox aprovalfrm_regnotextBox;
        private System.Windows.Forms.ComboBox aprovalfrm_applnocomboBox;
        private System.Windows.Forms.Label aprovalfrm_selappnolable;
        private System.Windows.Forms.Button aprovalfrm_canclebutton;
        private System.Windows.Forms.DateTimePicker aprovalfrm_regdatedateTimePicker;
        private System.Windows.Forms.TextBox aprovalfrm_pantextBox;
        private System.Windows.Forms.Label aprovalfrm__standcaplable;
        private System.Windows.Forms.TextBox aprovalfrm_emailtextBox;
        private System.Windows.Forms.Label aprovalfrm_RTOlabel;
        private System.Windows.Forms.TextBox aprovalfrm_aadhartextBox;
        private System.Windows.Forms.Label aprovalfrm__seatcaplable;
        private System.Windows.Forms.Label aprovalfrm__insurancenolable;
        private System.Windows.Forms.TextBox aprovalfrm_modeltextBox;
        private System.Windows.Forms.Label aprovalfrm__modelnamelable;
        private System.Windows.Forms.TextBox aprovalfrm_vehicletypetextBox;
        private System.Windows.Forms.Label aprovalfrm__vehicleclasslable;
        private System.Windows.Forms.TextBox aprovalfrm_colortextBox;
        private System.Windows.Forms.Label aprovalfrm_colorlable;
        private System.Windows.Forms.TextBox aprovalfrm_ownernametextBox;
        private System.Windows.Forms.Label aprovalfrm_ownernamelable;
        private System.Windows.Forms.TextBox aprovalfrm_mobnotextBox;
        private System.Windows.Forms.Label aprovalfrm__chassisnolable;
        private System.Windows.Forms.TextBox aprovalfrm_chassistextBox;
        private System.Windows.Forms.Label aprovalfrm_fueltypelable;
        private System.Windows.Forms.TextBox aprovalfrm_engnotextBox;
        private System.Windows.Forms.Label aprovalfrm_enginnolable;
        private System.Windows.Forms.TextBox aprovalfrm_owneraddrstextBox;
        private System.Windows.Forms.Label aprovalfrm_owneraddlable;
        private System.Windows.Forms.TextBox aprovalfrm_companytextBox;
        private System.Windows.Forms.Label aprovalfrm__makenamelable;
        private System.Windows.Forms.Label aprovalfrm_titlelable3;
        private System.Windows.Forms.Label aprovalfrm_issuedatelable;
        private System.Windows.Forms.Button aprovalfrm_rejectbutton;
        private System.Windows.Forms.Button aprovalfrm_approvebutton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}