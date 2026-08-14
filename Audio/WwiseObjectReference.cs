using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003DF0")]
public abstract class WwiseObjectReference
{
	[Token(Token = "0x401A458")]
	[FieldOffset(Offset = "0x8")]
	public string objectName;

	[Token(Token = "0x401A459")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x401A45A")]
	[FieldOffset(Offset = "0x10")]
	public string guid;

	[Token(Token = "0x17001B47")]
	public Guid Guid
	{
		[Token(Token = "0x6019344")]
		[Address(RVA = "0x336FE58", Offset = "0x336FE58", VA = "0x336FE58")]
		get
		{
			return default(Guid);
		}
	}

	[Token(Token = "0x17001B48")]
	public string ObjectName
	{
		[Token(Token = "0x6019345")]
		[Address(RVA = "0x336FE50", Offset = "0x336FE50", VA = "0x336FE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B49")]
	public virtual string DisplayName
	{
		[Token(Token = "0x6019346")]
		[Address(RVA = "0x336FF68", Offset = "0x336FF68", VA = "0x336FF68", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B4A")]
	public uint Id
	{
		[Token(Token = "0x6019347")]
		[Address(RVA = "0x336FF70", Offset = "0x336FF70", VA = "0x336FF70")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001B4B")]
	public abstract WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x6019348")]
		get;
	}

	[Token(Token = "0x6019343")]
	[Address(RVA = "0x336D5A4", Offset = "0x336D5A4", VA = "0x336D5A4")]
	protected WwiseObjectReference()
	{
	}

	[Token(Token = "0x6019349")]
	[Address(RVA = "0x336FE44", Offset = "0x336FE44", VA = "0x336FE44")]
	public static implicit operator bool(WwiseObjectReference object_ref)
	{
		return default(bool);
	}

	[Token(Token = "0x601934A")]
	[Address(RVA = "0x336FF78", Offset = "0x336FF78", VA = "0x336FF78")]
	public static implicit operator WwiseObjectReference(Object unity_object)
	{
		return null;
	}

	[Token(Token = "0x601934B")]
	[Address(RVA = "0x3370108", Offset = "0x3370108", VA = "0x3370108")]
	public static implicit operator Object(WwiseObjectReference object_ref)
	{
		return null;
	}
}
