///<summary>
///The purpose of the class is to contain functions that are used in this solution
///It is extended in all the solutions in the app
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Controll
    {
        /*
         *validateData() will check on the values that user typed.
         *validateData() require: 
             *a place to print an error on (errMsg), 
             *The input that the user typed the data in(DataInput), 
             *the data type of the data(type), 
             *the data to check on(data)
        *It will check if the data is null or empty function and check if the data got a write data type.
        *If any error accured, it will return an error to the user interface using the showError() function
        */

        /// <summary>
        /// validateData() will check on the values that user typed.
        /// validateData() require: 
            /// a place to print an error on (errMsg), 
            /// The input that the user typed the data in(DataInput), 
            /// The data type of the data(type), 
            /// The data to check on(data)
        /// It will check if the data is null or empty function and check if the data got a write data type.
        /// If any error accured, it will return an error to the user interface using the showError() function
        /// </summary>
        /// <param name="errMsg"></param>
        /// <param name="DataInput"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        public bool validateData(Label errMsg, Object DataInput, string type, string data)
        {
            if (String.IsNullOrEmpty(data))
            {
                showError(errMsg, defines.DATA_EMPTY, DataInput+ " cannot be empty");
                return false;
            }

            switch (type)
            {
                case "int":
                    int ignoreMeInt;
                    bool tryParseDataInt = int.TryParse(data, out ignoreMeInt);
                    if (!tryParseDataInt)
                    {
                        showError(errMsg, defines.DATA_TYPE_NOT_VALID, "you can only type int numbers inside " + DataInput);
                        return false;
                    }
                    break;

                case "float":
                    float ignoreMeFloat;
                    bool tryParseDataFloat = float.TryParse(data, out ignoreMeFloat);
                    if (!tryParseDataFloat)
                    {
                        showError(errMsg, defines.DATA_TYPE_NOT_VALID, "you can only type float numbers inside " + DataInput);
                        return false;
                    }
                    break;
                default:
                    showError(errMsg, defines.DATA_TYPE_NOT_VALID, "Wrong data type inside " + DataInput);
                    break;
            }
            return true;
        }


        /// <summary>
        /// the showError() function displays errors to the user interface
        /// showError() requires:
            /// a place to print the error on(errMsg)
            /// error code (errCode)
            /// error message(errMessage)
        /// </summary>
        /// <param name="errMsg"></param>
        /// <param name="errCode"></param>
        /// <param name="errMessage"></param>
        private void showError(Label errMsg, int errCode, string errMessage)
        {
            errMsg.Visible = true;
            errMsg.Text = "*Error: (" + errCode + ")" + errMessage;
        }

        /// <summary>
        /// ReadName() function will validate a name/text type string
        /// it will trim the text (removes all leading and trailing white-space characters)
        /// checks if the string is null or empty and return "Unknown" value.
        /// </summary>

        public string ReadName(TextBox BMIUserName)
        {
            BMIUserName.Text.Trim();
            if (!string.IsNullOrEmpty(BMIUserName.Text))
            {
                return BMIUserName.Text;
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
