using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Data.Entity;

namespace HBATools.Congresso.Business
{
    public class PessoaFisicaBusiness
    {
        private DataLayer.Context c = new DataLayer.Context();

        public IList<MVVM.PessoaFisicaModel> Listar()
        {

            var pessoaModelCadastradas = c.PessoaFisica.ToList();

            List<MVVM.PessoaFisicaModel> pessoaFisicaLista = new List<MVVM.PessoaFisicaModel>();

            Mapper.CreateMap<Entities.PessoaFisica, MVVM.PessoaFisicaModel>();

            foreach (var item in pessoaModelCadastradas)
            {
                MVVM.PessoaFisicaModel personViews = Mapper.Map<Entities.PessoaFisica, MVVM.PessoaFisicaModel>(item);
                pessoaFisicaLista.Add(personViews);

            }
            return pessoaFisicaLista;

        }

        public bool Criar(MVVM.PessoaFisicaModel pessoaFisicaModel)
        {

            try
            {
                Mapper.CreateMap<MVVM.PessoaFisicaModel, Entities.PessoaFisica>();
                c.PessoaFisica.Add(Mapper.Map<Entities.PessoaFisica>(pessoaFisicaModel));
                return c.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Editar(MVVM.PessoaFisicaModel pessoaFisicaModel)
        {
            try
            {
                Mapper.CreateMap<MVVM.PessoaFisicaModel, Entities.PessoaFisica>();
                c.Entry(Mapper.Map<Entities.PessoaFisica>(pessoaFisicaModel)).State = EntityState.Modified;
                return c.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remover(long id)
        {
            var pessoaFisicaEncontrada = c.PessoaFisica.Find(id);
            try
            {
                c.PessoaFisica.Remove(pessoaFisicaEncontrada);
                //c.Entry(Mapper.Map<Entities.PessoaFisica>(pessoaFisicaModel)).State = EntityState.Deleted;
                return c.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MVVM.PessoaFisicaModel BuscaPorId(long id)
        {
            MVVM.PessoaFisicaModel pessoaFisica = new MVVM.PessoaFisicaModel();

            var pessoaFisicaEncontrada = c.PessoaFisica.Find(id);

            Mapper.CreateMap<Entities.PessoaFisica, MVVM.PessoaFisicaModel>();
            pessoaFisica = Mapper.Map<Entities.PessoaFisica, MVVM.PessoaFisicaModel>(pessoaFisicaEncontrada);

            return pessoaFisica;

        }
    }
}
