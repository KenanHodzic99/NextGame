using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class IgricaPlatforma
    {
        [Required]
        public int IgricaId { get; set; }
        [Required]
        public int PlatformaId { get; set; }
    }
}
