using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final.ViewModel
 {

public class GastosViewModel
{

public Guid Id {get;set;}
public string Descripcion {get;set;}
[Required(ErrorMessage = "El monto del gasto es requerido!")]
public float Monto {get;set;}
[Required(ErrorMessage = "Eliga la categoria del gasto!")]
public string Categoria {get;set;}




}



}