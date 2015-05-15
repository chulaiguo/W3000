namespace W3000.BizData
{
    public class BizDBPermission
    {
        private int _ruleID = 0;
        private string _tableName = string.Empty;
        private bool _deletable = false;
        private bool _insertable = false;
        private bool _selectable = false;
        private bool _editable = false;

        public int RuleID
        {
            get { return _ruleID; }
            set { _ruleID = value; }
        }

        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        public bool Deletable
        {
            get { return _deletable; }
            set { _deletable = value; }
        }

        public bool Insertable
        {
            get { return _insertable; }
            set { _insertable = value; }
        }

        public bool Selectable
        {
            get { return _selectable; }
            set { _selectable = value; }
        }

        public bool Editable
        {
            get { return _editable; }
            set { _editable = value; }
        }
    }
}
