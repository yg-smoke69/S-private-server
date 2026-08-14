using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200334C")]
internal class UIHudCatapultLaunchButtonController : UIHudButtonBaseController
{
	[Token(Token = "0x40138AF")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCatapultLaunchView m_View;

	[Token(Token = "0x6015CD5")]
	[Address(RVA = "0x2148054", Offset = "0x2148054", VA = "0x2148054")]
	public UIHudCatapultLaunchButtonController()
	{
	}

	[Token(Token = "0x6015CD6")]
	[Address(RVA = "0x214805C", Offset = "0x214805C", VA = "0x214805C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015CD7")]
	[Address(RVA = "0x2148100", Offset = "0x2148100", VA = "0x2148100", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015CD8")]
	[Address(RVA = "0x214822C", Offset = "0x214822C", VA = "0x214822C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x6015CD9")]
	[Address(RVA = "0x21482D0", Offset = "0x21482D0", VA = "0x21482D0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6015CDA")]
	[Address(RVA = "0x2148530", Offset = "0x2148530", VA = "0x2148530")]
	private void SetVisibleState(object[] data)
	{
	}

	[Token(Token = "0x6015CDB")]
	[Address(RVA = "0x21487E0", Offset = "0x21487E0", VA = "0x21487E0")]
	private void ShowTutorialFireCatapult()
	{
	}

	[Token(Token = "0x6015CDC")]
	[Address(RVA = "0x2148934", Offset = "0x2148934", VA = "0x2148934")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015CDD")]
	[Address(RVA = "0x214893C", Offset = "0x214893C", VA = "0x214893C")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
