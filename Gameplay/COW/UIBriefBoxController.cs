using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20024FF")]
public class UIBriefBoxController : UIBasePopMenuController<UIChatPopMenuItemContoller>, _Attribute
{
	[Token(Token = "0x400E5B2")]
	[FieldOffset(Offset = "0x84")]
	private UIModelProfile m_Model;

	[Token(Token = "0x400E5B3")]
	[FieldOffset(Offset = "0x88")]
	private UIBriefBoxView m_View;

	[Token(Token = "0x400E5B4")]
	[FieldOffset(Offset = "0x8C")]
	private LayoutTable m_Table;

	[Token(Token = "0x400E5B5")]
	[FieldOffset(Offset = "0x90")]
	private GridTableItem m_GridItem;

	[Token(Token = "0x400E5B6")]
	[FieldOffset(Offset = "0x94")]
	private GridTableItem m_TagGridItem;

	[Token(Token = "0x400E5B7")]
	[FieldOffset(Offset = "0x98")]
	private GridTableItem m_SocialTagGridItem;

	[Token(Token = "0x400E5B8")]
	[FieldOffset(Offset = "0x9C")]
	private BaseTableItem m_ProfileContainerItem;

	[Token(Token = "0x400E5B9")]
	[FieldOffset(Offset = "0xA0")]
	private float m_DefaultWidth;

	[Token(Token = "0x400E5BA")]
	[FieldOffset(Offset = "0xA4")]
	private ILayoutTableItem m_ScrollViewItem;

	[Token(Token = "0x400E5BB")]
	[FieldOffset(Offset = "0xA8")]
	private ILayoutTableItem m_DescTableItem;

	[Token(Token = "0x400E5BC")]
	[FieldOffset(Offset = "0xAC")]
	private UIBaseProfileInfoController m_Control;

	[Token(Token = "0x400E5BD")]
	[FieldOffset(Offset = "0xB0")]
	private List<CommonPopMenuData> m_MenuDatas;

