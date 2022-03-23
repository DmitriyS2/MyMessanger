using MyMessanger;
using Newtonsoft.Json;

Message msg = new Message("Dmitriy", "Privet!", DateTime.UtcNow);
string output = JsonConvert.SerializeObject(msg);
Console.WriteLine(output);
Message deserializeMsg = JsonConvert.DeserializeObject<Message>(output);
Console.WriteLine(deserializeMsg);
//{ "UserName":"Dmitriy","MessageText":"Privet!","TimeStamp":"2022-03-23T10:40:34.0101235Z"}
//Dmitriy < 23.03.2022 10:40:34 >: Privet!


