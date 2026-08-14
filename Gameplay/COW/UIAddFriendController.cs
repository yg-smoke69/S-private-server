using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002498")]
public class UIAddFriendController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x2002499")]
	public enum EPlayerSocialType
	{
		[Token(Token = "0x400E2E1")]
		Gender = 1,
		[Token(Token = "0x400E2E2")]
		TimeActive = 4,
		[Token(Token = "0x400E2E3")]
		ModePrefer = 5
	}

	[Token(Token = "0x400E2CF")]
	[FieldOffset(Offset = "0x28")]
	private UIAddFriendView m_View;

	[Token(Token = "0x400E2D0")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_HasSearch;

	[Token(Token = "0x400E2D1")]
	[FieldOffset(Offset = "0x30")]
	private int m_scrollWidth;

	[Token(Token = "0x400E2D2")]
	[FieldOffset(Offset = "0x34")]
	private UIPopMenuSmallControler m_TimeActivePopMenuController;

	[Token(Token = "0x400E2D3")]
	[FieldOffset(Offset = "0x38")]
	private UIPopMenuSmallControler m_ModePreferPopMenuController;

	[Token(Token = "0x400E2D4")]
	[FieldOffset(Offset = "0x3C")]
	private UIPopMenuSmallControler m_GenderPopMenuController;

	[Token(Token = "0x400E2D5")]
	[FieldOffset(Offset = "0x40")]
	private UISelectLanguageController m_UISelectLanguageController;

	[Token(Token = "0x400E2D6")]
	[FieldOffset(Offset = "0x44")]
	private List<PlayerSocialTagsData> m_GenderList;

	[Token(Token = "0x400E2D7")]
	[FieldOffset(Offset = "0x48")]
	private List<PlayerSocialTagsData> m_TimeActiveList;

	[Token(Token = "0x400E2D8")]
	[FieldOffset(Offset = "0x4C")]
	private List<PlayerSocialTagsData> m_ModePreferList;

	[Token(Token = "0x400E2D9")]
	[FieldOffset(Offset = "0x50")]
	private List<PopMenuData> m_LanguageDataList;

	[Token(Token = "0x400E2DA")]
	private const int TOGGLE_GROUP_ID = 117;

	[Token(Token = "0x400E2DB")]
	[FieldOffset(Offset = "0x54")]
	private ESocial.Language m_SelectedLanguage;

	[Token(Token = "0x400E2DC")]
	[FieldOffset(Offset = "0x58")]
	private ESocial.Gender m_SelectedGender;

	[Token(Token = "0x400E2DD")]
	[FieldOffset(Offset = "0x5C")]
	private ESocial.TimeActive m_SelectedTimeActive;

	[Token(Token = "0x400E2DE")]
	[FieldOffset(Offset = "0x60")]
	private ESocial.ModePrefer m_SelectedModePrefer;

	[Token(Token = "0x400E2DF")]
	[FieldOffset(Offset = "0x64")]
	private uint _003CRefreshState_003Ek__BackingField;

	[Token(Token = "0x1700111E")]
	public uint RefreshState
	{
		[Token(Token = "0x600D113")]
		[Address(RVA = "0x1F29018", Offset = "0x1F29018", VA = "0x1F29018")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600D114")]
		[Address(RVA = "0x1F29020", Offset = "0x1F29020", VA = "0x1F29020")]
		private set
		{
		}
	}

	[Token(Token = "0x1700111F")]
	public EFriendTabType CurrentTabType
	{
		[Token(Token = "0x600D116")]
		[Address(RVA = "0x1F290CC", Offset = "0x1F290CC", VA = "0x1F290CC")]
		get
		{
			return default(EFriendTabType);
		}
	}

	[Token(Token = "0x600D112")]
	[Address(RVA = "0x1F28ED8", Offset = "0x1F28ED8", VA = "0x1F28ED8")]
	public UIAddFriendController()
	{
	}

	[Token(Token = "0x600D115")]
	[Address(RVA = "0x1F29028", Offset = "0x1F29028", VA = "0x1F29028")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D117")]
	[Address(RVA = "0x1F29124", Offset = "0x1F29124", VA = "0x1F29124", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D118")]
	[Address(RVA = "0x1F291D8", Offset = "0x1F291D8", VA = "0x1F291D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D119")]
	[Address(RVA = "0x1F2A7F4", Offset = "0x1F2A7F4", VA = "0x1F2A7F4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D11A")]
	[Address(RVA = "0x1F29BA0", Offset = "0x1F29BA0", VA = "0x1F29BA0")]
	private void InitPopMenus()
	{
	}

	[Token(Token = "0x600D11B")]
	[Address(RVA = "0x1F2A924", Offset = "0x1F2A924", VA = "0x1F2A924")]
	public void SetViewData(int width)
	{
	}

	[Token(Token = "0x600D11C")]
	[Address(RVA = "0x1F2AB80", Offset = "0x1F2AB80", VA = "0x1F2AB80")]
	private void OnSearchBtnClick()
	{
	}

	[Token(Token = "0x600D11D")]
	[Address(RVA = "0x1F2B044", Offset = "0x1F2B044", VA = "0x1F2B044")]
	private void OnInputSubmit()
	{
	}

	[Token(Token = "0x600D11E")]
	[Address(RVA = "0x1F2AFAC", Offset = "0x1F2AFAC", VA = "0x1F2AFAC")]
	public bool IsDefaultSearch()
	{
		return default(bool);
	}

	[Token(Token = "0x600D11F")]
	[Address(RVA = "0x1F2B4DC", Offset = "0x1F2B4DC", VA = "0x1F2B4DC")]
	public bool IsLanguageDefault()
	{
		return default(bool);
	}

	[Token(Token = "0x600D120")]
	[Address(RVA = "0x1F2B54C", Offset = "0x1F2B54C", VA = "0x1F2B54C")]
	public bool IsModePreferDefault()
	{
		return default(bool);
	}

	[Token(Token = "0x600D121")]
	[Address(RVA = "0x1F2B5BC", Offset = "0x1F2B5BC", VA = "0x1F2B5BC")]
	public bool isTimeActiveDefault()
	{
		return default(bool);
	}

	[Token(Token = "0x600D122")]
	[Address(RVA = "0x1F2B62C", Offset = "0x1F2B62C", VA = "0x1F2B62C")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600D123")]
	[Address(RVA = "0x1F2BCC0", Offset = "0x1F2BCC0", VA = "0x1F2BCC0")]
	public void OnRefreshSelectBtnClick()
	{
	}

	[Token(Token = "0x600D124")]
	[Address(RVA = "0x1F2C4E0", Offset = "0x1F2C4E0", VA = "0x1F2C4E0")]
	private void OnLanguageBtnClick()
	{
	}

	[Token(Token = "0x600D125")]
	[Address(RVA = "0x1F2CB0C", Offset = "0x1F2CB0C", VA = "0x1F2CB0C")]
	private void OnSearchInputChange()
	{
	}

	[Token(Token = "0x600D126")]
	[Address(RVA = "0x1F2CCCC", Offset = "0x1F2CCCC", VA = "0x1F2CCCC")]
	private void OnClearButtonClicked()
	{
	}

	[Token(Token = "0x600D127")]
	[Address(RVA = "0x1F2D1D8", Offset = "0x1F2D1D8", VA = "0x1F2D1D8")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x600D128")]
	[Address(RVA = "0x1F2D29C", Offset = "0x1F2D29C", VA = "0x1F2D29C", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D129")]
	[Address(RVA = "0x1F2D3C0", Offset = "0x1F2D3C0", VA = "0x1F2D3C0", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D12A")]
	[Address(RVA = "0x1F2D43C", Offset = "0x1F2D43C", VA = "0x1F2D43C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D12B")]
	[Address(RVA = "0x1F2DDA0", Offset = "0x1F2DDA0", VA = "0x1F2DDA0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D12C")]
	[Address(RVA = "0x1F2DA40", Offset = "0x1F2DA40", VA = "0x1F2DA40")]
	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	[Token(Token = "0x600D12D")]
	[Address(RVA = "0x1F2C7A8", Offset = "0x1F2C7A8", VA = "0x1F2C7A8")]
	private void InitLanguageList()
	{
	}

	[Token(Token = "0x600D12E")]
	[Address(RVA = "0x1F2DE34", Offset = "0x1F2DE34", VA = "0x1F2DE34")]
	private void GenerateGenderMenuData()
	{
	}

	[Token(Token = "0x600D12F")]
	[Address(RVA = "0x1F2E260", Offset = "0x1F2E260", VA = "0x1F2E260")]
	private void GenerateTimeActiveMenuData()
	{
	}

	[Token(Token = "0x600D130")]
	[Address(RVA = "0x1F2E6D0", Offset = "0x1F2E6D0", VA = "0x1F2E6D0")]
	private void GenerateModePreferMenuData()
	{
	}

	[Token(Token = "0x600D131")]
	[Address(RVA = "0x1F2EB40", Offset = "0x1F2EB40", VA = "0x1F2EB40")]
	private void OnGenderSelected(object obj)
	{
	}

	[Token(Token = "0x600D132")]
	[Address(RVA = "0x1F2EE54", Offset = "0x1F2EE54", VA = "0x1F2EE54")]
	private void OnTimeActiveSelected(object obj)
	{
	}

	[Token(Token = "0x600D133")]
	[Address(RVA = "0x1F2F168", Offset = "0x1F2F168", VA = "0x1F2F168")]
	private void OnModeHobbySelected(object obj)
	{
	}

	[Token(Token = "0x600D134")]
	[Address(RVA = "0x1F2F47C", Offset = "0x1F2F47C", VA = "0x1F2F47C")]
	private void OnLocLanguageSelect(object obj)
	{
	}

	[Token(Token = "0x600D135")]
	[Address(RVA = "0x1F2F7D8", Offset = "0x1F2F7D8", VA = "0x1F2F7D8")]
	private bool _003CInitPopMenus_003Em__0(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D136")]
	[Address(RVA = "0x1F2F810", Offset = "0x1F2F810", VA = "0x1F2F810")]
	private bool _003CInitPopMenus_003Em__1(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D137")]
	[Address(RVA = "0x1F2F848", Offset = "0x1F2F848", VA = "0x1F2F848")]
	private bool _003CInitPopMenus_003Em__2(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D138")]
	[Address(RVA = "0x1F2F880", Offset = "0x1F2F880", VA = "0x1F2F880")]
	private bool _003COnRefreshSelectBtnClick_003Em__3(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D139")]
	[Address(RVA = "0x1F2F8B8", Offset = "0x1F2F8B8", VA = "0x1F2F8B8")]
	private bool _003COnRefreshSelectBtnClick_003Em__4(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D13A")]
	[Address(RVA = "0x1F2F8F0", Offset = "0x1F2F8F0", VA = "0x1F2F8F0")]
	private bool _003COnRefreshSelectBtnClick_003Em__5(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D13B")]
	[Address(RVA = "0x1F2F928", Offset = "0x1F2F928", VA = "0x1F2F928")]
	private bool _003COnGenderSelected_003Em__6(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D13C")]
	[Address(RVA = "0x1F2F960", Offset = "0x1F2F960", VA = "0x1F2F960")]
	private bool _003COnTimeActiveSelected_003Em__7(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D13D")]
	[Address(RVA = "0x1F2F998", Offset = "0x1F2F998", VA = "0x1F2F998")]
	private bool _003COnModeHobbySelected_003Em__8(PlayerSocialTagsData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D13E")]
	[Address(RVA = "0x1F2F9D0", Offset = "0x1F2F9D0", VA = "0x1F2F9D0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D13F")]
	[Address(RVA = "0x1F2F9D8", Offset = "0x1F2F9D8", VA = "0x1F2F9D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D140")]
	[Address(RVA = "0x1F2F9E0", Offset = "0x1F2F9E0", VA = "0x1F2F9E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
