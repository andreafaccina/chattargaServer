﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;


///<summary>
///See <a href="https://core.telegram.org/constructor/phone.exportedGroupCallInvite" />
///</summary>
[TlObject(0x204bd158)]
public sealed class TExportedGroupCallInvite : IExportedGroupCallInvite
{
    public uint ConstructorId => 0x204bd158;
    public string Link { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Link);
    }

    public void Deserialize(BinaryReader br)
    {
        Link = br.Deserialize<string>();
    }
}