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
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PersonalInformation personalInformation = new PersonalInformation("Peter", null, -10);
            
            CompositeValidate personValidate = new CompositeValidate();
            MonoValidate firstNameValidate = Builder.Instance.RuleFor(personalInformation.FirstName).IsNotNull("First name have to be not null").GetProduct();
            MonoValidate lastNameValidate = Builder.Instance.RuleFor(personalInformation.LastName).IsNotNull("Last name have to be not null").GetProduct();
            MonoValidate ageValidate = Builder.Instance.RuleFor(personalInformation.Age).IsNotNull("Age have to be not null").IsGreaterThan(0, "Age have to be greater than 0").GetProduct();
            personValidate.Add(firstNameValidate);
            personValidate.Add(lastNameValidate);
            personValidate.Add(ageValidate);

            string result = personValidate.ValidateAndGetResult(String.Instance);
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
