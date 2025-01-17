﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMediaVenue" />
///</summary>
[TlObject(0xc13d1c11)]
public sealed class TInputMediaVenue : IInputMedia
{
    public uint ConstructorId => 0xc13d1c11;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputGeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IInputGeoPoint GeoPoint { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
    public string Provider { get; set; }
    public string VenueId { get; set; }
    public string VenueType { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        GeoPoint.Serialize(bw);
        bw.Serialize(Title);
        bw.Serialize(Address);
        bw.Serialize(Provider);
        bw.Serialize(VenueId);
        bw.Serialize(VenueType);
    }

    public void Deserialize(BinaryReader br)
    {
        GeoPoint = br.Deserialize<MyTelegram.Schema.IInputGeoPoint>();
        Title = br.Deserialize<string>();
        Address = br.Deserialize<string>();
        Provider = br.Deserialize<string>();
        VenueId = br.Deserialize<string>();
        VenueType = br.Deserialize<string>();
    }
}