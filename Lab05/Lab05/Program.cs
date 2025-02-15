using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    interface IVector
    {
        IVector Add(IVector vector);
        IVector Substract(IVector vector);
        IVector Multiply(double scalar);
        IVector Divide(double scalar);
        double Length();
        IVector Normalize();
        double DotProduct(IVector vector);
        IVector CrossProduct(IVector vector);

    }

    class Vector2D : IVector
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Vector2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Vector2D: <x: {X}, y: {Y}>");
        }

        public string Print()
        {
            return $"({this.X}, {this.Y})";
        }

        public IVector Add(IVector vt2)
        {
            if (vt2 is Vector2D v2)
            {
                return new Vector2D(this.X + v2.X, this.Y + v2.Y);
            }
            throw new InvalidOperationException("Cannot add non-Vector2D to Vector2D.");
        }

        public IVector Substract(IVector vt2)
        {
            if (vt2 is Vector2D v2)
            {
                return new Vector2D(this.X - v2.X, this.Y - v2.Y);
            }
            throw new InvalidOperationException("Cannot subtract non-Vector2D from Vector2D.");
        }

        public IVector Multiply(double k)
        {
            return new Vector2D(this.X * k, this.Y * k);
        }

        public IVector Divide(double k)
        {
            return new Vector2D(this.X / k, this.Y / k);
        }

        public double Length()
        {
            double x_2 = Math.Pow(this.X, 2);
            double y_2 = Math.Pow(this.Y, 2);

            return Math.Sqrt(x_2 + y_2);
        }

        public IVector Normalize()
        {
            if (this.Length() != 0)
            {
                return new Vector2D(this.X / this.Length(), this.Y / this.Length());
            }
            else return new Vector2D(0, 0);
        }

        public double DotProduct(IVector vt2)
        {
            if (vt2 is Vector2D v2)
            {
                return (this.X * v2.X + this.Y * v2.Y);
            }
            throw new InvalidOperationException("Cannot calculate dot product with non-Vector2D.");
        }

        public IVector CrossProduct(IVector vt2) => throw new NotSupportedException("Cross product is not defined for 2D vectors.");
        
    }

    class Vector3D : IVector
    {
        private double x;
        private double y;
        private double z;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public Vector3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Vector3D: <x: {X}, y: {Y}, z: {Z}>");
        }

        public string Print()
        {
            return $"({this.X}, {this.Y}, {this.Z})";
        }

        public IVector Add(IVector vt2)
        {
            if (vt2 is Vector3D v2)
            {
                return new Vector2D(this.X + v2.X, this.Y + v2.Y);
            }
            throw new InvalidOperationException("Cannot add non-Vector3D to Vector3D.");
        }

        public IVector Substract(IVector vt2)
        {
            if (vt2 is Vector3D v2)
            {
                return new Vector3D(this.X - v2.X, this.Y - v2.Y, this.Z - v2.Z);
            }
            throw new InvalidOperationException("Cannot subtract non-Vector3D from Vector3D.");
        }

        public IVector Multiply(double k)
        {
            return new Vector3D(this.X * k, this.Y * k, this.Z * k);
        }

        public IVector Divide(double k)
        {
            return new Vector3D(this.X / k, this.Y / k, this.Z / k);
        }

        public double Length()
        {
            double x_2 = Math.Pow(this.X, 2);
            double y_2 = Math.Pow(this.Y, 2);
            double z_2 = Math.Pow(this.Z, 2);

            return Math.Sqrt(x_2 + y_2 + z_2);
        }

        public IVector Normalize()
        {
            if (this.Length() != 0)
            {
                return new Vector3D(this.X / this.Length(), this.Y / this.Length(), this.Z / this.Length());
            }
            else return new Vector3D(0, 0, 0);

        }

        public double DotProduct(IVector vt2)
        {
            if (vt2 is Vector3D v2)
            {
                return (this.X * v2.X + this.Y * v2.Y + this.Z * v2.Z);
            }
            throw new InvalidOperationException("Cannot calculate dot product with non-Vector3D.");
        }

        public IVector CrossProduct(IVector vt2)
        {
            if (vt2 is Vector3D v2)
            {
                return new Vector3D(
                this.Y * v2.Z - this.Z * v2.Y,
                this.Z * v2.X - this.X * v2.Z,
                this.X * v2.Y - this.Y * v2.X);
            }
            throw new InvalidOperationException("Cannot calculate cross product with non-Vector3D."); 

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
