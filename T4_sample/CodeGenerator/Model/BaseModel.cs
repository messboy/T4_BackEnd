using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Model
{
    public class BaseModel
    {
        public string Namespace { get; set; }

        public string ClassName { get; set; }

        /// <summary>
        /// db context
        /// </summary>
        public string DataAccessContext { get; set; }

        public string ModelName { get; set; }

        public string TypeName { get; set; }
    }
}
