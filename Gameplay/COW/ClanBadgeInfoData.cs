using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000CE")]
public class ClanBadgeInfoData : CSVBaseData
{
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x8")]
	public uint IsDefault;

	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0xC")]
	public uint UnLockCdt;

	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x10")]
	public uint BadgeID;

	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x14")]
	public string BadgeName;

	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0x18")]
	public string BadgeGetWay;

	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x1C")]
	public string SpriteName;

	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0x20")]
	public string IsShow;

	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0x24")]
	public uint UnlockCdtValue;

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x1726AE4", Offset = "0x1726AE4", VA = "0x1726AE4")]
	public ClanBadgeInfoData()
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x1726B68", Offset = "0x1726B68", VA = "0x1726B68", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x1726BCC", Offset = "0x1726BCC", VA = "0x1726BCC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
