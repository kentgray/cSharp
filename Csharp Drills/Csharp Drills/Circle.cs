using System;


namespace Csharp_Drills
{
    class Circle
    {
        static float _PI = 3.141f;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return _PI * _Radius * _Radius;
        }
    }
}
