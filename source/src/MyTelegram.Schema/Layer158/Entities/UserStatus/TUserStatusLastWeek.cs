﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/userStatusLastWeek" />
///</summary>
[TlObject(0x7bf09fc)]
public sealed class TUserStatusLastWeek : IUserStatus
{
    public uint ConstructorId => 0x7bf09fc;


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