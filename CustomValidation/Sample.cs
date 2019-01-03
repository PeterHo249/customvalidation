using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    public class PersonalInformation
    {
        string _firstName;
        string _lastName;
        int _age;
        string _phone;
        Address _address;

        public PersonalInformation(string firstName, string lastName, int age, string phone, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
            Address = address;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public Address Address { get => _address; set => _address = value; }
    }

    public class Address
    {
        string _district;
        string _province;
        string _country;

        public Address(string district, string province, string country)
        {
            District = district;
            Province = province;
            Country = country;
        }

        public string District { get => _district; set => _district = value; }
        public string Province { get => _province; set => _province = value; }
        public string Country { get => _country; set => _country = value; }
    }

    public class AddressValidate : AbstractValidator<Address>
    {
        public AddressValidate()
        {
            RuleFor(x => x.District).IsNotNull("District have to be not null.");
            RuleFor(x => x.Province).IsNotNull("Province have to be not null.");
            RuleFor(x => x.Country).IsNotNull("Country have to be not null.");
        }
    }

    public class PersonalInformationValidate : AbstractValidator<PersonalInformation>
    {
        public PersonalInformationValidate()
        {
            RuleFor(x => x.FirstName).IsNotNull("First name have to be not null");
            RuleFor(x => x.LastName).IsNotNull("Last name have to be not null");
            RuleFor(x => x.Age).IsNotNull("Age have to be not null").IsGreaterThan(0, "Age have to be greater than 0");
            RuleFor(x => x.Phone).IsNotNull("Phone have to be not null").RegularExpression(@"^\d+$", "Phone have to contain all digit.").Must(IsLong10Char, "Phone number have to long 10 digits");
            RuleFor(x => x.Address, false).SetValidator(new AddressValidate());
        }

        bool IsLong10Char(dynamic candidate)
        {
            if (candidate is string && candidate.Length == 10)
                return true;
            else
                return false;
        }
    }
}
