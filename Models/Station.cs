//
// One CTA Station
//

namespace program.Models
{

  public class Station
	{
	
		// data members with auto-generated getters and setters:
	    public int StationID { get; set; }
		public string StationName { get; set; }
		public int AvgDailyRidership { get; set; }
        public int Stops { get; set; }
        public string HandiCap { get; set; }
	
		// default constructor:
		public Station()
		{ }
		
		// constructor:
		public Station(int id, string name, int avgDailyRidership, string handiCap, int nstops)
		{
			StationID = id;
			StationName = name;
			AvgDailyRidership = avgDailyRidership;
            Stops = nstops;
            this.HandiCap = handiCap;
		}
		
	}//class

}//namespace