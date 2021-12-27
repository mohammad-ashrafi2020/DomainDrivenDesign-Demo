namespace Calculator
{
    public class Computing
    {
        public string OddOrEven(int value)
        {
            return value % 2 == 0 ? "Even" : "Odd";
        }
        public int CalculateAge(int birthDate, int currentYear)
        {
            if (birthDate < 0)
                return 0;

            if (birthDate == 0 || currentYear == 0)
                throw new ArgumentException();

            return currentYear - birthDate;
        }
        public bool IsPrime(int value)
        {
            if (value < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(value); ++divisor)
            {
                if (value % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}