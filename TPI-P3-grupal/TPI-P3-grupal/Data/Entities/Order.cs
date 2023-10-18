using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPI_P3_grupal.Data.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Paymant { get; set; }
        public DateTime CreationDate { get; } = DateTime.Now.ToUniversalTime();
        public string TotalPrize { get; set; }

        /*
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }        ///CONSULTAR al profe
        public int ProductId { get; set; }
        */
    }
}
