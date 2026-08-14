using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x200290E")]
public class UILoadingPlayerInfoController : MonoBehaviour
{
	[Token(Token = "0x400FCD0")]
	[FieldOffset(Offset = "0xC")]
	private UILoadingPlayerInfoView m_View;

	[Token(Token = "0x400FCD1")]
	[FieldOffset(Offset = "0x10")]
	private List<UILoadingPlayerInfoItemController> m_InfoItemCtrls;

	[Token(Token = "0x400FCD2")]
	[FieldOffset(Offset = "0x14")]
	private List<UIProfileTagSmallController> m_ListTagCtrls;

	[Token(Token = "0x400FCD3")]
	private const int COUNT_BATTLE_TAG = 2;

	[Token(Token = "0x400FCD4")]
	[FieldOffset(Offset = "0x18")]
	private Color m_SelfColor;

	[Token(Token = "0x400FCD5")]
	[FieldOffset(Offset = "0x28")]
	private Color m_OtherColor;

	[Token(Token = "0x6010469")]
	[Address(RVA = "0x2158F8C", Offset = "0x2158F8C", VA = "0x2158F8C")]
	public UILoadingPlayerInfoController()
	{
	}

	[Token(Token = "0x601046A")]
	[Address(RVA = "0x2158980", Offset = "0x2158980", VA = "0x2158980")]
	public void SetView(UILoadingPlayerInfoView view)
	{
	}

	[Token(Token = "0x601046B")]
	[Address(RVA = "0x2158AA0", Offset = "0x2158AA0", VA = "0x2158AA0")]
	public void SetViewDataByTcpNtf(MatchPregameInfo info)
	{
	}

	[Token(Token = "0x601046C")]
	[Address(RVA = "0x2159558", Offset = "0x2159558", VA = "0x2159558")]
	public void SetHeadIconAndNickName(uint headIconId, string nickName, ulong accountId)
	{
	}

	[Token(Token = "0x601046D")]
	[Address(RVA = "0x215999C", Offset = "0x215999C", VA = "0x215999C")]
	public void SetEP(bool boughtEP, uint epBadgeId, uint countEPBadge)
	{
	}

	[Token(Token = "0x601046E")]
	[Address(RVA = "0x2159B7C", Offset = "0x2159B7C", VA = "0x2159B7C")]
	public void SetRank(uint rank, uint rankingPoints, uint[] heroicSeasons)
	{
	}

	[Token(Token = "0x601046F")]
	[Address(RVA = "0x215B1A0", Offset = "0x215B1A0", VA = "0x215B1A0")]
	private void RefreshSpriteFormerMaster(uint[] heroicSeasons)
	{
	}

	[Token(Token = "0x6010470")]
	[Address(RVA = "0x215A048", Offset = "0x215A048", VA = "0x215A048")]
	public void SetCharacter(uint avatarId)
	{
	}

	[Token(Token = "0x6010471")]
	[Address(RVA = "0x215AB48", Offset = "0x215AB48", VA = "0x215AB48")]
	public void SetInfoData(uint[] infoArray, [Optional] StatsInfo statsInfo, bool ignoreDefault = false, bool showPlaceHolder = false, bool showRefreshAnim = false)
	{
	}

	[Token(Token = "0x6010472")]
	[Address(RVA = "0x2158FFC", Offset = "0x2158FFC", VA = "0x2158FFC")]
	private void PrepareInfoItems()
	{
	}

	[Token(Token = "0x6010473")]
	[Address(RVA = "0x21592FC", Offset = "0x21592FC", VA = "0x21592FC")]
	private void PrepareBattleTags()
	{
	}

	[Token(Token = "0x6010474")]
	[Address(RVA = "0x215A508", Offset = "0x215A508", VA = "0x215A508")]
	public void RefreshBattleTags(List<BattleTagInfo> battleTags)
	{
	}

	[Token(Token = "0x6010475")]
	[Address(RVA = "0x215A1CC", Offset = "0x215A1CC", VA = "0x215A1CC")]
	public void RefreshBg(ulong accountId)
	{
	}
}
