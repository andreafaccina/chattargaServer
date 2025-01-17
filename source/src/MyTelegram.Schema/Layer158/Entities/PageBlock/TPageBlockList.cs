﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockList" />
///</summary>
[TlObject(0xe4e88011)]
public sealed class TPageBlockList : IPageBlock
{
    public uint ConstructorId => 0xe4e88011;
    public TVector<MyTelegram.Schema.IPageListItem> Items { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Items.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Items = br.Deserialize<TVector<MyTelegram.Schema.IPageListItem>>();
    }
}