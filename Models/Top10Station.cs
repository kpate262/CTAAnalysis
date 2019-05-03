//
// One CTA Stop
//

namespace program.Models
{

  public class TopTenStations
	{
	
		// data members with auto-generated getters and setters:
	    public int DailyRiders { get; set; }
		public string StationName { get; set; }
		
	
		// default constructor:
		public TopTenStations()
		{ }
		
		// constructor:
		public TopTenStations(int dailyRiders, string name)
		{
			DailyRiders = dailyRiders;
			StationName = name;
            
		}
		
	}//class

}//namespace