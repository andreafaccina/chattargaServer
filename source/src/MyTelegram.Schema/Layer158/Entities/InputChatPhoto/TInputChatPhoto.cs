﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputChatPhoto" />
///</summary>
[TlObject(0x8953ad37)]
public sealed class TInputChatPhoto : IInputChatPhoto
{
    public uint ConstructorId => 0x8953ad37;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPhoto" />
    ///</summary>
    public MyTelegram.Schema.IInputPhoto Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Id.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.Deserialize<MyTelegram.Schema.IInputPhoto>();
    }
}