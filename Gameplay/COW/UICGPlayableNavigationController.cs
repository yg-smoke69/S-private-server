using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C75")]
public abstract class UICGPlayableNavigationController : UIPreviewNavigationController
{
	[Token(Token = "0x4010FAE")]
	[FieldOffset(Offset = "0x7C")]
	protected UINavigationUtil.UINavigationPageType m_UINavigationPageType;

	[Token(Token = "0x60128A7")]
	[Address(RVA = "0x1449E90", Offset = "0x1449E90", VA = "0x1449E90")]
	protected UICGPlayableNavigationController()
	{
	}

	[Token(Token = "0x60128A8")]
	protected abstract UINavigationUtil.UINavigationPageType GetUINavigationPageType();

	[Token(Token = "0x60128A9")]
	[Address(RVA = "0x1449E98", Offset = "0x1449E98", VA = "0x1449E98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60128AA")]
	[Address(RVA = "0x1449F14", Offset = "0x1449F14", VA = "0x1449F14", Slot = "65")]
	protected virtual void PlayCG(ResourceID cgResourceID, bool showFuncBtn = true, bool isHas = false)
	{
	}

	[Token(Token = "0x60128AB")]
	[Address(RVA = "0x144A06C", Offset = "0x144A06C", VA = "0x144A06C")]
	public void CloseCG()
	{
	}

	[Token(Token = "0x60128AC")]
	[Address(RVA = "0x144A0E4", Offset = "0x144A0E4", VA = "0x144A0E4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
