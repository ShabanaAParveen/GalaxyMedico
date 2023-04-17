using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDetailsDto
    {
        public int CartDetailsId { get; set; }


        public int CartHeaderId { get; set; }

        public virtual CartHeaderDto CartHeader { get; set; }


        public int DrugId { get; set; }

        public virtual Drug Drug { get; set; }

        public int Count { get; set; }

    }
}
