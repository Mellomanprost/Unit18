using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._18._1._5
{
    /// <summary>
    /// Реализация первого объекта
    /// </summary>
    class ImplementationOne : BaseClass
    {
        public ImplementationOne(int id) : base(id){}

        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }
    }
}
