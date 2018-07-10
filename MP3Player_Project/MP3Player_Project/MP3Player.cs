using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player_Project
{
    public class MP3Player
    {
        private StringBuilder ret=new StringBuilder();

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand,StringBuilder lpstrReturnString,int uReturnLength,int hdwCallBack);

        public void Open(string file)
        {
            string format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = String.Format(format, file);
            mciSendString(command, null, 0, 0);
        }

        public void Play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void Close()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void Pause()
        {
            string command = "pause MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void Volume(int vol)
        {
            if(vol>=0 && vol<=1000)
            {
                string command = "setaudio MediaFile volume to " + vol.ToString();
                mciSendString(command, null, 0, 0);
            }
        }

        public int GetLength()
        {
            string command = "status MediaFile length";
            mciSendString(command, ret, ret.Capacity, 0);
            return Int32.Parse(ret.ToString());
        }

        public void PlayAtPosition(int val)
        {
            string command = "play MediaFile from " + val.ToString(); ;
            mciSendString(command, null, 0, 0);
        }

        public int GetPosition()
        {
            try
            {
                string command = "status MediaFile position";
                mciSendString(command, ret, 128, 0);
                return Int32.Parse(ret.ToString());
            }
            catch { }
            return 0;
        }
    }
}
