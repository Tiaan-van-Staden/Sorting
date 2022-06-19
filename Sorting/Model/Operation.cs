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
    /// Information about the sort operation and input
    /// </summary>
    public class Operation
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Operation"/> class.
        /// </summary>
        public Operation()
        {
            this.UserInput = string.Empty;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the User Input 
        /// </summary>
        public string UserInput { get; set; }

        /// <summary>
        /// Gets or sets the type of operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        #endregion      
    }
}
