using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000ED")]
public class CollectionPrivilegeTagData : CSVBaseData
{
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID PrivilegeIcon;

	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x10")]
	public string PrivilegeDesc;

	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x14")]
	public string PrivilegeTitle;

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x1736C04", Offset = "0x1736C04", VA = "0x1736C04")]
	public CollectionPrivilegeTagData()
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x1736C88", Offset = "0x1736C88", VA = "0x1736C88", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x1736CEC", Offset = "0x1736CEC", VA = "0x1736CEC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
