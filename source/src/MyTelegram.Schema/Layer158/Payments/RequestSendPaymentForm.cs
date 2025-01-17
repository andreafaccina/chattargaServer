﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;

///<summary>
///See <a href="https://core.telegram.org/method/payments.sendPaymentForm" />
///</summary>
[TlObject(0x2d03522f)]
public sealed class RequestSendPaymentForm : IRequest<MyTelegram.Schema.Payments.IPaymentResult>
{
    public uint ConstructorId => 0x2d03522f;
    public BitArray Flags { get; set; } = new BitArray(32);
    public long FormId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputInvoice" />
    ///</summary>
    public MyTelegram.Schema.IInputInvoice Invoice { get; set; }
    public string? RequestedInfoId { get; set; }
    public string? ShippingOptionId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPaymentCredentials" />
    ///</summary>
    public MyTelegram.Schema.IInputPaymentCredentials Credentials { get; set; }
    public long? TipAmount { get; set; }

    public void ComputeFlag()
    {
        if (RequestedInfoId != null) { Flags[0] = true; }
        if (ShippingOptionId != null) { Flags[1] = true; }
        if (TipAmount != 0 && TipAmount.HasValue) { Flags[2] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(FormId);
        Invoice.Serialize(bw);
        if (Flags[0]) { bw.Serialize(RequestedInfoId); }
        if (Flags[1]) { bw.Serialize(ShippingOptionId); }
        Credentials.Serialize(bw);
        if (Flags[2]) { bw.Write(TipAmount.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        FormId = br.ReadInt64();
        Invoice = br.Deserialize<MyTelegram.Schema.IInputInvoice>();
        if (Flags[0]) { RequestedInfoId = br.Deserialize<string>(); }
        if (Flags[1]) { ShippingOptionId = br.Deserialize<string>(); }
        Credentials = br.Deserialize<MyTelegram.Schema.IInputPaymentCredentials>();
        if (Flags[2]) { TipAmount = br.ReadInt64(); }
    }
}
