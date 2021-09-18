namespace OptimalCutsPDFMaker
{
    public class Panel
    {
        public double _x1;
        public double _x2;
        public double _y1;
        public double _y2;
        private bool _free;

        public Panel(double x1, double y1, double x2, double y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public void SetFree(bool free)
        {
            _free = free;
        }

        public bool IsFree()
        {
            return _free;
        }

        public override string ToString()
        {
            return $"[{_x1},{_y1},{_x2},{_y2},{_free}]";
        }
    }
}