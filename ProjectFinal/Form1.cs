using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        // ใช้สำหรับการเปลี่ยนหน้า tabpage เมื่อกดปุ่ม button จะทำการเปลี่ยนไปหน้าที่ตั้งค่าไว้
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnPlaySlot_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void btnPlayRock_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void btnPlayTic_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void btnPlayPuzzle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnOutHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnHomeSlot_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnHomeRock_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnHomeTic_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnHomePuzzle_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        // FRUITS SLOT GAME

        int count1 = 0;
        int count02 = 0;

        private void btnStartSlot_Click(object sender, EventArgs e)
        {
            //ใช้สำหรับการสุ่มรูป
            Random random = new Random();
            int ranNum1 = random.Next(1, 8);
            int ranNum2 = random.Next(1, 8);
            int ranNum3 = random.Next(1, 8);

            string lotto1 = PicSlot01.ToString();
            string lotto2 = PicSlot02.ToString();
            string lotto3 = PicSlot03.ToString();

            if (rad10.Checked == true)
            {
                count1++;
                lblOut.Text = "คุณสุ่มครั้งที่ " + count1;
                //กำหนดรูปแต่ละรูปที่ต้องการให้ตรงกับตัวเลขที่ต้องการ random ทำทั้งหมดจนครบ 3 ตัวสุ่ม
                if (ranNum1 == 1)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum1 == 2)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum1 == 3)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum1 == 4)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum1 == 5)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum1 == 6)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum1 == 7)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum2 == 1)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum2 == 2)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum2 == 3)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum2 == 4)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum2 == 5)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum2 == 6)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum2 == 7)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum3 == 1)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum3 == 2)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum3 == 3)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum3 == 4)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum3 == 5)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum3 == 6)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum3 == 7)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum1 != ranNum2 && ranNum1 != ranNum3) //เมื่อรูปที่แสดงออกมาต่างกันอย่างน้อย 1 รูป จะแสดงข้อความที่กำหนดไว้
                    lblput.Text = "เสียใจด้วย!! คุณไม่ถูกรางวัล";
                else if (ranNum1 == ranNum2 && ranNum1 == ranNum3) //เมื่อรูปที่แสดงออกมาเหมือนกันทั้งหมด 3 รูป จะแสดงข้อความที่กำหนดไว้
                {
                    count02++;
                    lblput.Text = "ยินดีด้วย!! คุณถูกรางวัล";
                    lblPut2.Text = "คุณถูกรางวัล " + count02 + " ครั้ง";
                }

                if (count1 == 10) //กำหนดให้เมื่อกดจนครบ 10 ครั้ง จะไม่สามารถกดปุ่ม Random ได้
                    btnStartSlot.Enabled = false;
            }

            if (rad20.Checked == true)
            {
                count1++;
                lblOut.Text = "คุณสุ่มครั้งที่ " + count1;
                if (ranNum1 == 1)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum1 == 2)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum1 == 3)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum1 == 4)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum1 == 5)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum1 == 6)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum1 == 7)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum2 == 1)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum2 == 2)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum2 == 3)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum2 == 4)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum2 == 5)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum2 == 6)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum2 == 7)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum3 == 1)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum3 == 2)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum3 == 3)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum3 == 4)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum3 == 5)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum3 == 6)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum3 == 7)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum1 != ranNum2 && ranNum1 != ranNum3)
                    lblput.Text = "เสียใจด้วย!! คุณไม่ถูกรางวัล";
                else if (ranNum1 == ranNum2 && ranNum1 == ranNum3)
                {
                    count02++;
                    lblput.Text = "ยินดีด้วย!! คุณถูกรางวัล";
                    lblPut2.Text = "คุณถูกรางวัล " + count02 + " ครั้ง";
                }

                if (count1 == 20)
                    btnStartSlot.Enabled = false;
            }

            if (rad60.Checked == true)
            {
                count1++;
                lblOut.Text = "คุณสุ่มครั้งที่ " + count1;
                if (ranNum1 == 1)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum1 == 2)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum1 == 3)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum1 == 4)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum1 == 5)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum1 == 6)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum1 == 7)
                    PicSlot01.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum2 == 1)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum2 == 2)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum2 == 3)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum2 == 4)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum2 == 5)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum2 == 6)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum2 == 7)
                    PicSlot02.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum3 == 1)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f01.png";
                else if (ranNum3 == 2)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f02.png";
                else if (ranNum3 == 3)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f03.png";
                else if (ranNum3 == 4)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f04.png";
                else if (ranNum3 == 5)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f05.png";
                else if (ranNum3 == 6)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f06.png";
                else if (ranNum3 == 7)
                    PicSlot03.ImageLocation = Application.StartupPath + "\\f07.png";

                if (ranNum1 != ranNum2 && ranNum1 != ranNum3)
                    lblput.Text = "เสียใจด้วย!! คุณไม่ถูกรางวัล";
                else if (ranNum1 == ranNum2 && ranNum1 == ranNum3)
                {
                    count02++;
                    lblput.Text = "ยินดีด้วย!! คุณถูกรางวัล";
                    lblPut2.Text = "คุณถูกรางวัล " + count02 + " ครั้ง";
                }

                if (count1 == 60)
                    btnStartSlot.Enabled = false;
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            btnStartSlot.Enabled = false; //บังคับให้ปุ่ม RANDOM ไม่สามารถกดได้
        }

        private void rad10_CheckedChanged(object sender, EventArgs e)
        {
            //เมื่อกดปุ่ม radioButton จะทำการรีเซ็ตค่ากล่อง lbl และตัวแปรcount ในโค้ดนี้ปุ่ม RANDOM จะสามารถใช้งานได้
            lblPut2.Text = "";
            lblput.Text = "";
            lblOut.Text = "";
            btnStartSlot.Enabled = true;
            count1 = 0;
            count02 = 0;
        }

        private void rad20_CheckedChanged(object sender, EventArgs e)
        {
            lblPut2.Text = "";
            lblput.Text = "";
            lblOut.Text = "";
            btnStartSlot.Enabled = true;
            count1 = 0;
            count02 = 0;
        }

        private void rad60_CheckedChanged(object sender, EventArgs e)
        {
            lblPut2.Text = "";
            lblput.Text = "";
            lblOut.Text = "";
            btnStartSlot.Enabled = true;
            count1 = 0;
            count02 = 0;
        }

        // 8 puzzle game

        Int32 score = 0; //สร้างตัวแปรแบบ Global เพราะต้องใช้ในหลาย Method

        public void Shuffle()
        {
            int i, j, RN;
            int[] a = new int[9];
            Boolean flag = false;
            i = 1;

            do
            {
                Random rnd = new Random();

                RN = Convert.ToInt32((rnd.Next(0, 8)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (a[j] == RN)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    a[i] = RN;
                    i = i + 1;
                }
            }
            while (i <= 8);
            btnPuzzle01.Text = Convert.ToString(a[1]);
            btnPuzzle02.Text = Convert.ToString(a[2]);
            btnPuzzle03.Text = Convert.ToString(a[3]);
            btnPuzzle04.Text = Convert.ToString(a[4]);
            btnPuzzle05.Text = Convert.ToString(a[5]);
            btnPuzzle06.Text = Convert.ToString(a[6]);
            btnPuzzle07.Text = Convert.ToString(a[7]);
            btnPuzzle08.Text = Convert.ToString(a[8]);
            btnPuzzle09.Text = "";

            //Method นี้ ในขั้นแรกจะสร้าง Array ที่มีขนาด 9 ช่องขึ้นมาก่อน จากนั้นจึงทำการสุ่มเลข 1-8 มาเก็บไว้ใช้ตัวแปรชื่อ RN แล้วใช้ for Loop ในการเช็คว่าเลขที่สุ่มได้ซ้ำกับเลขตัวอื่นหรือไม่ ถ้าสุ่มแล้วไม่ซ้ำ โปรแกรมจะนำตัวเลขที่สุ่มได้ไปใส่ใน Array และจะทำวนไปเรื่อยๆจนกว่าจะได้ตัวเลขครบทั้ง 8 ช่อง (ช่องที่ 9 เป็นช่องว่าง)
        }

        public void CheckButton(Button bttn1, Button bttn2)
        {
            if (bttn2.Text == "")
            {
                bttn2.Text = bttn1.Text;
                bttn1.Text = "";
            }
            //สร้าง Method ที่ชื่อว่า checkButton เพื่อเช็คว่ารอบๆ Button ที่ผู้เล่นกดเข้ามา มีช่องว่างหรือไม่ ถ้ามีช่องว่าง ตัวเลขจะย้ายไปอยู่ที่ตำแหน่งช่องว่างแทน
        }

        public void CheckSolved()
        {
            if (btnPuzzle01.Text == "1" && btnPuzzle02.Text == "2" && btnPuzzle03.Text == "3"
                && btnPuzzle04.Text == "4" && btnPuzzle05.Text == "5" && btnPuzzle06.Text == "6"
                && btnPuzzle07.Text == "7" && btnPuzzle08.Text == "8" && btnPuzzle09.Text == "")

            {
                score += 1;
                lblOutPuz.Text = "YOU DID IT ! Press OK to Play Again ";
                Shuffle();
            }
            if (btnPuzzle01.Text == "1" && btnPuzzle02.Text == "2" && btnPuzzle03.Text == "3"
                && btnPuzzle04.Text == "4" && btnPuzzle05.Text == "5" && btnPuzzle06.Text == "6"
                && btnPuzzle07.Text == "8" && btnPuzzle08.Text == "7" && btnPuzzle09.Text == "")

            {
                score += 1;
                lblOutPuz.Text = "NO SOLUTION ! RESHUFFLE !";
                Shuffle();
            }
            //สร้าง Method ที่ชื่อว่า CheckSolved สำหรับเช็คว่าผู้เล่นเรียงเลข 1–8 ได้ถูกต้องตามลำดับหรือยัง หากเรียงได้แล้ว ตัวแปร score จะเพิ่มค่าและโปรแกรมจะขึ้น Messagebox แจ้งเตือน และให้ผู้เล่นสุ่มเลขเพื่อเล่นอีกครั้ง
            //แต่ มีกรณีที่ไม่สามารถเรียง 1–8 ได้ตามลำดับ โปรแกรมจะขึ้น Message ว่า No Solution และทำการสุ่มตัวเลขชุดใหม่ให้ผู้เล่น
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Button 5 : Button 2 , 4, 6, 8
            CheckButton(btnPuzzle05, btnPuzzle04);
            CheckButton(btnPuzzle05, btnPuzzle02);
            CheckButton(btnPuzzle05, btnPuzzle06);
            CheckButton(btnPuzzle05, btnPuzzle08);
            CheckSolved();
        }

        private void btnPuzzle01_Click(object sender, EventArgs e)
        {
            //Button 1 : Button 2 , 4 
            CheckButton(btnPuzzle01, btnPuzzle02);
            CheckButton(btnPuzzle01, btnPuzzle04);
            CheckSolved();
        }

        private void btnPuzzle02_Click(object sender, EventArgs e)
        {
            //Button 2 : Button 1 , 3, 5
            CheckButton(btnPuzzle02, btnPuzzle01);
            CheckButton(btnPuzzle02, btnPuzzle03);
            CheckButton(btnPuzzle02, btnPuzzle05);
            CheckSolved();
        }

        private void btnPuzzle03_Click(object sender, EventArgs e)
        {
            //Button 3 : Button 2 , 6
            CheckButton(btnPuzzle03, btnPuzzle02);
            CheckButton(btnPuzzle03, btnPuzzle06);
            CheckSolved();
        }

        private void btnPuzzle04_Click(object sender, EventArgs e)
        {
            //Button 4 : Button 1 , 5, 7
            CheckButton(btnPuzzle04, btnPuzzle01);
            CheckButton(btnPuzzle04, btnPuzzle05);
            CheckButton(btnPuzzle04, btnPuzzle07);
            CheckSolved();
        }

        private void btnPuzzle06_Click(object sender, EventArgs e)
        {
            //Button 6 : Button 3 , 5, 9
            CheckButton(btnPuzzle06, btnPuzzle03);
            CheckButton(btnPuzzle06, btnPuzzle05);
            CheckButton(btnPuzzle06, btnPuzzle09);
            CheckSolved();
        }

        private void btnPuzzle07_Click(object sender, EventArgs e)
        {
            //Button 7 : Button  4, 8
            CheckButton(btnPuzzle07, btnPuzzle04);
            CheckButton(btnPuzzle07, btnPuzzle08);
            CheckSolved();
        }

        private void btnPuzzle08_Click(object sender, EventArgs e)
        {
            //Button 8 : Button  5, 7, 9
            CheckButton(btnPuzzle08, btnPuzzle05);
            CheckButton(btnPuzzle08, btnPuzzle07);
            CheckButton(btnPuzzle08, btnPuzzle09);
            CheckSolved();
        }

        private void btnPuzzle09_Click(object sender, EventArgs e)
        {
            //Button 9 : Button  6, 8
            CheckButton(btnPuzzle09, btnPuzzle08);
            CheckButton(btnPuzzle09, btnPuzzle06);
            CheckSolved();
            //เรียกใช้ Method CheckButton และ CheckSolved โดย Method CheckButton ต้องใส่ Paramiter ตัวแรกเป็นตัวที่ผู้เล่นกด ตัวที่สองเป็นตัวรอบข้าง
        }

        private void btnStartPuzzle_Click(object sender, EventArgs e)
        {
            Shuffle();
            //เรียกใช้ Method Shuffle เพื่อสุ่มตัวเลขชุดใหม่สำหรับเล่นอีกครั้ง
        }


        // Rock Paper Scissoors Game


        int humNum; //สร้างตัวแปร humNum ไว้สำหรับการเปรียบเทียบตัวแปร แล้วนำไปใส่ในปุ่ม btn (Rock Paper Scissors) พร้อมทั้งกำหนดเลขให้ไม่ซ้ำกัน 

        private void btmRock_Click(object sender, EventArgs e)
        {

            pictureBoxHu.ImageLocation = Application.StartupPath + "\\rock.png";
            btnStartRo.Enabled = true;
            humNum = 0;
            count01 = 0;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            pictureBoxHu.ImageLocation = Application.StartupPath + "\\Paper.png";
            btnStartRo.Enabled = true;
            humNum = 1;
            count01 = 0;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            pictureBoxHu.ImageLocation = Application.StartupPath + "\\Scissors.png";
            btnStartRo.Enabled = true;
            humNum = 2;
            count01 = 0;
        }
        //กำหนดค่าให้ปุ่ม START ไม่สามารถกดได้ให้ไม่กดปุ่ม ROCK PAPER SCISSORS ปุ่มใดปุ่มหนึ่งก่อน

        int count01 = 0;
        private void btnStartRo_Click(object sender, EventArgs e)
        {
            //กำหนดตัวแปรสำหรับการสุ่ม โดยใช้ Random
            Random rand = new Random();
            int randNum = rand.Next(0, 3);
            int comNum = 0;
            string Resultstr = "";
            comNum = randNum;


            count01++;
            if (count01 == 1)
            {
                btnStartRo.Enabled = false;
            }

            //com hum == 0 คือ rock 
            //com hum == 1 คือ paper
            //com hum == 2 คือ scissors
            //หากผู้เล่นกดปุ่มใดปุ่มหนึ่ง (Rock Paper Scissoors) จะทำการตรวจสอบกับสิ่งที่ computer สุ่มออกมา และแสดงค่าใน lbl ตามที่กำหนดไว้ในตัวแปร Resultstr
            if ((comNum == 0) && (humNum == 0))
            {
                Resultstr = "It's tie.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            else if ((comNum == 0) && (humNum == 1))
            {
                Resultstr = "You Win.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            else if ((comNum == 0) && (humNum == 2))
            {
                Resultstr = "You lose.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }
            else if ((comNum == 1) && (humNum == 0))
            {
                Resultstr = "You lose.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            else if ((comNum == 1) && (humNum == 1))
            {
                Resultstr = "It's tie.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            else if ((comNum == 1) && (humNum == 2))
            {
                Resultstr = "You Win.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            else if ((comNum == 2) && (humNum == 0))
            {
                Resultstr = "You Win.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            else if ((comNum == 2) && (humNum == 1))
            {
                Resultstr = "You lose.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            else if ((comNum == 2) && (humNum == 2))
            {
                Resultstr = "It's tie.!";
                count01++;
                if (count01 == 1)
                {
                    btnStartRo.Enabled = false;

                }
            }

            btnClear.Enabled = true;

            //แสดงรูปภาพของ com choice
            if (comNum == 0)
            {
                pictureBoxCom.ImageLocation = Application.StartupPath + "\\rock.png";
            }

            else if (comNum == 1)
            {
                pictureBoxCom.ImageLocation = Application.StartupPath + "\\Paper.png";
            }

            else if (comNum == 0)
            {
                pictureBoxCom.ImageLocation = Application.StartupPath + "\\Scissors.png";
            }

            lblResult.Text = Resultstr;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            btnStartRo.Enabled = false;
            btnClear.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnStartRo.Enabled = false;
            lblResult.Text = " ";
            pictureBoxCom.Image = null;
            pictureBoxHu.Image = null;
            //เมื่อกดปุ่ม clear รูปภาพที่แสดงอยู่จะกลายเป็นรูปว่าง
        }

        //TIC TAC TOE GAME

        Player currentPlayer; // ประกาศตัวแปรประเภท Player (ซึ่งเก็บข้อมูล X หรือ O)
        List<Button> buttons; // ประกาศตัวแปรเป็น List ของปุ่ม (Button) ที่จะเก็บปุ่มในเกม
        Random rand = new Random(); // ประกาศตัวแปร Random เพื่อใช้ในการสุ่มเลือกปุ่มสำหรับคอมพิวเตอร์
        int playerWins = 0; // เก็บจำนวนครั้งที่ผู้เล่นชนะ
        int computerWins = 0; // เก็บจำนวนครั้งที่คอมพิวเตอร์ชนะ

        public enum Player
        {
            X, O // กำหนดค่าของผู้เล่นเป็น X หรือ O
        }

        private void loadbuttons()
        {
            // ฟังก์ชันนี้จะโหลดปุ่มทั้งหมดจากฟอร์มไปยังรายการปุ่ม
            buttons = new List<Button> { btnR0C0 , btnR0C1 , btnR0C2 , 
                                         btnR1C0 , btnR1C1 , btnR1C2 , 
                                         btnR2C0 , btnR2C1 , btnR2C2 };
        }

        private void resetGame()
        {
            //ทำการตรวจสอบแต่ละปุ่มด้วยแท็กการเล่น
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // เปิดการใช้งานปุ่มทั้งหมด
                    ((Button)X).Text = "?"; // รีเซ็ตข้อความบนปุ่มเป็นเครื่องหมายคำถาม
                    ((Button)X).BackColor = default(Color); // รีเซ็ตสีพื้นหลังของปุ่ม
                }
                loadbuttons();
                btnR0C0.Enabled = true;
                btnR0C1.Enabled = true;
                btnR0C2.Enabled = true;
                btnR1C0.Enabled = true;
                btnR1C1.Enabled = true;
                btnR1C2.Enabled = true;
                btnR2C0.Enabled = true;
                btnR2C1.Enabled = true;
                btnR2C2.Enabled = true;
                //กำหนดให้ปุ่มทั้ง 9 ช่องสามารถกดได้เมื่อกดรีเซ็ต
            }
            // เรียกใช้ฟังก์ชันปุ่มโหลดเพื่อให้ปุ่มทั้งหมดถูกแทรกกลับเข้าไปในอาร์เรย์
        }

        private void Check()
        {
            //ในฟังก์ชันนี้เราจะตรวจสอบว่าผู้เล่นหรือ AI ชนะหรือไม่
            // เรามีข้อความ if ขนาดใหญ่มากสองข้อความพร้อมความเป็นไปได้ที่จะชนะ
            if (btnR0C0.Text == "X" && btnR0C1.Text == "X" && btnR0C2.Text == "X"
               || btnR1C0.Text == "X" && btnR1C1.Text == "X" && btnR1C2.Text == "X"
               || btnR2C0.Text == "X" && btnR2C2.Text == "X" && btnR2C1.Text == "X"
               || btnR0C0.Text == "X" && btnR1C0.Text == "X" && btnR2C0.Text == "X"
               || btnR0C1.Text == "X" && btnR1C1.Text == "X" && btnR2C1.Text == "X"
               || btnR0C2.Text == "X" && btnR1C2.Text == "X" && btnR2C2.Text == "X"
               || btnR0C0.Text == "X" && btnR1C1.Text == "X" && btnR2C2.Text == "X"
               || btnR0C2.Text == "X" && btnR1C1.Text == "X" && btnR2C0.Text == "X")
            {
                // if any of the above conditions are met เป็นไปตามเงื่อนไข  
                AImoves.Stop(); //หยุดตัวจับเวลา
                lblStatus.Text = "Player Wins"; // แสดงข้อความไปยังผู็เล่น
            }


            //ด้านล่างนี้หากเป็นคำสั่งสำหรับเวลาที่ AI ชนะเกม
            else if (btnR0C0.Text == "O" && btnR0C1.Text == "O" && btnR0C2.Text == "O"
                  || btnR1C0.Text == "O" && btnR1C1.Text == "O" && btnR1C2.Text == "O"
                  || btnR2C0.Text == "O" && btnR2C2.Text == "O" && btnR2C1.Text == "O"
                  || btnR0C0.Text == "O" && btnR1C0.Text == "O" && btnR2C0.Text == "O"
                  || btnR0C1.Text == "O" && btnR1C1.Text == "O" && btnR2C1.Text == "O"
                  || btnR0C2.Text == "O" && btnR1C2.Text == "O" && btnR2C2.Text == "O"
                  || btnR0C0.Text == "O" && btnR1C1.Text == "O" && btnR2C2.Text == "O"
                  || btnR0C2.Text == "O" && btnR1C1.Text == "O" && btnR2C0.Text == "O")
            {
                // ถ้าหากตรงตามเงื่อนไขใดๆข้างต้น เราจะดำเนินการดังต่อไปนี้
                // รหัสนี้จะทำงานเมื่อ AI ชนะเกม
                AImoves.Stop(); // stop the timer
                lblStatus.Text = " Computer Wins"; // show a message box to say computer won แสดงกล่องข้อความแจ้งว่าคอมพิวเตอร์ชนะ

            }

            btnTicStart.Enabled = true;
        }


        private void btnTicStart_Click(object sender, EventArgs e) //ไว้สำหรับเริ่มเกมใหม่
        {
            // this function is linked with the reset button ฟังก์ชั่นนี้เชื่อมโยงกับปุ่มรีเซ็ต
            // when the reset button is clicked then เมื่อคลิกปุ่มรีเซ็ตแล้ว
            // this function will run the reset game function ฟังก์ชั่นนี้จะเรียกใช้ฟังก์ชั่นรีเซ็ตเกมส์
            resetGame();
            btnR0C0.Text = "";
            btnR0C1.Text = "";
            btnR0C2.Text = "";
            btnR1C0.Text = "";
            btnR1C1.Text = "";
            btnR1C2.Text = "";
            btnR2C0.Text = "";
            btnR2C1.Text = "";
            btnR2C2.Text = "";
            lblStatus.Text = " ";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // find which button was clicked ค้นหาว่าปุ่มไหนถูกคลิก
            currentPlayer = Player.X; // set the player to X ตั้งค่าเครื่องเล่นเป็น X
            button.Text = currentPlayer.ToString(); // change the button text to player X เปลี่ยนข้อความปุ่มเป็นผู้เล่น X
            button.Enabled = false; // disable the button ปิดการใช้งานปุ่ม
            buttons.Remove(button); //remove the button from the list buttons so the AI can't click it either ลบปุ่มออกจากปุ่มรายการเพื่อให้ AI ไม่สามารถคลิกได้เช่นกัน
            Check(); // check if the player won ตรวจสอบว่าผู้เล่นชนะหรือไม่
            AImoves.Start(); // start the AI timer เริ่มจับเวลา AI
        }

        private void AImove(object sender, EventArgs e)
        {
            // THE CPU will randomly choose a button from the list to click. CPU จะสุ่มเลือกปุ่มจากรายการที่จะคลิก
            // While the array is greater than 0 the cpu will operate in the game แม้ว่าอาเรย์จะมากกว่า 0 แต่ cpu จะทำงานในเกม
            // if the array is less than 0 it will stop playing หากอาร์เรย์น้อยกว่า 0 ก็จะหยุดเล่น
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); // generate a random number within the number of buttons available สร้างตัวเลขสุ่มภายในจำนวนปุ่มที่มีอยู่
                buttons[index].Enabled = false; // assign the number to the button กำหนดหมายเลขให้กับปุ่ม
                // when the random number is generated then we will look into the list เมื่อสร้างตัวเลขสุ่มแล้วเราจะตรวจสอบรายการ
                // for what that number is we select that button เราเลือกปุ่มนั้นว่าหมายเลขอะไร
                // for example if the number is 8 เช่น ถ้าตัวเลขคือ 8
                // then we select the 8th button in the list จากนั้นเราเลือกปุ่มที่ 8 ในรายการ
                currentPlayer = Player.O; // set the  AI with O ตั้งค่า AI ด้วย O
                buttons[index].Text = currentPlayer.ToString(); // show O on the button แสดง O บนปุ่ม
                buttons.RemoveAt(index); // remove that button from the list ลบปุ่มนั้นออกจากรายการ
                AImoves.Stop(); // stop the AI timer
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
