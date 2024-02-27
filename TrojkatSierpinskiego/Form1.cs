using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrojkatSierpinskiego
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// variables needed for the program to work: number of triangle layers, offset from application bounds 
        /// </summary>
        int layers;
        int offset;
        SolidBrush whiteBrush;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            layers = 0;
            offset = 80;
            whiteBrush = new SolidBrush(Color.White);
        }

        /// <summary>
        /// Starts the whole process of drawing
        /// </summary>
        /// <remarks>
        /// based on numericUpDown1 having the number of white triangles and SufferSize having the length of one 
        /// side of the triangle drawing a big black triangle first for the background and then the white 
        /// triangles 3^[layers] times where each layer is 4 times smaller than the other
        /// </remarks>
        private void Suffer(object sender, EventArgs e)
        {
            //reloads the objects so it has a good enough size and clears it from everything
            g = this.CreateGraphics();
            g.Clear(BackColor);
            if (Controls.ContainsKey("Hi"))
                Controls.RemoveByKey("Hi");

            //gets the required information for the suffering triangles
            layers = Convert.ToInt32(numericUpDown1.Value);
            int height = EstimateHeight(Convert.ToInt32(SufferSize.Value));
            int width = Convert.ToInt32(SufferSize.Value);
            
            //Create the big black triangle
            Point[] points = new Point[3];
            points[0] = new Point(width / 2, offset);
            points[1] = new Point(width, height + offset);
            points[2] = new Point(0,height + offset);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.FillPolygon(blackBrush, points);

            //Create the white triangles [layers] times
            if (layers == 0) return;
            CreateWhiteOnes(width, height, new Point(), 0);

            if (width == 1000 && layers == 10)
            {
                Label Hi = new Label()
                {
                    Text = "Hello World",
                    Font = new Font("Microsoft Sans Serif", 20f),
                    Location = new Point(430, 600),
                    AutoSize = true,
                    TabIndex = 10,
                    BackColor = Color.White,
                    Name = "Hi",
                };

                Controls.Add(Hi);
            }
        }

        /// <summary>
        /// drawing white triangles in recursion
        /// </summary>
        /// <param name="width">width of the drawn triangle</param>
        /// <param name="height">height of the drawn triangle</param>
        /// <param name="start"> the most right-bottom point</param>
        /// <param name="it"> number of iteration</param>
        /// <remarks>
        /// draws an upside down white triangle in the center of the black triangle in its background
        /// then if it doesnt go beyond the iteration it creates its clones it recreates itself 3 times while positioning the clones so that
        /// they have their own black triangle background
        /// </remarks>
        private void CreateWhiteOnes(int width, int height, Point start, int it)
        {
            int quaterWidth = width / 4;
            int halfHeight = height / 2;

            //the points of the drawn triangle calculated first 1/4 width, 1/2 height
            //second 3/4 width, 1/2 height and third 1/2 width and full height (everything + offsets)
            Point[] points = new Point[3] {
                new Point(quaterWidth + start.X, halfHeight + offset + start.Y),
                new Point(width - quaterWidth + start.X, halfHeight + offset + start.Y),
                new Point(width / 2 + start.X, height + offset + start.Y)
                };
            g.FillPolygon(whiteBrush, points);

            //checking if it didnt pass the limit if not continue
            if (++it == layers || height < 7) return;

            CreateWhiteOnes(width / 2, halfHeight, new Point(start.X + quaterWidth, start.Y), it);
            CreateWhiteOnes(width / 2, halfHeight, new Point(start.X, start.Y + halfHeight), it);
            CreateWhiteOnes(width / 2, halfHeight, new Point(start.X + width / 2, start.Y + halfHeight), it);
        }

        //clears the board
        private void Clear_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(BackColor);

            if (Controls.ContainsKey("Hi"))
                Controls.RemoveByKey("Hi");
        }

        //estimate height for the equilateral triangle
        private int EstimateHeight(int side)
        {
            return Convert.ToInt32(side * Math.Sqrt(3) / 2);
        }
    }
}