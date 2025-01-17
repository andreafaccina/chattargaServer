﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelAdminLogEventActionParticipantMute" />
///</summary>
[TlObject(0xf92424d2)]
public sealed class TChannelAdminLogEventActionParticipantMute : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0xf92424d2;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/GroupCallParticipant" />
    ///</summary>
    public MyTelegram.Schema.IGroupCallParticipant Participant { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Participant.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Participant = br.Deserialize<MyTelegram.Schema.IGroupCallParticipant>();
    }
}