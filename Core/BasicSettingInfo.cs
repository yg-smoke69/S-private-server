using COW.HUD;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002371")]
public class BasicSettingInfo
{
	[Token(Token = "0x400DCA1")]
	[FieldOffset(Offset = "0x8")]
	public LocLang language;

	[Token(Token = "0x400DCA2")]
	[FieldOffset(Offset = "0xC")]
	public bool minimapScale;

	[Token(Token = "0x400DCA3")]
	[FieldOffset(Offset = "0x10")]
	public UIHudMinimapController.JPKDINFPGOD minimapMode;

	[Token(Token = "0x600C619")]
	[Address(RVA = "0x2ECFFF4", Offset = "0x2ECFFF4", VA = "0x2ECFFF4")]
	public BasicSettingInfo()
	{
	}
}
