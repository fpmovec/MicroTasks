
using State.Interfaces;

namespace State.DB
{
    public class DBConnection
    {
        public IDBState state { get; set; }
        public DBConnection(IDBState state) => this.state = state;

        public void Open() => state.Open(this);
        public void Process() => state.Process(this);
        public void Close() => state.Close(this);

    }
}
