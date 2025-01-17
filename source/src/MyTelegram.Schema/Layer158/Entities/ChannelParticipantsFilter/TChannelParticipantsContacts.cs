﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelParticipantsContacts" />
///</summary>
[TlObject(0xbb6ae88d)]
public sealed class TChannelParticipantsContacts : IChannelParticipantsFilter
{
    public uint ConstructorId => 0xbb6ae88d;
    public string Q { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Q);
    }

    public void Deserialize(BinaryReader br)
    {
        Q = br.Deserialize<string>();
    }
}