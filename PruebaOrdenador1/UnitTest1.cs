using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioIntroduccionDatosOrdenadores.Controllers;
using EjercicioIntroduccionDatosOrdenadores.Models;
using EjercicioIntroduccionDatosOrdenadores.Services;
using LoggerService;
using Microsoft.AspNetCore.Mvc;
using DocumentFormat.OpenXml.Vml;

namespace PruebasOrdenadores
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ComponentesController controlador = new(new FakeRepositorioComponentes(), new LoggerManager());

        [TestMethod]
        public void DetallesComponentes()
        {
            var result = controlador.details(1) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Details", result.ViewName); 
            Assert.IsNotNull(result.ViewData);
            var componentes = result.ViewData.Model as Componentes; 
            Assert.IsNotNull(componentes);
            Assert.AreEqual("Procesador", componentes.TipoComponente);
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void PruebaComponentesDetallesVistaNoEncontrado()
        {
            var result = controlador.details(2) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Details", result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            var componentes = result.ViewData.Model as Componentes;
            Assert.IsNotNull(componentes);
            Assert.AreEqual("Procesador", componentes.TipoComponente);
        }
        [TestMethod]
        public void PruebaComponentesIndexVistaOk()
        {
            var result = controlador.Index() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            var ListaComponentes = result.ViewData.Model as List<Componentes>;
            Assert.IsNotNull(ListaComponentes);
            Assert.AreEqual(3, ListaComponentes.Count);
        }
       
       
    }
}
