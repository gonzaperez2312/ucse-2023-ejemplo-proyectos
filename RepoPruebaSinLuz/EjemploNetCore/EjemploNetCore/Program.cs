// See https://aka.ms/new-console-template for more information
using Logica1;

Principal principal = new Principal();

Usuario usuario = new Usuario() { Nombre="Gonza", Dni=1};
Usuario usuario2 = new Usuario() { Nombre = "Maxi", Dni =2};
Usuario usuario3 = new Usuario() { Nombre = "Gabriel", Dni =3};

principal.AgregarUsuario(usuario);
principal.AgregarUsuario(usuario2);
principal.AgregarUsuario(usuario3);

foreach (Usuario item in principal.DevolverListaUsuarios())
{
    Console.WriteLine(item.DevolverDescription());
}

List<Usuario> usuarioDesdeArch = principal.DevolverUsuarioDesdeArchivo();

Console.ReadKey();
