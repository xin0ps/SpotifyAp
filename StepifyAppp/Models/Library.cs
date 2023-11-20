using StepifyAppp.Services;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepifyAppp.Models
{
    public class Library : NotificationService
    {

        private string _libraryName;

        public string LibraryName
        {
            get { return _libraryName; ; }
            set { _libraryName = value; OnPropertyChanged(); }
        }



        private List<Track> librarysongs;
        public List<Track> LibrarySongs
        {
            get { return librarysongs; }
            set { librarysongs = value; OnPropertyChanged(); }

        }

        public Library()
        {
           
        }

        public Library(string libraryName)
        {
            LibraryName = libraryName;
          
          
        }
        public override string ToString()
        {
            return LibraryName;
        }
    }
}