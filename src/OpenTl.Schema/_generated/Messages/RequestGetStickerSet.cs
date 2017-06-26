﻿// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2619a90e)]
    public class RequestGetStickerSet : IRequest<Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public IInputStickerSet Stickerset {get; set;}

    }
}