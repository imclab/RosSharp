//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-07T13:04:50+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
namespace RosSharp.std_msgs
{
    public class Float64 : IMessage
    {
        public Float64()
        {
        }
        public Float64(BinaryReader br)
        {
            Deserialize(br);
        }
        public double data { get; set; }
        public string MessageType
        {
            get { return "std_msgs/Float64"; }
        }
        public string Md5Sum
        {
            get { return "fdb28210bfa9d7c91146260178d9a584"; }
        }
        public string MessageDefinition
        {
            get { return "float64 data"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            bw.Write(data);
        }
        public void Deserialize(BinaryReader br)
        {
            data = br.ReadDouble();
        }
        public int SerializeLength
        {
            get { return 8; }
        }
        public bool Equals(Float64 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.data.Equals(data);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Float64)) return false;
            return Equals((Float64)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ data.GetHashCode();
                return result;
            }
        }
    }
}