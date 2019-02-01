using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolyCloud.Storage.Tests
{
    [TestClass]
    public class AWSTests
    {
        [TestCategory("AWS")]
        [TestMethod]
        public void CreateFolderAndFile()
        {
            Console.WriteLine("Test: AWS | CreateFolderAndFile");

            // Set your storage account credentials here before running tests

            String accessKey = "BKIAIBVVWJCZIPZQM2ZA";
            String secretKey = "xQlSUFBSLr5x3FvyccBJy5rcD3e93Ftwzic18gQH";
            String endpoint = "us-east-1";

            using (Storage storage = Storage.AWS(accessKey, secretKey, endpoint))
            {
                storage.HandleErrors = false;
                storage.Open();

                // Create folder

                String folderName = "test-" + Guid.NewGuid().ToString();
                Console.WriteLine("Creating folder " + folderName);
                storage.NewFolder(folderName);

                // Create file in folder

                String fileName = "test.txt";
                String fileName2 = "test2.txt";

                Console.WriteLine("Creating file " + fileName);

                String content = "This is a test.";

                if (File.Exists(fileName)) File.Delete(fileName);
                File.WriteAllText(fileName, content);

                // Upload file

                Console.WriteLine("Uploading file " + fileName);

                storage.UploadFile(folderName, fileName);

                // Retrieving file

                Console.WriteLine("Downloading file " + fileName + " as " + fileName2);

                if (File.Exists(fileName2)) File.Delete(fileName2);
                storage.DownloadFile(folderName, fileName, fileName2);

                // Retrieve file

                Console.WriteLine("Downloading file " + fileName + " as " + fileName2);

                if (File.Exists(fileName2)) File.Delete(fileName2);
                storage.DownloadFile(folderName, fileName, fileName2);

                // Delete file

                storage.DeleteFile(folderName, fileName);

                // Delete folder

                Console.WriteLine("Deleting test folder");
                storage.DeleteFolder(folderName);

                Console.WriteLine("Verifying content");

                String content2 = File.ReadAllText(fileName2);
                Assert.AreEqual(content, content2, "Downloaded file content did not match uploaded file content");

                storage.Close();
            }
        }
    }


}
