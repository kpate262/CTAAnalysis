using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
  
namespace program.Pages  
{  
    public class RidershipByYearModel : PageModel  
    {  
        public List<string> Years { get; set; }
        public List<int> NumRiders { get; set; }
        public Exception EX { get; set; }
  
        public void OnGet()  
        {
          Years = new List<string>();
          NumRiders = new List<int>();
          
          EX = null;
          
          
          try
          {
            string sql = string.Format(@"
SELECT Year(TheDate) AS Year, SUM(DailyTotal) AS TotalRidership
FROM Riderships
GROUP BY Year(TheDate)
ORDER BY Year
");
          
            DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
              Years.Add(Convert.ToString(row["Year"]));
              int numriders = Convert.ToInt32(row["TotalRidership"]);

              NumRiders.Add(numriders);
            }
		      }
		      catch(Exception ex)
		      {
            EX = ex;
		      }
		      finally
		      { 
            // nothing at the moment
          } 
        }  
        
    }//class
}//namespace