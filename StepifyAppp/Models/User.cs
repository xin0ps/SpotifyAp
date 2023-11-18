using StepifyAppp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepifyAppp.Models
{
    public class User:NotificationService
    {

        private List<Library> libraries ;

        public List<Library> Libraries 
        {
            get { return libraries ; }
            set {  libraries= value;OnPropertyChanged(); }
        }



        private string name;
        
		public string  Name
		{
			get { return name; }
			set { name = value; OnPropertyChanged(); }

		}

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged(); }

        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }

        }

        private string password;

  

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }

        }


        public User()
        {
            this.name = "";
            this.surname = "";
            this.email = "";
            this.password = "";
            Libraries= new List<Library>();
        }
        public User(string name,  string surname,  string email,  string pssword)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password= pssword;
        }

        public override string ToString()
        {
            return $"{name}";
        }

    }
}
