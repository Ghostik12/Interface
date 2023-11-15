using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();

            Worker worker = new Worker();
            //worker.Build();
            ((IWorker)worker).Build();
        }
    }

    public class Writer : IWriter
    {
        void IWriter.Write() 
        {
            throw new NotImplementedException();
        }
    }

    public interface IWriter
    {
        void Write();
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            throw new Exception();
        }
    }

    public interface IWorker
    {
        public void Build();
    }
}