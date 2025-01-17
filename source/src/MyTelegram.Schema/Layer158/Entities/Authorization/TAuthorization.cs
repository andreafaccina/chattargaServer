﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/authorization" />
///</summary>
[TlObject(0xad01d61d)]
public sealed class TAuthorization : IAuthorization
{
    public uint ConstructorId => 0xad01d61d;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Current { get; set; }
    public bool OfficialApp { get; set; }
    public bool PasswordPending { get; set; }
    public bool EncryptedRequestsDisabled { get; set; }
    public bool CallRequestsDisabled { get; set; }
    public long Hash { get; set; }
    public string DeviceModel { get; set; }
    public string Platform { get; set; }
    public string SystemVersion { get; set; }
    public int ApiId { get; set; }
    public string AppName { get; set; }
    public string AppVersion { get; set; }
    public int DateCreated { get; set; }
    public int DateActive { get; set; }
    public string Ip { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }

    public void ComputeFlag()
    {
        if (Current) { Flags[0] = true; }
        if (OfficialApp) { Flags[1] = true; }
        if (PasswordPending) { Flags[2] = true; }
        if (EncryptedRequestsDisabled) { Flags[3] = true; }
        if (CallRequestsDisabled) { Flags[4] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Hash);
        bw.Serialize(DeviceModel);
        bw.Serialize(Platform);
        bw.Serialize(SystemVersion);
        bw.Write(ApiId);
        bw.Serialize(AppName);
        bw.Serialize(AppVersion);
        bw.Write(DateCreated);
        bw.Write(DateActive);
        bw.Serialize(Ip);
        bw.Serialize(Country);
        bw.Serialize(Region);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Current = true; }
        if (Flags[1]) { OfficialApp = true; }
        if (Flags[2]) { PasswordPending = true; }
        if (Flags[3]) { EncryptedRequestsDisabled = true; }
        if (Flags[4]) { CallRequestsDisabled = true; }
        Hash = br.ReadInt64();
        DeviceModel = br.Deserialize<string>();
        Platform = br.Deserialize<string>();
        SystemVersion = br.Deserialize<string>();
        ApiId = br.ReadInt32();
        AppName = br.Deserialize<string>();
        AppVersion = br.Deserialize<string>();
        DateCreated = br.ReadInt32();
        DateActive = br.ReadInt32();
        Ip = br.Deserialize<string>();
        Country = br.Deserialize<string>();
        Region = br.Deserialize<string>();
    }
}