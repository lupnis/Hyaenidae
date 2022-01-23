using System;
namespace Hyaenidae.Misc
{
    public class GlobalServerOperation
    {
        public static void SetServerStatus(GlobalData.ServerStatus serverStatus)
        {
            GlobalData.Status = serverStatus;
            if(serverStatus == GlobalData.ServerStatus.Up)
            {
                GlobalData.Activated = DateTime.Now;
            }
            else
            {
                GlobalData.Activated = new DateTime(9999,12,31);
            }
        }


    }
}
