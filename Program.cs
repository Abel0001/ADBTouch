using AdvancedSharpAdbClient;
using AdvancedSharpAdbClient.DeviceCommands;
class Program{
static AdbClient adbClient;
static DeviceData deviceData;

    static void Main(){
        Console.WriteLine("asd");    
        
        if (!AdbServer.Instance.GetStatus().IsRunning)
        {
            AdbServer server = new AdbServer();
            StartServerResult result = server.StartServer(@"E:\ADB\platform-tools\adb.exe", false);
            if (result != StartServerResult.Started)
            {   
                Console.WriteLine("Can't start adb server");
            }
        }

            adbClient = new AdbClient();
            adbClient.Connect("127.0.0.1:58526");
            deviceData = adbClient.GetDevices().FirstOrDefault();
            adbClient.SendKeyEvent(deviceData, "KEYCODE_6");
        }
}