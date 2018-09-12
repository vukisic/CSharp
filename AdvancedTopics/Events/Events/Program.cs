using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        // 1. Define a delegate (Contract)
        // 2. Define a Event based on delegate
        // 3. Rise an Event
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video1" };
            var videoEncoder = new VideoEncoder(); //Pusblisher
            var mailService = new MailService(); //Subsriber
            var messageService = new MessageService();//Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }

    }

    public class MailService
    {
        public void OnVideoEncoded(object obj,VideoEventArgs args)
        {
            Console.WriteLine("{0} -> Mail service: Sending an Email...",args.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object obj, VideoEventArgs args)
        {
            Console.WriteLine("{0} -> Message service: Sending a Message...",args.Video.Title);
        }
    }
}
