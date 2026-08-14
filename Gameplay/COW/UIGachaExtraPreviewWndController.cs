using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200263E")]
public class UIGachaExtraPreviewWndController : UIPopupWindowController
{
	[Token(Token = "0x400EC13")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaExtraPreviewWndView m_View;

	[Token(Token = "0x600E3CB")]
	[Address(RVA = "0x2478E90", Offset = "0x2478E90", VA = "0x2478E90")]
	public UIGachaExtraPreviewWndController()
	{
	}

	[Token(Token = "0x600E3CC")]
	[Address(RVA = "0x2478E98", Offset = "0x2478E98", VA = "0x2478E98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3CD")]
	[Address(RVA = "0x2478F3C", Offset = "0x2478F3C", VA = "0x2478F3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E3CE")]
	[Address(RVA = "0x2479098", Offset = "0x2479098", VA = "0x2479098")]
	public void SetViewData(ExtraRewardDesc desc, bool needPeriod = true)
	{
	}

	[Token(Token = "0x600E3CF")]
	[Address(RVA = "0x247988C", Offset = "0x247988C", VA = "0x247988C")]
	private void ShowLeftTimeLabel(ExtraRewardDesc desc)
	{
	}

	[Token(Token = "0x600E3D0")]
	[Address(RVA = "0x2479BE8", Offset = "0x2479BE8", VA = "0x2479BE8")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x600E3D1")]
	[Address(RVA = "0x2479C4C", Offset = "0x2479C4C", VA = "0x2479C4C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E3D2")]
	[Address(RVA = "0x2479CB0", Offset = "0x2479CB0", VA = "0x2479CB0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E3D3")]
	[Address(RVA = "0x2479D14", Offset = "0x2479D14", VA = "0x2479D14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E3D4")]
	[Address(RVA = "0x2479D1C", Offset = "0x2479D1C", VA = "0x2479D1C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E3D5")]
	[Address(RVA = "0x2479D24", Offset = "0x2479D24", VA = "0x2479D24")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
