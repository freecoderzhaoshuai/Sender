using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount account;
            String connString = "DefaultEndpointsProtocol=https;AccountName=storageacczs;AccountKey=QLhVndW2bRnb58lGEB2QkVf0mFpXtHtcGo5gKUeUvO0sl/ku1KmSm/W9JlrzDyFhAGqAuiBHjA42UhDnG2X0Kw==;EndpointSuffix=core.windows.net";
            account = CloudStorageAccount.Parse(connString);
            CloudQueueClient client = account.CreateCloudQueueClient();
            CloudQueue queue = client.GetQueueReference("queue1");
            queue.CreateIfNotExists();
            String str = "Hello3";
            CloudQueueMessage message;
            message = new CloudQueueMessage(str);
            queue.AddMessage(message);
        }
    }
}
