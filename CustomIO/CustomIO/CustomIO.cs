using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIO
{
    public abstract class BaseIO
    {
        /// <summary>
        /// Order of the bytes(LE,BE)
        /// </summary>
        public enum ByteOrder
        {
            BigEndian,
            LittleEndian
        }

        protected ByteOrder byteoreder;
    }

    public class CustomReader : BaseIO
    {
        private BinaryReader binary_reader;

        /// <summary>
        /// Position to read at.
        /// </summary>
        public long Position { get => binary_reader.BaseStream.Position; set => binary_reader.BaseStream.Position = value; }

        public CustomReader(string path)
        {
            this.binary_reader = new BinaryReader(File.OpenRead(path));
            this.byteoreder = ByteOrder.BigEndian;
        }

        public CustomReader(string path,ByteOrder order)
        {
            this.binary_reader = new BinaryReader(File.OpenRead(path));
            this.byteoreder = order;
        }

        public byte ReadByte()
        {
            return binary_reader.ReadByte();
        }

        public sbyte ReadSByte()
        {
            return (sbyte)binary_reader.ReadByte();
        }

        public short ReadInt16()
        {
            short temp = binary_reader.ReadInt16();
            if (this.byteoreder==ByteOrder.LittleEndian)
            {
                return temp;
            }
            else
            {
                byte[] arr = BitConverter.GetBytes(temp);
                Array.Reverse(arr);
                temp = BitConverter.ToInt16(arr, 0);
                return temp;
            }
        }

        public ushort ReadUInt16()
        {
            ushort temp = binary_reader.ReadUInt16();
            if (this.byteoreder == ByteOrder.LittleEndian)
            {
                return temp;
            }
            else
            {
                byte[] arr = BitConverter.GetBytes(temp);
                Array.Reverse(arr);
                temp = BitConverter.ToUInt16(arr, 0);
                return temp;
            }
        }


        public int ReadInt32()
        {
            int temp = binary_reader.ReadInt32();
            if (this.byteoreder == ByteOrder.LittleEndian)
            {
                return temp;
            }
            else
            {
                byte[] arr = BitConverter.GetBytes(temp);
                Array.Reverse(arr);
                temp = BitConverter.ToInt32(arr, 0);
                return temp;
            }
        }

        public uint ReaduInt32()
        {
            uint temp = binary_reader.ReadUInt32();
            if (this.byteoreder == ByteOrder.LittleEndian)
            {
                return temp;
            }
            else
            {
                byte[] arr = BitConverter.GetBytes(temp);
                Array.Reverse(arr);
                temp = BitConverter.ToUInt32(arr, 0);
                return temp;
            }
        }

        public long ReadInt64()
        {
            long temp = binary_reader.ReadInt64();
            if (this.byteoreder == ByteOrder.LittleEndian)
            {
                return temp;
            }
            else
            {
                byte[] arr = BitConverter.GetBytes(temp);
                Array.Reverse(arr);
                temp = BitConverter.ToInt64(arr, 0);
                return temp;
            }
        }

        public ulong ReadUInt64()
        {
            ulong temp = binary_reader.ReadUInt64();
            if (this.byteoreder == ByteOrder.LittleEndian)
            {
                return temp;
            }
            else
            {
                byte[] arr = BitConverter.GetBytes(temp);
                Array.Reverse(arr);
                temp = BitConverter.ToUInt64(arr, 0);
                return temp;
            }
        }

        public byte[] ReadBytes(int amount)
        {
            byte[] buffer = binary_reader.ReadBytes(amount);
            if(this.byteoreder==ByteOrder.LittleEndian)
            {
                Array.Reverse(buffer);
                return buffer;
            }
            else
            {
                return buffer;
            }
        }

        public void Close()
        {
            binary_reader.Close();
        }

        public void ChangeByteOrder(ByteOrder order)
        {
            this.byteoreder = order;
        }

        public string ReadString(int lenght)
        {
            char[] chars=binary_reader.ReadChars(lenght);
            string retVal = new string(chars);
            return retVal;
        }

        public string ReadUnicodeString(int lenght)
        {
            if(this.byteoreder==ByteOrder.BigEndian)
            {
                return Encoding.BigEndianUnicode.GetString(binary_reader.ReadBytes(lenght));
            }
            else
            {
                return Encoding.Unicode.GetString(binary_reader.ReadBytes(lenght));
            }
        }

        public char ReadChar()
        {
            return binary_reader.ReadChar();
        }

        public char[] ReadChars(int amount)
        {
            return binary_reader.ReadChars(amount);
        }



    }
    
    public class CustomWriter : BaseIO
    {
        private BinaryWriter binary_writer;

        /// <summary>
        /// Position to read at.
        /// </summary>
        public long Position { get => binary_writer.BaseStream.Position; set => binary_writer.BaseStream.Position = value; }

        public CustomWriter(string path)
        {
            this.binary_writer = new BinaryWriter(File.OpenWrite(path));
            this.byteoreder = ByteOrder.BigEndian;
        }

        public CustomWriter(string path, ByteOrder order)
        {
            this.binary_writer = new BinaryWriter(File.OpenWrite(path));
            this.byteoreder = order;
        }

        public void WriteByte(byte toWrite)
        {
            binary_writer.Write(toWrite);
        }

        public void WriteBytes(byte[] toWrite)
        {
            if(this.byteoreder==ByteOrder.BigEndian)
            {
                Array.Reverse(toWrite);
                binary_writer.Write(toWrite);
            }
            else
            {
                binary_writer.Write(toWrite);
            }
        }

        public void WriteInt16(short toWrite)
        {
            byte[] arr = BitConverter.GetBytes(toWrite);
            if(this.byteoreder==ByteOrder.BigEndian)
            {
                Array.Reverse(arr);
                binary_writer.Write(arr);
            }
            else
            {
                binary_writer.Write(arr);
            }
        }

        public void WriteUInt16(ushort toWrite)
        {
            byte[] arr = BitConverter.GetBytes(toWrite);
            if (this.byteoreder == ByteOrder.BigEndian)
            {
                Array.Reverse(arr);
                binary_writer.Write(arr);
            }
            else
            {
                binary_writer.Write(arr);
            }
        }

        public void WriteInt32(int toWrite)
        {
            byte[] arr = BitConverter.GetBytes(toWrite);
            if (this.byteoreder == ByteOrder.BigEndian)
            {
                Array.Reverse(arr);
                binary_writer.Write(arr);
            }
            else
            {
                binary_writer.Write(arr);
            }
        }

        public void WriteUInt32(uint toWrite)
        {
            byte[] arr = BitConverter.GetBytes(toWrite);
            if (this.byteoreder == ByteOrder.BigEndian)
            {
                Array.Reverse(arr);
                binary_writer.Write(arr);
            }
            else
            {
                binary_writer.Write(arr);
            }
        }

        public void WriteInt64(long toWrite)
        {
            byte[] arr = BitConverter.GetBytes(toWrite);
            if (this.byteoreder == ByteOrder.BigEndian)
            {
                Array.Reverse(arr);
                binary_writer.Write(arr);
            }
            else
            {
                binary_writer.Write(arr);
            }
        }

        public void WriteUInt64(ulong toWrite)
        {
            byte[] arr = BitConverter.GetBytes(toWrite);
            if (this.byteoreder == ByteOrder.BigEndian)
            {
                Array.Reverse(arr);
                binary_writer.Write(arr);
            }
            else
            {
                binary_writer.Write(arr);
            }
        }

        public void WriteString(string toWrite)
        {
            binary_writer.Write(toWrite.ToCharArray());
        }

        public void WriteUnicodeString(string toWrite)
        {
            byte[] buffer = this.byteoreder == ByteOrder.BigEndian ? Encoding.BigEndianUnicode.GetBytes(toWrite) 
                : Encoding.Unicode.GetBytes(toWrite);
            binary_writer.Write(buffer);

        }

        public void WriteChar(char toWrite)
        {
            binary_writer.Write(toWrite);
        }

        public void WriteChars(char[] toWrite)
        {
            binary_writer.Write(toWrite);
        }

        public void Close()
        {
            binary_writer.Close();
        }

        public void ChangeByteOrder(ByteOrder order)
        {
            this.byteoreder = order;
        }







    }



}
