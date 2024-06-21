

namespace Potholes.Detector.Services
{
    public class FileUpload : IFileUpload
    {
        public IWebHostEnvironment webHostEnvironment { get; set; }
        public FileUpload(IWebHostEnvironment webHost)
        {
            webHostEnvironment = webHost;
        }
        //public async Task UploadFile(IFileListEntry file)
        //{
        //    var path = Path.Combine(webHostEnvironment.ContentRootPath, "UploadFiles", file.Name);
        //    var memStream = new MemoryStream();
        //    await file.Data.CopyToAsync(memStream);

        //    using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
        //    {
        //        memStream.WriteTo(fileStream);
        //    }
        //}

        public string GetContentRootPath()
        {
            return webHostEnvironment.WebRootPath;
        }

        
    }
}
