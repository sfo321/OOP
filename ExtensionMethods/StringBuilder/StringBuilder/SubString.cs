namespace StringBuilder
{
    using System.Text;

    public static class SubString
    {
        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            return new StringBuilder(input.ToString().Substring(index));
        }
        
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            return new StringBuilder(input.ToString().Substring(index, length));
        }
    }
}
