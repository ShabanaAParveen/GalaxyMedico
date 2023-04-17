using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.ShoppingCartAPI.Models
{
    public class CartDetails
    {
        public int CartDetailsId { get; set; }

        [ForeignKey("CartHeaderId")]
        public int CartHeaderId { get; set; }

        public virtual CartHeader CartHeader { get; set; }

        [ForeignKey("DrugId")]
        public int DrugId { get; set; }

        public virtual Drug Drug { get; set; }

        public int Count { get; set; }

    }
}
