using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace Pruebas
{
    [TestClass]
    public class UserManagerTest
    {
        /// <summary>
        /// Comprueba el método CrearAdmin.
        /// </summary>
        [TestMethod]
        public void CrearAdminTest()
        {
            int usuarios = UserManager.getAll().Count;

            if (usuarios == 0)
            {
                UserManager.CrearAdmin();
                Assert.AreEqual(usuarios+1, UserManager.getAll().Count);
            }
            else
            {
                UserManager.CrearAdmin();
                Assert.AreEqual(usuarios, UserManager.getAll().Count);
            }
        }

        /// <summary>
        /// Comprueba el método GetAll (hay que eliminar el nuevo usuario creado manualmente en la BDD).
        /// </summary>
        [TestMethod]
        public void GetAllTest()
        {
            int usuarios = UserManager.getAll().Count;

            Usuario u = new Usuario();
            u.username = "ivan";
            u.activo = true;
            u.email = "ivan@a2000.es";
            u.passwdSinCifrar = "aaa111...";
            
            UserManager.NuevoUsuario(u);
         
            Assert.AreEqual(usuarios + 1, UserManager.getAll().Count);
        }

    }
}
