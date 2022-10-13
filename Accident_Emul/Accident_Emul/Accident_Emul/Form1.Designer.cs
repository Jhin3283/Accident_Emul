namespace Accident_Emul
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
            this.components = new System.ComponentModel.Container();
            this.btnSendRollData = new System.Windows.Forms.Button();
            this.tbHRM = new System.Windows.Forms.TextBox();
            this.tbINDUpper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeelAngle = new System.Windows.Forms.TextBox();
            this.tbRollPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRollAmplitudePort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRollAmplitudeStbd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.upper1 = new System.Windows.Forms.CheckBox();
            this.upper2 = new System.Windows.Forms.CheckBox();
            this.upper3 = new System.Windows.Forms.CheckBox();
            this.upper4 = new System.Windows.Forms.CheckBox();
            this.upper5 = new System.Windows.Forms.CheckBox();
            this.upper10 = new System.Windows.Forms.CheckBox();
            this.upper9 = new System.Windows.Forms.CheckBox();
            this.upper8 = new System.Windows.Forms.CheckBox();
            this.upper7 = new System.Windows.Forms.CheckBox();
            this.upper6 = new System.Windows.Forms.CheckBox();
            this.lower10 = new System.Windows.Forms.CheckBox();
            this.lower9 = new System.Windows.Forms.CheckBox();
            this.lower8 = new System.Windows.Forms.CheckBox();
            this.lower7 = new System.Windows.Forms.CheckBox();
            this.lower6 = new System.Windows.Forms.CheckBox();
            this.lower5 = new System.Windows.Forms.CheckBox();
            this.lower4 = new System.Windows.Forms.CheckBox();
            this.lower3 = new System.Windows.Forms.CheckBox();
            this.lower2 = new System.Windows.Forms.CheckBox();
            this.lower1 = new System.Windows.Forms.CheckBox();
            this.tbXML = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timerSendRollData = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tbServerStatus = new System.Windows.Forms.TextBox();
            this.btnNewRoutePlanSend = new System.Windows.Forms.Button();
            this.btnSecondAccidentPrevent = new System.Windows.Forms.Button();
            this.timerSendFloodData = new System.Windows.Forms.Timer(this.components);
            this.btnSendHeelData = new System.Windows.Forms.Button();
            this.chkHexa = new System.Windows.Forms.CheckBox();
            this.btnSendNMEA = new System.Windows.Forms.Button();
            this.btn0LevelAccident = new System.Windows.Forms.Button();
            this.btn1LevelAccident = new System.Windows.Forms.Button();
            this.btn2LevelAccident = new System.Windows.Forms.Button();
            this.btn3LevelAccident = new System.Windows.Forms.Button();
            this.tbINDLower = new System.Windows.Forms.TextBox();
            this.DataValid = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendRollData
            // 
            this.btnSendRollData.Location = new System.Drawing.Point(623, 133);
            this.btnSendRollData.Name = "btnSendRollData";
            this.btnSendRollData.Size = new System.Drawing.Size(117, 46);
            this.btnSendRollData.TabIndex = 1;
            this.btnSendRollData.Text = "무작위 자동 경사보내기";
            this.btnSendRollData.UseVisualStyleBackColor = true;
            this.btnSendRollData.Visible = false;
            this.btnSendRollData.Click += new System.EventHandler(this.btnSendRollData_Click);
            // 
            // tbHRM
            // 
            this.tbHRM.Location = new System.Drawing.Point(21, 31);
            this.tbHRM.Name = "tbHRM";
            this.tbHRM.Size = new System.Drawing.Size(595, 23);
            this.tbHRM.TabIndex = 2;
            this.tbHRM.Text = "$ICHRM, 10.2,1.5,40.2,20.2,A*hh<CR><LF> ";
            // 
            // tbINDUpper
            // 
            this.tbINDUpper.Location = new System.Drawing.Point(21, 60);
            this.tbINDUpper.Name = "tbINDUpper";
            this.tbINDUpper.Size = new System.Drawing.Size(595, 23);
            this.tbINDUpper.TabIndex = 3;
            this.tbINDUpper.Text = "$PDIND,UPPER,1,1,1,1,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Heel Angle";
            // 
            // tbHeelAngle
            // 
            this.tbHeelAngle.Location = new System.Drawing.Point(129, 124);
            this.tbHeelAngle.Name = "tbHeelAngle";
            this.tbHeelAngle.Size = new System.Drawing.Size(100, 23);
            this.tbHeelAngle.TabIndex = 5;
            this.tbHeelAngle.Text = "12.3";
            // 
            // tbRollPeriod
            // 
            this.tbRollPeriod.Location = new System.Drawing.Point(129, 153);
            this.tbRollPeriod.Name = "tbRollPeriod";
            this.tbRollPeriod.Size = new System.Drawing.Size(100, 23);
            this.tbRollPeriod.TabIndex = 7;
            this.tbRollPeriod.Text = "15.3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Roll Period";
            // 
            // tbRollAmplitudePort
            // 
            this.tbRollAmplitudePort.Location = new System.Drawing.Point(430, 124);
            this.tbRollAmplitudePort.Name = "tbRollAmplitudePort";
            this.tbRollAmplitudePort.Size = new System.Drawing.Size(100, 23);
            this.tbRollAmplitudePort.TabIndex = 9;
            this.tbRollAmplitudePort.Text = "3.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Roll amplitude to port";
            // 
            // tbRollAmplitudeStbd
            // 
            this.tbRollAmplitudeStbd.Location = new System.Drawing.Point(430, 153);
            this.tbRollAmplitudeStbd.Name = "tbRollAmplitudeStbd";
            this.tbRollAmplitudeStbd.Size = new System.Drawing.Size(100, 23);
            this.tbRollAmplitudeStbd.TabIndex = 11;
            this.tbRollAmplitudeStbd.Text = "3.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Roll amplitude to starboard";
            // 
            // upper1
            // 
            this.upper1.AutoSize = true;
            this.upper1.Location = new System.Drawing.Point(32, 239);
            this.upper1.Name = "upper1";
            this.upper1.Size = new System.Drawing.Size(64, 19);
            this.upper1.TabIndex = 12;
            this.upper1.Text = "upper1";
            this.upper1.UseVisualStyleBackColor = true;
            // 
            // upper2
            // 
            this.upper2.AutoSize = true;
            this.upper2.Location = new System.Drawing.Point(102, 239);
            this.upper2.Name = "upper2";
            this.upper2.Size = new System.Drawing.Size(64, 19);
            this.upper2.TabIndex = 13;
            this.upper2.Text = "upper2";
            this.upper2.UseVisualStyleBackColor = true;
            // 
            // upper3
            // 
            this.upper3.AutoSize = true;
            this.upper3.Location = new System.Drawing.Point(172, 239);
            this.upper3.Name = "upper3";
            this.upper3.Size = new System.Drawing.Size(64, 19);
            this.upper3.TabIndex = 14;
            this.upper3.Text = "upper3";
            this.upper3.UseVisualStyleBackColor = true;
            // 
            // upper4
            // 
            this.upper4.AutoSize = true;
            this.upper4.Location = new System.Drawing.Point(242, 239);
            this.upper4.Name = "upper4";
            this.upper4.Size = new System.Drawing.Size(64, 19);
            this.upper4.TabIndex = 15;
            this.upper4.Text = "upper4";
            this.upper4.UseVisualStyleBackColor = true;
            // 
            // upper5
            // 
            this.upper5.AutoSize = true;
            this.upper5.Location = new System.Drawing.Point(312, 239);
            this.upper5.Name = "upper5";
            this.upper5.Size = new System.Drawing.Size(64, 19);
            this.upper5.TabIndex = 16;
            this.upper5.Text = "upper5";
            this.upper5.UseVisualStyleBackColor = true;
            // 
            // upper10
            // 
            this.upper10.AutoSize = true;
            this.upper10.Location = new System.Drawing.Point(662, 239);
            this.upper10.Name = "upper10";
            this.upper10.Size = new System.Drawing.Size(71, 19);
            this.upper10.TabIndex = 21;
            this.upper10.Text = "upper10";
            this.upper10.UseVisualStyleBackColor = true;
            // 
            // upper9
            // 
            this.upper9.AutoSize = true;
            this.upper9.Location = new System.Drawing.Point(592, 239);
            this.upper9.Name = "upper9";
            this.upper9.Size = new System.Drawing.Size(64, 19);
            this.upper9.TabIndex = 20;
            this.upper9.Text = "upper9";
            this.upper9.UseVisualStyleBackColor = true;
            // 
            // upper8
            // 
            this.upper8.AutoSize = true;
            this.upper8.Location = new System.Drawing.Point(522, 239);
            this.upper8.Name = "upper8";
            this.upper8.Size = new System.Drawing.Size(64, 19);
            this.upper8.TabIndex = 19;
            this.upper8.Text = "upper8";
            this.upper8.UseVisualStyleBackColor = true;
            // 
            // upper7
            // 
            this.upper7.AutoSize = true;
            this.upper7.Location = new System.Drawing.Point(452, 239);
            this.upper7.Name = "upper7";
            this.upper7.Size = new System.Drawing.Size(64, 19);
            this.upper7.TabIndex = 18;
            this.upper7.Text = "upper7";
            this.upper7.UseVisualStyleBackColor = true;
            // 
            // upper6
            // 
            this.upper6.AutoSize = true;
            this.upper6.Location = new System.Drawing.Point(382, 239);
            this.upper6.Name = "upper6";
            this.upper6.Size = new System.Drawing.Size(64, 19);
            this.upper6.TabIndex = 17;
            this.upper6.Text = "upper6";
            this.upper6.UseVisualStyleBackColor = true;
            // 
            // lower10
            // 
            this.lower10.AutoSize = true;
            this.lower10.Location = new System.Drawing.Point(660, 274);
            this.lower10.Name = "lower10";
            this.lower10.Size = new System.Drawing.Size(69, 19);
            this.lower10.TabIndex = 35;
            this.lower10.Text = "lower10";
            this.lower10.UseVisualStyleBackColor = true;
            // 
            // lower9
            // 
            this.lower9.AutoSize = true;
            this.lower9.Location = new System.Drawing.Point(590, 274);
            this.lower9.Name = "lower9";
            this.lower9.Size = new System.Drawing.Size(62, 19);
            this.lower9.TabIndex = 34;
            this.lower9.Text = "lower9";
            this.lower9.UseVisualStyleBackColor = true;
            // 
            // lower8
            // 
            this.lower8.AutoSize = true;
            this.lower8.Location = new System.Drawing.Point(520, 274);
            this.lower8.Name = "lower8";
            this.lower8.Size = new System.Drawing.Size(62, 19);
            this.lower8.TabIndex = 33;
            this.lower8.Text = "lower8";
            this.lower8.UseVisualStyleBackColor = true;
            // 
            // lower7
            // 
            this.lower7.AutoSize = true;
            this.lower7.Location = new System.Drawing.Point(450, 274);
            this.lower7.Name = "lower7";
            this.lower7.Size = new System.Drawing.Size(62, 19);
            this.lower7.TabIndex = 32;
            this.lower7.Text = "lower7";
            this.lower7.UseVisualStyleBackColor = true;
            // 
            // lower6
            // 
            this.lower6.AutoSize = true;
            this.lower6.Location = new System.Drawing.Point(380, 274);
            this.lower6.Name = "lower6";
            this.lower6.Size = new System.Drawing.Size(62, 19);
            this.lower6.TabIndex = 31;
            this.lower6.Text = "lower6";
            this.lower6.UseVisualStyleBackColor = true;
            // 
            // lower5
            // 
            this.lower5.AutoSize = true;
            this.lower5.Location = new System.Drawing.Point(310, 274);
            this.lower5.Name = "lower5";
            this.lower5.Size = new System.Drawing.Size(62, 19);
            this.lower5.TabIndex = 30;
            this.lower5.Text = "lower5";
            this.lower5.UseVisualStyleBackColor = true;
            // 
            // lower4
            // 
            this.lower4.AutoSize = true;
            this.lower4.Location = new System.Drawing.Point(240, 274);
            this.lower4.Name = "lower4";
            this.lower4.Size = new System.Drawing.Size(62, 19);
            this.lower4.TabIndex = 29;
            this.lower4.Text = "lower4";
            this.lower4.UseVisualStyleBackColor = true;
            // 
            // lower3
            // 
            this.lower3.AutoSize = true;
            this.lower3.Location = new System.Drawing.Point(170, 274);
            this.lower3.Name = "lower3";
            this.lower3.Size = new System.Drawing.Size(62, 19);
            this.lower3.TabIndex = 28;
            this.lower3.Text = "lower3";
            this.lower3.UseVisualStyleBackColor = true;
            // 
            // lower2
            // 
            this.lower2.AutoSize = true;
            this.lower2.Location = new System.Drawing.Point(100, 274);
            this.lower2.Name = "lower2";
            this.lower2.Size = new System.Drawing.Size(62, 19);
            this.lower2.TabIndex = 27;
            this.lower2.Text = "lower2";
            this.lower2.UseVisualStyleBackColor = true;
            // 
            // lower1
            // 
            this.lower1.AutoSize = true;
            this.lower1.Location = new System.Drawing.Point(30, 274);
            this.lower1.Name = "lower1";
            this.lower1.Size = new System.Drawing.Size(62, 19);
            this.lower1.TabIndex = 26;
            this.lower1.Text = "lower1";
            this.lower1.UseVisualStyleBackColor = true;
            // 
            // tbXML
            // 
            this.tbXML.Location = new System.Drawing.Point(22, 341);
            this.tbXML.Multiline = true;
            this.tbXML.Name = "tbXML";
            this.tbXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXML.Size = new System.Drawing.Size(343, 161);
            this.tbXML.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "XML 입력창";
            // 
            // timerSendRollData
            // 
            this.timerSendRollData.Interval = 1000;
            this.timerSendRollData.Tick += new System.EventHandler(this.timerSendRollData_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "서버 상태";
            // 
            // tbServerStatus
            // 
            this.tbServerStatus.Location = new System.Drawing.Point(397, 384);
            this.tbServerStatus.Multiline = true;
            this.tbServerStatus.Name = "tbServerStatus";
            this.tbServerStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbServerStatus.Size = new System.Drawing.Size(343, 118);
            this.tbServerStatus.TabIndex = 38;
            // 
            // btnNewRoutePlanSend
            // 
            this.btnNewRoutePlanSend.Location = new System.Drawing.Point(623, 89);
            this.btnNewRoutePlanSend.Name = "btnNewRoutePlanSend";
            this.btnNewRoutePlanSend.Size = new System.Drawing.Size(117, 40);
            this.btnNewRoutePlanSend.TabIndex = 42;
            this.btnNewRoutePlanSend.Text = "새로운 항로 전송";
            this.btnNewRoutePlanSend.UseVisualStyleBackColor = true;
            this.btnNewRoutePlanSend.Click += new System.EventHandler(this.btnConnectClient_Click);
            // 
            // btnSecondAccidentPrevent
            // 
            this.btnSecondAccidentPrevent.Location = new System.Drawing.Point(623, 181);
            this.btnSecondAccidentPrevent.Name = "btnSecondAccidentPrevent";
            this.btnSecondAccidentPrevent.Size = new System.Drawing.Size(117, 46);
            this.btnSecondAccidentPrevent.TabIndex = 43;
            this.btnSecondAccidentPrevent.Text = "2차 충돌방지경고";
            this.btnSecondAccidentPrevent.UseVisualStyleBackColor = true;
            this.btnSecondAccidentPrevent.Click += new System.EventHandler(this.btnSendFloodData_Click);
            // 
            // timerSendFloodData
            // 
            this.timerSendFloodData.Interval = 1000;
            this.timerSendFloodData.Tick += new System.EventHandler(this.timerSendFloodData_Tick);
            // 
            // btnSendHeelData
            // 
            this.btnSendHeelData.Location = new System.Drawing.Point(623, 12);
            this.btnSendHeelData.Name = "btnSendHeelData";
            this.btnSendHeelData.Size = new System.Drawing.Size(117, 30);
            this.btnSendHeelData.TabIndex = 44;
            this.btnSendHeelData.Text = "수동  경사보내기";
            this.btnSendHeelData.UseVisualStyleBackColor = true;
            this.btnSendHeelData.Click += new System.EventHandler(this.btnSendHeelData_Click);
            // 
            // chkHexa
            // 
            this.chkHexa.AutoSize = true;
            this.chkHexa.Location = new System.Drawing.Point(684, 364);
            this.chkHexa.Name = "chkHexa";
            this.chkHexa.Size = new System.Drawing.Size(56, 19);
            this.chkHexa.TabIndex = 45;
            this.chkHexa.Text = "HEXA";
            this.chkHexa.UseVisualStyleBackColor = true;
            // 
            // btnSendNMEA
            // 
            this.btnSendNMEA.Location = new System.Drawing.Point(623, 53);
            this.btnSendNMEA.Name = "btnSendNMEA";
            this.btnSendNMEA.Size = new System.Drawing.Size(117, 30);
            this.btnSendNMEA.TabIndex = 46;
            this.btnSendNMEA.Text = "NMEA 보내기";
            this.btnSendNMEA.UseVisualStyleBackColor = true;
            this.btnSendNMEA.Visible = false;
            this.btnSendNMEA.Click += new System.EventHandler(this.btnSendNMEA_Click);
            // 
            // btn0LevelAccident
            // 
            this.btn0LevelAccident.Location = new System.Drawing.Point(21, 187);
            this.btn0LevelAccident.Name = "btn0LevelAccident";
            this.btn0LevelAccident.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn0LevelAccident.Size = new System.Drawing.Size(101, 35);
            this.btn0LevelAccident.TabIndex = 47;
            this.btn0LevelAccident.Text = "정상등급 상황";
            this.btn0LevelAccident.UseVisualStyleBackColor = true;
            this.btn0LevelAccident.Visible = false;
            this.btn0LevelAccident.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1LevelAccident
            // 
            this.btn1LevelAccident.Location = new System.Drawing.Point(159, 187);
            this.btn1LevelAccident.Name = "btn1LevelAccident";
            this.btn1LevelAccident.Size = new System.Drawing.Size(116, 35);
            this.btn1LevelAccident.TabIndex = 48;
            this.btn1LevelAccident.Text = "경미한 등급 상황";
            this.btn1LevelAccident.UseVisualStyleBackColor = true;
            this.btn1LevelAccident.Visible = false;
            this.btn1LevelAccident.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn2LevelAccident
            // 
            this.btn2LevelAccident.Location = new System.Drawing.Point(301, 187);
            this.btn2LevelAccident.Name = "btn2LevelAccident";
            this.btn2LevelAccident.Size = new System.Drawing.Size(108, 35);
            this.btn2LevelAccident.TabIndex = 49;
            this.btn2LevelAccident.Text = "중대한 등급 상황";
            this.btn2LevelAccident.UseVisualStyleBackColor = true;
            this.btn2LevelAccident.Visible = false;
            this.btn2LevelAccident.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn3LevelAccident
            // 
            this.btn3LevelAccident.Location = new System.Drawing.Point(434, 187);
            this.btn3LevelAccident.Name = "btn3LevelAccident";
            this.btn3LevelAccident.Size = new System.Drawing.Size(113, 35);
            this.btn3LevelAccident.TabIndex = 50;
            this.btn3LevelAccident.Text = "치명적 등급 상황";
            this.btn3LevelAccident.UseVisualStyleBackColor = true;
            this.btn3LevelAccident.Visible = false;
            this.btn3LevelAccident.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbINDLower
            // 
            this.tbINDLower.Location = new System.Drawing.Point(22, 89);
            this.tbINDLower.Name = "tbINDLower";
            this.tbINDLower.Size = new System.Drawing.Size(595, 23);
            this.tbINDLower.TabIndex = 51;
            this.tbINDLower.Text = "$PDIND,LOWER,1,1,1,1,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1";
            // 
            // DataValid
            // 
            this.DataValid.AutoSize = true;
            this.DataValid.Location = new System.Drawing.Point(547, 155);
            this.DataValid.Name = "DataValid";
            this.DataValid.Size = new System.Drawing.Size(69, 19);
            this.DataValid.TabIndex = 52;
            this.DataValid.Text = "Validate";
            this.DataValid.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "선박의 위치";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 54;
            this.textBox1.Text = "34.0559 , 129.0559";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Heading";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(640, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 56;
            this.textBox2.Text = "92.7";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(450, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 58;
            this.textBox3.Text = "10 kts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 57;
            this.label9.Text = "속력";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(640, 337);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 60;
            this.textBox4.Text = "3.5 km";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 59;
            this.label10.Text = "자선과의 거리";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 561);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataValid);
            this.Controls.Add(this.tbINDLower);
            this.Controls.Add(this.btn3LevelAccident);
            this.Controls.Add(this.btn2LevelAccident);
            this.Controls.Add(this.btn1LevelAccident);
            this.Controls.Add(this.btn0LevelAccident);
            this.Controls.Add(this.btnSendNMEA);
            this.Controls.Add(this.chkHexa);
            this.Controls.Add(this.btnSendHeelData);
            this.Controls.Add(this.btnSecondAccidentPrevent);
            this.Controls.Add(this.btnNewRoutePlanSend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbServerStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbXML);
            this.Controls.Add(this.lower10);
            this.Controls.Add(this.lower9);
            this.Controls.Add(this.lower8);
            this.Controls.Add(this.lower7);
            this.Controls.Add(this.lower6);
            this.Controls.Add(this.lower5);
            this.Controls.Add(this.lower4);
            this.Controls.Add(this.lower3);
            this.Controls.Add(this.lower2);
            this.Controls.Add(this.lower1);
            this.Controls.Add(this.upper10);
            this.Controls.Add(this.upper9);
            this.Controls.Add(this.upper8);
            this.Controls.Add(this.upper7);
            this.Controls.Add(this.upper6);
            this.Controls.Add(this.upper5);
            this.Controls.Add(this.upper4);
            this.Controls.Add(this.upper3);
            this.Controls.Add(this.upper2);
            this.Controls.Add(this.upper1);
            this.Controls.Add(this.tbRollAmplitudeStbd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRollAmplitudePort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRollPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHeelAngle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbINDUpper);
            this.Controls.Add(this.tbHRM);
            this.Controls.Add(this.btnSendRollData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사고대응 서비스";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSendRollData;
        private TextBox tbHRM;
        private TextBox tbINDUpper;
        private Label label1;
        private TextBox tbHeelAngle;
        private TextBox tbRollPeriod;
        private Label label2;
        private TextBox tbRollAmplitudePort;
        private Label label3;
        private TextBox tbRollAmplitudeStbd;
        private Label label4;
        private CheckBox upper1;
        private CheckBox upper2;
        private CheckBox upper3;
        private CheckBox upper4;
        private CheckBox upper5;
        private CheckBox upper10;
        private CheckBox upper9;
        private CheckBox upper8;
        private CheckBox upper7;
        private CheckBox upper6;
        private CheckBox lower10;
        private CheckBox lower9;
        private CheckBox lower8;
        private CheckBox lower7;
        private CheckBox lower6;
        private CheckBox lower5;
        private CheckBox lower4;
        private CheckBox lower3;
        private CheckBox lower2;
        private CheckBox lower1;
        private TextBox tbXML;
        private Label label7;
        private System.Windows.Forms.Timer timerSendRollData;
        private Label label8;
        private TextBox tbServerStatus;
        private Button btnNewRoutePlanSend;
        private Button btnSecondAccidentPrevent;
        private System.Windows.Forms.Timer timerSendFloodData;
        private Button btnSendHeelData;
        private CheckBox chkHexa;
        private Button btnSendNMEA;
        private Button btn0LevelAccident;
        private Button btn1LevelAccident;
        private Button btn2LevelAccident;
        private Button btn3LevelAccident;
        private TextBox tbINDLower;
        private CheckBox DataValid;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
    }
}