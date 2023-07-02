using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ai_maze_solver
{

    public partial class Form1 : Form
    {
        public class CActor
        {
            public char Name;
            public int X, Y;
            public int W, S, G;
            public int type;
            public int U, D, L, R;
            public int Draw;
            public string path;
            public int GoL, GoU, GoD, GoR;
            public int cost;
        }

        List<CActor> LActs1 = new List<CActor>();
        List<CActor> LActs3 = new List<CActor>();

        int f;
        int a = 0;
        int b = 0;
        int ct = 0;
        int ss = 0;
        int gg = 0;
        int ct2 = 0;
        int ct3 = 0;
        int ct4 = 0;
        int ct5 = 0;
        int ct21 = 0;
        int ct22 = 0;
        int ct23 = 0;
        int ct24 = 0;
        int ct25 = 0;
        int ct26 = 0;
        int ct27 = 0;
        int ct28 = 0;
        int ct30 = 0;
        int ct31 = 0;
        int ct32 = 0;
        int ct33 = 0;
        int ct34 = 0;
        int ct35 = 0;
        int ct36 = 0;
        int ct37 = 0;
        int ct38 = 0;

        Random r = new Random();


        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load1;
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.WindowState = FormWindowState.Maximized;


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < LActs3.Count; i++)
            {
                if (LActs3[i].type == 0)
                {
                    if (e.X > LActs3[i].X + 500 && e.X < LActs3[i].X + 500 + 30)
                    {
                        if (e.Y > LActs3[i].Y + 250 && e.Y < LActs3[i].Y + 250 + 30)
                        {
                            ct++;
                            if (ct == 1)
                            {
                                MessageBox.Show("start");
                                LActs3[i].S = 1;

                            }
                            if (ct == 2)
                            {
                                MessageBox.Show("goal");
                                LActs3[i].G = 1;
                                break;
                            }
                        }
                    }
                }

            }
            DrawScene(CreateGraphics());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ct == 2)
            {
                for (int i = 0; i < LActs3.Count; i++)
                {





                }

            }
            else
            {
                MessageBox.Show("Please select the Start and the Goal");
            }
            DrawScene(CreateGraphics());
            DrawScene(CreateGraphics());
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);
        }
        void DrawScene(Graphics g)
        {
            g.Clear(Color.Black);
            Pen p = new Pen(Color.GreenYellow);

            g.FillRectangle(Brushes.Black, 500, 100, 1000, 700);

            for (int i = 0; i < LActs1.Count; i++)
            {
                g.FillRectangle(Brushes.Blue, LActs1[i].X, LActs1[i].Y, 30, LActs1[i].W);

            }
            for (int i = 0; i < LActs3.Count; i++)
            {










                if (LActs3[i].type == 1 && LActs3[i].Draw == 0)
                {
                    g.FillRectangle(Brushes.White, LActs3[i].X + 500, LActs3[i].Y + 250, LActs3[i].W, LActs3[i].W);
                }
                if (LActs3[i].GoL == 1)
                {

                    if (LActs3[i].Name == 'C')
                    {

                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "EtoC")
                            {
                                LActs3[j].Draw = 1;
                            }
                            if (LActs3[j].Name == 'E')
                            {
                                ss = j;

                            }
                        }
                    }
                    if (LActs3[i].Name == 'E')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "StoE")
                            {
                                LActs3[j].Draw = 1;
                            }
                            if (LActs3[j].Name == 'S')
                            {
                                ss = j;
                            }
                        }
                    }
                    if (LActs3[i].Name == 'F')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "StoF")
                            {
                                LActs3[j].Draw = 1;
                            }
                            if (LActs3[j].Name == 'S')
                            {
                                ss = j;
                            }
                        }
                    }
                    if (LActs3[i].Name == 'B')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "CtoB")
                            {
                                LActs3[j].Draw = 1;
                            }
                            if (LActs3[j].Name == 'C')
                            {
                                ss = j;
                            }
                        }
                    }
                    if (LActs3[i].Name == 'D')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "FtoD")
                            {
                                LActs3[j].Draw = 1;
                            }
                            if (LActs3[j].Name == 'F')
                            {
                                ss = j;
                            }
                        }
                    }
                    if (LActs3[i].Name == 'Z')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "DtoZ")
                            {
                                LActs3[j].Draw = 1;
                            }
                            if (LActs3[j].Name == 'D')
                            {
                                ss = j;
                            }
                        }
                    }
                    if (LActs3[i].Name == 'A')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "CtoA")
                            {
                                LActs3[j].Draw = 1;
                            }
                            if (LActs3[j].Name == 'C')
                            {
                                ss = j;
                            }
                        }
                    }
                    if (LActs3[i].Name == 'G')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].path == "ZtoG")
                            {
                                LActs3[j].Draw = 1;
                                //MessageBox.Show("hi");
                            }
                            if (LActs3[j].Name == 'Z')
                            {
                                ss = j;
                            }
                        }
                    }



                }
                if (LActs3[i].type == 1 && LActs3[i].Draw == 1)
                {
                    g.FillRectangle(Brushes.Red, LActs3[i].X + 500, LActs3[i].Y + 250, LActs3[i].W, LActs3[i].W);
                }

                if (LActs3[i].type == 0 && LActs3[i].G == 0 && LActs3[i].S == 0)
                {
                    g.FillEllipse(Brushes.Yellow, LActs3[i].X + 500, LActs3[i].Y + 250, 30, 30);
                }
                if (LActs3[i].type == 0 && LActs3[i].G == 1)
                {
                    g.FillEllipse(Brushes.Red, LActs3[i].X + 500, LActs3[i].Y + 250, 30, 30);
                }
                if (LActs3[i].type == 0 && LActs3[i].S == 1)
                {
                    g.FillEllipse(Brushes.Green, LActs3[i].X + 500, LActs3[i].Y + 250, 30, 30);
                }




            }


        }

        private void Form1_Load1(object sender, EventArgs e)
        {

            for (int i = 0; i < 7; i++)
            {
                //S to C up
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.cost = 1;
                pnn.path = "StoC";
                LActs3.Add(pnn);
                b += 32;
            }

            {
                //Start
                CActor pnn = new CActor();
                pnn.Name = 'S';
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                pnn.S = 0;
                pnn.G = 0;
                pnn.D = 10;
                pnn.R = 3;
                pnn.U = 17;
                pnn.L = 0;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);

            }
            f = 32;
            for (int i = 0; i < 3; i++)
            {
                //S to F Down
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b + f;
                pnn.W = 30;
                pnn.type = 1;
                LActs3.Add(pnn);
                f += 32;
                pnn.path = "StoF";
            }
            f = 32;
            for (int i = 0; i < 6; i++)
            {
                // S to F right
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a + f;
                pnn.Y = Location.Y + 193 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                LActs3.Add(pnn);
                f += 32;
                pnn.path = "StoF";

            }
            {
                //F Node
                CActor pnn = new CActor();
                pnn.Name = 'F';
                pnn.X = Location.X + 293 + a;
                pnn.Y = Location.Y + 193 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                pnn.S = 0;
                pnn.G = 0;
                pnn.D = 0;
                pnn.R = 7;
                pnn.U = 0;
                pnn.L = 9;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);
                

            }
            f = 32;
            for (int i = 0; i < 7; i++)
            {
                //F to D
                CActor pnn = new CActor();
                pnn.X = Location.X + 293 + a + f;
                pnn.Y = Location.Y + 193 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                LActs3.Add(pnn);
                f += 32;
                pnn.path = "FtoD";
            }
            {
                //D Node
                CActor pnn = new CActor();
                pnn.Name = 'D';
                pnn.X = Location.X + 293 + a + f;
                pnn.Y = Location.Y + 193 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                pnn.S = 0;
                pnn.G = 0;
                pnn.D = 0;
                pnn.R = 6;
                pnn.U = 5;
                pnn.L = 7;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);

            }
            f = 32;
            for (int i = 0; i < 4; i++)
            {
                //D to Z right
                CActor pnn = new CActor();

                pnn.X = Location.X + 549 + a + f;
                pnn.Y = Location.Y + 193 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                LActs3.Add(pnn);
                f += 32;
                pnn.path = "DtoZ";
            }
            f = 32;
            for (int i = 0; i < 2; i++)

            {
                //D to Z up
                CActor pnn = new CActor();
                pnn.X = Location.X + 677 + a;
                pnn.Y = Location.Y + 193 + b - f;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                LActs3.Add(pnn);
                f += 32;
                pnn.path = "DtoZ";
            }
            {
                //Z Node
                CActor pnn = new CActor();
                pnn.Name = 'Z';
                pnn.X = Location.X + 677 + a;
                pnn.Y = Location.Y + 193 + b - f;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                pnn.S = 0;
                pnn.G = 0;
                pnn.D = 6;
                pnn.R = 2;
                pnn.U = 6;
                pnn.L = 4;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);

            }
            for (int i = 0; i < 3; i++)

            {
                //B to Z down
                CActor pnn = new CActor();
                pnn.X = Location.X + 677 + a;
                pnn.Y = Location.Y + 161 + b - f;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "BtoZ";
                LActs3.Add(pnn);
                f += 32;
            }
            for (int i = 0; i < 3; i++)

            {
                //B to Z right
                CActor pnn = new CActor();
                pnn.X = Location.X + 837 + a - f;
                pnn.Y = Location.Y + 1 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "BtoZ";
                LActs3.Add(pnn);
                f += 32;
            }
            f = 32;
            for (int i = 0; i < 2; i++)
            {
                // Z to G
                CActor pnn = new CActor();
                pnn.X = Location.X + 677 + a + f;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "ZtoG";
                LActs3.Add(pnn);
                f += 32;
            }
            f = 32;
            {
                //Goal
                CActor pnn = new CActor();
                pnn.Name = 'G';
                pnn.X = Location.X + 741 + a + f;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                pnn.S = 0;
                pnn.G = 0;
                pnn.D = 0;
                pnn.R = 0;
                pnn.U = 13;
                pnn.L = 2;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);

            }

            f = 32;
            for (int i = 0; i < 5; i++)
            {//B to D
                CActor pnn = new CActor();
                pnn.X = Location.X + 549 + a;
                pnn.Y = Location.Y + 193 + b - f;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "BtoD";
                LActs3.Add(pnn);
                f += 32;
            }




            for (int i = 0; i < 3; i++)
            {
                //S to E
                CActor pnn = new CActor();
                pnn.X = Location.X + 101 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "StoE";
                LActs3.Add(pnn);
                a += 32;
            }

            a += 32;
            {   //E node
                CActor pnn = new CActor();
                pnn.Name = 'E';
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                pnn.S = 0;
                pnn.G = 0;
                pnn.D = 0;
                pnn.R = 0;
                pnn.U = 9;
                pnn.L = 3;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);

            }



            b -= 32;
            for (int i = 0; i < 3; i++)
            {
                //E to C up
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "EtoC";
                LActs3.Add(pnn);
                b -= 32;
            }
            for (int i = 0; i < 2; i++)
            {
                // E to C right
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "EtoC";
                LActs3.Add(pnn);
                a += 32;
            }
            a += 64;
            a -= 32;
            b -= 32;
            for (int i = 0; i < 3; i++)
            {   //E to C up
                CActor pnn = new CActor();
                pnn.X = Location.X + 5 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "EtoC";
                LActs3.Add(pnn);
                b -= 32;
            }

            {
                //E to C
                CActor pnn = new CActor();
                pnn.X = Location.X + 37 + a;
                pnn.Y = Location.Y + 129 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "EtoC";
                LActs3.Add(pnn);

            }
            b += 64;
            for (int i = 0; i < 3; i++)
            {
                a += 32;
            }
            a -= 32;
            for (int i = 0; i < 4; i++)
            {
                //C to B down
                CActor pnn = new CActor();
                pnn.X = Location.X + 5 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "CtoB";
                LActs3.Add(pnn);
                b += 32;
            }
            b -= 32;
            for (int i = 0; i < 7; i++)
            {
                //C to B right 2
                CActor pnn = new CActor();
                pnn.X = Location.X + 37 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "CtoB";
                LActs3.Add(pnn);
                a += 32;
            }
            a -= 32;


            {
                //B node

                CActor pnn = new CActor();
                pnn.Name = 'B';
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                b -= 32;
                pnn.S = 0;
                pnn.G = 0;
                pnn.D = 5;
                pnn.R = 6;
                pnn.U = 3;
                pnn.L = 11;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);

            }
            for (int i = 0; i < 3; i++)
            {
                //A to B
                CActor pnn = new CActor();

                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "AtoB";
                LActs3.Add(pnn);
                b -= 32;
            }
            a = 0;
            b = 0;

            for (int i = 0; i < 3; i++)
            {
                //S to C right 
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "StoC";
                LActs3.Add(pnn);
                a += 32;
            }
            f = 0;
            for (int i = 0; i < 3; i++)
            {
                //S to C up 2
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b - f;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "StoC";
                LActs3.Add(pnn);
                f += 32;
            }
            f = 32;
            for (int i = 0; i < 4; i++)
            {
                //S to C right 2
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a + f;
                pnn.Y = Location.Y + 33 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "StoC";
                LActs3.Add(pnn);
                f += 32;
            }
            {
                //S to C down 
                CActor pnn = new CActor();
                pnn.X = Location.X + 197 + a;
                pnn.Y = Location.Y + 33 + b + 32;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                LActs3.Add(pnn);
                f += 32;
                pnn.path = "StoC";
            }
            a += 128;
            {
                //C Node
                CActor pnn = new CActor();
                pnn.Name = 'C';
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                a += 32;
                pnn.S = 0;
                pnn.G = 0;

                pnn.D = 11;
                pnn.R = 7;
                pnn.U = 17;
                pnn.L = 9;
                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);


            }
            for (int i = 0; i < 7; i++)
            {
                //From C to A
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "CtoA";
                LActs3.Add(pnn);
                a += 32;
            }
            {
                // Node A
                CActor pnn = new CActor();
                pnn.Name = 'A';
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 0;
                LActs3.Add(pnn);
                a += 32;
                pnn.S = 0;
                pnn.G = 0;

                pnn.D = 3;
                pnn.R = 13;
                pnn.U = 0;
                pnn.L = 7;

                pnn.GoU = 0;
                pnn.GoD = 0;
                pnn.GoL = 0;
                pnn.GoR = 0;
                pnn.cost = r.Next(0, 10);

            }
            for (int i = 0; i < 6; i++)
            {
                //Path from A to G Left
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "AtoG";
                LActs3.Add(pnn);
                a += 32;
            }
            for (int i = 0; i < 7; i++)
            {
                //path from A to G Down
                CActor pnn = new CActor();
                pnn.X = Location.X + 69 + a;
                pnn.Y = Location.Y + 97 + b;
                pnn.W = 30;
                pnn.type = 1;
                pnn.Draw = 0;
                pnn.path = "AtoG";
                LActs3.Add(pnn);
                b += 32;
            }


            for (int i = 0; i < LActs3.Count; i++)
            {

                if (LActs3[i].Name == 'C')
                {
                    label9.Text = LActs3[i].cost.ToString();
                }

                if (LActs3[i].Name == 'E')
                {
                    label10.Text = LActs3[i].cost.ToString();

                }
                if (LActs3[i].Name == 'F')
                {
                    label11.Text = LActs3[i].cost.ToString();

                }
                if (LActs3[i].Name == 'D')
                {
                    label13.Text = LActs3[i].cost.ToString();


                }
                if (LActs3[i].Name == 'B')
                {
                    label12.Text = LActs3[i].cost.ToString();


                }
                if (LActs3[i].Name == 'Z')
                {
                    label15.Text = LActs3[i].cost.ToString();

                }
                if (LActs3[i].Name == 'G')
                {
                    label16.Text = LActs3[i].cost.ToString();

                }
                if (LActs3[i].Name == 'A')
                {
                    label14.Text = LActs3[i].cost.ToString();
                }
            }
            DrawScene(CreateGraphics());
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int ctsf = 0;
            int ctsf2 = 0;
            int ctsf3 = 0;
            int ctsf4 = 0;
            if (ct == 2)
            {
                for (int i = 0; i < LActs3.Count; i++)
                {
                    if (LActs3[i].S == 1 && LActs3[i].Name == 'S')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].G == 1 && LActs3[j].Name == 'F')   //f
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {             
                                    if (LActs3[k].path == "StoF")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if(LActs3[j].Name=='F')
                                    {
                                        textBox1.Text = "S + F";
                                    }
                                }
                            }
                        }
                        
                        textBox2.Text = ctsf.ToString();
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].G == 1 && LActs3[j].Name == 'D')  //D
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {
                                    if (LActs3[k].path == "StoF")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if (LActs3[k].path == "FtoD")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf2++;
                                    }
                                    if(LActs3[j].Name=='D')
                                    {
                                        textBox1.Text = "S + F + D";
                                    }
                                }
                            }
                            int num = ctsf + ctsf2;
                            
                            textBox2.Text = num.ToString();
                        }
                      
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].G == 1 && LActs3[j].Name == 'Z')  // z
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {
                                    if (LActs3[k].path == "StoF")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if (LActs3[k].path == "FtoD")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf2++;
                                    }
                                    if (LActs3[k].path == "DtoZ")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf3++;
                                    }
                                    if(LActs3[j].Name=='Z')
                                    {
                                        textBox1.Text = "S + F + D + Z";
                                    }
                                }
                            }
                            int num2 = ctsf + ctsf2 + ctsf3;
                            
                            textBox2.Text = num2.ToString();
                        }
                      
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].G == 1 && LActs3[j].Name == 'E')   //e
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {
                                    if (LActs3[k].path == "StoE")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if(LActs3[j].Name=='E')
                                    {
                                        textBox1.Text = "S + E";
                                    }
                                }
                            }
                            
                            textBox2.Text = ctsf.ToString();
                        }
                        
                        for (int j = 0; j < LActs3.Count; j++)
                        {

                            if (LActs3[j].G == 1 && LActs3[j].Name == 'C')    //c
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {
                                    if (LActs3[k].path == "StoE")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if (LActs3[k].path == "EtoC")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf2++;
                                    }
                                    if(LActs3[j].Name=='C')
                                    {
                                        textBox1.Text = "S + E + C";
                                    }
                                }
                            }
                            int num5 = ctsf + ctsf2;
                           
                            textBox2.Text = num5.ToString();
                        }
                      
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].G == 1 && LActs3[j].Name == 'A') //a
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {
                                    if (LActs3[k].path == "StoE")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if (LActs3[k].path == "EtoC")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf2++;
                                    }
                                    if (LActs3[k].path == "CtoA")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf3++;
                                    }
                                    if(LActs3[j].Name=='A')
                                    {
                                        textBox1.Text = "S + E + C + A";
                                    }
                                }
                            }
                            int num3 = ctsf + ctsf2 + ctsf3;
                            
                            textBox2.Text = num3.ToString();
                        }
                      
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].G == 1 && LActs3[j].Name == 'B')  //b
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {
                                    if (LActs3[k].path == "StoE")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if (LActs3[k].path == "EtoC")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf2++;
                                    }
                                    if (LActs3[k].path == "CtoA")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf3++;
                                    }
                                    if (LActs3[k].path == "AtoB")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf4++;
                                    }
                                    if(LActs3[j].Name=='B')
                                    {
                                        textBox1.Text = "S + E + C + A + B";
                                    }
                                }
                            }
                            int num7 = ctsf + ctsf2 + ctsf3 + ctsf4;
                            
                            textBox2.Text = num7.ToString();
                        }
                       
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].G == 1 && LActs3[j].Name == 'G')  //g
                            {
                                for (int k = 0; k < LActs3.Count; k++)
                                {
                                    if (LActs3[k].path == "StoF")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf++;
                                    }
                                    if (LActs3[k].path == "FtoD")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf2++;
                                    }
                                    if (LActs3[k].path == "DtoZ")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf3++;
                                    }
                                    if (LActs3[k].path == "ZtoG")
                                    {
                                        LActs3[k].Draw = 1;
                                        ctsf4++;
                                    }
                                    if(LActs3[j].Name=='G')
                                    {
                                        textBox1.Text = "S + F + D + Z + G";
                                    }
                                }
                            }
                        }
                        int num6 = ctsf + ctsf2 + ctsf3 + ctsf4;
                       
                        textBox2.Text = num6.ToString();
                    }
                }
                DrawScene(CreateGraphics());
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (ct == 2)
            {
                for (int i = 0; i < LActs3.Count; i++)
                {
                    if (LActs3[i].S == 1 && LActs3[i].Name == 'S')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                           if (LActs3[j].Name == 'C')
                           {
                              
                                    ct2 += LActs3[j].cost;



                                for (int p = 0; p < LActs3.Count; p++)
                                {
                                    if (LActs3[p].Name == 'A')
                                    {

                                        ct21 = ct2;
                                        ct21 += LActs3[p].cost;
                                        for (int o = 0; o < LActs3.Count; o++)
                                        {

                                            if (LActs3[o].Name == 'G')
                                            {


                                                ct23 = ct21;
                                                ct23 += LActs3[o].cost;
                                                for (int r = 0; r < LActs3.Count; r++)
                                                {
                                                    if (LActs3[r].Name == 'Z')
                                                    {

                                                        ct26 = ct23;
                                                        ct26 += LActs3[r].cost;


                                                    }

                                                }



                                            }
                                        }


                                    }
                                    if (LActs3[p].Name == 'B')
                                    {

                                        ct22 = ct2;
                                        ct22 += LActs3[p].cost;

                                        for (int q = 0; q < LActs3.Count; q++)
                                        {

                                            if (LActs3[q].Name == 'Z')
                                            {

                                                ct24 = ct22;
                                                ct24 += LActs3[q].cost;

                                                for (int w = 0; w < LActs3.Count; w++)
                                                {
                                                    if (LActs3[w].Name == 'G')
                                                    {
                                                        ct25 = ct24;
                                                        ct25 += LActs3[w].cost;
                                                    }
                                                }
                                            }
                                            for (int t = 0; t < LActs3.Count; t++)
                                            {
                                                if (LActs3[t].Name == 'D')
                                                {
                                                    ct27 = ct22;
                                                    ct27 += LActs3[t].cost;
                                                }
                                            }
                                        }
                                    }
                                }

                           } 
                        }
                        //------------------------------------------------
                        for(int k=0;k<LActs3.Count;k++)
                        {
                            if (LActs3[k].Name == 'E')
                            {
                               
                                    ct3 += LActs3[k].cost;
                                  
                                
                               
                            }
                        }
                        //----------------------------------------------------------------------------------
                        for (int l = 0; l < LActs3.Count; l++)
                        {
                            if (LActs3[l].Name == 'F')
                            {
                               
                                    ct30 += LActs3[l].cost;
                                    
                                    for(int y=0;y <LActs3.Count;y++)
                                    {
                                        if (LActs3[y].Name == 'D')
                                        {
                                           
                                                ct31 = ct30;
                                                ct31 += LActs3[y].cost;
                                                for (int u = 0; u < LActs3.Count; u++)
                                                {
                                                    if (LActs3[u].Name == 'Z')
                                                    {
                                                        
                                                            ct32 = ct31;
                                                            ct32 += LActs3[u].cost;
                                                            for(int a=0;a<LActs3.Count;a++)
                                                            {
                                                                if(LActs3[a].Name == 'G')
                                                                {
                                                                        ct33 = ct32;
                                                                        ct33 += LActs3[a].cost;
                                                                        for (int s = 0; s < LActs3.Count; s++)
                                                                        {
                                                                            if (LActs3[s].Name == 'A')
                                                                            {
                                                                                
                                                                                    ct34 = ct33;
                                                                                    ct34 += LActs3[s].cost;
                                                                                
                                                                            
                                                                            }
                                                                        }
                                                                    
                                                                }
                                                                
                                                             


                                                            }
                                                        
                                                    
                                                    }
                                                }
                                                for(int f=0;f<LActs3.Count;f++)
                                                {
                                                    if (LActs3[f].Name == 'B')
                                                    {
                                                        
                                                            ct35 = ct31;
                                                            ct35 += LActs3[f].cost;
                                                            for (int g = 0; g < LActs3.Count; g++)
                                                            {
                                                                if (LActs3[g].Name == 'A')
                                                                {
                                                                    
                                                                        ct36 = ct35;
                                                                        ct36 += LActs3[g].cost;
                                                                       

                                                                    
                                                                 
                                                                }
                                                            }
                                                        
                                                    
                                                    }
                                                }
                                            
                                        
                                        }
                                    }
                                
                              
                            }
                        }
                    }
                }
                for (int i=0;i < LActs3.Count;i++)
                {
                    if (LActs3[i].G == 1)
                    {
                        if (LActs3[i].Name == 'C')
                        {  //23
                            textBox1.Text = "S + C";
                            textBox2.Text =LActs3[i].cost.ToString();
                            for(int j=0;j<LActs3.Count;j++)
                            {
                                if (LActs3[j].path == "StoC")
                                {
                                    LActs3[j].Draw = 1;
                                }

                            }
                        }
                        if (LActs3[i].Name == 'E')
                        {  //3
                            textBox1.Text = "S + E";
                            textBox2.Text = LActs3[i].cost.ToString();
                            for (int j = 0; j < LActs3.Count; j++)
                            {
                                if (LActs3[j].path == "StoE")
                                {
                                    LActs3[j].Draw = 1;
                                }

                            }
                        }
                        if (LActs3[i].Name == 'F')
                        {   //9
                            textBox1.Text = "S + F";
                            textBox2.Text = LActs3[i].cost.ToString();

                            for (int j = 0; j < LActs3.Count; j++)
                            {
                                if (LActs3[j].path == "StoF")
                                {
                                    LActs3[j].Draw = 1;
                                }

                            }
                        }
                        if (LActs3[i].Name == 'D')
                        {
                            if (ct27 > ct31)
                            { //16
                                textBox1.Text = "S + F + D";
                                textBox2.Text = ct31.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct27 < ct31)
                            {
                                textBox1.Text = "S + C + B + D";
                                textBox2.Text = ct27.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if(LActs3[j].path == "BtoD")
                                    {
                                        LActs3[j].Draw = 1;


                                    }
                                }
                            }
                        }
                        if (LActs3[i].Name == 'B')
                        {
                            if (ct22 < ct35)
                            {  //28
                                textBox1.Text = "S + C + B";
                                textBox2.Text = ct22.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }

                                }

                            }
                            if (ct22 > ct35)
                            {
                                textBox1.Text = "S + F + D + B";
                                textBox2.Text = ct35.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }

                                }
                            }
                        }
                        if (LActs3[i].Name == 'Z')
                        {
                            if (ct26 < ct24 && ct26 < ct32)
                            {
                                textBox1.Text = "S + C + A + G + Z";
                                textBox2.Text = ct26.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoA")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "ZtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct24 < ct26 && ct24 < ct32)
                            {
                                textBox1.Text = "S + C + B + Z";
                                textBox2.Text = ct24.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {

                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct32 < ct24 && ct32 < ct26)
                            {
                                textBox1.Text = "S + F + D + Z";
                                textBox2.Text = ct22.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "DtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                               
                                }
                            }
                        }
                        if (LActs3[i].Name == 'G')
                        {
                            if (ct23 < ct25 && ct23 < ct33)
                            {
                                textBox1.Text = "S + C + A + G";
                                textBox2.Text = ct23.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoA")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct25 < ct23 && ct25 < ct33)
                            {
                                textBox1.Text = "S + C + B + Z + G";
                                textBox2.Text = ct25.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct33 < ct23 && ct33 < ct25)
                            {
                                textBox1.Text = "S + F + D + Z+ G";
                                textBox2.Text = ct33.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "DtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "ZtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                        }
                        if (LActs3[i].Name == 'A')
                        {
                            if (ct21 < ct34 && ct21 < ct36)
                            {
                                textBox1.Text = "S + C + A";
                                textBox2.Text = ct21.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoA")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct34 < ct21 && ct34 < ct36)
                            {
                                textBox1.Text = "S + F + D + Z + G + A";
                                textBox2.Text = ct34.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "DtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "ZtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct36 < ct34 && ct36 < ct21)
                            {
                                textBox1.Text = "S + F + D + B + A";
                                textBox2.Text = ct36.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                        }
                    }
                }
                DrawScene(CreateGraphics());

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------A*-------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (ct == 2)
            {
                for (int i = 0; i < LActs3.Count; i++)
                {
                    if (LActs3[i].S == 1 && LActs3[i].Name == 'S')
                    {
                        for (int j = 0; j < LActs3.Count; j++)
                        {
                            if (LActs3[j].Name == 'C')
                            {

                                ct2 += LActs3[j].cost;
                                ct2 += LActs3[j].U;

                                for (int p = 0; p < LActs3.Count; p++)
                                {
                                    if (LActs3[p].Name == 'A')
                                    {

                                        ct21 = ct2;
                                        ct21 += LActs3[p].cost;
                                        ct21 += LActs3[p].L;

                                        for (int o = 0; o < LActs3.Count; o++)
                                        {

                                            if (LActs3[o].Name == 'G')
                                            {


                                                ct23 = ct21;
                                                ct23 += LActs3[o].cost;
                                                ct32 += LActs3[o].U;
                                                for (int r = 0; r < LActs3.Count; r++)
                                                {
                                                    if (LActs3[r].Name == 'Z')
                                                    {

                                                        ct26 = ct23;
                                                        ct26 += LActs3[r].cost;
                                                        ct26 += LActs3[r].R;
                                                    }
                                                }
                                            }
                                        }


                                    }
                                    if (LActs3[p].Name == 'B')
                                    {

                                        ct22 = ct2;
                                        ct22 += LActs3[p].cost;
                                        ct22 += LActs3[p].U;

                                        for (int q = 0; q < LActs3.Count; q++)
                                        {

                                            if (LActs3[q].Name == 'Z')
                                            {

                                                ct24 = ct22;
                                                ct24 += LActs3[q].cost;
                                                ct24 += LActs3[q].U;

                                                for (int w = 0; w < LActs3.Count; w++)
                                                {
                                                    if (LActs3[w].Name == 'G')
                                                    {

                                                        ct25 = ct24;
                                                        ct25 += LActs3[w].cost;
                                                        ct25 += LActs3[w].L;


                                                    }
                                                }



                                            }
                                            for (int t = 0; t < LActs3.Count; t++)
                                            {
                                                if (LActs3[t].Name == 'D')
                                                {
                                                    ct27 = ct22;
                                                    ct27 += LActs3[t].cost;
                                                    ct27 += LActs3[t].U;


                                                }

                                            }

                                        }



                                    }

                                }


                            }

                        }
                        //------------------------------------------------
                        for (int k = 0; k < LActs3.Count; k++)
                        {
                            if (LActs3[k].Name == 'E')
                            {

                                ct3 += LActs3[k].cost;
                                ct3 += LActs3[k].L;


                            }
                        }
                        //----------------------------------------------------------------------------------
                        for (int l = 0; l < LActs3.Count; l++)
                        {
                            if (LActs3[l].Name == 'F')
                            {

                                ct30 += LActs3[l].cost;
                                ct30 += LActs3[l].L;
                                for (int y = 0; y < LActs3.Count; y++)
                                {
                                    if (LActs3[y].Name == 'D')
                                    { 
                                        ct31 = ct30;
                                        ct31 += LActs3[y].cost;
                                        ct31 += LActs3[y].L;
                                        for (int u = 0; u < LActs3.Count; u++)
                                        {
                                            if (LActs3[u].Name == 'Z')
                                            {
                                                ct32 = ct31;
                                                ct32 += LActs3[u].cost;
                                                ct32 += LActs3[u].D;
                                                for (int a = 0; a < LActs3.Count; a++)
                                                {
                                                    if (LActs3[a].Name == 'G')
                                                    {
                                                        ct33 = ct32;
                                                        ct33 += LActs3[a].cost;
                                                        ct33 += LActs3[a].L;
                                                        for (int s = 0; s < LActs3.Count; s++)
                                                        {
                                                            if (LActs3[s].Name == 'A')
                                                            {
                                                                ct34 = ct33;
                                                                ct34 += LActs3[s].cost;
                                                                ct34 += LActs3[s].R;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        for (int f = 0; f < LActs3.Count; f++)
                                        {
                                            if (LActs3[f].Name == 'B')
                                            {
                                                ct35 = ct31;
                                                ct35 += LActs3[f].cost;
                                                ct35 += LActs3[f].D;
                                                for (int g = 0; g < LActs3.Count; g++)
                                                {
                                                    if (LActs3[g].Name == 'A')
                                                    {
                                                        ct36 = ct35;
                                                        ct36 += LActs3[g].cost;
                                                        ct36 += LActs3[g].D;
                                                    }
                                                }


                                            }
                                        }


                                    }
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < LActs3.Count; i++)
                {
                    if (LActs3[i].G == 1)
                    {
                        if (LActs3[i].Name == 'C')
                        {
                            textBox1.Text = "S + C";
                            textBox2.Text = Convert.ToString(ct2);
                            for (int j = 0; j < LActs3.Count; j++)
                            {
                                if (LActs3[j].path == "StoC")
                                {
                                    LActs3[j].Draw = 1;
                                }

                            }
                        }
                        if (LActs3[i].Name == 'E')
                        {
                            textBox1.Text = "S + E";
                            int num = LActs3[i].cost;
                            textBox2.Text = Convert.ToString(ct3);
                            for (int j = 0; j < LActs3.Count; j++)
                            {
                                if (LActs3[j].path == "StoE")
                                {
                                    LActs3[j].Draw = 1;
                                }

                            }
                        }
                        if (LActs3[i].Name == 'F')
                        {
                            textBox1.Text = "S + F";
                            int num2 = LActs3[i].cost;
                            textBox2.Text = Convert.ToString(ct30);

                            for (int j = 0; j < LActs3.Count; j++)
                            {
                                if (LActs3[j].path == "StoF")
                                {
                                    LActs3[j].Draw = 1;
                                }

                            }
                        }
                        if (LActs3[i].Name == 'D')
                        {

                            if (ct27 > ct31)
                            {
                                textBox1.Text = "S + F + D";
                                int num8 = LActs3[i].cost;
                                textBox2.Text = Convert.ToString( ct31 );
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }

                                }
                            }
                            if (ct27 < ct31)
                            {
                                textBox1.Text = "S + C + B + D";
                                textBox2.Text = ct27.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoD")
                                    {
                                        LActs3[j].Draw = 1;


                                    }
                                }
                            }
                        }
                        if (LActs3[i].Name == 'B')
                        {
                            
                            if (ct22 < ct35)
                            {
                                textBox1.Text = "S + C + B";
                                int num = LActs3[i].cost;
                                textBox2.Text = Convert.ToString(ct22 + 8);
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            //;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
                            if (ct22 > ct35)
                            {  //21
                                textBox1.Text = "S + F + D + B";
                                textBox2.Text = ct35.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }

                                }
                            }
                        }
                        if (LActs3[i].Name == 'Z')
                        {
                            if (ct26 < ct24 && ct26 < ct32)
                            {  
                                textBox1.Text = "S + C + A + G + Z";
                                textBox2.Text = ct26.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoA")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "ZtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct24 < ct26 && ct24 < ct32)
                            {  //34
                                textBox1.Text = "S + C + B + Z";
                                textBox2.Text = Convert.ToString(ct24 + 8);
                                for (int j = 0; j < LActs3.Count; j++)
                                {

                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct32 < ct24 && ct32 < ct26)
                            {  //24
                                textBox1.Text = "S + F + D + Z";
                                textBox2.Text = Convert.ToString(ct32 );
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "DtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }

                                }
                            }
                        }
                        if (LActs3[i].Name == 'G')
                        {
                            if (ct23 < ct25 && ct23 < ct33)
                            {     //37
                                textBox1.Text = "S + C + A + G";
                                textBox2.Text = Convert.ToString(ct23 + 13);
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoA")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct25 < ct23 && ct25 < ct33)
                            {
                                textBox1.Text = "S + C + B + Z + G";
                                textBox2.Text = Convert.ToString(ct25);
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct33 < ct23 && ct33 < ct25)
                            {  
                                textBox1.Text = "S + F + D + Z+ G";
                                textBox2.Text = ct33.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "DtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "ZtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                        }
                        if (LActs3[i].Name == 'A')
                        { //24
                            if (ct21 < ct34 && ct21 < ct36)
                            {
                                textBox1.Text = "S + C + A";
                                textBox2.Text = ct21.ToString();
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoC")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "CtoA")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct34 < ct21 && ct34 < ct36)
                            {
                                textBox1.Text = "S + F + D + Z + G + A";
                                textBox2.Text = Convert.ToString(ct34);
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "DtoZ")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "ZtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoG")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                            if (ct36 < ct34 && ct36 < ct21)
                            {
                                textBox1.Text = "S + F + D + B + A";
                                textBox2.Text = Convert.ToString(ct36);
                                for (int j = 0; j < LActs3.Count; j++)
                                {
                                    if (LActs3[j].path == "StoF")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "FtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "BtoD")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                    if (LActs3[j].path == "AtoB")
                                    {
                                        LActs3[j].Draw = 1;
                                    }
                                }
                            }
                        }
                    }
                }
                DrawScene(CreateGraphics());

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

