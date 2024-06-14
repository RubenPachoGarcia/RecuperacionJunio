using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Dtos
{
    internal class VehiculoDto
    {
        long id = 0;
        string matricula = "aaaaa";
        DateTime fechaMatriculacion;

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FechaMatriculacion { get => fechaMatriculacion; set => fechaMatriculacion = value; }

        public VehiculoDto()
        {
        }
    }
}
