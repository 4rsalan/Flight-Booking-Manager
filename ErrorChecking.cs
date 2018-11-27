using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    class ErrorChecking
    {
        public ErrorChecking() { }

        public bool CheckForNumericsOnly(string textBoxInput)
        {
            int value = -1;
            return int.TryParse(textBoxInput, out value);
        }

        public bool CheckForLettersOnly(string textBoxInput)
        {
            bool inputFlag = true;
            int ascii;

            //checks if input is only spaces
            for (int x = 0; x < textBoxInput.Length; x++)
            {
                ascii = textBoxInput[x];
                if (ascii != 32)
                {
                    inputFlag = true;
                    break;
                }
            }
            if (!inputFlag)
            {
                return false;
            }

            //checks for symbols and numbers
            for (int y = 0; y < textBoxInput.Length; y++)
            {
                ascii = textBoxInput[y];
                if ((ascii < 65 || (ascii > 90 && ascii < 97) || ascii > 122) && ascii != 32)
                {
                    inputFlag = false;
                }
            }

            return inputFlag;
        }

        public bool CheckPhoneNumber(string textBoxInput)
        {
            int ascii;
            bool inputFlag = false;

            //checks if input is only spaces
            for (int x = 0; x < textBoxInput.Length; x++)
            {
                ascii = textBoxInput[x];
                if (ascii != 32)
                {
                    inputFlag = true;
                }
            }
            if (!inputFlag || textBoxInput == "")
            {
                return false;
            }

            //checks for symbols and numbers
            for (int y = 0; y < textBoxInput.Length; y++)
            {
                ascii = textBoxInput[y];
                if ((ascii < 48 || ascii > 57) && ascii != 45)
                {
                    inputFlag = false;
                }
            }

            return inputFlag;
        }
    }
}
