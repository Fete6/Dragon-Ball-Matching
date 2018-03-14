using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallMatching.Models
{
    public class UserClass : ObservableObject
    {
        private string _fname;
        private string _lname;
        private DateTime _birthday;
        private DateTime _startdate;
        private DateTime _enddate;
        private string _shortstory;
        private int _sexid;
        private int _areaid;

        public UserClass(string Fname, string Lname, DateTime Birthday, int Sexid, int Areaid, string Shortstory = null)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Birthday = Birthday;
            this.Sexid = Sexid;
            this.Areaid = Areaid;
            this.Shortstory = Shortstory;
        }

        public int Areaid
        {
            get { return _areaid; }
            set { _areaid = value; OnPropertyChanged("Areaid"); }
        }

        public int Sexid
        {
            get { return _sexid; }
            set { _sexid = value; OnPropertyChanged("Sexid"); }
        }

        public string Shortstory
        {
            get { return _shortstory; }
            set { _shortstory = value; OnPropertyChanged("Shortstory"); }
        }

        public DateTime Enddate
        {
            get { return _enddate; }
            set { _enddate = value; OnPropertyChanged("Enddate"); }
        }

        public DateTime Startdate
        {
            get { return _startdate; }
            set { _startdate = value; OnPropertyChanged("Startdate"); }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; OnPropertyChanged("Birthday"); }
        }


        public string Lname
        {
            get { return _lname; }
            set { _lname = value; OnPropertyChanged("Lname"); }
        }


        public string Fname
        {
            get { return _fname; }
            set { _fname = value; OnPropertyChanged("Fname"); }
        }

    }
}
