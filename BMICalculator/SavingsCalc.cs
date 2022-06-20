///<summary>
///The purpose of the class is to calculate savings. 
///Instance variables for computing compound interest: monthlyDeposit, InterestRate, Period, Fees 
///</summary>
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{

    /// <summary>
    /// The extended Controll class have a helpfull functions ready for use in multible sections of this solotion. 
    /// </summary>
    internal class SavingsCalc : Controll
    {
        /// <summary>
        /// The cunstructor function is created to run directly by calling the main class.
        /// It will prepare/validate and convert the requested data using the validateData() function.
        /// call the SavingsCalculateAction() function to do the calculation.
        /// </summary>
        public SavingsCalc(Label errMsg, TextBox monthlyDeposit, TextBox period, TextBox startValue, TextBox intrest, TextBox fees, TextBox amountEarndResult, TextBox totalFeesResult, TextBox amountPaidResult, TextBox finalBalanceResult)
        {
            bool validateMonthlyDeposit = validateData(errMsg, monthlyDeposit.Tag, "float", monthlyDeposit.Text);
            bool validatePeriod = validateData(errMsg, period.Tag, "float", period.Text);
            bool validateStartValue = validateData(errMsg, period.Tag, "float", startValue.Text);
            bool validateintrest = validateData(errMsg, period.Tag, "float", intrest.Text);
            bool validateFees = validateData(errMsg, fees.Tag, "float", fees.Text);

            if ((!validateMonthlyDeposit) || (!validatePeriod) || (!validateStartValue) || (!validateintrest) || (!validateFees))
            {
                return;
            }

            float savingsMonthlyDeposit = float.Parse(monthlyDeposit.Text);
            float savingsPeriod = float.Parse(period.Text);
            float savingsStartValue = float.Parse(startValue.Text);
            float savingsIntrest = float.Parse(intrest.Text);
            float savingsFees = float.Parse(fees.Text);
            float intrestRate = savingsIntrest / 100;
            float totalFees = savingsFees / 100;

            SavingsCalculateAction(savingsMonthlyDeposit, savingsPeriod, savingsStartValue, intrestRate, totalFees, amountPaidResult, totalFeesResult, amountEarndResult, finalBalanceResult);
        }

        /// <summary>
        /// the SavingsCalculateAction function calculate the:
        /// paid amount, intrest, fees and the final balance and return it to the user interface 
        /// </summary>
        private void SavingsCalculateAction(float savingsMonthlyDeposit, float savingsPeriod, float savingsStartValue, float intrestRate, float totalFees, TextBox amountPaidResult, TextBox totalFeesResult, TextBox amountEarndResult, TextBox finalBalanceResult)
        {
            double finalBalance = savingsStartValue;
            double interestEarned = 0;
            double AmountPaid = savingsStartValue;
            double feesTaken = 0;

            double intrestRateMonth = (1 + intrestRate / 12) - 1;
            double feesRateMonth = (1 + totalFees / 12) - 1;
            for (int i = 0; i < (savingsPeriod * 12); i++) ///loop every month in provided years
            {
                    AmountPaid += savingsMonthlyDeposit;
                    double intrest = (finalBalance * intrestRateMonth);
                    interestEarned += intrest;
                    double fees = (intrest * feesRateMonth);
                    feesTaken += fees;
                    finalBalance += (savingsMonthlyDeposit + intrest) - feesTaken;
            }


            ///store the data to the user interface
            totalFeesResult.Text = feesTaken.ToString("0.000");
            amountEarndResult.Text = interestEarned.ToString("0.000");
            amountPaidResult.Text = AmountPaid.ToString("0.000");
            finalBalanceResult.Text = finalBalance.ToString("0.000");


        }
    }
}
