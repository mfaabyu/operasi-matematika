using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operatorSymbol;
            ///kata pertama sambutan yang akan muncul di tampilan awal program///
            Console.WriteLine("Welcome to Calculator");
            Console.WriteLine("--------------------");
            ///line dibawah memunculkan tulisan"Enter the First number"///
            Console.Write("Enter the first number: ");
            ///line dibawah untuk memasukan angka pertama yang ingin kita lakukan penjumalahan, pengurangan, pembagian atau perkalihan///
            num1 = double.Parse(Console.ReadLine());
            ///line dibawah akan menampilkan "(+, -, *, /)" dan kita dapat memlih untuk melakukan pejumlahan(+), pengurangan(-), perkalihan(*), pembagian(/).///
            Console.Write("Enter the operator (+, -, *, /): ");
            ///line dibawah untuk memasukan pilihan kita ingin melakukan penjumalahan, pembagian ataupun  perkalihan///
            operatorSymbol = char.Parse(Console.ReadLine());
            ///line dibawah memunculkan tulisan"Enter the second number"///
            Console.Write("Enter the second number: ");
            ///line dibawah untuk memasukan angka kedua yang ingin kita lakukan penjumalahan, pengurangan, pembagian atau perkalihan///
            num2 = double.Parse(Console.ReadLine());

            switch (operatorSymbol)
            {
                    ///untuk program penjumlahan///
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;
                    ///untuk program pengurangan///
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;
                    ///untuk program perkalian///
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;
                    ///untuk program pembagian///
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    break;
                   ///line ini adalah program jika yang dimasukan bukan sebuah angka/ tidak terdefinisikan///
                default:
                    Console.WriteLine("Invalid operator symbol");
                    break;
            }

            Console.ReadLine();
        }
    }
}