

using Microsoft.AspNetCore.Hosting;

namespace eShopSolution.Application.Common
{
    public class FileStorageService : IStorageService
    {
        private readonly string _userContentFolder;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";

        public FileStorageService(IWebHostEnvironment webHostEnvironment)
        {
            // Con hàm ở ManageProductService và ở đây
        }
    }
}
