﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockOrderedList" />
///</summary>
[TlObject(0x9a8ae1e1)]
public sealed class TPageBlockOrderedList : IPageBlock
{
    public uint ConstructorId => 0x9a8ae1e1;
    public TVector<MyTelegram.Schema.IPageListOrderedItem> Items { get; set; }

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
        Items = br.Deserialize<TVector<MyTelegram.Schema.IPageListOrderedItem>>();
    }
}