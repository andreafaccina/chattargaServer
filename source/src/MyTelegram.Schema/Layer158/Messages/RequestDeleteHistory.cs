﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.deleteHistory" />
///</summary>
[TlObject(0xb08f922a)]
public sealed class RequestDeleteHistory : IRequest<MyTelegram.Schema.Messages.IAffectedHistory>
{
    public uint ConstructorId => 0xb08f922a;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool JustClear { get; set; }
    public bool Revoke { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public int MaxId { get; set; }
    public int? MinDate { get; set; }
    public int? MaxDate { get; set; }

    public void ComputeFlag()
    {
        if (JustClear) { Flags[0] = true; }
        if (Revoke) { Flags[1] = true; }
        if (MinDate != 0 && MinDate.HasValue) { Flags[2] = true; }
        if (MaxDate != 0 && MaxDate.HasValue) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(MaxId);
        if (Flags[2]) { bw.Write(MinDate.Value); }
        if (Flags[3]) { bw.Write(MaxDate.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { JustClear = true; }
        if (Flags[1]) { Revoke = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        MaxId = br.ReadInt32();
        if (Flags[2]) { MinDate = br.ReadInt32(); }
        if (Flags[3]) { MaxDate = br.ReadInt32(); }
    }
}