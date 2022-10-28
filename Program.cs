using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IFileReader
    {
        object Reader();
    }
    public class FileItem : IFileReader
    {
        public string InFilePath { get; set; }
        public string InArchieveType { get; set; }
        public string InFileType { get; set; }
        public string OutFileType { get; set; }
        public string OutArchieveType { get; set; }
        private string _expression { get; set; }

        public Stream archiveStream;

        public object Reader()
        {
            return this;
        }

        void SetExpression(string exp)
        {
            _expression = exp;
        }
        public string GetExpression()
        {
            return _expression;
        }
        public override string ToString() =>
            new StringBuilder()
            .Append(InFilePath + "\n")
            .Append(InArchieveType + "\n")
            .Append(InFileType + "\n")
            .Append(OutFileType + "\n")
            .Append(OutArchieveType + "\n")
            .Append(_expression + "\n")
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
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
