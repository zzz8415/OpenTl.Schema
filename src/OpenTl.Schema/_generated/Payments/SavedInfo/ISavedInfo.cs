﻿// ReSharper disable All

namespace OpenTl.Schema.Payments
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface ISavedInfo : IObject
    {
       BitArray Flags {get; set;}

       bool HasSavedCredentials {get; set;}

       IPaymentRequestedInfo SavedInfo {get; set;}

    }
}
