using OpenTK.Graphics;
using System.Drawing;
using System;

namespace Dinco
{
    class Vertex
    {
        private double X;
        private double Y;
        private double Z;
        private Color Colour;
        private Color4 Colour4;
        private float r;
        private float g;
        private float b;
        private float a;

        public Vertex()
        {
            X = 0;
            Y = 0;
            Z = 0;
            r = 1;
            g = 1;
            b = 1;
            a = 1;
            Colour = Color.Black;
            Colour4 = Color4.Black;
        }

        public Vertex(double _x, double _y, double _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
            r = 1;
            g = 1;
            b = 1;
            a = 1;
            Colour = Color.Black;
            Colour4 = Color4.Black;
        }

        public Vertex(double _x, double _y, double _z, Color _color)
        {
            X = _x;
            Y = _y;
            Z = _z;
            Colour = _color;
            r = _color.R;
            g = _color.G;
            b = _color.B;
            a = _color.A;
        }

        public Vertex(double _x, double _y, double _z, Color4 _color)
        {
            X = _x;
            Y = _y;
            Z = _z;
            Colour4 = _color;
            r = _color.R;
            g = _color.G;
            b = _color.B;
            a = _color.A;
        }

        public void SetColor(Color _color)
        {
            Colour = _color;
            r = _color.R;
            g = _color.G;
            b = _color.B;
            a = _color.A;
        }
        public void SetColor4(Color4 _color)
        {
            Colour4 = _color;
            r = _color.R;
            g = _color.G;
            b = _color.B;
            a = _color.A;
        }

        public void SetColor4RGBA(float _r, float _g, float _b, float _a)
        {
            r = _r;
            g = _g;
            b = _b;
            a = _a;
        }

        public Color GetColor()
        {
            return Colour;
        }

        public Color4 GetColor4()
        {
            return Colour4;
        }

        public void SetX(double _x)
        {
            X = _x;
        }

        public void SetY(double _y)
        {
            Y = _y;
        }

        public void SetZ(double _z)
        {
            Z = _z;
        }

        public double GetX()
        {
            return X;
        }

        public double GetY()
        {
            return Y;
        }

        public double GetZ()
        {
            return Z;
        }

        public void SetR(float _r)
        {
            r = _r;
        }

        public void SetG(float _g)
        {
            g = _g;
        }

        public void SetB(float _b)
        {
            b = _b;
        }

        public void SetA(float _a)
        {
            a = _a;
        }

        public float GetR()
        {
            return r;
        }

        public float GetG()
        {
            return g;
        }

        public float GetB()
        {
            return b;
        }

        public float GetA()
        {
            return a;
        }
    }
}
