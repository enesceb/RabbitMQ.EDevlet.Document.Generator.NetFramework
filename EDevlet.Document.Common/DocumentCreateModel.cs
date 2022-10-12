using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDevlet.Document.Common
{
    public class DocumentCreateModel
    {
        public int UserId   { get; set; }   
        public string url { get; set; }
        public DocumentType DocumentType { get; set; }  
    }

    public enum DocumentType
    {
        Pdf,
        Html,
        Png
    }
}
