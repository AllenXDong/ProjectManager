using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using MainProject.Beans;

namespace MainProject.Utils
{
    public class LiteDBUtils
    {

        public static int insertData(ProjectInfo projectInfo)
        {
            int id = 0;
            using (LiteDatabase db = new LiteDatabase(@"ProjectData.db"))
            {
                // Get customer collection
                var col = db.GetCollection<ProjectInfo>("projectinfo");

                // Create unique index in Name field
                col.EnsureIndex(x => x.id, true);

                // Insert new customer document (Id will be auto-incremented)
                id = col.Insert(projectInfo);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //col.Update(customer);

                // Use LINQ to query documents (with no index)
                //var results = col.Find(x => x.Age > 20);
            }
            return id;
        }

        public static void deleteData(int id)
        {
            using (LiteDatabase db = new LiteDatabase(@"ProjectData.db"))
            {
                // Get customer collection
                var col = db.GetCollection<ProjectInfo>("projectinfo");
                //col.EnsureIndex(x => x.SubjectName, true);
                // Create unique index in Name field

                //ProjectInfo project = col.FindOne(x => x.SubjectName == subjectName);
               
                // Insert new customer document (Id will be auto-incremented)
                col.Delete(id);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //col.Update(customer);

                // Use LINQ to query documents (with no index)
                //var results = col.Find(x => x.Age > 20);
            }
        }

        public static ProjectInfo queryOne(int id)
        {
            using (LiteDatabase db = new LiteDatabase(@"ProjectData.db"))
            {
                // Get customer collection
                var col = db.GetCollection<ProjectInfo>("projectinfo");
                //col.EnsureIndex(x => x.SubjectName, true);
                // Create unique index in Name field

                ProjectInfo project = col.FindById(id);

                return project;
                // Insert new customer document (Id will be auto-incremented)
                //col.Delete(project.id);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //col.Update(customer);

                // Use LINQ to query documents (with no index)
                //var results = col.Find(x => x.Age > 20);
            }
        }

        public static List<ProjectInfo> queryAll()
        {
            using (LiteDatabase db = new LiteDatabase(@"ProjectData.db"))
            {
                // Get customer collection
                var col = db.GetCollection<ProjectInfo>("projectinfo");
                //col.EnsureIndex(x => x.SubjectName, true);
                // Create unique index in Name field

                List<ProjectInfo> projects = col.FindAll().ToList();

                return projects;
                // Insert new customer document (Id will be auto-incremented)
                //col.Delete(project.id);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //col.Update(customer);

                // Use LINQ to query documents (with no index)
                //var results = col.Find(x => x.Age > 20);
            }
        }

        public static void updateProjectInfo(ProjectInfo newproject)
        {
            using (LiteDatabase db = new LiteDatabase(@"ProjectData.db"))
            {
                // Get customer collection
                var col = db.GetCollection<ProjectInfo>("projectinfo");
                //col.EnsureIndex(x => x.SubjectName, true);
                // Create unique index in Name field

                //ProjectInfo oldproject = col.FindById(newproject.id);
                //oldproject.
                //if (oldproject != null)
                {
                    col.Update(newproject);
                }
                // Insert new customer document (Id will be auto-incremented)
                //col.Delete(project.id);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //col.Update(customer);

                // Use LINQ to query documents (with no index)
                //var results = col.Find(x => x.Age > 20);
            }
        }

        public static ProjectInfo updateCurrentProject(int id)
        {
            using (LiteDatabase db = new LiteDatabase(@"ProjectData.db"))
            {
                // Get customer collection
                var col = db.GetCollection<ProjectInfo>("projectinfo");
                //col.EnsureIndex(x => x.SubjectName, true);
                // Create unique index in Name field

                ProjectInfo newproject = col.FindById(id);
                ProjectInfo oldproject = col.FindOne(x => x.IsCurrent == true);
                newproject.IsCurrent = true;
                col.Update(newproject);
                if(oldproject!=null)
                {
                    oldproject.IsCurrent = false;
                    col.Update(oldproject);
                }
                return newproject;
                // Insert new customer document (Id will be auto-incremented)
                //col.Delete(project.id);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //col.Update(customer);

                // Use LINQ to query documents (with no index)
                //var results = col.Find(x => x.Age > 20);
            }
        }

        public static ProjectInfo getCurrentProject()
        {
            using (LiteDatabase db = new LiteDatabase(@"ProjectData.db"))
            {
                // Get customer collection
                var col = db.GetCollection<ProjectInfo>("projectinfo");
                //col.EnsureIndex(x => x.SubjectName, true);
                // Create unique index in Name field

                ProjectInfo oldproject = col.FindOne(x => x.IsCurrent == true);
                return oldproject;
                // Insert new customer document (Id will be auto-incremented)
                //col.Delete(project.id);
                // Update a document inside a collection
                //customer.Name = "Joana Doe";

                //col.Update(customer);

                // Use LINQ to query documents (with no index)
                //var results = col.Find(x => x.Age > 20);
            }
        }
    }

    
}
