using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002445")]
internal abstract class UIHUDUGC_BaseLeaderboard_TeammateItemController : UIEasyListItemController
{
	[Token(Token = "0x400E177")]
	[FieldOffset(Offset = "0x38")]
	protected Player m_Player;

	[Token(Token = "0x600CDB5")]
	[Address(RVA = "0x22256BC", Offset = "0x22256BC", VA = "0x22256BC")]
	protected UIHUDUGC_BaseLeaderboard_TeammateItemController()
	{
	}

	[Token(Token = "0x600CDB6")]
	[Address(RVA = "0x22256C4", Offset = "0x22256C4", VA = "0x22256C4")]
	public void SetPlayer(Player player)
	{
	}

	[Token(Token = "0x600CDB7")]
	[Address(RVA = "0x2225824", Offset = "0x2225824", VA = "0x2225824", Slot = "37")]
	protected virtual void SetSelf(bool isSelf)
	{
	}

	[Token(Token = "0x600CDB8")]
	[Address(RVA = "0x2225880", Offset = "0x2225880", VA = "0x2225880", Slot = "38")]
	protected virtual void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	[Token(Token = "0x600CDB9")]
	[Address(RVA = "0x22258DC", Offset = "0x22258DC", VA = "0x22258DC", Slot = "39")]
	public virtual void RefreshInfo(CBNPMCENMKE infoType)
	{
	}

	[Token(Token = "0x600CDBA")]
	[Address(RVA = "0x2225938", Offset = "0x2225938", VA = "0x2225938", Slot = "40")]
	public virtual void RefreshAllInfo()
	{
	}

	[Token(Token = "0x600CDBB")]
	[Address(RVA = "0x222598C", Offset = "0x222598C", VA = "0x222598C")]
	protected int GetInfoValue(CBNPMCENMKE infoType)
	{
		return default(int);
	}

	[Token(Token = "0x600CDBC")]
	[Address(RVA = "0x2225BC4", Offset = "0x2225BC4", VA = "0x2225BC4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}
}
