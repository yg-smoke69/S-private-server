using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200015E")]
public class InGameTriggerMaskData : CSVBaseData
{
	[Token(Token = "0x40008DE")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40008DF")]
	[FieldOffset(Offset = "0xC")]
	public uint Priority;

	[Token(Token = "0x40008E0")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID IconRes;

	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x14")]
	public uint FollowType;

	[Token(Token = "0x40008E2")]
	[FieldOffset(Offset = "0x18")]
	public uint MarkType;

	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x1C")]
	public int Deviation;

	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x20")]
	public float Duration;

	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x24")]
	public float CoolDown;

	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x28")]
	public uint IsBlinkOn;

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x2C7760C", Offset = "0x2C7760C", VA = "0x2C7760C")]
	public InGameTriggerMaskData()
	{
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x2C77690", Offset = "0x2C77690", VA = "0x2C77690", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0x2C77794", Offset = "0x2C77794", VA = "0x2C77794", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
