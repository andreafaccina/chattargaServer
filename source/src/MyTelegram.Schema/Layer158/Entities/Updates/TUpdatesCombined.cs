﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updatesCombined" />
///</summary>
[TlObject(0x725b04c3)]
public sealed class TUpdatesCombined : IUpdates
{
    public uint ConstructorId => 0x725b04c3;
    public TVector<MyTelegram.Schema.IUpdate> Updates { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }
    public int Date { get; set; }
    public int SeqStart { get; set; }
    public int Seq { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Updates.Serialize(bw);
        Users.Serialize(bw);
        Chats.Serialize(bw);
        bw.Write(Date);
        bw.Write(SeqStart);
        bw.Write(Seq);
    }

    public void Deserialize(BinaryReader br)
    {
        Updates = br.Deserialize<TVector<MyTelegram.Schema.IUpdate>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
        Chats = br.Deserialize<TVector<MyTelegram.Schema.IChat>>();
        Date = br.ReadInt32();
        SeqStart = br.ReadInt32();
        Seq = br.ReadInt32();
    }
}