using System;
using System.Collections;

namespace W3000.BizData
{
	[Serializable]
    public class BizKeyValueCollection : CollectionBase
    {
        public void Add(BizKeyValue entity)
		{
			this.List.Add(entity);
		}

        public void Insert(int index, BizKeyValue entity)
		{
			this.List.Insert(index, entity);
		}

        public void Remove(BizKeyValue entity)
		{
			this.List.Remove(entity);
		}

        public BizKeyValue this[int index]
		{
            get { return (BizKeyValue)base.List[index]; }
			set{{ base.List[index] = value; }}
		}

    }
}
