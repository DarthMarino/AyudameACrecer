using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Colaborador : Persona
    {
        decimal sueldo;
        string ocupacion;

        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }
    }
}
