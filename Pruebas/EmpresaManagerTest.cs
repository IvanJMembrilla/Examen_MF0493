using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTest()
        {
            Assert.IsNull(EmpresaManager.get("4"));
            Assert.AreEqual(EmpresaManager.get("75722300k").nif, "75722300k");
        }

        [TestMethod]
        public void NuevaTest()
        {
            Empresa nueva = new Empresa(){
                nif = "78945612l",
                nombre = "mi empresa",
                email = "nueva@empresa.com",
                poblacion = "Mojacar",
                telefono = "123456789",
                activa = true,
                usr = "ivan",
                Usuario = UserManager.get("75722300K")
            };
            Assert.IsTrue(EmpresaManager.Nueva(nueva));
            Assert.IsFalse(EmpresaManager.Nueva(nueva));

            EmpresaManager.Eliminar("78945612l");
        }

        [TestMethod]
        public void ModificarTest()
        {
            Empresa nueva = new Empresa()
            {
                nif = "78945634k",
                nombre = "mi empresa2",
                email = "nueva2@empresa.com",
                poblacion = "Laujar",
                telefono = "123456789",
                activa = true,
                usr = "ivan",
                Usuario = UserManager.get("75722300K")
            };
            
            int empresas = EmpresaManager.getAll().Count;

            Assert.IsTrue(EmpresaManager.Modificar(nueva));
            Assert.AreEqual(empresas + 1, EmpresaManager.getAll().Count);

            nueva.poblacion = "Barcelona";
            Assert.IsTrue(EmpresaManager.Nueva(nueva));
            Assert.AreEqual(nueva.poblacion, EmpresaManager.get("78945634k").poblacion);

            Empresa nueva2 = null;
            Assert.IsFalse(EmpresaManager.Nueva(nueva2));
        }

        [TestMethod]
        public void EliminarTest()
        {
            int empresas = EmpresaManager.getAll().Count;
            EmpresaManager.Eliminar("78945634k");
            Assert.AreEqual(empresas -1, EmpresaManager.getAll().Count);
        }
    }
}
