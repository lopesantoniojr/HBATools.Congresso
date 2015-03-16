using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Data.Entity;

namespace HBATools.Congresso.Business
{
    public class PessoaJuridicaBusiness
    {

        private DataLayer.Context c = new DataLayer.Context();

        public IList<MVVM.PessoaJuridicaModel> Listar()
        {

            var pessoaJuridicaCadastradas = c.PessoaJuridica.ToList();

            List<MVVM.PessoaJuridicaModel> pessoaJuridicaLista = new List<MVVM.PessoaJuridicaModel>();

            AutoMapper.Mapper.CreateMap<Entities.PessoaJuridica, MVVM.PessoaJuridicaModel>();

            foreach (var item in pessoaJuridicaCadastradas)
            {
                MVVM.PessoaJuridicaModel personViews = Mapper.Map<Entities.PessoaJuridica, MVVM.PessoaJuridicaModel>(item);
                pessoaJuridicaLista.Add(personViews);
            }

            return pessoaJuridicaLista;   
        }

        //public IList<MVVM.SegmentoModel> ListarSegmento() {

        //    var segmentosCadastrados = c.Segmento.ToList();

        //    List<MVVM.SegmentoModel> segmentoLista = new List<MVVM.SegmentoModel>();

        //    AutoMapper.Mapper.CreateMap<Entities.Segmento, MVVM.SegmentoModel>();

        //    foreach (var item in segmentosCadastrados)
        //    {
        //        MVVM.SegmentoModel personViews = Mapper.Map<Entities.Segmento, MVVM.SegmentoModel>(item);
        //        segmentoLista.Add(personViews);
        //    }

        //    return segmentoLista;   
        
        //}

        public bool Criar(MVVM.PessoaJuridicaModel pessoaJuridicaModel)
        {

            try
            {
                Mapper.CreateMap<MVVM.PessoaJuridicaModel, Entities.PessoaJuridica>();
                c.PessoaJuridica.Add(Mapper.Map<Entities.PessoaJuridica>(pessoaJuridicaModel));
                return c.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Editar(MVVM.PessoaJuridicaModel pessoaJuridicaModel)
        {
            try
            {
                Mapper.CreateMap<MVVM.PessoaJuridicaModel, Entities.PessoaJuridica>();
                c.Entry(Mapper.Map<Entities.PessoaJuridica>(pessoaJuridicaModel)).State = EntityState.Modified;
                return c.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Remover(long id)
        {
            var pessoaJuridicaEncontrada = c.PessoaJuridica.Find(id);
            try
            {
                c.PessoaJuridica.Remove(pessoaJuridicaEncontrada);
                //c.Entry(Mapper.Map<Entities.PessoaJuridica>(pessoaJuridicaModel)).State = EntityState.Deleted;
                return c.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MVVM.PessoaJuridicaModel BuscaPorId(long id)
        {
            MVVM.PessoaJuridicaModel pessoaJuridica = new MVVM.PessoaJuridicaModel();

            var pessoaJuridicaEncontrada = c.PessoaJuridica.Find(id);

            Mapper.CreateMap<Entities.PessoaJuridica, MVVM.PessoaJuridicaModel>();
            pessoaJuridica = Mapper.Map<Entities.PessoaJuridica, MVVM.PessoaJuridicaModel>(pessoaJuridicaEncontrada);

            return pessoaJuridica;

        }


        public object ListarSegmento()
        {
            throw new NotImplementedException();
        }
    }
}
