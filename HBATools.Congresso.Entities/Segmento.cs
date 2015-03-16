using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace HBATools.Congresso.Entities
{
    public partial class Segmento
    {
        public Segmento()
        {
            this.pessoa_juridica = new HashSet<PessoaJuridica>();
        }

        public int id { get; set; }
        public string descricao { get; set; }

        public virtual ICollection<PessoaJuridica> pessoa_juridica { get; set; }
    }
}
