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
            BLL.BLLSTORY story = new BLL.BLLSTORY();
            BE.USER user = new BE.USER();
            user.Id = 1;
            BE.USER user2 = new BE.USER();
            user2.Id = 2;
            BE.Project project = new BE.Project();
            project.IdProject = 7;
            // Act
            int result = story.CreateStory("Test Story", project, user);
            // Assert
            Assert.AreNotEqual(-1, 1);
        }

        [TestMethod]
        public void InsertFullStory()
        {
            // Arrange
            BLL.BLLSTORY story = new BLL.BLLSTORY();
            BE.USER user = new BE.USER();
            user.Id = 1;
            BE.USER user2 = new BE.USER();
            user2.Id = 2;
            BE.Project project = new BE.Project();
            project.IdProject = 7;
            BE.STORY father = new BE.STORY();
            father.IdStory = 8;
            DateTime date = DateTime.Now;
            // Act
            int result = story.CreateStory("Test Story", project, user, user2, 2, father);
            // Assert
            Assert.AreNotEqual(-1, 1);
        }

        [TestMethod]
        public void GetStory()
        {
            // Arrange
            MP_STORY story2 = new MP_STORY();
            // Act
            var result = story2.GetStory(1);
            // Assert
            Assert.AreEqual("Test Story", result.Name, "Esta mal el nombre");
        }

        [TestMethod]
        public void EditStory()
        {
            // Arrange
            MP_STORY story2 = new MP_STORY();
            BLL.BLLSTORY story = new BLL.BLLSTORY();
            story.Story = story2.GetStory(1);
            // Act
            story.Story.Assignee = new BE.USER();
            story.Story.Assignee.Id = 1;
            story.EditStory();
            var result = story2.GetStory(1);
            // Assert
            Assert.AreEqual(1, result.Assignee.Id, "no se guardo el Assignee");
        }

        [TestMethod]
        public void ListStory()
        {
            // Arrange
            MP_STORY story2 = new MP_STORY();
            // Act
            var result = story2.ListStories(1);
            // Assert
            Assert.AreEqual(2, result[0].IdStory, "Esta mal el nro");
            Assert.AreEqual(3, result[1].IdStory, "Esta mal el nro");
        }

        [TestMethod]
        public void ListEpic()
        {
            // Arrange
            MP_STORY story2 = new MP_STORY();
            // Act
            var result = story2.ListEpics(6);
            // Assert
            Assert.AreEqual(1, result[0].IdStory, "Esta mal el nro");
        }

        [TestMethod]
        public void EditStoryPoints()
        {
            // Arrange
            MP_STORY story2 = new MP_STORY();
            BLL.BLLSTORY story = new BLL.BLLSTORY();
            story.Story = story2.GetStory(2);
            // Act
            story.Story.Points = 3;
            story.EditStory();
            var result = story2.GetStory(1);
            // Assert
            Assert.AreEqual(9, result.Points, "se calcularon mal los puntos");
        }
    }
}
