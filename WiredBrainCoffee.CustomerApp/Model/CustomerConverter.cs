using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.CustomerApp.Model
{
    public static class CustomerConverter
    {
        public static Customer CreateCutomerFromString(string inputString)
        {
            var values = inputString.Split(',');
            return new Customer
            {
                Firstname = values[0],
                Lastname = values[1],
                IsDeveloper = bool.Parse(values[2])
            };
        }
    }
}
