﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.updateDialogFiltersOrder" />
///</summary>
[TlObject(0xc563c1e4)]
public sealed class RequestUpdateDialogFiltersOrder : IRequest<IBool>
{
    public uint ConstructorId => 0xc563c1e4;
    public TVector<int> Order { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Order.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Order = br.Deserialize<TVector<int>>();
    }
}