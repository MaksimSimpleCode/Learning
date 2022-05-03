namespace EntityFrameworkAutoLotConsoleApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderID { get; set; }

        public int CustId { get; set; }

        public int CardId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Car Car { get; set; }
    }
}
