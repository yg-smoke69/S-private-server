using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000207")]
internal class PrivilegeData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x8")]
	public uint PrivilegeID;

	[Token(Token = "0x4000C08")]
	[FieldOffset(Offset = "0xC")]
	public uint Type;

	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID ResourceID;

	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x196837C", Offset = "0x196837C", VA = "0x196837C")]
	public PrivilegeData()
	{
	}

	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x1968400", Offset = "0x1968400", VA = "0x1968400", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x1968458", Offset = "0x1968458", VA = "0x1968458", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x19684BC", Offset = "0x19684BC", VA = "0x19684BC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
