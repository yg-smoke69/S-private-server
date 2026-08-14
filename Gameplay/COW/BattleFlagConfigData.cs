using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000C4")]
public class BattleFlagConfigData : CSVBaseData, _Attribute
{
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0xC")]
	public uint LinkID;

	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID resLobbyModel;

	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID resModel;

	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID EffectRes;

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x2E6754C", Offset = "0x2E6754C", VA = "0x2E6754C")]
	public BattleFlagConfigData()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x2E675D0", Offset = "0x2E675D0", VA = "0x2E675D0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x2E67634", Offset = "0x2E67634", VA = "0x2E67634", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x2E6768C", Offset = "0x2E6768C", VA = "0x2E6768C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
