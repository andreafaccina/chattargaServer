﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.updateProfile" />
///</summary>
[TlObject(0x78515775)]
public sealed class RequestUpdateProfile : IRequest<MyTelegram.Schema.IUser>
{
    public uint ConstructorId => 0x78515775;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? About { get; set; }

    public void ComputeFlag()
    {
        if (FirstName != null) { Flags[0] = true; }
        if (LastName != null) { Flags[1] = true; }
        if (About != null) { Flags[2] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Serialize(FirstName); }
        if (Flags[1]) { bw.Serialize(LastName); }
        if (Flags[2]) { bw.Serialize(About); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { FirstName = br.Deserialize<string>(); }
        if (Flags[1]) { LastName = br.Deserialize<string>(); }
        if (Flags[2]) { About = br.Deserialize<string>(); }
    }
}
