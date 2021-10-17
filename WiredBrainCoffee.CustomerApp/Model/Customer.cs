using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using WiredBrainCoffee.CustomerApp.Base;

namespace WiredBrainCoffee.CustomerApp.Model
{
    [CreateFromString(MethodName = "WiredBrainCoffee.CustomerApp.Model.CustomerConverter.CreateCutomerFromString")]
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
