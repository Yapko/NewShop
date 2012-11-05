using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Models
{
    /// <summary>
    /// Class to store line and it color
    /// </summary>
    public class Line
    {
        /// <summary>
        /// Gets or sets begin of line
        /// </summary>
        public Point X { get; set; }

        /// <summary>
        /// Gets or sets end of line
        /// </summary>
        public Point Y { get; set; }

        /// <summary>
        /// Gets or sets a color of line
        /// </summary>
        public Color Cl { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class.
        /// </summary>
        public Line()
        {
            X = new Point();
            Y = new Point();
            Cl = new Color();
        }
    }

    /// <summary>
    /// Class for generating and draw captcha
    /// </summary>
    public class Captcha
    {
        /// <summary>
        /// Panel to paint image with captcha
        /// </summary>
        private Panel pnl;

        /// <summary>
        /// Randomly generated text of captcha
        /// </summary>
        private StringBuilder txt;

        /// <summary>
        /// List of Fonts to draw captcha
        /// </summary>
        private List<Font> fonts = new List<Font>();

        /// <summary>
        /// List of brushes for drawing lines
        /// </summary>
        private List<SolidBrush> brushes = new List<SolidBrush>();

        /// <summary>
        /// list of lines to make image noise
        /// </summary>
        private List<Line> lines = new List<Line>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Captcha"/> class.
        /// </summary>
        /// <param name="panel">gets panel to represent captcha</param>
        public Captcha(Panel panel)
        {
            pnl = panel;
            txt = new StringBuilder();
        }

        /// <summary>
        /// Method  to generate captcha.
        /// </summary>
        public void MakeCaptcha()
        {
            string[] fontNames = new string[]
            {
                "Comic Sans MS",
                "Arial",
                "Times New Roman",
                "Georgia",
                "Verdana",
                "Geneva"
            };
            FontStyle[] fontStyles = new FontStyle[]
            {  
                FontStyle.Bold,
                FontStyle.Italic,
                FontStyle.Regular,
            };

            txt.Clear();
            fonts.Clear();
            brushes.Clear();
            lines.Clear();
            Random rand = new Random();
            int rnd;

            // chars [48 - 122]
            for (int i = 0; i < 8; ++i)
            {
                rnd = rand.Next(48, 122);
                if ((rnd >= 91 && rnd <= 96) || (rnd >= 58 && rnd <= 64))
                {
                    --i;
                    continue;
                }

                this.txt.Append((char)rnd);
                this.fonts.Add(new Font(fontNames[rand.Next(fontNames.Count())], (float)rand.Next(20, 25), fontStyles[rand.Next(fontStyles.Count())]));
                this.brushes.Add(new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))));
            }

            Line toPush;
            for (int i = 0; i < 10; ++i)
            {
                toPush = new Line();
                toPush.Cl = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                toPush.X = new Point(rand.Next(pnl.Width), rand.Next(pnl.Height));
                toPush.Y = new Point(rand.Next(pnl.Width), rand.Next(pnl.Height));
                lines.Add(toPush);
            }
        }

        /// <summary>
        /// shows captcha
        /// </summary>
        public void ShowCaptcha()
        {
            Graphics grf = this.pnl.CreateGraphics();
            Pen pn = new Pen(Color.Red);
            grf.Clear(Color.White);
            for (int i = 0; i < 8; ++i)
            {
                grf.DrawString(txt[i].ToString(), fonts[i], brushes[i], new PointF(3 + i * (pnl.Width / 10), 10));
            }

            Random rand = new Random();
            for (int i = 0; i < 10; ++i)
            {
                pn.Color = lines[i].Cl;
                grf.DrawLine(pn, lines[i].X, lines[i].Y);
            }
        }

        /// <summary>
        /// password validating
        /// </summary>
        /// <param name="text">text of password</param>
        /// <returns>if text is valid</returns>
        public bool Validate(string text)
        {
            if (text.ToString().Equals(txt.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  refresh captcha image.
        /// </summary>
        public void Refresh()
        {
            MakeCaptcha();
            ShowCaptcha();
        }
    }
}
