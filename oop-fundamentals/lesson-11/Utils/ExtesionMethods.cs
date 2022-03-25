namespace lesson_11.Utils
{
    public static class ExtesionMethods
    {
        public static string FirstUpperCase(this string str)
        {

            if (str.Length > 0)
            {
                char[] arr = str.ToCharArray();
                arr[0] = char.ToUpper(arr[0]);
                return new string(arr);
            }
            else
            {
                return str;
            }
        }
    }
}