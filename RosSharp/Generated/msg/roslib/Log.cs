//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-07T13:04:48+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
namespace RosSharp
{
    public class Log : IMessage
    {
        public Log()
        {
            header = new Header();
            name = string.Empty;
            msg = string.Empty;
            file = string.Empty;
            function = string.Empty;
            topics = new List<string>();
        }
        public Log(BinaryReader br)
        {
            Deserialize(br);
        }
        public const byte DEBUG = 1;
        public const byte INFO = 2;
        public const byte WARN = 4;
        public const byte ERROR = 8;
        public const byte FATAL = 16;
        public Header header { get; set; }
        public byte level { get; set; }
        public string name { get; set; }
        public string msg { get; set; }
        public string file { get; set; }
        public string function { get; set; }
        public uint line { get; set; }
        public List<string> topics { get; set; }
        public string MessageType
        {
            get { return "Log"; }
        }
        public string Md5Sum
        {
            get { return "acffd30cd6b6de30f120938c17c593fb"; }
        }
        public string MessageDefinition
        {
            get { return "byte DEBUG=1\nbyte INFO=2\nbyte WARN=4\nbyte ERROR=8\nbyte FATAL=16\nHeader header\nbyte level\nstring name\nstring msg\nstring file\nstring function\nuint32 line\nstring[] topics"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            header.Serialize(bw);
            bw.Write(level);
            bw.WriteUtf8String(name);
            bw.WriteUtf8String(msg);
            bw.WriteUtf8String(file);
            bw.WriteUtf8String(function);
            bw.Write(line);
            bw.Write(topics.Count); for(int i=0; i<topics.Count; i++) { bw.WriteUtf8String(topics[i]);}
        }
        public void Deserialize(BinaryReader br)
        {
            header = new Header();
            level = br.ReadByte();
            name = br.ReadUtf8String();
            msg = br.ReadUtf8String();
            file = br.ReadUtf8String();
            function = br.ReadUtf8String();
            line = br.ReadUInt32();
            topics = new List<string>(br.ReadInt32()); for(int i=0; i<topics.Count; i++) { topics[i] = br.ReadUtf8String();}
        }
        public int SerializeLength
        {
            get { return header.SerializeLength + 1 + 4 + name.Length + 4 + msg.Length + 4 + file.Length + 4 + function.Length + 4 + topics.Sum(x => 4 + x.Length); }
        }
        public bool Equals(Log other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.header.Equals(header) && other.level.Equals(level) && other.name.Equals(name) && other.msg.Equals(msg) && other.file.Equals(file) && other.function.Equals(function) && other.line.Equals(line) && other.topics.Equals(topics);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Log)) return false;
            return Equals((Log)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ header.GetHashCode();
                result = (result * 397) ^ level.GetHashCode();
                result = (result * 397) ^ name.GetHashCode();
                result = (result * 397) ^ msg.GetHashCode();
                result = (result * 397) ^ file.GetHashCode();
                result = (result * 397) ^ function.GetHashCode();
                result = (result * 397) ^ line.GetHashCode();
                result = (result * 397) ^ topics.GetHashCode();
                return result;
            }
        }
    }
}
