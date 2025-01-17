﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;


///<summary>
///See <a href="https://core.telegram.org/constructor/payments.paymentResult" />
///</summary>
[TlObject(0x4e5f810d)]
public sealed class TPaymentResult : IPaymentResult
{
    public uint ConstructorId => 0x4e5f810d;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Updates" />
    ///</summary>
    public MyTelegram.Schema.IUpdates Updates { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Updates.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Updates = br.Deserialize<MyTelegram.Schema.IUpdates>();
    }
}