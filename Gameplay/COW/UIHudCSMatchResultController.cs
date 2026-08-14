using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200221A")]
internal class UIHudCSMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x200221B")]
	private sealed class _003CCheckIsWinTeamPlayerForSpectator_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D51F")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG playerID;

		[Token(Token = "0x600B8B1")]
		[Address(RVA = "0x1F181C0", Offset = "0x1F181C0", VA = "0x1F181C0")]
		public _003CCheckIsWinTeamPlayerForSpectator_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B8B2")]
		[Address(RVA = "0x1F18214", Offset = "0x1F18214", VA = "0x1F18214")]
		internal bool _003C_003Em__0(TeamData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600B8A7")]
	[Address(RVA = "0x1F17BE8", Offset = "0x1F17BE8", VA = "0x1F17BE8")]
	public UIHudCSMatchResultController()
	{
	}

	[Token(Token = "0x600B8A8")]
	[Address(RVA = "0x1F17BF0", Offset = "0x1F17BF0", VA = "0x1F17BF0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B8A9")]
	[Address(RVA = "0x1F17C98", Offset = "0x1F17C98", VA = "0x1F17C98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B8AA")]
	[Address(RVA = "0x1F17D04", Offset = "0x1F17D04", VA = "0x1F17D04", Slot = "43")]
	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return default(int);
	}

	[Token(Token = "0x600B8AB")]
	[Address(RVA = "0x1F17DE8", Offset = "0x1F17DE8", VA = "0x1F17DE8", Slot = "44")]
	protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return default(int);
	}

	[Token(Token = "0x600B8AC")]
	[Address(RVA = "0x1F17ECC", Offset = "0x1F17ECC", VA = "0x1F17ECC", Slot = "54")]
	protected override bool CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B8AD")]
	[Address(RVA = "0x1F181C8", Offset = "0x1F181C8", VA = "0x1F181C8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B8AE")]
	[Address(RVA = "0x1F181D0", Offset = "0x1F181D0", VA = "0x1F181D0")]
	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return default(int);
	}

	[Token(Token = "0x600B8AF")]
	[Address(RVA = "0x1F181D8", Offset = "0x1F181D8", VA = "0x1F181D8")]
	public int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return default(int);
	}

	[Token(Token = "0x600B8B0")]
	[Address(RVA = "0x1F181E0", Offset = "0x1F181E0", VA = "0x1F181E0")]
	public new bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG P0)
	{
		return default(bool);
	}
}
