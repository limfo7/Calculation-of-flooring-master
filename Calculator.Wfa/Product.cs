namespace Calculator.Wfa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderforBuyings = new HashSet<OrderforBuying>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public int ManufacturerId { get; set; }

        public int CoverageTypeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public double? Coast1 { get; set; }

        public double? CoastOpt { get; set; }

        public virtual CoverageType CoverageType { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderforBuying> OrderforBuyings { get; set; }
    }
}
