namespace W3000.Utils
{
    [System.Serializable]
    public class BRRuleConstant
    {
        public const int _Show_Configure = 1001;
        public const int _Show_Password = 1002;
       
        private readonly int _id = 0;
        public int ID
        {
            get { return _id; }
        }

        private readonly string _description = string.Empty;
        public string Description
        {
            get { return _description; }
        }

        private BRRuleConstant(int id, string description)
        {
            this._id = id;
            this._description = description;
        }

        public static BRRuleConstant[] GetAll()
        {
            BRRuleConstant[] list = new BRRuleConstant[]
                {
                    new BRRuleConstant(_Show_Configure, "Show Configure"),
                    new BRRuleConstant(_Show_Password, "Show Password")
                };

            return list;
        }

        public static BRRuleConstant DefaultValue
        {
            get { return new BRRuleConstant(0, "Undefined"); }
        }

        public static BRRuleConstant FindByID(int id)
        {
            BRRuleConstant[] list = GetAll();
            foreach (BRRuleConstant item in list)
            {
                if (item.ID == id)
                    return item;
            }

            return DefaultValue;
        }
    }
}
