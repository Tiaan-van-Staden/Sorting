// Name: Tiaan van Staden

// Note: Regarding the sorting methods - I sincerely apologise, I could not get them to work correctly and I am pressed for time as I 
// Note: am currently busy with exams and need to prioritise studying, please view my github repositories to find further work regarding 
// Note: MVC, Strategies, Layered programming and API's

// Program: This is a basic Sorting program for you_source's Skill Test
// GitHub: https://github.com/Tiaan-van-Staden
// Date: 18 June 2022

namespace Sorting
{
    using Sorting.Logic_Layer;
    using Sorting.Model;

    /// <summary>
    /// This is a basic Sorting program for you_source's Skill Test
    /// </summary>
    public partial class FrmSort : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmSort"/> class.
        /// </summary>
        public FrmSort()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Sort Button

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmSort"/> class.
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event of instance</param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            this.CalculateSortOutput();
        }

        #endregion

        #region Clearing Method

        /// <summary>
        /// Clears the user input text and resets the form
        /// </summary>
        /// <param name="sender">Click Operation</param>
        /// <param name="e">Event argument</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clears userinput and makes it that you can do another test
            this.UserInputText.Text = string.Empty;
            this.SortingMethod.Text = string.Empty;
            this.SortOutput.Text = "Waiting";   
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Accepts the sort type and returns the correct <see cref="OperationType"/>
        /// </summary>
        /// <param name="sortType">The method it should follow</param>
        /// <returns>Sort Type selected</returns>
        /// <exception cref="InvalidOperationException">If operation method was selected</exception>
        private OperationType GetOperationType(string sortType)
        {
            switch (sortType)
            {
                case "BubbleSort":
                    return OperationType.BUBBLE;
                case "QuickSort":
                    return OperationType.QUICK;
                case "MergeSort":
                    return OperationType.MERGE;
                default:
                    throw new InvalidOperationException("Choose a sorting Method");
            }
        }

        /// <summary>
        /// Start of sorting operation
        /// </summary>
        private void CalculateSortOutput()
        {
            // Sets the output label to the correct result after sorting
            this.SortOutput.Text = this.ParseOperation();
        }

        /// <summary>
        /// Parses the user input and outputs the result after sorting
        /// </summary>
        /// <returns>Operation output to label</returns>
        private string ParseOperation()
        {
            try
            {
                var operation = new Operation();
                
                // Getting user input
                var userInput = this.UserInputText.Text;
                operation.UserInput = userInput;

                // Remove spaces  
                userInput = userInput.Replace(" ", string.Empty);

                // Setting Sorting Method
                var sortingMethod = this.sortingMethod.Text;
                var operatorType = this.GetOperationType(sortingMethod);
                operation.OperationType = operatorType;
                
                // If we are done parsing and there are no exeptions
                // sort with method
                return this.SortOpperation(operation);
            }
            catch (Exception ex)
            {
                return $"Invalid input. {ex.Message}";
            }
        }

        /// <summary>
        /// Sorts an <see cref="UserInputText"/> and returns string
        /// </summary>
        /// <param name="operation">Object of the operation</param>
        /// <returns>Final Output to ParseOperation()</returns>
        /// <exception cref="Exception">If NULL or if valid</exception>
        private string SortOpperation(Operation operation)
        {
            // store user input
            string input = operation.UserInput;

            // Check if input is valid or null
            if (string.IsNullOrEmpty(operation.UserInput))
            {
                throw new InvalidOperationException($"The input is invalid. {operation.UserInput}");
            }

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.BUBBLE:
                        return FileHandler.BubbleSort(input);
                    case OperationType.QUICK:
                        return FileHandler.QuickSort(input);
                    case OperationType.MERGE:
                        return FileHandler.MergeSort(input);
                    default:
                        throw new InvalidOperationException($"The OperationType is invalid. {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to sort {operation.UserInput} with {operation.OperationType}. {ex.Message}");
            }
        }
        #endregion
    }
}