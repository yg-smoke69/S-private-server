using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200026E")]
public class WereWolvesRoomDefaultParams : CSVBaseData
{
	[Token(Token = "0x4000ECA")]
	[FieldOffset(Offset = "0x8")]
	public uint PlayerCount;

	[Token(Token = "0x4000ECB")]
	[FieldOffset(Offset = "0xC")]
	public uint WolfCount;

	[Token(Token = "0x4000ECC")]
	[FieldOffset(Offset = "0x10")]
	public uint GameTime;

	[Token(Token = "0x4000ECD")]
	[FieldOffset(Offset = "0x14")]
	public uint HumanTaskCount;

	[Token(Token = "0x4000ECE")]
	[FieldOffset(Offset = "0x18")]
	public uint WolfKillCD;

	[Token(Token = "0x4000ECF")]
	[FieldOffset(Offset = "0x1C")]
	public uint WolfTaskCD;

	[Token(Token = "0x4000ED0")]
	[FieldOffset(Offset = "0x20")]
	public uint WolfTaskDuration;

	[Token(Token = "0x4000ED1")]
	[FieldOffset(Offset = "0x24")]
	public uint VoteCenterCD;

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x21B9A14", Offset = "0x21B9A14", VA = "0x21B9A14")]
	public WereWolvesRoomDefaultParams()
	{
	}

	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x21B9A98", Offset = "0x21B9A98", VA = "0x21B9A98", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x21B9AFC", Offset = "0x21B9AFC", VA = "0x21B9AFC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
