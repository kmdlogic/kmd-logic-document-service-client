// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.DocumentService.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InternalClient.
    /// </summary>
    internal static partial class InternalClientExtensions
    {
            /// <summary>
            /// Uploads the single citizen document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// </param>
            /// <param name='cpr'>
            /// </param>
            /// <param name='retentionPeriodInDays'>
            /// </param>
            /// <param name='documentType'>
            /// Possible values include: 'CitizenDocument', 'DigitalPostCoverLetter',
            /// 'SnailMailCoverLetter'
            /// </param>
            /// <param name='document'>
            /// </param>
            /// <param name='documentName'>
            /// </param>
            public static object UploadAttachment(this IInternalClient operations, System.Guid subscriptionId, string configurationId = default(string), string cpr = default(string), int? retentionPeriodInDays = default(int?), string documentType = default(string), Stream document = default(Stream), string documentName = default(string))
            {
                return operations.UploadAttachmentAsync(subscriptionId, configurationId, cpr, retentionPeriodInDays, documentType, document, documentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Uploads the single citizen document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// </param>
            /// <param name='cpr'>
            /// </param>
            /// <param name='retentionPeriodInDays'>
            /// </param>
            /// <param name='documentType'>
            /// Possible values include: 'CitizenDocument', 'DigitalPostCoverLetter',
            /// 'SnailMailCoverLetter'
            /// </param>
            /// <param name='document'>
            /// </param>
            /// <param name='documentName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UploadAttachmentAsync(this IInternalClient operations, System.Guid subscriptionId, string configurationId = default(string), string cpr = default(string), int? retentionPeriodInDays = default(int?), string documentType = default(string), Stream document = default(Stream), string documentName = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UploadAttachmentWithHttpMessagesAsync(subscriptionId, configurationId, cpr, retentionPeriodInDays, documentType, document, documentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sends the documents to citizens
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static SendCitizenDocumentResponse SendDocument(this IInternalClient operations, System.Guid subscriptionId, SendCitizenDocumentRequest request)
            {
                return operations.SendDocumentAsync(subscriptionId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends the documents to citizens
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SendCitizenDocumentResponse> SendDocumentAsync(this IInternalClient operations, System.Guid subscriptionId, SendCitizenDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SendDocumentWithHttpMessagesAsync(subscriptionId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets link to storage with access to upload document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='documentName'>
            /// </param>
            public static string StorageAccess(this IInternalClient operations, System.Guid subscriptionId, string documentName)
            {
                return operations.StorageAccessAsync(subscriptionId, documentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets link to storage with access to upload document.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='documentName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> StorageAccessAsync(this IInternalClient operations, System.Guid subscriptionId, string documentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StorageAccessWithHttpMessagesAsync(subscriptionId, documentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the upload data to db
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object UpdateDataToDb(this IInternalClient operations, System.Guid subscriptionId, CitizenDocumentUpdateRequest request)
            {
                return operations.UpdateDataToDbAsync(subscriptionId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the upload data to db
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateDataToDbAsync(this IInternalClient operations, System.Guid subscriptionId, CitizenDocumentUpdateRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateDataToDbWithHttpMessagesAsync(subscriptionId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the citizen document by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            public static object GetDocument(this IInternalClient operations, System.Guid documentId)
            {
                return operations.GetDocumentAsync(documentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the citizen document by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetDocumentAsync(this IInternalClient operations, System.Guid documentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDocumentWithHttpMessagesAsync(documentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Loads the data for Citizen Document File Access Page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            public static CitizenDocumentFileAccessPageData GetFileAccessPageData(this IInternalClient operations, System.Guid documentId)
            {
                return operations.GetFileAccessPageDataAsync(documentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Loads the data for Citizen Document File Access Page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CitizenDocumentFileAccessPageData> GetFileAccessPageDataAsync(this IInternalClient operations, System.Guid documentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFileAccessPageDataWithHttpMessagesAsync(documentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Upload's citizen/company document for companies
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='documentConfigurationId'>
            /// </param>
            /// <param name='cvrs'>
            /// </param>
            /// <param name='document'>
            /// </param>
            /// <param name='retentionPeriodInDays'>
            /// </param>
            /// <param name='companyDocumentType'>
            /// Possible values include: 'Document', 'DigitalPostCoverLetter',
            /// 'SnailMailCoverLetter'
            /// </param>
            /// <param name='documentName'>
            /// </param>
            /// <param name='sender'>
            /// </param>
            /// <param name='documentComment'>
            /// </param>
            public static object UploadAttachmentForCompanies(this IInternalClient operations, System.Guid subscriptionId, string documentConfigurationId, IList<string> cvrs, Stream document, int? retentionPeriodInDays = default(int?), string companyDocumentType = default(string), string documentName = default(string), string sender = default(string), string documentComment = default(string))
            {
                return operations.UploadAttachmentForCompaniesAsync(subscriptionId, documentConfigurationId, cvrs, document, retentionPeriodInDays, companyDocumentType, documentName, sender, documentComment).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Upload's citizen/company document for companies
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='documentConfigurationId'>
            /// </param>
            /// <param name='cvrs'>
            /// </param>
            /// <param name='document'>
            /// </param>
            /// <param name='retentionPeriodInDays'>
            /// </param>
            /// <param name='companyDocumentType'>
            /// Possible values include: 'Document', 'DigitalPostCoverLetter',
            /// 'SnailMailCoverLetter'
            /// </param>
            /// <param name='documentName'>
            /// </param>
            /// <param name='sender'>
            /// </param>
            /// <param name='documentComment'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UploadAttachmentForCompaniesAsync(this IInternalClient operations, System.Guid subscriptionId, string documentConfigurationId, IList<string> cvrs, Stream document, int? retentionPeriodInDays = default(int?), string companyDocumentType = default(string), string documentName = default(string), string sender = default(string), string documentComment = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UploadAttachmentForCompaniesWithHttpMessagesAsync(subscriptionId, documentConfigurationId, cvrs, document, retentionPeriodInDays, companyDocumentType, documentName, sender, documentComment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the upload data to db
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object UpdateCompanyDataToDb(this IInternalClient operations, System.Guid subscriptionId, CompanyDocumentRequest request)
            {
                return operations.UpdateCompanyDataToDbAsync(subscriptionId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the upload data to db
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateCompanyDataToDbAsync(this IInternalClient operations, System.Guid subscriptionId, CompanyDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateCompanyDataToDbWithHttpMessagesAsync(subscriptionId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the company document by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            public static object GeCompanyDocument(this IInternalClient operations, System.Guid documentId)
            {
                return operations.GeCompanyDocumentAsync(documentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the company document by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GeCompanyDocumentAsync(this IInternalClient operations, System.Guid documentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GeCompanyDocumentWithHttpMessagesAsync(documentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Loads the data for Company Document File Access Page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            public static DocumentFileAccessPageData GetCompanyFileAccessPageData(this IInternalClient operations, System.Guid documentId)
            {
                return operations.GetCompanyFileAccessPageDataAsync(documentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Loads the data for Company Document File Access Page.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='documentId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DocumentFileAccessPageData> GetCompanyFileAccessPageDataAsync(this IInternalClient operations, System.Guid documentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCompanyFileAccessPageDataWithHttpMessagesAsync(documentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create provider config to send citizen/company document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object SaveConfig(this IInternalClient operations, System.Guid subscriptionId, DocumentProviderConfigRequest request)
            {
                return operations.SaveConfigAsync(subscriptionId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create provider config to send citizen/company document
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> SaveConfigAsync(this IInternalClient operations, System.Guid subscriptionId, DocumentProviderConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SaveConfigWithHttpMessagesAsync(subscriptionId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Loads the provider config.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            public static IList<DocumentConfigResponse> LoadProviderConfiguration(this IInternalClient operations, System.Guid subscriptionId)
            {
                return operations.LoadProviderConfigurationAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Loads the provider config.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DocumentConfigResponse>> LoadProviderConfigurationAsync(this IInternalClient operations, System.Guid subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LoadProviderConfigurationWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edit citizen document configuration settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// configuration Id
            /// </param>
            /// <param name='request'>
            /// </param>
            public static object EditConfig(this IInternalClient operations, System.Guid subscriptionId, System.Guid configurationId, DocumentProviderConfigRequest request)
            {
                return operations.EditConfigAsync(subscriptionId, configurationId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edit citizen document configuration settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// </param>
            /// <param name='configurationId'>
            /// configuration Id
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> EditConfigAsync(this IInternalClient operations, System.Guid subscriptionId, System.Guid configurationId, DocumentProviderConfigRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EditConfigWithHttpMessagesAsync(subscriptionId, configurationId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Loads all uploaded documents based on cpr number
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cpr'>
            /// </param>
            public static IList<LoadDocumentResponse> GetFileAccessListByCPr(this IInternalClient operations, string cpr)
            {
                return operations.GetFileAccessListByCPrAsync(cpr).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Loads all uploaded documents based on cpr number
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cpr'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LoadDocumentResponse>> GetFileAccessListByCPrAsync(this IInternalClient operations, string cpr, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFileAccessListByCPrWithHttpMessagesAsync(cpr, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Loads all uploaded documents based on cvr number
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cvr'>
            /// </param>
            public static IList<LoadDocumentResponse> GetFileAccessListByCvr(this IInternalClient operations, string cvr)
            {
                return operations.GetFileAccessListByCvrAsync(cvr).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Loads all uploaded documents based on cvr number
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cvr'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LoadDocumentResponse>> GetFileAccessListByCvrAsync(this IInternalClient operations, string cvr, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFileAccessListByCvrWithHttpMessagesAsync(cvr, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
