using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using OpenTK.Graphics;


namespace Dinco
{
    internal class Triunghi
    {

        public Vertex A, B, C;

        private float counter1 = 1/255f;

        public Triunghi()
        {

            A = new Vertex(5, 2, 0, Color4.DeepPink);
            B = new Vertex(15, 10, 0, Color4.DeepPink);
            C = new Vertex(10, 15, 0, Color4.DeepPink);
        }

        public Triunghi(Vertex _A, Vertex _B, Vertex _C)
        {

            A = _A;
            B = _B;
            C = _C;
        }

        public void DrawTriunghi()
        {

            GL.Begin(PrimitiveType.Triangles);

            GL.Color4(A.GetR(), A.GetG(), A.GetB(), A.GetA());
            GL.Vertex3(A.GetX(), A.GetY(), A.GetZ());
            GL.Color4(B.GetR(), B.GetG(), B.GetB(), B.GetA());
            GL.Vertex3(B.GetX(), B.GetY(), B.GetZ());
            GL.Color4(C.GetR(), C.GetG(), C.GetB(), C.GetA());
            GL.Vertex3(C.GetX(), C.GetY(), C.GetZ());

            GL.End();
        }

        /// <summary>
        /// Lab 4 Problema 2
        /// </summary>


        public void ChangeColor4VertexA(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if (r == true)
            {
                if (Math.Round(A.GetR() * 255) > 255)
                {
                    this.A.SetR(1.00f);
                }

                if ((A.GetR() * 255) < 0)
                {
                    A.SetR(0.00f);
                }
                A.SetR(A.GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(A.GetR() * 255) > 255)
                {
                    A.SetR(1.00f);
                }

                if ((A.GetR() * 255) < 0)
                {
                    A.SetR(0.00f);
                }
                A.SetR(A.GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(A.GetG() * 255) > 255)
                {
                    this.A.SetG(1.00f);
                }

                if ((A.GetG() * 255) < 0)
                {
                    A.SetG(0.00f);
                }
                A.SetG(A.GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(A.GetG() * 255) > 255)
                {
                    A.SetG(1.00f);
                }

                if ((A.GetG() * 255) < 0)
                {
                    A.SetG(0.00f);
                }
                A.SetG(A.GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(A.GetB() * 255) > 255)
                {
                    this.A.SetB(1.00f);
                }

                if ((A.GetB() * 255) < 0)
                {
                    A.SetB(0.00f);
                }
                A.SetB(A.GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(A.GetB() * 255) > 255)
                {
                    A.SetB(1.00f);
                }

                if ((A.GetB() * 255) < 0)
                {
                    A.SetB(0.00f);
                }
                A.SetB(A.GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(A.GetA() * 255) > 255)
                {
                    this.A.SetA(1.00f);
                }

                if ((A.GetA() * 255) < 0)
                {
                    A.SetA(0.00f);
                }
                A.SetA(A.GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(A.GetA() * 255) > 255)
                {
                    A.SetA(1.00f);
                }

                if ((A.GetA() * 255) < 0)
                {
                    A.SetA(0.00f);
                }
                A.SetA(A.GetA() - counter1);
            }

            Console.WriteLine("R:" + A.GetR() + ", G:" + A.GetG() + ", B:" + A.GetB() + ", A:" + A.GetA());
        }

