using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRsoft.Store.UI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.Tests.Controllers
{
    [TestClass]
    [TestCategory("Controllers - Home")]
    public class HomeCtrlTests
    {
        
        [TestMethod]
        public void DadoOControllerHomeOMetodoIndexDeveraRetornarUmaView()
        {
            //a (ambiente)
            var homeCtrl = new HomeController();

            //a act
            var result = homeCtrl.Index() as ViewResult;

            // 
            Assert.IsNotNull(result);
        }
    }
}
