using GCommon.UGCUI;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002447")]
public class UIHUDUGC_ButtonWidgetController : UIHUDUGC_WidgetBaseController
{
	[Token(Token = "0x400E17E")]
	[FieldOffset(Offset = "0x1C")]
	private HudButtonWidgetEntity m_ViewData;

	[Token(Token = "0x400E17F")]
	[FieldOffset(Offset = "0x20")]
	private UGCHudButton m_Button;

	[Token(Token = "0x600CDD0")]
	[Address(RVA = "0x2225C34", Offset = "0x2225C34", VA = "0x2225C34")]
	public UIHUDUGC_ButtonWidgetController()
	{
	}

	[Token(Token = "0x600CDD1")]
	[Address(RVA = "0x2225C3C", Offset = "0x2225C3C", VA = "0x2225C3C", Slot = "6")]
	protected override void InitEntityData()
	{
	}

	[Token(Token = "0x600CDD2")]
	[Address(RVA = "0x2226040", Offset = "0x2226040", VA = "0x2226040", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600CDD3")]
	[Address(RVA = "0x22260B4", Offset = "0x22260B4", VA = "0x22260B4", Slot = "8")]
	protected override void InitWidget()
	{
	}

	[Token(Token = "0x600CDD4")]
	[Address(RVA = "0x2226378", Offset = "0x2226378", VA = "0x2226378", Slot = "9")]
	protected override void RefreshWidgetInfo()
	{
	}

	[Token(Token = "0x600CDD5")]
	[Address(RVA = "0x22264DC", Offset = "0x22264DC", VA = "0x22264DC")]
	private void OnSpriteNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CDD6")]
	[Address(RVA = "0x2226720", Offset = "0x2226720", VA = "0x2226720")]
	public void OnClickButton()
	{
	}

	[Token(Token = "0x600CDD7")]
	[Address(RVA = "0x22268A0", Offset = "0x22268A0", VA = "0x22268A0")]
	public void _003C_003EiFixBaseProxy_InitWidget()
	{
	}

	[Token(Token = "0x600CDD8")]
	[Address(RVA = "0x22268A8", Offset = "0x22268A8", VA = "0x22268A8")]
	public void _003C_003EiFixBaseProxy_RefreshWidgetInfo()
	{
	}
}
