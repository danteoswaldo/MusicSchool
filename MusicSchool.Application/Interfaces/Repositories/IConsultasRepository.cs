using MusicSchool.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchool.Application.Interfaces.Repositories
{
    public interface IConsultasRepository
    {
        Task<List<AlumnoPorProfesorDto>> ObtenerAlumnosPorProfesor(int profesorId);
        Task<List<EscuelaAlumnoDto>> ObtenerEscuelasYAlumnosPorProfesor(int profesorId);
    }
}
