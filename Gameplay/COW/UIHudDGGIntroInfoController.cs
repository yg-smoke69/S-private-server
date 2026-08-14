using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200272C")]
public class UIHudDGGIntroInfoController : UIBaseController
{
	[Token(Token = "0x400F1B9")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDGGIntroInfoView m_View;

	[Token(Token = "0x400F1BA")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x600EE6E")]
	[Address(RVA = "0x1CC9A10", Offset = "0x1CC9A10", VA = "0x1CC9A10")]
	public UIHudDGGIntroInfoController()
	{
	}

	[Token(Token = "0x600EE6F")]
	[Address(RVA = "0x1CC9A94", Offset = "0x1CC9A94", VA = "0x1CC9A94")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EE70")]
	[Address(RVA = "0x1CC9B38", Offset = "0x1CC9B38", VA = "0x1CC9B38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EE71")]
	[Address(RVA = "0x1CCA3F0", Offset = "0x1CCA3F0", VA = "0x1CCA3F0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EE72")]
	[Address(RVA = "0x1CC9CDC", Offset = "0x1CC9CDC", VA = "0x1CC9CDC")]
	private void UpdateDetailInfo()
	{
	}

	[Token(Token = "0x600EE73")]
	[Address(RVA = "0x1CCA50C", Offset = "0x1CCA50C", VA = "0x1CCA50C")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600EE74")]
	[Address(RVA = "0x1CCA5E4", Offset = "0x1CCA5E4", VA = "0x1CCA5E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EE75")]
	[Address(RVA = "0x1CCA5EC", Offset = "0x1CCA5EC", VA = "0x1CCA5EC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
