using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface IValueIncrese<T> : IValue<T>, IValue2<T>, ISumMethod<T>, IProduct<T>
    {

    }
}
