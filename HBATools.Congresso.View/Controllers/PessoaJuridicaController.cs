using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HBATools.Congresso.View.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        //
        // GET: /PessoaJuridica/

        private Business.PessoaJuridicaBusiness pessoaJuridicaBusiness = new Business.PessoaJuridicaBusiness();

        public ActionResult Index()
        {
            var lista = pessoaJuridicaBusiness.Listar();
            return View(lista);
        }

        public ActionResult Adicionar() {
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(MVVM.PessoaJuridicaModel pessoaJuridicaModel)
        {
            pessoaJuridicaBusiness.Criar(pessoaJuridicaModel);
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return RedirectToAction("Index");
        }

        public ActionResult Editar(long id)
        {
            MVVM.PessoaJuridicaModel pessoaJuridica = pessoaJuridicaBusiness.BuscaPorId(id);
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return View(pessoaJuridica);
        }

        [HttpPost]
        public ActionResult Editar(MVVM.PessoaJuridicaModel pessoaJuridicaModel)
        {
            pessoaJuridicaBusiness.Editar(pessoaJuridicaModel);
            ViewBag.id_pessoa_juridica = new SelectList(pessoaJuridicaBusiness.Listar(), "id", "nome");
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(long id)
        {
            pessoaJuridicaBusiness.Remover(id);

            return RedirectToAction("Index");
        }

    }
}
