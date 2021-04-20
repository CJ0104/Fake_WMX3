namespace EtherCAT_28_motor_testing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeviceCount = new System.Windows.Forms.Label();
            this.axis1_targetpostion_t = new System.Windows.Forms.TextBox();
            this.axis1_modesofoperation_t = new System.Windows.Forms.TextBox();
            this.axis1_controlword_t = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.LAB_StatusWord = new System.Windows.Forms.Label();
            this.LAB_mode = new System.Windows.Forms.Label();
            this.LAB_actual_position = new System.Windows.Forms.Label();
            this.LAB_actual_velocity = new System.Windows.Forms.Label();
            this.BTN_disC = new System.Windows.Forms.Button();
            this.BT_Send1 = new System.Windows.Forms.Button();
            this.axis1_targetdiference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LAB_current_position = new System.Windows.Forms.Label();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_Start = new System.Windows.Forms.Button();
            this.Btn_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LAB_phase_count = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.axis1_Final_target = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LAB_Tar_perc_pos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.axis1_TargetVelocity = new System.Windows.Forms.TextBox();
            this.axis1_ProfileDeceleration = new System.Windows.Forms.TextBox();
            this.axis1_ProfileAcceleration = new System.Windows.Forms.TextBox();
            this.Btn_Heating = new System.Windows.Forms.Button();
            this.time_Forheat = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.LAB_Heat_sec = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.LAB_ActVel = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.LAB_ActPos = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_H_start = new System.Windows.Forms.Button();
            this.TXB_H_Method = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.TXB_H_SFS = new System.Windows.Forms.TextBox();
            this.TXB_H_SFZ = new System.Windows.Forms.TextBox();
            this.TXB_H_Acc = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_PV_Start = new System.Windows.Forms.Button();
            this.TXB_PV_TV = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TXB_PV_PA = new System.Windows.Forms.TextBox();
            this.TXB_PV_PD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_PP_Start = new System.Windows.Forms.Button();
            this.TXB_PP_TP = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TXB_PP_PV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXB_PP_PA = new System.Windows.Forms.TextBox();
            this.TXB_PP_PD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BTN_SV_ON = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.LAB_STW = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "TwinCAT Connect";
            // 
            // BTN_connect
            // 
            this.BTN_connect.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_connect.Location = new System.Drawing.Point(200, 10);
            this.BTN_connect.Name = "BTN_connect";
            this.BTN_connect.Size = new System.Drawing.Size(108, 53);
            this.BTN_connect.TabIndex = 15;
            this.BTN_connect.Text = "Connect";
            this.BTN_connect.UseVisualStyleBackColor = true;
            this.BTN_connect.Click += new System.EventHandler(this.BTN_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F);
            this.label3.Location = new System.Drawing.Point(314, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Device:";
            // 
            // DeviceCount
            // 
            this.DeviceCount.AutoSize = true;
            this.DeviceCount.Font = new System.Drawing.Font("新細明體", 14F);
            this.DeviceCount.Location = new System.Drawing.Point(406, 23);
            this.DeviceCount.Name = "DeviceCount";
            this.DeviceCount.Size = new System.Drawing.Size(18, 19);
            this.DeviceCount.TabIndex = 35;
            this.DeviceCount.Text = "0";
            // 
            // axis1_targetpostion_t
            // 
            this.axis1_targetpostion_t.Location = new System.Drawing.Point(283, 115);
            this.axis1_targetpostion_t.Name = "axis1_targetpostion_t";
            this.axis1_targetpostion_t.Size = new System.Drawing.Size(100, 20);
            this.axis1_targetpostion_t.TabIndex = 41;
            this.axis1_targetpostion_t.Text = "0";
            // 
            // axis1_modesofoperation_t
            // 
            this.axis1_modesofoperation_t.Location = new System.Drawing.Point(283, 81);
            this.axis1_modesofoperation_t.Name = "axis1_modesofoperation_t";
            this.axis1_modesofoperation_t.Size = new System.Drawing.Size(100, 20);
            this.axis1_modesofoperation_t.TabIndex = 40;
            this.axis1_modesofoperation_t.Text = "8";
            // 
            // axis1_controlword_t
            // 
            this.axis1_controlword_t.Location = new System.Drawing.Point(283, 46);
            this.axis1_controlword_t.Name = "axis1_controlword_t";
            this.axis1_controlword_t.Size = new System.Drawing.Size(100, 20);
            this.axis1_controlword_t.TabIndex = 39;
            this.axis1_controlword_t.Text = "6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 14F);
            this.label16.Location = new System.Drawing.Point(67, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 19);
            this.label16.TabIndex = 36;
            this.label16.Text = "ControlWord：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 14F);
            this.label17.Location = new System.Drawing.Point(67, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 19);
            this.label17.TabIndex = 37;
            this.label17.Text = "ModesOfOperation：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("新細明體", 14F);
            this.label18.Location = new System.Drawing.Point(69, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 19);
            this.label18.TabIndex = 38;
            this.label18.Text = "Position：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("新細明體", 14F);
            this.label19.Location = new System.Drawing.Point(603, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(253, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "RealVelocityValue[μsteps / t]：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("新細明體", 14F);
            this.label20.Location = new System.Drawing.Point(603, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 19);
            this.label20.TabIndex = 42;
            this.label20.Text = "StatusWord：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("新細明體", 14F);
            this.label21.Location = new System.Drawing.Point(603, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(224, 19);
            this.label21.TabIndex = 43;
            this.label21.Text = "ModesOfOperationDisplay：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("新細明體", 14F);
            this.label23.Location = new System.Drawing.Point(603, 177);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(178, 19);
            this.label23.TabIndex = 44;
            this.label23.Text = "PositionActualValue：";
            // 
            // LAB_StatusWord
            // 
            this.LAB_StatusWord.AutoSize = true;
            this.LAB_StatusWord.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_StatusWord.Location = new System.Drawing.Point(886, 37);
            this.LAB_StatusWord.Name = "LAB_StatusWord";
            this.LAB_StatusWord.Size = new System.Drawing.Size(18, 19);
            this.LAB_StatusWord.TabIndex = 46;
            this.LAB_StatusWord.Text = "0";
            // 
            // LAB_mode
            // 
            this.LAB_mode.AutoSize = true;
            this.LAB_mode.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_mode.Location = new System.Drawing.Point(886, 73);
            this.LAB_mode.Name = "LAB_mode";
            this.LAB_mode.Size = new System.Drawing.Size(18, 19);
            this.LAB_mode.TabIndex = 47;
            this.LAB_mode.Text = "0";
            // 
            // LAB_actual_position
            // 
            this.LAB_actual_position.AutoSize = true;
            this.LAB_actual_position.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_actual_position.Location = new System.Drawing.Point(886, 177);
            this.LAB_actual_position.Name = "LAB_actual_position";
            this.LAB_actual_position.Size = new System.Drawing.Size(18, 19);
            this.LAB_actual_position.TabIndex = 48;
            this.LAB_actual_position.Text = "0";
            // 
            // LAB_actual_velocity
            // 
            this.LAB_actual_velocity.AutoSize = true;
            this.LAB_actual_velocity.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_actual_velocity.Location = new System.Drawing.Point(886, 107);
            this.LAB_actual_velocity.Name = "LAB_actual_velocity";
            this.LAB_actual_velocity.Size = new System.Drawing.Size(18, 19);
            this.LAB_actual_velocity.TabIndex = 49;
            this.LAB_actual_velocity.Text = "0";
            // 
            // BTN_disC
            // 
            this.BTN_disC.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_disC.Location = new System.Drawing.Point(493, 10);
            this.BTN_disC.Name = "BTN_disC";
            this.BTN_disC.Size = new System.Drawing.Size(142, 57);
            this.BTN_disC.TabIndex = 50;
            this.BTN_disC.Text = "Disconnect";
            this.BTN_disC.UseVisualStyleBackColor = true;
            this.BTN_disC.Click += new System.EventHandler(this.BTN_disC_Click);
            // 
            // BT_Send1
            // 
            this.BT_Send1.Enabled = false;
            this.BT_Send1.Font = new System.Drawing.Font("新細明體", 14F);
            this.BT_Send1.Location = new System.Drawing.Point(419, 211);
            this.BT_Send1.Name = "BT_Send1";
            this.BT_Send1.Size = new System.Drawing.Size(110, 44);
            this.BT_Send1.TabIndex = 51;
            this.BT_Send1.Text = "Send";
            this.BT_Send1.UseVisualStyleBackColor = true;
            this.BT_Send1.Click += new System.EventHandler(this.BT_Send1_Click);
            // 
            // axis1_targetdiference
            // 
            this.axis1_targetdiference.Location = new System.Drawing.Point(283, 148);
            this.axis1_targetdiference.Margin = new System.Windows.Forms.Padding(2);
            this.axis1_targetdiference.Name = "axis1_targetdiference";
            this.axis1_targetdiference.Size = new System.Drawing.Size(100, 20);
            this.axis1_targetdiference.TabIndex = 55;
            this.axis1_targetdiference.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2.Location = new System.Drawing.Point(67, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "TargetDifference:";
            // 
            // BTN_reset
            // 
            this.BTN_reset.Font = new System.Drawing.Font("新細明體", 14F);
            this.BTN_reset.Location = new System.Drawing.Point(398, 353);
            this.BTN_reset.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_reset.Name = "BTN_reset";
            this.BTN_reset.Size = new System.Drawing.Size(116, 59);
            this.BTN_reset.TabIndex = 57;
            this.BTN_reset.Text = "Reset";
            this.BTN_reset.UseVisualStyleBackColor = true;
            this.BTN_reset.Click += new System.EventHandler(this.BTN_reset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F);
            this.label4.Location = new System.Drawing.Point(603, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "CurrentPosition:";
            // 
            // LAB_current_position
            // 
            this.LAB_current_position.AutoSize = true;
            this.LAB_current_position.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_current_position.Location = new System.Drawing.Point(886, 142);
            this.LAB_current_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_current_position.Name = "LAB_current_position";
            this.LAB_current_position.Size = new System.Drawing.Size(18, 19);
            this.LAB_current_position.TabIndex = 60;
            this.LAB_current_position.Text = "0";
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Font = new System.Drawing.Font("新細明體", 14F);
            this.BTN_Stop.Location = new System.Drawing.Point(255, 353);
            this.BTN_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(120, 57);
            this.BTN_Stop.TabIndex = 69;
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Font = new System.Drawing.Font("新細明體", 14F);
            this.BTN_Start.Location = new System.Drawing.Point(116, 353);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(122, 55);
            this.BTN_Start.TabIndex = 70;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // Btn_add
            // 
            this.Btn_add.Font = new System.Drawing.Font("新細明體", 14F);
            this.Btn_add.Location = new System.Drawing.Point(419, 261);
            this.Btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(110, 47);
            this.Btn_add.TabIndex = 71;
            this.Btn_add.Text = "add";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14F);
            this.label9.Location = new System.Drawing.Point(603, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 72;
            this.label9.Text = "PhaseCount:";
            // 
            // LAB_phase_count
            // 
            this.LAB_phase_count.AutoSize = true;
            this.LAB_phase_count.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_phase_count.Location = new System.Drawing.Point(886, 213);
            this.LAB_phase_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_phase_count.Name = "LAB_phase_count";
            this.LAB_phase_count.Size = new System.Drawing.Size(18, 19);
            this.LAB_phase_count.TabIndex = 73;
            this.LAB_phase_count.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14F);
            this.label10.Location = new System.Drawing.Point(69, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 19);
            this.label10.TabIndex = 74;
            this.label10.Text = "Final_Target:";
            // 
            // axis1_Final_target
            // 
            this.axis1_Final_target.Location = new System.Drawing.Point(283, 189);
            this.axis1_Final_target.Margin = new System.Windows.Forms.Padding(2);
            this.axis1_Final_target.Name = "axis1_Final_target";
            this.axis1_Final_target.Size = new System.Drawing.Size(100, 20);
            this.axis1_Final_target.TabIndex = 75;
            this.axis1_Final_target.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14F);
            this.label5.Location = new System.Drawing.Point(603, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "PercentTarget:";
            // 
            // LAB_Tar_perc_pos
            // 
            this.LAB_Tar_perc_pos.AutoSize = true;
            this.LAB_Tar_perc_pos.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_Tar_perc_pos.Location = new System.Drawing.Point(886, 252);
            this.LAB_Tar_perc_pos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_Tar_perc_pos.Name = "LAB_Tar_perc_pos";
            this.LAB_Tar_perc_pos.Size = new System.Drawing.Size(18, 19);
            this.LAB_Tar_perc_pos.TabIndex = 77;
            this.LAB_Tar_perc_pos.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14F);
            this.label6.Location = new System.Drawing.Point(69, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 78;
            this.label6.Text = "TargetVelocity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 14F);
            this.label7.Location = new System.Drawing.Point(67, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 79;
            this.label7.Text = "ProfileDeceleration:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14F);
            this.label8.Location = new System.Drawing.Point(67, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 80;
            this.label8.Text = "ProfileAcceleration:";
            // 
            // axis1_TargetVelocity
            // 
            this.axis1_TargetVelocity.Location = new System.Drawing.Point(283, 297);
            this.axis1_TargetVelocity.Margin = new System.Windows.Forms.Padding(2);
            this.axis1_TargetVelocity.Name = "axis1_TargetVelocity";
            this.axis1_TargetVelocity.Size = new System.Drawing.Size(100, 20);
            this.axis1_TargetVelocity.TabIndex = 81;
            this.axis1_TargetVelocity.Text = "0";
            // 
            // axis1_ProfileDeceleration
            // 
            this.axis1_ProfileDeceleration.Location = new System.Drawing.Point(283, 261);
            this.axis1_ProfileDeceleration.Margin = new System.Windows.Forms.Padding(2);
            this.axis1_ProfileDeceleration.Name = "axis1_ProfileDeceleration";
            this.axis1_ProfileDeceleration.Size = new System.Drawing.Size(100, 20);
            this.axis1_ProfileDeceleration.TabIndex = 82;
            this.axis1_ProfileDeceleration.Text = "0";
            // 
            // axis1_ProfileAcceleration
            // 
            this.axis1_ProfileAcceleration.Location = new System.Drawing.Point(283, 225);
            this.axis1_ProfileAcceleration.Margin = new System.Windows.Forms.Padding(2);
            this.axis1_ProfileAcceleration.Name = "axis1_ProfileAcceleration";
            this.axis1_ProfileAcceleration.Size = new System.Drawing.Size(100, 20);
            this.axis1_ProfileAcceleration.TabIndex = 83;
            this.axis1_ProfileAcceleration.Text = "0";
            // 
            // Btn_Heating
            // 
            this.Btn_Heating.Font = new System.Drawing.Font("新細明體", 14F);
            this.Btn_Heating.Location = new System.Drawing.Point(116, 435);
            this.Btn_Heating.Name = "Btn_Heating";
            this.Btn_Heating.Size = new System.Drawing.Size(122, 52);
            this.Btn_Heating.TabIndex = 84;
            this.Btn_Heating.Text = "Heat";
            this.Btn_Heating.UseVisualStyleBackColor = true;
            this.Btn_Heating.Click += new System.EventHandler(this.Btn_Heating_Click);
            // 
            // time_Forheat
            // 
            this.time_Forheat.Interval = 20;
            this.time_Forheat.Tick += new System.EventHandler(this.time_Forheat_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14F);
            this.label11.Location = new System.Drawing.Point(603, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 85;
            this.label11.Text = "HeatSecond:";
            // 
            // LAB_Heat_sec
            // 
            this.LAB_Heat_sec.AutoSize = true;
            this.LAB_Heat_sec.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_Heat_sec.Location = new System.Drawing.Point(886, 288);
            this.LAB_Heat_sec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAB_Heat_sec.Name = "LAB_Heat_sec";
            this.LAB_Heat_sec.Size = new System.Drawing.Size(18, 19);
            this.LAB_Heat_sec.TabIndex = 86;
            this.LAB_Heat_sec.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 657);
            this.tabControl1.TabIndex = 87;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTN_Start);
            this.tabPage1.Controls.Add(this.LAB_Heat_sec);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.Btn_Heating);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.axis1_ProfileAcceleration);
            this.tabPage1.Controls.Add(this.axis1_controlword_t);
            this.tabPage1.Controls.Add(this.axis1_ProfileDeceleration);
            this.tabPage1.Controls.Add(this.axis1_modesofoperation_t);
            this.tabPage1.Controls.Add(this.axis1_TargetVelocity);
            this.tabPage1.Controls.Add(this.axis1_targetpostion_t);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.LAB_Tar_perc_pos);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.LAB_StatusWord);
            this.tabPage1.Controls.Add(this.axis1_Final_target);
            this.tabPage1.Controls.Add(this.LAB_mode);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.LAB_actual_position);
            this.tabPage1.Controls.Add(this.LAB_phase_count);
            this.tabPage1.Controls.Add(this.LAB_actual_velocity);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.BT_Send1);
            this.tabPage1.Controls.Add(this.Btn_add);
            this.tabPage1.Controls.Add(this.axis1_targetdiference);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BTN_Stop);
            this.tabPage1.Controls.Add(this.BTN_reset);
            this.tabPage1.Controls.Add(this.LAB_current_position);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 632);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TM shit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.LAB_ActVel);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.LAB_ActPos);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.BTN_SV_ON);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.LAB_STW);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 632);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FakeWMX";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("新細明體", 14F);
            this.label33.Location = new System.Drawing.Point(548, 36);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(86, 19);
            this.label33.TabIndex = 93;
            this.label33.Text = "Velocity : ";
            // 
            // LAB_ActVel
            // 
            this.LAB_ActVel.AutoSize = true;
            this.LAB_ActVel.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_ActVel.Location = new System.Drawing.Point(666, 36);
            this.LAB_ActVel.Name = "LAB_ActVel";
            this.LAB_ActVel.Size = new System.Drawing.Size(18, 19);
            this.LAB_ActVel.TabIndex = 94;
            this.LAB_ActVel.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("新細明體", 14F);
            this.label31.Location = new System.Drawing.Point(287, 36);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 19);
            this.label31.TabIndex = 91;
            this.label31.Text = "Position : ";
            // 
            // LAB_ActPos
            // 
            this.LAB_ActPos.AutoSize = true;
            this.LAB_ActPos.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_ActPos.Location = new System.Drawing.Point(407, 36);
            this.LAB_ActPos.Name = "LAB_ActPos";
            this.LAB_ActPos.Size = new System.Drawing.Size(18, 19);
            this.LAB_ActPos.TabIndex = 92;
            this.LAB_ActPos.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_H_start);
            this.groupBox3.Controls.Add(this.TXB_H_Method);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.TXB_H_SFS);
            this.groupBox3.Controls.Add(this.TXB_H_SFZ);
            this.groupBox3.Controls.Add(this.TXB_H_Acc);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(477, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 369);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Homing Mode";
            // 
            // BTN_H_start
            // 
            this.BTN_H_start.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_H_start.Location = new System.Drawing.Point(206, 32);
            this.BTN_H_start.Name = "BTN_H_start";
            this.BTN_H_start.Size = new System.Drawing.Size(108, 53);
            this.BTN_H_start.TabIndex = 92;
            this.BTN_H_start.Text = "Start";
            this.BTN_H_start.UseVisualStyleBackColor = true;
            this.BTN_H_start.Click += new System.EventHandler(this.BTN_H_start_Click);
            // 
            // TXB_H_Method
            // 
            this.TXB_H_Method.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_H_Method.Location = new System.Drawing.Point(212, 124);
            this.TXB_H_Method.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_H_Method.Name = "TXB_H_Method";
            this.TXB_H_Method.Size = new System.Drawing.Size(102, 27);
            this.TXB_H_Method.TabIndex = 98;
            this.TXB_H_Method.Text = "1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("新細明體", 14F);
            this.label30.Location = new System.Drawing.Point(22, 125);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(84, 19);
            this.label30.TabIndex = 97;
            this.label30.Text = "Method : .";
            // 
            // TXB_H_SFS
            // 
            this.TXB_H_SFS.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_H_SFS.Location = new System.Drawing.Point(212, 188);
            this.TXB_H_SFS.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_H_SFS.Name = "TXB_H_SFS";
            this.TXB_H_SFS.Size = new System.Drawing.Size(102, 27);
            this.TXB_H_SFS.TabIndex = 96;
            this.TXB_H_SFS.Text = "100000";
            // 
            // TXB_H_SFZ
            // 
            this.TXB_H_SFZ.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_H_SFZ.Location = new System.Drawing.Point(214, 238);
            this.TXB_H_SFZ.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_H_SFZ.Name = "TXB_H_SFZ";
            this.TXB_H_SFZ.Size = new System.Drawing.Size(100, 27);
            this.TXB_H_SFZ.TabIndex = 95;
            this.TXB_H_SFZ.Text = "100000";
            // 
            // TXB_H_Acc
            // 
            this.TXB_H_Acc.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_H_Acc.Location = new System.Drawing.Point(214, 284);
            this.TXB_H_Acc.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_H_Acc.Name = "TXB_H_Acc";
            this.TXB_H_Acc.Size = new System.Drawing.Size(100, 27);
            this.TXB_H_Acc.TabIndex = 94;
            this.TXB_H_Acc.Text = "100000";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("新細明體", 14F);
            this.label27.Location = new System.Drawing.Point(22, 189);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(146, 19);
            this.label27.TabIndex = 93;
            this.label27.Text = "Speed for switch : ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("新細明體", 14F);
            this.label28.Location = new System.Drawing.Point(22, 239);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(125, 19);
            this.label28.TabIndex = 92;
            this.label28.Text = "Speed for zero :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("新細明體", 14F);
            this.label29.Location = new System.Drawing.Point(22, 292);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 19);
            this.label29.TabIndex = 91;
            this.label29.Text = "Acceleration :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_PV_Start);
            this.groupBox2.Controls.Add(this.TXB_PV_TV);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.TXB_PV_PA);
            this.groupBox2.Controls.Add(this.TXB_PV_PD);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(26, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 229);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile Velocity Mode";
            // 
            // BTN_PV_Start
            // 
            this.BTN_PV_Start.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_PV_Start.Location = new System.Drawing.Point(237, 27);
            this.BTN_PV_Start.Name = "BTN_PV_Start";
            this.BTN_PV_Start.Size = new System.Drawing.Size(108, 53);
            this.BTN_PV_Start.TabIndex = 92;
            this.BTN_PV_Start.Text = "Start";
            this.BTN_PV_Start.UseVisualStyleBackColor = true;
            this.BTN_PV_Start.Click += new System.EventHandler(this.BTN_PV_Start_Click);
            // 
            // TXB_PV_TV
            // 
            this.TXB_PV_TV.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_PV_TV.Location = new System.Drawing.Point(237, 98);
            this.TXB_PV_TV.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_PV_TV.Name = "TXB_PV_TV";
            this.TXB_PV_TV.Size = new System.Drawing.Size(102, 27);
            this.TXB_PV_TV.TabIndex = 97;
            this.TXB_PV_TV.Text = "100000";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("新細明體", 14F);
            this.label26.Location = new System.Drawing.Point(23, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(165, 19);
            this.label26.TabIndex = 92;
            this.label26.Text = "Profile Deceleration :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("新細明體", 14F);
            this.label24.Location = new System.Drawing.Point(23, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 19);
            this.label24.TabIndex = 96;
            this.label24.Text = "Target Velocity :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("新細明體", 14F);
            this.label25.Location = new System.Drawing.Point(23, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(165, 19);
            this.label25.TabIndex = 93;
            this.label25.Text = "Profile Acceleration :";
            // 
            // TXB_PV_PA
            // 
            this.TXB_PV_PA.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_PV_PA.Location = new System.Drawing.Point(237, 151);
            this.TXB_PV_PA.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_PV_PA.Name = "TXB_PV_PA";
            this.TXB_PV_PA.Size = new System.Drawing.Size(100, 27);
            this.TXB_PV_PA.TabIndex = 95;
            this.TXB_PV_PA.Text = "100000";
            // 
            // TXB_PV_PD
            // 
            this.TXB_PV_PD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_PV_PD.Location = new System.Drawing.Point(237, 190);
            this.TXB_PV_PD.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_PV_PD.Name = "TXB_PV_PD";
            this.TXB_PV_PD.Size = new System.Drawing.Size(100, 27);
            this.TXB_PV_PD.TabIndex = 94;
            this.TXB_PV_PD.Text = "100000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_PP_Start);
            this.groupBox1.Controls.Add(this.TXB_PP_TP);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.TXB_PP_PV);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TXB_PP_PA);
            this.groupBox1.Controls.Add(this.TXB_PP_PD);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(6, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 276);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Posisition Mode";
            // 
            // BTN_PP_Start
            // 
            this.BTN_PP_Start.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_PP_Start.Location = new System.Drawing.Point(242, 24);
            this.BTN_PP_Start.Name = "BTN_PP_Start";
            this.BTN_PP_Start.Size = new System.Drawing.Size(108, 53);
            this.BTN_PP_Start.TabIndex = 91;
            this.BTN_PP_Start.Text = "Start";
            this.BTN_PP_Start.UseVisualStyleBackColor = true;
            this.BTN_PP_Start.Click += new System.EventHandler(this.BTN_PP_Start_Click);
            // 
            // TXB_PP_TP
            // 
            this.TXB_PP_TP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_PP_TP.Location = new System.Drawing.Point(244, 91);
            this.TXB_PP_TP.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_PP_TP.Name = "TXB_PP_TP";
            this.TXB_PP_TP.Size = new System.Drawing.Size(102, 27);
            this.TXB_PP_TP.TabIndex = 91;
            this.TXB_PP_TP.Text = "51200";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("新細明體", 14F);
            this.label22.Location = new System.Drawing.Point(32, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 19);
            this.label22.TabIndex = 90;
            this.label22.Text = "Target Position :";
            // 
            // TXB_PP_PV
            // 
            this.TXB_PP_PV.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_PP_PV.Location = new System.Drawing.Point(244, 141);
            this.TXB_PP_PV.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_PP_PV.Name = "TXB_PP_PV";
            this.TXB_PP_PV.Size = new System.Drawing.Size(102, 27);
            this.TXB_PP_PV.TabIndex = 89;
            this.TXB_PP_PV.Text = "100000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 14F);
            this.label15.Location = new System.Drawing.Point(32, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 19);
            this.label15.TabIndex = 88;
            this.label15.Text = "Profile Velocity :";
            // 
            // TXB_PP_PA
            // 
            this.TXB_PP_PA.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_PP_PA.Location = new System.Drawing.Point(246, 187);
            this.TXB_PP_PA.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_PP_PA.Name = "TXB_PP_PA";
            this.TXB_PP_PA.Size = new System.Drawing.Size(100, 27);
            this.TXB_PP_PA.TabIndex = 87;
            this.TXB_PP_PA.Text = "100000";
            // 
            // TXB_PP_PD
            // 
            this.TXB_PP_PD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TXB_PP_PD.Location = new System.Drawing.Point(246, 225);
            this.TXB_PP_PD.Margin = new System.Windows.Forms.Padding(2);
            this.TXB_PP_PD.Name = "TXB_PP_PD";
            this.TXB_PP_PD.Size = new System.Drawing.Size(100, 27);
            this.TXB_PP_PD.TabIndex = 86;
            this.TXB_PP_PD.Text = "100000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 14F);
            this.label13.Location = new System.Drawing.Point(32, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 19);
            this.label13.TabIndex = 85;
            this.label13.Text = "Profile Acceleration :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 14F);
            this.label14.Location = new System.Drawing.Point(32, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 19);
            this.label14.TabIndex = 84;
            this.label14.Text = "Profile Deceleration :";
            // 
            // BTN_SV_ON
            // 
            this.BTN_SV_ON.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_SV_ON.Location = new System.Drawing.Point(53, 18);
            this.BTN_SV_ON.Name = "BTN_SV_ON";
            this.BTN_SV_ON.Size = new System.Drawing.Size(108, 53);
            this.BTN_SV_ON.TabIndex = 88;
            this.BTN_SV_ON.Text = "Servo On";
            this.BTN_SV_ON.UseVisualStyleBackColor = true;
            this.BTN_SV_ON.Click += new System.EventHandler(this.BTN_SV_ON_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 14F);
            this.label12.Location = new System.Drawing.Point(899, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 47;
            this.label12.Text = "StatusWord：";
            // 
            // LAB_STW
            // 
            this.LAB_STW.AutoSize = true;
            this.LAB_STW.Font = new System.Drawing.Font("新細明體", 14F);
            this.LAB_STW.Location = new System.Drawing.Point(1035, 36);
            this.LAB_STW.Name = "LAB_STW";
            this.LAB_STW.Size = new System.Drawing.Size(18, 19);
            this.LAB_STW.TabIndex = 48;
            this.LAB_STW.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 751);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BTN_disC);
            this.Controls.Add(this.DeviceCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_connect);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 8F);
            this.Name = "Form1";
            this.Text = "EhterCAT Test";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DeviceCount;
        private System.Windows.Forms.TextBox axis1_targetpostion_t;
        private System.Windows.Forms.TextBox axis1_modesofoperation_t;
        private System.Windows.Forms.TextBox axis1_controlword_t;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label LAB_StatusWord;
        private System.Windows.Forms.Label LAB_mode;
        private System.Windows.Forms.Label LAB_actual_position;
        private System.Windows.Forms.Label LAB_actual_velocity;
        private System.Windows.Forms.Button BTN_disC;
        private System.Windows.Forms.Button BT_Send1;
        private System.Windows.Forms.TextBox axis1_targetdiference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LAB_current_position;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LAB_phase_count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox axis1_Final_target;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LAB_Tar_perc_pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox axis1_TargetVelocity;
        private System.Windows.Forms.TextBox axis1_ProfileDeceleration;
        private System.Windows.Forms.TextBox axis1_ProfileAcceleration;
        private System.Windows.Forms.Button Btn_Heating;
        private System.Windows.Forms.Timer time_Forheat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LAB_Heat_sec;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LAB_STW;
        private System.Windows.Forms.Button BTN_SV_ON;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_H_start;
        private System.Windows.Forms.TextBox TXB_H_Method;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox TXB_H_SFS;
        private System.Windows.Forms.TextBox TXB_H_SFZ;
        private System.Windows.Forms.TextBox TXB_H_Acc;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_PV_Start;
        private System.Windows.Forms.TextBox TXB_PV_TV;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TXB_PV_PA;
        private System.Windows.Forms.TextBox TXB_PV_PD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_PP_Start;
        private System.Windows.Forms.TextBox TXB_PP_TP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TXB_PP_PV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXB_PP_PA;
        private System.Windows.Forms.TextBox TXB_PP_PD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label LAB_ActVel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label LAB_ActPos;
    }
}

