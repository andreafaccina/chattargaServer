﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;


///<summary>
///See <a href="https://core.telegram.org/constructor/payments.paymentReceipt" />
///</summary>
[TlObject(0x70c4fe03)]
public sealed class TPaymentReceipt : IPaymentReceipt
{
    public uint ConstructorId => 0x70c4fe03;
    public BitArray Flags { get; set; } = new BitArray(32);
    public int Date { get; set; }
    public long BotId { get; set; }
    public long ProviderId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/WebDocument" />
    ///</summary>
    public MyTelegram.Schema.IWebDocument? Photo { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Invoice" />
    ///</summary>
    public MyTelegram.Schema.IInvoice Invoice { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PaymentRequestedInfo" />
    ///</summary>
    public MyTelegram.Schema.IPaymentRequestedInfo? Info { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ShippingOption" />
    ///</summary>
    public MyTelegram.Schema.IShippingOption? Shipping { get; set; }
    public long? TipAmount { get; set; }
    public string Currency { get; set; }
    public long TotalAmount { get; set; }
    public string CredentialsTitle { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {
        if (Photo != null) { Flags[2] = true; }
        if (Info != null) { Flags[0] = true; }
        if (Shipping != null) { Flags[1] = true; }
        if (TipAmount != 0 && TipAmount.HasValue) { Flags[3] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Date);
        bw.Write(BotId);
        bw.Write(ProviderId);
        bw.Serialize(Title);
        bw.Serialize(Description);
        if (Flags[2]) { Photo.Serialize(bw); }
        Invoice.Serialize(bw);
        if (Flags[0]) { Info.Serialize(bw); }
        if (Flags[1]) { Shipping.Serialize(bw); }
        if (Flags[3]) { bw.Write(TipAmount.Value); }
        bw.Serialize(Currency);
        bw.Write(TotalAmount);
        bw.Serialize(CredentialsTitle);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Date = br.ReadInt32();
        BotId = br.ReadInt64();
        ProviderId = br.ReadInt64();
        Title = br.Deserialize<string>();
        Description = br.Deserialize<string>();
        if (Flags[2]) { Photo = br.Deserialize<MyTelegram.Schema.IWebDocument>(); }
        Invoice = br.Deserialize<MyTelegram.Schema.IInvoice>();
        if (Flags[0]) { Info = br.Deserialize<MyTelegram.Schema.IPaymentRequestedInfo>(); }
        if (Flags[1]) { Shipping = br.Deserialize<MyTelegram.Schema.IShippingOption>(); }
        if (Flags[3]) { TipAmount = br.ReadInt64(); }
        Currency = br.Deserialize<string>();
        TotalAmount = br.ReadInt64();
        CredentialsTitle = br.Deserialize<string>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}