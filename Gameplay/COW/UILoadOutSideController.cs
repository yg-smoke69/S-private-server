using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2003363")]
public class UILoadOutSideController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x401391D")]
	private const uint LOADOUT_TUTORIAL_SUBTYPE_SURVIVAL = 500000001u;

	[Token(Token = "0x401391E")]
	private const uint LOADOUT_TUTORIAL_SUBTYPE_BASIC = 500000002u;

	[Token(Token = "0x401391F")]
	private const string LOADOUT_TUTORIAL_TITLE_SURVIVAL = "T_27_C_LOUT_S_INTRO";

	[Token(Token = "0x4013920")]
	private const string LOADOUT_TUTORIAL_TITLE_BASIC = "T_27_C_LOUT_B_INTRO";

	[Token(Token = "0x4013921")]
	[FieldOffset(Offset = "0x48")]
	private UILoadOutSideView m_View;

	[Token(Token = "0x4013922")]
	[FieldOffset(Offset = "0x4C")]
	private Transform[] m_SlotCommonList;

	[Token(Token = "0x4013923")]
	[FieldOffset(Offset = "0x50")]
	private List<UIAvatarSkillSlotController> m_SlotCommonCtrlList;

	[Token(Token = "0x4013924")]
	[FieldOffset(Offset = "0x54")]
	private UIChooseSkillWindowController m_ChooseSkillCtrl;

	[Token(Token = "0x4013925")]
	[FieldOffset(Offset = "0x58")]
	private List<UILoadoutItemControllerUnified> m_LoadOutItemCtrlsOld;

	[Token(Token = "0x4013926")]
	[FieldOffset(Offset = "0x5C")]
	private List<UILoadoutItemControllerUnified> m_LoadOutItemCtrlsNew;

	[Token(Token = "0x4013927")]
	[FieldOffset(Offset = "0x60")]
	private int m_CurrentSelectedLoadoutId;

	[Token(Token = "0x4013928")]
	[FieldOffset(Offset = "0x64")]
	private int m_CurrentSelectedLoadoutIdNew;

	[Token(Token = "0x4013929")]
	[FieldOffset(Offset = "0x68")]
	private uint m_OriginalNewId;

	[Token(Token = "0x401392A")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_OriginalOldId;

	[Token(Token = "0x401392B")]
	[FieldOffset(Offset = "0x70")]
	private uint m_CurrentShowAvatarID;

	[Token(Token = "0x401392C")]
	[FieldOffset(Offset = "0x74")]
	private AvatarProfile m_Profile;

	[Token(Token = "0x401392D")]
	[FieldOffset(Offset = "0x78")]
	private MapModeData m_SelectedMapData;

	[Token(Token = "0x401392E")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelAvatarProfile m_AvatarProfileModel;

	[Token(Token = "0x401392F")]
	[FieldOffset(Offset = "0x80")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x4013930")]
	[FieldOffset(Offset = "0x84")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x4013931")]
	[FieldOffset(Offset = "0x88")]
	private UIModelCustomRoom m_ModelCustomRoom;

	[Token(Token = "0x4013932")]
	[FieldOffset(Offset = "0x8C")]
	private AvatarSkillData m_SkillData;

	[Token(Token = "0x170016D3")]
	public MapModeData SelectedMapData
	{
		[Token(Token = "0x6015DA5")]
		[Address(RVA = "0x214FFA4", Offset = "0x214FFA4", VA = "0x214FFA4")]
		set
		{
		}
	}

	[Token(Token = "0x6015DA4")]
	[Address(RVA = "0x214FEC0", Offset = "0x214FEC0", VA = "0x214FEC0")]
	public UILoadOutSideController()
	{
	}

	[Token(Token = "0x6015DA6")]
	[Address(RVA = "0x215028C", Offset = "0x215028C", VA = "0x215028C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015DA7")]
	[Address(RVA = "0x2150330", Offset = "0x2150330", VA = "0x2150330", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015DA8")]
	[Address(RVA = "0x2151408", Offset = "0x2151408", VA = "0x2151408", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6015DA9")]
	[Address(RVA = "0x215187C", Offset = "0x215187C", VA = "0x215187C", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6015DAA")]
	[Address(RVA = "0x2150010", Offset = "0x2150010", VA = "0x2150010")]
	private void UpdateLoadoutAvailableStatus()
	{
	}

	[Token(Token = "0x6015DAB")]
	[Address(RVA = "0x21518D4", Offset = "0x21518D4", VA = "0x21518D4")]
	private void SetBannedStatus(bool isShow)
	{
	}

	[Token(Token = "0x6015DAC")]
	[Address(RVA = "0x2151CC0", Offset = "0x2151CC0", VA = "0x2151CC0")]
	private bool IsLoadoutEnable(uint gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6015DAD")]
	[Address(RVA = "0x215293C", Offset = "0x215293C", VA = "0x215293C")]
	private bool IsSelectedSpeedMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6015DAE")]
	[Address(RVA = "0x2150E24", Offset = "0x2150E24", VA = "0x2150E24")]
	private void InitContents()
	{
	}

	[Token(Token = "0x6015DAF")]
	[Address(RVA = "0x21529C8", Offset = "0x21529C8", VA = "0x21529C8")]
	private List<Item> FilterLoadouts(List<Item> loadoutList)
	{
		return null;
	}

	[Token(Token = "0x6015DB0")]
	[Address(RVA = "0x215330C", Offset = "0x215330C", VA = "0x215330C")]
	private bool IsItemShow(Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x6015DB1")]
	[Address(RVA = "0x2152B58", Offset = "0x2152B58", VA = "0x2152B58")]
	private void BuildLoadoutsUI(List<Item> loadoutList, CSSharedItemDataManager.LoadoutSubType type, UIGrid grid)
	{
	}

	[Token(Token = "0x6015DB2")]
	[Address(RVA = "0x2150B58", Offset = "0x2150B58", VA = "0x2150B58")]
	private void InitSkillContent()
	{
	}

	[Token(Token = "0x6015DB3")]
	[Address(RVA = "0x2150FE0", Offset = "0x2150FE0", VA = "0x2150FE0")]
	private void RefreshAvatarProfileAndSuit()
	{
	}

	[Token(Token = "0x6015DB4")]
	[Address(RVA = "0x21537F4", Offset = "0x21537F4", VA = "0x21537F4")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x6015DB5")]
	[Address(RVA = "0x2153A74", Offset = "0x2153A74", VA = "0x2153A74")]
	private void OnOpenSkillList(object[] data)
	{
	}

	[Token(Token = "0x6015DB6")]
	[Address(RVA = "0x2153C88", Offset = "0x2153C88", VA = "0x2153C88")]
	private void OnEquipSkill(object[] data)
	{
	}

	[Token(Token = "0x6015DB7")]
	[Address(RVA = "0x2153DCC", Offset = "0x2153DCC", VA = "0x2153DCC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6015DB8")]
	[Address(RVA = "0x2154E08", Offset = "0x2154E08", VA = "0x2154E08")]
	private void OnLoadoutOriginalSet(object[] data)
	{
	}

	[Token(Token = "0x6015DB9")]
	[Address(RVA = "0x2154F28", Offset = "0x2154F28", VA = "0x2154F28")]
	private void OnUILoadOutSelected(object[] data)
	{
	}

	[Token(Token = "0x6015DBA")]
	[Address(RVA = "0x2155220", Offset = "0x2155220", VA = "0x2155220")]
	private void OnSurvivalInfoBtnClick()
	{
	}

	[Token(Token = "0x6015DBB")]
	[Address(RVA = "0x2155330", Offset = "0x2155330", VA = "0x2155330")]
	private void OnBasicInfoBtnClick()
	{
	}

	[Token(Token = "0x6015DBC")]
	[Address(RVA = "0x2155440", Offset = "0x2155440", VA = "0x2155440")]
	private void OnCloseClick()
	{
	}

	[Token(Token = "0x6015DBD")]
	[Address(RVA = "0x21554A4", Offset = "0x21554A4", VA = "0x21554A4")]
	private void OnSelfSlotClicked(object[] data)
	{
	}

	[Token(Token = "0x6015DBE")]
	[Address(RVA = "0x2155794", Offset = "0x2155794", VA = "0x2155794", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6015DBF")]
	[Address(RVA = "0x2155A2C", Offset = "0x2155A2C", VA = "0x2155A2C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6015DC0")]
	[Address(RVA = "0x2155B44", Offset = "0x2155B44", VA = "0x2155B44")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015DC1")]
	[Address(RVA = "0x2155B4C", Offset = "0x2155B4C", VA = "0x2155B4C")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x6015DC2")]
	[Address(RVA = "0x2155B54", Offset = "0x2155B54", VA = "0x2155B54")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6015DC3")]
	[Address(RVA = "0x2155B5C", Offset = "0x2155B5C", VA = "0x2155B5C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
