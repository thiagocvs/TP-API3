using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TP_API3
{
    [ApiController]
    [Route("[controller]")]
    public class MateriaController : ControllerBase
    {
        List<Materia> materias = new List<Materia>
        {
            new Materia { Id = 1, Nombre = "Programación II", CupoMaximo = 35 },
            new Materia { Id = 2, Nombre = "Bases de Datos", CupoMaximo = 30 },
            new Materia { Id = 3, Nombre = "Sistemas", CupoMaximo = 40 },
            new Materia { Id = 4, Nombre = "Inglés", CupoMaximo = 25 }
        };

    //Get /materia devolver todas las materias
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(materias);
    }

    //GET /materia/{id}
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        foreach (Materia m in materias)
        {
            if (m.Id == id)
            {
                return Ok(m);
            }
        }

        return NotFound("Materia no encontrada.");
    }

        //Post materia
        [HttpPost]
        public IActionResult Post([FromBody] Materia materiaEntrante)
        {
            materias.Add(materiaEntrante);
            return Ok(materiaEntrante);
        }

        //Post materia/{idmateria}/inscribir
        [HttpPost("{id}/inscribir")]
        public IActionResult InscribirAlumno(int id, [FromBody] Alumno alumnoEntrante)
        {
            foreach (Materia m in materias)
            {
                if (m.Id == id)
                {
                    if (m.Alumnos.Count < m.CupoMaximo)
                    {
                        m.Alumnos.Add(alumnoEntrante);
                        return Ok(alumnoEntrante);
                    }
                    else
                    {
                        return BadRequest("No hay cupo disponible en la materia.");
                    }
                }
            }
            return NotFound("Materia no encontrada.");
        }
        
        //Delete materia/{idmateria}/alumno/{IdAlumnno} elimar un alumno de una mataeria por su id
        [HttpDelete("{id}/alumno/{idAlumno}")]
        public IActionResult EliminarAlumno(int id, int idAlumno)
        {
            foreach (Materia m in materias)
            {
                if (m.Id == id)
                {
                    foreach (Alumno a in m.Alumnos)
                    {
                        if (a.Id == idAlumno)
                        {
                            m.Alumnos.Remove(a);
                            return Ok(a);
                        }
                        return NotFound("Alumno no encontrado en la materia.");
                    }
                }
            }
            return NotFound("Materia no encontrada.");
        }
    }





 
}
