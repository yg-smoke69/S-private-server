using Il2CppDummyDll;
using UnityStandardAssets.ImageEffects;

namespace GCommon;

[Token(Token = "0x2003EA6")]
public class OutlinePostEffect : PostEffectsBase
{
	[Token(Token = "0x401A772")]
	[FieldOffset(Offset = "0x14")]
	public float farClipPlane;

	[Token(Token = "0x401A773")]
	[FieldOffset(Offset = "0x18")]
	public float width;

	[Token(Token = "0x401A774")]
	[FieldOffset(Offset = "0x1C")]
	public float brightness;

	[Token(Token = "0x401A775")]
	[FieldOffset(Offset = "0x20")]
	public float brightnessWidth;

	[Token(Token = "0x401A776")]
	[FieldOffset(Offset = "0x24")]
	public int blurIterations;

	[Token(Token = "0x60197CA")]
	[Address(RVA = "0x29801E8", Offset = "0x29801E8", VA = "0x29801E8")]
	public OutlinePostEffect()
	{
	}

	[Token(Token = "0x60197CB")]
	[Address(RVA = "0x2980218", Offset = "0x2980218", VA = "0x2980218", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}
}
