namespace Example.ExtensionMethods
{
    /// <summary>Linq擴充方法</summary>
    public static class LinqEx
    {
        public static void App()
        {
            string[] strList = new string[]
            {
                "Test",
                "Benson",
                "Hello"
            };

            Console.WriteLine("英文轉大寫", strList.ListUpper());
            Console.WriteLine("英文轉小寫", strList.ListLowwer());
        }

        #region ListUpper [ List英文大寫 ]
        /// <summary>List英文大寫</summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static IEnumerable<string> ListUpper(this IEnumerable<string> list)
        {
            var result = new List<string>();

            foreach (var item in list)
            {
                result.Add(item.ToUpper());
            }

            return result;
        }
        #endregion

        #region ListUpper [ List英文小寫 ]
        /// <summary>List英文小寫</summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static IEnumerable<string> ListLowwer(this IEnumerable<string> list)
        {
            var result = new List<string>();

            foreach (var item in list)
            {
                result.Add(item.ToLower());
            }

            return result;
        }
        #endregion
    }
}
