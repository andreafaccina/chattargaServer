﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
///See <a href="https://core.telegram.org/method/contacts.getBlocked" />
///</summary>
[TlObject(0xf57c350f)]
public sealed class RequestGetBlocked : IRequest<MyTelegram.Schema.Contacts.IBlocked>
{
    public uint ConstructorId => 0xf57c350f;
    public int Offset { get; set; }
    public int Limit { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Offset);
        bw.Write(Limit);
    }

    public void Deserialize(BinaryReader br)
    {
        Offset = br.ReadInt32();
        Limit = br.ReadInt32();
    }
}
