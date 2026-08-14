using Il2CppDummyDll;

namespace GCommon.UGCUI;

[Token(Token = "0x2004109")]
public class UGCHudImage : UGCHudWidget
{
	[Token(Token = "0x401B51A")]
	[FieldOffset(Offset = "0x58")]
	protected UISprite m_Sprite;

	[Token(Token = "0x17001D39")]
	public UISprite Image
	{
		[Token(Token = "0x601A8F8")]
		[Address(RVA = "0x324D2D0", Offset = "0x324D2D0", VA = "0x324D2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A8F6")]
	[Address(RVA = "0x324D2C4", Offset = "0x324D2C4", VA = "0x324D2C4")]
	public UGCHudImage()
	{
	}

	[Token(Token = "0x601A8F7")]
	[Address(RVA = "0x324D2C8", Offset = "0x324D2C8", VA = "0x324D2C8", Slot = "9")]
	public override UGCHudWidgetType GetHudWidgetType()
	{
		return default(UGCHudWidgetType);
	}
}
