using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025AA")]
public class CountDownStyleConfig
{
	[Token(Token = "0x400E8E7")]
	[FieldOffset(Offset = "0x8")]
	public UICountDownController.AlignmentType alignmentType;

	[Token(Token = "0x400E8E8")]
	[FieldOffset(Offset = "0xC")]
	public UICountDownController.EIconType iconType;

	[Token(Token = "0x400E8E9")]
	[FieldOffset(Offset = "0x10")]
	public Effect labelStyle;

	[Token(Token = "0x400E8EA")]
	[FieldOffset(Offset = "0x14")]
	public bool applyGradient;

	[Token(Token = "0x400E8EB")]
	[FieldOffset(Offset = "0x18")]
	public uint gradientTop;

	[Token(Token = "0x400E8EC")]
	[FieldOffset(Offset = "0x1C")]
	public uint gradientBottom;

	[Token(Token = "0x600DC71")]
	[Address(RVA = "0x1C80614", Offset = "0x1C80614", VA = "0x1C80614")]
	public CountDownStyleConfig()
	{
	}
}
