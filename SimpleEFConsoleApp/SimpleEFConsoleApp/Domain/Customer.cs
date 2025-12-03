using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFConsoleApp.Domain
{
    class Customer
    {

        //convention(primarykey/auto generated)
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return $"id {this.Id}, name {this.Name} ,address {this.Address}";
        }

    }
}
