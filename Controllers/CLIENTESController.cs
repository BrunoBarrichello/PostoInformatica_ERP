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
    public class CLIENTESController : Controller
    {
        private readonly Contexto _context;

        public CLIENTESController(Contexto context)
        {
            _context = context;
        }

        // GET: CLIENTES
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(CLIENTES clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CLIENTES login = _context.Cliente.FirstOrDefault(x => x.LOGIN == clientes.LOGIN);
                    if (login != null)
                    {
                        if (!string.IsNullOrEmpty(login.LOGIN))
                        {
                            if (login.SENHA == clientes.SENHA)
                            {
                                return RedirectToAction("Index", "Home");
                            }

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

        // GET: CLIENTES/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Cliente == null)
            {
                return NotFound();
            }

            var clientes = await _context.Cliente
                .FirstOrDefaultAsync(m => m.CNPJ_CPF == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // GET: CLIENTES/Create
        public IActionResult Create()
        {
            var model = new CLIENTES();
            return View(model);
        }

        // POST: CLIENTES/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CNPJ_CPF,RG_INSCRICAO,INSCRICAOMUNICIPAL,NOME,FANTASIA,COLIGADA,CEP,CEP_COBRANCA,ENDERECO,ENDERECO_COBRANCA,NUMERO,NUMERO_COBRANCA,COMPLEMENTO,COMPLEMENTO_COBRANCA,BAIRRO,BAIRRO_COBRANCA,CIDADE,CIDADE_COBRANCA,CIDADE_IBGE,ESTADO,ESTADO_COBRANCA,CAIXA_POSTAL,CAIXA_POSTAL_COBRANCA,PAIS,FONE,FONE_RAMAL,CELULAR,INTERNET,CONTATO,EMAIL,COND_PAGAMENTO,CODIGO,LOGIN,SENHA,VENDEDOR,OPTANTE_SIMPLES")] CLIENTES clientes)
        {
            if (!ModelState.IsValid)
            {
                return View(clientes);
            }

            CLIENTES dadosCliente = _context.Cliente
                .FirstOrDefault(x => x.LOGIN == clientes.LOGIN || x.CNPJ_CPF == clientes.CNPJ_CPF);

            

            if (dadosCliente == null)
            {
                clientes.OPTANTE_SIMPLES = clientes.OPTANTE_SIMPLES == "S" ? "S" : "N";
                clientes.COLIGADA = clientes.COLIGADA == "S" ? "S" : "N";

                _context.Add(clientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            List<string> mensagemErro = new List<string>();

            if (dadosCliente.LOGIN == clientes.LOGIN)
            {
                mensagemErro.Add("Nome de usuário já utilizado.");
            }

            if (dadosCliente.CNPJ_CPF == clientes.CNPJ_CPF)
            {
                mensagemErro.Add("CPF/CNPJ já utilizado.");
            }

            TempData["MensagemErro"] = string.Join("<br>", mensagemErro);

            return View(clientes);
        }

        // GET: CLIENTES/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Cliente == null)
            {
                return NotFound();
            }

            var clientes = await _context.Cliente.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }
            return View(clientes);
        }

        // POST: CLIENTES/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CNPJ_CPF,RG_INSCRICAO,INSCRICAOMUNICIPAL,NOME,FANTASIA,COLIGADA,CEP,CEP_COBRANCA,ENDERECO,ENDERECO_COBRANCA,NUMERO,NUMERO_COBRANCA,COMPLEMENTO,COMPLEMENTO_COBRANCA,BAIRRO,BAIRRO_COBRANCA,CIDADE,CIDADE_COBRANCA,CIDADE_IBGE,ESTADO,ESTADO_COBRANCA,CAIXA_POSTAL,CAIXA_POSTAL_COBRANCA,PAIS,FONE,FONE_RAMAL,CELULAR,INTERNET,CONTATO,EMAIL,COND_PAGAMENTO,CODIGO,LOGIN,SENHA,VENDEDOR,OPTANTE_SIMPLES")] CLIENTES clientes)
        {
            if (id != clientes.CNPJ_CPF)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CLIENTESExists(clientes.CNPJ_CPF))
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
            return View(clientes);
        }

        // GET: CLIENTES/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Cliente == null)
            {
                return NotFound();
            }

            var clientes = await _context.Cliente
                .FirstOrDefaultAsync(m => m.CNPJ_CPF == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // POST: CLIENTES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Cliente == null)
            {
                return Problem("Entity set 'Contexto.Cliente'  is null.");
            }
            var clientes = await _context.Cliente.FindAsync(id);
            if (clientes != null)
            {
                _context.Cliente.Remove(clientes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CLIENTESExists(string id)
        {
            return (_context.Cliente?.Any(e => e.CNPJ_CPF == id)).GetValueOrDefault();
        }
    }
}
