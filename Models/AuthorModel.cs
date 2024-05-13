using System;

namespace ASP_MVC_Library.Models
{
    public class AuthorModel
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public AuthorModel(int id, string firstName, string lastName, DateTime birthDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public AuthorModel()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
    }
}
