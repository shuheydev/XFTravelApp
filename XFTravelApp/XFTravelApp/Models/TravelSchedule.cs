using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFTravelApp.Models
{
    public class TravelSchedule
    {
        public string Time { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TransportType { get; set; }
        public Color TransportColor { get; set; }
        public bool IsLast { get; set; } = false;
    }
}
