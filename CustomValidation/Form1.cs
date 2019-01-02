using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PersonalInformation info = new PersonalInformation("Peter", null, -10, new Address(null, "Dong Nai", null));
            PersonalInformationValidate validate = new PersonalInformationValidate();
            string result = validate.ValidateAndGetResult(info, String.Instance);

            errorTextbox.Text = result;
        }

        bool IsLonger10(dynamic candidate)
        {
            if (candidate is string && candidate.Length > 10)
                return true;
            else
                return false;
        }
    }
}
