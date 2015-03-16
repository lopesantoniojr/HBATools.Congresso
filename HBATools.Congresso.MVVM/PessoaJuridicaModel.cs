﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HBATools.Congresso.MVVM
{
    public class PessoaJuridicaModel : PessoaModel
    {
        public int id_segmento { get; set; }
        public string cnpj { get; set; }
        public string insc_estadual { get; set; }
        public string insc_municipal { get; set; }
        public string codigo_produtor_rural { get; set; }
        public string doc_empresa_estrangeira { get; set; }
        public string nome_fantasia { get; set; }
        public string site { get; set; }
        public Nullable<System.DateTime> data_abertura { get; set; }
    }
}
