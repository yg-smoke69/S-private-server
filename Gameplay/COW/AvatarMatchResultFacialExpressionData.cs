using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000108")]
public class AvatarMatchResultFacialExpressionData : CSVBaseData
{
	[Token(Token = "0x40006AF")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0xC")]
	public uint AvatarID;

	[Token(Token = "0x40006B1")]
	[FieldOffset(Offset = "0x10")]
	public int Weight;

	[Token(Token = "0x40006B2")]
	[FieldOffset(Offset = "0x14")]
	public bool IsMVPShow;

	[Token(Token = "0x40006B3")]
	[FieldOffset(Offset = "0x18")]
	public uint Weapon;

	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID Animation;

	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID AnimationExtra;

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x234D5AC", Offset = "0x234D5AC", VA = "0x234D5AC")]
	public AvatarMatchResultFacialExpressionData()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x234D630", Offset = "0x234D630", VA = "0x234D630", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x234D694", Offset = "0x234D694", VA = "0x234D694", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x234D940", Offset = "0x234D940", VA = "0x234D940")]
	public bool ValidForType(bool mvp, uint weapon)
	{
		return default(bool);
	}
}
