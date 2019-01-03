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

            PersonalInformation info = new PersonalInformation("Peter", null, -10, "0s1235678", new Address(null, "Dong Nai", null));
            PersonalInformationValidate validate = new PersonalInformationValidate();
            string result = validate.ValidateAndGetResult(info, String.Instance);

            var candidate = "as";
            var numberValidate = new Builder().RuleFor(candidate).IsNumber("This have to be number").GetProduct();
            result += "\n\n" + numberValidate.ValidateAndGetResult(candidate, String.Instance);

            errorTextbox.Text = result;
        }
    }
}
