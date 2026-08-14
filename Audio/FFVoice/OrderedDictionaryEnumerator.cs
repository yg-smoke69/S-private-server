using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B47")]
internal class OrderedDictionaryEnumerator : _Attribute, IConvertible
{
	[Token(Token = "0x40193FC")]
	[FieldOffset(Offset = "0x8")]
	private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

	[Token(Token = "0x170017F8")]
	public object Current
	{
		[Token(Token = "0x6017935")]
		[Address(RVA = "0x26AAF84", Offset = "0x26AAF84", VA = "0x26AAF84", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017F9")]
	public DictionaryEntry Entry
	{
		[Token(Token = "0x6017936")]
		[Address(RVA = "0x26AB008", Offset = "0x26AB008", VA = "0x26AB008", Slot = "4")]
		get
		{
			return default(DictionaryEntry);
		}
	}

	[Token(Token = "0x170017FA")]
	public object Key
	{
		[Token(Token = "0x6017937")]
		[Address(RVA = "0x26AB154", Offset = "0x26AB154", VA = "0x26AB154", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017FB")]
	public object Value
	{
		[Token(Token = "0x6017938")]
		[Address(RVA = "0x26AB260", Offset = "0x26AB260", VA = "0x26AB260", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017934")]
	[Address(RVA = "0x26AAF64", Offset = "0x26AAF64", VA = "0x26AAF64")]
	public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
	{
	}

	[Token(Token = "0x6017939")]
	[Address(RVA = "0x26AB36C", Offset = "0x26AB36C", VA = "0x26AB36C", Slot = "8")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x601793A")]
	[Address(RVA = "0x26AB444", Offset = "0x26AB444", VA = "0x26AB444", Slot = "9")]
	public void Reset()
	{
	}
}
