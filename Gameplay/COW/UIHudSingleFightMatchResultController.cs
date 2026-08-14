using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002251")]
internal class UIHudSingleFightMatchResultController : UIHudMatchResultBaseController, _Attribute
{
	[Token(Token = "0x400D6DC")]
	[FieldOffset(Offset = "0x18C")]
	protected UIHudSingleFightMatchResultView m_View;

	[Token(Token = "0x400D6DD")]
	[FieldOffset(Offset = "0x190")]
	private UIHudSingleFightMatchResultItemController m_SelfUIItem;

	[Token(Token = "0x400D6DE")]
	[FieldOffset(Offset = "0x194")]
	protected int m_LocalPlayerItemIndex;

	[Token(Token = "0x400D6DF")]
	private const int ShowSelfItemRank = 4;

	[Token(Token = "0x400D6E0")]
	private const int ShowAvatarPlayerRank = 3;

	[Token(Token = "0x400D6E1")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001083")]
	public int LocalPlayerItemIndex
	{
		[Token(Token = "0x600BAFA")]
		[Address(RVA = "0x16BC908", Offset = "0x16BC908", VA = "0x16BC908")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600BAF8")]
	[Address(RVA = "0x16BC834", Offset = "0x16BC834", VA = "0x16BC834")]
	public UIHudSingleFightMatchResultController()
	{
	}

	[Token(Token = "0x600BAF9")]
	[Address(RVA = "0x16BC860", Offset = "0x16BC860", VA = "0x16BC860")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BAFB")]
	[Address(RVA = "0x16BC960", Offset = "0x16BC960", VA = "0x16BC960", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BAFC")]
	[Address(RVA = "0x16BD0B4", Offset = "0x16BD0B4", VA = "0x16BD0B4", Slot = "50")]
	protected override void OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BAFD")]
	[Address(RVA = "0x16BD1E8", Offset = "0x16BD1E8", VA = "0x16BD1E8", Slot = "49")]
	protected override void OnShowDetailUI(bool show)
	{
	}

	[Token(Token = "0x600BAFE")]
	[Address(RVA = "0x16BD48C", Offset = "0x16BD48C", VA = "0x16BD48C", Slot = "59")]
	protected virtual void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x600BAFF")]
	[Address(RVA = "0x16BD584", Offset = "0x16BD584", VA = "0x16BD584", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600BB00")]
	[Address(RVA = "0x16BDE18", Offset = "0x16BDE18", VA = "0x16BDE18", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BB01")]
	[Address(RVA = "0x16BDEE8", Offset = "0x16BDEE8", VA = "0x16BDEE8", Slot = "51")]
	protected override void OnUpdate(float delta)
	{
	}

	[Token(Token = "0x600BB02")]
	[Address(RVA = "0x16BE178", Offset = "0x16BE178", VA = "0x16BE178", Slot = "60")]
	protected virtual PlayerData GetPlayerData(TeammateStats stats)
	{
		return null;
	}

	[Token(Token = "0x600BB03")]
	[Address(RVA = "0x16BE228", Offset = "0x16BE228", VA = "0x16BE228", Slot = "52")]
	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600BB04")]
	[Address(RVA = "0x16BE7E4", Offset = "0x16BE7E4", VA = "0x16BE7E4", Slot = "43")]
	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return default(int);
	}

	[Token(Token = "0x600BB05")]
	[Address(RVA = "0x16BE890", Offset = "0x16BE890", VA = "0x16BE890", Slot = "53")]
	protected override EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return default(EMatchResultIsWin);
	}

	[Token(Token = "0x600BB06")]
	[Address(RVA = "0x16BE8F4", Offset = "0x16BE8F4", VA = "0x16BE8F4", Slot = "55")]
	protected override void OnFixMatchInfoForLanguage()
	{
	}

	[Token(Token = "0x600BB07")]
	[Address(RVA = "0x16BEA34", Offset = "0x16BEA34", VA = "0x16BEA34", Slot = "61")]
	protected virtual UIHudSingleFightMatchResultItemController OpenItemController(TeammateStats data, bool single)
	{
		return null;
	}

	[Token(Token = "0x600BB08")]
	[Address(RVA = "0x16BEB24", Offset = "0x16BEB24", VA = "0x16BEB24", Slot = "62")]
	protected virtual List<TeammateStats> ProcesssStatesList(List<TeammateStats> orgList, ulong localAccountID)
	{
		return null;
	}

	[Token(Token = "0x600BB09")]
	[Address(RVA = "0x16BDAAC", Offset = "0x16BDAAC", VA = "0x16BDAAC")]
	protected void UpdatePlayerListInfo(List<TeammateStats> players, ulong localplayerID)
	{
	}

	[Token(Token = "0x600BB0A")]
	[Address(RVA = "0x16BEC94", Offset = "0x16BEC94", VA = "0x16BEC94", Slot = "63")]
	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BB0B")]
	[Address(RVA = "0x16BEE98", Offset = "0x16BEE98", VA = "0x16BEE98", Slot = "58")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600BB0C")]
	[Address(RVA = "0x16BEF14", Offset = "0x16BEF14", VA = "0x16BEF14")]
	private static int _003CProcesssStatesList_003Em__0(TeammateStats a, TeammateStats b)
	{
		return default(int);
	}

	[Token(Token = "0x600BB0D")]
	[Address(RVA = "0x16BEF5C", Offset = "0x16BEF5C", VA = "0x16BEF5C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BB0E")]
	[Address(RVA = "0x16BEF64", Offset = "0x16BEF64", VA = "0x16BEF64")]
	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	[Token(Token = "0x600BB0F")]
	[Address(RVA = "0x16BEF6C", Offset = "0x16BEF6C", VA = "0x16BEF6C")]
	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	[Token(Token = "0x600BB10")]
	[Address(RVA = "0x16BEF74", Offset = "0x16BEF74", VA = "0x16BEF74")]
	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	[Token(Token = "0x600BB11")]
	[Address(RVA = "0x16BEF7C", Offset = "0x16BEF7C", VA = "0x16BEF7C")]
	public int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BB12")]
	[Address(RVA = "0x16BEF84", Offset = "0x16BEF84", VA = "0x16BEF84")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0)
	{
	}

	[Token(Token = "0x600BB13")]
	[Address(RVA = "0x16BEF8C", Offset = "0x16BEF8C", VA = "0x16BEF8C")]
	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}

	[Token(Token = "0x600BB14")]
	[Address(RVA = "0x16BEF94", Offset = "0x16BEF94", VA = "0x16BEF94")]
	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return default(int);
	}

	[Token(Token = "0x600BB15")]
	[Address(RVA = "0x16BEF9C", Offset = "0x16BEF9C", VA = "0x16BEF9C")]
	public EMatchResultIsWin _003C_003EiFixBaseProxy_CheckIsWin(MatchStats P0)
	{
		return default(EMatchResultIsWin);
	}

	[Token(Token = "0x600BB16")]
	[Address(RVA = "0x16BEFA4", Offset = "0x16BEFA4", VA = "0x16BEFA4")]
	public void _003C_003EiFixBaseProxy_OnFixMatchInfoForLanguage()
	{
	}
}
