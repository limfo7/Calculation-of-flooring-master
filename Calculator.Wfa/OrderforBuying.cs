namespace Calculator.Wfa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderforBuying")]
    public partial class OrderforBuying
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        [StringLength(100)]
        public string OrderNumber { get; set; }

        public virtual Product Product { get; set; }
    }
}
