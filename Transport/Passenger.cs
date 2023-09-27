using System;

namespace Transportation.Transport
{
    public class Passenger 
    {
        private string _name;
        private int _age;
        public bool HasPreferential;

        public int Age
        {
            get { return _age; }
            private set
            {
                if (value > 0)
                {
                    _age = value; 
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0.");
                }
            }
        }
        public Passenger(string name, int age, bool hasPreferential)
        {
            _name = name;
            Age = age;
            HasPreferential = hasPreferential;
        }
    }
}
