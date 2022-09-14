using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels; 

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List <EstudanteViewModel> estudantes = 
        new List<EstudanteViewModel>{
            new EstudanteViewModel (1, "Ana da Silva", "R. A, n.1", true),
            new EstudanteViewModel (2, "Carina Oliveira", "R. C, n.2", false),
            new EstudanteViewModel (3, "Carlos Campos", "R. K, n.3", true)
        };
            
    public IActionResult Index ()
    {
        return View(estudantes); 

    }

    public IActionResult Show (int id)
    {
        //var estudante = new EstudanteViewModel (5, "Lucas", "Rua L, n.11", false);
        return View(estudantes[id-1]); 
    }
}