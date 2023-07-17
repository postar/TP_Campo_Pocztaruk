using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MP_PROJECT : MAPPER<BE.Project>
    {
        public override BE.Project Convert(DataRow registry)
        {
            MP_USER user = new MP_USER();
            BE.Project project = new BE.Project();
            project.IdProject = int.Parse(registry["idProject"].ToString());
            string aux = registry["idPM"].ToString();
            if (!string.IsNullOrEmpty(aux))
            {
                project.PM = user.GetUserById(int.Parse(registry["idPM"].ToString()));
            }
            
            project.Client = user.GetUserById(int.Parse(registry["idClient"].ToString()));
            project.Responsible = user.GetUserById(int.Parse(registry["idResponsible"].ToString()));
            project.State = registry["state"].ToString();
            project.ProjectName = registry["projectName"].ToString();
            project.Description = registry["description"].ToString();
            return project;
        }

        public override int Delete(BE.Project entity)
        {
            throw new NotImplementedException();
        }

        public override int Edit(BE.Project entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("idProject", entity.IdProject),
                access.CreateParameter("@projectName", entity.ProjectName),
                access.CreateParameter("@idResponsible", entity.Responsible.Id),
                access.CreateParameter("@state", entity.State),
                access.CreateParameter("@idClient", entity.Client.Id),
                access.CreateParameter("idPM", entity.PM.Id),
                access.CreateParameter("description", entity.Description)
            };
            access.Open();
            int result = access.Write("EDIT_PROJECT", parameters);
            access.Close();
            return result;
        }

        public BE.Project GetProject(int idProject)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@idProject", idProject),
            };
            access.Open();
            DataTable table = access.Read("GET_PROJECTBYID", parameters);
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            return Convert(table.Rows[0]);
        }

        public BE.Project GetProject()
        {
            access.Open();
            DataTable table = access.Read("GET_LASTPROJECT");
            access.Close();
            if (table.Rows.Count == 0) { return null; }
            return Convert(table.Rows[0]);
        }

        public override int Insert(BE.Project entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                access.CreateParameter("@projectName", entity.ProjectName),
                access.CreateParameter("@idResponsible", entity.Responsible.Id),
                access.CreateParameter("@state", entity.State),
                access.CreateParameter("@idClient", entity.Client.Id),
                access.CreateParameter("description", entity.Description)

            };
            access.Open();
            int result = access.Write("CREATE_PROJECT", parameters);
            access.Close();
            return result;
        }

        public override List<BE.Project> List()
        {
            access.Open();
            DataTable table = access.Read("LIST_PROJECTS");
            access.Close();

            List<BE.Project> PROJECTS = new List<BE.Project>();
            foreach (DataRow registry in table.Rows)
            {
                PROJECTS.Add(ListElementConvert(registry));
            }
            return PROJECTS;
        }

        private BE.Project ListElementConvert(DataRow registry)
        {
            MP_USER user = new MP_USER();
            BE.Project project = new BE.Project();
            project.IdProject = int.Parse(registry["idProject"].ToString());
            project.PM = CreateUserName(registry["PM"].ToString());
            project.Client = CreateUserName(registry["Client"].ToString());
            project.Responsible = CreateUserName(registry["Responsible"].ToString());
            project.State = registry["state"].ToString();
            project.ProjectName = registry["projectName"].ToString();
            return project;
        }

        private BE.USER CreateUserName(string v)
        {
            var aux = new BE.USER();
            aux.Name = v;
            return aux;
        }
    }
}