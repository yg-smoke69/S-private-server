using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002829")]
internal class UIHudReloadController : UIHudButtonBaseController
{
	[Token(Token = "0x400F7CB")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudReloadView m_View;

	[Token(Token = "0x600FA57")]
	[Address(RVA = "0x13E07B8", Offset = "0x13E07B8", VA = "0x13E07B8")]
	public UIHudReloadController()
	{
	}

	[Token(Token = "0x600FA58")]
	[Address(RVA = "0x13E07C0", Offset = "0x13E07C0", VA = "0x13E07C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FA59")]
	[Address(RVA = "0x13E0864", Offset = "0x13E0864", VA = "0x13E0864", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FA5A")]
	[Address(RVA = "0x13E09D8", Offset = "0x13E09D8", VA = "0x13E09D8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FA5B")]
	[Address(RVA = "0x13E0B0C", Offset = "0x13E0B0C", VA = "0x13E0B0C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FA5C")]
	[Address(RVA = "0x13E0BB0", Offset = "0x13E0BB0", VA = "0x13E0BB0")]
	public void ShowWarningTip(bool show)
	{
	}

	[Token(Token = "0x600FA5D")]
	[Address(RVA = "0x13E0CA0", Offset = "0x13E0CA0", VA = "0x13E0CA0")]
	private void OnReloadTutorialShow(object[] data)
	{
	}

	[Token(Token = "0x600FA5E")]
	[Address(RVA = "0x13E0DFC", Offset = "0x13E0DFC", VA = "0x13E0DFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FA5F")]
	[Address(RVA = "0x13E0E04", Offset = "0x13E0E04", VA = "0x13E0E04")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
