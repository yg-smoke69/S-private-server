using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022A0")]
internal class UIHudTDMLikeShopEntryController : UIBaseController
{
	[Token(Token = "0x400D8C2")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTDMLikeShopEntryView m_View;

	[Token(Token = "0x400D8C3")]
	[FieldOffset(Offset = "0x2C")]
	private float m_NextHideTime;

	[Token(Token = "0x600BE50")]
	[Address(RVA = "0x1FF96F4", Offset = "0x1FF96F4", VA = "0x1FF96F4")]
	public UIHudTDMLikeShopEntryController()
	{
	}

	[Token(Token = "0x600BE51")]
	[Address(RVA = "0x1FF9778", Offset = "0x1FF9778", VA = "0x1FF9778")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE52")]
	[Address(RVA = "0x1FF9820", Offset = "0x1FF9820", VA = "0x1FF9820", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BE53")]
	[Address(RVA = "0x1FF9A08", Offset = "0x1FF9A08", VA = "0x1FF9A08")]
	private void Update()
	{
	}

	[Token(Token = "0x600BE54")]
	[Address(RVA = "0x1FF9A68", Offset = "0x1FF9A68", VA = "0x1FF9A68")]
	private void runOneFrame()
	{
	}

	[Token(Token = "0x600BE55")]
	[Address(RVA = "0x1FF9D4C", Offset = "0x1FF9D4C", VA = "0x1FF9D4C")]
	private void OnShopBtnClick()
	{
	}

	[Token(Token = "0x600BE56")]
	[Address(RVA = "0x1FF9EE8", Offset = "0x1FF9EE8", VA = "0x1FF9EE8")]
	private void OnShopManuallyClosed(object[] data)
	{
	}

	[Token(Token = "0x600BE57")]
	[Address(RVA = "0x1FF9F6C", Offset = "0x1FF9F6C", VA = "0x1FF9F6C")]
	private void OnShowGuide(object[] data)
	{
	}

	[Token(Token = "0x600BE58")]
	[Address(RVA = "0x1FFA114", Offset = "0x1FFA114", VA = "0x1FFA114")]
	public void SetNextHideTime(float nextHideTime)
	{
	}

	[Token(Token = "0x600BE59")]
	[Address(RVA = "0x1FFA178", Offset = "0x1FFA178", VA = "0x1FFA178")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
