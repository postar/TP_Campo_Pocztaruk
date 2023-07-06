using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using BE;
using System;

namespace UnitTesting
{
    [TestClass]
    public class BLLUserTest
    {
        [TestMethod]
        public void TestValidateUser()
        {
            // Arrange
            USER user = new USER();
            user.User = new BE.USER();
            user.User.Email = "test@example.com";
            user.User.Password = "password";

            // Act
            bool result = user.ValidateUser();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAddUser()
        {
            // Arrange
            USER user = new USER();
            user.User = new BE.USER();
            user.User.Email = "test@example.com";
            user.User.Password = "password";

            // Act
            int result = user.AddUser();

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestEditUser()
        {
            // Arrange
            USER user = new USER();
            user.User = new BE.USER();
            user.User.Email = "test@example.com";
            user.User.Password = "password";

            // Act
            int result = user.EditUser();

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestListUsers()
        {
            // Act
            List<BE.USER> users = USER.ListUsers();

            // Assert
            Assert.IsNotNull(users);
            Assert.AreEqual(2, users.Count);
        }

        [TestMethod]
        public void TestUnlockUser()
        {
            // Arrange
            USER user = new USER();
            user.User = new BE.USER();
            user.User.Email = "test@example.com";
            user.User.Locked = true;

            // Act
            int result = user.UnlockUser();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestDeleteUser()
        {
            // Arrange
            USER user = new USER();
            user.User = new BE.USER();
            user.User.Email = "test@example.com";

            // Act
            int result = user.DeleteUser();

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
