using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026F6")]
internal class UIHudBountyContractController : UIHudButtonBaseController
{
	[Token(Token = "0x400F097")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudBountyContractView m_View;

	[Token(Token = "0x400F098")]
	[FieldOffset(Offset = "0x30")]
	private bool needShow;

	[Token(Token = "0x400F099")]
	[FieldOffset(Offset = "0x31")]
	private bool HasShownTutorial;

	[Token(Token = "0x600EC74")]
	[Address(RVA = "0x1E159BC", Offset = "0x1E159BC", VA = "0x1E159BC")]
	public UIHudBountyContractController()
	{
	}

	[Token(Token = "0x600EC75")]
	[Address(RVA = "0x1E159C4", Offset = "0x1E159C4", VA = "0x1E159C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC76")]
	[Address(RVA = "0x1E15A68", Offset = "0x1E15A68", VA = "0x1E15A68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC77")]
	[Address(RVA = "0x1E15CC0", Offset = "0x1E15CC0", VA = "0x1E15CC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EC78")]
	[Address(RVA = "0x1E15EC4", Offset = "0x1E15EC4", VA = "0x1E15EC4", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EC79")]
	[Address(RVA = "0x1E15F68", Offset = "0x1E15F68", VA = "0x1E15F68")]
	private void ShowBountyIcon(object[] param)
	{
	}

	[Token(Token = "0x600EC7A")]
	[Address(RVA = "0x1E16158", Offset = "0x1E16158", VA = "0x1E16158")]
	private bool ShouldShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600EC7B")]
	[Address(RVA = "0x1E16380", Offset = "0x1E16380", VA = "0x1E16380")]
	private void OnUpdateLoadoutCount(object[] param)
	{
	}

	[Token(Token = "0x600EC7C")]
	[Address(RVA = "0x1E165A8", Offset = "0x1E165A8", VA = "0x1E165A8")]
	private void OnGameOpenningEnd(object[] param)
	{
	}

	[Token(Token = "0x600EC7D")]
	[Address(RVA = "0x1E16720", Offset = "0x1E16720", VA = "0x1E16720")]
	private void ShowTutorial()
	{
	}

	[Token(Token = "0x600EC7E")]
	[Address(RVA = "0x1E16928", Offset = "0x1E16928", VA = "0x1E16928")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC7F")]
	[Address(RVA = "0x1E16930", Offset = "0x1E16930", VA = "0x1E16930")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
