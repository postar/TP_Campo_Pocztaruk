using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class STORY
    {
        private BE.Story story;
        public BE.Story Story
        {
            get { return story; }
            set { story = value; }
        }

        DAL.MP_STORY dalStory = new DAL.MP_STORY();

        public void Assign(BE.USER asignee)
        {
            story.Assignee = asignee;
        }

        public int CreateStory(
            string storyName, 
            BE.Project project, 
            BE.USER reporter,
            string type, 
            BE.USER assignee = null, 
            int? points = null, 
            BE.Story father = null, 
            DateTime? startDate = null, 
            DateTime? endDate = null)
        {
            story = new BE.Story();

            story.Name = storyName;
            story.Project = project;
            story.Reporter = reporter;
            story.Type = type;
            story.Assignee = assignee;
            story.Points = points;
            story.Father = father;
            story.StartDate = startDate;
            story.EndDate = endDate;

            return dalStory.Insert(story);

        }

        //public STORY GetStory(int idStory)
        //{
        //    return dalStory.GetStory(idStory);
        //}

        //public STORY GetStory()
        //{
        //    return dalStory.GetStory();
        //}

        public int EditStory()
        {
            return dalStory.Edit(story);
        }
    }
}
