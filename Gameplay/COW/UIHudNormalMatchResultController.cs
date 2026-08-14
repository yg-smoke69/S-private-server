using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200224F")]
internal class UIHudNormalMatchResultController : UIHudMatchResultBaseController
{
	[Token(Token = "0x400D6D5")]
	[FieldOffset(Offset = "0x18C")]
	private UIHudNormalMatchResultView m_View;

	[Token(Token = "0x600BAD6")]
	[Address(RVA = "0x1F535AC", Offset = "0x1F535AC", VA = "0x1F535AC")]
	public UIHudNormalMatchResultController()
	{
	}

	[Token(Token = "0x600BAD7")]
	[Address(RVA = "0x1F535CC", Offset = "0x1F535CC", VA = "0x1F535CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BAD8")]
	[Address(RVA = "0x1F53674", Offset = "0x1F53674", VA = "0x1F53674", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BAD9")]
	[Address(RVA = "0x1F53E90", Offset = "0x1F53E90", VA = "0x1F53E90", Slot = "50")]
	protected override void OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BADA")]
	[Address(RVA = "0x1F53FF4", Offset = "0x1F53FF4", VA = "0x1F53FF4", Slot = "53")]
	protected override EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return default(EMatchResultIsWin);
	}

	[Token(Token = "0x600BADB")]
	[Address(RVA = "0x1F54074", Offset = "0x1F54074", VA = "0x1F54074", Slot = "47")]
	protected override void OnChangePageType()
	{
	}

	[Token(Token = "0x600BADC")]
	[Address(RVA = "0x1F54C54", Offset = "0x1F54C54", VA = "0x1F54C54")]
	private void UpdateFakeLikes(uint rank)
	{
	}

	[Token(Token = "0x600BADD")]
	[Address(RVA = "0x1F54458", Offset = "0x1F54458", VA = "0x1F54458")]
	private void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x600BADE")]
	[Address(RVA = "0x1F54CC8", Offset = "0x1F54CC8", VA = "0x1F54CC8", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BADF")]
	[Address(RVA = "0x1F56030", Offset = "0x1F56030", VA = "0x1F56030", Slot = "49")]
	protected override void OnShowDetailUI(bool show)
	{
	}

	[Token(Token = "0x600BAE0")]
	[Address(RVA = "0x1F561B4", Offset = "0x1F561B4", VA = "0x1F561B4", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BAE1")]
	[Address(RVA = "0x1F563C4", Offset = "0x1F563C4", VA = "0x1F563C4", Slot = "43")]
	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return default(int);
	}

	[Token(Token = "0x600BAE2")]
	[Address(RVA = "0x1F564B8", Offset = "0x1F564B8", VA = "0x1F564B8", Slot = "44")]
	protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return default(int);
	}

	[Token(Token = "0x600BAE3")]
	[Address(RVA = "0x1F55980", Offset = "0x1F55980", VA = "0x1F55980")]
	private TeammateStats ConstructSelfTeammateData(MatchStats stats)
	{
		return null;
	}

	[Token(Token = "0x600BAE4")]
	[Address(RVA = "0x1F55BFC", Offset = "0x1F55BFC", VA = "0x1F55BFC")]
	private void UpdatePlayerListInfo(List<TeammateStats> players)
	{
	}

	[Token(Token = "0x600BAE5")]
	[Address(RVA = "0x1F565AC", Offset = "0x1F565AC", VA = "0x1F565AC")]
	private Transform GetItemTransform(int index)
	{
		return null;
	}

	[Token(Token = "0x600BAE6")]
	[Address(RVA = "0x1F566A8", Offset = "0x1F566A8", VA = "0x1F566A8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BAE7")]
	[Address(RVA = "0x1F566B0", Offset = "0x1F566B0", VA = "0x1F566B0")]
	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BAE8")]
	[Address(RVA = "0x1F566B8", Offset = "0x1F566B8", VA = "0x1F566B8")]
	public EMatchResultIsWin _003C_003EiFixBaseProxy_CheckIsWin(MatchStats P0)
	{
		return default(EMatchResultIsWin);
	}

	[Token(Token = "0x600BAE9")]
	[Address(RVA = "0x1F566C0", Offset = "0x1F566C0", VA = "0x1F566C0")]
	public void _003C_003EiFixBaseProxy_OnChangePageType()
	{
	}

	[Token(Token = "0x600BAEA")]
	[Address(RVA = "0x1F566C8", Offset = "0x1F566C8", VA = "0x1F566C8")]
	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	[Token(Token = "0x600BAEB")]
	[Address(RVA = "0x1F566D0", Offset = "0x1F566D0", VA = "0x1F566D0")]
	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	[Token(Token = "0x600BAEC")]
	[Address(RVA = "0x1F566D8", Offset = "0x1F566D8", VA = "0x1F566D8")]
	public int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BAED")]
	[Address(RVA = "0x1F566E0", Offset = "0x1F566E0", VA = "0x1F566E0")]
	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return default(int);
	}

	[Token(Token = "0x600BAEE")]
	[Address(RVA = "0x1F566E8", Offset = "0x1F566E8", VA = "0x1F566E8")]
	public int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return default(int);
	}
}
