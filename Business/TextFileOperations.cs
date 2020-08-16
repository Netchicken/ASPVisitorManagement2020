using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASPVisitorManagement2020.Business
{
    public class TextFileOperations : ITextFileOperations
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TextFileOperations(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public IEnumerable<string> LoadConditionsForAcceptanceText()

        {

            string webRootPath = _webHostEnvironment.WebRootPath;
            FileInfo filePath = new FileInfo(Path.Combine(webRootPath, "COA.txt"));
            string[] lines = System.IO.File.ReadAllLines(filePath.ToString());
            return lines.ToList();

        }





    }
}
