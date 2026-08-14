using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000276")]
public class WorkshopCreateNewConfigData : CSVBaseData
{
	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000EED")]
	[FieldOffset(Offset = "0xC")]
	public uint Type;

	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x10")]
	public uint MainID;

	[Token(Token = "0x4000EEF")]
	[FieldOffset(Offset = "0x14")]
	public uint Template;

	[Token(Token = "0x4000EF0")]
	[FieldOffset(Offset = "0x18")]
	public bool ShowTutorial;

	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0x19")]
	public bool EnableFullCustom;

	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0x1A")]
	public bool IsHot;

	[Token(Token = "0x4000EF3")]
	[FieldOffset(Offset = "0x1B")]
	public bool IsNew;

	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsDefault;

	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0x20")]
	public string MainKey;

	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x24")]
	public string ModeCDN;

	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x28")]
	public string ModeCDNBg;

	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x2C")]
	public string DescKey;

	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x30")]
	public string TutorialURL;

	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x21BEA80", Offset = "0x21BEA80", VA = "0x21BEA80")]
	public WorkshopCreateNewConfigData()
	{
	}

	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x21BEB04", Offset = "0x21BEB04", VA = "0x21BEB04", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x21BEB68", Offset = "0x21BEB68", VA = "0x21BEB68", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
