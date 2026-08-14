using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000170")]
public class LikesMessageData : CSVBaseData
{
	[Token(Token = "0x400094C")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x400094D")]
	[FieldOffset(Offset = "0xC")]
	public uint LikesMessageSwitch;

	[Token(Token = "0x400094E")]
	[FieldOffset(Offset = "0x10")]
	public float ResultLikesDelay;

	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x14")]
	public uint ResultLikesUpperLimit;

	[Token(Token = "0x6000876")]
	[Address(RVA = "0xEC16B8", Offset = "0xEC16B8", VA = "0xEC16B8")]
	public LikesMessageData()
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xEC173C", Offset = "0xEC173C", VA = "0xEC173C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0xEC17A0", Offset = "0xEC17A0", VA = "0xEC17A0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
