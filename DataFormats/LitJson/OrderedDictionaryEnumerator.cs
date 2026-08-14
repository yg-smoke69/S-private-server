using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B76")]
internal class OrderedDictionaryEnumerator : _Attribute, IConvertible
{
	[Token(Token = "0x4019563")]
	[FieldOffset(Offset = "0x8")]
	private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

	[Token(Token = "0x1700184A")]
	public object Current
	{
		[Token(Token = "0x6017B23")]
		[Address(RVA = "0x1C621E8", Offset = "0x1C621E8", VA = "0x1C621E8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700184B")]
	public DictionaryEntry Entry
	{
		[Token(Token = "0x6017B24")]
		[Address(RVA = "0x1C6226C", Offset = "0x1C6226C", VA = "0x1C6226C", Slot = "4")]
		get
		{
			return default(DictionaryEntry);
		}
	}

	[Token(Token = "0x1700184C")]
	public object Key
	{
		[Token(Token = "0x6017B25")]
		[Address(RVA = "0x1C623B8", Offset = "0x1C623B8", VA = "0x1C623B8", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700184D")]
	public object Value
	{
		[Token(Token = "0x6017B26")]
		[Address(RVA = "0x1C624C4", Offset = "0x1C624C4", VA = "0x1C624C4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017B22")]
	[Address(RVA = "0x1C621C8", Offset = "0x1C621C8", VA = "0x1C621C8")]
	public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
	{
	}

	[Token(Token = "0x6017B27")]
	[Address(RVA = "0x1C625D0", Offset = "0x1C625D0", VA = "0x1C625D0", Slot = "8")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x6017B28")]
	[Address(RVA = "0x1C626A8", Offset = "0x1C626A8", VA = "0x1C626A8", Slot = "9")]
	public void Reset()
	{
	}
}
