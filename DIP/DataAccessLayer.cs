using System;

namespace DIP;

public class DataAccessLayer
{
    private readonly IFileLogger fileLogger;

    public DataAccessLayer(IFileLogger fileLogger)
    {
        this.fileLogger = fileLogger;
    }
    public void AddCustomer(string name){
        // Add customer to database
        // Write some logs
        this.fileLogger.Log(name);
    }
}
