using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200263D")]
public class UIGachaExtraPreviewItemController : UIBaseController
{
	[Token(Token = "0x400EC12")]
	[FieldOffset(Offset = "0x28")]
	private UIGachaExtraPreviewItemView m_View;

	[Token(Token = "0x600E3C2")]
	[Address(RVA = "0x2478688", Offset = "0x2478688", VA = "0x2478688")]
	public UIGachaExtraPreviewItemController()
	{
	}

	[Token(Token = "0x600E3C3")]
	[Address(RVA = "0x247870C", Offset = "0x247870C", VA = "0x247870C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3C4")]
	[Address(RVA = "0x24787B0", Offset = "0x24787B0", VA = "0x24787B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E3C5")]
	[Address(RVA = "0x24788A4", Offset = "0x24788A4", VA = "0x24788A4")]
	public void SetViewData(AwardDesc desc)
	{
	}

	[Token(Token = "0x600E3C6")]
	[Address(RVA = "0x24789C4", Offset = "0x24789C4", VA = "0x24789C4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E3C7")]
	[Address(RVA = "0x2478A28", Offset = "0x2478A28", VA = "0x2478A28", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E3C8")]
	[Address(RVA = "0x2478A8C", Offset = "0x2478A8C", VA = "0x2478A8C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E3C9")]
	[Address(RVA = "0x2478A94", Offset = "0x2478A94", VA = "0x2478A94")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E3CA")]
	[Address(RVA = "0x2478A9C", Offset = "0x2478A9C", VA = "0x2478A9C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
