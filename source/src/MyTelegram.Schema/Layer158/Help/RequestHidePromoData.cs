﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
///See <a href="https://core.telegram.org/method/help.hidePromoData" />
///</summary>
[TlObject(0x1e251c95)]
public sealed class RequestHidePromoData : IRequest<IBool>
{
    public uint ConstructorId => 0x1e251c95;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
    }
}
