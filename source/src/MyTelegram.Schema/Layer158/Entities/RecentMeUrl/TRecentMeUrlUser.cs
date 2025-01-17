﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/recentMeUrlUser" />
///</summary>
[TlObject(0xb92c09e2)]
public sealed class TRecentMeUrlUser : IRecentMeUrl
{
    public uint ConstructorId => 0xb92c09e2;
    public string Url { get; set; }
    public long UserId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Url);
        bw.Write(UserId);
    }

    public void Deserialize(BinaryReader br)
    {
        Url = br.Deserialize<string>();
        UserId = br.ReadInt64();
    }
}