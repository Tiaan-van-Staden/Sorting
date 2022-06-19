// Name: Tiaan van Staden

// Note: Regarding the sorting methods - I sincerely apologise, I could not get them to work correctly and I am pressed for time as I 
// Note: am currently busy with exams and need to prioritise studying, please view my github repositories to find further work regarding 
// Note: MVC, Strategies, Layered programming and API's

// Program: This is a basic Sorting program for you_source's Skill Test
// GitHub: https://github.com/Tiaan-van-Staden
// Date: 18 June 2022

namespace Sorting
{
    /// <summary>
    /// Designer for sorting windows form
    /// </summary>
    public partial class FrmSort
    {
        #region Form

        /// <summary>
        /// Label on form
        /// </summary>
        private Label label1;

        /// <summary>
        /// Textbox userInputText
        /// </summary>
        private TextBox userInputText;

        /// <summary>
        /// Label on form
        /// </summary>
        private Label label2;

        /// <summary>
        /// ComboBox sortingMethod
        /// </summary>
        private ComboBox sortingMethod;

        /// <summary>
        /// Button sortButton
        /// </summary>
        private Button sortButton;

        /// <summary>
        /// Label on form
        /// </summary>
        private Label label3;

        /// <summary>
        /// Label on form
        /// </summary>
        private Label sortOutput;

        /// <summary>
        /// Button clearButton
        /// </summary>
        private Button clearButton;

        #endregion

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortingMethod = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SortOutput = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter String";
            // 
            // UserInputText
            // 
            this.UserInputText.Location = new System.Drawing.Point(32, 40);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(138, 25);
            this.UserInputText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Sorting method";
            // 
            // SortingMethod
            // 
            this.SortingMethod.FormattingEnabled = true;
            this.SortingMethod.Items.AddRange(new object[] {
            "BubbleSort",
            "QuickSort",
            "MergeSort"});
            this.SortingMethod.Location = new System.Drawing.Point(32, 104);
            this.SortingMethod.Name = "SortingMethod";
            this.SortingMethod.Size = new System.Drawing.Size(138, 25);
            this.SortingMethod.TabIndex = 3;
            //this.SortingMethod.SelectedIndexChanged += new System.EventHandler(this.SortingMethod_SelectedIndexChanged);
            // 
            // SortButton
            // 
            this.SortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SortButton.Location = new System.Drawing.Point(60, 145);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(79, 25);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "String Output:";
            // 
            // SortOutput
            // 
            this.SortOutput.AutoSize = true;
            this.SortOutput.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortOutput.Location = new System.Drawing.Point(125, 192);
            this.SortOutput.Name = "SortOutput";
            this.SortOutput.Size = new System.Drawing.Size(63, 20);
            this.SortOutput.TabIndex = 6;
            this.SortOutput.Text = "Waiting";
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(60, 233);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(79, 25);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.SortButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(500, 279);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SortOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortingMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserInputText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana Pro Cond", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "LetsSort";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}