using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Linq;

namespace DAL
{
    public class MP_STORY : MAPPER<BE.STORY>
    {
        public override BE.STORY Convert(DataRow registry)
        {
            MP_USER user = new MP_USER();
            MP_PROJECT project = new MP_PROJECT();
            BE.STORY story = new BE.STORY();
            story.IdStory = int.Parse(registry["idStory"].ToString());
            story.Project = project.GetProject(int.Parse(registry["idProject"].ToString()));
            string auxFather = registry["idFather"].ToString();
            if (!string.IsNullOrEmpty(auxFather))
                story.Father = GetStory(int.Parse(registry["idFather"].ToString()));

            string auxAssignee = registry["idAssignee"].ToString();
            if (!string.IsNullOrEmpty(auxAssignee))
                story.Assignee = user.GetUserById(int.Parse(registry["idAssignee"].ToString()));

            story.Reporter = user.GetUserById(int.Parse(registry["idReporter"].ToString()));
            story.Name = registry["Name"].ToString();
            story.Type = registry["Type"].ToString();

            if (!string.IsNullOrEmpty(registry["points"].ToString()))
                story.Points = int.Parse(registry["points"].ToString());        

            if (!string.IsNullOrEmpty(registry["Description"].ToString()))
                story.Description = registry["Description"].ToString();

            if (!string.IsNullOrEmpty(registry["Priority"].ToString()))
                story.Priority = int.Parse(registry["Priority"].ToString());

            return story;
        }

        public override int Delete(BE.STORY entity)
        {
            throw new NotImplementedException();
        }

        public override int Edit(BE.STORY entity)
        {
            List<SqlParameter> parameters = LoadParams(entity);
            parameters.Add(access.CreateParameter("@idStory", entity.IdStory));

            access.Open();
            int result = access.Write("EDIT_STORY", parameters);
            access.Close();
            return result;
        }

        public BE.STORY GetStory(int idStory)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@idStory", idStory),
            };
            access.Open();
            DataTable table = access.Read("GET_STORYBYID", parameters);
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            return Convert(table.Rows[0]);
        }

        public BE.STORY GetStory()
        {
            access.Open();
            DataTable table = access.Read("GET_LASTSTORY");
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            return Convert(table.Rows[0]);
        }

        public List<BE.STORY> GetStoryByPID()
        {
            access.Open();
            DataTable table = access.Read("GET_STORYBYPID");
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            List<BE.STORY> stories = new List<BE.STORY>();
            foreach (DataRow row in table.Rows)
            {
                stories.Add(Convert(row));
            }
            return stories;
        }

        public override int Insert(BE.STORY entity)
        {
            List<SqlParameter> parameters = LoadParams(entity);

            access.Open();
            int result = access.Write("CREATE_STORY", parameters);
            access.Close();
            return result;
        }

        private List<SqlParameter> LoadParams(BE.STORY entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@Name", entity.Name),
                access.CreateParameter("@idProject", entity.Project.IdProject),
                access.CreateParameter("@type", entity.Type),
                access.CreateParameter("@idReporter", entity.Reporter.Id)
            };
            if (entity.Assignee != null)
                parameters.Add(access.CreateParameter("@idAssignee", entity.Assignee.Id));

            if (entity.Points != null)
                parameters.Add(access.CreateParameter("@points", entity.Points.Value));

            if (entity.Father != null)
                parameters.Add(access.CreateParameter("@idFather", entity.Father.IdStory));

            if (entity.Description != null)
                parameters.Add(access.CreateParameter("@Description", entity.Description));

            if (entity.Priority != null)
                parameters.Add(access.CreateParameter("@Priority", entity.Priority.Value.ToString()));
            return parameters;
        }

        private BE.STORY ListStoryElementConvert(DataRow registry)
        {
            BE.STORY story = new BE.STORY();
            story.IdStory = int.Parse(registry["idStory"].ToString());
            story.Name = registry["Name"].ToString();
            if (!string.IsNullOrEmpty(registry["points"].ToString()))
                story.Points = int.Parse(registry["points"].ToString());
            return story;
        }

        private BE.USER CreateUserName(string v)
        {
            var aux = new BE.USER();
            aux.Name = v;
            return aux;
        }

        public List<BE.STORY> ListStories(int idFather)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@idFather", idFather)

            };

            access.Open();
            DataTable table = access.Read("LIST_STORIES", parameters);
            access.Close();

            List<BE.STORY> STORYS = new List<BE.STORY>();
            foreach (DataRow registry in table.Rows)
            {                
                STORYS.Add(GetStory(ListStoryElementConvert(registry).IdStory));
            }
            return STORYS;
        }

        public List<BE.STORY> ListEpics(int idProject)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@idProject", idProject)

            };

            access.Open();
            DataTable table = access.Read("LIST_EPICS", parameters);
            access.Close();

            List<BE.STORY> STORYS = new List<BE.STORY>();
            foreach (DataRow registry in table.Rows)
            {
                STORYS.Add(GetStory(ListStoryElementConvert(registry).IdStory));
            }
            return STORYS;
        }

        public override List<BE.STORY> List()
        {
            throw new NotImplementedException();
        }
    }
}