using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warming.Clase_3;

namespace Warming.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelloWorldEnIngles()
        {
            // variable de instancia de la clase a probar
            MiHelloWorld inst = new MiHelloWorld();
            // variables con los valores a utilizar en la prueba
            string username = string.Empty;
            string expectedMessage = "Hello World";
            string realMessage = string.Empty;
            // invoque al método deseado
            realMessage = inst.HelloWorld();
            // verifique si la prueba fue exitosa
            Assert.IsTrue(realMessage.ToLower() == expectedMessage.ToLower(),
                string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedMessage, realMessage));
        }

        [TestMethod]
        public void HelloWorldEnEspanol()
        {
            // variable de instancia de la clase a probar
            MiHelloWorld inst = new MiHelloWorld(Warming.Clase_3.EnumIdiomas.Español);
            // variables con los valores a utilizar en la prueba
            string username = string.Empty;
            string expectedMessage = "Hola MUNdo";
            string realMessage = string.Empty;
            // invoque al método deseado
            realMessage = inst.HelloWorld();
            // verifique si la prueba fue exitosa
            Assert.IsTrue(realMessage.ToLower() == expectedMessage.ToLower(),
                string.Format("Error en la prueba. El valor esperado era [{0}] y se " +
                               "obtuvo [{1}].", expectedMessage, realMessage));
        }

    }
}


