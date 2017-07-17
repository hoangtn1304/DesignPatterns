namespace Singleton
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler _chocolateBoiler;
        
        private bool _boiled;
        private bool _empty;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler Instance => _chocolateBoiler ?? (_chocolateBoiler = new ChocolateBoiler());

        public void Fill()
        {
            if (!IsEmpty())
            {
                return;
            }

            _empty = false;
            _boiled = false;

            // fill
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // drain
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // boil
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}