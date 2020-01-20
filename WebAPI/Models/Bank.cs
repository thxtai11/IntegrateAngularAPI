using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPI.Models
{
    public class Bank
    {
        public Bank()
        {

        }
     //   [Key]
        public int BankID { get; set; }
     //   [Column(TypeName="nvarchar(100)")]
        public string BankName { get; set; }

    }
}
