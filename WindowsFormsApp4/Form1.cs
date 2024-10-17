using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        int[] squareCoords = { 0, 0, 0, 0 };

        bool threadStopped = false;
        int totalPoints = 0;
        int totalIn = 0;

        int[] sqTL = { 350, 250 };
        int[] sqTR = { 550, 250 };
        int[] sqBL = { 350, 450 };
        int[] sqBR = { 550, 450 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrawPoints_Click(object sender, EventArgs e)
        {
            drawMainArea(350, 250, 750, 650);
            Thread tl = new Thread(() => paintTLArea(100, 100, 300, 300));
            Thread tr = new Thread(() => paintTRArea(800, 100, 1000, 300));
            Thread bl = new Thread(() => paintBLArea(100, 600, 300, 800));
            Thread br = new Thread(() => paintBRArea(800, 600, 1000, 800));
            Thread totalArea = new Thread(updateLabelArea);
            tl.Start();
            tr.Start();
            bl.Start();
            br.Start();
            totalArea.Start();
        }

        private void updateLabelArea()
        {
            while (!threadStopped)
            {
                double result = (double)totalIn / (double)totalPoints;
                lblTotalArea.Invoke((MethodInvoker)delegate
                {
                    lblTotalArea.Text = $"{String.Format("{0:0.0000}", result)}";

                });

            }
        }

        private void drawRectangleLines(int pointX, int pointY, int[] borders, Graphics g)
        {
            g.DrawLine(new Pen(Color.White, 1), pointX, pointY, borders[0], borders[1]);
            g.DrawLine(new Pen(Color.White, 1), pointX, pointY, borders[2], borders[3]);
        }


        private void paintTLArea(int x1, int y1, int x2, int y2)
        {
            Graphics g = this.CreateGraphics();
            int pointX = squareCoords[0] + x1;
            int pointY = squareCoords[1] + y1;
            int[] borders = { pointX, y2, x2, pointY };
            drawRectangleLines(pointX, pointY, borders, g);
            graphicsPaint(x1, y1, x2, y2, Brushes.White, g, sqTL, lblTL);
        }
        private void paintTRArea(int x1, int y1, int x2, int y2)
        {
            Graphics g = this.CreateGraphics();
            int pointX = squareCoords[0] + squareCoords[2] - 200 + x1;
            int pointY = squareCoords[1] + y1;
            int[] borders = { x1, pointY, pointX, y2 };
            drawRectangleLines(pointX, pointY, borders, g);
            graphicsPaint(x1, y1, x2, y2, Brushes.Orange, g, sqTR, lblTR);
        }
        private void paintBLArea(int x1, int y1, int x2, int y2)
        {
            Graphics g = this.CreateGraphics();
            int pointX = squareCoords[0] + x1;
            int pointY = squareCoords[1] + squareCoords[3] - 200 + y1;
            int[] borders = { pointX, y1, x2, pointY };
            drawRectangleLines(pointX, pointY, borders, g);
            graphicsPaint(x1, y1, x2, y2, Brushes.Cyan, g, sqBL, lblBL);
        }
        private void paintBRArea(int x1, int y1, int x2, int y2)
        {
            Graphics g = this.CreateGraphics();
            int pointX = squareCoords[0] + squareCoords[2] - 200 + x1;
            int pointY = squareCoords[1] + squareCoords[3] - 200 + y1;
            int[] borders = { pointX, y1, x1, pointY };
            drawRectangleLines(pointX, pointY, borders, g);
            graphicsPaint(x1, y1, x2, y2, Brushes.Pink, g, sqBR, lblBR);
        }


        private void drawMainArea(int x1, int y1, int x2, int y2)
        {
            Graphics g = this.CreateGraphics();
            int width = x2 - x1;
            int height = y2 - y1;
            // Draw Rectangle
            var rand = new Random();
            int recX = rand.Next(x1, x1 + width / 2);
            int recY = rand.Next(y1, y1 + height / 2);
            int recWidth = rand.Next(width / 2 - (recX - x1), x2 - recX);
            int recHeight = rand.Next(height / 2 - (recY - y1), y2 - recY);
            squareCoords.SetValue(recX - x1, 0);
            squareCoords.SetValue(recY - y1, 1);
            squareCoords.SetValue(recWidth, 2);
            squareCoords.SetValue(recHeight, 3);

            Pen blackPen = new Pen(Color.White, 1);
            g.DrawRectangle(blackPen, recX, recY, recWidth, recHeight);

            // Draw middle lines
            Pen bluePen = new Pen(Color.White, 1);
            g.DrawLine(bluePen, x1 + (width / 2), y1, x1 + (width / 2), y2);
            g.DrawLine(bluePen, x1, y1 + (height / 2), x2, y1 + (height / 2));
        }

        private void graphicsPaint(int x1, int y1, int x2, int y2, Brush brush, Graphics g, int[] sq, Label lbl)
        {
            var rand = new Random();
            int pointCount;
            int pointsIn = 0;
            int i = 0;
            if (Int32.TryParse(txtPointCount.Text, out pointCount))
            {

                while (i < pointCount)
                {
                    totalPoints++;
                    i++;
                    int x = rand.Next(x1, x2);
                    int y = rand.Next(y1, y2);
                    g.FillRectangle(brush, x, y, 1, 1);

                    int squareX = sq[0] + (x - x1);
                    int squareY = sq[1] + (y - y1);
                    g.FillRectangle(brush, squareX, squareY, 1, 1);

                    if (squareCoords[2] + squareCoords[0] + 350 > squareX && squareX > 350 + squareCoords[0] &&
                        squareCoords[3] + squareCoords[1] + 250 > squareY && squareY > 250 + squareCoords[1])
                    {
                        lock ((object)totalIn)
                        {
                            totalIn++;
                        }
                        pointsIn++;
                        double result = (double)pointsIn / (double)i;
                        lbl.Invoke((MethodInvoker)delegate
                        {
                            lbl.Text = $"{String.Format("{0:0.0000}", result)}";
                        });
                    }
                    Thread.Sleep(10);
                }
                threadStopped = true;
            }
        }
    }
}
