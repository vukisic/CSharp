﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object obj, VideoEventArgs args);

        
        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding....");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded!=null)
            {
                VideoEncoded(this, new VideoEventArgs { Video = video });
            }
        }
    }
}
