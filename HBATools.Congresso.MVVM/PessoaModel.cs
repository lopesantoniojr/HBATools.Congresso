using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HBATools.Congresso.MVVM
{
    public class PessoaModel
    {
        public int id { get; set; }

        [Required]
        public string nome { get; set; }
        public string end_rua { get; set; }
        public string end_numero { get; set; }
        public string end_complemento { get; set; }
        public string end_bairro { get; set; }
        public string end_cidade { get; set; }
        public string end_estado { get; set; }
        public string end_cep { get; set; }

        [Required]
        public Nullable<int> id_pais { get; set; }
        public string end_zipcode { get; set; }
        public string telefone { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string nome_cracha { get; set; }
        public string observacao { get; set; }
        public Nullable<System.DateTime> datahora_cadastro { get; set; }
        public Nullable<System.DateTime> datahora_alteracao { get; set; }
    }
}
