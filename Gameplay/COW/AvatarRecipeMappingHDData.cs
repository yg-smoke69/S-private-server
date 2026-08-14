using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000AE")]
public class AvatarRecipeMappingHDData : CSVBaseData, _Attribute
{
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0xC")]
	public string recipeStrInLobby;

	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x10")]
	public string recipeStrInGame;

	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x14")]
	public string recipeStrInLobby_F;

	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x18")]
	public string recipeStrInGame_F;

	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID iconRes;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x2358C44", Offset = "0x2358C44", VA = "0x2358C44")]
	public AvatarRecipeMappingHDData()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x2358D10", Offset = "0x2358D10", VA = "0x2358D10", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x2358D74", Offset = "0x2358D74", VA = "0x2358D74", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x2358DCC", Offset = "0x2358DCC", VA = "0x2358DCC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
