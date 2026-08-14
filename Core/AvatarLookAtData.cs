using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000AB")]
public class AvatarLookAtData : CSVBaseData
{
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x8")]
	public uint AvatarID;

	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0xC")]
	public uint[] UIType;

	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x10")]
	public uint[] EyeUIType;

	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x14")]
	public float EyeAngleMax;

	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x18")]
	public float EyeAngleMin;

	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x1C")]
	public float EyeAngleInMax;

	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x20")]
	public float EyeAngleInMin;

	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x24")]
	public float EyeTurnSpeed;

	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x28")]
	public float EyeInLerpSpeed;

	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x2C")]
	public float EyeNewFrameAngleWeight;

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x2ECF704", Offset = "0x2ECF704", VA = "0x2ECF704")]
	public AvatarLookAtData()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x2ECF788", Offset = "0x2ECF788", VA = "0x2ECF788", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x2ECF794", Offset = "0x2ECF794", VA = "0x2ECF794", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
