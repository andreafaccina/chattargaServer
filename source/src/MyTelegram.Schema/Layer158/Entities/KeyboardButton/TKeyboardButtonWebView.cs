﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/keyboardButtonWebView" />
///</summary>
[TlObject(0x13767230)]
public sealed class TKeyboardButtonWebView : IKeyboardButton
{
    public uint ConstructorId => 0x13767230;
    public string Text { get; set; }
    public string Url { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Text);
        bw.Serialize(Url);
    }

    public void Deserialize(BinaryReader br)
    {
        Text = br.Deserialize<string>();
        Url = br.Deserialize<string>();
    }
}