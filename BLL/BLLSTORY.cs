using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSTORY
    {
        private BE.STORY story;
        public BE.STORY Story
        {
            get { return story; }
            set { story = value; }
        }

        DAL.MP_STORY dalStory = new DAL.MP_STORY();

        public static List<BE.STORY> ListStories(int idFather) 
        {
            DAL.MP_STORY mp_story = new DAL.MP_STORY();
            return mp_story.ListStories(idFather);
        }

        public void Assign(BE.USER asignee)
        {
            story.Assignee = asignee;
        }

        public int CreateStory(
            string storyName, 
            BE.Project project, 
            BE.USER reporter,
            BE.USER assignee = null, 
            int? points = null, 
            BE.STORY father = null, 
            string description = null, 
            int? priority = null)
        {
            story = new BE.STORY();

            story.Name = storyName;
            story.Project = project;
            story.Reporter = reporter;
            story.Assignee = assignee;
            story.Points = points;
            story.Father = father;
            story.Description = description;
            story.Priority = priority;
            if (father != null)
                story.Type = "Story";
            else
                story.Type = "Epic";

            return dalStory.Insert(story);

        }

        public BE.STORY GetStory(int idStory)
        {
            return dalStory.GetStory(idStory);
        }

        public int EditStory()
        {
            dalStory.Edit(story);
            if (story.Father == null)
                return 0;
            var father = dalStory.GetStory(story.Father.IdStory);
            father.Points = CalculateFatherPoints(father);
            return dalStory.Edit(father);            
        }

        private int CalculateFatherPoints(BE.STORY father)
        {
            var children = dalStory.ListStories(father.IdStory);
            int points = 0;
            foreach (var child in children)
            {
                if (child.Points != null)
                    points += child.Points.Value;
            }
            return points;
        }
    }
}
