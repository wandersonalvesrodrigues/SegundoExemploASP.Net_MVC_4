using SegundoExemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegundoExemploMVC.Controllers
{
    public class HomeController : Controller
    {
        //Chama o conteúdo via Gel, é o padrão mas poderiamos adiciona a anotação [HttpGet].
        public ActionResult Index()
        {
            var pessoa = new Pessoa() { PessoaId = 1, Nome = "João", Twitter = "@joão" };
            //Primeira forma de envio de dados - ViewData
            /*
            ViewData["pessoaId"] = pessoa.PessoaId;
            ViewData["nome"] = pessoa.Nome;
            ViewData["twitter"] = pessoa.Twitter;
             */

            //Segunda forma de envio de dados - ViewBag
            /*
            ViewBag.pessoaId = pessoa.PessoaId;
            ViewBag.nome = pessoa.Nome;
            ViewBag.twitter = pessoa.Twitter;
             * */

            //Terceira forma de enviar dados - View tipada
            return View(pessoa);
        }
        //Primeira forma de receber dados via post, usando parametros
        /*
        [HttpPost]
        public ActionResult Lista(int pessoaId, string nome, string twitter)
        {
            ViewData["pessoaId"] = pessoaId;
            ViewData["nome"] = nome;
            ViewData["twitter"] = twitter;

            return View();
        }
        */

        //Primeira forma de receber dados via get, usando parametros
        /*
        public ActionResult Lista(int pessoaId,string nome,string twitter)
        {
            ViewData["pessoaId"] = pessoaId;
            ViewData["nome"] = nome;
            ViewData["twitter"] = twitter;

            return View();
        }
        */

        //Segunda forma de receber dados via post, usando FormCollection
        /*
        [HttpPost]
        public ActionResult Lista(FormCollection form)
        {
            ViewData["pessoaId"] = form["pessoaId"];
            ViewData["nome"] = form["nome"];
            ViewData["twitter"] = form["twitter"];

            return View();
        }
        */

        //Terceira forma de receber dados via post, usando objeto
        /*
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["pessoaId"] = pessoa.PessoaId;
            ViewData["nome"] = pessoa.Nome;
            ViewData["twitter"] = pessoa.Twitter;

            return View();
        }
        */

        //View Tipada em Lista
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}
