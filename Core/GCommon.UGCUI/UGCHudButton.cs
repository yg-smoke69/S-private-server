using Il2CppDummyDll;

namespace GCommon.UGCUI;

[Token(Token = "0x2004107")]
public class UGCHudButton : UGCHudWidget
{
	[Token(Token = "0x401B512")]
	[FieldOffset(Offset = "0x58")]
	protected UIButton m_Button;

	[Token(Token = "0x401B513")]
	[FieldOffset(Offset = "0x5C")]
	protected UISprite m_Sprite;

	[Token(Token = "0x17001D37")]
	public UIButton Button
	{
		[Token(Token = "0x601A8F4")]
		[Address(RVA = "0x324D11C", Offset = "0x324D11C", VA = "0x324D11C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D38")]
	public UISprite Image
	{
		[Token(Token = "0x601A8F5")]
		[Address(RVA = "0x324D1F0", Offset = "0x324D1F0", VA = "0x324D1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A8F2")]
	[Address(RVA = "0x324D078", Offset = "0x324D078", VA = "0x324D078")]
	public UGCHudButton()
	{
	}

	[Token(Token = "0x601A8F3")]
	[Address(RVA = "0x324D114", Offset = "0x324D114", VA = "0x324D114", Slot = "9")]
	public override UGCHudWidgetType GetHudWidgetType()
	{
		return default(UGCHudWidgetType);
	}
}
