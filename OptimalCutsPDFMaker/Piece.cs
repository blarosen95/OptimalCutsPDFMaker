using System;

namespace OptimalCutsPDFMaker
{
    public class Piece
    {
        private double _length;
        private double _width;

        public Piece(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public int HashCode()
        {
            const int prime = 31;
            // int result = 1;
            long temp;

            temp = BitConverter.DoubleToInt64Bits(_length);
            // result = prime * result + (int)((ulong)temp ^ ((ulong)temp >> 32));
            int result = prime + (int)((ulong)temp ^ ((ulong)temp >> 32));

            temp = BitConverter.DoubleToInt64Bits(_width);
            // result = prime * result + (int)((ulong)temp ^ ((ulong)temp >> 32));
            // return result;

            return prime * result + (int)((ulong)temp ^ ((ulong)temp >> 32));
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            Piece other = (Piece)obj;

            return BitConverter.DoubleToInt64Bits(_length) == BitConverter.DoubleToInt64Bits(other._length) &&
                   BitConverter.DoubleToInt64Bits(_width) == BitConverter.DoubleToInt64Bits(other._width);
        }

        public override string ToString()
        {
            return $"Piece {HashCode()} ({_width},{_length})";
        }
    }
}