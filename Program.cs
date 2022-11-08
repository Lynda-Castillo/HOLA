using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marielcastillocast
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variables

            //Declarar variables
            string nombreUsuario, apellidosUsuario, perfil, direccionUsuario, celularUsuario, usuarioAcceso, contraseña, confirmarContraseña;
            byte edadUsuario;
            
            #endregion
            #region datos usuario

            //El usuario llena las variables con sus datos
            Console.WriteLine("Ingresa tu nombre, después presiona ENTER");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad, después presiona ENTER");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            //Edad usuario menor o mayor de edad
            if (edadUsuario < 18)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("No podemos validar tu acceso, debes ser mayor de edad");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Ingresa tus apellidos");
                apellidosUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu dirección");
                direccionUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu número de celular");
                celularUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu perfil de facebook");
                perfil = Console.ReadLine();
                Console.WriteLine("Ingresa tu nombre de usuario");
                usuarioAcceso = Console.ReadLine();
                Console.WriteLine("Ingresa tu contraseña");
                contraseña = Console.ReadLine();
                Console.WriteLine("Confirma tu contraseña");
                confirmarContraseña = Console.ReadLine();

                //Código de Acceso
                if (contraseña == confirmarContraseña)
                {
                    Random aleatorio = new Random();
                    aleatorio.Next(1000, 9999);
                    int codigoAcceso = aleatorio.Next(1000, 9999);
                    // Resultados
                    Console.Clear();
                    Console.WriteLine("Resultados");
                    Console.WriteLine("\n nombre(s): {0}, \n Apellido: {1}, \n perfil: {2}, \n dirección: {3}, \n celular: {4}, \n usuario: {5}, \n contraseña: {6}, \n confirmar contraseña: {7}");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tu código de acceso", + codigoAcceso);
                    #endregion

                    Console.ReadKey();
                }


                

                    
                }
            }
        }
    }