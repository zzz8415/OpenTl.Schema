﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1bfbd823)]
	public class TUpdateUserStatus : IUpdate
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public IUserStatus Status {get; set;}

	}
}