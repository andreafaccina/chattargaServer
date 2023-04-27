﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelAdminLogEventActionChangePhoto" />
///</summary>
[TlObject(0x434bd2af)]
public sealed class TChannelAdminLogEventActionChangePhoto : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x434bd2af;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto PrevPhoto { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Photo" />
    ///</summary>
    public MyTelegram.Schema.IPhoto NewPhoto { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        PrevPhoto.Serialize(bw);
        NewPhoto.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        PrevPhoto = br.Deserialize<MyTelegram.Schema.IPhoto>();
        NewPhoto = br.Deserialize<MyTelegram.Schema.IPhoto>();
    }
}