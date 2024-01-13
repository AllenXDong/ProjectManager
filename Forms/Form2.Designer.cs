namespace MainProject.Forms
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reviewInputText = new System.Windows.Forms.TextBox();
            this.subjectNameInputText = new System.Windows.Forms.TextBox();
            this.setCurrentButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.engineerInputText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.projectIdInputText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.subjectIdInputText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.approvalInputText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.standardInputText = new System.Windows.Forms.TextBox();
            this.processInputText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engineer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.subjectNameCurrentText = new System.Windows.Forms.TextBox();
            this.projectIdCurrentText = new System.Windows.Forms.TextBox();
            this.engineerCurrentText = new System.Windows.Forms.TextBox();
            this.subjectIdCurrentText = new System.Windows.Forms.TextBox();
            this.verificationComponent1 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "课题名称:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(715, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "审 核";
            // 
            // reviewInputText
            // 
            this.reviewInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewInputText.Enabled = false;
            this.reviewInputText.Location = new System.Drawing.Point(774, 29);
            this.reviewInputText.Name = "reviewInputText";
            this.reviewInputText.Size = new System.Drawing.Size(261, 28);
            this.reviewInputText.TabIndex = 5;
            this.verificationComponent1.SetVerificationCustomRegex(this.reviewInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.reviewInputText, "");
            this.verificationComponent1.SetVerificationModel(this.reviewInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.reviewInputText, false);
            // 
            // subjectNameInputText
            // 
            this.subjectNameInputText.Enabled = false;
            this.subjectNameInputText.Location = new System.Drawing.Point(121, 27);
            this.subjectNameInputText.Name = "subjectNameInputText";
            this.subjectNameInputText.Size = new System.Drawing.Size(277, 28);
            this.subjectNameInputText.TabIndex = 1;
            this.verificationComponent1.SetVerificationCustomRegex(this.subjectNameInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.subjectNameInputText, "");
            this.verificationComponent1.SetVerificationModel(this.subjectNameInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.subjectNameInputText, true);
            // 
            // setCurrentButton
            // 
            this.setCurrentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setCurrentButton.Location = new System.Drawing.Point(935, 27);
            this.setCurrentButton.Name = "setCurrentButton";
            this.setCurrentButton.Size = new System.Drawing.Size(121, 38);
            this.setCurrentButton.TabIndex = 17;
            this.setCurrentButton.Text = "置为当前";
            this.setCurrentButton.UseVisualStyleBackColor = true;
            this.setCurrentButton.Click += new System.EventHandler(this.setCurrentButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(666, 782);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(121, 38);
            this.okButton.TabIndex = 20;
            this.okButton.Text = "完成";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(825, 782);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 38);
            this.button6.TabIndex = 21;
            this.button6.Text = "放弃";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.engineerInputText);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.projectIdInputText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.subjectIdInputText);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.approvalInputText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.standardInputText);
            this.groupBox1.Controls.Add(this.subjectNameInputText);
            this.groupBox1.Controls.Add(this.processInputText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.reviewInputText);
            this.groupBox1.Location = new System.Drawing.Point(19, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 251);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(404, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 18);
            this.label16.TabIndex = 13;
            this.label16.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(404, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(404, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(404, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "设计师:";
            // 
            // engineerInputText
            // 
            this.engineerInputText.Enabled = false;
            this.engineerInputText.Location = new System.Drawing.Point(121, 197);
            this.engineerInputText.Name = "engineerInputText";
            this.engineerInputText.Size = new System.Drawing.Size(277, 28);
            this.engineerInputText.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.engineerInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.engineerInputText, "");
            this.verificationComponent1.SetVerificationModel(this.engineerInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.engineerInputText, true);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "项目编号:";
            // 
            // projectIdInputText
            // 
            this.projectIdInputText.Enabled = false;
            this.projectIdInputText.Location = new System.Drawing.Point(121, 143);
            this.projectIdInputText.Name = "projectIdInputText";
            this.projectIdInputText.Size = new System.Drawing.Size(277, 28);
            this.projectIdInputText.TabIndex = 3;
            this.verificationComponent1.SetVerificationCustomRegex(this.projectIdInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.projectIdInputText, "");
            this.verificationComponent1.SetVerificationModel(this.projectIdInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.projectIdInputText, true);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "课题代号:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(715, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "批 准";
            // 
            // subjectIdInputText
            // 
            this.subjectIdInputText.Enabled = false;
            this.subjectIdInputText.Location = new System.Drawing.Point(121, 85);
            this.subjectIdInputText.Name = "subjectIdInputText";
            this.subjectIdInputText.Size = new System.Drawing.Size(277, 28);
            this.subjectIdInputText.TabIndex = 2;
            this.verificationComponent1.SetVerificationCustomRegex(this.subjectIdInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.subjectIdInputText, "");
            this.verificationComponent1.SetVerificationModel(this.subjectIdInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.subjectIdInputText, true);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(706, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "标准化";
            // 
            // approvalInputText
            // 
            this.approvalInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.approvalInputText.Enabled = false;
            this.approvalInputText.Location = new System.Drawing.Point(774, 199);
            this.approvalInputText.Name = "approvalInputText";
            this.approvalInputText.Size = new System.Drawing.Size(261, 28);
            this.approvalInputText.TabIndex = 8;
            this.verificationComponent1.SetVerificationCustomRegex(this.approvalInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.approvalInputText, "");
            this.verificationComponent1.SetVerificationModel(this.approvalInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.approvalInputText, false);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "工 艺";
            // 
            // standardInputText
            // 
            this.standardInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.standardInputText.Enabled = false;
            this.standardInputText.Location = new System.Drawing.Point(774, 145);
            this.standardInputText.Name = "standardInputText";
            this.standardInputText.Size = new System.Drawing.Size(261, 28);
            this.standardInputText.TabIndex = 7;
            this.verificationComponent1.SetVerificationCustomRegex(this.standardInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.standardInputText, "");
            this.verificationComponent1.SetVerificationModel(this.standardInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.standardInputText, false);
            // 
            // processInputText
            // 
            this.processInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processInputText.Enabled = false;
            this.processInputText.Location = new System.Drawing.Point(774, 87);
            this.processInputText.Name = "processInputText";
            this.processInputText.Size = new System.Drawing.Size(261, 28);
            this.processInputText.TabIndex = 6;
            this.verificationComponent1.SetVerificationCustomRegex(this.processInputText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.processInputText, "");
            this.verificationComponent1.SetVerificationModel(this.processInputText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.processInputText, false);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.confirmButton);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.NewButton);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.setCurrentButton);
            this.groupBox2.Location = new System.Drawing.Point(19, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 361);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本地项目列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.SubjectName,
            this.SubjectId,
            this.ProjectId,
            this.Engineer,
            this.Review,
            this.Process,
            this.Standard,
            this.Approval});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 332);
            this.dataGridView1.TabIndex = 18;
            // 
            // 序号
            // 
            this.序号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 8;
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Visible = false;
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectName.HeaderText = "课题名称";
            this.SubjectName.MinimumWidth = 8;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // SubjectId
            // 
            this.SubjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectId.HeaderText = "课题代号";
            this.SubjectId.MinimumWidth = 8;
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            // 
            // ProjectId
            // 
            this.ProjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectId.HeaderText = "项目号";
            this.ProjectId.MinimumWidth = 8;
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.ReadOnly = true;
            // 
            // Engineer
            // 
            this.Engineer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Engineer.HeaderText = "设计师";
            this.Engineer.MinimumWidth = 8;
            this.Engineer.Name = "Engineer";
            this.Engineer.ReadOnly = true;
            this.Engineer.Width = 98;
            // 
            // Review
            // 
            this.Review.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Review.HeaderText = "审核";
            this.Review.MinimumWidth = 8;
            this.Review.Name = "Review";
            this.Review.ReadOnly = true;
            // 
            // Process
            // 
            this.Process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Process.HeaderText = "工艺";
            this.Process.MinimumWidth = 8;
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            // 
            // Standard
            // 
            this.Standard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Standard.HeaderText = "标准化";
            this.Standard.MinimumWidth = 8;
            this.Standard.Name = "Standard";
            this.Standard.ReadOnly = true;
            // 
            // Approval
            // 
            this.Approval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Approval.HeaderText = "批准";
            this.Approval.MinimumWidth = 8;
            this.Approval.Name = "Approval";
            this.Approval.ReadOnly = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.Location = new System.Drawing.Point(934, 296);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(121, 38);
            this.confirmButton.TabIndex = 17;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(934, 243);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 38);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.Location = new System.Drawing.Point(934, 190);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(121, 38);
            this.NewButton.TabIndex = 17;
            this.NewButton.Text = "新 建";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(934, 136);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 38);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "编 辑";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(934, 81);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 38);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "删 除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.subjectNameCurrentText);
            this.groupBox3.Controls.Add(this.projectIdCurrentText);
            this.groupBox3.Controls.Add(this.engineerCurrentText);
            this.groupBox3.Controls.Add(this.subjectIdCurrentText);
            this.groupBox3.Location = new System.Drawing.Point(19, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1056, 139);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "当前工作项目";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 18);
            this.label19.TabIndex = 6;
            this.label19.Text = "课题代号:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 18);
            this.label22.TabIndex = 6;
            this.label22.Text = "课题名称:";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(695, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 18);
            this.label23.TabIndex = 10;
            this.label23.Text = "设计师:";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(695, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 18);
            this.label24.TabIndex = 10;
            this.label24.Text = "项目号:";
            // 
            // subjectNameCurrentText
            // 
            this.subjectNameCurrentText.Enabled = false;
            this.subjectNameCurrentText.Location = new System.Drawing.Point(117, 27);
            this.subjectNameCurrentText.Name = "subjectNameCurrentText";
            this.subjectNameCurrentText.Size = new System.Drawing.Size(281, 28);
            this.subjectNameCurrentText.TabIndex = 12;
            this.verificationComponent1.SetVerificationCustomRegex(this.subjectNameCurrentText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.subjectNameCurrentText, "");
            this.verificationComponent1.SetVerificationModel(this.subjectNameCurrentText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.subjectNameCurrentText, false);
            // 
            // projectIdCurrentText
            // 
            this.projectIdCurrentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectIdCurrentText.Enabled = false;
            this.projectIdCurrentText.Location = new System.Drawing.Point(781, 29);
            this.projectIdCurrentText.Name = "projectIdCurrentText";
            this.projectIdCurrentText.Size = new System.Drawing.Size(250, 28);
            this.projectIdCurrentText.TabIndex = 11;
            this.verificationComponent1.SetVerificationCustomRegex(this.projectIdCurrentText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.projectIdCurrentText, "");
            this.verificationComponent1.SetVerificationModel(this.projectIdCurrentText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.projectIdCurrentText, false);
            // 
            // engineerCurrentText
            // 
            this.engineerCurrentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.engineerCurrentText.Enabled = false;
            this.engineerCurrentText.Location = new System.Drawing.Point(781, 87);
            this.engineerCurrentText.Name = "engineerCurrentText";
            this.engineerCurrentText.Size = new System.Drawing.Size(250, 28);
            this.engineerCurrentText.TabIndex = 11;
            this.verificationComponent1.SetVerificationCustomRegex(this.engineerCurrentText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.engineerCurrentText, "");
            this.verificationComponent1.SetVerificationModel(this.engineerCurrentText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.engineerCurrentText, false);
            // 
            // subjectIdCurrentText
            // 
            this.subjectIdCurrentText.Enabled = false;
            this.subjectIdCurrentText.Location = new System.Drawing.Point(117, 85);
            this.subjectIdCurrentText.Name = "subjectIdCurrentText";
            this.subjectIdCurrentText.Size = new System.Drawing.Size(281, 28);
            this.subjectIdCurrentText.TabIndex = 12;
            this.verificationComponent1.SetVerificationCustomRegex(this.subjectIdCurrentText, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.subjectIdCurrentText, "");
            this.verificationComponent1.SetVerificationModel(this.subjectIdCurrentText, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.subjectIdCurrentText, false);
            // 
            // verificationComponent1
            // 
            this.verificationComponent1.AutoCloseErrorTipsTime = 3000;
            this.verificationComponent1.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verificationComponent1.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 832);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form2";
            this.Text = "课题项目管理";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reviewInputText;
        private System.Windows.Forms.TextBox subjectNameInputText;
        private System.Windows.Forms.Button setCurrentButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button6;
        private int flCount = 0;
        private int[] flCountMulti = null;
        private string[] tuhaoMulti = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox engineerInputText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox projectIdInputText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox subjectIdInputText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox approvalInputText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox standardInputText;
        private System.Windows.Forms.TextBox processInputText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox subjectNameCurrentText;
        private System.Windows.Forms.TextBox projectIdCurrentText;
        private System.Windows.Forms.TextBox engineerCurrentText;
        private System.Windows.Forms.TextBox subjectIdCurrentText;
        private HZH_Controls.Controls.VerificationComponent verificationComponent1;
        private bool isEdit;
        private System.Windows.Forms.DataGridViewRow currentRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Engineer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Review;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approval;
    }
}