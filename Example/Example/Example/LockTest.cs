namespace Example.Example
{
    /// <summary>鎖住</summary>
    public class LockTest
    {
        /*
         * 參考資料：
         * https://ithelp.ithome.com.tw/articles/10309293
         * https://raychiutw.github.io/2019/%E9%9A%A8%E6%89%8B-Design-Pattern-6-%E5%96%AE%E4%BE%8B%E6%A8%A1%E5%BC%8F-Singleton-Pattern/
         */
        private static object lockObject = new object();
        private string testStringA = "";
        private static string testStringB = "";

        public void App()
        {
            Console.WriteLine(LockEP01("123"));
            Console.WriteLine(LockEP01("456"));
        }

        #region LockEP01 [ 防止多個執行緒同時執行共用程式段 ]
        /// <summary>防止多個執行緒同時執行共用程式段</summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string LockEP01(string str)
        {
            try
            {
                // 避免 同時呼叫產生 static被覆蓋的問題, 設定 lock鎖住 lockObject直到 return後 lock才解除
                lock (lockObject)
                {
                    testStringA = str;
                    testStringB = str;

                    return testStringA + " ， " + testStringB;
                }
            }
            catch
            {
                return "ERROR!";
            }
        }
        #endregion
    }
}
