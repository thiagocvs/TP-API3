public class Alumno
{
    private int id;
    private string nombre;
    private string email;

    public Alumno()
    {
        Id = id;
        Nombre = nombre;
        Email = email;
    }

    public string Email { get => email; set => email = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Id { get => id; set => id = value; }

}