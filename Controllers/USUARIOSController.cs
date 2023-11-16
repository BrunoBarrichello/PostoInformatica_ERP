using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PostoInformatica_ERP.Models;

namespace PostoInformatica_ERP.Controllers
{
    public class USUARIOSController : Controller
    {
        private readonly Contexto _context;

        public USUARIOSController(Contexto context)
        {
            _context = context;
        }

        // GET: USUARIOS
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(USUARIO usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    USUARIO login = _context.USUARIO.FirstOrDefault(x => x.NOME == usuario.NOME);

                    if (login != null)
                    {
                        if (login.SENHA == usuario.SENHA)
                        {
                            return RedirectToAction("Index", "Home");
                        }

                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente! {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        // GET: USUARIOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.USUARIO == null)
            {
                return NotFound();
            }

            var uSUARIO = await _context.USUARIO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (uSUARIO == null)
            {
                return NotFound();
            }

            return View(uSUARIO);
        }

        // GET: USUARIOS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: USUARIOS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NOME,SENHA,CPF,USUARIO_EMAIL,SENHA_EMAIL")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uSUARIO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uSUARIO);
        }

        // GET: USUARIOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.USUARIO == null)
            {
                return NotFound();
            }

            var uSUARIO = await _context.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return NotFound();
            }
            return View(uSUARIO);
        }

        // POST: USUARIOS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NOME,SENHA,CPF,USUARIO_EMAIL,SENHA_EMAIL")] USUARIO uSUARIO)
        {
            if (id != uSUARIO.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uSUARIO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!USUARIOExists(uSUARIO.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(uSUARIO);
        }

        // GET: USUARIOS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.USUARIO == null)
            {
                return NotFound();
            }

            var uSUARIO = await _context.USUARIO
                .FirstOrDefaultAsync(m => m.ID == id);
            if (uSUARIO == null)
            {
                return NotFound();
            }

            return View(uSUARIO);
        }

        // POST: USUARIOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.USUARIO == null)
            {
                return Problem("Entity set 'Contexto.USUARIO'  is null.");
            }
            var uSUARIO = await _context.USUARIO.FindAsync(id);
            if (uSUARIO != null)
            {
                _context.USUARIO.Remove(uSUARIO);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool USUARIOExists(int id)
        {
          return (_context.USUARIO?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
