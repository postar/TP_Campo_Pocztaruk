using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BLL
{
    public class BLLPROJECT
    {
        public static List<BE.Project> GetProjects() 
        {
            DAL.MP_PROJECT mp_project = new DAL.MP_PROJECT();
            return mp_project.List();
        }
        int costPerPoint = 50;
        private BE.Project project;
        public BE.Project Project
        {
            get { return project; }
            set { project = value; }
        }

        DAL.MP_PROJECT dalProject = new DAL.MP_PROJECT();

        public List<BE.STORY> ListEpics()
        {
            if(project != null)
                return project.Epics;
            return new List<BE.STORY>();
        }

        public void CalculateCost()
        {
            DAL.MP_STORY mP_STORY = new DAL.MP_STORY();
            project.Epics = mP_STORY.ListEpics(project.IdProject);
            project.Cost = 0;
            foreach (BE.STORY epic in project.Epics) 
            {
                if (epic.Points.HasValue)
                    project.Cost += (int)epic.Points * costPerPoint;

                foreach (BE.STORY story in mP_STORY.ListStories(epic.IdStory))
                {
                    if(story.Points.HasValue)
                        project.Cost += (int)story.Points * costPerPoint;
                }
            }
        }

        public void Assign(BE.USER pm)
        {
            project.PM = pm;
        }

        public int CreateProject(string projectName, string description, BE.USER client, BE.USER responsible)
        {
            project = new BE.Project();
            project.ProjectName = projectName;
            project.Client = client;
            project.Responsible = responsible;
            project.State = "Created";
            project.Description = description;
            project.Epics = new List<BE.STORY>();
            return dalProject.Insert(project);

        }

        public static BE.Project GetProject(int idProject)
        {
            DAL.MP_PROJECT dalProject = new DAL.MP_PROJECT();
            return dalProject.GetProject(idProject);
        }

        public static BE.Project GetProject()
        {
            DAL.MP_PROJECT dalProject = new DAL.MP_PROJECT();
            return dalProject.GetProject();
        }

        public int EditProject()
        {
            return dalProject.Edit(project);
        }
    }
}