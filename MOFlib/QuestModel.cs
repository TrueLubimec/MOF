using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOFLibrary
{
    /// <summary>
    /// Represents the template
    /// of the main quest
    /// </summary>
    internal class QuestModel
    {
        public Guid id { get; set; }
        public string QuestName { get; set; }
        public List<TaskModel> Quest { get; set; } = new List<TaskModel>();
        public string QuestRequester { get; set; }
        public string QuestExecuter { get; set;}
        public DateTime? QuestDeadline { get; set; }
    }
}
