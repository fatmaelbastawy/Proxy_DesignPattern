using Proxy;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        SMSServiceProxy proxy = new SMSServiceProxy();

        Console.WriteLine(proxy.SendMsg("121", "01111111111", "msg1"));
        Console.WriteLine(proxy.SendMsg("121", "01111111111", "msg1"));
        Console.WriteLine(proxy.SendMsg("121", "01111111111", "msg1"));
        Console.WriteLine(proxy.SendMsg("121", "01111111111", "msg1"));
        Console.WriteLine(proxy.SendMsg("121", "01111111111", "msg1"));

        Console.ReadLine();
    }
    
}