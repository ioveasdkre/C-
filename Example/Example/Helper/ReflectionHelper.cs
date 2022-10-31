namespace Example.Helper
{
    public static class ReflectionHelper
    {
        #region Mapping [ 物件對應 ]
        /// <summary>物件對應</summary>
        /// <param name="T">輸出目標</param>
        /// <param name="U">來源</param>
        /// <returns>輸出目標</returns>
        public static T Mapping<T, U>(this U source) where T : new() where U : class
        {
            var target = new T();

            foreach (var tinfo in typeof(T).GetProperties())
            {
                var uinfo = typeof(U).GetProperty(tinfo.Name);

                if (uinfo != null && uinfo.PropertyType == tinfo.PropertyType)
                {
                    tinfo.SetValue(target, uinfo.GetValue(source));
                }
            }

            return target;
        }
        #endregion
    }
}
