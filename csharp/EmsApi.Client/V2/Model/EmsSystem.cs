﻿using Newtonsoft.Json;

namespace EmsApi.Client.V2.Model
{
    /// <summary>
    /// Represents a single EMS system connected to the API endpoint.
    /// </summary>
    public class EmsSystem : CommonModels.IdAndDescriptionModel
    {
        /// <summary>
        /// The human-readable name describing the EMS system.
        /// </summary>
        [JsonProperty]
        public string Name { get; set; }

        /// <summary>
        /// The path to the "DirAdi" location indicating the location of the installed EMS system.
        /// </summary>
        [JsonProperty]
        public string DirAdi { get; set; }

        /// <summary>
        /// The path to the collection location indicating where data collections for this EMS system should go.
        /// </summary>
        [JsonProperty]
        public string DirCollection { get; set; }
    }
}
