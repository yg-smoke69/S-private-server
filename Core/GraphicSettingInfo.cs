using COW;
using COW.GamePlay;
using Il2CppDummyDll;

[Token(Token = "0x2002379")]
public class GraphicSettingInfo
{
	[Token(Token = "0x400DCCB")]
	[FieldOffset(Offset = "0x8")]
	public GAGILKKDDMJ quality;

	[Token(Token = "0x400DCCC")]
	[FieldOffset(Offset = "0xC")]
	public bool FPSSetting;

	[Token(Token = "0x400DCCD")]
	[FieldOffset(Offset = "0x10")]
	public EShowShadow shadow;

	[Token(Token = "0x400DCCE")]
	[FieldOffset(Offset = "0x14")]
	public int resolution;

	[Token(Token = "0x400DCCF")]
	[FieldOffset(Offset = "0x18")]
	public bool EnemyFootStepSetting;

	[Token(Token = "0x400DCD0")]
	[FieldOffset(Offset = "0x19")]
	public bool EnemyFireSetting;

	[Token(Token = "0x600C670")]
	[Address(RVA = "0x350B4A4", Offset = "0x350B4A4", VA = "0x350B4A4")]
	public GraphicSettingInfo()
	{
	}
}
