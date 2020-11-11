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
        protected readonly PracticaSQLContext context;

        public Logic()
        {
            this.context = new PracticaSQLContext();
        }

    }
}
