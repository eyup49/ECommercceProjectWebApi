using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    internal interface IDisplayEntity
    {
        int DisplayOrder { get; set; }
        bool IsDisplay { get; set; }
    }
}
