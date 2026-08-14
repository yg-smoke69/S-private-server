using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026BC")]
internal class UIGuideTipsController : UIPopupWindowController
{
	[Token(Token = "0x400EF10")]
	[FieldOffset(Offset = "0x48")]
	private uint m_TipsCall;

	[Token(Token = "0x400EF11")]
	[FieldOffset(Offset = "0x4C")]
	private UIGuideTipsView m_View;

	[Token(Token = "0x600E9F1")]
	[Address(RVA = "0x2027B70", Offset = "0x2027B70", VA = "0x2027B70")]
	public UIGuideTipsController()
	{
	}

	[Token(Token = "0x600E9F2")]
	[Address(RVA = "0x2027B78", Offset = "0x2027B78", VA = "0x2027B78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E9F3")]
	[Address(RVA = "0x2027C1C", Offset = "0x2027C1C", VA = "0x2027C1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E9F4")]
	[Address(RVA = "0x2027D10", Offset = "0x2027D10", VA = "0x2027D10")]
	public void SetData(string msg)
	{
	}

	[Token(Token = "0x600E9F5")]
	[Address(RVA = "0x2027F28", Offset = "0x2027F28", VA = "0x2027F28", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E9F6")]
	[Address(RVA = "0x2028044", Offset = "0x2028044", VA = "0x2028044")]
	private void _003CSetData_003Em__0()
	{
	}

	[Token(Token = "0x600E9F7")]
	[Address(RVA = "0x2028054", Offset = "0x2028054", VA = "0x2028054")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E9F8")]
	[Address(RVA = "0x202805C", Offset = "0x202805C", VA = "0x202805C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
