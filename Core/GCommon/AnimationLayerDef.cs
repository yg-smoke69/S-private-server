using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20003CD")]
public class AnimationLayerDef
{
	[Token(Token = "0x400389B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int BASE_LAYER;

	[Token(Token = "0x400389C")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int UPPER_BODY_LAYER;

	[Token(Token = "0x400389D")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int UPPER_BODY_ADDITIVE_LAYER;

	[Token(Token = "0x400389E")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int LAYER_NB;

	[Token(Token = "0x400389F")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerNames;

	[Token(Token = "0x6001101")]
	[Address(RVA = "0x26B5714", Offset = "0x26B5714", VA = "0x26B5714")]
	public AnimationLayerDef()
	{
	}
}
