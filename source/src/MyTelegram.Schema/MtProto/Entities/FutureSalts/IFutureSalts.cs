﻿// ReSharper disable All

namespace MyTelegram.Schema;

public interface IFutureSalts : IObject
{
    long ReqMsgId { get; set; }
    int Now { get; set; }
    TVector<Schema.IFutureSalt> Salts { get; set; }
}
