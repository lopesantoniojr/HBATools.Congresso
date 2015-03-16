using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HBATools.Congresso.Entities
{

    [Table("pessoa_fisica")]
    public class PessoaFisica : Pessoa
    {
        public Nullable<int> id_pessoa_juridica { get; set; }
        public string cpf { get; set; }
        public string passaporte { get; set; }
        public string registro_conselho { get; set; }
        public string rg { get; set; }
        public string tratamento { get; set; }
        public string nome_completo { get; set; }
        public string email { get; set; }
        public System.DateTime data_nascimento { get; set; }
        public string foto { get; set; }
        public string biometria { get; set; }
        public string sexo { get; set; }

        [ForeignKey("id_pessoa_juridica")]
        public virtual PessoaJuridica pessoa_juridica { get; set; }
    }
}
