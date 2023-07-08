using BE;
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
    public class MP_STORY : MAPPER<Story>
    {
        public override Story Convert(DataRow registry)
        {
            MP_USER user = new MP_USER();
            BE.Story story = new BE.Story();
            story.IdStory = int.Parse(registry["idStory"].ToString());
            string aux = registry["idPM"].ToString();
            //if (!string.IsNullOrEmpty(aux))
            //{
            //    story.PM = user.GetUserById(int.Parse(registry["idPM"].ToString()));
            //}
            
            //story.Client = user.GetUserById(int.Parse(registry["idClient"].ToString()));
            //story.Responsible = user.GetUserById(int.Parse(registry["idResponsible"].ToString()));
            //story.State = registry["state"].ToString();
            //story.StoryName = registry["storyName"].ToString();
            return story;
        }

        public override int Delete(Story entity)
        {
            throw new NotImplementedException();
        }

        public override int Edit(Story entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("idStory", entity.IdStory),
                //access.CreateParameter("@storyName", entity.StoryName),
                //access.CreateParameter("@idResponsible", entity.Responsible.Id),
                //access.CreateParameter("@state", entity.State),
                //access.CreateParameter("@idClient", entity.Client.Id),
                //access.CreateParameter("idPM", entity.PM.Id)
            };
            access.Open();
            int result = access.Write("EDIT_STORY", parameters);
            access.Close();
            return result;
        }

        public Story GetStory(int idStory)
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

        public Story GetStory()
        {
            access.Open();
            DataTable table = access.Read("GET_LASTSTORY");
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            return Convert(table.Rows[0]);
        }

        public override int Insert(Story entity)
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

            if (entity.StartDate != null)
                parameters.Add(access.CreateParameter("@startDate", entity.StartDate.Value.ToString()));

            if (entity.EndDate != null)
                parameters.Add(access.CreateParameter("@endDate", entity.EndDate.Value.ToString()));

            access.Open();
            int result = access.Write("CREATE_STORY", parameters);
            access.Close();
            return result;
        }

        public override List<Story> List()
        {
            access.Open();
            DataTable table = access.Read("LIST_STORYS");
            access.Close();

            List<BE.Story> STORYS = new List<BE.Story>();
            foreach (DataRow registry in table.Rows)
            {
                STORYS.Add(ListElementConvert(registry));
            }
            return STORYS;
        }

        private Story ListElementConvert(DataRow registry)
        {
            MP_USER user = new MP_USER();
            BE.Story story = new BE.Story();
            story.IdStory = int.Parse(registry["idStory"].ToString());
            //story.PM = CreateUserName(registry["PM"].ToString());
            //story.Client = CreateUserName(registry["Client"].ToString());
            //story.Responsible = CreateUserName(registry["Responsible"].ToString());
            //story.State = registry["state"].ToString();
            //story.StoryName = registry["storyName"].ToString();
            return story;
        }

        private USER CreateUserName(string v)
        {
            var aux = new BE.USER();
            aux.Name = v;
            return aux;
        }
    }
}