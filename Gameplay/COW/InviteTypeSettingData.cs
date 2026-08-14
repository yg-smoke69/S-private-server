using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000160")]
internal class InviteTypeSettingData : CSVBaseData
{
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0xC")]
	public uint GameMode;

	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x10")]
	public uint[] MatchMode;

	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x14")]
	public uint[] InviteType;

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x1EE1C90", Offset = "0x1EE1C90", VA = "0x1EE1C90")]
	public InviteTypeSettingData()
	{
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0x1EE1D14", Offset = "0x1EE1D14", VA = "0x1EE1D14", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0x1EE1EB8", Offset = "0x1EE1EB8", VA = "0x1EE1EB8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
