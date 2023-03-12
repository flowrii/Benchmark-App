using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class FormInstruction : Form
    {
        public FormInstruction()
        {
            InitializeComponent();
            testInstructionsSpeed();
        }

        public static List<int> GeneratePrimesNaive(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }

        public static List<int> GenerateFibonacciNumbers(int n)
        {
            List<int> fibo = new List<int>();
            fibo.Add(0);
            fibo.Add(1);
            for (int i = 2; i < n; i++)
            {
                fibo.Add(fibo.ElementAt(i - 2) + fibo.ElementAt(i - 1));
            }
            return fibo;
        }

        void testInstructionsSpeed()
        {
            instrTextBox.AppendText("\r\nInstructions execution speed: \r\n");

            var iterations = 100;
            var random = new Random();

            int inb1, inb2, ires;
            double dnb1, dnb2, dres;
            bool b1, b2, bres;

            Stopwatch watch;
            double rez = 0;
            
            instrTextBox.AppendText("\r\n*ADDITION*: \r\n");
            instrTextBox.AppendText("-> Double numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                dnb1 = random.NextDouble();
                dnb2 = random.NextDouble();

                watch = Stopwatch.StartNew();
                dres = dnb1 + dnb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("-> Integer numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                inb1 = random.Next();
                inb2 = random.Next();

                watch = Stopwatch.StartNew();
                ires = inb1 + inb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();


            rez = 0;
            instrTextBox.AppendText("\r\n*SUBTRACTION*: \r\n");
            instrTextBox.AppendText("-> Double numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                dnb1 = random.NextDouble();
                dnb2 = random.NextDouble();

                watch = Stopwatch.StartNew();
                dres = dnb1 - dnb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("-> Integer numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                inb1 = random.Next();
                inb2 = random.Next();

                watch = Stopwatch.StartNew();
                ires = inb1 - inb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();


            rez = 0;
            instrTextBox.AppendText("\r\n*MULTIPLICATION*: \r\n");
            instrTextBox.AppendText("-> Double numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                dnb1 = random.NextDouble();
                dnb2 = random.NextDouble();

                watch = Stopwatch.StartNew();
                dres = dnb1 * dnb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("-> Integer numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                inb1 = random.Next();
                inb2 = random.Next();

                watch = Stopwatch.StartNew();
                ires = inb1 * inb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();


            rez = 0;
            instrTextBox.AppendText("\r\n*DIVISION*: \r\n");
            instrTextBox.AppendText("-> Double numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                dnb1 = random.NextDouble();
                dnb2 = random.NextDouble();

                watch = Stopwatch.StartNew();
                dres = dnb1 / dnb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("-> Integer numbers: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                inb1 = random.Next();
                inb2 = random.Next();

                watch = Stopwatch.StartNew();
                ires = inb1 / inb2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("\r\n*AND*: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                b1 = random.Next() > (Int32.MaxValue / 2);
                b2 = random.Next() > (Int32.MaxValue / 2);

                watch = Stopwatch.StartNew();
                bres = b1 & b2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("\r\n*OR*: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                b1 = random.Next() > (Int32.MaxValue / 2);
                b2 = random.Next() > (Int32.MaxValue / 2);

                watch = Stopwatch.StartNew();
                bres = b1 | b2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("\r\n*XOR*: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                b1 = random.Next() > (Int32.MaxValue / 2);
                b2 = random.Next() > (Int32.MaxValue / 2);

                watch = Stopwatch.StartNew();
                bres = b1 ^ b2;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("\r\n*NOT*: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                b1 = random.Next() > (Int32.MaxValue / 2);

                watch = Stopwatch.StartNew();
                bres = !b1;
                watch.Stop();

                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{ Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("\r\n*Generate first 1000 primes*: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                watch = Stopwatch.StartNew();
                List<int> primes = GeneratePrimesNaive(1000);
                watch.Stop();
                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();

            rez = 0;
            instrTextBox.AppendText("\r\n*Generate first 1000 fibonacci numbers*: \r\n");
            for (int it = 1; it <= iterations; it++)
            {
                watch = Stopwatch.StartNew();
                List<int> primes = GenerateFibonacciNumbers(1000);
                watch.Stop();
                rez += watch.ElapsedTicks;
            }
            instrTextBox.AppendText($"\tAverage:\t{Math.Round(rez / iterations, 3)} ticks\r\n");
            instrTextBox.Invalidate();
        }
    }
}
