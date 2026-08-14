using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022BF")]
internal class UIHudPVEReviveInfoController : UIBaseController
{
	[Token(Token = "0x400D93C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPVEReviveInfoView m_View;

	[Token(Token = "0x600BF2A")]
	[Address(RVA = "0x183BAE4", Offset = "0x183BAE4", VA = "0x183BAE4")]
	public UIHudPVEReviveInfoController()
	{
	}

	[Token(Token = "0x600BF2B")]
	[Address(RVA = "0x183BB68", Offset = "0x183BB68", VA = "0x183BB68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF2C")]
	[Address(RVA = "0x183BC0C", Offset = "0x183BC0C", VA = "0x183BC0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF2D")]
	[Address(RVA = "0x183BD70", Offset = "0x183BD70", VA = "0x183BD70", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BF2E")]
	[Address(RVA = "0x183BEA4", Offset = "0x183BEA4", VA = "0x183BEA4")]
	public void OpenFakeHudBtns()
	{
	}

	[Token(Token = "0x600BF2F")]
	[Address(RVA = "0x183C004", Offset = "0x183C004", VA = "0x183C004")]
	public void SetUIData(ulong num = 10uL, bool teamWiped = false, int leftTokenCount = 0, int leftDiamond = 0, int costTokenCount = 0, int costGemsCount = 0)
	{
	}

	[Token(Token = "0x600BF30")]
	[Address(RVA = "0x183C30C", Offset = "0x183C30C", VA = "0x183C30C")]
	private void SetButtonNumberAndEnabled(UIButton btn, UILabel label, bool enable, int cost)
	{
	}

	[Token(Token = "0x600BF31")]
	[Address(RVA = "0x183C41C", Offset = "0x183C41C", VA = "0x183C41C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BF32")]
	[Address(RVA = "0x183C770", Offset = "0x183C770", VA = "0x183C770", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600BF33")]
	[Address(RVA = "0x183C488", Offset = "0x183C488", VA = "0x183C488")]
	private void UpdateAxisTouchingThroughArea()
	{
	}

	[Token(Token = "0x600BF34")]
	[Address(RVA = "0x183C900", Offset = "0x183C900", VA = "0x183C900")]
	private void OnLocalPlayerAdd(object[] data)
	{
	}

	[Token(Token = "0x600BF35")]
	[Address(RVA = "0x183C968", Offset = "0x183C968", VA = "0x183C968")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BF36")]
	[Address(RVA = "0x183C970", Offset = "0x183C970", VA = "0x183C970")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600BF37")]
	[Address(RVA = "0x183C978", Offset = "0x183C978", VA = "0x183C978")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BF38")]
	[Address(RVA = "0x183C980", Offset = "0x183C980", VA = "0x183C980")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
