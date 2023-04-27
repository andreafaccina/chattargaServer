﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/dataJSON" />
///</summary>
[TlObject(0x7d748d04)]
public sealed class TDataJSON : IDataJSON
{
    public uint ConstructorId => 0x7d748d04;
    public string Data { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Data);
    }

    public void Deserialize(BinaryReader br)
    {
        Data = br.Deserialize<string>();
    }
}