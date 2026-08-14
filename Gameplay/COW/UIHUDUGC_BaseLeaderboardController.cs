using System.Runtime.InteropServices;
using COW.GamePlay;
using COW.Gameplay.MultiplayerGame;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002446")]
internal abstract class UIHUDUGC_BaseLeaderboardController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E178")]
	[FieldOffset(Offset = "0x28")]
	protected UGCScoreBlackboard m_ScoreBlackboard;

	[Token(Token = "0x400E179")]
	[FieldOffset(Offset = "0x2C")]
	protected UserControlHandler m_UserControl;

	[Token(Token = "0x400E17A")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_OriginInputState;

	[Token(Token = "0x400E17B")]
	[FieldOffset(Offset = "0x34")]
	protected uint m_SelfTeamIndex;

	[Token(Token = "0x400E17C")]
	[FieldOffset(Offset = "0x38")]
	protected string m_EntityID;

	[Token(Token = "0x400E17D")]
	[FieldOffset(Offset = "0x3C")]
	private float m_LastUpateTime;

	[Token(Token = "0x600CDBD")]
	[Address(RVA = "0x22249D8", Offset = "0x22249D8", VA = "0x22249D8")]
	protected UIHUDUGC_BaseLeaderboardController()
	{
	}

	[Token(Token = "0x600CDBE")]
	[Address(RVA = "0x2224A5C", Offset = "0x2224A5C", VA = "0x2224A5C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CDBF")]
	protected abstract void InitView();

	[Token(Token = "0x600CDC0")]
	protected abstract UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player);

	[Token(Token = "0x600CDC1")]
	protected abstract UIHUDUGC_BaseLeaderboard_TeammateItemController FindTeammateItem(IHAAMHPPLMG playerId);

	[Token(Token = "0x600CDC2")]
	protected abstract UIHUDUGC_BaseLeaderboard_TeamItemController GetTeamItem(int teamIndex);

	[Token(Token = "0x600CDC3")]
	[Address(RVA = "0x2224D58", Offset = "0x2224D58", VA = "0x2224D58", Slot = "37")]
	protected virtual void InitViewData()
	{
	}

	[Token(Token = "0x600CDC4")]
	[Address(RVA = "0x2224DAC", Offset = "0x2224DAC", VA = "0x2224DAC", Slot = "38")]
	protected virtual void UpdateAllTeammateItemInfo()
	{
	}

	[Token(Token = "0x600CDC5")]
	[Address(RVA = "0x2224E00", Offset = "0x2224E00", VA = "0x2224E00", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CDC6")]
	[Address(RVA = "0x2224EFC", Offset = "0x2224EFC", VA = "0x2224EFC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CDC7")]
	[Address(RVA = "0x2224F8C", Offset = "0x2224F8C", VA = "0x2224F8C")]
	private void Update()
	{
	}

	[Token(Token = "0x600CDC8")]
	[Address(RVA = "0x2225028", Offset = "0x2225028", VA = "0x2225028")]
	protected UIHUDUGC_BaseLeaderboard_TeammateItemController AddTeammateItem(Player player)
	{
		return null;
	}

	[Token(Token = "0x600CDC9")]
	[Address(RVA = "0x2225194", Offset = "0x2225194", VA = "0x2225194")]
	protected bool IsSelfTeamIndex(uint teamIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600CDCA")]
	[Address(RVA = "0x2225208", Offset = "0x2225208", VA = "0x2225208")]
	private void OnAddPlayer(object[] param)
	{
	}

	[Token(Token = "0x600CDCB")]
	[Address(RVA = "0x2225400", Offset = "0x2225400", VA = "0x2225400", Slot = "39")]
	public virtual void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CDCC")]
	[Address(RVA = "0x2225460", Offset = "0x2225460", VA = "0x2225460", Slot = "40")]
	public virtual void DestroyEntity()
	{
	}

	[Token(Token = "0x600CDCD")]
	[Address(RVA = "0x22254B4", Offset = "0x22254B4", VA = "0x22254B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CDCE")]
	[Address(RVA = "0x22254BC", Offset = "0x22254BC", VA = "0x22254BC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CDCF")]
	[Address(RVA = "0x22254C4", Offset = "0x22254C4", VA = "0x22254C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
