using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.IO;
using System.IO.Ports;
using System.Threading;


namespace EtherCAT_28_motor_testing
{
    public partial class Form1 : Form
    {
        //精準 Timer
        UltraHighAccurateTimer uhat;
        //UltraHighAccurateTimer exc_clk;
        //執行續
        private delegate void MyInvoke();
        //timer
       // private static System.Timers.Timer excelTimer;//excel每10ms存一次資料
        int startflag = 1;
        int timeflag = 0;
        int excel_count = 0;


        //heat
        int heat_timecnt = 0;
        int heat_sec = 0;
        int heat_flag=0;
        Int32 TargetVelocity_temp=0;

        //Steam串流長度
        int rdLength = 0x11;
        int wdLength = 0x29;

        //excel 傳送flag
        Int32 PositionValue;//目前位置的暫存
        

        //parameter for control when will getch the data
        Int32 Phase_count = 0; //phase_count(PositionDemandValue_axis1) register
        Int32 Final_Target = 0; //Target_position(TargetPosition_axis1) register
        Int32 Target_laps = 1; //make how many laps does the motor go
        UInt32 Tar_perc_pos = 0;
        


        //TwinCAT ADS Info
        private TcAdsClient tcClient;
        private int port = 11;
        int SlaveCount = 0;
        long Group = 0x3040020;
        Int32 trans =0,targetdiff=0,reset=0;
       
 

        //********  PDO mapping AXIS 1 *************************************************************************************************//
        static public long objStatusWord_axis1 = 0x80000027;
        static public long objModesOfOperationDisplay_axis1 = 0x80000029;
        static public long objPositionActualValue_axis1 = 0x8000002A;
        static public long objRealVelocityValue_axis1 = 0x8000002E;
        static public long objFollowingErrorActualValue_axis1 = 0x80000032;
        static public long objPositionDemandValue_axis1 = 0x80000034;

        static public long objControlWord_axis1 = 0x81000027;
        static public long objModesOfOperation_axis1 = 0x81000029;
        static public long objTargetPosition_axis1 = 0x8100002A;
        static public long objPolarity_axis1 = 0x8100002E;
        static public long objProfileVelocity_axis1 = 0x8100002F;
        static public long objProfileAcceleration_axis1 = 0x81000033;
        static public long objProfileDeceleration_axis1 = 0x81000037;
        static public long objTargetVelocity_axis1 = 0x8100003B;

        //*********   PDO TX  ****************************************************************************************************//
        UInt16 Statusword_axis1;
        Byte ModesOfOperationDisplay_axis1;
        Int32 PositionActualValue_axis1;
        Int32 RealVelocityValue_axis1;
        UInt32 FollowingErrorActualValue_axis1;
        Int32 PositionDemandValue_axis1;

        //*********   PDO RX  ****************************************************************************************************//
        UInt16 Controlword_axis1;
        Byte ModesOfOperation_axis1;
        Int32 TargetPosition_axis1;
        Byte Polarity_axis1;
        UInt32 ProfileVelocity_axis1;
        UInt32 ProfileAcceleration_axis1;
        UInt32 ProfileDeceleration_axis1;
        Int32 TargetVelocity_axis1;
        //Home RX
        Byte HomingMethod_axix2;
        UInt32[] HomeSpeed_axix2 = new UInt32[2];
        UInt32 HomingAcceleration_axix2;



        public Form1()
        {
            InitializeComponent();
            uhat = new UltraHighAccurateTimer();
            uhat.Interval = 4;  //定時間隔4毫秒
            uhat.Tick += new UltraHighAccurateTimer.ManualTimerEventHandler(uhat_Tick);


            //Addexcel("actual position", "PHC", "target position", "test.csv");//write the topic in excel
        }

    
        

        private void uhat_Tick(object sender)
        {
            AdsReadFeedBack();  //Read data From Device
            AdsWrite();         //Write data to Device
            
            //when get new data reflash the UI
            MyInvoke invoke = new MyInvoke(UpdateUI);
            this.BeginInvoke(invoke);
        }

        private void UpdateUI()
        {
            //Axis 1   將從TwinCAT同步之TxPDO變數  顯示在UI介面
            LAB_StatusWord.Text = Statusword_axis1.ToString();
            LAB_mode.Text = ModesOfOperationDisplay_axis1.ToString();
            LAB_actual_position.Text = PositionActualValue_axis1.ToString();
            LAB_actual_velocity.Text = RealVelocityValue_axis1.ToString();
            LAB_phase_count.Text = PositionDemandValue_axis1.ToString();
            // axis1_followingerroractualvalue_t.Text = FollowingErrorActualValue_axis1.ToString();

            //CJ Fake WMX UI 
            LAB_STW.Text = Statusword_axis1.ToString();
            LAB_ActPos.Text = PositionActualValue_axis1.ToString();
            LAB_ActVel.Text = RealVelocityValue_axis1.ToString();
        }


