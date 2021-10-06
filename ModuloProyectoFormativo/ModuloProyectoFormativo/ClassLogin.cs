using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloProyectoFormativo
{
    class ClassLogin
    {
        public string nombre { set; get; }
        public string correo { set; get; }
        public string contraseña { set; get; }
        public string nIdentificacion { set; get; }
        public string fechaN { set; get; }
        public string telefono { set; get; }


        public void RegistroUsuario(string NombreUsuario, string Correo, string Contraseña, string Identificacion, string Fecha, string Telefono)
        {
            ClassListLogin.List.Add(new ClassLogin { nombre = NombreUsuario, correo = Correo, contraseña = Contraseña, nIdentificacion = Identificacion, fechaN = Fecha, telefono = Telefono });
        }

        public bool InicioSesion(string Email, string Contraseña)
        {
            bool Ingreso = false;
            foreach (ClassLogin i in ClassListLogin.List)
            {
                if (i.correo == Email)
                    if (i.contraseña == Contraseña)
                    {
                        Ingreso = true;
                    }

            }
            return Ingreso;
        }
    }
}
