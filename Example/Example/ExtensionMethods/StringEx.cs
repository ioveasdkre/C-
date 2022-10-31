namespace Example.ExtensionMethods
{
    /// <summary>String擴充方法</summary>
    public static class StringEx
    {
        public static void App()
        {
            string str = "abc";
            Console.WriteLine(str.StrUPP());
        }

        #region StrUPP [ Str英文大寫 ]
        /// <summary>Str英文大寫</summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StrUPP(this string str)
        {
            return str.ToUpper();
        }
        #endregion
    }
}
