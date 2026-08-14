using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200272A")]
public class UIHudDebugToggleUIController : UIBaseController
{
	[Token(Token = "0x400F1B5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudDebugToggleUIView m_View;

	[Token(Token = "0x600EE58")]
	[Address(RVA = "0x1CD1E50", Offset = "0x1CD1E50", VA = "0x1CD1E50")]
	public UIHudDebugToggleUIController()
	{
	}

	[Token(Token = "0x600EE59")]
	[Address(RVA = "0x1CD1ED4", Offset = "0x1CD1ED4", VA = "0x1CD1ED4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EE5A")]
	[Address(RVA = "0x1CD1F7C", Offset = "0x1CD1F7C", VA = "0x1CD1F7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EE5B")]
	[Address(RVA = "0x1CD23D0", Offset = "0x1CD23D0", VA = "0x1CD23D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EE5C")]
	[Address(RVA = "0x1CD2504", Offset = "0x1CD2504", VA = "0x1CD2504")]
	private void OnDebugToggle()
	{
	}

	[Token(Token = "0x600EE5D")]
	[Address(RVA = "0x1CD2190", Offset = "0x1CD2190", VA = "0x1CD2190")]
	private void OnShowDebugUI(object[] param)
	{
	}

	[Token(Token = "0x600EE5E")]
	[Address(RVA = "0x1CD26EC", Offset = "0x1CD26EC", VA = "0x1CD26EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EE5F")]
	[Address(RVA = "0x1CD26F4", Offset = "0x1CD26F4", VA = "0x1CD26F4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
