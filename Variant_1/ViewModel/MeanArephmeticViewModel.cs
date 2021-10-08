using System;
using System.Windows;
using System.Windows.Input;

namespace Variant_1.ViewModel
{
    public class MeanArephmeticViewModel: ViewModelBase
    {
        private const int MAX_RANDOM_VALUE = 100;
        
        private float calcNumbers(int[] numbers)
        {
            int sum = 0;
            float average = 0;
            foreach (var number in numbers) sum += number;
            if (numbers.Length != 0 & sum != 0) average = sum / numbers.Length;
            return average;
        }

        private string getRandomNumbers()
        {
            Random random = new Random();
            return random.Next(MAX_RANDOM_VALUE) + ", " + random.Next(MAX_RANDOM_VALUE) + ", " + random.Next(MAX_RANDOM_VALUE);
        }

        private int[] parseInput(string input)
        {
            string[] rawNumbers = input.Split(',');
            int[] numbers = new int[rawNumbers.Length];
            for (int i = 0; i < rawNumbers.Length; i++)
            {
                int number;
                if (int.TryParse(rawNumbers[i], out number))
                {
                    numbers[i] = number;
                }
                else
                {
                    numbers[i] = 0;
                }
            }
            return numbers;
        }

        private bool isValidInput(string input)
        {
            int[] numbers = parseInput(input);
            if (numbers != null & numbers.Length > 1)
            {
                return true;
            }

            return false;
        }

        private void calc(string input)
        {
            if (isValidInput(input))
            {
                int[] numbers = parseInput(input);
                resultValue = "Результат выполнения: "+calcNumbers(numbers);
            }
            else
            {
                resultValue = "Не правильно ввели числа";
            }
        }

        private string _inputValue = "Введите числа через запятую";

        public string inputValue
        {
            get
            {
                return _inputValue;
            }
            set
            {
                _inputValue = value;
                try
                {
                    calc(value);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace);
                }
                OnPropertyChanged();
            }
        }

        private string _resultValue = "Результат решения";

        public string resultValue
        {
            get
            {
                return _resultValue;
            }
            set
            {
                _resultValue = value;
                OnPropertyChanged();
            }
        }

        public ICommand RandomButtonOnClickEvent
        {
            get
            {
                return new DelegateCommand(o =>
                {
                    inputValue = getRandomNumbers();
                });
            }
        }
    }
}