using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace program.Pages  
{  
    public class StopInfoModel : PageModel  
    {  
				public List<Models.Stop> StopList { get; set; }
				public string Input { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
				  StopList = new List<Models.Stop>();
					
					// make input available to web page:
					Input = input;
					
					// clear exception:
					EX = null;
					
					try
					{
						//
						// Do we have an input argument?  If not, there's nothing to do:
						//
						if (input == null)
						{
							//
							// there's no page argument, perhaps user surfed to the page directly?  
							// In this case, nothing to do.
							//
						}
						else  
						{
							// 
							// Lookup movie(s) based on input, which could be id or a partial name:
							// 
							string sql;

						  // lookup Stop(s) by partial name match:
							input = input.Replace("'", "''");

							sql = string.Format(@"
    SELECT Stops.StopID, Stops.Name, Direction, ADA, Latitude, Longitude, Color
    FROM Stops
    INNER JOIN StopDetails
        ON StopDetails.StopID = Stops.StopID
    INNER JOIN Lines
        ON Lines.LineID = StopDetails.LineID
    WHERE StationID = '{0}'
    ORDER BY Stops.Name, Lines.Color
    ", input);

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables[0].Rows)
							{
								Models.Stop s = new Models.Stop();
                                s.StopID = Convert.ToInt32(row["StopID"]);
                                int checker = 0;
                                
                                foreach(Models.Stop g in StopList){
                                    if(g.StopID == s.StopID){
                                        g.LineColor = string.Format("{0}; {1}", g.LineColor, Convert.ToString(row["Color"]));
                                        checker = 1;
                                        continue;
                                    }
                                    
                                }
                                
                                if(checker == 1){
                                    continue;
                                }
                                
                                s.StopName = Convert.ToString(row["Name"]);
                                s.Direction = Convert.ToString(row["Direction"]);
                                s.Latitude = Convert.ToString(row["Latitude"]);
                                s.Longitude = Convert.ToString(row["Longitude"]);
                                s.LineColor = Convert.ToString(row["Color"]);
                                 
                                
                                try{
                                    if(Convert.ToInt32(row["ADA"]) == 0 ){
                                        s.HandiCap = "No";
                                    }
                                    else if (Convert.ToInt32(row["ADA"]) == 1){
                                        s.HandiCap = "Yes";
                                    }
                                    
                                      
                                }catch(Exception ex){
                                    
                                }
                                
                                
								
								StopList.Add(s);
							}
						}//else
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