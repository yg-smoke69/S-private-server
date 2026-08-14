using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200221E")]
internal class UIHudGuildWarMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x600B8BF")]
	[Address(RVA = "0x133ED70", Offset = "0x133ED70", VA = "0x133ED70")]
	public UIHudGuildWarMatchResultController()
	{
	}

	[Token(Token = "0x600B8C0")]
	[Address(RVA = "0x133ED78", Offset = "0x133ED78", VA = "0x133ED78")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B8C1")]
	[Address(RVA = "0x133EE20", Offset = "0x133EE20", VA = "0x133EE20", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B8C2")]
	[Address(RVA = "0x133EEF0", Offset = "0x133EEF0", VA = "0x133EEF0", Slot = "52")]
	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600B8C3")]
	[Address(RVA = "0x133F300", Offset = "0x133F300", VA = "0x133F300", Slot = "43")]
	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return default(int);
	}

	[Token(Token = "0x600B8C4")]
	[Address(RVA = "0x133F3B0", Offset = "0x133F3B0", VA = "0x133F3B0", Slot = "58")]
	protected override Transform GetItemTransform(bool localTeam, int index)
	{
		return null;
	}

	[Token(Token = "0x600B8C5")]
	[Address(RVA = "0x133F468", Offset = "0x133F468", VA = "0x133F468")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B8C6")]
	[Address(RVA = "0x133F470", Offset = "0x133F470", VA = "0x133F470")]
	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600B8C7")]
	[Address(RVA = "0x133F478", Offset = "0x133F478", VA = "0x133F478")]
	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return default(int);
	}

	[Token(Token = "0x600B8C8")]
	[Address(RVA = "0x133F480", Offset = "0x133F480", VA = "0x133F480")]
	public Transform _003C_003EiFixBaseProxy_GetItemTransform(bool P0, int P1)
	{
		return null;
	}
}
