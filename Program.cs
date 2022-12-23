using SingletonDBConnection;

var s = DbConnectionSingleton.Instance;
Console.WriteLine(s.ToString());
