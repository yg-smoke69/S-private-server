using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200215F")]
internal class UILadderMatchLeaderboardItemController : UIEasyListItemController
{
	[Token(Token = "0x400D19D")]
	[FieldOffset(Offset = "0x38")]
	private LadderMatchLeaderboardItemView m_View;

	[Token(Token = "0x400D19E")]
	[FieldOffset(Offset = "0x3C")]
	private LeaderBoardInfo m_Info;

	[Token(Token = "0x400D19F")]
	[FieldOffset(Offset = "0x40")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x400D1A0")]
	private const int m_TopRankThreshold = 3;

	[Token(Token = "0x400D1A1")]
	[FieldOffset(Offset = "0x44")]
	private GameObject[] m_TopCupArray;

	[Token(Token = "0x400D1A2")]
	[FieldOffset(Offset = "0x48")]
	private GameObject[] m_TopBgArray;

	[Token(Token = "0x600B062")]
	[Address(RVA = "0x1AF189C", Offset = "0x1AF189C", VA = "0x1AF189C")]
	public UILadderMatchLeaderboardItemController()
	{
	}

	[Token(Token = "0x600B063")]
	[Address(RVA = "0x1AF18A4", Offset = "0x1AF18A4", VA = "0x1AF18A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B064")]
	[Address(RVA = "0x1AF1948", Offset = "0x1AF1948", VA = "0x1AF1948", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B065")]
	[Address(RVA = "0x1AF1E2C", Offset = "0x1AF1E2C", VA = "0x1AF1E2C")]
	public void ShowTopVFX(bool value)
	{
	}

	[Token(Token = "0x600B066")]
	[Address(RVA = "0x1AF1F74", Offset = "0x1AF1F74", VA = "0x1AF1F74", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600B067")]
	[Address(RVA = "0x1AF2204", Offset = "0x1AF2204", VA = "0x1AF2204", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B068")]
	[Address(RVA = "0x1AF1010", Offset = "0x1AF1010", VA = "0x1AF1010")]
	public void SetSelfUI(bool isRegion)
	{
	}

	[Token(Token = "0x600B069")]
	[Address(RVA = "0x1AF2D20", Offset = "0x1AF2D20", VA = "0x1AF2D20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B06A")]
	[Address(RVA = "0x1AF2D28", Offset = "0x1AF2D28", VA = "0x1AF2D28")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
