namespace CapaEntidad
{
    public class PersonaCLS
    {
        //Listar
        public int iidpersona { get; set; }
        public string nombrecompleto { get; set; }
        public string correo { get; set; }
        public string fechanacimientocadena { get; set; }

        // Recuperar datos para editar
        public string nombre { get; set; }
        public string appaterno { get; set; }
        public string apmaterno { get; set; }
        public DateTime? fechanacimiento { get; set; }
        public int iidsexo { get; set; }
    }
}
