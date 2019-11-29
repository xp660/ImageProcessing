using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        ImageForm CurrentImage = null;
        public Form1()
        {
            InitializeComponent();
        }

        // Load 按鈕事件處理函式
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory= @"C:\Users\xp660\Desktop";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageForm MyImage = new ImageForm(openFileDialog1.FileName); // 建立秀圖物件
                MyImage.Show(); // 顯示秀圖照片
                CurrentImage = MyImage;
            }
        }

        // 一般處理方式: 灰階化範例
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // 高效率影像處理 --  反轉顏色範例
        private void button3_Click(object sender, EventArgs e)
        {

        }

        // 高效率影像處理 --  紅色濾鏡範例
        private void button4_Click(object sender, EventArgs e)
        {

        }

        // 高效率影像處理 --  綠色濾鏡範例
        private void button5_Click(object sender, EventArgs e)
        {

        }

        // 高效率影像處理範例 --  藍色濾鏡範例
        private void button6_Click(object sender, EventArgs e)
        {

        }

        // 高效率影像處理範例 --  增加亮度
        private void button7_Click(object sender, EventArgs e)
        {

        }

       
    }



}
