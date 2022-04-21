using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using AutoLotDAL.Models.Base;

namespace AutoLotDAL.Models
{
    public partial class Inventory: EntityBase
    {
        [NotMapped]
        public string MakeColor => $"{Make} + ({Color})";
        public override string ToString()
        {
            return $"{this.PetName ?? "**No Name**"} is a {this.Color} { this.Make} whith ID { this.CarId}.";
        }
    }
}
