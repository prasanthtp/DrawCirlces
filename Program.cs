using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace delete21
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(@"C:\delete\Liner.png");//  Convert.ToInt32(1024), Convert.ToInt32(1024), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap); 
            
            var myPen = new Pen(Color.Black, 2);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            SolidBrush brush = new SolidBrush(Color.Blue);
           

            int radius = 5;
            int centerX = bitmap.Width/2;
            int centerY = bitmap.Height / 2; 


            for (int i=0; i<1;  i++)
            {
                g.FillCircle(brush, centerX+i, centerY+i, radius);
            }




            g.FillCircle(brush, centerX, centerY, radius);
            g.DrawCircle(myPen, centerX, centerY, radius);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawCircle(myPen, centerX, centerY, radius - 20);
            g.DrawCircle(myPen, centerX, centerY, radius - 40);
            g.DrawCircle(myPen, centerX, centerY, radius - 60);
            g.DrawCircle(myPen, centerX, centerY, radius - 80);


            g.FillCircle(brush, centerX + 2 * centerX, centerY, radius);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.DrawCircle(myPen, centerX + 2 * centerX, centerY, radius);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawCircle(myPen, centerX + 2 * centerX, centerY, radius - 20);
            g.DrawCircle(myPen, centerX + 2 * centerX, centerY, radius - 40);
            g.DrawCircle(myPen, centerX + 2 * centerX, centerY, radius - 60);
            g.DrawCircle(myPen, centerX + 2 * centerX, centerY, radius - 80);

            g.FillCircle(brush, 200, 200 + 500, radius);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.DrawCircle(myPen, 200, 200 + 500, radius);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawCircle(myPen, 200, 200 + 500, radius - 20);
            g.DrawCircle(myPen, 200, 200 + 500, radius - 40);
            g.DrawCircle(myPen, 200, 200 + 500, radius - 60);
            g.DrawCircle(myPen, 200, 200 + 500, radius - 80);


            g.FillCircle(brush, 200 + 500, 200 + 500, radius);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.DrawCircle(myPen, 200 + 500, 200 + 500, radius);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawCircle(myPen, 200 + 500, 200 + 500, radius - 20);
            g.DrawCircle(myPen, 200 + 500, 200 + 500, radius - 40);
            g.DrawCircle(myPen, 200 + 500, 200 + 500, radius - 60);
            g.DrawCircle(myPen, 200 + 500, 200 + 500, radius - 80);


            bitmap.Save(@"C:\delete\test.png", ImageFormat.Png);


        }

       
    }


    public static class GraphicsExtensions
    {
        public static void DrawCircle(this Graphics g, Pen pen,
                                      float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        public static void FillCircle(this Graphics g, Brush brush,
                                      float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
    }

}
