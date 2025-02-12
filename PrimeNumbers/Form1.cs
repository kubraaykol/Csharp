namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int number;
        List<int> primeNumbers = new List<int>();
        bool isPrime = false;
        private void btnList_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(txtNumber.Text);
            isPrime = AsalMi3(number);
            if (isPrime == true)
            {
                MessageBox.Show($"{number} asalsayýdýr");

            }
            else
            {
                MessageBox.Show($"{number}asal sayý deðildir");
            }
        }

        bool AsalMi(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }

        bool AsalMi2(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 0; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        bool AsalMi3(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        List<int> GetPrimes(int number)
        {
            List<int> primes = new List<int>();
            if (number >= 2)
            {
                primes.Add(2);
            }

            for (int i = 3; i <= number; i++)
            {
                isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtNumber.Text);
            primeNumbers = GetPrimes(sayi);
            //lstPrimeNumbers.Items.Clear();
            //foreach (var item in primeNumberss) {
            //lstPrimeNumbers.Items.Add.(item);
            //}
            lstPrimeNumber.DataSource = primeNumbers;

        }
    }
}
