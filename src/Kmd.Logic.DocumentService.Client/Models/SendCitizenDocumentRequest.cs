// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.DocumentService.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SendCitizenDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the SendCitizenDocumentRequest class.
        /// </summary>
        public SendCitizenDocumentRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendCitizenDocumentRequest class.
        /// </summary>
        /// <param name="configurationId">Citizen document config id</param>
        /// <param name="sendingSystem">Name of the sending system</param>
        /// <param name="cpr">Citizen CPR value</param>
        /// <param name="documentType">Name of the predefined document type to
        /// be used for subsequent delivery</param>
        /// <param name="citizenDocumentId">Id of the original document to
        /// share with the citizen</param>
        /// <param name="title">Title of the message</param>
        /// <param name="digitalPostCoverLetterId">Id of the digital post cover
        /// letter to share with the citizen</param>
        /// <param name="snailMailCoverLetterId">Id of the snail mail cover
        /// letter to share with the citizen</param>
        public SendCitizenDocumentRequest(System.Guid? configurationId = default(System.Guid?), string sendingSystem = default(string), string cpr = default(string), string documentType = default(string), System.Guid? citizenDocumentId = default(System.Guid?), string title = default(string), System.Guid? digitalPostCoverLetterId = default(System.Guid?), System.Guid? snailMailCoverLetterId = default(System.Guid?))
        {
            ConfigurationId = configurationId;
            SendingSystem = sendingSystem;
            Cpr = cpr;
            DocumentType = documentType;
            CitizenDocumentId = citizenDocumentId;
            Title = title;
            DigitalPostCoverLetterId = digitalPostCoverLetterId;
            SnailMailCoverLetterId = snailMailCoverLetterId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets citizen document config id
        /// </summary>
        [JsonProperty(PropertyName = "configurationId")]
        public System.Guid? ConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets name of the sending system
        /// </summary>
        [JsonProperty(PropertyName = "sendingSystem")]
        public string SendingSystem { get; set; }

        /// <summary>
        /// Gets or sets citizen CPR value
        /// </summary>
        [JsonProperty(PropertyName = "cpr")]
        public string Cpr { get; set; }

        /// <summary>
        /// Gets or sets name of the predefined document type to be used for
        /// subsequent delivery
        /// </summary>
        [JsonProperty(PropertyName = "documentType")]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or sets id of the original document to share with the citizen
        /// </summary>
        [JsonProperty(PropertyName = "citizenDocumentId")]
        public System.Guid? CitizenDocumentId { get; set; }

        /// <summary>
        /// Gets or sets title of the message
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets id of the digital post cover letter to share with the
        /// citizen
        /// </summary>
        [JsonProperty(PropertyName = "digitalPostCoverLetterId")]
        public System.Guid? DigitalPostCoverLetterId { get; set; }

        /// <summary>
        /// Gets or sets id of the snail mail cover letter to share with the
        /// citizen
        /// </summary>
        [JsonProperty(PropertyName = "snailMailCoverLetterId")]
        public System.Guid? SnailMailCoverLetterId { get; set; }

    }
}
