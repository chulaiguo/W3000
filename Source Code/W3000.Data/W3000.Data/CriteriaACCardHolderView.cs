using System;

namespace W3000.Data
{
    [Serializable]
    public class CriteriaACCardHolderView
    {
        private Int32 _sitecode = 0;
        private Int32 _embossed = 0;
        private Int32 _encoded = 0;

        private Guid _bDBuildingPK = Guid.Empty;
        private Guid _bDTenantPK = Guid.Empty;

        private String _firstName = string.Empty;
        private String _lastName = string.Empty;
        private String _tenant = string.Empty;
    
        public Int32 Sitecode
        {
            get { return this._sitecode; }
            set { this._sitecode = value; }
        }

        public Int32 Embossed
        {
            get { return this._embossed; }
            set { this._embossed = value; }
        }

        public Int32 Encoded
        {
            get { return this._encoded; }
            set { this._encoded = value; }
        }

        public Guid BDBuildingPK
        {
            get { return _bDBuildingPK; }
            set { _bDBuildingPK = value; }
        }

        public Guid BDTenantPK
        {
            get { return _bDTenantPK; }
            set { _bDTenantPK = value; }
        }

        public String FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public String LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        public string Tenant
        {
            get { return _tenant; }
            set { _tenant = value; }
        }

        public bool IsEmpty()
        {
            if(this.Sitecode != 0 || this.Encoded != 0 || this.Embossed != 0)
                return false;

            if(this.FirstName.Length > 0 || this.LastName.Length > 0 || this.Tenant.Length > 0)
                return false;

            return true;
        }
    }
}