using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000216")]
public class RelationTypeInfoData : CSVBaseData
{
	[Token(Token = "0x4000C5B")]
	[FieldOffset(Offset = "0x8")]
	public uint RelationType;

	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0xC")]
	public string RelationName;

	[Token(Token = "0x4000C5D")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID RelationBrokenBadgeIcon;

	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x14")]
	public string RelationBgUrl;

	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x18")]
	public string RelationLetterUrl;

	[Token(Token = "0x4000C60")]
	[FieldOffset(Offset = "0x1C")]
	public uint RelationFriendMax;

	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x20")]
	public uint RelationItem;

	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x24")]
	public uint RejectCountDown;

	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x28")]
	public uint RelationBreakUpCD;

	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x2C")]
	public uint RelationBreakUpCountDown;

	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x1972EE0", Offset = "0x1972EE0", VA = "0x1972EE0")]
	public RelationTypeInfoData()
	{
	}

	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x1972F64", Offset = "0x1972F64", VA = "0x1972F64", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x1972FC8", Offset = "0x1972FC8", VA = "0x1972FC8")]
	public void SetServerData(RelationTypeInfoDesc res)
	{
	}

	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x19730B4", Offset = "0x19730B4", VA = "0x19730B4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
