using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOFLibrary
{
    /// <summary>
    /// Represents small tasks 
    /// inside the main quest.
    /// </summary>
    internal class TaskModel
    {
        public string TaskArticle { get; set; }
        public string TaskDescription { get; set; }
        [DefaultValue("Unknown")]
        public string TaskLocation { get; set; }
    }
}
