using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20024F7")]
internal class UIBaseProfileInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E57B")]
	[FieldOffset(Offset = "0x28")]
	private UIBaseProfileInfoView m_View;

	[Token(Token = "0x400E57C")]
	[FieldOffset(Offset = "0x2C")]
	public Action BtnCallBack;

	[Token(Token = "0x400E57D")]
	private const uint NIKENAME_GREY_COLOR = 2341178367u;

	[Token(Token = "0x400E57E")]
	[FieldOffset(Offset = "0x30")]
	private BaseItemInfo m_PinItemInfo;

	[Token(Token = "0x400E57F")]
	[FieldOffset(Offset = "0x34")]
	private UISprite[] m_CSStarArray;

	[Token(Token = "0x400E580")]
	[FieldOffset(Offset = "0x38")]
	private UISprite[] m_CSBlackStarArray;

	[Token(Token = "0x400E581")]
	[FieldOffset(Offset = "0x3C")]
	private ESocial.Gender m_Gender;

	[Token(Token = "0x400E582")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_AccountID;

	[Token(Token = "0x400E583")]
	[FieldOffset(Offset = "0x48")]
	private string m_NickName;

	[Token(Token = "0x600D58A")]
	[Address(RVA = "0x140BF08", Offset = "0x140BF08", VA = "0x140BF08")]
	public UIBaseProfileInfoController()
	{
	}

	[Token(Token = "0x600D58B")]
	[Address(RVA = "0x140BFDC", Offset = "0x140BFDC", VA = "0x140BFDC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D58C")]
	[Address(RVA = "0x140C080", Offset = "0x140C080", VA = "0x140C080", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D58D")]
	[Address(RVA = "0x140CD54", Offset = "0x140CD54", VA = "0x140CD54")]
	public void SetBoxColliderDisabled()
	{
	}

	[Token(Token = "0x600D58E")]
	[Address(RVA = "0x140CE6C", Offset = "0x140CE6C", VA = "0x140CE6C")]
	public void UpdateLevelRankUI(bool showLevel, bool showRank)
	{
	}

	[Token(Token = "0x600D58F")]
	[Address(RVA = "0x140CEDC", Offset = "0x140CEDC", VA = "0x140CEDC")]
	public void SetBRUIData(uint rank, uint peakRankPos)
	{
	}

	[Token(Token = "0x600D590")]
	[Address(RVA = "0x140CF4C", Offset = "0x140CF4C", VA = "0x140CF4C")]
	public void SetCSUIdata(uint rank, uint peakRankPos)
	{
	}

	[Token(Token = "0x600D591")]
	[Address(RVA = "0x140CFBC", Offset = "0x140CFBC", VA = "0x140CFBC")]
	public void SetPeriodicUIData(uint rank)
	{
	}

	[Token(Token = "0x600D592")]
	[Address(RVA = "0x140D018", Offset = "0x140D018", VA = "0x140D018")]
	public void SetCSUIwithScore(uint rank, uint rankpoint, uint peakRankPos)
	{
	}

	[Token(Token = "0x600D593")]
	[Address(RVA = "0x140D08C", Offset = "0x140D08C", VA = "0x140D08C")]
	public void SetPeriodicUIwithScore(uint rank, uint rankpoint)
	{
	}

	[Token(Token = "0x600D594")]
	[Address(RVA = "0x140D0FC", Offset = "0x140D0FC", VA = "0x140D0FC")]
	public void SetBRUIwithScore(uint rank, uint rankpoint, uint peakRankPos)
	{
	}

	[Token(Token = "0x600D595")]
	[Address(RVA = "0x140D170", Offset = "0x140D170", VA = "0x140D170")]
	public void SetGender(ESocial.Gender gender)
	{
	}

	[Token(Token = "0x600D596")]
	[Address(RVA = "0x140D1DC", Offset = "0x140D1DC", VA = "0x140D1DC")]
	private void UpdateGender()
	{
	}

	[Token(Token = "0x600D597")]
	[Address(RVA = "0x140D438", Offset = "0x140D438", VA = "0x140D438")]
	public void SetUIData(BaseProfileInfo data, uint showState = 0u)
	{
	}

	[Token(Token = "0x600D598")]
	[Address(RVA = "0x140EEB4", Offset = "0x140EEB4", VA = "0x140EEB4")]
	public void UpdatePin(uint pinId)
	{
	}

	[Token(Token = "0x600D599")]
	[Address(RVA = "0x140F460", Offset = "0x140F460", VA = "0x140F460")]
	public void SetPinIconState(bool value, bool isBigIcon = false)
	{
	}

	[Token(Token = "0x600D59A")]
	[Address(RVA = "0x140F538", Offset = "0x140F538", VA = "0x140F538")]
	private void OnBtnPinClick()
	{
	}

	[Token(Token = "0x600D59B")]
	[Address(RVA = "0x140F128", Offset = "0x140F128", VA = "0x140F128")]
	public void UpdateBanner(uint bannerId)
	{
	}

	[Token(Token = "0x600D59C")]
	[Address(RVA = "0x140F6B4", Offset = "0x140F6B4", VA = "0x140F6B4")]
	public void UpdateBanner(BannerData bannerdata, bool isBrief = false)
	{
	}

	[Token(Token = "0x600D59D")]
	[Address(RVA = "0x140F940", Offset = "0x140F940", VA = "0x140F940")]
	public void UpdateHeadPic(HeadPicData data)
	{
	}

	[Token(Token = "0x600D59E")]
	[Address(RVA = "0x140FAC4", Offset = "0x140FAC4", VA = "0x140FAC4")]
	public void ResetBanner()
	{
	}

	[Token(Token = "0x600D59F")]
	[Address(RVA = "0x140FBAC", Offset = "0x140FBAC", VA = "0x140FBAC")]
	public void ResetHeadPic()
	{
	}

	[Token(Token = "0x600D5A0")]
	[Address(RVA = "0x140FC94", Offset = "0x140FC94", VA = "0x140FC94")]
	public void ResetPin()
	{
	}

	[Token(Token = "0x600D5A1")]
	[Address(RVA = "0x140FD44", Offset = "0x140FD44", VA = "0x140FD44")]
	public void ShowClanName(bool v)
	{
	}

	[Token(Token = "0x600D5A2")]
	[Address(RVA = "0x140FDFC", Offset = "0x140FDFC", VA = "0x140FDFC")]
	public void ShowOnlineStatus(bool v)
	{
	}

	[Token(Token = "0x600D5A3")]
	[Address(RVA = "0x140FEB4", Offset = "0x140FEB4", VA = "0x140FEB4")]
	public void ShowRank(bool v)
	{
	}

	[Token(Token = "0x600D5A4")]
	[Address(RVA = "0x140FF6C", Offset = "0x140FF6C", VA = "0x140FF6C")]
	public void ShowInfoContainer(bool v)
	{
	}

	[Token(Token = "0x600D5A5")]
	[Address(RVA = "0x1410004", Offset = "0x1410004", VA = "0x1410004")]
	public void OnHeadBtnClick()
	{
	}

	[Token(Token = "0x600D5A6")]
	[Address(RVA = "0x140F3A0", Offset = "0x140F3A0", VA = "0x140F3A0")]
	public void UpdateScrollText()
	{
	}

	[Token(Token = "0x600D5A7")]
	[Address(RVA = "0x140F2D4", Offset = "0x140F2D4", VA = "0x140F2D4")]
	public void UpdateRank(int rank, uint peakRankPos)
	{
	}

	[Token(Token = "0x600D5A8")]
	[Address(RVA = "0x140F344", Offset = "0x140F344", VA = "0x140F344")]
	public void UpdateRank(BaseProfileInfo data)
	{
	}

	[Token(Token = "0x600D5A9")]
	[Address(RVA = "0x1410180", Offset = "0x1410180", VA = "0x1410180")]
	public void EnableHeadClick(bool enabled)
	{
	}

	[Token(Token = "0x600D5AA")]
	[Address(RVA = "0x1410218", Offset = "0x1410218", VA = "0x1410218")]
	private void UpdateNickNameAndAlias()
	{
	}

	[Token(Token = "0x600D5AB")]
	[Address(RVA = "0x1410500", Offset = "0x1410500", VA = "0x1410500")]
	public void ShowLadderRankChangeEffect()
	{
	}

	[Token(Token = "0x600D5AC")]
	[Address(RVA = "0x14105C8", Offset = "0x14105C8", VA = "0x14105C8", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D5AD")]
	[Address(RVA = "0x141065C", Offset = "0x141065C", VA = "0x141065C", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D5AE")]
	[Address(RVA = "0x1410728", Offset = "0x1410728", VA = "0x1410728")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
