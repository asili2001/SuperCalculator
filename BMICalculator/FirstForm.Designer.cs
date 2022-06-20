namespace BMICalculator
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.grpBMI = new System.Windows.Forms.GroupBox();
            this.BMISubmit = new System.Windows.Forms.Button();
            this.grpBMIResults = new System.Windows.Forms.GroupBox();
            this.BMIResultBlur = new System.Windows.Forms.PictureBox();
            this.idealWeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightCategoryResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BMIResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBMIUnit = new System.Windows.Forms.GroupBox();
            this.BMIUnit2 = new System.Windows.Forms.RadioButton();
            this.BMIUnit1 = new System.Windows.Forms.RadioButton();
            this.grpBMIUserData = new System.Windows.Forms.GroupBox();
            this.BMIUserHeightIN = new System.Windows.Forms.TextBox();
            this.BMIUserWeight = new System.Windows.Forms.TextBox();
            this.BMIUserHeight = new System.Windows.Forms.TextBox();
            this.BMIUserName = new System.Windows.Forms.TextBox();
            this.BMIlblWeight = new System.Windows.Forms.Label();
            this.BMIlblHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errMsg = new System.Windows.Forms.Label();
            this.grpSavingPlan = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.savingsPlanStartValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpSavingPlanResult = new System.Windows.Forms.GroupBox();
            this.amountPaidResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalFeesResult = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.finalBalanceResult = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.amountEarndResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.savingsCalculateSubmit = new System.Windows.Forms.Button();
            this.savingsPlanFees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.savingsPlanIntrest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.savingsPlanPeriod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.savingsPlanMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WeeklyActivityLevel_Extra = new System.Windows.Forms.RadioButton();
            this.WeeklyActivityLevel_Moderately = new System.Windows.Forms.RadioButton();
            this.WeeklyActivityLevel_Very = new System.Windows.Forms.RadioButton();
            this.WeeklyActivityLevel_Lightly = new System.Windows.Forms.RadioButton();
            this.WeeklyActivityLevel_Sedentary = new System.Windows.Forms.RadioButton();
            this.BMRCalculatorSubmit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MBRAge = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gender2 = new System.Windows.Forms.RadioButton();
            this.Gender1 = new System.Windows.Forms.RadioButton();
            this.MBRResultBox = new System.Windows.Forms.ListBox();
            this.grpBMI.SuspendLayout();
            this.grpBMIResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMIResultBlur)).BeginInit();
            this.grpBMIUnit.SuspendLayout();
            this.grpBMIUserData.SuspendLayout();
            this.grpSavingPlan.SuspendLayout();
            this.grpSavingPlanResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBMI
            // 
            this.grpBMI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBMI.Controls.Add(this.BMISubmit);
            this.grpBMI.Controls.Add(this.grpBMIResults);
            this.grpBMI.Controls.Add(this.grpBMIUnit);
            this.grpBMI.Controls.Add(this.grpBMIUserData);
            this.grpBMI.ForeColor = System.Drawing.Color.White;
            this.grpBMI.Location = new System.Drawing.Point(12, 31);
            this.grpBMI.Name = "grpBMI";
            this.grpBMI.Size = new System.Drawing.Size(535, 460);
            this.grpBMI.TabIndex = 0;
            this.grpBMI.TabStop = false;
            this.grpBMI.Text = "BMI Calculator";
            // 
            // BMISubmit
            // 
            this.BMISubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMISubmit.FlatAppearance.BorderSize = 0;
            this.BMISubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMISubmit.ForeColor = System.Drawing.Color.White;
            this.BMISubmit.Location = new System.Drawing.Point(91, 227);
            this.BMISubmit.Name = "BMISubmit";
            this.BMISubmit.Size = new System.Drawing.Size(311, 43);
            this.BMISubmit.TabIndex = 3;
            this.BMISubmit.Tag = "BMI submit";
            this.BMISubmit.Text = "Calculate My BMI";
            this.BMISubmit.UseVisualStyleBackColor = false;
            this.BMISubmit.Click += new System.EventHandler(this.BMISubmit_Click);
            // 
            // grpBMIResults
            // 
            this.grpBMIResults.Controls.Add(this.BMIResultBlur);
            this.grpBMIResults.Controls.Add(this.idealWeight);
            this.grpBMIResults.Controls.Add(this.label2);
            this.grpBMIResults.Controls.Add(this.weightCategoryResult);
            this.grpBMIResults.Controls.Add(this.label5);
            this.grpBMIResults.Controls.Add(this.BMIResult);
            this.grpBMIResults.Controls.Add(this.label4);
            this.grpBMIResults.ForeColor = System.Drawing.Color.White;
            this.grpBMIResults.Location = new System.Drawing.Point(6, 296);
            this.grpBMIResults.Name = "grpBMIResults";
            this.grpBMIResults.Size = new System.Drawing.Size(523, 157);
            this.grpBMIResults.TabIndex = 2;
            this.grpBMIResults.TabStop = false;
            this.grpBMIResults.Text = "Results";
            // 
            // BMIResultBlur
            // 
            this.BMIResultBlur.Image = global::BMICalculator.Properties.Resources.bmiResBlur;
            this.BMIResultBlur.Location = new System.Drawing.Point(6, 19);
            this.BMIResultBlur.Name = "BMIResultBlur";
            this.BMIResultBlur.Size = new System.Drawing.Size(511, 132);
            this.BMIResultBlur.TabIndex = 10;
            this.BMIResultBlur.TabStop = false;
            // 
            // idealWeight
            // 
            this.idealWeight.AutoSize = true;
            this.idealWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idealWeight.ForeColor = System.Drawing.Color.Gray;
            this.idealWeight.Location = new System.Drawing.Point(66, 115);
            this.idealWeight.Name = "idealWeight";
            this.idealWeight.Size = new System.Drawing.Size(395, 21);
            this.idealWeight.TabIndex = 9;
            this.idealWeight.Text = "Normal weight should be between 115 and 154 lbs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(101, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Normal BMI is between 18.50 anad 24.9 ";
            // 
            // weightCategoryResult
            // 
            this.weightCategoryResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.weightCategoryResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightCategoryResult.ForeColor = System.Drawing.Color.White;
            this.weightCategoryResult.Location = new System.Drawing.Point(206, 51);
            this.weightCategoryResult.Name = "weightCategoryResult";
            this.weightCategoryResult.ReadOnly = true;
            this.weightCategoryResult.Size = new System.Drawing.Size(229, 23);
            this.weightCategoryResult.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 51);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Weight Category";
            // 
            // BMIResult
            // 
            this.BMIResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMIResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIResult.ForeColor = System.Drawing.Color.White;
            this.BMIResult.Location = new System.Drawing.Point(206, 22);
            this.BMIResult.Name = "BMIResult";
            this.BMIResult.ReadOnly = true;
            this.BMIResult.Size = new System.Drawing.Size(229, 23);
            this.BMIResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 22);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "BMI";
            // 
            // grpBMIUnit
            // 
            this.grpBMIUnit.Controls.Add(this.BMIUnit2);
            this.grpBMIUnit.Controls.Add(this.BMIUnit1);
            this.grpBMIUnit.ForeColor = System.Drawing.Color.White;
            this.grpBMIUnit.Location = new System.Drawing.Point(329, 36);
            this.grpBMIUnit.Name = "grpBMIUnit";
            this.grpBMIUnit.Size = new System.Drawing.Size(200, 179);
            this.grpBMIUnit.TabIndex = 1;
            this.grpBMIUnit.TabStop = false;
            this.grpBMIUnit.Text = "Unit";
            // 
            // BMIUnit2
            // 
            this.BMIUnit2.Appearance = System.Windows.Forms.Appearance.Button;
            this.BMIUnit2.AutoSize = true;
            this.BMIUnit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMIUnit2.FlatAppearance.BorderSize = 0;
            this.BMIUnit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMIUnit2.ForeColor = System.Drawing.Color.White;
            this.BMIUnit2.Location = new System.Drawing.Point(6, 73);
            this.BMIUnit2.Name = "BMIUnit2";
            this.BMIUnit2.Size = new System.Drawing.Size(100, 25);
            this.BMIUnit2.TabIndex = 1;
            this.BMIUnit2.TabStop = true;
            this.BMIUnit2.Text = "Imperial (ft, lbs)";
            this.BMIUnit2.UseVisualStyleBackColor = false;
            this.BMIUnit2.CheckedChanged += new System.EventHandler(this.MPIUnit2_CheckedChanged);
            // 
            // BMIUnit1
            // 
            this.BMIUnit1.Appearance = System.Windows.Forms.Appearance.Button;
            this.BMIUnit1.AutoSize = true;
            this.BMIUnit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMIUnit1.FlatAppearance.BorderSize = 0;
            this.BMIUnit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMIUnit1.ForeColor = System.Drawing.Color.White;
            this.BMIUnit1.Location = new System.Drawing.Point(6, 35);
            this.BMIUnit1.Name = "BMIUnit1";
            this.BMIUnit1.Size = new System.Drawing.Size(98, 25);
            this.BMIUnit1.TabIndex = 0;
            this.BMIUnit1.TabStop = true;
            this.BMIUnit1.Text = "Metrik (kg, cm)";
            this.BMIUnit1.UseVisualStyleBackColor = false;
            this.BMIUnit1.CheckedChanged += new System.EventHandler(this.MBIUnit1_CheckedChanged);
            // 
            // grpBMIUserData
            // 
            this.grpBMIUserData.Controls.Add(this.BMIUserHeightIN);
            this.grpBMIUserData.Controls.Add(this.BMIUserWeight);
            this.grpBMIUserData.Controls.Add(this.BMIUserHeight);
            this.grpBMIUserData.Controls.Add(this.BMIUserName);
            this.grpBMIUserData.Controls.Add(this.BMIlblWeight);
            this.grpBMIUserData.Controls.Add(this.BMIlblHeight);
            this.grpBMIUserData.Controls.Add(this.label1);
            this.grpBMIUserData.ForeColor = System.Drawing.Color.White;
            this.grpBMIUserData.Location = new System.Drawing.Point(6, 36);
            this.grpBMIUserData.Name = "grpBMIUserData";
            this.grpBMIUserData.Size = new System.Drawing.Size(288, 179);
            this.grpBMIUserData.TabIndex = 0;
            this.grpBMIUserData.TabStop = false;
            this.grpBMIUserData.Text = "User Data";
            // 
            // BMIUserHeightIN
            // 
            this.BMIUserHeightIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMIUserHeightIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIUserHeightIN.ForeColor = System.Drawing.Color.White;
            this.BMIUserHeightIN.Location = new System.Drawing.Point(217, 73);
            this.BMIUserHeightIN.Name = "BMIUserHeightIN";
            this.BMIUserHeightIN.Size = new System.Drawing.Size(65, 23);
            this.BMIUserHeightIN.TabIndex = 6;
            this.BMIUserHeightIN.Tag = "(BMI User Height inch)";
            this.BMIUserHeightIN.Text = "0";
            // 
            // BMIUserWeight
            // 
            this.BMIUserWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMIUserWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIUserWeight.ForeColor = System.Drawing.Color.White;
            this.BMIUserWeight.Location = new System.Drawing.Point(143, 116);
            this.BMIUserWeight.Name = "BMIUserWeight";
            this.BMIUserWeight.Size = new System.Drawing.Size(140, 23);
            this.BMIUserWeight.TabIndex = 5;
            this.BMIUserWeight.Tag = "BMI User Weight";
            this.BMIUserWeight.Text = "0";
            // 
            // BMIUserHeight
            // 
            this.BMIUserHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMIUserHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIUserHeight.ForeColor = System.Drawing.Color.White;
            this.BMIUserHeight.Location = new System.Drawing.Point(143, 73);
            this.BMIUserHeight.Name = "BMIUserHeight";
            this.BMIUserHeight.Size = new System.Drawing.Size(65, 23);
            this.BMIUserHeight.TabIndex = 4;
            this.BMIUserHeight.Tag = "(BMI User Height)";
            this.BMIUserHeight.Text = "0";
            // 
            // BMIUserName
            // 
            this.BMIUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMIUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIUserName.ForeColor = System.Drawing.Color.White;
            this.BMIUserName.Location = new System.Drawing.Point(143, 31);
            this.BMIUserName.Name = "BMIUserName";
            this.BMIUserName.Size = new System.Drawing.Size(140, 23);
            this.BMIUserName.TabIndex = 3;
            this.BMIUserName.Tag = "(BMI UserName)";
            // 
            // BMIlblWeight
            // 
            this.BMIlblWeight.AutoSize = true;
            this.BMIlblWeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BMIlblWeight.ForeColor = System.Drawing.Color.White;
            this.BMIlblWeight.Location = new System.Drawing.Point(6, 116);
            this.BMIlblWeight.Name = "BMIlblWeight";
            this.BMIlblWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BMIlblWeight.Size = new System.Drawing.Size(86, 20);
            this.BMIlblWeight.TabIndex = 2;
            this.BMIlblWeight.Text = "Weight (kg)";
            // 
            // BMIlblHeight
            // 
            this.BMIlblHeight.AutoSize = true;
            this.BMIlblHeight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BMIlblHeight.ForeColor = System.Drawing.Color.White;
            this.BMIlblHeight.Location = new System.Drawing.Point(6, 76);
            this.BMIlblHeight.Name = "BMIlblHeight";
            this.BMIlblHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BMIlblHeight.Size = new System.Drawing.Size(88, 20);
            this.BMIlblHeight.TabIndex = 1;
            this.BMIlblHeight.Text = "Height (cm)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // errMsg
            // 
            this.errMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.errMsg.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errMsg.ForeColor = System.Drawing.Color.IndianRed;
            this.errMsg.Location = new System.Drawing.Point(0, 0);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(927, 28);
            this.errMsg.TabIndex = 1;
            this.errMsg.Text = "*Error message goes here";
            // 
            // grpSavingPlan
            // 
            this.grpSavingPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSavingPlan.Controls.Add(this.label16);
            this.grpSavingPlan.Controls.Add(this.label15);
            this.grpSavingPlan.Controls.Add(this.savingsPlanStartValue);
            this.grpSavingPlan.Controls.Add(this.label13);
            this.grpSavingPlan.Controls.Add(this.grpSavingPlanResult);
            this.grpSavingPlan.Controls.Add(this.savingsCalculateSubmit);
            this.grpSavingPlan.Controls.Add(this.savingsPlanFees);
            this.grpSavingPlan.Controls.Add(this.label8);
            this.grpSavingPlan.Controls.Add(this.savingsPlanIntrest);
            this.grpSavingPlan.Controls.Add(this.label7);
            this.grpSavingPlan.Controls.Add(this.savingsPlanPeriod);
            this.grpSavingPlan.Controls.Add(this.label6);
            this.grpSavingPlan.Controls.Add(this.savingsPlanMonthlyDeposit);
            this.grpSavingPlan.Controls.Add(this.label3);
            this.grpSavingPlan.ForeColor = System.Drawing.Color.White;
            this.grpSavingPlan.Location = new System.Drawing.Point(573, 31);
            this.grpSavingPlan.Name = "grpSavingPlan";
            this.grpSavingPlan.Size = new System.Drawing.Size(343, 460);
            this.grpSavingPlan.TabIndex = 2;
            this.grpSavingPlan.TabStop = false;
            this.grpSavingPlan.Text = "Saving Plan";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label16.Location = new System.Drawing.Point(311, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "% ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label15.Location = new System.Drawing.Point(311, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "%";
            // 
            // savingsPlanStartValue
            // 
            this.savingsPlanStartValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savingsPlanStartValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savingsPlanStartValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingsPlanStartValue.ForeColor = System.Drawing.Color.White;
            this.savingsPlanStartValue.Location = new System.Drawing.Point(197, 45);
            this.savingsPlanStartValue.Name = "savingsPlanStartValue";
            this.savingsPlanStartValue.Size = new System.Drawing.Size(140, 23);
            this.savingsPlanStartValue.TabIndex = 17;
            this.savingsPlanStartValue.Tag = "(Saving plan Start Value)";
            this.savingsPlanStartValue.Text = "0";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 45);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(131, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "Start Value";
            // 
            // grpSavingPlanResult
            // 
            this.grpSavingPlanResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSavingPlanResult.Controls.Add(this.amountPaidResult);
            this.grpSavingPlanResult.Controls.Add(this.label9);
            this.grpSavingPlanResult.Controls.Add(this.totalFeesResult);
            this.grpSavingPlanResult.Controls.Add(this.label12);
            this.grpSavingPlanResult.Controls.Add(this.finalBalanceResult);
            this.grpSavingPlanResult.Controls.Add(this.label11);
            this.grpSavingPlanResult.Controls.Add(this.amountEarndResult);
            this.grpSavingPlanResult.Controls.Add(this.label10);
            this.grpSavingPlanResult.ForeColor = System.Drawing.Color.White;
            this.grpSavingPlanResult.Location = new System.Drawing.Point(6, 276);
            this.grpSavingPlanResult.Name = "grpSavingPlanResult";
            this.grpSavingPlanResult.Size = new System.Drawing.Size(331, 177);
            this.grpSavingPlanResult.TabIndex = 15;
            this.grpSavingPlanResult.TabStop = false;
            this.grpSavingPlanResult.Text = "Results";
            // 
            // amountPaidResult
            // 
            this.amountPaidResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountPaidResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.amountPaidResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountPaidResult.ForeColor = System.Drawing.Color.White;
            this.amountPaidResult.Location = new System.Drawing.Point(182, 26);
            this.amountPaidResult.Name = "amountPaidResult";
            this.amountPaidResult.ReadOnly = true;
            this.amountPaidResult.Size = new System.Drawing.Size(140, 23);
            this.amountPaidResult.TabIndex = 25;
            this.amountPaidResult.Tag = "BMI UserName";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(131, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Amount Paid";
            // 
            // totalFeesResult
            // 
            this.totalFeesResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalFeesResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.totalFeesResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeesResult.ForeColor = System.Drawing.Color.White;
            this.totalFeesResult.Location = new System.Drawing.Point(182, 113);
            this.totalFeesResult.Name = "totalFeesResult";
            this.totalFeesResult.ReadOnly = true;
            this.totalFeesResult.Size = new System.Drawing.Size(140, 23);
            this.totalFeesResult.TabIndex = 23;
            this.totalFeesResult.Tag = "BMI UserName";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 113);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(131, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total Fees";
            // 
            // finalBalanceResult
            // 
            this.finalBalanceResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalBalanceResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.finalBalanceResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalBalanceResult.ForeColor = System.Drawing.Color.White;
            this.finalBalanceResult.Location = new System.Drawing.Point(182, 84);
            this.finalBalanceResult.Name = "finalBalanceResult";
            this.finalBalanceResult.ReadOnly = true;
            this.finalBalanceResult.Size = new System.Drawing.Size(140, 23);
            this.finalBalanceResult.TabIndex = 21;
            this.finalBalanceResult.Tag = "BMI UserName";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 84);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Final Balance";
            // 
            // amountEarndResult
            // 
            this.amountEarndResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountEarndResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.amountEarndResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountEarndResult.ForeColor = System.Drawing.Color.White;
            this.amountEarndResult.Location = new System.Drawing.Point(182, 55);
            this.amountEarndResult.Name = "amountEarndResult";
            this.amountEarndResult.ReadOnly = true;
            this.amountEarndResult.Size = new System.Drawing.Size(140, 23);
            this.amountEarndResult.TabIndex = 19;
            this.amountEarndResult.Tag = "BMI UserName";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Amount Earned";
            // 
            // savingsCalculateSubmit
            // 
            this.savingsCalculateSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savingsCalculateSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savingsCalculateSubmit.FlatAppearance.BorderSize = 0;
            this.savingsCalculateSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savingsCalculateSubmit.ForeColor = System.Drawing.Color.White;
            this.savingsCalculateSubmit.Location = new System.Drawing.Point(12, 227);
            this.savingsCalculateSubmit.Name = "savingsCalculateSubmit";
            this.savingsCalculateSubmit.Size = new System.Drawing.Size(325, 43);
            this.savingsCalculateSubmit.TabIndex = 4;
            this.savingsCalculateSubmit.Tag = "BMI submit";
            this.savingsCalculateSubmit.Text = "Calculate my savings";
            this.savingsCalculateSubmit.UseVisualStyleBackColor = false;
            this.savingsCalculateSubmit.Click += new System.EventHandler(this.savingsCalculateSubmit_Click);
            // 
            // savingsPlanFees
            // 
            this.savingsPlanFees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savingsPlanFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savingsPlanFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingsPlanFees.ForeColor = System.Drawing.Color.White;
            this.savingsPlanFees.Location = new System.Drawing.Point(197, 192);
            this.savingsPlanFees.MaxLength = 3;
            this.savingsPlanFees.Name = "savingsPlanFees";
            this.savingsPlanFees.Size = new System.Drawing.Size(140, 23);
            this.savingsPlanFees.TabIndex = 14;
            this.savingsPlanFees.Tag = "(Saving plan Fees in %)";
            this.savingsPlanFees.Text = "0";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 192);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fees in %";
            // 
            // savingsPlanIntrest
            // 
            this.savingsPlanIntrest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savingsPlanIntrest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savingsPlanIntrest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingsPlanIntrest.ForeColor = System.Drawing.Color.White;
            this.savingsPlanIntrest.Location = new System.Drawing.Point(197, 152);
            this.savingsPlanIntrest.MaxLength = 3;
            this.savingsPlanIntrest.Name = "savingsPlanIntrest";
            this.savingsPlanIntrest.Size = new System.Drawing.Size(140, 23);
            this.savingsPlanIntrest.TabIndex = 12;
            this.savingsPlanIntrest.Tag = "(Saving plan Growth (or intrest) in %)";
            this.savingsPlanIntrest.Text = "0";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 152);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Growth (or intrest) in % ";
            // 
            // savingsPlanPeriod
            // 
            this.savingsPlanPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savingsPlanPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savingsPlanPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingsPlanPeriod.ForeColor = System.Drawing.Color.White;
            this.savingsPlanPeriod.Location = new System.Drawing.Point(197, 114);
            this.savingsPlanPeriod.Name = "savingsPlanPeriod";
            this.savingsPlanPeriod.Size = new System.Drawing.Size(140, 23);
            this.savingsPlanPeriod.TabIndex = 10;
            this.savingsPlanPeriod.Tag = "(Saving plan Period (years))";
            this.savingsPlanPeriod.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 114);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Period (years)";
            // 
            // savingsPlanMonthlyDeposit
            // 
            this.savingsPlanMonthlyDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savingsPlanMonthlyDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.savingsPlanMonthlyDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingsPlanMonthlyDeposit.ForeColor = System.Drawing.Color.White;
            this.savingsPlanMonthlyDeposit.Location = new System.Drawing.Point(197, 79);
            this.savingsPlanMonthlyDeposit.Name = "savingsPlanMonthlyDeposit";
            this.savingsPlanMonthlyDeposit.Size = new System.Drawing.Size(140, 23);
            this.savingsPlanMonthlyDeposit.TabIndex = 8;
            this.savingsPlanMonthlyDeposit.Tag = "(Saving plan Monthly Deposit)";
            this.savingsPlanMonthlyDeposit.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monthly Deposit";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.BMRCalculatorSubmit);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.MBRResultBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 497);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MBR Calculator";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WeeklyActivityLevel_Extra);
            this.groupBox4.Controls.Add(this.WeeklyActivityLevel_Moderately);
            this.groupBox4.Controls.Add(this.WeeklyActivityLevel_Very);
            this.groupBox4.Controls.Add(this.WeeklyActivityLevel_Lightly);
            this.groupBox4.Controls.Add(this.WeeklyActivityLevel_Sedentary);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(112, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(274, 195);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Weekly Activity Level";
            // 
            // WeeklyActivityLevel_Extra
            // 
            this.WeeklyActivityLevel_Extra.Appearance = System.Windows.Forms.Appearance.Button;
            this.WeeklyActivityLevel_Extra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.WeeklyActivityLevel_Extra.FlatAppearance.BorderSize = 0;
            this.WeeklyActivityLevel_Extra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyActivityLevel_Extra.ForeColor = System.Drawing.Color.White;
            this.WeeklyActivityLevel_Extra.Location = new System.Drawing.Point(6, 153);
            this.WeeklyActivityLevel_Extra.Name = "WeeklyActivityLevel_Extra";
            this.WeeklyActivityLevel_Extra.Size = new System.Drawing.Size(262, 25);
            this.WeeklyActivityLevel_Extra.TabIndex = 4;
            this.WeeklyActivityLevel_Extra.Text = "Extra Active, hard exercises/job";
            this.WeeklyActivityLevel_Extra.UseVisualStyleBackColor = false;
            // 
            // WeeklyActivityLevel_Moderately
            // 
            this.WeeklyActivityLevel_Moderately.Appearance = System.Windows.Forms.Appearance.Button;
            this.WeeklyActivityLevel_Moderately.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.WeeklyActivityLevel_Moderately.Checked = true;
            this.WeeklyActivityLevel_Moderately.FlatAppearance.BorderSize = 0;
            this.WeeklyActivityLevel_Moderately.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyActivityLevel_Moderately.ForeColor = System.Drawing.Color.White;
            this.WeeklyActivityLevel_Moderately.Location = new System.Drawing.Point(6, 91);
            this.WeeklyActivityLevel_Moderately.Name = "WeeklyActivityLevel_Moderately";
            this.WeeklyActivityLevel_Moderately.Size = new System.Drawing.Size(262, 25);
            this.WeeklyActivityLevel_Moderately.TabIndex = 3;
            this.WeeklyActivityLevel_Moderately.TabStop = true;
            this.WeeklyActivityLevel_Moderately.Text = "Moderately Active (3 to 5 times)";
            this.WeeklyActivityLevel_Moderately.UseVisualStyleBackColor = false;
            // 
            // WeeklyActivityLevel_Very
            // 
            this.WeeklyActivityLevel_Very.Appearance = System.Windows.Forms.Appearance.Button;
            this.WeeklyActivityLevel_Very.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.WeeklyActivityLevel_Very.FlatAppearance.BorderSize = 0;
            this.WeeklyActivityLevel_Very.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyActivityLevel_Very.ForeColor = System.Drawing.Color.White;
            this.WeeklyActivityLevel_Very.Location = new System.Drawing.Point(6, 122);
            this.WeeklyActivityLevel_Very.Name = "WeeklyActivityLevel_Very";
            this.WeeklyActivityLevel_Very.Size = new System.Drawing.Size(262, 25);
            this.WeeklyActivityLevel_Very.TabIndex = 2;
            this.WeeklyActivityLevel_Very.Text = "Very Active (16to 7 times)";
            this.WeeklyActivityLevel_Very.UseVisualStyleBackColor = false;
            // 
            // WeeklyActivityLevel_Lightly
            // 
            this.WeeklyActivityLevel_Lightly.Appearance = System.Windows.Forms.Appearance.Button;
            this.WeeklyActivityLevel_Lightly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.WeeklyActivityLevel_Lightly.FlatAppearance.BorderSize = 0;
            this.WeeklyActivityLevel_Lightly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyActivityLevel_Lightly.ForeColor = System.Drawing.Color.White;
            this.WeeklyActivityLevel_Lightly.Location = new System.Drawing.Point(6, 60);
            this.WeeklyActivityLevel_Lightly.Name = "WeeklyActivityLevel_Lightly";
            this.WeeklyActivityLevel_Lightly.Size = new System.Drawing.Size(262, 25);
            this.WeeklyActivityLevel_Lightly.TabIndex = 1;
            this.WeeklyActivityLevel_Lightly.Text = "Lightly Active (1 to 3 times)";
            this.WeeklyActivityLevel_Lightly.UseVisualStyleBackColor = false;
            // 
            // WeeklyActivityLevel_Sedentary
            // 
            this.WeeklyActivityLevel_Sedentary.Appearance = System.Windows.Forms.Appearance.Button;
            this.WeeklyActivityLevel_Sedentary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.WeeklyActivityLevel_Sedentary.FlatAppearance.BorderSize = 0;
            this.WeeklyActivityLevel_Sedentary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeeklyActivityLevel_Sedentary.ForeColor = System.Drawing.Color.White;
            this.WeeklyActivityLevel_Sedentary.Location = new System.Drawing.Point(6, 29);
            this.WeeklyActivityLevel_Sedentary.Name = "WeeklyActivityLevel_Sedentary";
            this.WeeklyActivityLevel_Sedentary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeeklyActivityLevel_Sedentary.Size = new System.Drawing.Size(262, 25);
            this.WeeklyActivityLevel_Sedentary.TabIndex = 0;
            this.WeeklyActivityLevel_Sedentary.Text = "Sedentary (Little or no exercise)";
            this.WeeklyActivityLevel_Sedentary.UseVisualStyleBackColor = false;
            // 
            // BMRCalculatorSubmit
            // 
            this.BMRCalculatorSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BMRCalculatorSubmit.FlatAppearance.BorderSize = 0;
            this.BMRCalculatorSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMRCalculatorSubmit.ForeColor = System.Drawing.Color.White;
            this.BMRCalculatorSubmit.Location = new System.Drawing.Point(6, 183);
            this.BMRCalculatorSubmit.Name = "BMRCalculatorSubmit";
            this.BMRCalculatorSubmit.Size = new System.Drawing.Size(100, 40);
            this.BMRCalculatorSubmit.TabIndex = 4;
            this.BMRCalculatorSubmit.Tag = "BMR submit";
            this.BMRCalculatorSubmit.Text = "Calculate My BMR";
            this.BMRCalculatorSubmit.UseVisualStyleBackColor = false;
            this.BMRCalculatorSubmit.Click += new System.EventHandler(this.BMRCalculatorSubmit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MBRAge);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(94, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Age";
            // 
            // MBRAge
            // 
            this.MBRAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.MBRAge.ForeColor = System.Drawing.Color.White;
            this.MBRAge.Location = new System.Drawing.Point(3, 27);
            this.MBRAge.MaxLength = 3;
            this.MBRAge.Name = "MBRAge";
            this.MBRAge.Size = new System.Drawing.Size(49, 23);
            this.MBRAge.TabIndex = 29;
            this.MBRAge.Tag = "(MBR User Age)";
            this.MBRAge.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "years";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Gender2);
            this.groupBox2.Controls.Add(this.Gender1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(94, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // Gender2
            // 
            this.Gender2.Appearance = System.Windows.Forms.Appearance.Button;
            this.Gender2.AutoSize = true;
            this.Gender2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Gender2.FlatAppearance.BorderSize = 0;
            this.Gender2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender2.ForeColor = System.Drawing.Color.White;
            this.Gender2.Location = new System.Drawing.Point(6, 53);
            this.Gender2.Name = "Gender2";
            this.Gender2.Size = new System.Drawing.Size(55, 25);
            this.Gender2.TabIndex = 1;
            this.Gender2.Text = "Female";
            this.Gender2.UseVisualStyleBackColor = false;
            // 
            // Gender1
            // 
            this.Gender1.Appearance = System.Windows.Forms.Appearance.Button;
            this.Gender1.AutoSize = true;
            this.Gender1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Gender1.Checked = true;
            this.Gender1.FlatAppearance.BorderSize = 0;
            this.Gender1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender1.ForeColor = System.Drawing.Color.White;
            this.Gender1.Location = new System.Drawing.Point(6, 22);
            this.Gender1.Name = "Gender1";
            this.Gender1.Size = new System.Drawing.Size(43, 25);
            this.Gender1.TabIndex = 0;
            this.Gender1.TabStop = true;
            this.Gender1.Text = "Male";
            this.Gender1.UseVisualStyleBackColor = false;
            // 
            // MBRResultBox
            // 
            this.MBRResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MBRResultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.MBRResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MBRResultBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MBRResultBox.ForeColor = System.Drawing.Color.White;
            this.MBRResultBox.FormattingEnabled = true;
            this.MBRResultBox.Location = new System.Drawing.Point(404, 28);
            this.MBRResultBox.Name = "MBRResultBox";
            this.MBRResultBox.Size = new System.Drawing.Size(494, 195);
            this.MBRResultBox.TabIndex = 0;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(927, 757);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSavingPlan);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.grpBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FirstForm";
            this.Text = "Super Calculator by Ahmad Asili";
            this.grpBMI.ResumeLayout(false);
            this.grpBMIResults.ResumeLayout(false);
            this.grpBMIResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMIResultBlur)).EndInit();
            this.grpBMIUnit.ResumeLayout(false);
            this.grpBMIUnit.PerformLayout();
            this.grpBMIUserData.ResumeLayout(false);
            this.grpBMIUserData.PerformLayout();
            this.grpSavingPlan.ResumeLayout(false);
            this.grpSavingPlan.PerformLayout();
            this.grpSavingPlanResult.ResumeLayout(false);
            this.grpSavingPlanResult.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBMI;
        private GroupBox grpBMIResults;
        private GroupBox grpBMIUnit;
        private GroupBox grpBMIUserData;
        private Button BMISubmit;
        private TextBox BMIResult;
        private Label label4;
        private RadioButton BMIUnit2;
        private RadioButton BMIUnit1;
        private TextBox BMIUserWeight;
        private TextBox BMIUserHeight;
        private TextBox BMIUserName;
        private Label BMIlblWeight;
        private Label BMIlblHeight;
        private Label label1;
        private TextBox weightCategoryResult;
        private Label label5;
        private Label idealWeight;
        private Label label2;
        private TextBox BMIUserHeightIN;
        private Label errMsg;
        private GroupBox grpSavingPlan;
        private TextBox savingsPlanFees;
        private Label label8;
        private TextBox savingsPlanIntrest;
        private Label label7;
        private TextBox savingsPlanPeriod;
        private Label label6;
        private TextBox savingsPlanMonthlyDeposit;
        private Label label3;
        private GroupBox grpSavingPlanResult;
        private TextBox amountPaidResult;
        private Label label9;
        private TextBox totalFeesResult;
        private Label label12;
        private TextBox finalBalanceResult;
        private Label label11;
        private TextBox amountEarndResult;
        private Label label10;
        private Button savingsCalculateSubmit;
        private TextBox savingsPlanStartValue;
        private Label label13;
        private GroupBox groupBox1;
        private ListBox MBRResultBox;
        private GroupBox groupBox2;
        private RadioButton Gender2;
        private RadioButton Gender1;
        private Button BMRCalculatorSubmit;
        private GroupBox groupBox3;
        private PictureBox BMIResultBlur;
        private GroupBox groupBox4;
        private RadioButton WeeklyActivityLevel_Extra;
        private RadioButton WeeklyActivityLevel_Moderately;
        private RadioButton WeeklyActivityLevel_Very;
        private RadioButton WeeklyActivityLevel_Lightly;
        private RadioButton WeeklyActivityLevel_Sedentary;
        private Label label14;
        private Label label16;
        private Label label15;
        private TextBox MBRAge;
    }
}