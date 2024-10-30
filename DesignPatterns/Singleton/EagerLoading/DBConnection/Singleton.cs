public sealed class Singleton
{

    private static Singleton _instance;
    private static object _instanceLock = new object();
    public static Singleton Instance
    {
        get
        {
            if (_instance != null) return _instance;
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
            return _instance;
        }
    }

    private Singleton()
    {
            
    }

    public int  Counter { get; set; }     

}