using Microsoft.AspNetCore.Mvc;

namespace TP_API
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
    }  

    //POST /materia










     private Materia? BuscarPorId(int id)
    {
        foreach (Materia m in materias)
        {
            if (m.Id == id)
            {
                return m;
            }
        }

        return null;
    }
 
}
