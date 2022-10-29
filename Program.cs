using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{  
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 1:");
            FileItem item = new FileItem();
            item.InFilePath = "input.zip";
            item.InArchieveType = Path.GetExtension(item.InFilePath);
            item.InFileType = "xml";
            ZipInDecorator zip = new ZipInDecorator(item);
            XmlDecorator xml = new XmlDecorator(zip);
            MD5Decorator md5 = new MD5Decorator(xml);
            Console.WriteLine(md5.Reader().ToString());

            Console.WriteLine("Example 2:");
            FileItem item1 = new FileItem();
            item1.InFilePath = "input.rar";
            item1.InArchieveType = Path.GetExtension(item1.InFilePath);
            item1.InFileType = "json";
            RarInDecorator rar = new RarInDecorator(item1);
            JsonDecorator json = new JsonDecorator(rar);
            MD5Decorator md5_1 = new MD5Decorator(json);
            Console.WriteLine(md5_1.Reader().ToString());
        }
    }

    public interface IFileReader
    {
        object Reader();
    }
    public class FileItem : IFileReader
    {
        public string InFilePath { get; set; }
        public string InArchieveType { get; set; }
        public string InFileType { get; set; }
        private string _expression { get; set; }
        private string _hashExpression { get; set; }

        public Stream archiveStream;

        public object Reader()
        {
            return this;
        }

        public void SetExpression(string exp)
        {
            _expression = exp;
        }
        public void SetHashExpression(string hashExp)
        {
            _hashExpression = hashExp;
        }
        public string GetExpression()
        {
            return _expression;
        }
        public string GetHashExpression()
        {
            return _hashExpression;
        }
        public override string ToString() =>
            new StringBuilder()
            .Append("Input path: " + InFilePath + "\n")
            .Append("Input archive type: " + InArchieveType + "\n")
            .Append("Input file type: " + InFileType + "\n")
            .Append("Readed expression: " + _expression + "\n")
            .Append("Encrypted expression: " + _hashExpression + "\n")
            .ToString();
    }
    class FileDecorator : IFileReader
    {
        private IFileReader _reader;
        public FileDecorator(IFileReader reader)
        {
            _reader = reader;   
        }
        public virtual object Reader()
        {
            return _reader.Reader();
        }
    }

}
