    using System;

    namespace MoneyClass
    {
        class Money
        {
            private Dictionary<int, uint> rubles;

            public Money()
            {
                rubles = new Dictionary<int, uint>
                {
                    {500000, 0},
                    {100000, 0},
                    {50000, 0},
                    {20000, 0},
                    {10000, 0},
                    {5000, 0},
                    {1000, 0},
                    {500, 0},
                    {200, 0},
                    {100, 0},
                    {10, 0},
                    {5, 0},
                    {1, 0}
                };
            }

            public Money(Money other)
            {
                if (other is null)
                    throw new ArgumentNullException(nameof(other), "Source money cannot be null");
                rubles = new Dictionary<int, uint>(other.rubles);
            }

            public double MakeSum()
            {
                double sum = 0;
                foreach (var i in rubles)
                    sum += i.Key * i.Value;
                sum = sum / 100;
                return sum;
            }

            public void SetCount()
            {
                foreach (var i in rubles)
                {
                    Console.Write($"Enter the count for {i.Key}: ");
                    uint cnt = Convert.ToUInt32(Console.ReadLine());
                    rubles[i.Key] = cnt;
                }
            }

            public override bool Equals(object? obj)
            {
                if (obj is null || !(obj is Money))
                    return false;

                return this == (Money)obj;
            }

            public override int GetHashCode()
            {
                return MakeSum().GetHashCode();
            }

            public static double operator +(Money m1, Money m2)
            {
                if (m1 is null || m2 is null)
                    throw new ArgumentNullException("Money object cannot be null");
                return Math.Round(m1.MakeSum() + m2.MakeSum(), 2);
            }

            public static double operator -(Money m1, Money m2)
            {
                if (m1 is null || m2 is null)
                    throw new ArgumentNullException("Money object cannot be null");
                return Math.Round(m1.MakeSum() - m2.MakeSum(), 2); ;
            }

            public static double operator /(Money m1, Money m2)
            {
                if (m1 is null || m2 is null)
                    throw new ArgumentNullException("Money object cannot be null");
                if (m2.MakeSum() == 0)
                    throw new DivideByZeroException("Money object cannot be null");
                return Math.Round(m1.MakeSum() / m2.MakeSum(), 2);
            }

            public static double operator /(Money money, double divisor)
            {
                if (money is null)
                    throw new ArgumentNullException("Money object cannot be null");
                if (Math.Abs(divisor) < 0.000001)
                    throw new DivideByZeroException("Divisor cannot be zero");
                if (divisor < 0)
                    throw new ArgumentException("Divisor cannot be negative for money division");
                return Math.Round(money.MakeSum() / divisor, 2);
            }

            public static double operator *(Money money, double divisor)
            {
                if (money is null)
                    throw new ArgumentNullException("Money object cannot be null");
                if (Math.Abs(divisor) < 0.000001)
                    throw new DivideByZeroException("Divisor cannot be zero");
                if (divisor < 0)
                    throw new ArgumentException("Divisor cannot be negative for money division");
                return Math.Round(money.MakeSum() * divisor, 2);
            }

            public static bool operator >(Money m1, Money m2)
            {
                if (m1 is null || m2 is null)
                    return false;
                return m1.MakeSum() > m2.MakeSum();
            }

            public static bool operator <(Money m1, Money m2)
            {
                if (m1 is null || m2 is null)
                    return false;
                return m1.MakeSum() < m2.MakeSum();
            }

            public static bool operator >=(Money m1, Money m2)
            {
                if (m1 is null || m2 is null)
                    return false;
                return m1.MakeSum() >= m2.MakeSum();
            }

            public static bool operator <=(Money m1, Money m2)
            {
                if (m1 is null || m2 is null)
                    return false;
                return m1.MakeSum() <= m2.MakeSum();
            }
            public static bool operator ==(Money m1, Money m2)
            {
                if (m1 is null || m2 is null) return false;
                return m1.MakeSum() == m2.MakeSum();
            }
            public static bool operator !=(Money m1, Money m2)
            {
                return !(m1 == m2);
            }

            public static bool operator >(Money money, double rub)
            {
                if (money is null) return false;
                return money.MakeSum() > rub;
            }

            public static bool operator <(Money money, double rub)
            {
                if (money is null) return false;
                return money.MakeSum() < rub;
            }

            public static bool operator ==(Money money, double rub)
            {
                if (money is null) return false;
                return money.MakeSum() == rub;
            }

            public static bool operator !=(Money money, double rub) => !(money == rub);

            public static bool operator >=(Money money, double rub) => money > rub || money == rub;

            public static bool operator <=(Money money, double rub) => money < rub || money == rub;
        };
    }