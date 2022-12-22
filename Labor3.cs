﻿using System;
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
                    double[] arr = new double[5];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToDouble(ReadLine());
                    }
                    double l = 0;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        l += Math.Pow(arr[i], 2);
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
                        mas[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    WriteLine("Enter p");
                    double p = Convert.ToDouble(Console.ReadLine());
                    WriteLine("Enter q");
                    double q = Convert.ToDouble(Console.ReadLine());

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
                        mas[i] = double.Parse(ReadLine());
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
                        mas[i] = double.Parse(ReadLine());
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
                        mas[i] = double.Parse(ReadLine());
                    }

                    double[] even = Array.FindAll(mas, i => i % 2 == 0);
                    double[] uneven = Array.FindAll(mas, i => i % 2 != 0);

                    WriteLine("Even numbers: ");
                    foreach (double s in even)
                        Write(s + " ");

                    WriteLine("\nUneven numbers: ");
                    foreach (double s in uneven)
                        Write(s + " ");
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

                    double min = 0;
                    if (n > 0)
                    {
                        min = a[0];
                        int min1 = 0;
                        for (int i = 0; i < n; i++)
                        {
                            if ((a[i] > 0) && (a[i] < min))
                            {
                                min = a[i];
                                min1 = i;
                            }

                        }

                        for (int i = min1; i < n - 1; i++)
                        {
                            a[i] = a[i + 1];
                        }
                    }

                    WriteLine("Answer: ");
                    if (n <= 0)
                    {
                        WriteLine("Error");
                    }
                    else
                    {
                        for (int i = 0; i < n - 1; i++)
                        {
                            Write(a[i] + "\t");
                        }
                    }
                }
                #endregion

                #region Task 11
                {
                    Write("Enter P: ");
                    double P = Convert.ToDouble(ReadLine());
                    WriteLine("Enetr length of massive: ");
                    int l = Convert.ToInt32(ReadLine());
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
                    int l = Convert.ToInt32(ReadLine());
                    double[] a = new double[l];
                    int max = -1;
                    double maxnumber = -10000000;

                    WriteLine("Fill in the massive");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        a[i] = double.Parse(ReadLine());

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
                    int n = Convert.ToInt32(ReadLine());
                    double[] a = new double[n];

                    WriteLine("Fill in the massive A");
                    for (int i = 0; i < n; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        a[i] = double.Parse(ReadLine());
                    }

                    WriteLine();

                    WriteLine("Enter length of B massive");
                    int k = Convert.ToInt32(ReadLine());
                    double[] b = new double[k];

                    WriteLine("Fill in the massive B");
                    for (int i = 0; i < k; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        b[i] = double.Parse(ReadLine());
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
                    int l = Convert.ToInt32(ReadLine());
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
                            a[i] = double.Parse(ReadLine());
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
                    int l = Convert.ToInt32(ReadLine());
                    double[] a = new double[l + 1];

                    WriteLine("Fill in the massive: ");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + "number of massive");
                        a[i] = double.Parse(ReadLine());
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
                    int l = Convert.ToInt32(ReadLine());
                    double[] a = new double[l + 1];

                    WriteLine("Fill in the massive");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + "number of massive");
                        a[i] = double.Parse(ReadLine());
                    }

                    for (int i = 0; i < l - 1; i++)
                    {
                        for (int j = i + 1; j < n; j++)
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
                    foreach (double x in Arr) Console.Write(x + " ");
                }
                #endregion

                #region Task 9
                {
                    int n;
                    WriteLine("Enter length of massive: ");
                    int l = Convert.ToInt32(ReadLine());
                    double[] a = new double[l];

                    WriteLine("Fill in the massive: ");
                    for (int i = 0; i < l; i++)
                    {
                        WriteLine("Enter " + (i + 1) + " number of massive");
                        a[i] = double.Parse(ReadLine());
                    }

                    int counter = 0, max1 = 1, max2 = 1;
                    for (int i = 0; i < l - 1; i++)
                    {
                        if (a[i] > a[i + 1])
                        {
                            counter++;
                            max1 = Math.Max(max1, counter);
                        }
                        else
                        {

                            counter = 0;
                        }
                    }

                    for (int i = 0; i < l - 1; i++)
                    {
                        if (a[i] < a[i + 1])
                        {
                            counter++;
                            max2 = Math.Max(max2, counter);

                        }
                        else
                        {

                            counter = 0;
                        }
                    }

                    WriteLine("Answer for Task 9: ");
                    WriteLine(Math.Max(max1, max2));

                }
                #endregion

                #region Task 12
                {
                    double[] a = new double[12];
                    for (int i = 0; i < 12; i++)
                    {
                        a[i] = Convert.ToDouble(ReadLine());
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
                        a[i] = double.Parse(ReadLine());
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
                    int n = Convert.ToInt32(ReadLine());
                    double[] a = new double[n];

                    for (int j = 0; j < n; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive");
                        a[j] = Convert.ToDouble(ReadLine());
                    }
                    Array.Sort(a);

                    WriteLine("Enter x: ");
                    double x = Convert.ToDouble(ReadLine());
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
                    int l = Convert.ToInt32(ReadLine());
                    double[] a = new double[l];

                    for (int j = 0; j < l; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive a");
                        a[j] = Convert.ToDouble(ReadLine());
                    }

                    WriteLine("Enter length of massive b: ");
                    int l1 = Convert.ToInt32(ReadLine());
                    double[] b = new double[l1];
                    for (int j = 0; j < l1; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive");
                        b[j] = Convert.ToDouble(ReadLine());
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
                    WriteLine("Enter length of massive a: ");
                    int l = Convert.ToInt32(ReadLine());
                    double[] a = new double[l];

                    for (int j = 0; j < l; j++)
                    {
                        Console.WriteLine("Enter " + (j + 1) + " elememt of massive a");
                        a[j] = Convert.ToDouble(ReadLine());
                    }
                    Array.Sort(a);

                    WriteLine("Enter length of massive b: ");
                    int l2 = Convert.ToInt32(ReadLine());
                    double[] b = new double[l2];

                    for (int j = 0; j < l2; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive");
                        b[j] = Convert.ToDouble(ReadLine());
                    }
                    Array.Sort(b);

                    double[] c = new double[l + l2];
                    int min = 0;

                    if (l < l2)
                    {
                        min = l;
                    }
                    else
                    {
                        min = l2;
                    }
                    int ai = 0, bi = 0;

                    while (ai < min || bi < min)
                    {
                        if (a[ai] < b[bi])
                        {
                            c[ai + bi] = b[bi];
                            bi++;
                        }
                        else
                        {
                            c[ai + bi] = a[ai];
                            ai++;
                        }
                    }

                    if (l < l2)
                    {
                        for (; bi < l2; bi++)
                        {
                            c[bi + ai] = b[bi];
                        }
                    }

                    if (l > l2)
                    {
                        for (; ai < l; ai++)
                        {
                            c[bi + ai] = a[ai];
                        }
                    }

                    foreach (double i in c)
                    {
                        Write(i + " ");
                    }
                }
                #endregion

                #region Alg 14
                {
                    WriteLine("Enter length of massive a: ");
                    int a1 = Convert.ToInt32(ReadLine());
                    double[] a = new double[a1];

                    for (int j = 0; j < a1; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive a");
                        a[j] = Convert.ToDouble(ReadLine());
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

                #region
                {
                    WriteLine("Enter length of massive: ");
                    int l = Convert.ToInt32(ReadLine());
                    double[] a = new double[l];

                    for (int j = 0; j < l; j++)
                    {
                        WriteLine("Enter " + (j + 1) + " elememt of massive");
                        a[j] = Convert.ToDouble(ReadLine());
                    }

                    WriteLine("Enter amount of moves: ");
                    int x = Convert.ToInt32(ReadLine());
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
