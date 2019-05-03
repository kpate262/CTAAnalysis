//
// One CTA Stop
//

namespace program.Models
{

  public class Stop
	{
	
		// data members with auto-generated getters and setters:
	    public int StopID { get; set; }
		public string StopName { get; set; }
		public string Direction { get; set; }
        public string HandiCap { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string LineColor { get; set; }
	
		// default constructor:
		public Stop()
		{ }
		
		// constructor:
		public Stop(int id, string name, string direction, 
                    string handiCap, string latitude, string longitude, string lineColor)
		{
			StopID = id;
			StopName = name;
            Direction = direction;
            HandiCap = handiCap;
            Latitude = latitude;
            Longitude = longitude;
            LineColor = lineColor;
		}
		
	}//class

}//namespace