﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageMediaDice" />
///</summary>
[TlObject(0x3f7ee58b)]
public sealed class TMessageMediaDice : IMessageMedia
{
    public uint ConstructorId => 0x3f7ee58b;
    public int Value { get; set; }
    public string Emoticon { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Value);
        bw.Serialize(Emoticon);
    }

    public void Deserialize(BinaryReader br)
    {
        Value = br.ReadInt32();
        Emoticon = br.Deserialize<string>();
    }
}