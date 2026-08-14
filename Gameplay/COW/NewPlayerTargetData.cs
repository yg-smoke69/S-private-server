using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001BC")]
public class NewPlayerTargetData : CSVBaseData
{
	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x8")]
	public uint TargetID;

	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0xC")]
	public uint SlotID;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x10")]
	public string TargetDescrip;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x14")]
	public uint MinLevel;

	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x18")]
	public uint MaxLevel;

	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x1C")]
	public string TargetHint;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x20")]
	public uint AvatarID;

	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x24")]
	public bool HaveGoto;

	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x28")]
	public uint GotoGuideID;

	[Token(Token = "0x6000962")]
	[Address(RVA = "0x28B40F0", Offset = "0x28B40F0", VA = "0x28B40F0")]
	public NewPlayerTargetData()
	{
	}

	[Token(Token = "0x6000963")]
	[Address(RVA = "0x28B4174", Offset = "0x28B4174", VA = "0x28B4174", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000964")]
	[Address(RVA = "0x28B41D8", Offset = "0x28B41D8", VA = "0x28B41D8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
