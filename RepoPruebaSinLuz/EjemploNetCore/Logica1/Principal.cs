using Newtonsoft.Json;

namespace Logica1
{
    public class Principal
    {
        private List<Usuario> Usuarios;

        public Principal() { 
            Usuarios = new List<Usuario>();
        }

        public bool AgregarUsuario(Usuario usuario) {
            Usuarios.Add(usuario);

            GuardarUsuarios();

            return true;
        }

        public void GuardarUsuarios() {
            string datosParaArchivo = JsonConvert.SerializeObject(Usuarios, Formatting.Indented);

            string rutaArchivo = "D:\\RepoPruebaSinLuz\\archivo.json";

            File.WriteAllText(rutaArchivo, datosParaArchivo);
        }

        public List<Usuario> DevolverUsuarioDesdeArchivo() {
            string rutaArchivo = "D:\\RepoPruebaSinLuz\\archivo.json";

            string contenidoJson = File.ReadAllText(rutaArchivo);

            List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(contenidoJson);

            return usuarios;
        }

        public List<Usuario> DevolverListaUsuarios() { 
            return Usuarios;
        }
    }
}