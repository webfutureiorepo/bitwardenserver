using Bit.Core.Enums;

namespace Bit.Core.Models.Api
{
    public class AttachmentUploadDataResponseModel : ResponseModel
    {
        public string AttachmentId { get; set; }
        public string Url { get; set; }
        public FileUploadType FileUploadType { get; set; }
        public CipherResponseModel CipherResponse { get; set; }
        public CipherMiniResponseModel CipherMiniResponse { get; set; }

        public AttachmentUploadDataResponseModel() : base("attachment-fileUpload") { }
    }
}
