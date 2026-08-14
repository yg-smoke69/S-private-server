using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200019C")]
public class ManualWeaponData : CSVBaseData
{
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x8")]
	public string UnlockIcon;

	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0xC")]
	public string LabelPic1;

	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x10")]
	public string LabelText1;

	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x14")]
	public string NameKey;

	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x18")]
	public string IntroKey;

	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x1C")]
	public string SubTitle;

	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x20")]
	public uint EventID;

	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x24")]
	public uint PageID;

	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x28")]
	public uint LocationID;

	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x2C")]
	public uint SubTitleID;

	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x30")]
	public bool Link;

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x1533718", Offset = "0x1533718", VA = "0x1533718")]
	public ManualWeaponData()
	{
	}

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x153379C", Offset = "0x153379C", VA = "0x153379C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0x1533800", Offset = "0x1533800", VA = "0x1533800", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
