using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026FC")]
internal class UIHudBuildingSwitchInfoController : UIBaseController
{
	[Token(Token = "0x400F0A9")]
	[FieldOffset(Offset = "0x28")]
	public UIHudBuildingSwitchInfoView m_View;

	[Token(Token = "0x400F0AA")]
	[FieldOffset(Offset = "0x2C")]
	public int Index;

	[Token(Token = "0x600ECAF")]
	[Address(RVA = "0x1EFD814", Offset = "0x1EFD814", VA = "0x1EFD814")]
	public UIHudBuildingSwitchInfoController()
	{
	}

	[Token(Token = "0x600ECB0")]
	[Address(RVA = "0x1EFD898", Offset = "0x1EFD898", VA = "0x1EFD898")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ECB1")]
	[Address(RVA = "0x1EFD940", Offset = "0x1EFD940", VA = "0x1EFD940", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ECB2")]
	[Address(RVA = "0x1EFDB30", Offset = "0x1EFDB30", VA = "0x1EFDB30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600ECB3")]
	[Address(RVA = "0x1EFDC64", Offset = "0x1EFDC64", VA = "0x1EFDC64")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600ECB4")]
	[Address(RVA = "0x1EFDCF0", Offset = "0x1EFDCF0", VA = "0x1EFDCF0")]
	public void SetSprite(string name)
	{
	}

	[Token(Token = "0x600ECB5")]
	[Address(RVA = "0x1EFE050", Offset = "0x1EFE050", VA = "0x1EFE050")]
	private void OnSwitchBuildingClick()
	{
	}

	[Token(Token = "0x600ECB6")]
	[Address(RVA = "0x1EFE2F0", Offset = "0x1EFE2F0", VA = "0x1EFE2F0")]
	public bool GetHighlight()
	{
		return default(bool);
	}

	[Token(Token = "0x600ECB7")]
	[Address(RVA = "0x1EFE37C", Offset = "0x1EFE37C", VA = "0x1EFE37C")]
	public void SetHighlight(bool val)
	{
	}

	[Token(Token = "0x600ECB8")]
	[Address(RVA = "0x1EFE454", Offset = "0x1EFE454", VA = "0x1EFE454")]
	private void OnIndexChange(object[] param)
	{
	}

	[Token(Token = "0x600ECB9")]
	[Address(RVA = "0x1EFE550", Offset = "0x1EFE550", VA = "0x1EFE550")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ECBA")]
	[Address(RVA = "0x1EFE558", Offset = "0x1EFE558", VA = "0x1EFE558")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
