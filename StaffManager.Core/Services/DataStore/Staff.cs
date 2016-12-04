using System;
using Cirrious.MvvmCross.Plugins.Sqlite;

namespace StaffManager.Core.Services.DataStore
{
    public class Staff
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        public string Name { get; set; }
		public bool Sex { get; set; }
		public string Address { get; set; }

        public DateTime Birthday { get; set; }
		public DateTime WhenUtc { get; set; }
        
        public bool LocationKnown { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }

        public string ImagePath { get; set; }
    }
}
