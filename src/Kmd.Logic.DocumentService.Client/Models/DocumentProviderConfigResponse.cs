// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.DocumentService.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DocumentProviderConfigResponse
    {
        /// <summary>
        /// Initializes a new instance of the DocumentProviderConfigResponse
        /// class.
        /// </summary>
        public DocumentProviderConfigResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DocumentProviderConfigResponse
        /// class.
        /// </summary>
        public DocumentProviderConfigResponse(System.Guid? configurationId = default(System.Guid?))
        {
            ConfigurationId = configurationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configurationId")]
        public System.Guid? ConfigurationId { get; set; }

    }
}
