﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
///See <a href="https://core.telegram.org/method/channels.getForumTopics" />
///</summary>
[TlObject(0xde560d1)]
public sealed class RequestGetForumTopics : IRequest<MyTelegram.Schema.Messages.IForumTopics>
{
    public uint ConstructorId => 0xde560d1;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }
    public string? Q { get; set; }
    public int OffsetDate { get; set; }
    public int OffsetId { get; set; }
    public int OffsetTopic { get; set; }
    public int Limit { get; set; }

    public void ComputeFlag()
    {
        if (Q != null) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Channel.Serialize(bw);
        if (Flags[0]) { bw.Serialize(Q); }
        bw.Write(OffsetDate);
        bw.Write(OffsetId);
        bw.Write(OffsetTopic);
        bw.Write(Limit);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Channel = br.Deserialize<MyTelegram.Schema.IInputChannel>();
        if (Flags[0]) { Q = br.Deserialize<string>(); }
        OffsetDate = br.ReadInt32();
        OffsetId = br.ReadInt32();
        OffsetTopic = br.ReadInt32();
        Limit = br.ReadInt32();
    }
}
