//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HBATools.Congresso.View.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pessoa_fisica : pessoa
    {
        public long id_pessoa_juridica { get; set; }
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
    
        public virtual pessoa_juridica pessoa_juridica { get; set; }
    }
}
