﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.chatsSlice" />
///</summary>
[TlObject(0x9cd81144)]
public sealed class TChatsSlice : IChats
{
    public uint ConstructorId => 0x9cd81144;
    public int Count { get; set; }
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Count);
        Chats.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Count = br.ReadInt32();
        Chats = br.Deserialize<TVector<MyTelegram.Schema.IChat>>();
    }
}