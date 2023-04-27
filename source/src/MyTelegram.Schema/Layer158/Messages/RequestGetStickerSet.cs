﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getStickerSet" />
///</summary>
[TlObject(0xc8a0ec74)]
public sealed class RequestGetStickerSet : IRequest<MyTelegram.Schema.Messages.IStickerSet>
{
    public uint ConstructorId => 0xc8a0ec74;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputStickerSet" />
    ///</summary>
    public MyTelegram.Schema.IInputStickerSet Stickerset { get; set; }
    public int Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Stickerset.Serialize(bw);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Stickerset = br.Deserialize<MyTelegram.Schema.IInputStickerSet>();
        Hash = br.ReadInt32();
    }
}