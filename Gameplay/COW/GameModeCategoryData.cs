using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200014A")]
public class GameModeCategoryData : CSVBaseData
{
	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x8")]
	public EGameModeCategory m_Category;

	[Token(Token = "0x400085C")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> m_GameModes;

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x1DD5764", Offset = "0x1DD5764", VA = "0x1DD5764")]
	public GameModeCategoryData()
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x1DD57E8", Offset = "0x1DD57E8", VA = "0x1DD57E8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x1DD58E8", Offset = "0x1DD58E8", VA = "0x1DD58E8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x1DD5AE0", Offset = "0x1DD5AE0", VA = "0x1DD5AE0")]
	public bool ContainInCategory(uint gamemodeid)
	{
		return default(bool);
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x1DD5C30", Offset = "0x1DD5C30", VA = "0x1DD5C30")]
	public static ResourceID GetLadderIconByGameMode(uint gamemodeid, uint rank)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x1DD5EA4", Offset = "0x1DD5EA4", VA = "0x1DD5EA4")]
	public static EGameModeCategory GetGameModeCategory(uint gamemodeid)
	{
		return default(EGameModeCategory);
	}
}
