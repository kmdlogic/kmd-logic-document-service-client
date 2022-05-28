// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.DocumentService.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CompanyDocumentResponse
    {
        /// <summary>
        /// Initializes a new instance of the CompanyDocumentResponse class.
        /// </summary>
        public CompanyDocumentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompanyDocumentResponse class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="companyDocumentType">Possible values include:
        /// 'Document', 'DigitalPostCoverLetter',
        /// 'SnailMailCoverLetter'</param>
        /// <param name="fileAccessPageUrl"></param>
        public CompanyDocumentResponse(System.Guid? documentId = default(System.Guid?), string companyDocumentType = default(string), string fileAccessPageUrl = default(string))
        {
            DocumentId = documentId;
            CompanyDocumentType = companyDocumentType;
            FileAccessPageUrl = fileAccessPageUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentId")]
        public System.Guid? DocumentId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Document',
        /// 'DigitalPostCoverLetter', 'SnailMailCoverLetter'
        /// </summary>
        [JsonProperty(PropertyName = "companyDocumentType")]
        public string CompanyDocumentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileAccessPageUrl")]
        public string FileAccessPageUrl { get; set; }

    }
}
