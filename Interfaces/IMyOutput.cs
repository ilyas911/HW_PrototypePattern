using HW_PrototypePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrototypePattern.Interfaces
{
    public interface IMyOutput<T>
    {
        void MyOutput(T item)
        {

        }
        void MyOutput(object item)
        {

        }
    }
}
