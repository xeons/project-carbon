using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarbon
{
    public enum EndianType
    {
        BigEndian,
        LittleEndian
    }
    public interface IBinaryConverter
    {
        EndianType Type { get; }
        byte[] GetBytes(bool value);
        byte[] GetBytes(char value);
        byte[] GetBytes(float value);
        byte[] GetBytes(double value);
        byte[] GetBytes(short value);
        byte[] GetBytes(int value);
        byte[] GetBytes(long value);
        byte[] GetBytes(ushort value);
        byte[] GetBytes(uint value);
        byte[] GetBytes(ulong value);

        bool ToBoolean(byte[] value, int startIndex);
        char ToChar(byte[] value, int startIndex);
        float ToSingle(byte[] value, int startIndex);
        double ToDouble(byte[] value, int startIndex);
        short ToInt16(byte[] value, int startIndex);
        int ToInt32(byte[] value, int startIndex);
        long ToInt64(byte[] value, int startIndex);
        ushort ToUInt16(byte[] value, int startIndex);
        uint ToUInt32(byte[] value, int startIndex);
        ulong ToUInt64(byte[] value, int startIndex);
    }
    #region BigEndianConverter
    public class BigEndianConverter : IBinaryConverter
    {
        public EndianType Type
        {
            get { return EndianType.BigEndian; }
        }

        public byte[] GetBytes(bool value)
        {
            return new byte[] { (byte)(value ? 0x01 : 0x00) };
        }

        public byte[] GetBytes(char value)
        {
            return GetBytes((short)value);
        }

        public unsafe byte[] GetBytes(float value)
        {
            return GetBytes(*((int*)&value));
        }

        public unsafe byte[] GetBytes(double value)
        {
            return GetBytes(*((long*)&value));
        }

        public byte[] GetBytes(short value)
        {
            byte[] buffer = new byte[2];

            buffer[0] = (byte)(value >> 8);
            buffer[1] = (byte)value;

            return buffer;
        }

        public byte[] GetBytes(int value)
        {
            byte[] buffer = new byte[4];

            buffer[0] = (byte)(value >> 0x18);
            buffer[1] = (byte)(value >> 0x10);
            buffer[2] = (byte)(value >> 8);
            buffer[3] = (byte)value;

            return buffer;
        }

        public byte[] GetBytes(long value)
        {
            byte[] buffer = new byte[8];

            buffer[0] = (byte)(value >> 0x38);
            buffer[1] = (byte)(value >> 0x30);
            buffer[2] = (byte)(value >> 0x28);
            buffer[3] = (byte)(value >> 0x20);
            buffer[4] = (byte)(value >> 0x18);
            buffer[5] = (byte)(value >> 0x10);
            buffer[6] = (byte)(value >> 8);
            buffer[7] = (byte)value;

            return buffer;
        }

        public byte[] GetBytes(ushort value)
        {
            byte[] buffer = new byte[2];

            buffer[0] = (byte)(value >> 8);
            buffer[1] = (byte)value;

            return buffer;
        }

        public byte[] GetBytes(uint value)
        {
            byte[] buffer = new byte[4];

            buffer[0] = (byte)(value >> 0x18);
            buffer[1] = (byte)(value >> 0x10);
            buffer[2] = (byte)(value >> 8);
            buffer[3] = (byte)value;

            return buffer;
        }

        public byte[] GetBytes(ulong value)
        {
            byte[] buffer = new byte[8];

            buffer[0] = (byte)(value >> 0x38);
            buffer[1] = (byte)(value >> 0x30);
            buffer[2] = (byte)(value >> 0x28);
            buffer[3] = (byte)(value >> 0x20);
            buffer[4] = (byte)(value >> 0x18);
            buffer[5] = (byte)(value >> 0x10);
            buffer[6] = (byte)(value >> 8);
            buffer[7] = (byte)value;

            return buffer;
        }

        public bool ToBoolean(byte[] value, int startIndex)
        {
            return (value[startIndex] == 0) ? false : true;
        }

        public char ToChar(byte[] value, int startIndex)
        {
            return (char)ToInt16(value, startIndex);
        }

        public unsafe float ToSingle(byte[] value, int startIndex)
        {
            int rv = ToInt32(value, startIndex);
            return *((float*)&rv);
        }

        public unsafe double ToDouble(byte[] value, int startIndex)
        {
            long rv = ToInt64(value, startIndex);
            return *((double*)&rv);
        }

        public short ToInt16(byte[] value, int startIndex)
        {
            return (short)((value[startIndex] << 8) | (value[++startIndex] & 0xff));
        }

        public int ToInt32(byte[] value, int startIndex)
        {
            return ((value[startIndex] << 0x18) | (value[++startIndex] << 0x10) | (value[++startIndex] << 8) | (value[++startIndex] & 0xff));
        }

        public long ToInt64(byte[] value, int startIndex)
        {
            uint hi = (uint)((value[startIndex] << 0x18) | (value[++startIndex] << 0x10) | (value[++startIndex] << 8) | (value[++startIndex] & 0xff));
            uint lo = (uint)((value[++startIndex] << 0x18) | (value[++startIndex] << 0x10) | (value[++startIndex] << 8) | (value[++startIndex] & 0xff));

            return (long)((((ulong)hi) << 0x20) | lo);
        }

        public ushort ToUInt16(byte[] value, int startIndex)
        {
            return (ushort)((value[startIndex] << 8) | (value[++startIndex] & 0xff));
        }

        
        public uint ToUInt32(byte[] value, int startIndex)
        {
            return (uint)((value[startIndex] << 0x18) | (value[++startIndex] << 0x10) | (value[++startIndex] << 8) | (value[++startIndex] & 0xff));
        }

        
        public ulong ToUInt64(byte[] value, int startIndex)
        {
            uint hi = (uint)((value[startIndex] << 0x18) | (value[++startIndex] << 0x10) | (value[++startIndex] << 8) | (value[++startIndex] & 0xff));
            uint lo = (uint)((value[++startIndex] << 0x18) | (value[++startIndex] << 0x10) | (value[++startIndex] << 8) | (value[++startIndex] & 0xff));

            return ((((ulong)hi) << 0x20) | lo);
        }
    }
    #endregion
    #region LittleEndianConverter
    public class LittleEndianConverter : IBinaryConverter
    {
        public EndianType Type
        {
            get { return EndianType.LittleEndian; }
        }

        public byte[] GetBytes(bool value)
        {
            return new byte[] { (byte)(value ? 0x01 : 0x00) };
        }

        public byte[] GetBytes(char value)
        {
            return GetBytes((short)value);
        }

        public unsafe byte[] GetBytes(float value)
        {
            return GetBytes(*((int*)&value));
        }

        public unsafe byte[] GetBytes(double value)
        {
            return GetBytes(*((long*)&value));
        }

        public byte[] GetBytes(short value)
        {
            byte[] buffer = new byte[2];

            buffer[0] = (byte)value;
            buffer[1] = (byte)(value >> 8);

            return buffer;
        }

        public byte[] GetBytes(int value)
        {
            byte[] buffer = new byte[4];

            buffer[0] = (byte)value;
            buffer[1] = (byte)(value >> 8);
            buffer[2] = (byte)(value >> 0x10);
            buffer[3] = (byte)(value >> 0x18);

            return buffer;
        }

        public byte[] GetBytes(long value)
        {
            byte[] buffer = new byte[8];

            buffer[0] = (byte)value;
            buffer[1] = (byte)(value >> 8);
            buffer[2] = (byte)(value >> 0x10);
            buffer[3] = (byte)(value >> 0x18);
            buffer[4] = (byte)(value >> 0x20);
            buffer[5] = (byte)(value >> 0x28);
            buffer[6] = (byte)(value >> 0x30);
            buffer[7] = (byte)(value >> 0x38);

            return buffer;
        }

        
        public byte[] GetBytes(ushort value)
        {
            byte[] buffer = new byte[2];

            buffer[0] = (byte)value;
            buffer[1] = (byte)(value >> 8);

            return buffer;
        }

        
        public byte[] GetBytes(uint value)
        {
            byte[] buffer = new byte[4];

            buffer[0] = (byte)value;
            buffer[1] = (byte)(value >> 8);
            buffer[2] = (byte)(value >> 0x10);
            buffer[3] = (byte)(value >> 0x18);

            return buffer;
        }

        
        public byte[] GetBytes(ulong value)
        {
            byte[] buffer = new byte[8];

            buffer[0] = (byte)value;
            buffer[1] = (byte)(value >> 8);
            buffer[2] = (byte)(value >> 0x10);
            buffer[3] = (byte)(value >> 0x18);
            buffer[4] = (byte)(value >> 0x20);
            buffer[5] = (byte)(value >> 0x28);
            buffer[6] = (byte)(value >> 0x30);
            buffer[7] = (byte)(value >> 0x38);

            return buffer;
        }

        public bool ToBoolean(byte[] value, int startIndex)
        {

            return (value[startIndex] == 0) ? false : true;
        }

        public char ToChar(byte[] value, int startIndex)
        {
            return (char)ToInt16(value, startIndex);
        }

        public unsafe float ToSingle(byte[] value, int startIndex)
        {
            int rv = ToInt32(value, startIndex);
            return *((float*)&rv);
        }

        public unsafe double ToDouble(byte[] value, int startIndex)
        {
            long rv = ToInt64(value, startIndex);
            return *((double*)&rv);
        }

        public short ToInt16(byte[] value, int startIndex)
        {
            return (short)((value[startIndex] & 0xff) | (value[++startIndex] << 8));
        }

        public int ToInt32(byte[] value, int startIndex)
        {
            return ((value[startIndex] & 0xff) | (value[++startIndex] << 8) | (value[++startIndex] << 0x10) | (value[++startIndex] << 0x18));
        }

        public long ToInt64(byte[] value, int startIndex)
        {
            uint lo = (uint)((value[startIndex] & 0xff) | (value[++startIndex] << 8) | (value[++startIndex] << 0x10) | (value[++startIndex] << 0x18));
            uint hi = (uint)((value[++startIndex] & 0xff) | (value[++startIndex] << 8) | (value[++startIndex] << 0x10) | (value[++startIndex] << 0x18));

            return (long)((((ulong)hi) << 0x20) | lo);
        }

        
        public ushort ToUInt16(byte[] value, int startIndex)
        {
            return (ushort)((value[startIndex] & 0xff) | (value[++startIndex] << 8));
        }

        
        public uint ToUInt32(byte[] value, int startIndex)
        {
            return (uint)((value[startIndex] & 0xff) | (value[++startIndex] << 8) | (value[++startIndex] << 0x10) | (value[++startIndex] << 0x18));
        }

        
        public ulong ToUInt64(byte[] value, int startIndex)
        {
            uint lo = (uint)((value[startIndex] & 0xff) | (value[++startIndex] << 8) | (value[++startIndex] << 0x10) | (value[++startIndex] << 0x18));
            uint hi = (uint)((value[++startIndex] & 0xff) | (value[++startIndex] << 8) | (value[++startIndex] << 0x10) | (value[++startIndex] << 0x18));

            return ((((ulong)hi) << 0x20) | lo);
        }
    }
    #endregion
}
