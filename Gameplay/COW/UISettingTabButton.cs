using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B1B")]
public class UISettingTabButton
{
	[Token(Token = "0x2002B1C")]
	public delegate void ClickCallback(SettingPageType pageType);

	[Token(Token = "0x4010875")]
	[FieldOffset(Offset = "0x8")]
	private UIToggleButton Button;

	[Token(Token = "0x4010876")]
	[FieldOffset(Offset = "0xC")]
	private SettingPageType ToggleType;

	[Token(Token = "0x4010877")]
	[FieldOffset(Offset = "0x10")]
	private ClickCallback m_Callback;

	[Token(Token = "0x6011B89")]
	[Address(RVA = "0x1A58944", Offset = "0x1A58944", VA = "0x1A58944")]
	public UISettingTabButton(UIToggleButton button, SettingPageType type, ClickCallback callback)
	{
	}

	[Token(Token = "0x6011B8A")]
	[Address(RVA = "0x1A5EEB4", Offset = "0x1A5EEB4", VA = "0x1A5EEB4")]
	private void OnButtonClick()
	{
	}
}
