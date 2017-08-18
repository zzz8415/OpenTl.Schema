﻿// ReSharper disable All

namespace OpenTl.Schema
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IInputContact : IObject
    {
       long ClientId {get; set;}

       byte[] PhoneAsBinary {get; set;}
       string Phone {get; set;}

       byte[] FirstNameAsBinary {get; set;}
       string FirstName {get; set;}

       byte[] LastNameAsBinary {get; set;}
       string LastName {get; set;}

    }
}
