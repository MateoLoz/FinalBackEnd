using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Final.GastosDto {

    public class GastosDto {

        public string Descripcion {get;set;}
        public decimal Monto {get;set;}
        public string Categoria {get;set;}
    }
}