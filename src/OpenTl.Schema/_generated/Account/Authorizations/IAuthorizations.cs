﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IAuthorizations : IObject
    {
       TVector<IAuthorization> Authorizations {get; set;}

    }
}
