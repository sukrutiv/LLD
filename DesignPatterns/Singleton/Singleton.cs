public sealed class Singleton
{
    //the volatile keyword ensures that the instantiation is complete 
    //before it can be accessed further helping with thread safety.
    private static volatile Singleton _instance;
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
