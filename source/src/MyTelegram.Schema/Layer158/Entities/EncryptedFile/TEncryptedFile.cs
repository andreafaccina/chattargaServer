﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/encryptedFile" />
///</summary>
[TlObject(0xa8008cd8)]
public sealed class TEncryptedFile : IEncryptedFile
{
    public uint ConstructorId => 0xa8008cd8;
    public long Id { get; set; }
    public long AccessHash { get; set; }
    public long Size { get; set; }
    public int DcId { get; set; }
    public int KeyFingerprint { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Id);
        bw.Write(AccessHash);
        bw.Write(Size);
        bw.Write(DcId);
        bw.Write(KeyFingerprint);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.ReadInt64();
        AccessHash = br.ReadInt64();
        Size = br.ReadInt64();
        DcId = br.ReadInt32();
        KeyFingerprint = br.ReadInt32();
    }
}