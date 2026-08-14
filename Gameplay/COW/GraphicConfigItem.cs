using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000145")]
public class GraphicConfigItem
{
	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x8")]
	public bool fog;

	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0xC")]
	public float lodBias;

	[Token(Token = "0x400083C")]
	[FieldOffset(Offset = "0x10")]
	public int shaderLOD;

	[Token(Token = "0x400083D")]
	[FieldOffset(Offset = "0x14")]
	public int qualitySetting;

	[Token(Token = "0x400083E")]
	[FieldOffset(Offset = "0x18")]
	public bool terrainShadow;

	[Token(Token = "0x400083F")]
	[FieldOffset(Offset = "0x19")]
	public bool hdLocalPlayer;

	[Token(Token = "0x4000840")]
	[FieldOffset(Offset = "0x1A")]
	public bool hdTeammate;

	[Token(Token = "0x4000841")]
	[FieldOffset(Offset = "0x1B")]
	public bool hd3PInWaitingRoom;

	[Token(Token = "0x4000842")]
	[FieldOffset(Offset = "0x1C")]
	public int postEffectMask;

	[Token(Token = "0x4000843")]
	[FieldOffset(Offset = "0x20")]
	public int appendixStreamingRange;

	[Token(Token = "0x4000844")]
	[FieldOffset(Offset = "0x24")]
	public bool useHDAudio;

	[Token(Token = "0x4000845")]
	[FieldOffset(Offset = "0x25")]
	public bool useHDAnimation;

	[Token(Token = "0x4000846")]
	[FieldOffset(Offset = "0x26")]
	public bool useHDWeaponEffect;

	[Token(Token = "0x4000847")]
	[FieldOffset(Offset = "0x27")]
	public bool useHDTexture;

	[Token(Token = "0x4000848")]
	[FieldOffset(Offset = "0x28")]
	public bool useHDVehicleEffect;

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x259492C", Offset = "0x259492C", VA = "0x259492C")]
	public GraphicConfigItem()
	{
	}
}
