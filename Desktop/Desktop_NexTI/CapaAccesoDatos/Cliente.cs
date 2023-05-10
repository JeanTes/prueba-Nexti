namespace CapaAccesoDatos
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public byte[] FotoPerfil { get; set; }
        public string Cursos { get; set; }
    }
}