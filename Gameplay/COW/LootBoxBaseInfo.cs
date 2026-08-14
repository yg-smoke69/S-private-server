using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA2")]
public class LootBoxBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012284")]
	[FieldOffset(Offset = "0x20")]
	public LootBoxData lootbox_data;

	[Token(Token = "0x6013E95")]
	[Address(RVA = "0x152E5A8", Offset = "0x152E5A8", VA = "0x152E5A8")]
	public LootBoxBaseInfo()
	{
	}

	[Token(Token = "0x6013E96")]
	[Address(RVA = "0x152E5B0", Offset = "0x152E5B0", VA = "0x152E5B0")]
	public LootBoxBaseInfo(uint lootboxId)
	{
	}

	[Token(Token = "0x6013E97")]
	[Address(RVA = "0x152E88C", Offset = "0x152E88C", VA = "0x152E88C")]
	public static implicit operator LootBoxBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013E98")]
	[Address(RVA = "0x152E958", Offset = "0x152E958", VA = "0x152E958")]
	public static implicit operator LootBoxBaseInfo(LootBoxData box)
	{
		return null;
	}

	[Token(Token = "0x6013E99")]
	[Address(RVA = "0x152EA24", Offset = "0x152EA24", VA = "0x152EA24", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013E9A")]
	[Address(RVA = "0x152EB5C", Offset = "0x152EB5C", VA = "0x152EB5C", Slot = "6")]
	public int CompareTo(LootBoxBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013E9B")]
	[Address(RVA = "0x152EBCC", Offset = "0x152EBCC", VA = "0x152EBCC")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
