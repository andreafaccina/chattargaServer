﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Upload;

///<summary>
///See <a href="https://core.telegram.org/method/upload.getFileHashes" />
///</summary>
[TlObject(0x9156982a)]
public sealed class RequestGetFileHashes : IRequest<TVector<MyTelegram.Schema.IFileHash>>
{
    public uint ConstructorId => 0x9156982a;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputFileLocation" />
    ///</summary>
    public MyTelegram.Schema.IInputFileLocation Location { get; set; }
    public long Offset { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Location.Serialize(bw);
        bw.Write(Offset);
    }

    public void Deserialize(BinaryReader br)
    {
        Location = br.Deserialize<MyTelegram.Schema.IInputFileLocation>();
        Offset = br.ReadInt64();
    }
}