
///<summary>
///The purpose of the class is to calculate BMI
///based on your height and weight in both metrik and imperial unit!. 
/// </summary>
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
    internal class BmiCalc : Controll
    {

        /// <summary>
        /// The cunstructor function is created to run directly by calling the main class.
        /// It will prepare/validate and convert the requested data using the validateData() function.
        /// Check which unit you chose (metrik, imperial) and based on that the metrikCalc() or the imperialCalc will be called to calculate the MBI.
        /// It will calculate your weight category based on your BMI result using WeightCategory() function
        /// calculate your Ideal weight using IdealWeight() function
        /// </summary>
        public BmiCalc(Label errMsg, TextBox BMIUserName, TextBox BMIUserHeight, TextBox BMIUserWeight, TextBox BMIUserHeightIN, string MBIUnit, GroupBox grpBMIResults, TextBox BMIResult, TextBox weightCategoryResult, Label idealWeight, PictureBox BMIResultBlur)
        {

            grpBMIResults.Text = ReadName(BMIUserName);


            bool validateUserHeight = validateData(errMsg, BMIUserHeight.Tag, "float", BMIUserHeight.Text);
            bool validateUserWeight = validateData(errMsg, BMIUserWeight.Tag, "float", BMIUserWeight.Text);

            if ((!validateUserHeight) || (!validateUserWeight))
            {
                return;
            }

            float UserHeight = float.Parse(BMIUserHeight.Text);
            float UserWeight = float.Parse(BMIUserWeight.Text);
            float UserHeightInch = 0;
            string unitKGorLBS = "unknown";
            string Unit = MBIUnit;

            float BMI = 0;

            ///<summary>
            ///in the metric unit, the BMIUserHeight will act as CM
            /// and in the imperial unit it will act as FEET and the BMIUserHeightIN input will be used to sore INCH
            /// </summary>
            if (MBIUnit == "metrik")
            {
                BMI = metrikCalc(UserHeight, UserWeight);
                unitKGorLBS = "kg";
            }

            if (MBIUnit == "imperial")
            {

                bool validateUserHeightInch = validateData(errMsg, BMIUserHeightIN.Tag, "float", BMIUserHeightIN.Text);
                if (!validateUserHeightInch)
                {
                    return;
                }
                UserHeightInch = float.Parse(BMIUserHeightIN.Text);

                BMI = imperialCalc(UserHeight, UserHeightInch, UserWeight);
                unitKGorLBS = "lbs";
            }

            string FormatBMI = String.Format("{0:n}", BMI);
            BMIResult.Text = FormatBMI;


            weightCategoryResult.Text = WeightCategory(BMI);

            var (item1, item2) = IdealWeight(UserHeight, UserHeightInch, Unit);

            idealWeight.Text = $"Normal weight should be between {item1.ToString("0.00")} and {item2.ToString("0.00")} {unitKGorLBS}";

            BMIResultBlur.Visible = false; ///hide the blur image from the result panel
        }

        /// <summary>
        /// The metricCalc() function calculates the BMI in metrik unit
        /// </summary>
        private float metrikCalc(float height, float weight)
        {

            float Mheight = (height * 0.01f);
            float BMI = weight / (Mheight * Mheight);

            return BMI;
        }
        /// <summary>
        /// The imperialCalc() function calculates the BMI in imperial unit
        /// </summary>
        private float imperialCalc(float heightFT, float heightINCH, float weight)
        {
            float height = (heightFT * 12f) + heightINCH;
            float BMI = (weight * 703f) / (height * height);
            return BMI;
        }
        /// <summary>
        /// the WeightCategory() function will return your weight category based on your BMI result
        /// </summary>
        private string WeightCategory(float bmi)
        {
            if (bmi > 40)
            {
                return "Overweight (Obesity class III)";
            }
            else if (35.0 <= bmi)
            {
                return "Overweight (Obesity class II)";
            }
            else if (30.0 <= bmi)
            {
                return "Overweight (Obesity class I)";
            }
            else if (25.0 <= bmi)
            {
                return "Overweight (Pre-obesity)";
            }
            else if (18.5 <= bmi)
            {
                return "Normal weight";
            }
            else
            {
                return "Underweight";
            }
        }

        /// <summary>
        /// the IdealWeight() function will calculate the ideal weight based on the height and the ideal BMI result
        /// </summary>
        private (float, float) IdealWeight(float height, float heightINCH, string unit)
        {
            float IdealWeight1 = 0;
            float IdealWeight2 = 0;
            if (unit == "metrik")
            {
                float heightM = (height * 0.01f);
                IdealWeight1 = 18.50f * (heightM * heightM);
                IdealWeight2 = 24.90f * (heightM * heightM);
            }
            if(unit == "imperial")
            {
                float heightFT = height;
                float heightIN = (heightFT * 12f) + heightINCH; ///feet to inches
                float heightM = heightIN * 0.0254f; ///Inches to meters

                IdealWeight1 = 18.50f * (heightM * heightM);

                IdealWeight1 = IdealWeight1 / 0.45359237f; ///kg to lbs
                IdealWeight2 = 24.90f * (heightM * heightM);
                IdealWeight2 = IdealWeight2 / 0.45359237f; ///kg to lbs

            }

            return (IdealWeight1, IdealWeight2);
        }
    }
}
