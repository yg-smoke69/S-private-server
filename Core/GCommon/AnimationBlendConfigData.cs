using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003ECF")]
public class AnimationBlendConfigData : CSVBaseData
{
	[Token(Token = "0x401A85F")]
	[FieldOffset(Offset = "0x8")]
	public long TransitionID;

	[Token(Token = "0x401A860")]
	[FieldOffset(Offset = "0x10")]
	public bool UseFixedDuration;

	[Token(Token = "0x401A861")]
	[FieldOffset(Offset = "0x14")]
	public float TransitionDuration;

	[Token(Token = "0x601990C")]
	[Address(RVA = "0x26B3630", Offset = "0x26B3630", VA = "0x26B3630")]
	public AnimationBlendConfigData()
	{
	}

	[Token(Token = "0x601990D")]
	[Address(RVA = "0x26B36CC", Offset = "0x26B36CC", VA = "0x26B36CC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x601990E")]
	[Address(RVA = "0x26B36D8", Offset = "0x26B36D8", VA = "0x26B36D8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x601990F")]
	[Address(RVA = "0x26B3C00", Offset = "0x26B3C00", VA = "0x26B3C00")]
	public static long MakeTransitionID(AnimationID fadeOutAnim, AnimationID fadeInAnim)
	{
		return default(long);
	}
}
