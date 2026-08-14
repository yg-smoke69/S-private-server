using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027EB")]
public class UIHudPartyGameSoloDanceInvitationController : UIBaseController
{
	[Token(Token = "0x400F66B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPartyGameSoloDanceInvitationView m_View;

	[Token(Token = "0x400F66C")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_CanReceiveInvitation;

	[Token(Token = "0x400F66D")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallAutoHide;

	[Token(Token = "0x600F7A3")]
	[Address(RVA = "0x184093C", Offset = "0x184093C", VA = "0x184093C")]
	public UIHudPartyGameSoloDanceInvitationController()
	{
	}

	[Token(Token = "0x600F7A4")]
	[Address(RVA = "0x18409C0", Offset = "0x18409C0", VA = "0x18409C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F7A5")]
	[Address(RVA = "0x1840A64", Offset = "0x1840A64", VA = "0x1840A64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F7A6")]
	[Address(RVA = "0x1840E10", Offset = "0x1840E10", VA = "0x1840E10", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F7A7")]
	[Address(RVA = "0x1841194", Offset = "0x1841194", VA = "0x1841194")]
	private void OnEnterMode(object[] data)
	{
	}

	[Token(Token = "0x600F7A8")]
	[Address(RVA = "0x1841270", Offset = "0x1841270", VA = "0x1841270")]
	private void OnQuitMode(object[] data)
	{
	}

	[Token(Token = "0x600F7A9")]
	[Address(RVA = "0x18412D8", Offset = "0x18412D8", VA = "0x18412D8")]
	private void OnMsgInvitation(object[] data)
	{
	}

	[Token(Token = "0x600F7AA")]
	[Address(RVA = "0x1841518", Offset = "0x1841518", VA = "0x1841518")]
	private void ShowThisPanel()
	{
	}

	[Token(Token = "0x600F7AB")]
	[Address(RVA = "0x18411FC", Offset = "0x18411FC", VA = "0x18411FC")]
	private void HideThisPanel()
	{
	}

	[Token(Token = "0x600F7AC")]
	[Address(RVA = "0x1841084", Offset = "0x1841084", VA = "0x1841084")]
	private void CleanDelayCallAutoHide()
	{
	}

	[Token(Token = "0x600F7AD")]
	[Address(RVA = "0x18416D0", Offset = "0x18416D0", VA = "0x18416D0")]
	private void OnMsgBattleStart(object[] data)
	{
	}

	[Token(Token = "0x600F7AE")]
	[Address(RVA = "0x1841738", Offset = "0x1841738", VA = "0x1841738")]
	private void OnClickBtnRejectInvitaion()
	{
	}

	[Token(Token = "0x600F7AF")]
	[Address(RVA = "0x18417D4", Offset = "0x18417D4", VA = "0x18417D4")]
	private void OnClickBtnAcceptInvitaion()
	{
	}

	[Token(Token = "0x600F7B0")]
	[Address(RVA = "0x1841AF8", Offset = "0x1841AF8", VA = "0x1841AF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F7B1")]
	[Address(RVA = "0x1841B00", Offset = "0x1841B00", VA = "0x1841B00")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
