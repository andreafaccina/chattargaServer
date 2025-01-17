﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionTopicEdit" />
///</summary>
[TlObject(0xc0944820)]
public sealed class TMessageActionTopicEdit : IMessageAction
{
    public uint ConstructorId => 0xc0944820;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string? Title { get; set; }
    public long? IconEmojiId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool? Closed { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool? Hidden { get; set; }

    public void ComputeFlag()
    {
        if (Title != null) { Flags[0] = true; }
        if (IconEmojiId != 0 && IconEmojiId.HasValue) { Flags[1] = true; }
        if (Closed !=null) { Flags[2] = true; }
        if (Hidden !=null) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Serialize(Title); }
        if (Flags[1]) { bw.Write(IconEmojiId.Value); }
        if (Flags[2]) { bw.Serialize(Closed.Value); }
        if (Flags[3]) { bw.Serialize(Hidden.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Title = br.Deserialize<string>(); }
        if (Flags[1]) { IconEmojiId = br.ReadInt64(); }
        if (Flags[2]) { Closed = br.Deserialize<bool>(); }
        if (Flags[3]) { Hidden = br.Deserialize<bool>(); }
    }
}