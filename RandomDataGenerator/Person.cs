using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomDataGenerator
{
    internal class Person
    {
        private String[] _arrayOfFirstNames = {"Timothy","Thomas","Joey","Will Smith","Nathan","Jonah","Ryan","Bill","Bob","Joe"};
        public Dependent[] dependents;

        public string FirstName { get= _arrayOfFirstNames; init { _arrayOfFirstNames = value; } }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
        public SSN SSN { get; init; }
        public Phone Phone { get; init; }

        public Person(string firstName, string lastName, DateTime birthDate, SSN SSN, Phone phone)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            SSN = SSN;
            Phone = phone;
        }
        public int Age()
        {
            int x = 0;
            return x;
        }
        public void addDependent()
        {

        }
        override
        public string ToString()
        {
            return FirstName + "\n" + LastName + "\n" + BirthDate + "\n" + Age +"\n"+ SSN + "\n" + Phone +"\n"+ addDependent +"\n";
        }
    }
}
