using Microsoft.AspNetCore.Mvc;
using Final.ViewModel;

namespace Final.Controllers {

public class AppController : Controller {
    
private static List<GastosViewModel> _gasto = new List<GastosViewModel>();

    public IActionResult Index(){
        return View(_gasto);
    }

    public IActionResult Edit(Guid id){
        var gasto = _gasto.FirstOrDefault(x=> x.Id == id);
        return View(gasto);
    }

    [HttpPost]
    public IActionResult Edit(GastosViewModel model){
      
        var gasto = _gasto.FirstOrDefault(x=> x.Id == model.Id);
        if(ModelState.IsValid){
            if(gasto == null){
                model.Id =  Guid.NewGuid();    
                
                _gasto.Add(model);
            }
            else
            {
              gasto.Descripcion = model.Descripcion;
              gasto.Monto = model.Monto;
              gasto.Categoria = model.Categoria;
            }
             return RedirectToAction(nameof(Index));
        }
      
        return View();
    }
    

 public IActionResult Delete(Guid id){
    var gasto = _gasto.FirstOrDefault(x=> x.Id == id);
    if(gasto != null){
        _gasto.Remove(gasto);
    }
    return RedirectToAction(nameof(Index));
 }







    }
}