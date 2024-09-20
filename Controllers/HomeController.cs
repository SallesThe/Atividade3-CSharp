using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // * Instâncias Clientes
        Cliente cliente1 = new Cliente(01, "João", "056.458.795-45", "joao@gmail.com", "Madruga");
        Cliente cliente2 = new Cliente(02, "Maria", "895.288.755-45", "maria@gmail.com", "Susy");
        Cliente cliente3 = new Cliente(03, "Davi", "057.418.772-45", "davi@gmail.com", "Caju");

        // * Lista de Clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);

        ViewBag.listaClientes = listaClientes;

        // * Instâncias Fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Virtude LTDA", "789.456.456/22", "virtude@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Dandara LTDA", "759.998.352/74", "dandara@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "MyPets LTDA", "879.123.789/65", "mypets@gmail.com");
        
        // * Lista de Fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
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
