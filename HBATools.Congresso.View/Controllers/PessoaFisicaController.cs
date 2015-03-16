using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HBATools.Congresso.View.Controllers
{
    public class PessoaFisicaController : Controller
    {
        //
        // GET: /PessoaFisica/

        private Business.PessoaFisicaBusiness pessoaFisicaBusiness = new Business.PessoaFisicaBusiness();
        private Business.PessoaJuridicaBusiness pessoaJuridicaBusiness = new Business.PessoaJuridicaBusiness();


        public ActionResult Index()
        {
            var lista = pessoaFisicaBusiness.Listar();
            return View(lista);
        }

        public ActionResult Adicionar()
        {
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(MVVM.PessoaFisicaModel pessoaFisicaModel)
        {
            pessoaFisicaBusiness.Criar(pessoaFisicaModel);
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return RedirectToAction("Index") ;
        }

        public ActionResult Editar(long id)
        {
            MVVM.PessoaFisicaModel pessoaFisica = pessoaFisicaBusiness.BuscaPorId(id);
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return View(pessoaFisica);
        }

        [HttpPost]
        public ActionResult Editar(MVVM.PessoaFisicaModel pessoaFisicaModel)
        {
            pessoaFisicaBusiness.Editar(pessoaFisicaModel);
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(long id)
        {
            pessoaFisicaBusiness.Remover(id);

            return RedirectToAction("Index");
        }

    }
}
