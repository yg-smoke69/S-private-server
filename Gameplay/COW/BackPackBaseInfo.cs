using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA3")]
public class BackPackBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012285")]
	[FieldOffset(Offset = "0x20")]
	public BackPackData backpack_data;

	[Token(Token = "0x6013E9C")]
	[Address(RVA = "0x2E4D2B4", Offset = "0x2E4D2B4", VA = "0x2E4D2B4")]
	public BackPackBaseInfo()
	{
	}

	[Token(Token = "0x6013E9D")]
	[Address(RVA = "0x2E4D2BC", Offset = "0x2E4D2BC", VA = "0x2E4D2BC")]
	public BackPackBaseInfo(uint backpackId)
	{
	}

	[Token(Token = "0x6013E9E")]
	[Address(RVA = "0x2E4D590", Offset = "0x2E4D590", VA = "0x2E4D590")]
	public static implicit operator BackPackBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013E9F")]
	[Address(RVA = "0x2E4D65C", Offset = "0x2E4D65C", VA = "0x2E4D65C")]
	public static implicit operator BackPackBaseInfo(BackPackData backpack)
	{
		return null;
	}

	[Token(Token = "0x6013EA0")]
	[Address(RVA = "0x2E4D728", Offset = "0x2E4D728", VA = "0x2E4D728", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013EA1")]
	[Address(RVA = "0x2E4D860", Offset = "0x2E4D860", VA = "0x2E4D860", Slot = "6")]
	public int CompareTo(BackPackBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013EA2")]
	[Address(RVA = "0x2E4D8D0", Offset = "0x2E4D8D0", VA = "0x2E4D8D0")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
