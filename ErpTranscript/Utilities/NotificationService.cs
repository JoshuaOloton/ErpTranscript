using ErpTranscript.Enums;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text.Json;

namespace ErpTranscript.Utilities
{
    public class NotificationService
    {
        public void Notify(String message, NotificationType notificationType, ITempDataDictionary tempData)
        {
            var msg = new
            {
                message = message,
                type = notificationType.ToString()
            };
            tempData["notification"] = JsonSerializer.Serialize(msg);
        }
    }
}
