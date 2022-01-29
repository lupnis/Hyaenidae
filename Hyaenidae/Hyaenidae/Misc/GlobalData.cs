using System;
namespace Hyaenidae.Misc
{
    public class GlobalData
    {
        public enum ServerStatus
        {
            Down,
            Up,
            Maintain
        };
        public const string Name = "Hyaenidae";
        public const string SubName = "Primidae Server";
        public const string Version = "0.0.0";
        public static ServerStatus Status = ServerStatus.Up;
        public static DateTime Activated = DateTime.Now;

        
        protected const string RedisConnectionString = "127.0.0.1:6379";
    }
}
