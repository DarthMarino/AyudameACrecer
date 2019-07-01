using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Persona
    {
        int idPersona;
        string nombre;
        string apellido;
        string documento;
        TiposDocumentos tipoDocumento;
        string direccion;
        string telefono;
        DateTime fechaRegistro;
        DateTime fechaNacimiento;
        bool estado;

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Documento { get => documento; set => documento = value; }
        public TiposDocumentos TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public bool Estado { get => estado; set => estado = value; }

    }

    public enum TiposPersonas { Niño, Colaborador, Donador, Patrocinador, Tutor, Padrino};
    public enum TiposDocumentos { Cedula, Pasaporte};
}
