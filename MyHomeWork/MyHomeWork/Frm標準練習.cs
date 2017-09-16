using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class CSharp標準練習 : Form
    {
        public CSharp標準練習()
        {
            InitializeComponent();
        }

        private void Frm標準練習_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 99;
            b = 77;
            c = 55;
            int maxNum = Math.Max(Math.Max(a, b), c);
            string varString = Convert.ToString(maxNum);
            lblResult.Text = varString;
            //if (a > b && a > c)
            //{
            //    if (b > c)
            //    {
            //        lblResult.Text = a + ">" + b + ">" + c;
            //    }
            //    else
            //    {
            //        lblResult.Text = a + ">" + c + ">" + b;
            //    }
            //}
            //else if (b > a && b > c)
            //{
            //    if (a > c)
            //    {
            //        lblResult.Text = b + ">" + a + ">" + c;
            //    }
            //    else
            //    {
            //        lblResult.Text = b + ">" + c + ">" + a;
            //    }
            //}
            //else if (c > a && c > b)
            //{
            //    if (a > b)
            //    {
            //        lblResult.Text = c + ">" + a + ">" + b;
            //    }
            //    else
            //    {
            //        lblResult.Text = c + ">" + b + ">" + a;
            //    }
            //}

        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblResult.Text =" {aaa, bbbbbb, cc }\n\n";
            string[] names = { "aaa", "bbbbbb", "cc" };
            int x = 0;  //紀錄陣列元素的位置
            int y = 0;  //元素字串的長度
            for (int i = 0; i < names.Length; i++)//陣列.Length    代表是陣列的總數
            {
                if (names[i].Length > y)   //陣列元素.Length    代表陣列中字元的數目
                {
                    x = i;
                    y = names[i].Length; 
                }
            }
            lblResult.Text += names[x] + "是最長的名子";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] strArray = { "aaa", "bbbbbb", "Cc", "cat", "chocolate", "client", "Coco" };
            lblResult.Text =""+ "{ aaa, bbbbbb, Cc, cat, chocolate, client, Coco }\n\n";
            string findThisString = "C"; //要找的字
            string find = "c";
            int strNumber = 0;  //判別c
            int strIndex = 0;   //判別C
            int a = 0;   //有C的數量
            int b = 0;   //有c的數量
            for (int x = 0; x < strArray.Length; x++)
            {
                strIndex = strArray[x].IndexOf(findThisString);//IndexOf如果傳回值是-1   代表字串沒有要找的
                if (strIndex >= 0)
                {
                    a++;
                }
            }
            for (int x = 0; x < strArray.Length; x++)
            {
                strNumber = strArray[x].IndexOf(find); ;
                if (strNumber >= 0)
                {
                    b++;
                }
            }
            lblResult.Text+= "含C有" + a + "個\n";
            lblResult.Text += "含c有" + b + "個\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string i = textBox4.Text;  //從textBox4取的字串值
            int x;  //存變整數的值
            bool y;  //真
            y = int.TryParse(i, out x);
            if (x % 2 == 0)
            {
                lblResult.Text = "偶數";    //lblResult.Text  在結過那輸出
            }
            else
            {
                lblResult.Text = "奇數";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int j = 100;
            ArrayList z = new ArrayList(); 
            for (int i = j % 2; j != 0; i = j % 2)  //i=餘數     j=商     //只要j商不等於0就一直執行 i = j % 2
            {
                j = j / 2;
                z.Add(i);
            }
            for (int i = z.Count - 1; i >= 0; i--)//z.Count=z陣列的總數=7
            {
                lblResult.Text += z[i];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 11, 33, 44, 99, 100, 2 };
            lblResult.Text = " int[] nums = { 11, 33, 44, 99, 100, 2 }" + "\n\n";
            int j = 0;   //  奇數
            int k = 0;  //  偶數
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    k++;
                else
                    j++;
            }
            lblResult.Text += "奇數有" + j + "個\n\n偶數有" + k + "個";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] i = new int[10] { 52, 23, 523, 5, 235, 35, 53, 25, 530, 315 };
            lblResult.Text = " int[] i = new int[10] { 52, 23, 523, 5, 235, 35, 53, 25, 530, 315 }" + "\n";
            Array.Sort(i);
            Array.Reverse(i);  //陣列由大排到小
            lblResult.Text += "最大值為" + i[0];
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int a, b, c;
            for (a = 1; a <= 9; a++)
            {
                for (b = 1; b <= 9; b++)
                {
                    c = a * b;
                    lblResult.Text += a + "*" + b + "=";
                    if (c < 10)
                    {
                        lblResult.Text += " ";
                    }
                    lblResult.Text += c + "   ";
                }
                lblResult.Text +="\n";
                lblResult.Text += "\n";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int x, y, z;bool t;
            string a = textBox1.Text;   //from  x   
            string b = textBox2.Text;   //to   y
            string c = textBox3.Text;   //step  z
            t = int.TryParse(a, out x);
            t = int.TryParse(b, out y);
            t = int.TryParse(c, out z);
            int sum=0;
            for (x = x; x <= y; x = x + z)
            {
                sum = sum + x;
                
            }
            lblResult.Text = "總和為 " + sum;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x, y, z; bool t;
            string a = textBox1.Text;   //from  x   
            string b = textBox2.Text;   //to   y
            string c = textBox3.Text;   //step  z
            t = int.TryParse(a, out x);
            t = int.TryParse(b, out y);
            t = int.TryParse(c, out z);
            int sum = 0;
            while (x <= y)
            {
                sum = sum + x;
                x = x + z;
            }
            lblResult.Text = "總和為 " + sum;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x, y, z; bool t;
            string a = textBox1.Text;   //from  x   
            string b = textBox2.Text;   //to   y
            string c = textBox3.Text;   //step  z
            t = int.TryParse(a, out x);
            t = int.TryParse(b, out y);
            t = int.TryParse(c, out z);
            int sum = 0;
            do
            {
                sum = sum + x;
                x = x + z;
            } while (x <= y);
            lblResult.Text = "總和為 " + sum;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
           string a = textBox5.Text;
            int xyz;  // 輸入的行數
            bool t;
            t = int.TryParse(a, out xyz);
            int n;//行的初值
            int y;  // *
            for (n = 1; n<= xyz; n =n + 1)
            {
                for (y = 1; y <= n; y = y + 1)
                {
                    lblResult.Text += "*";
                }
                lblResult.Text += "\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] i = new int[2] { 5, 23 };    //i陣列原本順序為{ 5, 23 }
            lblResult.Text = "原本為  " + i[0] + " , " + i[1];
            lblResult.Text += "\n";
            for (int j = 0; j < i.Length - 1; j++)
            {
                int k;
                k = i[j];
                i[j] = i[j + 1];
                i[j + 1] = k;
            }
            lblResult.Text += "交換後為 " + i[0] + " , " + i[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] i = new int[10] { 52, 23, 523, 5, 235, 35, 53, 25, 530, 315 };
            lblResult.Text = " int[] i = new int[10] { 52, 23, 523, 5, 235, 35, 53, 25, 530, 315 }" + "\n";
            int sum = 0;   //總和
            for (int j = 0; j < i.Length; j++)  // i.Length 陣列的總數
            {
                sum = sum + i[j];
            }
            lblResult.Text +=  "陣列總和為 " + sum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] i = new int[10] { 52, 23, 523, 5, 235, 35, 53, 25, 530, 315 };
            lblResult.Text = " int[] i = new int[10] { 52, 23, 523, 5, 235, 35, 53, 25, 530, 315 }" + "\n";
            Array.Sort(i);  //陣列由小排到大
            lblResult.Text +="最小值為"+ i[0];
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = ""+"大樂透自動選號\n";
            int[] loto = new int[49]; //將所有號碼(1~49)放入陣列loto中
            for (int i = 0; i <= 48; i++)
            {
                loto[i] = i + 1;
            }
            int[] x = new int[6]; //宣告要取多少個數字
            Random r = new Random();
            for (int j = 0; j <= 5; j++)
            {
                int temp = r.Next(1, 49); //隨機抓取一組數字放入x[]陣列中
                if (loto[temp] == 0)//如果數字為0，則重新產生亂數
                { j--; }
                else
                {
                    x[j] = loto[temp]; //否則將亂數產生之數字放入x[]陣列中

                    loto[temp] = 0; //將以使用之數字以零取代

                    lblResult.Text += "  " + x[j];
                }
            }
            lblResult.Text +="\n";
            lblResult.Text += "------------------------------------------------------"+ "\n";
            lblResult.Text += "排序後的結果:" + "\n";
            Array.Sort(x);
            for (int k = 0; k < 6; k++)
            {
                lblResult.Text += "  " + x[k];
            }
            lblResult.Text += "\n";
            lblResult.Text += "------------------------------------------------------" + "\n";
        }
    }
    
}
