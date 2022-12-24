using State.DB;
namespace State.Interfaces
{
    public interface IDBState
    {
        void Open(DBConnection dB);
        void Process(DBConnection db);
        void Close(DBConnection dB);
        
    }
}
