﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.cancelPasswordEmail" />
///</summary>
[TlObject(0xc1cbd5b6)]
public sealed class RequestCancelPasswordEmail : IRequest<IBool>
{
    public uint ConstructorId => 0xc1cbd5b6;

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}