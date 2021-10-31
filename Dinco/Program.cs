using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Drawing;

namespace Dinco
{
    internal class Window3D : GameWindow
    {
        Axe xyz;
        Triunghi trg;
        Cub cub;

        private Window3D() : base(800, 600, new GraphicsMode(32, 24, 0, 8))
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);
            GL.Hint(HintTarget.PolygonSmoothHint, HintMode.Nicest);

            xyz = new Axe();
            trg = new Triunghi();
            cub = new Cub("D:\\01_Facultate An III\\Semestrul I\\EGC\\Laboratoare\\Proiecte\\Lab 4\\Dinco\\Dinco\\coordonate_cub.txt", "D:\\01_Facultate An III\\Semestrul I\\EGC\\Laboratoare\\Proiecte\\Lab 4\\Dinco\\Dinco\\culori.txt");
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(30, 30, 30, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();

            /// Lab 4 Problema 1

            //////   FATA 1



            if (keyboard[Key.W])
            {
                cub.ChangeColorsFace1(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.Q])
            {
                cub.ChangeColorsFace1(false, false, false, false, true, false, false, false);
            }

            if (keyboard[Key.S])
            {
                cub.ChangeColorsFace1(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.A])
            {
                cub.ChangeColorsFace1(false, false, false, false, false, true, false, false);
            }

            if (keyboard[Key.X])
            {
                cub.ChangeColorsFace1(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.Z])
            {
                cub.ChangeColorsFace1(false, false, false, false, false, false, true, false);
            }

            if (keyboard[Key.Number2])
            {
                cub.ChangeColorsFace1(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Number1])
            {
                cub.ChangeColorsFace1(false, false, false, false, false, false, false, true);
            }


            //////   FATA 2



            if (keyboard[Key.R])
            {
                cub.ChangeColorsFace2(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.E])
            {
                cub.ChangeColorsFace2(false, false, false, false, true, false, false, false);
            }

            if (keyboard[Key.F])
            {
                cub.ChangeColorsFace2(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.D])
            {
                cub.ChangeColorsFace2(false, false, false, false, false, true, false, false);
            }

            if (keyboard[Key.V])
            {
                cub.ChangeColorsFace2(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.C])
            {
                cub.ChangeColorsFace2(false, false, false, false, false, false, true, false);
            }

            if (keyboard[Key.Number4])
            {
                cub.ChangeColorsFace2(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Number3])
            {
                cub.ChangeColorsFace2(false, false, false, false, false, false, false, true);
            }



            //////    FATA 3

            if (keyboard[Key.Y])
            {
                cub.ChangeColorsFace3(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.T])
            {
                cub.ChangeColorsFace3(false, false, false, false, true, false, false, false);
            }

            if (keyboard[Key.H])
            {
                cub.ChangeColorsFace3(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.G])
            {
                cub.ChangeColorsFace3(false, false, false, false, false, true, false, false);
            }

            if (keyboard[Key.N])
            {
                cub.ChangeColorsFace3(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.B])
            {
                cub.ChangeColorsFace3(false, false, false, false, false, false, true, false);
            }

            if (keyboard[Key.Number6])
            {
                cub.ChangeColorsFace3(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Number5])
            {
                cub.ChangeColorsFace3(false, false, false, false, false, false, false, true);
            }


            //////   FATA 4


            if (keyboard[Key.I])
            {
                cub.ChangeColorsFace4(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.U])
            {
                cub.ChangeColorsFace4(false, false, false, false, true, false, false, false);
            }

            if (keyboard[Key.K])
            {
                cub.ChangeColorsFace4(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.J])
            {
                cub.ChangeColorsFace4(false, false, false, false, false, true, false, false);
            }

            if (keyboard[Key.Comma])
            {
                cub.ChangeColorsFace4(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.M])
            {
                cub.ChangeColorsFace4(false, false, false, false, false, false, true, false);
            }

            if (keyboard[Key.Number8])
            {
                cub.ChangeColorsFace4(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Number7])
            {
                cub.ChangeColorsFace4(false, false, false, false, false, false, false, true);
            }


            //////   FATA 5


            if (keyboard[Key.P])
            {
                cub.ChangeColorsFace5(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.O])
            {
                cub.ChangeColorsFace5(false, false, false, false, true, false, false, false);
            }

            if (keyboard[Key.Semicolon])
            {
                cub.ChangeColorsFace5(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.L])
            {
                cub.ChangeColorsFace5(false, false, false, false, false, true, false, false);
            }

            if (keyboard[Key.Slash])
            {
                cub.ChangeColorsFace5(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.Period])
            {
                cub.ChangeColorsFace5(false, false, false, false, false, false, true, false);
            }

            if (keyboard[Key.Number0])
            {
                cub.ChangeColorsFace5(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Number9])
            {
                cub.ChangeColorsFace5(false, false, false, false, false, false, false, true);
            }


            //////    FATA 6


            if (keyboard[Key.BracketRight])
            {
                cub.ChangeColorsFace6(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.BracketLeft])
            {
                cub.ChangeColorsFace6(false, false, false, false, true, false, false, false);
            }

            if (keyboard[Key.BackSlash])
            {
                cub.ChangeColorsFace6(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.Quote])
            {
                cub.ChangeColorsFace6(false, false, false, false, false, true, false, false);
            }

            if (keyboard[Key.ControlRight])
            {
                cub.ChangeColorsFace6(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.AltRight])
            {
                cub.ChangeColorsFace6(false, false, false, false, false, false, true, false);
            }

            if (keyboard[Key.Minus])
            {
                cub.ChangeColorsFace6(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Plus])
            {
                cub.ChangeColorsFace6(false, false, false, false, false, false, false, true);
            }


            /// Lab 4 Problema 2

            ///    Triunghi
            ///    Vertex 1

            ///    Vertex 1 Canal R
            if (keyboard[Key.Keypad8])
            {
                trg.ChangeColor4VertexA(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.Keypad7])
            {
                trg.ChangeColor4VertexA(false, false, false, false, true, false, false, false);
            }

            ///    Vertex 1 Canal G

            if (keyboard[Key.Keypad5])
            {
                trg.ChangeColor4VertexA(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.Keypad4])
            {
                trg.ChangeColor4VertexA(false, false, false, false, false, true, false, false);
            }

            ///    Vertex 1 Canal B

            if (keyboard[Key.Keypad2])
            {
                trg.ChangeColor4VertexA(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.Keypad1])
            {
                trg.ChangeColor4VertexA(false, false, false, false, false, false, true, false);
            }

            ///    Vertex 1 Canal A

            if (keyboard[Key.Keypad0])
            {
                trg.ChangeColor4VertexA(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Up])
            {
                trg.ChangeColor4VertexA(false, false, false, false, false, false, false, true);
            }


            ///    Vertex 2

            ///    Vertex 2 Canal R
            if (keyboard[Key.NumLock])
            {
                trg.ChangeColor4VertexB(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.KeypadDivide])
            {
                trg.ChangeColor4VertexB(false, false, false, false, true, false, false, false);
            }

            ///    Vertex 2 Canal G

            if (keyboard[Key.KeypadMultiply])
            {
                trg.ChangeColor4VertexB(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.KeypadSubtract])
            {
                trg.ChangeColor4VertexB(false, false, false, false, false, true, false, false);
            }

            ///    Vertex 2 Canal B

            if (keyboard[Key.PrintScreen])
            {
                trg.ChangeColor4VertexB(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.Home])
            {
                trg.ChangeColor4VertexB(false, false, false, false, false, false, true, false);
            }

            ///    Vertex 2 Canal A

            if (keyboard[Key.Pause])
            {
                trg.ChangeColor4VertexB(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.Delete])
            {
                trg.ChangeColor4VertexB(false, false, false, false, false, false, false, true);
            }


            ///    Vertex 3


            ///    Vertex 3 Canal R
            if (keyboard[Key.F1])
            {
                trg.ChangeColor4VertexC(true, false, false, false, false, false, false, false);
            }

            if (keyboard[Key.F2])
            {
                trg.ChangeColor4VertexC(false, false, false, false, true, false, false, false);
            }

            ///    Vertex 3 Canal G

            if (keyboard[Key.F3])
            {
                trg.ChangeColor4VertexC(false, true, false, false, false, false, false, false);
            }

            if (keyboard[Key.F4])
            {
                trg.ChangeColor4VertexC(false, false, false, false, false, true, false, false);
            }

            ///    Vertex 3 Canal B

            if (keyboard[Key.F5])
            {
                trg.ChangeColor4VertexC(false, false, true, false, false, false, false, false);
            }

            if (keyboard[Key.F6])
            {
                trg.ChangeColor4VertexC(false, false, false, false, false, false, true, false);
            }

            ///    Vertex 3 Canal A

            if (keyboard[Key.F7])
            {
                trg.ChangeColor4VertexC(false, false, false, true, false, false, false, false);
            }

            if (keyboard[Key.F8])
            {
                trg.ChangeColor4VertexC(false, false, false, false, false, false, false, true);
            }

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            KeyboardState key = Keyboard.GetState();

            xyz.DrawAxe();

            //trg.GetColorsRGBA_XYZ();

            trg.DrawTriunghi();


            if(key[Key.Tab])
            {
                cub.DrawCub();
            }
            
            if(key[Key.Grave])
            {
                cub.SetColorsRandom();
            }



            SwapBuffers();
        }


        static void Main(string[] args)
        {
            using (Window3D example = new Window3D())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}
