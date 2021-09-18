namespace OptimalCutsPDFMaker
{
    public class Settings
    {
        private double _length;
        private double _width;

        public Settings(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public void Deconstruct(out double length, out double width)
        {
            length = _length;
            width = _width;
        }
    }
}