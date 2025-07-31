using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public abstract class IEntityBase<TID>
    {
        public TID Id { get; set; }
    }
}
