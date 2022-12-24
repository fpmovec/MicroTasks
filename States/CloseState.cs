using State.DB;
using State.Interfaces;

namespace State.States
{
    public class CloseState : IDBState
    {
        public void Open(DBConnection db)
        {
            Console.WriteLine("Opening is succesfully\tclose --> open");
            db.state = new OpenState();
        }
        public void Process(DBConnection db)
        {
            Console.WriteLine("Processing cannot be performed");
        }
        public void Close(DBConnection db)
        {
            Console.WriteLine("Connection is already closed");
        }
    }
}
