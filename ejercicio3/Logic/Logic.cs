using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Logic
{
    public abstract class Logic
    {
        protected readonly NorthwindContext context;

        public Logic()
        {
            this.context = new NorthwindContext();
        }

    }
}
