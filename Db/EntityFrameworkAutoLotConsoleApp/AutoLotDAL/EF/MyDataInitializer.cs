using System;
using System.Collections.Generic;
using System.Linq;
using AutoLotDAL.Models;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AutoLotDAL.EF
{
    public class MyDataInitializer:DropCreateDatabaseAlways<AutoLotEntities>
    {
        protected override void Seed(AutoLotEntities context)
        {
            base.Seed(context);
        }
    }
}
