using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaRodeio.Data;
using SistemaRodeio.Models;

namespace SistemaRodeio.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Home / Painel (Dashboard)
    public async Task<IActionResult> Index()
    {
        var viewModel = new DashboardViewModel
        {
            TotalAnimais = await _context.Animais.CountAsync(),
            TotalCompetidores = await _context.Competidores.CountAsync(),
            TotalCidades = await _context.Cidades.CountAsync(),
            TotalRounds = await _context.Rounds.CountAsync(),
            TotalTiposAnimais = await _context.TiposAnimais.CountAsync(),

            AnimaisPorTipo = await _context.Animais
                .GroupBy(a => a.tipoAnimal!.descricao)
                .Select(g => new AnimalPorTipo { Tipo = g.Key, Quantidade = g.Count() })
                .OrderByDescending(g => g.Quantidade)
                .ToListAsync(),

            TopCompetidores = await _context.Competidores
                .Include(c => c.cidade)
                .OrderByDescending(c => c.vitorias)
                .Take(5)
                .ToListAsync(),

            UltimosRounds = await _context.Rounds
                .Include(r => r.animal)
                .Include(r => r.competidor)
                .OrderByDescending(r => r.data)
                .Take(5)
                .ToListAsync()
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
