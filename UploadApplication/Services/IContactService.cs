using UploadApplication.Models;

namespace UploadApplication.Services
{
    public interface IContactService
    {
        void Import(ContactImport importFile);
    }
}