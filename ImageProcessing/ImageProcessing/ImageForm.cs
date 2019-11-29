using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; // for ImageFormat

namespace ImageProcessing
{
    public class ImageForm : Form
    {
        Image image;

        // 預設建構子建構子
        public ImageForm()
        {
            // Step 1: 載入影像  
            LoadImage("空中花園.jpg");
        }

        public ImageForm(String FileName)
        {
            LoadImage(FileName);
        }

        public void LoadImage(String FileName)
        {
            // Step 1: 載入影像 
            image = Image.FromFile(FileName);
            this.Text = FileName;

            // Step 2: 調整視窗的大小
            this.Height = image.Height;
            this.Width = image.Width;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            // Step 3: 顯示出影像
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            //int cx = ClientSize.Width;
            //int cy = ClientSize.Height;

            /*
            // 放大 2 倍
            this.Height = image.Height * 2;
            this.Width = image.Width * 2;

            e.Graphics.DrawImage(image, new Point[] { new Point(0, 0) ,
                                        new Point(2*image.Width, 0),
                                        new Point(0, 2*image.Height) });
            */
            /*
            // 縮小 1/2 倍            
            e.Graphics.DrawImage(image, new Point[] { new Point(0, 0) ,
                                        new Point(image.Width/2, 0),
                                        new Point(0, image.Height/2) });
             */

            /*
            // 形變旋轉
            e.Graphics.DrawImage(image, new Point[] { new Point(cx/2, 0) ,
                                        new Point(cx, cy/2),
                                        new Point(0, cy/2) });
            */
            image.Save(@"C:\Users\xp660\Desktop\ImageProcessing\image.bmp", ImageFormat.Bmp);
            image.Save(@"C:\Users\xp660\Desktop\ImageProcessing\image.gif", ImageFormat.Gif);

        }

    }
}
