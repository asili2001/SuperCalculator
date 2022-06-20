/// <summary>
/// This solution will calculate your BMI, BMR and your savings plan
/// Made by Ahmad Asili 2022-03-1
/// </summary>
namespace BMICalculator
{
    /// <summary>
    /// The FirstForm class is where the program starts.
    /// The the needed variable is included at the first of the main class
    /// In the constuctor Function the IntializeGUI() is called to configure the default values of the program
    /// </summary>
    public partial class FirstForm : Form
    {
        //prepare the needed variables
        string BMIUnit = "";
        string userGender = "";
        float WeeklyActivityLevel = 3;
        public FirstForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "Super Calculator by Ahmad Asili";
            BMIUnit1.Checked = true;
            BMIUserHeightIN.Visible = false;
            errMsg.Visible = false;
            BMIUserHeight.Size = new System.Drawing.Size(140, 23);
        }

        ///-------------------------Start of BMI Calculator-----------------------///

        /// <summary>
        /// Check if the metrik unit option is selected then change:
        /// the  label of the height input (cm)
        /// the label of the weight value (kg)
        /// hide the height in inch value
        /// strech the height input
        /// </summary>
        private void MBIUnit1_CheckedChanged(object sender, EventArgs e)
        {
            BMIlblHeight.Text = "Height (cm)";
            BMIlblWeight.Text = "Weight (kg)";
            BMIUserHeightIN.Visible = false;
            BMIUserHeight.Size = new System.Drawing.Size(140, 23);
            //update the unit variable
            BMIUnit = "metrik";
        }

        /// <summary>
        /// Check if the imperial unit option is selected then change:
        /// the label of the height input (ft and inch)
        /// the label of the weight value (lbs)
        /// show the height in inch value
        /// resize the height input
        /// </summary>
        
        private void MPIUnit2_CheckedChanged(object sender, EventArgs e)
        {
            BMIlblHeight.Text = "Height (ft and inch)";
            BMIlblWeight.Text = "Weight (lbs)";
            BMIUserHeight.Size = new System.Drawing.Size(65, 23);
            BMIUserHeightIN.Visible = true;

            BMIUnit = "imperial";
        }

        /// <summary>
        /// Check if the submit button is clicked and:
        /// hide the error message
        /// call the BmiCalc function and pass in all needed information
        /// to calculate the bmi and return it to the user interface
        /// </summary>
        private void BMISubmit_Click(object sender, EventArgs e)
        {
            errMsg.Visible = false;
            BmiCalc BMI = new BmiCalc(errMsg, BMIUserName, BMIUserHeight, BMIUserWeight, BMIUserHeightIN, BMIUnit, grpBMIResults, BMIResult, weightCategoryResult, idealWeight, BMIResultBlur);
        }

        ///-------------------------End of BMI calculator-----------------------///


        ///-------------------------Start of Savings Calculator-----------------------///

        ///<summary>
        /// Check if the submit button is clicked and:
        /// call the SavingsCalc function and pass in all needed information
        /// to calculate your savings and return it to the user interface
        /// </summary>
        private void savingsCalculateSubmit_Click(object sender, EventArgs e)
        {
            errMsg.Visible = false;
            SavingsCalc savings = new SavingsCalc(errMsg, savingsPlanMonthlyDeposit, savingsPlanPeriod, savingsPlanStartValue, savingsPlanIntrest, savingsPlanFees, amountEarndResult, totalFeesResult, amountPaidResult, finalBalanceResult);
        }
        ///-------------------------End of the Savings Calculator-----------------------///

        ///-------------------------Start of BMR calculator-----------------------///

        ///<summary>
        ///if the BMR submit button is clicked:
        ///Check if the gender type male or female and store it to the global variable for later use.
        ///Check what weekly activity option the user selected and store it in the global variable for later use
        ///hide the error message
        ///call the BMRCalc function and pass in all needed information
        ///to calculate your BMR and return the the response to the user interface
        /// </summary>
        private void BMRCalculatorSubmit_Click(object sender, EventArgs e)
        {
            bool GenderChecked = Gender1.Checked;
            if (GenderChecked)
            {
                userGender = "male";
            }
            else
            {
                userGender = "female";
            }

            ///check which weekly activity option is selected
            if (WeeklyActivityLevel_Sedentary.Checked)
            {
                WeeklyActivityLevel = 1.2f;
            }else if (WeeklyActivityLevel_Lightly.Checked)
            {
                WeeklyActivityLevel = 1.375f;
            }
            else if (WeeklyActivityLevel_Moderately.Checked)
            {
                WeeklyActivityLevel = 1.550f;
            }
            else if (WeeklyActivityLevel_Very.Checked)
            {
                WeeklyActivityLevel = 1.725f;
            }else if (WeeklyActivityLevel_Extra.Checked)
            {
                WeeklyActivityLevel = 1.9f;
            }


            errMsg.Visible = false;
            BMRCalc BMR = new BMRCalc(errMsg, BMIUserName, BMIUserHeight, BMIUserHeightIN, BMIUnit, BMIUserWeight, userGender, MBRAge, WeeklyActivityLevel, MBRResultBox);

        }
        ///-------------------------End of the BMR Calculator-----------------------///
    }
}