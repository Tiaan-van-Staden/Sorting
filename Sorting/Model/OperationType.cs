// Name: Tiaan van Staden

// Note: Regarding the sorting methods - I sincerely apologise, I could not get them to work correctly and I am pressed for time as I 
// Note: am currently busy with exams and need to prioritise studying, please view my github repositories to find further work regarding 
// Note: MVC, Strategies, Layered programming and API's

// Program: This is a basic Sorting program for you_source's Skill Test
// GitHub: https://github.com/Tiaan-van-Staden
// Date: 18 June 2022

namespace Sorting.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Type of sort operation the program should perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Utilizes BubbleSort
        /// </summary>
        BUBBLE,
        
        /// <summary>
        /// Utilizes QuickSort
        /// </summary>
        QUICK,
        
        /// <summary>
        /// Utilizes MergeSort
        /// </summary>
        MERGE
    }
}