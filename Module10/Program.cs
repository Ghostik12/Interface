using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public interface IWrite
    {
        void Write();
    }
    public interface IReader
    {
        void Read();
    }
    public interface IMailer
    {
        void Sendmail();
    }

    class FileManager : IWrite, IReader, IMailer
    {
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Sendmail()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}