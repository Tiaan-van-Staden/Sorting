// Name: Tiaan van Staden

// Note: Regarding the sorting methods - I sincerely apologise, I could not get them to work correctly and I am pressed for time as I 
// Note: am currently busy with exams and need to prioritise studying, please view my github repositories to find further work regarding 
// Note: MVC, Strategies, Layered programming and API's

// Program: This is a basic Sorting program for you_source's Skill Test
// GitHub: https://github.com/Tiaan-van-Staden
// Date: 18 June 2022

namespace Sorting.Logic_Layer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contains Methods used by FormSort.cs
    /// </summary>
    public class FileHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileHandler"/> class.
        /// </summary>
        public FileHandler()
        {
        }

        #region BubbleSort

        /// <summary>
        /// BubbleSort method that takes input and returns a sorted string
        /// </summary>
        /// <param name="input">User Input</param>
        /// <returns>Output after MergeSort</returns>
        public static string BubbleSort(string input)
        {
            char temp;
            string myStr;
            myStr = Convert.ToString(input);
            string str = myStr.ToLower();
            char[] charstr = str.ToCharArray();

            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }

            // TODO: fix this, it outputs "Invalid input. Index was outside the bounds of the array"
            string result = string.Join(" ", charstr);
            return result;
        }

        #endregion

        #region QuickSort

        /// <summary>
        /// QuickSort method that takes input and returns a sorted string
        /// </summary>
        /// <param name="input">User Input</param>
        /// <returns>Output after QuickSort</returns>
        public static string QuickSort(string input)
        {
            string temp = input;

            // TODO: make QuickSort Algorithm 
            return temp + " is sorted using QuickSort";
        }

        #endregion

        #region MergeSort
        
        /// <summary>
        /// MergeSort method that takes input and returns a sorted string
        /// </summary>
        /// <param name="input">User Input</param>
        /// <returns>Output after MergeSort</returns>
        public static string MergeSort(string input)
        {
            string temp = input;

            // TODO: make MergeSort Algorithm
            return temp + " is sorted using MergeSort";         
        }

        #endregion
    }
}
