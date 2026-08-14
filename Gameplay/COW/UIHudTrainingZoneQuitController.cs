using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002888")]
public class UIHudTrainingZoneQuitController : UIBaseController
{
	[Token(Token = "0x400F9A1")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTrainingZoneQuitView m_View;

	[Token(Token = "0x600FE44")]
	[Address(RVA = "0x1587A18", Offset = "0x1587A18", VA = "0x1587A18")]
	public UIHudTrainingZoneQuitController()
	{
	}

	[Token(Token = "0x600FE45")]
	[Address(RVA = "0x1587A9C", Offset = "0x1587A9C", VA = "0x1587A9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE46")]
	[Address(RVA = "0x1587B40", Offset = "0x1587B40", VA = "0x1587B40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE47")]
	[Address(RVA = "0x1587E58", Offset = "0x1587E58", VA = "0x1587E58", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FE48")]
	[Address(RVA = "0x15880B4", Offset = "0x15880B4", VA = "0x15880B4")]
	private void OnTrainingZoneChanged(object[] data)
	{
	}

	[Token(Token = "0x600FE49")]
	[Address(RVA = "0x15881B0", Offset = "0x15881B0", VA = "0x15881B0")]
	private void OnMiniGameStart(object[] data)
	{
	}

	[Token(Token = "0x600FE4A")]
	[Address(RVA = "0x1588298", Offset = "0x1588298", VA = "0x1588298")]
	private void OnMiniGameClose(object[] data)
	{
	}

	[Token(Token = "0x600FE4B")]
	[Address(RVA = "0x158830C", Offset = "0x158830C", VA = "0x158830C")]
	private void OnBtnBack()
	{
	}

	[Token(Token = "0x600FE4C")]
	[Address(RVA = "0x15888E8", Offset = "0x15888E8", VA = "0x15888E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FE4D")]
	[Address(RVA = "0x15888F0", Offset = "0x15888F0", VA = "0x15888F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
