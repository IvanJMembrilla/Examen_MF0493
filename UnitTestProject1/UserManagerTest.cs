using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void CrearAdminTest()
        {
            int usuarios = UserManager.getAll().Count;

            if (usuarios == 0)
            {
                UserManager.CrearAdmin();
                Assert.Equals(usuarios + 1, UserManager.getAll().Count);
            }
            else{
                UserManager.CrearAdmin();
                Assert.Equals(usuarios, UserManager.getAll().Count);
            }
        }

        /*[TestMethod]
        public void CrearAdminTest()
        {
            int usuarios = UserManager.getAll().Count;

            if (usuarios == 0)
            {
                UserManager.CrearAdmin();
                Assert.Equals(usuarios + 1, UserManager.getAll().Count);
            }
            else
            {
                UserManager.CrearAdmin();
                Assert.Equals(usuarios, UserManager.getAll().Count);
            }
        }*/
    }
}