	[Token(Token = "0x400E5BE")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 m_WindowPos;

	[Token(Token = "0x400E5BF")]
	[FieldOffset(Offset = "0xC0")]
	private BaseProfileInfo m_BaseProfileInfo;

	[Token(Token = "0x400E5C0")]
	[FieldOffset(Offset = "0xC4")]
	private AccountBriefInfo m_Data;

	[Token(Token = "0x400E5C1")]
	[FieldOffset(Offset = "0xC8")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x400E5C2")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_HasRequestData;

	[Token(Token = "0x400E5C3")]
	[FieldOffset(Offset = "0xD0")]
	private List<ProfileTagView> m_ProfileTagItems;

	[Token(Token = "0x400E5C4")]
	[FieldOffset(Offset = "0xD4")]
	private List<ProfileTagView> m_SocialTagItems;

	[Token(Token = "0x400E5C5")]
	[FieldOffset(Offset = "0xD8")]
	private List<GameObject> m_HistoryStarList;

	[Token(Token = "0x400E5C6")]
	[FieldOffset(Offset = "0xDC")]
	private List<GameObject> m_HistoryBlackStarList;

	[Token(Token = "0x400E5C7")]
	[FieldOffset(Offset = "0xE0")]
	private TweenPosition m_TweenPos;

	[Token(Token = "0x400E5C8")]
	[FieldOffset(Offset = "0xE4")]
	private TweenScale m_TweenScale;

	[Token(Token = "0x400E5C9")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 m_FromPos;

	[Token(Token = "0x400E5CA")]
	[FieldOffset(Offset = "0xF4")]
	private GameObject m_CacheHeroicBREffect;

	[Token(Token = "0x400E5CB")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject m_CacheHeroicCSEffect;

	[Token(Token = "0x600D62A")]
	[Address(RVA = "0x10DE504", Offset = "0x10DE504", VA = "0x10DE504")]
	public UIBriefBoxController()
	{
	}

	[Token(Token = "0x600D62B")]
	[Address(RVA = "0x10DE5E8", Offset = "0x10DE5E8", VA = "0x10DE5E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D62C")]
	[Address(RVA = "0x10DE68C", Offset = "0x10DE68C", VA = "0x10DE68C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D62D")]
	[Address(RVA = "0x10DF338", Offset = "0x10DF338", VA = "0x10DF338", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D62E")]
	[Address(RVA = "0x10DF450", Offset = "0x10DF450", VA = "0x10DF450", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D62F")]
	[Address(RVA = "0x10DF734", Offset = "0x10DF734", VA = "0x10DF734")]
	private void RefreshCSRank(object[] param)
	{
	}

	[Token(Token = "0x600D630")]
	[Address(RVA = "0x10DFB50", Offset = "0x10DFB50", VA = "0x10DFB50", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600D631")]
	[Address(RVA = "0x10DF628", Offset = "0x10DF628", VA = "0x10DF628")]
	private void Clear()
	{
	}

	[Token(Token = "0x600D632")]
	[Address(RVA = "0x10DFBBC", Offset = "0x10DFBBC", VA = "0x10DFBBC")]
	public void UpdateMenuData(List<CommonPopMenuData> list, BaseProfileInfo profileInfo)
	{
	}

	[Token(Token = "0x600D633")]
	[Address(RVA = "0x10DFCC8", Offset = "0x10DFCC8", VA = "0x10DFCC8")]
	public void UpdateMenuData(List<CommonPopMenuData> list, BaseProfileInfo profileInfo, Vector3 WindowPos)
	{
	}

	[Token(Token = "0x600D634")]
	[Address(RVA = "0x10E022C", Offset = "0x10E022C", VA = "0x10E022C")]
	private void UpdateMenuDataInternal(List<CommonPopMenuData> list, BaseProfileInfo profileInfo, Vector3 WindowPos)
	{
	}

	[Token(Token = "0x600D635")]
	[Address(RVA = "0x10E2780", Offset = "0x10E2780", VA = "0x10E2780")]
	private void RefreshContainer(float width)
	{
	}

	[Token(Token = "0x600D636")]
	[Address(RVA = "0x10E3130", Offset = "0x10E3130", VA = "0x10E3130")]
	private void AddMask()
	{
	}

	[Token(Token = "0x600D637")]
	[Address(RVA = "0x10E0078", Offset = "0x10E0078", VA = "0x10E0078")]
	private void RequestData()
	{
	}

	[Token(Token = "0x600D638")]
	[Address(RVA = "0x10E2494", Offset = "0x10E2494", VA = "0x10E2494")]
	private void RefreshItem(float width)
	{
	}

	[Token(Token = "0x600D639")]
	[Address(RVA = "0x10E07C8", Offset = "0x10E07C8", VA = "0x10E07C8")]
	private float RefreshProfile()
	{
		return default(float);
	}

	[Token(Token = "0x600D63A")]
	[Address(RVA = "0x10E3778", Offset = "0x10E3778", VA = "0x10E3778")]
	private void SetDefaultLanguage()
	{
	}

	[Token(Token = "0x600D63B")]
	[Address(RVA = "0x10E0BBC", Offset = "0x10E0BBC", VA = "0x10E0BBC")]
	private void RefreshBattleTag()
	{
	}

	[Token(Token = "0x600D63C")]
	[Address(RVA = "0x10E15F0", Offset = "0x10E15F0", VA = "0x10E15F0")]
	private void RefreshSocialTag()
	{
	}

	[Token(Token = "0x600D63D")]
	[Address(RVA = "0x10E1FB8", Offset = "0x10E1FB8", VA = "0x10E1FB8")]
	private void RefreshDesc()
	{
	}

	[Token(Token = "0x600D63E")]
	[Address(RVA = "0x10DEF94", Offset = "0x10DEF94", VA = "0x10DEF94")]
	private void InitRank()
	{
	}

	[Token(Token = "0x600D63F")]
	[Address(RVA = "0x10E0B68", Offset = "0x10E0B68", VA = "0x10E0B68")]
	private void RefreshRank()
	{
	}

	[Token(Token = "0x600D640")]
	[Address(RVA = "0x10E39E8", Offset = "0x10E39E8", VA = "0x10E39E8")]
	private void ShowBrLadder(int rank, uint peakRankPos, UISprite spr)
	{
	}

	[Token(Token = "0x600D641")]
	[Address(RVA = "0x10E3BDC", Offset = "0x10E3BDC", VA = "0x10E3BDC")]
	private void ShowBrRankInfo()
	{
	}

	[Token(Token = "0x600D642")]
	[Address(RVA = "0x10E3C30", Offset = "0x10E3C30", VA = "0x10E3C30")]
	private void RefreshHeroicLevel(int rank, int rankPoint, uint peakRankPos)
	{
	}

	[Token(Token = "0x600D643")]
	[Address(RVA = "0x10E3E10", Offset = "0x10E3E10", VA = "0x10E3E10")]
	private void RefreshHeroicMaxLevel(int rankPoint)
	{
	}

	[Token(Token = "0x600D644")]
	[Address(RVA = "0x10E3EC8", Offset = "0x10E3EC8", VA = "0x10E3EC8")]
	private void ShowCsHistoryRankInfo(uint rank)
	{
	}

	[Token(Token = "0x600D645")]
	[Address(RVA = "0x10E4460", Offset = "0x10E4460", VA = "0x10E4460")]
	private void ShowCsCurrentRankInfo()
	{
	}

	[Token(Token = "0x600D646")]
	[Address(RVA = "0x10E4CAC", Offset = "0x10E4CAC", VA = "0x10E4CAC")]
	private void OnHeroicMarkBRIconClick()
	{
	}

	[Token(Token = "0x600D647")]
	[Address(RVA = "0x10E4E28", Offset = "0x10E4E28", VA = "0x10E4E28")]
	private void OnHeroicMarkCSIconClick()
	{
	}

	[Token(Token = "0x600D648")]
	[Address(RVA = "0x10E4FA4", Offset = "0x10E4FA4", VA = "0x10E4FA4")]
	private void RefreshHeroicMarkInfo()
	{
	}

	[Token(Token = "0x600D649")]
	[Address(RVA = "0x10E3220", Offset = "0x10E3220", VA = "0x10E3220")]
	private void UpdateMenuDataWithFixedWidth(List<CommonPopMenuData> list, int width)
	{
	}

	[Token(Token = "0x600D64A")]
	[Address(RVA = "0x10E4FF8", Offset = "0x10E4FF8", VA = "0x10E4FF8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D64B")]
	[Address(RVA = "0x10E5184", Offset = "0x10E5184", VA = "0x10E5184", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D64C")]
	[Address(RVA = "0x10E5218", Offset = "0x10E5218", VA = "0x10E5218")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D64D")]
	[Address(RVA = "0x10E521C", Offset = "0x10E521C", VA = "0x10E521C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600D64E")]
	[Address(RVA = "0x10E5224", Offset = "0x10E5224", VA = "0x10E5224")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D64F")]
	[Address(RVA = "0x10E5228", Offset = "0x10E5228", VA = "0x10E5228")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
