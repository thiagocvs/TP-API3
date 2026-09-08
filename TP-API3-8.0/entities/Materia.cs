namespace TP_API3;
public class Materia
{
    private int id;
    private string nombre;
    private int cupoMaximo;
    private List<Alumno> alumnos = new();

    public Materia()
    {
        Id = id;
        Nombre = nombre;
        CupoMaximo = cupoMaximo;
        Alumnos = alumnos;
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int CupoMaximo { get => cupoMaximo; set => cupoMaximo = value; }
    public List<Alumno> Alumnos { get => alumnos; set => alumnos = value ?? new List<Alumno>(); }
}
