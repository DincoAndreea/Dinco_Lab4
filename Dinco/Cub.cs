using OpenTK.Graphics.OpenGL;
using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Dinco
{
    class Cub
    {
        private int[,] Vertexes = new int[40, 40];
        private Color[] ColorV = { Color.White, Color.LawnGreen, Color.WhiteSmoke, Color.Tomato, Color.Turquoise, Color.OldLace, Color.Olive, Color.MidnightBlue, Color.PowderBlue, Color.PeachPuff, Color.LavenderBlush, Color.MediumAquamarine, Color.Red, Color.Fuchsia, Color.Cyan };
        private float[,] Colors4 = new float[10,10];
        private List<Vertex> vs_X = new List<Vertex>();
        private List<Vertex> vs_Y = new List<Vertex>();
        private List<Vertex> vs_Z = new List<Vertex>();
        private float counter1 = 1/255f;

        public Cub()
        {
            float[,] Colors4 = new float[,] { 
                { 0.23f, 0.45f, 0.56f, 1.0f },
                { 0.78f, 0.45f, 0.89f, 1.0f }, 
                { 0.73f, 0.85f, 0.26f, 1.0f }, 
                { 0.55f, 0.15f, 0.76f, 1.0f }, 
                { 0.13f, 0.25f, 0.76f, 1.0f }, 
                { 0.67f, 0.55f, 0.86f, 1.0f } };


            int[,] Vertexes = new int[,] {
            {5, 10, 5, 10, 5, 10, 5, 10, 5, 10, 5, 10, 5, 5, 5, 5, 5, 5, 5, 10, 5,10, 10, 5, 10, 10, 10, 10, 10, 10,5, 10, 5,10, 10, 5},
            {5, 5, 12,
                5, 12, 12,
                5, 5, 5,
                5, 5, 5,
                5, 12, 5,
                12, 5, 12,
                12, 12, 12,
                12, 12, 12,
                5, 12, 5,
                12, 5, 12,
                5, 5, 12,
                5, 12, 12},
            {6, 6, 6,
                6, 6, 6,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                6, 6, 12,
                6, 12, 12,
                12, 12, 12,
                12, 12, 12}};

            for (int i = 0; i < 36; i = i + 3)
            {

                vs_X.Add(new Vertex(Vertexes[0, i], Vertexes[1, i], Vertexes[2, i]));
                vs_Y.Add(new Vertex(Vertexes[0, i + 1], Vertexes[1, i + 1], Vertexes[2, i + 1]));
                vs_Z.Add(new Vertex(Vertexes[0, i + 2], Vertexes[1, i + 2], Vertexes[2, i + 2]));

            }

            for (int i = 0; i < 12; i++)
            {
                vs_X.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);
                vs_Y.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);
                vs_Z.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);
                
            }


        }

        public Cub(int[,] _Vertexes, float[,] _Colors4)
        {
            Vertexes = _Vertexes;
            Colors4 = _Colors4;

            for (int i = 0; i < 36; i = i + 3)
            {

                vs_X.Add(new Vertex(Vertexes[0, i], Vertexes[1, i], Vertexes[2, i]));
                vs_Y.Add(new Vertex(Vertexes[0, i + 1], Vertexes[1, i + 1], Vertexes[2, i + 1]));
                vs_Z.Add(new Vertex(Vertexes[0, i + 2], Vertexes[1, i + 2], Vertexes[2, i + 2]));

            }

            for (int i = 0; i < 12; i++)
            {
                vs_X.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);
                vs_Y.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);
                vs_Z.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);

            }
        }

        /// Lab 4 Problema 1


        public Cub(string numeFisier1, string numeFisier2)
        {

            StreamReader f1 = new StreamReader(numeFisier1);
            
            int nrLinii = Int32.Parse(f1.ReadLine());
            int[,] Vertexes1 = new int[nrLinii,nrLinii];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < nrLinii; j+=3)
                {
                    string aux = f1.ReadLine();
                    Vertexes1[i, j] = Int32.Parse(aux.Split(',')[0]);
                    Vertexes1[i, j+1] = Int32.Parse(aux.Split(',')[1]);
                    Vertexes1[i, j+2] = Int32.Parse(aux.Split(',')[2]);
                }
            }
            Vertexes = Vertexes1;
            f1.Close();

            for (int i = 0; i < 36; i = i + 3)
            {

                vs_X.Add(new Vertex(Vertexes[0, i], Vertexes[1, i], Vertexes[2, i]));
                vs_Y.Add(new Vertex(Vertexes[0, i + 1], Vertexes[1, i + 1], Vertexes[2, i + 1]));
                vs_Z.Add(new Vertex(Vertexes[0, i + 2], Vertexes[1, i + 2], Vertexes[2, i + 2]));

            }


            StreamReader f2 = new StreamReader(numeFisier2);

            int nrLinii1 = Int32.Parse(f2.ReadLine());
            float[,] Culori1 = new float[nrLinii1, nrLinii1];
            for (int i = 0; i < nrLinii1; i++)
            {
           
                string aux1 = f2.ReadLine();
                Culori1[i, 0] = float.Parse(aux1.Split(' ')[0]);
                Culori1[i, 1] = float.Parse(aux1.Split(' ')[1]);
                Culori1[i, 2] = float.Parse(aux1.Split(' ')[2]);
                Culori1[i, 3] = float.Parse(aux1.Split(' ')[3]);
                
            }

            Colors4 = Culori1;
            f2.Close();

            for (int i = 0; i < 12; i++)
            {
                vs_X.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);
                vs_Y.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);
                vs_Z.ElementAt(i).SetColor4RGBA(Colors4[i / 2, 0], Colors4[i / 2, 1], Colors4[i / 2, 2], Colors4[i / 2, 3]);

            }

        }


        public void SetColorFace1(float _R, float _G, float _B, float _A)
        {
            vs_X.ElementAt(10).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(10).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(10).SetColor4RGBA(_R, _G, _B, _A);
            vs_X.ElementAt(11).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(11).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(11).SetColor4RGBA(_R, _G, _B, _A);
        }

        public void SetColorFace2(float _R, float _G, float _B, float _A)
        {
            vs_X.ElementAt(8).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(8).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(8).SetColor4RGBA(_R, _G, _B, _A);
            vs_X.ElementAt(9).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(9).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(9).SetColor4RGBA(_R, _G, _B, _A);
        }

        public void SetColorFace3(float _R, float _G, float _B, float _A)
        {
            vs_X.ElementAt(6).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(6).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(6).SetColor4RGBA(_R, _G, _B, _A);
            vs_X.ElementAt(7).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(7).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(7).SetColor4RGBA(_R, _G, _B, _A);
        }

        public void SetColorFace4(float _R, float _G, float _B, float _A)
        {
            vs_X.ElementAt(4).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(4).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(4).SetColor4RGBA(_R, _G, _B, _A);
            vs_X.ElementAt(5).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(5).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(5).SetColor4RGBA(_R, _G, _B, _A);
        }

        public void SetColorFace5(float _R, float _G, float _B, float _A)
        {
            vs_X.ElementAt(2).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(2).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(2).SetColor4RGBA(_R, _G, _B, _A);
            vs_X.ElementAt(3).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(3).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(3).SetColor4RGBA(_R, _G, _B, _A);
        }

        public void SetColorFace6(float _R, float _G, float _B, float _A)
        {
            vs_X.ElementAt(0).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(0).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(0).SetColor4RGBA(_R, _G, _B, _A);
            vs_X.ElementAt(1).SetColor4RGBA(_R, _G, _B, _A);
            vs_Y.ElementAt(1).SetColor4RGBA(_R, _G, _B, _A);
            vs_Z.ElementAt(1).SetColor4RGBA(_R, _G, _B, _A);
        }


        /// <summary>
        /// Lab 4 Problema 3
        /// </summary>

        public void SetColorsRandom()
        {
            Random rand = new Random();
            int[] indexes = new int[12];
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = rand.Next(0, 14);
            }

            GL.Begin(PrimitiveType.Triangles);

            for (int i = 0; i < 12; i++)
            {
                GL.Color3(ColorV[indexes[i/2]]);
                GL.Vertex3(vs_X.ElementAt(i).GetX(), vs_X.ElementAt(i).GetY(), vs_X.ElementAt(i).GetZ());
                GL.Vertex3(vs_Y.ElementAt(i).GetX(), vs_Y.ElementAt(i).GetY(), vs_Y.ElementAt(i).GetZ());
                GL.Vertex3(vs_Z.ElementAt(i).GetX(), vs_Z.ElementAt(i).GetY(), vs_Z.ElementAt(i).GetZ());
            }
            
            GL.End();

        }

        public void DrawCub()
        {

            GL.Begin(PrimitiveType.Triangles);


            for (int i = 0; i < 12; i++)
            {
                GL.Color4(vs_X.ElementAt(i).GetR(), vs_X.ElementAt(i).GetG(), vs_X.ElementAt(i).GetB(), vs_X.ElementAt(i).GetA());
                GL.Vertex3(vs_X.ElementAt(i).GetX(), vs_X.ElementAt(i).GetY(), vs_X.ElementAt(i).GetZ());
                GL.Vertex3(vs_Y.ElementAt(i).GetX(), vs_Y.ElementAt(i).GetY(), vs_Y.ElementAt(i).GetZ());
                GL.Vertex3(vs_Z.ElementAt(i).GetX(), vs_Z.ElementAt(i).GetY(), vs_Z.ElementAt(i).GetZ());
            }

            GL.End();
        }


        /// <summary>
        /// Lab 4 Problema 1
        /// </summary>


        public void ChangeColorsFace1(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if(r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetR(0.00f);
                }
                this.vs_X.ElementAt(10).SetR(this.vs_X.ElementAt(10).GetR() + counter1);
            }
            if(_r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetR(0.00f);
                }
                this.vs_X.ElementAt(10).SetR(this.vs_X.ElementAt(10).GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetG(0.00f);
                }
                this.vs_X.ElementAt(10).SetG(this.vs_X.ElementAt(10).GetG() + counter1);
            }
            if(_g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetG(0.00f);
                }
                this.vs_X.ElementAt(10).SetG(this.vs_X.ElementAt(10).GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetB(0.00f);
                }
                this.vs_X.ElementAt(10).SetB(this.vs_X.ElementAt(10).GetB() + counter1);
            }
            if(_b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetB(0.00f);
                }
                this.vs_X.ElementAt(10).SetB(this.vs_X.ElementAt(10).GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetA(0.00f);
                }
                this.vs_X.ElementAt(10).SetA(this.vs_X.ElementAt(10).GetA() + counter1);
            }
            if(_a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(10).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(10).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(10).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(10).SetA(0.00f);
                }
                this.vs_X.ElementAt(10).SetA(this.vs_X.ElementAt(10).GetA() - counter1);
            }


            this.SetColorFace1(this.vs_X.ElementAt(10).GetR(), this.vs_X.ElementAt(10).GetG(), this.vs_X.ElementAt(10).GetB(), this.vs_X.ElementAt(10).GetA());
        }






        public void ChangeColorsFace2(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if (r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetR(0.00f);
                }
                this.vs_X.ElementAt(8).SetR(this.vs_X.ElementAt(8).GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetR(0.00f);
                }
                this.vs_X.ElementAt(8).SetR(this.vs_X.ElementAt(8).GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetG(0.00f);
                }
                this.vs_X.ElementAt(8).SetG(this.vs_X.ElementAt(8).GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetG(0.00f);
                }
                this.vs_X.ElementAt(8).SetG(this.vs_X.ElementAt(8).GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetB(0.00f);
                }
                this.vs_X.ElementAt(8).SetB(this.vs_X.ElementAt(8).GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetB(0.00f);
                }
                this.vs_X.ElementAt(8).SetB(this.vs_X.ElementAt(8).GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetA(0.00f);
                }
                this.vs_X.ElementAt(8).SetA(this.vs_X.ElementAt(8).GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(8).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(8).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(8).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(8).SetA(0.00f);
                }
                this.vs_X.ElementAt(8).SetA(this.vs_X.ElementAt(8).GetA() - counter1);
            }


            this.SetColorFace2(this.vs_X.ElementAt(8).GetR(), this.vs_X.ElementAt(8).GetG(), this.vs_X.ElementAt(8).GetB(), this.vs_X.ElementAt(8).GetA());
        }







        public void ChangeColorsFace3(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if (r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetR(0.00f);
                }
                this.vs_X.ElementAt(6).SetR(this.vs_X.ElementAt(6).GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetR(0.00f);
                }
                this.vs_X.ElementAt(6).SetR(this.vs_X.ElementAt(6).GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetG(0.00f);
                }
                this.vs_X.ElementAt(6).SetG(this.vs_X.ElementAt(6).GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetG(0.00f);
                }
                this.vs_X.ElementAt(6).SetG(this.vs_X.ElementAt(6).GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetB(0.00f);
                }
                this.vs_X.ElementAt(6).SetB(this.vs_X.ElementAt(6).GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetB(0.00f);
                }
                this.vs_X.ElementAt(6).SetB(this.vs_X.ElementAt(6).GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetA(0.00f);
                }
                this.vs_X.ElementAt(6).SetA(this.vs_X.ElementAt(6).GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(6).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(6).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(6).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(6).SetA(0.00f);
                }
                this.vs_X.ElementAt(6).SetA(this.vs_X.ElementAt(6).GetA() - counter1);
            }


            this.SetColorFace3(this.vs_X.ElementAt(6).GetR(), this.vs_X.ElementAt(6).GetG(), this.vs_X.ElementAt(6).GetB(), this.vs_X.ElementAt(6).GetA());
        }







        public void ChangeColorsFace4(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if (r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetR(0.00f);
                }
                this.vs_X.ElementAt(4).SetR(this.vs_X.ElementAt(4).GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetR(0.00f);
                }
                this.vs_X.ElementAt(4).SetR(this.vs_X.ElementAt(4).GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetG(0.00f);
                }
                this.vs_X.ElementAt(4).SetG(this.vs_X.ElementAt(4).GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetG(0.00f);
                }
                this.vs_X.ElementAt(4).SetG(this.vs_X.ElementAt(4).GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetB(0.00f);
                }
                this.vs_X.ElementAt(4).SetB(this.vs_X.ElementAt(4).GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetB(0.00f);
                }
                this.vs_X.ElementAt(4).SetB(this.vs_X.ElementAt(4).GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetA(0.00f);
                }
                this.vs_X.ElementAt(4).SetA(this.vs_X.ElementAt(4).GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(4).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(4).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(4).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(4).SetA(0.00f);
                }
                this.vs_X.ElementAt(4).SetA(this.vs_X.ElementAt(4).GetA() - counter1);
            }


            this.SetColorFace4(this.vs_X.ElementAt(4).GetR(), this.vs_X.ElementAt(4).GetG(), this.vs_X.ElementAt(4).GetB(), this.vs_X.ElementAt(4).GetA());
        }







        public void ChangeColorsFace5(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if (r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetR(0.00f);
                }
                this.vs_X.ElementAt(2).SetR(this.vs_X.ElementAt(2).GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetR(0.00f);
                }
                this.vs_X.ElementAt(2).SetR(this.vs_X.ElementAt(2).GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetG(0.00f);
                }
                this.vs_X.ElementAt(2).SetG(this.vs_X.ElementAt(2).GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetG(0.00f);
                }
                this.vs_X.ElementAt(2).SetG(this.vs_X.ElementAt(2).GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetB(0.00f);
                }
                this.vs_X.ElementAt(2).SetB(this.vs_X.ElementAt(2).GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetB(0.00f);
                }
                this.vs_X.ElementAt(2).SetB(this.vs_X.ElementAt(2).GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetA(0.00f);
                }
                this.vs_X.ElementAt(2).SetA(this.vs_X.ElementAt(2).GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(2).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(2).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(2).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(2).SetA(0.00f);
                }
                this.vs_X.ElementAt(2).SetA(this.vs_X.ElementAt(2).GetA() - counter1);
            }


            this.SetColorFace5(this.vs_X.ElementAt(2).GetR(), this.vs_X.ElementAt(2).GetG(), this.vs_X.ElementAt(2).GetB(), this.vs_X.ElementAt(2).GetA());
        }





        

        public void ChangeColorsFace6(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if (r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetR(0.00f);
                }
                this.vs_X.ElementAt(0).SetR(this.vs_X.ElementAt(0).GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetR() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetR(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetR() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetR(0.00f);
                }
                this.vs_X.ElementAt(0).SetR(this.vs_X.ElementAt(0).GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetG(0.00f);
                }
                this.vs_X.ElementAt(0).SetG(this.vs_X.ElementAt(0).GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetG() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetG(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetG() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetG(0.00f);
                }
                this.vs_X.ElementAt(0).SetG(this.vs_X.ElementAt(0).GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetB(0.00f);
                }
                this.vs_X.ElementAt(0).SetB(this.vs_X.ElementAt(0).GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetB() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetB(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetB() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetB(0.00f);
                }
                this.vs_X.ElementAt(0).SetB(this.vs_X.ElementAt(0).GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetA(0.00f);
                }
                this.vs_X.ElementAt(0).SetA(this.vs_X.ElementAt(0).GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(this.vs_X.ElementAt(0).GetA() * 255) > 255)
                {
                    this.vs_X.ElementAt(0).SetA(1.00f);
                }

                if ((this.vs_X.ElementAt(0).GetA() * 255) < 0)
                {
                    this.vs_X.ElementAt(0).SetA(0.00f);
                }
                this.vs_X.ElementAt(0).SetA(this.vs_X.ElementAt(0).GetA() - counter1);
            }


            this.SetColorFace6(this.vs_X.ElementAt(0).GetR(), this.vs_X.ElementAt(0).GetG(), this.vs_X.ElementAt(0).GetB(), this.vs_X.ElementAt(0).GetA());
        }
    }
}
