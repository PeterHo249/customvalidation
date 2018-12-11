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
            string candidate = "10.3a@adwqvfqdqdqd";
            MonoValidate monoValidate = Builder.Instance.RuleFor(candidate).IsNotNull("This have to be not null.").Must(IsLonger10, "your string have longer than 10 character.").GetProduct();
            monoValidate.Validate();
            string result = monoValidate.GetResult(String.Instance);
            System.Diagnostics.Debug.WriteLine(result);
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
