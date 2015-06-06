using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warming.Clase_3
{

    public class MiHelloWorld
    {


        // idioma en que se muestra el mensaje
        private EnumIdiomas language = EnumIdiomas.Inglés;

        // listareadonly de usuarios que son bloqueados para saludarse personalizadamente
        private string[] BLOCKEDUSERS = { "Bryan", "Li", "Chope", "Maduro" };

        // mensajes de Hello World en diferentes idiomas;
        public readonly string[] HELLOWORLDMESSAGE = { "Hola mundo", "Hello world", "Ciao mondo" };

        public int IdiomaEnInt
        {
            get { return (Convert.ToInt32(language)); }
        }

        public MiHelloWorld(EnumIdiomas selectedLanguage)
        {
            language = selectedLanguage;
        }

        public MiHelloWorld()
        {
            // TODO: Complete member initialization
        }

        public string HelloWorld()
        {
            string resultado = HELLOWORLDMESSAGE[IdiomaEnInt];
            return resultado;
        }

        //overloading
        public string HelloWorld(string userName)
        {
            string resultado = HelloWorld() + ", " + userName;
            return resultado;
        }

        public string HelloWorldBaneado(string userName)
        {
            string resultado = string.Empty;
            if (!BLOCKEDUSERS.Contains(userName))
                resultado = HelloWorld(userName);
            else
                resultado = HelloWorld();

            return resultado;
        }

    }
}
