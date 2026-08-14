using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001989")]
public class HyperBookPage : _Attribute
{
	[Token(Token = "0x400A009")]
	[FieldOffset(Offset = "0x8")]
	public uint sort_id;

	[Token(Token = "0x400A00A")]
	[FieldOffset(Offset = "0xC")]
	public bool unlocked;

	[Token(Token = "0x6007FE2")]
	[Address(RVA = "0x30A3730", Offset = "0x30A3730", VA = "0x30A3730")]
	public HyperBookPage()
	{
	}

	[Token(Token = "0x6007FE3")]
	[Address(RVA = "0x30A3738", Offset = "0x30A3738", VA = "0x30A3738")]
	public HyperBookPage Clone()
	{
		return null;
	}

	[Token(Token = "0x6007FE4")]
	[Address(RVA = "0x30A37E0", Offset = "0x30A37E0", VA = "0x30A37E0", Slot = "4")]
	public int CompareTo(object obj)
	{
		return default(int);
	}
}
