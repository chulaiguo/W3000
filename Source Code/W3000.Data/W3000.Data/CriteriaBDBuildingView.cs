using System;

namespace W3000.Data
{
    [Serializable]
    public class CriteriaBDBuildingView
    {
        private string _streetNumber = string.Empty;
        private string _streetName = string.Empty;
        private string _buildingName = string.Empty;
        private string _state = string.Empty;
        private string _city = string.Empty;
        private string _zipcode = string.Empty;

        public string StreetNumber
        {
            get { return _streetNumber; }
            set { _streetNumber = value; }
        }

        public string StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }

        public string BuildingName
        {
            get { return _buildingName; }
            set { _buildingName = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public bool IsEmpty()
        {
            if (!string.IsNullOrEmpty(this.StreetNumber))
                return false;

            if (!string.IsNullOrEmpty(this.StreetName))
                return false;

            if (!string.IsNullOrEmpty(this.BuildingName))
                return false;

            if (!string.IsNullOrEmpty(this.State))
                return false;

            if (!string.IsNullOrEmpty(this.City))
                return false;

            if (!string.IsNullOrEmpty(this.Zipcode))
                return false;

            return true;
        }
    }
}
