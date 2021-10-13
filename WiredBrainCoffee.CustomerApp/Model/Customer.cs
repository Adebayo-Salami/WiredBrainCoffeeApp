using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomerApp.Base;

namespace WiredBrainCoffee.CustomerApp.Model
{
    public class Customer : Obervable
    {
        private string firstname;
        private string lastname;
        private bool isDeveloper;

        //public string Firstname { get => firstname; set { firstname = value; OnPropertyChanged(nameof(Firstname)); } }
        public string Firstname { get => firstname; set { firstname = value; OnPropertyChanged(); } }
        public string Lastname { get => lastname; set { lastname = value; OnPropertyChanged(); } }
        public bool IsDeveloper
        {
            get => isDeveloper;
            set
            {
                isDeveloper = value;
                OnPropertyChanged();
            }
        }
    }
}
