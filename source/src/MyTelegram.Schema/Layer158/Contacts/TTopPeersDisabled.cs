﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;


///<summary>
///See <a href="https://core.telegram.org/constructor/contacts.topPeersDisabled" />
///</summary>
[TlObject(0xb52c939d)]
public sealed class TTopPeersDisabled : ITopPeers
{
    public uint ConstructorId => 0xb52c939d;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}