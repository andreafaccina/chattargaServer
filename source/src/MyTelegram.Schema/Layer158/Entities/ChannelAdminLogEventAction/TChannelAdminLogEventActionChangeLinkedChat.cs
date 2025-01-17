﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelAdminLogEventActionChangeLinkedChat" />
///</summary>
[TlObject(0x50c7ac8)]
public sealed class TChannelAdminLogEventActionChangeLinkedChat : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x50c7ac8;
    public long PrevValue { get; set; }
    public long NewValue { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(PrevValue);
        bw.Write(NewValue);
    }

    public void Deserialize(BinaryReader br)
    {
        PrevValue = br.ReadInt64();
        NewValue = br.ReadInt64();
    }
}