        public void ChangeColor4VertexB(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {
            if (r == true)
            {
                if (Math.Round(B.GetR() * 255) > 255)
                {
                    this.B.SetR(1.00f);
                }

                if ((B.GetR() * 255) < 0)
                {
                    B.SetR(0.00f);
                }
                B.SetR(B.GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(B.GetR() * 255) > 255)
                {
                    B.SetR(1.00f);
                }

                if ((B.GetR() * 255) < 0)
                {
                    B.SetR(0.00f);
                }
                B.SetR(B.GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(B.GetG() * 255) > 255)
                {
                    this.B.SetG(1.00f);
                }

                if ((B.GetG() * 255) < 0)
                {
                    B.SetG(0.00f);
                }
                B.SetG(B.GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(B.GetG() * 255) > 255)
                {
                    B.SetG(1.00f);
                }

                if ((B.GetG() * 255) < 0)
                {
                    B.SetG(0.00f);
                }
                B.SetG(B.GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(B.GetB() * 255) > 255)
                {
                    this.B.SetB(1.00f);
                }

                if ((B.GetB() * 255) < 0)
                {
                    B.SetB(0.00f);
                }
                B.SetB(B.GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(B.GetB() * 255) > 255)
                {
                    B.SetB(1.00f);
                }

                if ((B.GetB() * 255) < 0)
                {
                    B.SetB(0.00f);
                }
                B.SetB(B.GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(B.GetA() * 255) > 255)
                {
                    this.B.SetA(1.00f);
                }

                if ((B.GetA() * 255) < 0)
                {
                    B.SetA(0.00f);
                }
                B.SetA(B.GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(B.GetA() * 255) > 255)
                {
                    B.SetA(1.00f);
                }

                if ((B.GetA() * 255) < 0)
                {
                    B.SetA(0.00f);
                }
                B.SetA(B.GetA() - counter1);
            }

            Console.WriteLine("R:" + B.GetR() + ", G:" + B.GetG() + ", B:" + B.GetB() + ", A:" + B.GetA());
        }

        public void ChangeColor4VertexC(bool r, bool g, bool b, bool a, bool _r, bool _g, bool _b, bool _a)
        {

            if (r == true)
            {
                if (Math.Round(C.GetR() * 255) > 255)
                {
                    this.C.SetR(1.00f);
                }

                if ((C.GetR() * 255) < 0)
                {
                    C.SetR(0.00f);
                }
                C.SetR(C.GetR() + counter1);
            }
            if (_r == true)
            {
                if (Math.Round(C.GetR() * 255) > 255)
                {
                    C.SetR(1.00f);
                }

                if ((C.GetR() * 255) < 0)
                {
                    C.SetR(0.00f);
                }
                C.SetR(C.GetR() - counter1);
            }

            if (g == true)
            {
                if (Math.Round(C.GetG() * 255) > 255)
                {
                    this.C.SetG(1.00f);
                }

                if ((C.GetG() * 255) < 0)
                {
                    C.SetG(0.00f);
                }
                C.SetG(C.GetG() + counter1);
            }
            if (_g == true)
            {
                if (Math.Round(C.GetG() * 255) > 255)
                {
                    C.SetG(1.00f);
                }

                if ((C.GetG() * 255) < 0)
                {
                    C.SetG(0.00f);
                }
                C.SetG(C.GetG() - counter1);
            }

            if (b == true)
            {
                if (Math.Round(C.GetB() * 255) > 255)
                {
                    this.C.SetB(1.00f);
                }

                if ((C.GetB() * 255) < 0)
                {
                    C.SetB(0.00f);
                }
                C.SetB(C.GetB() + counter1);
            }
            if (_b == true)
            {
                if (Math.Round(C.GetB() * 255) > 255)
                {
                    C.SetB(1.00f);
                }

                if ((C.GetB() * 255) < 0)
                {
                    C.SetB(0.00f);
                }
                C.SetB(C.GetB() - counter1);
            }

            if (a == true)
            {
                if (Math.Round(C.GetA() * 255) > 255)
                {
                    this.C.SetA(1.00f);
                }

                if ((C.GetA() * 255) < 0)
                {
                    C.SetA(0.00f);
                }
                C.SetA(C.GetA() + counter1);
            }
            if (_a == true)
            {
                if (Math.Round(C.GetA() * 255) > 255)
                {
                    C.SetA(1.00f);
                }

                if ((C.GetA() * 255) < 0)
                {
                    C.SetA(0.00f);
                }
                C.SetA(C.GetA() - counter1);
            }

            Console.WriteLine("R:" + C.GetR() + ", G:" + C.GetG() + ", B:" + C.GetB() + ", A:" + C.GetA());
        }

        

        public void GetColorsRGBA_XYZ()
        {
            Console.WriteLine("Vertex 1  R:" + A.GetR() + ", G:" + A.GetG() + ", B:" + A.GetB() + ", A:" + A.GetA());
            Console.WriteLine("Vertex 2  R:" + B.GetR() + ", G:" + B.GetG() + ", B:" + B.GetB() + ", A:" + B.GetA());
            Console.WriteLine("Vertex 3  R:" + C.GetR() + ", G:" + C.GetG() + ", B:" + C.GetB() + ", A:" + C.GetA());
        }
    }
}
