using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Dinco
{
    class Axe
    {

        private int dim;
        public Axe()
        {
            dim = 30;
        }

        public Axe(int _dim)
        {
            dim = _dim;
        }

        public void DrawAxe()
        {

            // Set color/coords for Ox.
            GL.Color3(Color.Red);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(dim, 0, 0);
            GL.End();

            // Set color/coords for Oy.
            GL.Color3(Color.Green);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, dim, 0);
            GL.End();

            // Set color/coords for Oz.
            GL.Color3(Color.Blue);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, dim);
            GL.End();
        }
    }
}
