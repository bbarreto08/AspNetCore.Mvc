using AspNetCore.Mvc.Site.Data;
using AspNetCore.Mvc.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly MeuDbContext _context;

        public HomeController(MeuDbContext meuDbContext)
        {
            _context = meuDbContext;
        }

        public IActionResult Index() 
        {
            var aluno = new Aluno 
            { 
                Nome = "Bruno"    ,
                DataNascimento = DateTime.Now,
                Email = "email@email.com"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            var aluno2 = _context.Alunos.Find(aluno.Id);

            var aluno3 = _context.Alunos.FirstOrDefault(a => a.Email == "email@email.com");

            var aluno4 = _context.Alunos.Where(a => a.Email == "email@email.com");

            aluno.Nome = "João";

            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            _context.Remove(aluno);
            _context.SaveChanges();

            return View("_Layout");            
        }
    }
}
