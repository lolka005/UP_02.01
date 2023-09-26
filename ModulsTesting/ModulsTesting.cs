using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataBaseController;

namespace ModulsTesting
{
    [TestClass]
    public class ModulsTesting
    {
        [TestMethod]
        public void Can_Connect_With_True_Login_And_Password()
        {
            string login = "Admin";
            string password = "123";
            DB db = new DB(login, password);
            bool real = db.CanOpen();
            Assert.IsTrue(real);
        }
        [TestMethod]
        public void Can_Connect_With_False_Login_Or_Passwrord()
        {
            string login = "Egor";
            string password = "123";
            DB db = new DB(login, password);
            bool real = db.CanOpen();
            Assert.IsFalse(real);
        }
        [TestMethod]
        public void ClearLogs()
        {
            string login = "Admin";
            string password = "123";
            DB db = new DB(login, password);
            db.ClearLogs();
            return;
        }
        [TestMethod]
        public void ClearLogsWithNoConnection()
        {
            string login = "Egor";
            string password = "123";
            DB db = new DB(login, password);
            Assert.ThrowsException<InvalidOperationException>(() => db.ClearLogs());
        }
        [TestMethod]
        public void DeleteFromRecievers()
        {
            string login = "Admin";
            string password = "123";
            DB db = new DB(login, password);
            db.DeleteFromRec(1);
        }
        [TestMethod]
        public void DeleteFromRecieversWithNoConnection()
        {
            string login = "Egor";
            string password = "123";
            DB db = new DB(login, password);
            Assert.ThrowsException<InvalidOperationException>(() => db.DeleteFromRec(1));
        }
        [TestMethod]
        public void DeleteFromRecieversWrongRow()
        {
            string login = "Admin";
            string password = "123";
            DB db = new DB(login, password);
            db.DeleteFromRec(-1);
        }
        [TestMethod]
        public void UpdateInRecieversWrongRow()
        {
            string login = "Admin";
            string password = "123";
            DB db = new DB(login, password);
            db.UpdateToRec("Egor", "Shakir", "Andre", "SPb", -99);
        }
        [TestMethod]
        public void UpdateInRecievers()
        {
            string login = "Admin";
            string password = "123";
            DB db = new DB(login, password);
            db.UpdateToRec("Egor", "Shakir", "Andre", "SPb", 1);
        }
        [TestMethod]
        public void UpdateInRecieversWithNoConnection()
        {
            string login = "Admin4";
            string password = "123";
            DB db = new DB(login, password);
            Assert.ThrowsException<InvalidOperationException>(() => db.UpdateToRec("Egor", "Shakir", "Andre", "SPb", 1));
        }
    }
}
