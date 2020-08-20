using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM.DatabaseModel
{
    /// <summary>
    /// The Government body .. Senate, Lower Houese, Council etc.
    /// </summary>
    public class GovBody
    {
        public long Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        ///  Assuming all GovBodies have a GovEntity as a parent
        /// </summary>
        public int Parent { get; set; }
        
        public List<Language> Languages { get; set; }
        public List<Meeting> Meetings { get; set; }
        public List<Topic> Topics { get; set; }

        public GovBody()
        {
        }
        public GovBody(string name, int entityID)
        {
            Name = name;
            Parent = entityID;
        }

    }
}
