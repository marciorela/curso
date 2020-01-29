using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Tests
{
    [TestClass]
    public class HelloWorldTest
    {

        [TestMethod]
        public void ExecutandoUmTesteDeOlaMundo()
        {
            //arrange -> ambiente (onde vc instancia os objetos)
            var helloWorld = "HelloWorld";

            //act -> ação (execução do método a ser testado)
            bool troca = (new Random().Next(0,2) == 0);
            if (troca)
            {
//                helloWorld = "outracoisa";
            }

            //assert -> validação do resultado
            Assert.AreEqual("HelloWorld", helloWorld);
        }
        
    }
}
