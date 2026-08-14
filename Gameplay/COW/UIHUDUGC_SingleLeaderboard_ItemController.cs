using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002476")]
internal class UIHUDUGC_SingleLeaderboard_ItemController : UIHUDUGC_BaseLeaderboard_TeammateItemController
{
	[Token(Token = "0x400E244")]
	[FieldOffset(Offset = "0x3C")]
	private UIHUDUGC_SingleLeaderboard_ItemView m_View;

	[Token(Token = "0x400E245")]
	[FieldOffset(Offset = "0x40")]
	private List<int> m_ScoreTypes;

	[Token(Token = "0x400E246")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<int, UILabel> m_LabelDict;

	[Token(Token = "0x600CFC6")]
	[Address(RVA = "0x292196C", Offset = "0x292196C", VA = "0x292196C")]
	public UIHUDUGC_SingleLeaderboard_ItemController()
	{
	}

	[Token(Token = "0x600CFC7")]
	[Address(RVA = "0x29219F8", Offset = "0x29219F8", VA = "0x29219F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CFC8")]
	[Address(RVA = "0x2921AA0", Offset = "0x2921AA0", VA = "0x2921AA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CFC9")]
	[Address(RVA = "0x292046C", Offset = "0x292046C", VA = "0x292046C")]
	public void SetScoreType(List<int> scoreTypes)
	{
	}

	[Token(Token = "0x600CFCA")]
	[Address(RVA = "0x2921B94", Offset = "0x2921B94", VA = "0x2921B94", Slot = "38")]
	protected override void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	[Token(Token = "0x600CFCB")]
	[Address(RVA = "0x29220D0", Offset = "0x29220D0", VA = "0x29220D0", Slot = "39")]
	public override void RefreshInfo(CBNPMCENMKE infoType)
	{
	}

	[Token(Token = "0x600CFCC")]
	[Address(RVA = "0x292221C", Offset = "0x292221C", VA = "0x292221C", Slot = "40")]
	public override void RefreshAllInfo()
	{
	}

	[Token(Token = "0x600CFCD")]
	[Address(RVA = "0x291FED4", Offset = "0x291FED4", VA = "0x291FED4")]
	public void SetTeamRank(int rank)
	{
	}

	[Token(Token = "0x600CFCE")]
	[Address(RVA = "0x2922468", Offset = "0x2922468", VA = "0x2922468", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600CFCF")]
	[Address(RVA = "0x291E79C", Offset = "0x291E79C", VA = "0x291E79C")]
	public void ShowSelfBg(bool show)
	{
	}

	[Token(Token = "0x600CFD0")]
	[Address(RVA = "0x2922688", Offset = "0x2922688", VA = "0x2922688")]
	public bool IsLocalPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x600CFD1")]
	[Address(RVA = "0x2922788", Offset = "0x2922788", VA = "0x2922788")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CFD2")]
	[Address(RVA = "0x2922790", Offset = "0x2922790", VA = "0x2922790")]
	public void _003C_003EiFixBaseProxy_ShowProfileInfo(BaseProfileInfo P0)
	{
	}

	[Token(Token = "0x600CFD3")]
	[Address(RVA = "0x2922798", Offset = "0x2922798", VA = "0x2922798")]
	public void _003C_003EiFixBaseProxy_RefreshInfo(CBNPMCENMKE P0)
	{
	}

	[Token(Token = "0x600CFD4")]
	[Address(RVA = "0x29227A0", Offset = "0x29227A0", VA = "0x29227A0")]
	public void _003C_003EiFixBaseProxy_RefreshAllInfo()
	{
	}

	[Token(Token = "0x600CFD5")]
	[Address(RVA = "0x29227A8", Offset = "0x29227A8", VA = "0x29227A8")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
