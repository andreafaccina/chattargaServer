﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageExtendedMediaPreview" />
///</summary>
[TlObject(0xad628cc8)]
public sealed class TMessageExtendedMediaPreview : IMessageExtendedMedia
{
    public uint ConstructorId => 0xad628cc8;
    public BitArray Flags { get; set; } = new BitArray(32);
    public int? W { get; set; }
    public int? H { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PhotoSize" />
    ///</summary>
    public MyTelegram.Schema.IPhotoSize? Thumb { get; set; }
    public int? VideoDuration { get; set; }

    public void ComputeFlag()
    {
        if (W != 0 && W.HasValue) { Flags[0] = true; }
        if (H != 0 && H.HasValue) { Flags[0] = true; }
        if (Thumb != null) { Flags[1] = true; }
        if (VideoDuration != 0 && VideoDuration.HasValue) { Flags[2] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Write(W.Value); }
        if (Flags[0]) { bw.Write(H.Value); }
        if (Flags[1]) { Thumb.Serialize(bw); }
        if (Flags[2]) { bw.Write(VideoDuration.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { W = br.ReadInt32(); }
        if (Flags[0]) { H = br.ReadInt32(); }
        if (Flags[1]) { Thumb = br.Deserialize<MyTelegram.Schema.IPhotoSize>(); }
        if (Flags[2]) { VideoDuration = br.ReadInt32(); }
    }
}