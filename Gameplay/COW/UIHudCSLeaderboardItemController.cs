using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002045")]
internal class UIHudCSLeaderboardItemController : UIHUDTeamBattleScoreBoardItemController
{
	[Token(Token = "0x400CA4C")]
	[FieldOffset(Offset = "0x48")]
	private LeaderboardData m_Data;

	[Token(Token = "0x17000FD7")]
	public LeaderboardData DataInfo
	{
		[Token(Token = "0x600A417")]
		[Address(RVA = "0x1F12950", Offset = "0x1F12950", VA = "0x1F12950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A416")]
	[Address(RVA = "0x1F129F8", Offset = "0x1F129F8", VA = "0x1F129F8")]
	public UIHudCSLeaderboardItemController()
	{
	}

	[Token(Token = "0x600A418")]
	[Address(RVA = "0x1F12A00", Offset = "0x1F12A00", VA = "0x1F12A00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A419")]
	[Address(RVA = "0x1F12AC4", Offset = "0x1F12AC4", VA = "0x1F12AC4", Slot = "31")]
	protected override void OnInitData(Player player)
	{
	}

	[Token(Token = "0x600A41A")]
	[Address(RVA = "0x1F131F4", Offset = "0x1F131F4", VA = "0x1F131F4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A41B")]
	[Address(RVA = "0x1F1329C", Offset = "0x1F1329C", VA = "0x1F1329C", Slot = "33")]
	protected override void OnKillChange(int kill)
	{
	}

	[Token(Token = "0x600A41C")]
	[Address(RVA = "0x1F13318", Offset = "0x1F13318", VA = "0x1F13318", Slot = "34")]
	protected override void OnDeadChange(int dead)
	{
	}

	[Token(Token = "0x600A41D")]
	[Address(RVA = "0x1F133A0", Offset = "0x1F133A0", VA = "0x1F133A0", Slot = "35")]
	protected override void OnDamageChange(uint damage)
	{
	}

	[Token(Token = "0x600A41E")]
	[Address(RVA = "0x1F12C80", Offset = "0x1F12C80", VA = "0x1F12C80")]
	public void SetRankInfo(int rankLevel, int peakRankPos, int rankPoint)
	{
	}

	[Token(Token = "0x600A41F")]
	[Address(RVA = "0x1F13428", Offset = "0x1F13428", VA = "0x1F13428")]
	private void RefreshRankIcon(ResourceID resId)
	{
	}

	[Token(Token = "0x600A420")]
	[Address(RVA = "0x1F13630", Offset = "0x1F13630", VA = "0x1F13630")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A421")]
	[Address(RVA = "0x1F13638", Offset = "0x1F13638", VA = "0x1F13638")]
	public void _003C_003EiFixBaseProxy_OnInitData(Player P0)
	{
	}

	[Token(Token = "0x600A422")]
	[Address(RVA = "0x1F13640", Offset = "0x1F13640", VA = "0x1F13640")]
	public void _003C_003EiFixBaseProxy_OnKillChange(int P0)
	{
	}

	[Token(Token = "0x600A423")]
	[Address(RVA = "0x1F13648", Offset = "0x1F13648", VA = "0x1F13648")]
	public void _003C_003EiFixBaseProxy_OnDeadChange(int P0)
	{
	}

	[Token(Token = "0x600A424")]
	[Address(RVA = "0x1F13650", Offset = "0x1F13650", VA = "0x1F13650")]
	public void _003C_003EiFixBaseProxy_OnDamageChange(uint P0)
	{
	}
}
