using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200026C")]
public class WereWolvesQuickChatData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0xC")]
	public string ChatVis;

	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x10")]
	public string ChatFormat;

	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0x14")]
	public bool HasTarget;

	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x21B8EC8", Offset = "0x21B8EC8", VA = "0x21B8EC8")]
	public WereWolvesQuickChatData()
	{
	}

	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x21B8F4C", Offset = "0x21B8F4C", VA = "0x21B8F4C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x21B8FB0", Offset = "0x21B8FB0", VA = "0x21B8FB0", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x21B9008", Offset = "0x21B9008", VA = "0x21B9008", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x21B91A0", Offset = "0x21B91A0", VA = "0x21B91A0")]
	public string GetChatString(IHAAMHPPLMG playerId)
	{
		return null;
	}
}