        #region ADS code
        private void AdsReadFeedBack()
        {
            try
            {

                // Get the ADS return codes and examine for errors
                AdsStream rdStream = new AdsStream(rdLength);
                tcClient.Read(Group, objStatusWord_axis1, rdStream);
                BinaryReader reader = new BinaryReader(rdStream);

                // Read the data from the ADS stream
                Statusword_axis1 = reader.ReadUInt16();
                ModesOfOperationDisplay_axis1 = reader.ReadByte();
                PositionActualValue_axis1 = reader.ReadInt32();
                RealVelocityValue_axis1 = reader.ReadInt32();
                FollowingErrorActualValue_axis1 = reader.ReadUInt16();
                PositionDemandValue_axis1 = reader.ReadInt32();
                //   FollowingErrorActualValue_axis1 = reader.ReadUInt32();

            }
            catch (Exception err)
            {
                                                                 
            }
        }


        private void AdsWrite()
        {
            AdsStream wdStream = new AdsStream(wdLength);
            BinaryWriter Writer = new BinaryWriter(new AdsStream(wdLength));
            //Axis1
            Writer.Write(Controlword_axis1);
            Writer.Write(ModesOfOperation_axis1);
            Writer.Write(TargetPosition_axis1);
            Writer.Write(Polarity_axis1);
            Writer.Write(ProfileVelocity_axis1);
            Writer.Write(ProfileAcceleration_axis1);
            Writer.Write(ProfileDeceleration_axis1);
            Writer.Write(TargetVelocity_axis1);
            //Axix2
            Writer.Write(HomingMethod_axix2);
            Writer.Write(HomeSpeed_axix2[0]);
            Writer.Write(HomeSpeed_axix2[1]);
            Writer.Write(HomingAcceleration_axix2);

            tcClient.Write(Group, objControlWord_axis1, (AdsStream)Writer.BaseStream);
        }
        #endregion

        #region Excel shit
        private void Add()
        {
            PositionValue = Convert.ToInt32(axis1_targetpostion_t.Text);
            trans = Convert.ToInt32(axis1_targetpostion_t.Text);
            targetdiff = Convert.ToInt32(axis1_targetdiference.Text);
            trans += targetdiff;
            axis1_targetpostion_t.Text = trans.ToString();
        }
        //test.csv
        private void Excel()
        {
            Addexcel(LAB_actual_position.Text, LAB_phase_count.Text, axis1_targetpostion_t.Text, "test.csv");
        }

        //add data into csv with change column everytime
        public static void Addexcel(string act_pos, string PHC, string target, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(act_pos + "," + PHC + "," + target);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program did an oopsie:", ex);
            }
        }
        #endregion

