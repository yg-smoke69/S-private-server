using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027E6")]
internal class UIHudObserverProfileController : UIBaseController
{
	[Token(Token = "0x400F651")]
	[FieldOffset(Offset = "0x28")]
	private UIHudObserverProfileView m_View;

	[Token(Token = "0x400F652")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_Profile;

	[Token(Token = "0x400F653")]
	[FieldOffset(Offset = "0x30")]
	private IHAAMHPPLMG m_TargetPlayerID;

	[Token(Token = "0x400F654")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_TargetUserID;

	[Token(Token = "0x400F655")]
	[FieldOffset(Offset = "0x50")]
	private string m_TargetPlayerName;

	[Token(Token = "0x400F656")]
	[FieldOffset(Offset = "0x54")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F657")]
	[FieldOffset(Offset = "0x58")]
	private bool m_ShowReviveCountDown;

	[Token(Token = "0x600F75C")]
	[Address(RVA = "0x18308D4", Offset = "0x18308D4", VA = "0x18308D4")]
	public UIHudObserverProfileController()
	{
	}

	[Token(Token = "0x600F75D")]
	[Address(RVA = "0x1830958", Offset = "0x1830958", VA = "0x1830958")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F75E")]
	[Address(RVA = "0x18309FC", Offset = "0x18309FC", VA = "0x18309FC", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F75F")]
	[Address(RVA = "0x1831574", Offset = "0x1831574", VA = "0x1831574", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F760")]
	[Address(RVA = "0x18325E4", Offset = "0x18325E4", VA = "0x18325E4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F761")]
	[Address(RVA = "0x183101C", Offset = "0x183101C", VA = "0x183101C")]
	private void RefreshSomeUIVisable()
	{
	}

	[Token(Token = "0x600F762")]
	[Address(RVA = "0x1832988", Offset = "0x1832988", VA = "0x1832988")]
	private void OnObserverSwitch(object[] data)
	{
	}

	[Token(Token = "0x600F763")]
	[Address(RVA = "0x1833FD0", Offset = "0x1833FD0", VA = "0x1833FD0")]
	private void OnLikeCountChanged(object[] data)
	{
	}

	[Token(Token = "0x600F764")]
	[Address(RVA = "0x1834110", Offset = "0x1834110", VA = "0x1834110")]
	private void OnDropClick()
	{
	}

	[Token(Token = "0x600F765")]
	[Address(RVA = "0x18342BC", Offset = "0x18342BC", VA = "0x18342BC")]
	private void onReportClick()
	{
	}

	[Token(Token = "0x600F766")]
	[Address(RVA = "0x18345A8", Offset = "0x18345A8", VA = "0x18345A8")]
	private void OnReportCheatSent(object[] param)
	{
	}

	[Token(Token = "0x600F767")]
	[Address(RVA = "0x18346C8", Offset = "0x18346C8", VA = "0x18346C8")]
	private void OnLikeClick()
	{
	}

	[Token(Token = "0x600F768")]
	[Address(RVA = "0x1834A14", Offset = "0x1834A14", VA = "0x1834A14")]
	private void OnAddFriendClick()
	{
	}

	[Token(Token = "0x600F769")]
	[Address(RVA = "0x1834DF4", Offset = "0x1834DF4", VA = "0x1834DF4")]
	private void OnReviveClick()
	{
	}

	[Token(Token = "0x600F76A")]
	[Address(RVA = "0x1835244", Offset = "0x1835244", VA = "0x1835244")]
	private void OnOpenReviveUI(object[] param)
	{
	}

	[Token(Token = "0x600F76B")]
	[Address(RVA = "0x18339C8", Offset = "0x18339C8", VA = "0x18339C8")]
	private void StartReviveCountDown()
	{
	}

	[Token(Token = "0x600F76C")]
	[Address(RVA = "0x1835728", Offset = "0x1835728", VA = "0x1835728")]
	private void OnCountDownFinished()
	{
	}

	[Token(Token = "0x600F76D")]
	[Address(RVA = "0x1835990", Offset = "0x1835990", VA = "0x1835990")]
	private void OnObserverInfoListVisibleChanged(object[] data)
	{
	}

	[Token(Token = "0x600F76E")]
	[Address(RVA = "0x1835A9C", Offset = "0x1835A9C", VA = "0x1835A9C")]
	private void OnTrainingZoneChanged(object[] data)
	{
	}

	[Token(Token = "0x600F76F")]
	[Address(RVA = "0x1835BE0", Offset = "0x1835BE0", VA = "0x1835BE0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F770")]
	[Address(RVA = "0x1835BE8", Offset = "0x1835BE8", VA = "0x1835BE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F771")]
	[Address(RVA = "0x1835BF0", Offset = "0x1835BF0", VA = "0x1835BF0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
