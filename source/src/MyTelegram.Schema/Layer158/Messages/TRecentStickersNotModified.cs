﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.recentStickersNotModified" />
///</summary>
[TlObject(0xb17f890)]
public sealed class TRecentStickersNotModified : IRecentStickers
{
    public uint ConstructorId => 0xb17f890;


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