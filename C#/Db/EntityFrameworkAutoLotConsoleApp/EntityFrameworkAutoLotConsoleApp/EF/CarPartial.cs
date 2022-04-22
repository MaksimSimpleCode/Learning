using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAutoLotConsoleApp.EF
{
    public partial class Car
    {
        public override string ToString()
        {
            return $"{this.CarNickName ?? "**No Name**"} is a {this.Color} { this.Make} whith ID { this.CarId}.";
        }
    }
}
