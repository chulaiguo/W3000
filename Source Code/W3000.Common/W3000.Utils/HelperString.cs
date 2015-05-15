namespace W3000.Utils
{
    public static class HelperString
    {
        public static bool IsDigits(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                    return false;
            }

            return true;
        }

        public static bool IsAEqualsB(string strA, string strB)
        {
            return string.Compare(strA.Trim(), strB.Trim(), true) == 0 ? true : false;
        }

        public static bool IsAContainsB(string strA, string strB)
        {
            return strA.Trim().ToUpper().Contains(strB.Trim().ToUpper());
        }

        public static bool IsAStartsWithB(string strA, string strB)
        {
            return strA.Trim().ToUpper().StartsWith(strB.Trim().ToUpper());
        }

        public static string ToNDigits(string numb, int len)
        {
            string temp = numb.Trim();
            while (temp.Length < len)
                temp = "0" + temp;

            return temp;
        }

        public static bool IsSitecodeEquals(string sitcodeA, string sitecodeB)
        {
            string numA = ToNDigits(sitcodeA, 4);
            string numB = ToNDigits(sitecodeB, 4);

            return IsAEqualsB(numA, numB) ? true : false;
        }

        public static bool IsEmbossEquals(string embossA, string embossB)
        {
            string numA = ToNDigits(embossA, 6);
            string numB = ToNDigits(embossB, 6);

            return IsAEqualsB(numA, numB) ? true : false;
        }

    }
}
