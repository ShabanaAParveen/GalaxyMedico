using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.OrderAPI.Messages
{
    public class CartDetailsDto
    {
        public int CartDetailsId { get; set; }


        public int CartHeaderId { get; set; }

        public int DrugId { get; set; }

        public virtual DrugDto Drug { get; set; }

        public int Count { get; set; }

    }
}
