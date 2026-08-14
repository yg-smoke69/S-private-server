using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000B5")]
public class ClothesSpecialData : CSVBaseData, _Attribute
{
	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0xC")]
	public uint avatarID;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x10")]
	public uint itemID;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x14")]
	public string recipeStrInLobby;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x18")]
	public string recipeStrInGame;

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x172E950", Offset = "0x172E950", VA = "0x172E950")]
	public ClothesSpecialData()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x172E9D4", Offset = "0x172E9D4", VA = "0x172E9D4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x172EA2C", Offset = "0x172EA2C", VA = "0x172EA2C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x172EA90", Offset = "0x172EA90", VA = "0x172EA90", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
