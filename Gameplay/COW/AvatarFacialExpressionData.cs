using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000107")]
public class AvatarFacialExpressionData : CSVBaseData
{
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0xC")]
	public uint AvatarID;

	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x10")]
	public int Weight;

	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID Animation;

	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x18")]
	public byte Condition;

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x234CA24", Offset = "0x234CA24", VA = "0x234CA24")]
	public AvatarFacialExpressionData()
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x234CAA8", Offset = "0x234CAA8", VA = "0x234CAA8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x234CB0C", Offset = "0x234CB0C", VA = "0x234CB0C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x234CD60", Offset = "0x234CD60", VA = "0x234CD60")]
	public bool ValidForType(UIModelAvatarBase.EWardrobeType type)
	{
		return default(bool);
	}
}
