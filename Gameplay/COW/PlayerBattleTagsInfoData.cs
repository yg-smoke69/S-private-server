using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001FE")]
public class PlayerBattleTagsInfoData : CSVBaseData
{
	[Token(Token = "0x4000BEC")]
	[FieldOffset(Offset = "0x8")]
	public uint BattleTagID;

	[Token(Token = "0x4000BED")]
	[FieldOffset(Offset = "0xC")]
	public uint TagPriority;

	[Token(Token = "0x4000BEE")]
	[FieldOffset(Offset = "0x10")]
	public string TagNameKey;

	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x14")]
	public string TagDescriptionKey;

	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x1C07D48", Offset = "0x1C07D48", VA = "0x1C07D48")]
	public PlayerBattleTagsInfoData()
	{
	}

	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x1C07DCC", Offset = "0x1C07DCC", VA = "0x1C07DCC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x1C07E30", Offset = "0x1C07E30", VA = "0x1C07E30", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
