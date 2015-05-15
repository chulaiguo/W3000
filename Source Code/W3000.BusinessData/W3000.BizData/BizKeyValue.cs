using System;

namespace W3000.BizData
{
	[Serializable]
    public class BizKeyValue
	{
	    private string _key = string.Empty;
	    private string _value = string.Empty;

        public BizKeyValue()
        {
        }

        public BizKeyValue(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

	    public string Key
	    {
	        get { return _key; }
	        set { _key = value; }
	    }

	    public string Value
	    {
	        get { return _value; }
	        set { _value = value; }
	    }
	}
}
