namespace W3000.BizData
{
    public class BizBRPermission
    {
        private int _ruleID = 0;
        private bool _denied = false;

        public int RuleID
        {
            get { return _ruleID; }
            set { _ruleID = value; }
        }

        public bool Denied
        {
            get { return _denied; }
            set { _denied = value; }
        }
    }
}
