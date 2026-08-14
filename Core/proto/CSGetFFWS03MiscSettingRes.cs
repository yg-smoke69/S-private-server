using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200188B")]
public class CSGetFFWS03MiscSettingRes
{
	[Token(Token = "0x4009D2B")]
	[FieldOffset(Offset = "0x8")]
	public FFWSMiscSettingDesc setting;

	[Token(Token = "0x4009D2C")]
	[FieldOffset(Offset = "0xC")]
	public FFWS03ManagerSetting manager_setting;

	[Token(Token = "0x6007EE4")]
	[Address(RVA = "0x3184940", Offset = "0x3184940", VA = "0x3184940")]
	public CSGetFFWS03MiscSettingRes()
	{
	}
}
