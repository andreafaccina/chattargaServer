﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/restrictionReason" />
///</summary>
[TlObject(0xd072acb4)]
public sealed class TRestrictionReason : IRestrictionReason
{
    public uint ConstructorId => 0xd072acb4;
    public string Platform { get; set; }
    public string Reason { get; set; }
    public string Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Platform);
        bw.Serialize(Reason);
        bw.Serialize(Text);
    }

    public void Deserialize(BinaryReader br)
    {
        Platform = br.Deserialize<string>();
        Reason = br.Deserialize<string>();
        Text = br.Deserialize<string>();
    }
}