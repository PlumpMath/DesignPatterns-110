using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Structural
{
    public abstract class Prototype
    {
        private string _id;

        /// <summary>
        /// Constructor
        /// </summary>
        public Prototype(string id)
        {
            this._id = id;
        }

        /// <summary>
        /// Gets id
        /// </summary> 
        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}
