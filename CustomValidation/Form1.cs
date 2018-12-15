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
    public class PersonalInformation
    {
        string _firstName;
        string _lastName;
        int _age;

        public PersonalInformation(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
    }

    public class PersonalInformationValidate : AbstractValidator<PersonalInformation>
    {
        public PersonalInformationValidate()
        {
            RuleFor(x => x.FirstName).IsNotNull("First name have to be not null");
            RuleFor(x => x.LastName).IsNotNull("Last name have to be not null");
            RuleFor(x => x.Age).IsNotNull("Age have to be not null").IsGreaterThan(0,"Age have to be greater than 0");
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PersonalInformation info = new PersonalInformation("Peter", null, -10);
            PersonalInformationValidate validate = new PersonalInformationValidate();
            string result = validate.ValidateAndGetResult(info, String.Instance);
            
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
