﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stickers;

///<summary>
///See <a href="https://core.telegram.org/method/stickers.renameStickerSet" />
///</summary>
[TlObject(0x124b1c00)]
public sealed class RequestRenameStickerSet : IRequest<MyTelegram.Schema.Messages.IStickerSet>
{
    public uint ConstructorId => 0x124b1c00;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputStickerSet" />
    ///</summary>
    public MyTelegram.Schema.IInputStickerSet Stickerset { get; set; }
    public string Title { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Stickerset.Serialize(bw);
        bw.Serialize(Title);
    }

    public void Deserialize(BinaryReader br)
    {
        Stickerset = br.Deserialize<MyTelegram.Schema.IInputStickerSet>();
        Title = br.Deserialize<string>();
    }
}