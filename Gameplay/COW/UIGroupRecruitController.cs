using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026B9")]
public class UIGroupRecruitController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400EEEF")]
	[FieldOffset(Offset = "0x48")]
	private UIGroupRecruitView m_View;

	[Token(Token = "0x400EEF0")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelChat m_ChatModel;

	[Token(Token = "0x400EEF1")]
	[FieldOffset(Offset = "0x50")]
	private UIModelGroup m_GroupModel;

	[Token(Token = "0x400EEF2")]
	[FieldOffset(Offset = "0x54")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EEF3")]
	[FieldOffset(Offset = "0x58")]
	private StringBuilder m_Builder;

	[Token(Token = "0x400EEF4")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_LastInCDState;

	[Token(Token = "0x400EEF5")]
	[FieldOffset(Offset = "0x60")]
	private uint m_WorldDelayCallID;

	[Token(Token = "0x400EEF6")]
	[FieldOffset(Offset = "0x64")]
	private readonly float GREY_ALPHA;

	[Token(Token = "0x400EEF7")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HasWorldToggleInit;

	[Token(Token = "0x400EEF8")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_ModeID;

	[Token(Token = "0x400EEF9")]
	[FieldOffset(Offset = "0x70")]
	private uint m_MatchID;

	[Token(Token = "0x400EEFA")]
	[FieldOffset(Offset = "0x74")]
	private uint m_MapID;

	[Token(Token = "0x400EEFB")]
	[FieldOffset(Offset = "0x78")]
	private uint m_GroupID;

	[Token(Token = "0x400EEFC")]
	[FieldOffset(Offset = "0x7C")]
	private int m_LadderLimitID;

	[Token(Token = "0x400EEFD")]
	[FieldOffset(Offset = "0x80")]
	private uint m_Tag1;

	[Token(Token = "0x400EEFE")]
	[FieldOffset(Offset = "0x84")]
	private uint m_Tag2;

	[Token(Token = "0x400EEFF")]
	[FieldOffset(Offset = "0x88")]
	private List<MultiPopMenuData> m_ModeMenuData;

	[Token(Token = "0x400EF00")]
	[FieldOffset(Offset = "0x8C")]
	private List<MultiPopMenuData> m_MapMenuData;

	[Token(Token = "0x400EF01")]
	[FieldOffset(Offset = "0x90")]
	private List<MultiPopMenuData> m_GroupMenuData;

	[Token(Token = "0x400EF02")]
	[FieldOffset(Offset = "0x94")]
	private List<MultiPopMenuData> m_RankMenuData;

	[Token(Token = "0x400EF03")]
	[FieldOffset(Offset = "0x98")]
	private List<MultiPopMenuData> m_CSRankMenuData;

	[Token(Token = "0x400EF04")]
	[FieldOffset(Offset = "0x9C")]
	private List<MultiPopMenuData> m_TagMenuData;

	[Token(Token = "0x600E9B9")]
	[Address(RVA = "0x1D078AC", Offset = "0x1D078AC", VA = "0x1D078AC")]
	public UIGroupRecruitController()
	{
	}

	[Token(Token = "0x600E9BA")]
	[Address(RVA = "0x1D079E0", Offset = "0x1D079E0", VA = "0x1D079E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E9BB")]
	[Address(RVA = "0x1D07A84", Offset = "0x1D07A84", VA = "0x1D07A84", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E9BC")]
	[Address(RVA = "0x1D08394", Offset = "0x1D08394", VA = "0x1D08394")]
	private void InitDefaultSelection()
	{
	}

	[Token(Token = "0x600E9BD")]
	[Address(RVA = "0x1D0AD04", Offset = "0x1D0AD04", VA = "0x1D0AD04", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E9BE")]
	[Address(RVA = "0x1D0AE44", Offset = "0x1D0AE44", VA = "0x1D0AE44")]
	private void DefaultWorldState()
	{
	}

	[Token(Token = "0x600E9BF")]
	[Address(RVA = "0x1D0919C", Offset = "0x1D0919C", VA = "0x1D0919C")]
	private void RefreshGroupDataUI()
	{
	}

	[Token(Token = "0x600E9C0")]
	[Address(RVA = "0x1D09D6C", Offset = "0x1D09D6C", VA = "0x1D09D6C")]
	private void UpdateSendChannelView()
	{
	}

	[Token(Token = "0x600E9C1")]
	[Address(RVA = "0x1D0B054", Offset = "0x1D0B054", VA = "0x1D0B054")]
	private void OnSendClick()
	{
	}

	[Token(Token = "0x600E9C2")]
	[Address(RVA = "0x1D0BB74", Offset = "0x1D0BB74", VA = "0x1D0BB74")]
	private void DoSendRecruit()
	{
	}

	[Token(Token = "0x600E9C3")]
	[Address(RVA = "0x1D0A218", Offset = "0x1D0A218", VA = "0x1D0A218")]
	private void OnChannelWorldToggleChangeWithTips(bool needTips = true)
	{
	}

	[Token(Token = "0x600E9C4")]
	[Address(RVA = "0x1D0C32C", Offset = "0x1D0C32C", VA = "0x1D0C32C")]
	private void OnChannelWorldToggleChange()
	{
	}

	[Token(Token = "0x600E9C5")]
	[Address(RVA = "0x1D0A580", Offset = "0x1D0A580", VA = "0x1D0A580")]
	private void OnChannelClanToggleChange()
	{
	}

	[Token(Token = "0x600E9C6")]
	[Address(RVA = "0x1D0BAE8", Offset = "0x1D0BAE8", VA = "0x1D0BAE8")]
	private bool CheckSendToValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600E9C7")]
	[Address(RVA = "0x1D0C3A8", Offset = "0x1D0C3A8", VA = "0x1D0C3A8")]
	private void OnModeBtnClick()
	{
	}

	[Token(Token = "0x600E9C8")]
	[Address(RVA = "0x1D0C6EC", Offset = "0x1D0C6EC", VA = "0x1D0C6EC")]
	private List<MultiPopMenuData> GetOrConstructModeMenu(ref string defaultID)
	{
		return null;
	}

	[Token(Token = "0x600E9C9")]
	[Address(RVA = "0x1D0CC08", Offset = "0x1D0CC08", VA = "0x1D0CC08")]
	private void OnMapBtnClick()
	{
	}

	[Token(Token = "0x600E9CA")]
	[Address(RVA = "0x1D0CE84", Offset = "0x1D0CE84", VA = "0x1D0CE84")]
	private void OnGroupBtnClick()
	{
	}

	[Token(Token = "0x600E9CB")]
	[Address(RVA = "0x1D0D100", Offset = "0x1D0D100", VA = "0x1D0D100")]
	private void OnLadderBtnClick()
	{
	}

	[Token(Token = "0x600E9CC")]
	[Address(RVA = "0x1D0D398", Offset = "0x1D0D398", VA = "0x1D0D398")]
	private void OnTagBtn1Click()
	{
	}

	[Token(Token = "0x600E9CD")]
	[Address(RVA = "0x1D0DBA4", Offset = "0x1D0DBA4", VA = "0x1D0DBA4")]
	private void OnTagBtn2Click()
	{
	}

	[Token(Token = "0x600E9CE")]
	[Address(RVA = "0x1D0D864", Offset = "0x1D0D864", VA = "0x1D0D864")]
	private List<MultiPopMenuData> GetOrConstructTagMenu()
	{
		return null;
	}

	[Token(Token = "0x600E9CF")]
	[Address(RVA = "0x1D0A5D4", Offset = "0x1D0A5D4", VA = "0x1D0A5D4")]
	private bool SetSelectModeID(uint modeid, uint matchid)
	{
		return default(bool);
	}

	[Token(Token = "0x600E9D0")]
	[Address(RVA = "0x1D08768", Offset = "0x1D08768", VA = "0x1D08768")]
	private void ConstructLadderData()
	{
	}

	[Token(Token = "0x600E9D1")]
	[Address(RVA = "0x1D0E070", Offset = "0x1D0E070", VA = "0x1D0E070")]
	private void ConstructMapMenuList(List<MapModeData> mapList)
	{
	}

	[Token(Token = "0x600E9D2")]
	[Address(RVA = "0x1D0AB28", Offset = "0x1D0AB28", VA = "0x1D0AB28")]
	private bool SetSelectMapID(uint mapid)
	{
		return default(bool);
	}

	[Token(Token = "0x600E9D3")]
	[Address(RVA = "0x1D0E528", Offset = "0x1D0E528", VA = "0x1D0E528")]
	private void ConstructGroupMenuList()
	{
	}

	[Token(Token = "0x600E9D4")]
	[Address(RVA = "0x1D0E860", Offset = "0x1D0E860", VA = "0x1D0E860", Slot = "46")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E9D5")]
	[Address(RVA = "0x1D0E99C", Offset = "0x1D0E99C", VA = "0x1D0E99C", Slot = "47")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E9D6")]
	[Address(RVA = "0x1D0EA30", Offset = "0x1D0EA30", VA = "0x1D0EA30")]
	private void _003COnModeBtnClick_003Em__0(List<string> ids)
	{
	}

	[Token(Token = "0x600E9D7")]
	[Address(RVA = "0x1D0EBD8", Offset = "0x1D0EBD8", VA = "0x1D0EBD8")]
	private void _003COnMapBtnClick_003Em__1(List<string> ids)
	{
	}

	[Token(Token = "0x600E9D8")]
	[Address(RVA = "0x1D0ECB4", Offset = "0x1D0ECB4", VA = "0x1D0ECB4")]
	private void _003COnGroupBtnClick_003Em__2(List<string> ids)
	{
	}

	[Token(Token = "0x600E9D9")]
	[Address(RVA = "0x1D0ED8C", Offset = "0x1D0ED8C", VA = "0x1D0ED8C")]
	private void _003COnLadderBtnClick_003Em__3(List<string> ids)
	{
	}

	[Token(Token = "0x600E9DA")]
	[Address(RVA = "0x1D0EE64", Offset = "0x1D0EE64", VA = "0x1D0EE64")]
	private void _003COnTagBtn1Click_003Em__4(List<string> ids)
	{
	}

	[Token(Token = "0x600E9DB")]
	[Address(RVA = "0x1D0EF24", Offset = "0x1D0EF24", VA = "0x1D0EF24")]
	private void _003COnTagBtn2Click_003Em__5(List<string> ids)
	{
	}

	[Token(Token = "0x600E9DC")]
	[Address(RVA = "0x1D0EFE4", Offset = "0x1D0EFE4", VA = "0x1D0EFE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E9DD")]
	[Address(RVA = "0x1D0EFEC", Offset = "0x1D0EFEC", VA = "0x1D0EFEC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
