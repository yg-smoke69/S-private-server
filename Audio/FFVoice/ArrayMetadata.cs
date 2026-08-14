using System;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B4A")]
internal struct ArrayMetadata
{
	[Token(Token = "0x4019400")]
	[FieldOffset(Offset = "0x0")]
	private Type element_type;

	[Token(Token = "0x4019401")]
	[FieldOffset(Offset = "0x4")]
	private bool is_array;

	[Token(Token = "0x4019402")]
	[FieldOffset(Offset = "0x5")]
	private bool is_list;

	[Token(Token = "0x170017FC")]
	public Type ElementType
	{
		[Token(Token = "0x6017942")]
		[Address(RVA = "0x93E094", Offset = "0x93E094", VA = "0x93E094")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017943")]
		[Address(RVA = "0x93E09C", Offset = "0x93E09C", VA = "0x93E09C")]
		set
		{
		}
	}

	[Token(Token = "0x170017FD")]
	public bool IsArray
	{
		[Token(Token = "0x6017944")]
		[Address(RVA = "0x93E0A4", Offset = "0x93E0A4", VA = "0x93E0A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017945")]
		[Address(RVA = "0x93E0AC", Offset = "0x93E0AC", VA = "0x93E0AC")]
		set
		{
		}
	}

	[Token(Token = "0x170017FE")]
	public bool IsList
	{
		[Token(Token = "0x6017946")]
		[Address(RVA = "0x93E0B4", Offset = "0x93E0B4", VA = "0x93E0B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017947")]
		[Address(RVA = "0x93E0BC", Offset = "0x93E0BC", VA = "0x93E0BC")]
		set
		{
		}
	}
}