        #region Timer 
        private void time_Forheat_Tick(object sender, EventArgs e)
        {
            if(RealVelocityValue_axis1 != 0)
            {
                heat_flag = 1;
            }
            heat_timecnt++;
            if(heat_timecnt==50)
            {
                heat_timecnt = 0;
                heat_sec++;
                LAB_Heat_sec.Text = heat_sec.ToString();
            }
            if(RealVelocityValue_axis1==0 && heat_flag==1)
            {
                heat_flag = 0;
                TargetVelocity_temp = TargetVelocity_axis1;
                TargetVelocity_temp = TargetVelocity_temp * -1;
                TargetVelocity_axis1 = TargetVelocity_temp;
                axis1_TargetVelocity.Text = TargetVelocity_axis1.ToString();
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Phase_count = Convert.ToInt32(LAB_phase_count.Text); 
            timeflag = 1;

            /* 0328 test mode
            if(Phase_count<=Tar_perc_pos)
            {
                Add();
                //if phase count move to 90% of target start collect excel and slow down the 
                if (Phase_count> Tar_perc_pos*0.95)
                {
                    Excel();
                    axis1_targetdiference.Text = "3";
                    timer1.Interval = 200;
                }  
            }
            else
            {
                timer1.Stop();
                Addexcel("end", " ", " ", "test.csv");
            }
            
            //write X current position
            LAB_current_position.Text = PositionValue.ToString();
            //write X control word
            Controlword_axis1 = Convert.ToUInt16(axis1_controlword_t.Text);
            //write X modes of operation
            ModesOfOperation_axis1 = Convert.ToByte(axis1_modesofoperation_t.Text);
            //write X target position
            TargetPosition_axis1 = Convert.ToInt32(axis1_targetpostion_t.Text);
            */

            //0401 test mode
            if(TargetPosition_axis1 == PositionActualValue_axis1 && excel_count<5)
            {
                Excel();
                excel_count++;
            }
            else if(excel_count==5)
            {
                timer1.Stop();
                excel_count = 0;
                Addexcel("end", " ", " ", "test.csv");
            }
            
        }
#endregion

        #region Button
        private void BTN_connect_Click(object sender, EventArgs e)
        {
            try
            {
                tcClient = new TcAdsClient();   //新增object
                tcClient.Connect(port);         //開始連線
                long index = 0x800005FA;        //0x800005FA為TwinCAT中  slave count的位址
                ushort read_data = (ushort)tcClient.ReadAny(Group, index, typeof(ushort));       //將從TwinCAT讀取 Slave數量
                DeviceCount.Text = read_data.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connect Error,please repower on the servo.");
            }
            MessageBox.Show("連線成功!");
            BT_Send1.Enabled = true;
            uhat.Start();   // 開始精準Timer

        }   


       

        private void BTN_disC_Click(object sender, EventArgs e)
        {
            try
            {
                //tcClient.Dispose();
                uhat.Stop();  //停止精準Timer
                
                DeviceCount.Text = "---";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_Send1_Click(object sender, EventArgs e)
        {
            //write X current position
            LAB_current_position.Text = PositionValue.ToString();
            //write X control word
            Controlword_axis1 = Convert.ToUInt16(axis1_controlword_t.Text);
            //write X modes of operation
            ModesOfOperation_axis1 = Convert.ToByte(axis1_modesofoperation_t.Text);

            //position mode

            //write X target position
            TargetPosition_axis1 = Convert.ToInt32(axis1_targetpostion_t.Text);
            //write X Final target
            axis1_Final_target.Text = axis1_targetpostion_t.Text; //final target = target position on UI
            Final_Target = Convert.ToInt32(axis1_Final_target.Text);
            
            //speed mode

            //write X ProfileAcceleration
            ProfileAcceleration_axis1 = Convert.ToUInt32(axis1_ProfileAcceleration.Text);
            //write X ProfileDcceleration
            ProfileDeceleration_axis1 = Convert.ToUInt32(axis1_ProfileDeceleration.Text);
            //write TargetVelocity
            TargetVelocity_axis1 = Convert.ToInt32(axis1_TargetVelocity.Text);

            //decide the motor laps and the position PHC need to get
            if (Final_Target>0)
            {
                Tar_perc_pos = Convert.ToUInt32(Final_Target) * 10000 / 51200;
                
                if (Final_Target > 51200)
                {
                    Target_laps = Final_Target / 51200;
                }
            }
            else
            {
                Tar_perc_pos = Convert.ToUInt32(Final_Target * -10000 / 51200);
               if (Final_Target < -51200)
                {
                    Target_laps = Final_Target / 51200;
                }
            }

            //show Tar_perc_pos on UI
            LAB_Tar_perc_pos.Text = Tar_perc_pos.ToString();


            //postion mode開始條件
            if (Controlword_axis1==15 && ModesOfOperation_axis1==8)
            {
                startflag = 1;
                timer1.Start();
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeflag = 0;
        }

       
        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (startflag == 1)
            {
                //把位置的公差加入目標位置
                PositionValue = Convert.ToInt32(axis1_targetpostion_t.Text);
                trans = Convert.ToInt32(axis1_targetpostion_t.Text);
                targetdiff = Convert.ToInt32(axis1_targetdiference.Text);
                trans += targetdiff;
                axis1_targetpostion_t.Text = trans.ToString();
            }
        }

        private void Btn_Heating_Click(object sender, EventArgs e)
        {
            if(ModesOfOperation_axis1 == 3 && Controlword_axis1==31)
            {
                axis1_ProfileAcceleration.Text = "50000";
                axis1_ProfileDeceleration.Text = "50000";
                axis1_TargetVelocity.Text = "300000";
                time_Forheat.Start();

                //write X ProfileAcceleration
                ProfileAcceleration_axis1 = Convert.ToUInt32(axis1_ProfileAcceleration.Text);
                //write X ProfileDcceleration
                ProfileDeceleration_axis1 = Convert.ToUInt32(axis1_ProfileDeceleration.Text);
                //write TargetVelocity
                TargetVelocity_axis1 = Convert.ToInt32(axis1_TargetVelocity.Text);
            }
        }

       
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (startflag == 1)
            {
                timer1.Start();

                //把位置的公差加入目標位置
                PositionValue = Convert.ToInt32(axis1_targetpostion_t.Text);
                trans = Convert.ToInt32(axis1_targetpostion_t.Text);
                targetdiff = Convert.ToInt32(axis1_targetdiference.Text);
                trans += targetdiff;
                axis1_targetpostion_t.Text = trans.ToString();
            }         
        }

       

        //重置目標位置
        private void BTN_reset_Click(object sender, EventArgs e)
        {
            axis1_targetpostion_t.Text = reset.ToString();
            TargetPosition_axis1 = 0;

            //write X current position
            LAB_current_position.Text = PositionValue.ToString();
            //write X control word
            Controlword_axis1 = Convert.ToUInt16(axis1_controlword_t.Text);
            //write X modes of operation
            ModesOfOperation_axis1 = Convert.ToByte(axis1_modesofoperation_t.Text);
            //write X target position
            TargetPosition_axis1 = Convert.ToInt32(axis1_targetpostion_t.Text);

            startflag = 1;
            

        }


        #endregion

        #region Fake WMX3 code

        private void BTN_SV_ON_Click(object sender, EventArgs e)
        {
            BTN_SV_ON.Enabled = false;
            if(BTN_SV_ON.Text == "Servo On")
            {
                Controlword_axis1 = 6;
                Thread.Sleep(20);
                Controlword_axis1 = 7;
                Thread.Sleep(20);
                Controlword_axis1 = 15;
                BTN_SV_ON.Text = "Servo Off";
            }
            else
            {
                Controlword_axis1 = 7;
                BTN_SV_ON.Text = "Servo On";
            }
            
            BTN_SV_ON.Enabled = true;

        }

      

        //PP Mode
        private void BTN_PP_Start_Click(object sender, EventArgs e)
        {
            BTN_PP_Start.Enabled = false;

            ModesOfOperation_axis1 = Convert.ToByte("1");   //mode OP = 1 PP mode 
            Thread.Sleep(20);
            Controlword_axis1 = 15;
            Thread.Sleep(20);
            TargetPosition_axis1        = Convert.ToInt32(TXB_PP_TP.Text);
            ProfileVelocity_axis1       = Convert.ToUInt32(TXB_PP_PV.Text);
            ProfileAcceleration_axis1   = Convert.ToUInt32(TXB_PP_PA.Text);
            ProfileDeceleration_axis1   = Convert.ToUInt32(TXB_PP_PD.Text);
            Thread.Sleep(20);
            Controlword_axis1 = 31;
            BTN_PP_Start.Enabled = true;

        }
        //PV Mode
        private void BTN_PV_Start_Click(object sender, EventArgs e)
        {
            BTN_PV_Start.Enabled = false;
            ModesOfOperation_axis1 = Convert.ToByte("3");   //mode OP = 3 PV mode
            Thread.Sleep(20);
            Controlword_axis1 = 15;
            Thread.Sleep(20);
            TargetVelocity_axis1 = Convert.ToInt32(TXB_PV_TV.Text);
            ProfileAcceleration_axis1 = Convert.ToUInt32(TXB_PV_PA.Text);
            ProfileDeceleration_axis1 = Convert.ToUInt32(TXB_PV_PD.Text);
            Thread.Sleep(20);
            Controlword_axis1 = 31;
            BTN_PV_Start.Enabled = true;
        }
        //Homing Mode
        private void BTN_H_start_Click(object sender, EventArgs e)
        {
            BTN_H_start.Enabled = false;
            ModesOfOperation_axis1 = Convert.ToByte("6");   //mode OP = 6 HM mode
            Thread.Sleep(20);
            Controlword_axis1 = 15;
            Thread.Sleep(20);
            HomingMethod_axix2 = Convert.ToByte(TXB_H_Method.Text);
            HomeSpeed_axix2[0] = Convert.ToUInt32(TXB_H_SFS.Text);
            HomeSpeed_axix2[1] = Convert.ToUInt32(TXB_H_SFZ.Text);
            HomingAcceleration_axix2 = Convert.ToUInt32(TXB_H_Acc.Text);
            Thread.Sleep(20);
            Controlword_axis1 = 31;
            BTN_H_start.Enabled = true;

        }

        #endregion

    }
}
