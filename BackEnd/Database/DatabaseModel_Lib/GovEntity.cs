using GM.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModel_Lib
{



    public enum GovEntityTypes
    {
        City,
        Town,
        Boro,
        Township,
        County,
        StateOrProvince,
        Territory,
        Country
    };



    /// <summary>
    /// Government Entity an actual place such as state, county, city, country
    /// </summary>
    public class GovEntity
    {
        public long Id { get; set; }
        public GovEntityTypes GovEntityType { get; set; }

        /// <summary>
        /// The list of government bodies associated with this entity
        /// </summary>
        public List<GovBody> GovBodies { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// A set of entities under this one (CHI under IL)
        /// </summary>
        // public List<GovEntity> subEntities;

        /// <summary>
        ///  The parent to this entity
        /// </summary>
        GovEntity parentEntity;



    }
}
