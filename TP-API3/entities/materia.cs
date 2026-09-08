namespace TP_API;
public class Materia
{
    private int id;
    private string nombre;
    private int cupoMaximo;
    private List<Alumno> alumnos;

    public Materia()
    {
        Id = id;
        Nombre = nombre;
        CupoMaximo = cupoMaximo;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int CupoMaximo { get => cupoMaximo; set => cupoMaximo = value; }
    public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
}
