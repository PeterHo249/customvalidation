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
            int candidate = 10;
            MonoValidate monoValidate = Builder.GetBuilder().RuleFor(candidate).IsNotNull("This have to be not null.").IsGreaterThan("ab", "This have to be greater than 15").GetProduct();
            monoValidate.Validate();
            string result = monoValidate.GetResult(new String());
            System.Diagnostics.Debug.WriteLine(result);
        }
    }
}
