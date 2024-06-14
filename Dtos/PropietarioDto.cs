using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Dtos
{
    internal class PropietarioDto
    {
        long id = 0;
        string dni = "aaaaa";
        DateTime fechaCompra;
        string matriculaPropietario = "aaaaa";
        bool esHistorico;

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public string MatriculaPropietario { get => matriculaPropietario; set => matriculaPropietario = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }

        public PropietarioDto(long id, string dni, DateTime fechaCompra, string matriculaPropietario, bool esHistorico)
        {
            Id = id;
            Dni = dni;
            FechaCompra = fechaCompra;
            MatriculaPropietario = matriculaPropietario;
            EsHistorico = esHistorico;
        }

        public PropietarioDto()
        {
        }

        override
        public string ToString()
        {
            string objetoString = String.Concat("Nuevo propietario: ", this.id, "-", this.dni);
            return objetoString;
        }
    }
}
