using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geoJSON_to_iosJSON_converter.Model
{
   

    public class Properties
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<List<double>> coordinates { get; set; }
    }

    public class geoJSON
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
    }

    


    public class LatLn
    {
        public double lat { get; set; }
        public double ln { get; set; }
    }


    public class iosJSON
    {
        public string name { get; set; }
        public string zone { get; set; }
        public string apn { get; set; }
        public string address { get; set; }
        
        public List<LatLn> feature { get; set; }
    
    }






}
