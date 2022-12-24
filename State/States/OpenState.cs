using State.DB;
using State.Interfaces;

namespace State.States
{
    public class OpenState : IDBState
    {
        public void Open(DBConnection db)
        {
            Console.WriteLine("Connection is already opened");
        }
        public void Process(DBConnection db)
        {
            Console.WriteLine("Processing is succesfully\t(open --> process)");
            db.state = new ProcessState();
        }
        public void Close(DBConnection db)
        {
            Console.WriteLine("Closing is succesfully\t(open --> close)");
            db.state = new CloseState();
        }
    }
}
