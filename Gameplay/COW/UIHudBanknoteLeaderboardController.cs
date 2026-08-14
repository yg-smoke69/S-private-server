using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003348")]
internal class UIHudBanknoteLeaderboardController : UIBaseController
{
	[Token(Token = "0x4013892")]
	[FieldOffset(Offset = "0x28")]
	private UIHudControlLeaderboardView m_View;

	[Token(Token = "0x4013893")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, LeaderboardData> m_ItemsBe4LocalPlayer;

	[Token(Token = "0x4013894")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<IHAAMHPPLMG, UIHudBanknoteLeaderboardItemController> m_ItemControllers;

	[Token(Token = "0x4013895")]
	[FieldOffset(Offset = "0x34")]
	private bool m_LocalPlayerAdded;

	[Token(Token = "0x4013896")]
	[FieldOffset(Offset = "0x38")]
	private int m_LocalPlayerTeamId;

	[Token(Token = "0x4013897")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsSPFactionUpdated;

	[Token(Token = "0x4013898")]
	[FieldOffset(Offset = "0x40")]
	private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType1;

	[Token(Token = "0x4013899")]
	[FieldOffset(Offset = "0x44")]
	private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType2;

	[Token(Token = "0x401389A")]
	[FieldOffset(Offset = "0x48")]
	private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType3;

	[Token(Token = "0x6015C8E")]
	[Address(RVA = "0x1715364", Offset = "0x1715364", VA = "0x1715364")]
	public UIHudBanknoteLeaderboardController()
	{
	}

	[Token(Token = "0x6015C8F")]
	[Address(RVA = "0x1715450", Offset = "0x1715450", VA = "0x1715450")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015C90")]
	[Address(RVA = "0x17154F4", Offset = "0x17154F4", VA = "0x17154F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015C91")]
	[Address(RVA = "0x1715900", Offset = "0x1715900", VA = "0x1715900", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6015C92")]
	[Address(RVA = "0x17159F8", Offset = "0x17159F8", VA = "0x17159F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015C93")]
	[Address(RVA = "0x1715D34", Offset = "0x1715D34", VA = "0x1715D34")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x6015C94")]
	[Address(RVA = "0x1715DA0", Offset = "0x1715DA0", VA = "0x1715DA0")]
	public void SetTitle(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
	{
	}

	[Token(Token = "0x6015C95")]
	[Address(RVA = "0x1715F04", Offset = "0x1715F04", VA = "0x1715F04")]
	private void OnAddPlayer(object[] param)
	{
	}

	[Token(Token = "0x6015C96")]
	[Address(RVA = "0x1716C7C", Offset = "0x1716C7C", VA = "0x1716C7C")]
	private bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x6015C97")]
	[Address(RVA = "0x171680C", Offset = "0x171680C", VA = "0x171680C")]
	private void AddItemController(IHAAMHPPLMG pId, LeaderboardData dataInfo)
	{
	}

	[Token(Token = "0x6015C98")]
	[Address(RVA = "0x17175C4", Offset = "0x17175C4", VA = "0x17175C4")]
	private void OnKillCountChanged(object[] param)
	{
	}

	[Token(Token = "0x6015C99")]
	[Address(RVA = "0x1717808", Offset = "0x1717808", VA = "0x1717808")]
	private void OnDMGChanged(object[] param)
	{
	}

	[Token(Token = "0x6015C9A")]
	[Address(RVA = "0x1717A4C", Offset = "0x1717A4C", VA = "0x1717A4C")]
	private void OnSyncLeaderBoard(object[] data)
	{
	}

	[Token(Token = "0x6015C9B")]
	[Address(RVA = "0x1717DB0", Offset = "0x1717DB0", VA = "0x1717DB0")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x6015C9C")]
	[Address(RVA = "0x1717EA4", Offset = "0x1717EA4", VA = "0x1717EA4")]
	private void OnFactionIDChanged(object[] param)
	{
	}

	[Token(Token = "0x6015C9D")]
	[Address(RVA = "0x1716FF8", Offset = "0x1716FF8", VA = "0x1716FF8")]
	private void UpdateFactionInfo()
	{
	}

	[Token(Token = "0x6015C9E")]
	[Address(RVA = "0x1716E78", Offset = "0x1716E78", VA = "0x1716E78")]
	private void UpdateFactionInfo(int localFactionID)
	{
	}

	[Token(Token = "0x6015C9F")]
	[Address(RVA = "0x1717F80", Offset = "0x1717F80", VA = "0x1717F80")]
	private void OnToggleRoundInfo(object[] parap)
	{
	}

	[Token(Token = "0x6015CA0")]
	[Address(RVA = "0x1718034", Offset = "0x1718034", VA = "0x1718034")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015CA1")]
	[Address(RVA = "0x171803C", Offset = "0x171803C", VA = "0x171803C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6015CA2")]
	[Address(RVA = "0x1718044", Offset = "0x1718044", VA = "0x1718044")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
