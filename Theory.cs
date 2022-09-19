using System;

namespace _3rd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region Collections Theory
            /* Array - static (restricted) massive of data in the memory. If we want to extend it, we should create a new array and copy existing data there.
             * access to each number of array have static time that don't depend on size of array. So get arr[10] and arr[25426] consume equal time.
             * use it when you have determinative amount of elements.
             * 
             *
             *
             * These more suitable collections available if you add System.Collections.Generic library
             *
             *
             * Stack<type of data> - pile of elements (like a books on the table or plates in the sink) that lay one over another and you can add new one to the top, look at the highest one or take it
             * 
             * Queue<type of data> - like in the shop or on escalator in the subway. You can add to the end, look the first element or take the first element.
             * 
             * List<type of data> - very suitable array when you don't know the limit of your array and ought to add or remove elements sometimes (linked array)
             * the PC create an array and when you want to add new element, create a new array and copy all existing elements there.
             *
             * LinkedList<type of data> - array with a reference to the next and previous element (twice-linked array)
             * 
             * Dictionary<type of key, type of data> - pair key-value. You can add new key, find key, get value by key, set value by key. Very fast access (as simple array), but more flexible
             * 
             */
            #endregion

            #region Arrays

            //Dimensions:
            int[] oneDimension = new int[1000000]; // raw with a 1 million if zeros
            double[] oneDimensionInitializedArray; // undefined array
            int[,] twoDimension = new int[1000, 1000]; // matrix 1000 x 1000, filled by zeros
            string[,,] threeDimension = new string[5, 10, 255]; // 5 raws, 10 columns and 255 elements in the column. Each element can contain a string (so it 4-th dimension array actually)

            int[][] notSquarMatrix = new int[15][]; // array where each element contain an array (different or equal lengths) -> [ [0,1,2,3,4] , [10,25] , [8] ];

            //and so on

            // Access to element:

            threeDimension[threeDimension.Length-1, 0, threeDimension.GetLength(2)-1] = "I am the latest element here!"; // do not forget that start with 0 and end with Length-1!


            double[] shortExample = new double[4] { 1.2, 0.154564, -454, 0 }; // will be crated a new massive with 4 elements

            // Use arrays for limited length. Otherwise - List.
            // For fast search - Dictionary
            // Efficient simple solutions usually realizing by Stack and Queue
            // LinkedList is used seldom

            #endregion
        }
    }
}
