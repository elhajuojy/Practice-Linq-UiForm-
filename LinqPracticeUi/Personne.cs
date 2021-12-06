using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeUi
{
    public class Personne
    {
        private string firstName;
        private string lastName;
        private int age;
        private string city;
        private long[] numbers;







        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public String City { get { return city; } set { city = value; } }
        public long [] Numbers { get { return numbers; } set { numbers = value; } }

        public Personne()
        {
            numbers = new long[0];
        }
        public Personne(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;

        }

    }
}
