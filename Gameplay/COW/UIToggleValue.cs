using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D3E")]
public class UIToggleValue
{
	[Token(Token = "0x40114C9")]
	[FieldOffset(Offset = "0x8")]
	public int m_Content;

	[Token(Token = "0x40114CA")]
	[FieldOffset(Offset = "0xC")]
	public UIToggle m_Toggle;

	[Token(Token = "0x40114CB")]
	[FieldOffset(Offset = "0x10")]
	public UILabel m_Label;

	[Token(Token = "0x6012EDD")]
	[Address(RVA = "0x201D864", Offset = "0x201D864", VA = "0x201D864")]
	public UIToggleValue(int value, UIToggle toggle)
	{
	}

	[Token(Token = "0x6012EDE")]
	[Address(RVA = "0x201D88C", Offset = "0x201D88C", VA = "0x201D88C")]
	public void SetUIToggleLabel(UILabel label)
	{
	}
}
