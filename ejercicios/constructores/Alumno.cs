namespace constructores
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public  string Apellido { get; set; }

        public Alumno()
        {
            Nombre = "Sin Asignar";
        }

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string nombreCompleto()
        {
            return Nombre + " " + Apellido;
        }
    }
}