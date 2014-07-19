namespace DoubleColor.Redballs.Handler
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Summary description for VerifyCodeHandler
    /// </summary>
    public class VerifyCodeHandler
    {

        public string GetVerifyCodeImage(HttpContext context)
        {
            int width, height;

            if (!int.TryParse(context.Request.QueryString["width"], out width))
            {
                width = 70;
            }

            if (!int.TryParse(context.Request.QueryString["height"], out height))
            {
                height = 35;
            }

            return DrawImage(context, width, height);
        }

        private string DrawImage(HttpContext context, int width, int height)
        {
            string verifyCode = this.RndNum(4);
            context.Session["CheckCode"] = verifyCode;
            return this.CreateImages(verifyCode, width, height);
        }

        private string CreateImages(string checkCode, int width, int height)
        {
            //int iwidth = (int)(checkCode.Length * 13);
            System.Drawing.Bitmap image = new System.Drawing.Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);

            Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };

            string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                int x = rand.Next(image.Width);
                int y = rand.Next(image.Height);
                g.DrawRectangle(new Pen(Color.LightGray, 0), x, y, 1, 1);
            }

            for (int i = 0; i < checkCode.Length; i++)
            {
                int cindex = rand.Next(7);
                int findex = rand.Next(5);

                Font f = new System.Drawing.Font(font[findex], 16, System.Drawing.FontStyle.Bold);
                Brush b = new System.Drawing.SolidBrush(c[cindex]);
                int ii = 4;
                if ((i + 1) % 2 == 0)
                {
                    ii = 2;
                }
                g.DrawString(checkCode.Substring(i, 1), f, b, 3 + (i * 12), ii);
            }

            g.DrawRectangle(new Pen(Color.Black, 0), 0, 0, image.Width - 1, image.Height - 1);

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var base64Image = Convert.ToBase64String(ms.ToArray());
            return "data:image/jpeg;base64," + base64Image;
        }

        private string RndNum(int VcodeNum)
        {
            string Vchar = "0,1,2,3,4,5,6,7,8,9";
            string[] VcArray = Vchar.Split(',');
            string VNum = "";
            int temp = -1;

            Random rand = new Random();
            for (int i = 1; i < VcodeNum + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(VcArray.Length);
                if (temp != -1 && temp == t)
                {
                    return RndNum(VcodeNum);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;
        }
    }
}