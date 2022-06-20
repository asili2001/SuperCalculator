///<summary>
///The purpose of the class is to calculate BMR
///using your height, weight, age, and your activity level.
///it will let you know your MBR/calories per day, 
///Calories per day to keep your current weight, 
///calories to lose 0,5kg and 1kg, calories to gain 0,5kg and 1kg
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class BMRCalc : Controll
    {

        ///<summary>
        ///The cunstructor function is created to run directly by calling the main class.
        ///It will prepare/validate and convert the requested data using the validateData() function.
        ///Check wich unit you chose.
        ///call the GetMbr() function to do the calculation.
        /// </summary>
        public BMRCalc(Label errMsg, TextBox BMIUserName, TextBox BMIUserHeight, TextBox BMIUserHeightIN, string BMIUnit, TextBox BMIUserWeight, string userGender, TextBox MBRAge, float WeeklyActivityLevel, ListBox MBRResultBox)
        {
            bool validateUserHeight = validateData(errMsg, BMIUserHeight.Tag, "float", BMIUserHeight.Text);
            bool validateUserWeight = validateData(errMsg, BMIUserHeight.Tag, "float", BMIUserWeight.Text);
            bool validateUserAge = validateData(errMsg, MBRAge.Tag, "float", MBRAge.Text);

            if ((!validateUserHeight) || (!validateUserWeight) || (!validateUserAge))
            {
                return;
            }

            string userName = ReadName(BMIUserName);
            float UserHeight = float.Parse(BMIUserHeight.Text);
            float UserWeight = float.Parse(BMIUserWeight.Text);
            float UserAge = float.Parse(MBRAge.Text);


            ///if imperial, convert the height from feet and inch to cm
            if (BMIUnit == "imperial")
            {
                bool validateUserHeightFT = validateData(errMsg, BMIUserHeight.Tag, "float", BMIUserHeight.Text);
                bool validateUserHeightIN = validateData(errMsg, BMIUserHeight.Tag, "float", BMIUserHeightIN.Text);
                if ((!validateUserHeightFT) || (!validateUserHeightIN))
                {
                    return;
                }
                float UserHeightFT = float.Parse(BMIUserHeight.Text);
                float UserHeightIN = float.Parse(BMIUserHeightIN.Text);

                ///convert feet to inch and add it together with UserHeightIN
                float calUserHeightIN = (UserHeightFT * 12f) + UserHeightIN;

                UserHeight = calUserHeightIN * 2.54f; ///convert inch to cm

                UserWeight /= 2.2046f; ///convert user weight from lbs to kg
            }

            var (MBR, maintainWeightBMRs, MBRGain500, MBRGain1000, MBRLose500, MBRLose1000) = GetMbr(UserWeight, UserHeight, UserAge, userGender, WeeklyActivityLevel);

            ///store the data to the user interface (listBox)
            MBRResultBox.Items.Clear();
            MBRResultBox.Font = new Font(FontFamily.GenericMonospace, 10);
            MBRResultBox.Items.Add("BMR Result for " + userName);
            MBRResultBox.Items.Add(String.Format("{0, -50}{1, 10}", "Your MBR (calories/day)", MBR));
            MBRResultBox.Items.Add(String.Format("{0, -50}{1, 10}", "Calories to maintain your weight ", String.Format("{0:0.00}", maintainWeightBMRs)));
            MBRResultBox.Items.Add(String.Format("{0, -50}{1, 10}", "Calories to lose 0,5 kg per week ", String.Format("{0:0.00}", MBRLose500)));
            MBRResultBox.Items.Add(String.Format("{0, -50}{1, 10}", "Calories to lose 1 kg per week ", String.Format("{0:0.00}", MBRLose1000)));
            MBRResultBox.Items.Add(String.Format("{0, -50}{1, 10}", "Calories to gain 0,5 kg per week ", String.Format("{0:0.00}", MBRGain500)));
            MBRResultBox.Items.Add(String.Format("{0, -50}{1, 10}", "Calories to gain 1 kg per week ", String.Format("{0:0.00}", MBRGain1000)));
            MBRResultBox.Items.Add("");
            MBRResultBox.Items.Add("Losing more then 1000 calories per day is to be avoided");
        }

        /// <summary>
        /// GetMbr will calculate the MBR/calories per day,
        /// Calories per day to keep your current weight, 
        /// calories to lose 0,5kg and 1kg,
        /// calories to gain 0,5kg and 1kg.
        /// </summary>

        private (float, float, float, float, float, float) GetMbr(float weight, float height, float age, string gender, float WeeklyActivityLevel)
        {
            float MBR = 0;
            float maintainWeightBMRs;
            float MBRGain500;
            float MBRGain1000;
            float MBRLose500;
            float MBRLose1000;

            float BMR = 10f * weight + 6.25f * height - 5f * age;
            if (gender == "male")
            {
                MBR = BMR + 5;

            }
            else if (gender == "female")
            {
                MBR = BMR - 161;
            }

            maintainWeightBMRs = BMR * WeeklyActivityLevel;
            MBRGain500 = maintainWeightBMRs + 500;
            MBRGain1000 = maintainWeightBMRs + 1000;
            MBRLose500 = maintainWeightBMRs - 500;
            MBRLose1000 = maintainWeightBMRs - 1000;

            return (MBR, maintainWeightBMRs, MBRGain500, MBRGain1000, MBRLose500, MBRLose1000);
        }
    }
}
