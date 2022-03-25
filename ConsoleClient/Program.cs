using MyMessanger;
using Newtonsoft.Json;

class Program
{
    private static int MessageID;
    private static string UserName;
    private static MessangerClientAPI API = new MessangerClientAPI();

    private static void GetNewMessages()
    {
        Message msg = API.GetMessage(MessageID);
        while (msg != null)
        {
            Console.WriteLine(msg);
            MessageID++;
            msg = API.GetMessage(MessageID);
        }
    }
    static void Main(string[] args)
    {
        //Message msg = new Message("Dmitriy", "Privet!", DateTime.UtcNow);
        //string output = JsonConvert.SerializeObject(msg);
        //Console.WriteLine(output);
        //Message deserializeMsg = JsonConvert.DeserializeObject<Message>(output);
        //Console.WriteLine(deserializeMsg);
        //{ "UserName":"Dmitriy","MessageText":"Privet!","TimeStamp":"2022-03-23T10:40:34.0101235Z"}
        //Dmitriy < 23.03.2022 10:40:34 >: Privet!
        MessageID = 1;
        Console.WriteLine("Введите Ваше имя:");
        //UserName = "RusAl";
        UserName = Console.ReadLine();
        string MessageText = "";
        while (MessageText != "exit")
        {
            GetNewMessages();
            MessageText = Console.ReadLine();
            if (MessageText.Length > 1)
            {
                Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
                API.SendMessage(Sendmsg);
            }
        }
    }

}
