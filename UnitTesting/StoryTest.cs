using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class StoryTest
    {
        [TestMethod]
        public void InsertStory()
        {
            // Arrange
            BLL.STORY story = new BLL.STORY();
            BE.USER user = new BE.USER();
            user.Id = 1;
            BE.USER user2 = new BE.USER();
            user2.Id = 2;
            BE.Project project = new BE.Project();
            project.IdProject = 6;
            // Act
            int result = story.CreateStory("Test Story", project, user, "Epic");
            // Assert
            Assert.AreNotEqual(-1, 1);
        }

        [TestMethod]
        public void InsertFullStory()
        {
            // Arrange
            BLL.STORY story = new BLL.STORY();
            BE.USER user = new BE.USER();
            user.Id = 1;
            BE.USER user2 = new BE.USER();
            user2.Id = 2;
            BE.Project project = new BE.Project();
            project.IdProject = 6;
            BE.Story father = new BE.Story();
            father.IdStory = 1;
            DateTime date = DateTime.Now;
            // Act
            int result = story.CreateStory("Test Story", project, user, "Epic", user2, 2, father);
            // Assert
            Assert.AreNotEqual(-1, 1);
        }

        [TestMethod]
        public void GetStory()
        {
            // Arrange
            MP_STORY story2 = new MP_STORY();
            // Act
            var result = story2.GetStory(6);
            // Assert
            Assert.AreEqual("asd", result.Name, "Esta mal el nombre");
        }

        [TestMethod]
        public void EditStory()
        {
            //// Arrange
            //MP_STORY story2 = new MP_STORY();
            //BLL.STORY story = new BLL.STORY();
            //story.Story = story2.GetStory(6);
            //// Act
            //story.Story.PM = new BE.USER();
            //story.Story.PM.Id = 1;
            //story.EditStory();
            //var result = story2.GetStory(6);
            //// Assert
            //Assert.AreEqual(1, result.PM.Id, "no se guardo el PM");
        }

        [TestMethod]
        public void StoryIntegrationTest()
        {
            // Arrange
            //BLL.STORY story = new BLL.STORY();
            //MP_STORY mP_STORY = new MP_STORY();
            //BE.USER user = new BE.USER();
            //user.Id = 1;
            //BE.USER user2 = new BE.USER();
            //user2.Id = 2;
            //// Act
            //story.CreateStory("Test Story Total", user2, user);
            //var result1 = mP_STORY.GetStory();
            //Assert.AreEqual("Test Story Total", result1.StoryName, "no se guardo el nombre");
            //story.Story = result1;
            //story.Story.PM = new BE.USER();
            //story.Story.PM.Id = 1;
            //story.EditStory();
            //var result = mP_STORY.GetStory(story.Story.IdStory);
            // Assert
            //Assert.AreEqual(1, result.PM.Id, "no se guardo el PM");
        }

        [TestMethod]
        public void ListStory()
        {
            //// Arrange
            //MP_STORY story2 = new MP_STORY();
            //// Act
            //var result = story2.List();
            //// Assert
            //Assert.AreEqual("asd", result[0].StoryName, "Esta mal el nombre");
            //Assert.AreEqual("Test Story Total", result[1].StoryName, "Esta mal el nombre");
            //Assert.AreEqual("asd", result[0].Client.Name, "Esta mal el nombre");
        }
    }
}
