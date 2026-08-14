using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000238")]
public class SoundTipsData : CSVBaseData
{
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID IconResourceID;

	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x10")]
	public float DangerRange;

	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x14")]
	public float WarningRange;

	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x18")]
	public float HintRange;

	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x1C")]
	public float MaxRange;

	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x20")]
	public float Time;

	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x24")]
	public bool IsNeedShow;

	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x20F3578", Offset = "0x20F3578", VA = "0x20F3578")]
	public SoundTipsData()
	{
	}

	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x20F35FC", Offset = "0x20F35FC", VA = "0x20F35FC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x20F3660", Offset = "0x20F3660", VA = "0x20F3660", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
