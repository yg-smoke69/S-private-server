using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000256")]
public class UGCMoveObjectMoveTemplateData : CSVBaseData
{
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0xC")]
	public LevelMotionPlatform.KHKKPACHHGE MotionType;

	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x10")]
	public float MotionValueX;

	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x14")]
	public float MotionValueY;

	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0x18")]
	public float MotionValueZ;

	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0x1C")]
	public float MotionTime;

	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0x20")]
	public float StayTime;

	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0x24")]
	public bool IsReset;

	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x29F300C", Offset = "0x29F300C", VA = "0x29F300C")]
	public UGCMoveObjectMoveTemplateData()
	{
	}

	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x29F30A0", Offset = "0x29F30A0", VA = "0x29F30A0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x29F3104", Offset = "0x29F3104", VA = "0x29F3104", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
