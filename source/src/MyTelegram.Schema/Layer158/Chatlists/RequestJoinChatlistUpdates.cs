﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Chatlists;

///<summary>
///See <a href="https://core.telegram.org/method/chatlists.joinChatlistUpdates" />
///</summary>
[TlObject(0xe089f8f5)]
public sealed class RequestJoinChatlistUpdates : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xe089f8f5;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChatlist" />
    ///</summary>
    public MyTelegram.Schema.IInputChatlist Chatlist { get; set; }
    public TVector<MyTelegram.Schema.IInputPeer> Peers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Chatlist.Serialize(bw);
        Peers.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Chatlist = br.Deserialize<MyTelegram.Schema.IInputChatlist>();
        Peers = br.Deserialize<TVector<MyTelegram.Schema.IInputPeer>>();
    }
}