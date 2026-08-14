using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002217")]
internal class UIHudBombMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x2002218")]
	private sealed class _003CCheckIsWinTeamPlayerForSpectator_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D51E")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG playerID;

		[Token(Token = "0x600B8A1")]
		[Address(RVA = "0x1E12C50", Offset = "0x1E12C50", VA = "0x1E12C50")]
		public _003CCheckIsWinTeamPlayerForSpectator_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B8A2")]
		[Address(RVA = "0x1E12CAC", Offset = "0x1E12CAC", VA = "0x1E12CAC")]
		internal bool _003C_003Em__0(TeamData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600B895")]
	[Address(RVA = "0x1E12000", Offset = "0x1E12000", VA = "0x1E12000")]
	public UIHudBombMatchResultController()
	{
	}

	[Token(Token = "0x600B896")]
	[Address(RVA = "0x1E12008", Offset = "0x1E12008", VA = "0x1E12008")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B897")]
	[Address(RVA = "0x1E120B0", Offset = "0x1E120B0", VA = "0x1E120B0", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B898")]
	[Address(RVA = "0x1E121D0", Offset = "0x1E121D0", VA = "0x1E121D0", Slot = "43")]
	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return default(int);
	}

	[Token(Token = "0x600B899")]
	[Address(RVA = "0x1E122B4", Offset = "0x1E122B4", VA = "0x1E122B4", Slot = "44")]
	protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return default(int);
	}

	[Token(Token = "0x600B89A")]
	[Address(RVA = "0x1E12398", Offset = "0x1E12398", VA = "0x1E12398", Slot = "52")]
	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600B89B")]
	[Address(RVA = "0x1E1295C", Offset = "0x1E1295C", VA = "0x1E1295C", Slot = "54")]
	protected override bool CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B89C")]
	[Address(RVA = "0x1E12C58", Offset = "0x1E12C58", VA = "0x1E12C58")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B89D")]
	[Address(RVA = "0x1E12C60", Offset = "0x1E12C60", VA = "0x1E12C60")]
	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return default(int);
	}

	[Token(Token = "0x600B89E")]
	[Address(RVA = "0x1E12C68", Offset = "0x1E12C68", VA = "0x1E12C68")]
	public int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return default(int);
	}

	[Token(Token = "0x600B89F")]
	[Address(RVA = "0x1E12C70", Offset = "0x1E12C70", VA = "0x1E12C70")]
	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600B8A0")]
	[Address(RVA = "0x1E12C78", Offset = "0x1E12C78", VA = "0x1E12C78")]
	public new bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(IHAAMHPPLMG P0)
	{
		return default(bool);
	}
}
