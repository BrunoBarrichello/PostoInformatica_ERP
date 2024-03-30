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
    public class OBRASController : Controller
    {
        private readonly Contexto _context;

        public OBRASController(Contexto context)
        {
            _context = context;
        }

        // GET: OBRAS
        public async Task<IActionResult> Index()
        {
              return _context.OBRAS != null ? 
                          View(await _context.OBRAS.ToListAsync()) :
                          Problem("Entity set 'Contexto.OBRAS'  is null.");
        }

        // GET: OBRAS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OBRAS == null)
            {
                return NotFound();
            }

            var oBRAS = await _context.OBRAS
                .FirstOrDefaultAsync(m => m.INCREMENTO == id);
            if (oBRAS == null)
            {
                return NotFound();
            }

            return View(oBRAS);
        }

        // GET: OBRAS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OBRAS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("INCREMENTO,OBRA,DESCRICAO,CLIENTE,ENDERECO,NUMERO,CEP,COMPLEMENTO,REFERENCIA,BAIRRO,CONTATO1,CONTATO2,CIDADE,ESTADO,CEI,CIDADE_DESCRICAO,ISS,CONTRATO,CODIGOGIS,CODIGOGISRC,CONCLUSAO,OBSERVACOES,VALOR_CONTRATO,ISENTA_ISS,OFICIO,RETENCAO,EMPRESA,VALOREMPERMUTA,PERCENTUALPERMUTA,VALORPERMUTADOANTERIOR")] OBRAS oBRAS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oBRAS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oBRAS);
        }

        // GET: OBRAS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OBRAS == null)
            {
                return NotFound();
            }

            var oBRAS = await _context.OBRAS.FindAsync(id);
            if (oBRAS == null)
            {
                return NotFound();
            }
            return View(oBRAS);
        }

        // POST: OBRAS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("INCREMENTO,OBRA,DESCRICAO,CLIENTE,ENDERECO,NUMERO,CEP,COMPLEMENTO,REFERENCIA,BAIRRO,CONTATO1,CONTATO2,CIDADE,ESTADO,CEI,CIDADE_DESCRICAO,ISS,CONTRATO,CODIGOGIS,CODIGOGISRC,CONCLUSAO,OBSERVACOES,VALOR_CONTRATO,ISENTA_ISS,OFICIO,RETENCAO,EMPRESA,VALOREMPERMUTA,PERCENTUALPERMUTA,VALORPERMUTADOANTERIOR")] OBRAS oBRAS)
        {
            if (id != oBRAS.INCREMENTO)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oBRAS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OBRASExists(oBRAS.INCREMENTO))
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
            return View(oBRAS);
        }

        // GET: OBRAS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OBRAS == null)
            {
                return NotFound();
            }

            var oBRAS = await _context.OBRAS
                .FirstOrDefaultAsync(m => m.INCREMENTO == id);
            if (oBRAS == null)
            {
                return NotFound();
            }

            return View(oBRAS);
        }

        // POST: OBRAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OBRAS == null)
            {
                return Problem("Entity set 'Contexto.OBRAS'  is null.");
            }
            var oBRAS = await _context.OBRAS.FindAsync(id);
            if (oBRAS != null)
            {
                _context.OBRAS.Remove(oBRAS);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OBRASExists(int id)
        {
          return (_context.OBRAS?.Any(e => e.INCREMENTO == id)).GetValueOrDefault();
        }
    }
}
