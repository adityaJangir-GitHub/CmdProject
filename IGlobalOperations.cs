namespace CmdControl
{
    public interface IGlobalOperations
    {
        void ReadData();
        void ClearData();
        void InsertData(string value);
        void DeleteFile();
        
    }
}
