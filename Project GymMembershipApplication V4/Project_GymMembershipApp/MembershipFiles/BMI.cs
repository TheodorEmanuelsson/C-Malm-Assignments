using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GymMembershipApp.MembershipFiles
{
    public class BMI
    {
        // Private fields
        private double m_height;
        private double m_weight;

        /// <summary>
        /// Get and Set property for height
        /// </summary>
        public double Height
        {
            get { return m_height; }
            set { m_height = value; }
        }
        /// <summary>
        /// Get and Set property for weight
        /// </summary>
        public double Weight
        {
            get { return m_weight; }
            set { m_weight = value; }
        }
        /// <summary>
        /// Get property for BMI Output information
        /// </summary>
        public string BMIOutput
        {
            get { return BMIInfoOut(); }
        }
        /// <summary>
        /// Calculates BMI
        /// </summary>
        /// <returns></returns>
        private double CalcBMI()
        {
            double bmi;

            bmi = m_weight / (m_height * m_height);

            return bmi;
        }
        /// <summary>
        /// Calculates Weight
        /// </summary>
        /// <param name="bmi"></param>
        /// <returns></returns>
        private double CalcWeight(double bmi)
        {
            double weight;

            weight = bmi * (Height * Height);

            return weight;
        }
        /// <summary>
        /// Weight category string
        /// </summary>
        /// <returns></returns>
        private string WeightCategory()
        {
            double bmi = CalcBMI();
            string stringOut;

            if (bmi < 18.5)
            {
                stringOut = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                stringOut = "Normal weight";
            }
            else if (bmi <= 29.9)
            {
                stringOut = "Overweight (Pre-obesity)";
            }
            else if (bmi <= 34.9)
            {
                stringOut = "Overweight (Obesity class I)";
            }
            else if (bmi <= 39.9)
            {
                stringOut = "Overweight (Obesity class II)";
            }
            else
            {
                stringOut = "Overweight (Obesity class III)";
            }
            return stringOut;
        }
        /// <summary>
        /// BMI output string
        /// </summary>
        /// <returns></returns>
        private string BMIInfoOut()
        {
            string newLine = Environment.NewLine;
            string bmi = CalcBMI().ToString("f2");
            string category = WeightCategory();
            string lowerbound = CalcWeight(18.5).ToString("f2");
            string upperbound = CalcWeight(24.9).ToString("f2");
            string normalweight = "Normal weight should be between " + lowerbound + " and " + upperbound + " kg. ";
            string normalbmi = "Normal BMI is between 18.5 and 24.9";

            string Out = newLine +
                "Selected member has BMI of " + bmi + newLine + newLine +
                normalbmi + newLine + newLine +
                normalweight + newLine + newLine +
                "BMI Category: " + category;

            return Out;
        }
    }
}
