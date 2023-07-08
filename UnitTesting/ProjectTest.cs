using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class ProjectTest
    {
        [TestMethod]
        public void InsertProject()
        {
            // Arrange
            BLL.PROJECT project = new BLL.PROJECT();
            BE.USER user = new BE.USER();
            user.Id = 1;
            BE.USER user2 = new BE.USER();
            user2.Id = 2;
            // Act
            int result = project.CreateProject("Test Project", user2, user);
            // Assert
            Assert.AreNotEqual(-1, 1);
        }

        [TestMethod]
        public void GetProject()
        {
            // Arrange
            MP_PROJECT project2 = new MP_PROJECT();
            // Act
            var result = project2.GetProject(6);
            // Assert
            Assert.AreEqual("asd", result.ProjectName, "Esta mal el nombre");
        }

        [TestMethod]
        public void EditProject()
        {
            // Arrange
            MP_PROJECT project2 = new MP_PROJECT();
            BLL.PROJECT project = new BLL.PROJECT();
            project.Project = project2.GetProject(6);
            // Act
            project.Project.PM = new BE.USER();
            project.Project.PM.Id = 1;
            project.EditProject();
            var result = project2.GetProject(6);
            // Assert
            Assert.AreEqual(1, result.PM.Id, "no se guardo el PM");
        }

        [TestMethod]
        public void ProjectIntegrationTest()
        {
            // Arrange
            BLL.PROJECT project = new BLL.PROJECT();
            MP_PROJECT mP_PROJECT = new MP_PROJECT();
            BE.USER user = new BE.USER();
            user.Id = 1;
            BE.USER user2 = new BE.USER();
            user2.Id = 2;
            // Act
            project.CreateProject("Test Project Total", user2, user);
            var result1 = mP_PROJECT.GetProject();
            Assert.AreEqual("Test Project Total", result1.ProjectName, "no se guardo el nombre");
            project.Project = result1;
            project.Project.PM = new BE.USER();
            project.Project.PM.Id = 1;
            project.EditProject();
            var result = mP_PROJECT.GetProject(project.Project.IdProject);
            // Assert
            Assert.AreEqual(1, result.PM.Id, "no se guardo el PM");
        }

        [TestMethod]
        public void ListProject()
        {
            // Arrange
            MP_PROJECT project2 = new MP_PROJECT();
            // Act
            var result = project2.List();
            // Assert
            Assert.AreEqual("asd", result[0].ProjectName, "Esta mal el nombre");
            Assert.AreEqual("Test Project Total", result[1].ProjectName, "Esta mal el nombre");
            Assert.AreEqual("asd", result[0].Client.Name, "Esta mal el nombre");
        }
    }
}
