﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/sendMessageUploadDocumentAction" />
///</summary>
[TlObject(0xaa0cd9e4)]
public sealed class TSendMessageUploadDocumentAction : ISendMessageAction
{
    public uint ConstructorId => 0xaa0cd9e4;
    public int Progress { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Progress);
    }

    public void Deserialize(BinaryReader br)
    {
        Progress = br.ReadInt32();
    }
}