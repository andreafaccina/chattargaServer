﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/topPeerCategoryPeers" />
///</summary>
[TlObject(0xfb834291)]
public sealed class TTopPeerCategoryPeers : ITopPeerCategoryPeers
{
    public uint ConstructorId => 0xfb834291;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/TopPeerCategory" />
    ///</summary>
    public MyTelegram.Schema.ITopPeerCategory Category { get; set; }
    public int Count { get; set; }
    public TVector<MyTelegram.Schema.ITopPeer> Peers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Category.Serialize(bw);
        bw.Write(Count);
        Peers.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Category = br.Deserialize<MyTelegram.Schema.ITopPeerCategory>();
        Count = br.ReadInt32();
        Peers = br.Deserialize<TVector<MyTelegram.Schema.ITopPeer>>();
    }
}