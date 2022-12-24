using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices;
using System.IO.Compression;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LEVEL 1
            {
                #region Task 6
                {
                    WriteLine("Enter 5 numbers");
                    double[] a = new double[5];

                    for (int i = 0; i < a.Length; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }
                    double l = 0;

                    for (int i = 0; i < a.Length; i++)
                    {
                        l += Math.Pow(a[i], 2);
                    }
                    WriteLine($"Vector length = {Math.Sqrt(l)}");
                }
                #endregion

                #region Task 10
                {
                    double[] mas = new double[10];
                    WriteLine("Enter 10 numbers");
                    for (int i = 0; i < mas.Length; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        mas[i] = x;
                    }

                    WriteLine("Enter p");
                    int p = 0;
                    int.TryParse(ReadLine(), out p);
                    WriteLine("Enter q");
                    int q = 0;
                    int.TryParse(ReadLine(), out q);

                    int count = 0;
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if ((mas[i] >= p) && (mas[i] <= q))
                        {
                            count++;
                        }
                    }
                    WriteLine($"Count of numbers = {count}");
                }
                #endregion

                #region Task 11
                {
                    double[] mas = new double[10];
                    WriteLine("Enter 10 numbers");
                    for (int i = 0; i < mas.Length; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        mas[i] = x;

                    }
                    double[] arr = Array.FindAll(mas, i => i > 0);
                    foreach (double s in arr) Write(s + " ");
                }
                #endregion

                #region Task 12
                {
                    double[] mas = new double[8];
                    double z = 0, n = 0;
                    WriteLine("Enter 8 numbers");
                    for (int i = 0; i < mas.Length; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        mas[i] = x;

                        if (mas[i] < 0)
                        {
                            z = mas[i];
                            n = i;
                        }
                    }
                    WriteLine($"Last negative element = {z} ,number of last element = {n}");
                }
                #endregion

                #region Task 13
                {
                    double[] mas = new double[8];
                    WriteLine("Enter 8 numbers");
                    for (int i = 0; i < mas.Length; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        mas[i] = x;

                    }

                    double[] even = Array.FindAll(mas, i => i % 2 == 0);
                    double[] uneven = Array.FindAll(mas, i => i % 2 != 0);

                    WriteLine("Even numbers: ");
                    foreach (double s in even)
                    {
                        Write(s + " ");
                    }

                    WriteLine("\nUneven numbers: ");
                    foreach (double s in uneven)
                    {
                        Write(s + " ");
                    }
                }
                #endregion
            }
            #endregion

            #region LEVEL 2
            {
                #region Task 5
                {
                    WriteLine("Enter length of massive");
                    int n = 0;
                    int.TryParse(ReadLine(), out n);
                    double[] a = new double[n];

                    WriteLine("Enter massive's values");
                    for (int i = 0; i < n; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    double[] negative = new double[n];

                    double max = a[0];
                    double min = a[0];
                    int min1 = 0;
                    int max1 = 0;

                    for (int i = 0; i < n; i++)
                    {
                        if (a[i] > max)
                        {
                            max = a[i];
                            max1 = i;
                        }

                        if (a[i] < min)
                        {
                            min = a[i];
                            min1 = i;
                        }
                    }

                    a[max1] = 1;
                    a[min1] = 1;
                    int k = 1;

                    for (int i = 0; i < n; i++)
                    {
                        if (a[i] < 0)
                        {
                            negative[k] = a[i];
                            k++;
                        }
                    }

                    negative[0] = min;
                    negative[k] = max;

                    WriteLine("Answer: ");
                    for (int i = 0; i < k + 1; i++)
                    {
                        WriteLine("{0}", negative[i]);
                    }

                }
                #endregion

                #region Task 6
                {
                    WriteLine("Enter legth of massive");
                    int n = 0;
                    int.TryParse(ReadLine(), out n);
                    double[] a = new double[n];

                    WriteLine("Enter massive's values");
                    for (int i = 0; i < n; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    int indexP = 0;
                    WriteLine("Enter P: ");
                    double P = 0;
                    double.TryParse(ReadLine(), out P);

                    double avg = a.Sum() / n;

                    for (int i = 0; i < n - 1; i++)
                    {
                        if (a[i] < avg & avg < a[i + 1])
                        {
                            indexP = i + 1;
                        }
                    }

                    Array.Resize(ref a, n + 1);
                    for (int i = n - 1; i >= indexP - 1; i--)
                    {
                        a[i + 1] = a[i];
                    }

                    a[indexP] = P;

                    WriteLine("Answer: ");
                    for (int i = 0; i < n + 1; i++)
                    {
                        Write(a[i] + "\t");
                    }

                }
                #endregion

                #region Task 9
                {
                    WriteLine("Enter length of massive");
                    int n = 0;
                    int.TryParse(ReadLine(), out n);
                    double[] a = new double[n];

                    WriteLine("Enter massive's values");
                    for (int i = 0; i < n; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    double max = a[0], min = a[0], sum = 0, count = 0;
                    int max1 = 0, min1 = 0, k = 0;
                    foreach (double x in a)
                    {
                        if (x > max)
                        {
                            max = x;
                            max1 = k;
                        }

                        if (x < min)
                        {
                            min = x;
                            min1 = k;
                        }
                        k++;
                    }

                    if (max1 > min1)
                    {
                        for (int i = min1; i < max1 + 1; i++)
                        {
                            sum += a[i];
                            count++;
                        }
                    }
                    else if (min1 > min1)
                    {
                        for (int i = max1; i < min1 + 1; i++)
                        {
                            sum += a[i];
                            count++;
                        }
                    }
                    WriteLine("Answer: ");
                    if (count != 0)
                    {
                        WriteLine(sum / count);
                    }
                    else WriteLine(max);
                }
                #endregion

                #region Task 10
                {
                    int min, min1;
                    min1 = 0;

                    Write("Enter lenght of massive: ");
                    int n;
                    if (Int32.TryParse(ReadLine(), out n))
                    {
                        int[] a = new int[n];

                        WriteLine("Enter massive's values");
                        for (int i = 0; i < n; i++)
                        {
                            Int32.TryParse(ReadLine(), out a[i]);
                        }
                        min = a[0];

                        for (int i = 0; i < n; i++)
                        {
                            if (a[i] > 0 && min > a[i])
                            {
                                min = a[i];
                                min1 = i;
                            }
                        }

                        int[] a2 = new int[n - 1];
                        for (int i = 1; i < n; i++)
                        {
                            a2[i - 1] = a[i - 1];
                            if ((i - 1) >= min1)
                            {
                                a2[i - 1] = a[i];
                            }
                        }

                        WriteLine($"Answer for Task 10: ");
                        for (int i = 0; i < n; i++)
                        {
                            WriteLine(a2[i]);
                        }
                    }

                }
                #endregion

                #region Task 11
                {
                    Write("Enter P: ");
                    int P = 0;
                    int.TryParse(ReadLine(), out P);

                    WriteLine("Enetr length of massive: ");
                    int l = 0;
                    int.TryParse(ReadLine(), out l);

                    double[] a = new double[l + 1];
                    int max = -1;

                    WriteLine("Fill in the massive");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        a[i] = double.Parse(ReadLine());

                        if (a[i] > 0)
                        {
                            max = i;
                        }
                    }

                    for (int i = l; i > max + 1; i--)
                    {
                        a[i] = a[i - 1];
                    }
                    a[max + 1] = P;

                    foreach (double s in a)
                    {
                        Write(s + " ");
                    }
                }
                #endregion

                #region Task 13
                {
                    WriteLine("Enetr length of massive: ");
                    int l = 0;
                    int.TryParse(ReadLine(), out l);

                    double[] a = new double[l];
                    int max = -1;
                    double maxnumber = -10000000;

                    WriteLine("Fill in the massive");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;

                        if (a[i] > maxnumber && i % 2 == 0)
                        {
                            max = i;
                        }
                    }
                    a[max] = max;
                    foreach (double s in a)
                    {
                        Write(s + " ");
                    }
                }
                #endregion

                #region Task 15
                {
                    WriteLine("Enter length of A massive: ");
                    int n = 0;
                    int.TryParse(ReadLine(), out n);
                    double[] a = new double[n];

                    WriteLine("Fill in the massive A");
                    for (int i = 0; i < n; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    WriteLine();

                    WriteLine("Enter length of B massive");
                    int k = 0;
                    int.TryParse(ReadLine(), out k);
                    double[] b = new double[k];

                    WriteLine("Fill in the massive B");
                    for (int i = 0; i < k; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        b[i] = x;
                    }
                    WriteLine("Enter index");
                    int d = 0;
                    int.TryParse(ReadLine(), out d);

                    double[] ab = new double[k + n + 5]; //a+b massive

                    for (int i = 0; i < d + 1; i++)
                    {
                        ab[i] = a[i];
                    }

                    int counter = 0;

                    for (int i = d + 1; i < (d + k + 1) + 1; i++)
                    {
                        ab[i] = b[counter];
                        counter++;
                    }

                    counter = d + 1;

                    for (int i = d + k + 2; i < d + k + (n - d) + 2; i++)
                    {
                        ab[i] = a[counter];
                        counter++;
                    }
                    WriteLine("Answer Task 15: ");

                    foreach (double x in ab)
                    {
                        Write(x + " ");
                    }
                }
                #endregion
            }
            #endregion

            #region LEVEL 3
            {
                #region Task 1
                {
                    int n;
                    WriteLine("Enter length of massive: ");
                    int l = 0;
                    int.TryParse(ReadLine(), out l);
                    double[] a = new double[l];
                    double[] b = new double[l];

                    WriteLine("Fill in the massive");
                    int counter = 0;
                    if (l > 0)
                    {
                        double max = -999999;
                        for (int i = 0; i < l; i++)
                        {
                            WriteLine("Enter " + (i + 1) + " number of massive");
                            double x = 0;
                            double.TryParse(ReadLine(), out x);
                            a[i] = x;

                            if (a[i] > max)
                            {
                                max = a[i];
                                counter = 0;
                            }

                            if (a[i] == max)
                            {
                                b[counter] = i;
                                counter++;
                            }
                        }
                    }
                    WriteLine("Answer for №1");
                    if (l <= 0) WriteLine("n can't be <= 0");
                    else
                        for (int i = 0; i < counter; i++)
                        {
                            Write(b[i] + " ");
                        }
                }
                #endregion

                #region Task 5
                {
                    int n;
                    WriteLine("Enter length of massive: ");
                    int l = 0;
                    int.TryParse(ReadLine(), out l);
                    double[] a = new double[l + 1];

                    WriteLine("Fill in the massive: ");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + "number of massive");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }
                    for (int i = 0; i < l - 2; i = i + 2)
                    {

                        for (int j = i + 2; j < l - 1; j = j + 2)
                        {
                            if (a[j] > a[i])
                            {
                                double x = a[i];
                                a[i] = a[j];
                                a[j] = x;
                            }
                        }
                    }

                    WriteLine("Answer for Task 5: ");
                    foreach (double x in a)
                    {
                        Write(x + " ");
                    }
                }
                #endregion

                #region Task 8
                {
                    int n;
                    WriteLine("Enter length of massive: ");
                    int l = 0;
                    int.TryParse(ReadLine(), out l);
                    double[] a = new double[l + 1];

                    WriteLine("Fill in the massive");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + "number of massive");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    for (int i = 0; i < l - 1; i++)
                    {
                        for (int j = i + 1; j < l; j++)
                        {
                            if (a[i] < 0 && a[j] < 0)
                            {
                                if (a[i] < a[j])
                                {
                                    double x = a[i];
                                    a[i] = a[j];
                                    a[j] = x;

                                }
                            }
                        }
                    }

                    WriteLine("Answer for Task 8: ");
                    foreach (double x in a)
                    {
                        Write(x + " ");
                    }
                }
                #endregion

                #region Task 9
                {
                    int n;
                    if (Int32.TryParse(ReadLine(), out n))
                    {
                        int[] a = new int[n];
                        WriteLine("Enter massive's values");
                        for (int i = 0; i < n; i++)
                        {
                            Int32.TryParse(ReadLine(), out a[i]);
                        }

                        int tomax = 0, tomin = 0;
                        int max = 0;

                        for (int i = 0; i < a.Length - 1; i++)
                        {
                            if (tomax > max)
                            {
                                max = tomin;
                            }

                            if (tomin > max)
                            {
                                max = tomin;
                            }

                            if (a[i] > a[i + 1])
                            {
                                tomin++;
                            }
                            else tomin = 0;

                            if (a[i] < a[i + 1])
                            {
                                tomax++;
                            }
                            else tomax = 0;
                        }
                        WriteLine($"Длина самой упорядоченной последовательности: {max + 1}");
                    }
                }
                #endregion

                #region Task 12
                {
                    double[] a = new double[12];
                    for (int i = 0; i < 12; i++)
                    {
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    a = a.Where(val => val > 0).ToArray();

                    foreach (double i in a)
                    {
                        Write(i + " ");
                    }
                }
                #endregion

                #region Task 13
                {
                    int n = 0;
                    WriteLine("Enter length of massive: ");
                    int.TryParse(ReadLine(), out n);
                    double[] a = new double[n];
                    double[] b = new double[n];

                    WriteLine("Fill in the massive: ");
                    for (int i = 0; i < n; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    double counter = 0;

                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if (a[i] == a[j])
                            {
                                a[j] = 0;
                                counter++;
                            }
                        }

                        if (counter > 0) a[i] = 0;
                        counter = 0;
                    }

                    WriteLine("Answer for Task 13");
                    for (int i = 0; i < n; i++)
                    {
                        Write(a[i] + " ");
                    }
                    WriteLine();
                }
                #endregion
            }
            #endregion

            #region Algorithms
            {
                #region Alg 11
                {
                    WriteLine("Enter length of massive: ");
                    int n = 0;
                    int.TryParse(ReadLine(), out n);
                    double[] a = new double[n];

                    for (int j = 0; j < n; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive");
                        double xx = 0;
                        double.TryParse(ReadLine(), out xx);
                        a[j] = xx;
                    }
                    Array.Sort(a);

                    WriteLine("Enter x: ");
                    int x = 0;
                    int.TryParse(ReadLine(), out x);

                    int i1 = 0, i2 = n - 1, i;

                    while (i2 >= i1)
                    {
                        i = (i1 + i2) / 2;
                        if (a[i] == x)
                        {
                            WriteLine($"x exist, it's index {i}");
                            break;
                        }
                        else if (x < a[i])
                        {
                            i2 = i - 1;
                        }
                        else
                        {
                            i1 = i + 1;
                        }
                    }
                    if (i2 < i1)
                    {
                        WriteLine("x doesn't exist");
                    }
                }
                #endregion

                #region Alg 12
                {
                    WriteLine("Enter length of massive a: ");
                    int l = 0;
                    int.TryParse(ReadLine(), out l);
                    double[] a = new double[l];

                    for (int j = 0; j < l; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive a");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[j] = x;
                    }

                    WriteLine("Enter length of massive b: ");
                    int l1 = 0;
                    int.TryParse(ReadLine(), out l1);

                    double[] b = new double[l1];
                    for (int j = 0; j < l1; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive");
                        double y = 0;
                        double.TryParse(ReadLine(), out y);
                        b[j] = y;
                    }
                    double[] c = new double[l + l1];
                    int min = -1;
                    if (l < l1)
                    {
                        min = l;
                    }
                    else
                    {
                        min = l1;
                    }
                    for (int j = 0; j < min; j++)
                    {
                        c[2 * j] = a[j];
                        c[2 * j + 1] = b[j];
                    }
                    if (l < l1)
                    {
                        for (int j = 0; j < Math.Abs(l - l1); j++)
                        {
                            c[min * 2 + j] = b[l + j];
                        }
                    }
                    else if (l > l1)
                    {
                        for (int j = l1; j < l1 + Math.Abs(l - l1); j++)
                        {
                            c[min * 2 + j] = a[l1 + j];
                        }
                    }
                    foreach (double i in c)
                    {
                        Write(i + " ");
                    }
                }
                #endregion

                #region Alg 13
                {
                    int n = 0, m = 0;
                    WriteLine("Enter length of massive a: ");
                    int.TryParse(ReadLine(), out n);

                    WriteLine("Enter length of massive b");
                    int.TryParse(ReadLine(), out m);

                    double[] a = new double[n];
                    double[] b = new double[m];

                    WriteLine("Fill in the massive a: ");
                    for (int i = 0; i < n; i++)
                    {
                        double x;
                        double.TryParse(ReadLine(), out x);
                        a[i] = x;
                    }

                    WriteLine("Fill in the massive b: ");
                    for (int i = 0; i < m; i++)
                    {
                        double x;
                        double.TryParse(ReadLine(), out x);
                        b[i] = x;
                    }

                    Array.Sort(a);
                    Array.Reverse(a);

                    Array.Sort(b);
                    Array.Reverse(b);

                    double[] c = new double[n + m];
                    n = 0;
                    m = 0;

                    for (int i = 0; i < c.Length; i++)
                    {
                        if (n < a.Length)
                        {
                            if (m < b.Length)
                            {
                                if (a[n] > b[m])
                                {
                                    c[i] = b[n];
                                    n++;
                                }
                                else
                                {
                                    c[i] = b[m];
                                    m++;
                                }
                            }
                            else
                            {
                                c[i] = a[n];
                                n++;
                            }
                        }
                        else
                        {
                            c[i] = b[m];
                            n++;
                        }
                    }

                    for (int i = 0; i < c.Length; i++)
                    {
                        Write(c[i] + " ");
                    }

                }
                #endregion

                #region Alg 14
                {
                    WriteLine("Enter length of massive a: ");
                    int a1 = 0;
                    int.TryParse(ReadLine(), out a1);
                    double[] a = new double[a1];

                    for (int j = 0; j < a1; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive a");
                        double x = 0;
                        double.TryParse(ReadLine(), out x);
                        a[j] = x;
                    }

                    double n = 0;
                    for (int i = 0; i < a1 / 2; i++)
                    {
                        n = a[i];
                        a[i] = a[a1 - i - 1];
                        a[a1 - i - 1] = n;
                    }
                    foreach (double i in a)
                    {
                        Write(i + " ");
                    }
                }
                #endregion

                #region Alg 15
                {
                    WriteLine("Enter length of massive: ");
                    int l = 0;
                    int.TryParse(ReadLine(), out l);
                    double[] a = new double[l];

                    for (int j = 0; j < l; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive");
                        double y = 0;
                        double.TryParse(ReadLine(), out y);
                        a[j] = y;
                    }

                    WriteLine("Enter amount of moves: ");
                    int x = 0;
                    int.TryParse(ReadLine(), out x);
                    x = x % l;
                    double[] auxil = new double[x];

                    for (int i = 0; i < x; i++)
                    {
                        auxil[i] = a[l - 1 - i];
                    }

                    for (int i = l - 1; i > x - 1; i--)
                    {
                        a[i] = a[i - x];
                    }

                    for (int i = 0; i < x; i++)
                    {
                        a[i] = auxil[x - 1 - i];
                    }

                    foreach (double i in a)
                    {
                        Write(i + " ");
                    }
                }
                #endregion
            }
            #endregion
        }
    }
}
