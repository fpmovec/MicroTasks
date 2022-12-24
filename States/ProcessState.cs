
using State.DB;
using State.Interfaces;

namespace State.States
{
    public class ProcessState : IDBState
    {
        public void Open(DBConnection db)
        {
            Console.WriteLine("Opening cannot be performed");
        }
        public void Process(DBConnection db)
        {
            Console.WriteLine("Connection is already processing");
        }
        public void Close(DBConnection db)
        {
            Console.WriteLine("Closing is succesfully\t(process --> close)");
            db.state = new CloseState();
        }
    }
}
