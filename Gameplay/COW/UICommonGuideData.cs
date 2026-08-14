using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200257D")]
public class UICommonGuideData
{
	[Token(Token = "0x400E7F5")]
	[FieldOffset(Offset = "0x8")]
	public string PlayerPrefKey;

	[Token(Token = "0x400E7F6")]
	[FieldOffset(Offset = "0xC")]
	public CommonGuideSetting GuideSetting;

	[Token(Token = "0x400E7F7")]
	[FieldOffset(Offset = "0x10")]
	public UIButton FinishGuideBtn;

	[Token(Token = "0x400E7F8")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget GuidingWidget;

	[Token(Token = "0x400E7F9")]
	[FieldOffset(Offset = "0x18")]
	public Side Side;

	[Token(Token = "0x600DB25")]
	[Address(RVA = "0x2CE338C", Offset = "0x2CE338C", VA = "0x2CE338C")]
	public UICommonGuideData()
	{
	}
}
