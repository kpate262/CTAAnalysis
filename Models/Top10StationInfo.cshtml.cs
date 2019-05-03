using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace program.Pages  
{  
    public class TopTenStationInfoModel : PageModel  
    {  
				public List<Models.TopTenStations> StationList { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
				  StationList = new List<Models.TopTenStations>();

                // 
                // Lookup movie(s) based on input, which could be id or a partial name:
                // 
                  string sql;

            sql = string.Format(@"
                SELECT TOP 10 Stations.Name AS Name, SUM(DailyTotal) AS TotalRidership
                FROM Stations
                INNER JOIN Riderships
                    ON Stations.StationID = Riderships.StationID
                GROUP BY Stations.Name
                ORDER BY TotalRidership DESC");

            DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Models.TopTenStations s = new Models.TopTenStations();
                s.DailyRiders = Convert.ToInt32(row["TotalRidership"]);
                s.StationName = Convert.ToString(row["Name"]);

                StationList.Add(s);
            }
						
					
		}
			
    }//class  
}//namespace