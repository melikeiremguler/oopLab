using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace _15212120161069
{
    public class General
    {
        // BindingList<Staff> searchList = new BindingList<Staff>();
        DataTable dt = new DataTable();
        public DataTable Loadcsvfile(string filePath)
        {

            dt.Columns.AddRange(new DataColumn[13] { new DataColumn("Image", typeof(Image)), new DataColumn("ID", typeof(Int32)), new DataColumn("Name", typeof(String)), new DataColumn("Surname", typeof(String)), new DataColumn("Address", typeof(String)), new DataColumn("BMO", typeof(Int32)), new DataColumn("Salary", typeof(Int32)), new DataColumn("City", typeof(String)), new DataColumn("Experience", typeof(String)), new DataColumn("Management Position", typeof(String)), new DataColumn("Academic Degree", typeof(String)), new DataColumn("Family Status", typeof(String)), new DataColumn("Foreign Language", typeof(String)) });

            using (TextReader reader = File.OpenText(filePath))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
           
              
                while (csv.Read())
                {
                    Staff Record = csv.GetRecord<Staff>();
   
                    dt.Rows.Add(null,Record.id,Record.name,Record.surname,Record.address,Record.bmo,Record.salary,Record.city,Record.experience,Record.managmentPosition,Record.academicDegree,Record.familyStatus,Record.foreignLanguage);

                }
               
                return dt;
              
            }
        }
        
    }
    
}
