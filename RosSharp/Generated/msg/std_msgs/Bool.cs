//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-06-23T22:05:29+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
using RosSharp.std_msgs;
namespace RosSharp.std_msgs
{
    ///<exclude/>
    public class Bool : IMessage
    {
        ///<exclude/>
        public Bool()
        {
        }
        ///<exclude/>
        public Bool(BinaryReader br)
        {
            Deserialize(br);
        }
        ///<exclude/>
        public bool data { get; set; }
        ///<exclude/>
        public string MessageType
        {
            get { return "std_msgs/Bool"; }
        }
        ///<exclude/>
        public string Md5Sum
        {
            get { return "8b94c1b53db61fb6aed406028ad6332a"; }
        }
        ///<exclude/>
        public string MessageDefinition
        {
            get { return "bool data"; }
        }
        ///<exclude/>
        public bool HasHeader
        {
            get { return false; }
        }
        ///<exclude/>
        public void Serialize(BinaryWriter bw)
        {
            bw.Write(data);
        }
        ///<exclude/>
        public void Deserialize(BinaryReader br)
        {
            data = br.ReadBoolean();
        }
        ///<exclude/>
        public int SerializeLength
        {
            get { return 1; }
        }
        ///<exclude/>
        public bool Equals(Bool other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.data.Equals(data);
        }
        ///<exclude/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Bool)) return false;
            return Equals((Bool)obj);
        }
        ///<exclude/>
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
