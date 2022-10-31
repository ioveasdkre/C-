using System.Collections;
using System.Linq.Expressions;

namespace Example.Access
{
    /// <summary>IQueryable繼承 IEnumerable便可使用其 擴充方法
    /// <para> 可參 ExtensionMethodsLinqEx.cs</para>
    /// </summary>
    public interface IQueryable : IEnumerable
    {
        Expression Expression { get; set; }
        Type ElementType { get; set; }
        IQueryProvider Provider { get; set; }
    }
}
