using System.Collections.Generic;

namespace W3000.Utils
{
    public static class HelperNumber
    {
        public static int GetNextAvailableID(IList<int> list)
        {
            if (list.Count == 0)
                return 1;

            if (!list.Contains(1))
                return 1;

            if (list.Count == 1)
                return list[0] + 1;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] + 1 < list[i + 1])
                    return list[i] + 1;
            }

            return list[list.Count - 1] + 1;
        }
    }
}
