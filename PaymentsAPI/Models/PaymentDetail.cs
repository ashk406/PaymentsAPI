using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentsAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int  PaymentDetailID { get; set; }
        
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwner { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; } = string.Empty;

        //mm/yy
        [Column(TypeName = "nvarchar(5)")]
        public string ExpiryDate { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(13)")]
        public string SecurityCode { get; set; } = string.Empty;
    }
}
