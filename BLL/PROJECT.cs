using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BLL
{
    public class PROJECT
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

        public List<BE.EPIC> ListEpics()
        {
            return project.Epics;
        }

        public void CalculateCost()
        {
            project.Cost = 0;
            foreach (EPIC epic in project.Epics) 
            {
                project.Cost += CalculateEpicCost(epic);
            }
        }

        private int CalculateEpicCost(EPIC epic)
        {
            int epicCost = 0;
            foreach (BE.Story story in epic.RelatedStories)
            {
                //epicCost += story.Points * costPerPoint;
            }
            return epicCost;
        }

        public void Assign(BE.USER pm)
        {
            project.PM = pm;
        }

        public int CreateProject(string projectName, BE.USER client, BE.USER responsible)
        {
            project = new BE.Project();
            project.ProjectName = projectName;
            project.Client = client;
            project.Responsible = responsible;
            project.State = "Created";
            project.Requirements = new List<BE.Requirement>();
            project.Epics = new List<BE.EPIC>();
            return dalProject.Insert(project);

        }

        public Project GetProject(int idProject)
        {
            return dalProject.GetProject(idProject);
        }

        public Project GetProject()
        {
            return dalProject.GetProject();
        }

        public int EditProject()
        {
            return dalProject.Edit(project);
        }
    }
}