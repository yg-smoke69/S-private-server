using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200201E")]
public class UIChampionshipTeamCreateFormController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C9AB")]
	[FieldOffset(Offset = "0x48")]
	private NationFlagData m_SelectNationFlag;

	[Token(Token = "0x400C9AC")]
	[FieldOffset(Offset = "0x4C")]
	private HeadPicBaseInfo m_ClanAvatarInfo;

	[Token(Token = "0x400C9AD")]
	[FieldOffset(Offset = "0x50")]
	private BannerBaseInfo m_ClanBannerInfo;

	[Token(Token = "0x400C9AE")]
	[FieldOffset(Offset = "0x54")]
	private UIChampionshipTeamCreateFormView m_View;

	[Token(Token = "0x400C9AF")]
	[FieldOffset(Offset = "0x58")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9B0")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400C9B1")]
	[FieldOffset(Offset = "0x60")]
	private int m_SelectChannelID;

	[Token(Token = "0x400C9B2")]
	[FieldOffset(Offset = "0x64")]
	private EChampionship.TeamScaleType m_TeamScaleType;

	[Token(Token = "0x400C9B3")]
	[FieldOffset(Offset = "0x68")]
	public Action CancelAction;

	[Token(Token = "0x400C9B4")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_IsCreatTing;

	[Token(Token = "0x600A298")]
	[Address(RVA = "0x283BE2C", Offset = "0x283BE2C", VA = "0x283BE2C")]
	public UIChampionshipTeamCreateFormController()
	{
	}

	[Token(Token = "0x600A299")]
	[Address(RVA = "0x283BE34", Offset = "0x283BE34", VA = "0x283BE34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A29A")]
	[Address(RVA = "0x283BED8", Offset = "0x283BED8", VA = "0x283BED8")]
	public void InitUI(EChampionship.TeamScaleType teamScaleType)
	{
	}

	[Token(Token = "0x600A29B")]
	[Address(RVA = "0x283CC6C", Offset = "0x283CC6C", VA = "0x283CC6C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A29C")]
	[Address(RVA = "0x283CEFC", Offset = "0x283CEFC", VA = "0x283CEFC")]
	private void Confirm()
	{
	}

	[Token(Token = "0x600A29D")]
	[Address(RVA = "0x283D528", Offset = "0x283D528", VA = "0x283D528")]
	private void CancelCallBack()
	{
	}

	[Token(Token = "0x600A29E")]
	[Address(RVA = "0x283D360", Offset = "0x283D360", VA = "0x283D360")]
	private string GetFixContactInfo()
	{
		return null;
	}

	[Token(Token = "0x600A29F")]
	[Address(RVA = "0x283D5A4", Offset = "0x283D5A4", VA = "0x283D5A4")]
	private void SelectFlag()
	{
	}

	[Token(Token = "0x600A2A0")]
	[Address(RVA = "0x283D6B4", Offset = "0x283D6B4", VA = "0x283D6B4")]
	private void SelectAvatar()
	{
	}

	[Token(Token = "0x600A2A1")]
	[Address(RVA = "0x283D7C4", Offset = "0x283D7C4", VA = "0x283D7C4")]
	private void SelectBanner()
	{
	}

	[Token(Token = "0x600A2A2")]
	[Address(RVA = "0x283D8D4", Offset = "0x283D8D4", VA = "0x283D8D4")]
	private void SelectChannel()
	{
	}

	[Token(Token = "0x600A2A3")]
	[Address(RVA = "0x283D9E4", Offset = "0x283D9E4", VA = "0x283D9E4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A2A4")]
	[Address(RVA = "0x283DB64", Offset = "0x283DB64", VA = "0x283DB64", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A2A5")]
	[Address(RVA = "0x283DBF8", Offset = "0x283DBF8", VA = "0x283DBF8")]
	private void NationalFlagSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A2A6")]
	[Address(RVA = "0x283DD60", Offset = "0x283DD60", VA = "0x283DD60")]
	private void ClanAvatarSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A2A7")]
	[Address(RVA = "0x283DEE4", Offset = "0x283DEE4", VA = "0x283DEE4")]
	private void ClanBannerSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A2A8")]
	[Address(RVA = "0x283E0AC", Offset = "0x283E0AC", VA = "0x283E0AC")]
	private void ChannelSelectHandler(object[] args)
	{
	}

	[Token(Token = "0x600A2A9")]
	[Address(RVA = "0x283E2CC", Offset = "0x283E2CC", VA = "0x283E2CC")]
	private void _003CInitUI_003Em__0()
	{
	}

	[Token(Token = "0x600A2AA")]
	[Address(RVA = "0x283E368", Offset = "0x283E368", VA = "0x283E368")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
