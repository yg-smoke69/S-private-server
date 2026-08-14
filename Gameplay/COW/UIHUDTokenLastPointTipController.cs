using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023D6")]
public class UIHUDTokenLastPointTipController : UIBaseController
{
	[Token(Token = "0x400DEC6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTokenLastPointWinTipView m_View;

	[Token(Token = "0x400DEC7")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x600CA26")]
	[Address(RVA = "0x2221938", Offset = "0x2221938", VA = "0x2221938")]
	public UIHUDTokenLastPointTipController()
	{
	}

	[Token(Token = "0x600CA27")]
	[Address(RVA = "0x22219BC", Offset = "0x22219BC", VA = "0x22219BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA28")]
	[Address(RVA = "0x2221A64", Offset = "0x2221A64", VA = "0x2221A64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA29")]
	[Address(RVA = "0x2221B20", Offset = "0x2221B20", VA = "0x2221B20", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600CA2A")]
	[Address(RVA = "0x2221C9C", Offset = "0x2221C9C", VA = "0x2221C9C")]
	public void ShowContent(string content)
	{
	}

	[Token(Token = "0x600CA2B")]
	[Address(RVA = "0x2221E44", Offset = "0x2221E44", VA = "0x2221E44")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600CA2C")]
	[Address(RVA = "0x2221B8C", Offset = "0x2221B8C", VA = "0x2221B8C")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600CA2D")]
	[Address(RVA = "0x2221F54", Offset = "0x2221F54", VA = "0x2221F54")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CA2E")]
	[Address(RVA = "0x2221F5C", Offset = "0x2221F5C", VA = "0x2221F5C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
