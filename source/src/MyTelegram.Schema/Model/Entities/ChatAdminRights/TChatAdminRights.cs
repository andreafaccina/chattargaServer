﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/chatAdminRights" />
///</summary>
[TlObject(0x5fb224d5)]
public class TChatAdminRights : IChatAdminRights
{
    public uint ConstructorId => 0x5fb224d5;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool ChangeInfo { get; set; }
    public bool PostMessages { get; set; }
    public bool EditMessages { get; set; }
    public bool DeleteMessages { get; set; }
    public bool BanUsers { get; set; }
    public bool InviteUsers { get; set; }
    public bool PinMessages { get; set; }
    public bool AddAdmins { get; set; }
    public bool Anonymous { get; set; }
    public bool ManageCall { get; set; }
    public bool Other { get; set; }
    public bool ManageTopics { get; set; }

    public void ComputeFlag()
    {
        if (ChangeInfo) { Flags[0] = true; }
        if (PostMessages) { Flags[1] = true; }
        if (EditMessages) { Flags[2] = true; }
        if (DeleteMessages) { Flags[3] = true; }
        if (BanUsers) { Flags[4] = true; }
        if (InviteUsers) { Flags[5] = true; }
        if (PinMessages) { Flags[7] = true; }
        if (AddAdmins) { Flags[9] = true; }
        if (Anonymous) { Flags[10] = true; }
        if (ManageCall) { Flags[11] = true; }
        if (Other) { Flags[12] = true; }
        if (ManageTopics) { Flags[13] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);

    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { ChangeInfo = true; }
        if (Flags[1]) { PostMessages = true; }
        if (Flags[2]) { EditMessages = true; }
        if (Flags[3]) { DeleteMessages = true; }
        if (Flags[4]) { BanUsers = true; }
        if (Flags[5]) { InviteUsers = true; }
        if (Flags[7]) { PinMessages = true; }
        if (Flags[9]) { AddAdmins = true; }
        if (Flags[10]) { Anonymous = true; }
        if (Flags[11]) { ManageCall = true; }
        if (Flags[12]) { Other = true; }
        if (Flags[13]) { ManageTopics = true; }
    }
}