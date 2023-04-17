using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Models
{
    public class CartDetailsDto
    {
        public int CartDetailsId { get; set; }


        public int CartHeaderId { get; set; }

        public virtual CartHeaderDto CartHeader { get; set; }


        public int DrugId { get; set; }

        public virtual DrugDto Drug { get; set; }

        public int Count { get; set; }

    }
}
