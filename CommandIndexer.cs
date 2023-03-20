namespace CmdControl
{
    public class CommandIndexer
    {
        private readonly Dictionary<string, Commands> _dictionary;

        public CommandIndexer()
        {
            this._dictionary = new Dictionary<string, Commands>();
        }
        public Commands this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
