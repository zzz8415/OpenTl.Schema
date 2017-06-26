﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdf77f3bc)]
    public class RequestResetAuthorization : IRequest<bool>
    {
       [SerializationOrder(0)]
       public long Hash {get; set;}

    }
}