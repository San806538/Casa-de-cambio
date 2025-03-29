using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using casa_cambio.Models;

namespace casa_cambio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult calcular(double cantidad, int opcion){
        double cantCambiado = 0;
        if(cantidad!=null){
            if(opcion==1){
                cantCambiado = cantidad *0.6338236;
            }else if(opcion == 2){
                cantCambiado = cantidad*1.577726;
            }
        }
        ViewBag.cantCambio = Math.Round(cantCambiado, 2);;
        ViewBag.cantidad = cantidad;
        return View("Index");
    }

    public IActionResult generarBoleta(double cantidad,double cantCambiado){
        ViewBag.cantCambio = cantCambiado;
        ViewBag.cantidad = cantidad;
    
        return View("GenerarBoleta");       
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
