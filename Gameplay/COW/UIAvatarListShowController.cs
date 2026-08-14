using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024BA")]
public class UIAvatarListShowController : UIBaseController, _Attribute
{
	[Token(Token = "0x20024BB")]
	private enum AvatarSortType
	{
		[Token(Token = "0x400E3D2")]
		PositiveLevel,
		[Token(Token = "0x400E3D3")]
		Awakeken
	}

	[Token(Token = "0x20024BC")]
	private sealed class _003CRefreshAllUI_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E3D4")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelAvatarProfile model;

		[Token(Token = "0x600D2F9")]
		[Address(RVA = "0x2B5C080", Offset = "0x2B5C080", VA = "0x2B5C080")]
		public _003CRefreshAllUI_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D2FA")]
		[Address(RVA = "0x2B5C9EC", Offset = "0x2B5C9EC", VA = "0x2B5C9EC")]
		internal bool _003C_003Em__0(AvatarProfile a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E3BD")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarListShowView m_View;

	[Token(Token = "0x400E3BE")]
	[FieldOffset(Offset = "0x2C")]
	private List<AvatarProfile> m_AvatarProfileList;

	[Token(Token = "0x400E3BF")]
	[FieldOffset(Offset = "0x30")]
	private List<AvatarListItemData> m_AvatarlistItems;

	[Token(Token = "0x400E3C0")]
	[FieldOffset(Offset = "0x34")]
	private int m_MaxLevel;

	[Token(Token = "0x400E3C1")]
	[FieldOffset(Offset = "0x38")]
	private UIPopMenuSmallControler m_CurrentPop;

	[Token(Token = "0x400E3C2")]
	[FieldOffset(Offset = "0x3C")]
	private List<PopMenuData> m_PopMenuList;

	[Token(Token = "0x400E3C3")]
	[FieldOffset(Offset = "0x40")]
	private List<string> m_PopStrList;

	[Token(Token = "0x400E3C4")]
	[FieldOffset(Offset = "0x44")]
	private string m_CurrentChooseTab;

	[Token(Token = "0x400E3C5")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsShrink;

	[Token(Token = "0x400E3C6")]
	[FieldOffset(Offset = "0x49")]
	private bool m_CanTouch;

	[Token(Token = "0x400E3C7")]
	[FieldOffset(Offset = "0x0")]
	private static List<string> m_PopSpriteNames;

	[Token(Token = "0x400E3C8")]
	[FieldOffset(Offset = "0x4C")]
	private EventDelegate m_Delegate;

	[Token(Token = "0x400E3C9")]
	[FieldOffset(Offset = "0x50")]
	private uint m_Index;

	[Token(Token = "0x400E3CA")]
	[FieldOffset(Offset = "0x54")]
	private uint m_DelayCall;

	[Token(Token = "0x400E3CB")]
	[FieldOffset(Offset = "0x58")]
	private bool m_FirstEntered;

	[Token(Token = "0x400E3CC")]
	[FieldOffset(Offset = "0x5C")]
	private AvatarSortType m_Type;

	[Token(Token = "0x400E3CD")]
	[FieldOffset(Offset = "0x60")]
	private List<EventDelegate> m_GuideAction;

	[Token(Token = "0x400E3CE")]
	[FieldOffset(Offset = "0x64")]
	private UIAvatarListItemController m_GuideItemCtrl;

	[Token(Token = "0x400E3CF")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AvatarSuit> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E3D0")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600D2C3")]
	[Address(RVA = "0x2B53528", Offset = "0x2B53528", VA = "0x2B53528")]
	public UIAvatarListShowController()
	{
	}

	[Token(Token = "0x600D2C4")]
	[Address(RVA = "0x2B53694", Offset = "0x2B53694", VA = "0x2B53694")]
	public bool GetCanTouch()
	{
		return default(bool);
	}

	[Token(Token = "0x600D2C5")]
	[Address(RVA = "0x2B536EC", Offset = "0x2B536EC", VA = "0x2B536EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D2C6")]
	[Address(RVA = "0x2B53790", Offset = "0x2B53790", VA = "0x2B53790", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D2C7")]
	[Address(RVA = "0x2B543FC", Offset = "0x2B543FC", VA = "0x2B543FC")]
	private void OnAwakenEntranceBtnClick()
	{
	}

	[Token(Token = "0x600D2C8")]
	[Address(RVA = "0x2B547C0", Offset = "0x2B547C0", VA = "0x2B547C0")]
	private void OnExchangeToAwakenAvatar()
	{
	}

	[Token(Token = "0x600D2C9")]
	[Address(RVA = "0x2B55154", Offset = "0x2B55154", VA = "0x2B55154")]
	private void OnExchangeToOriAvatar()
	{
	}

	[Token(Token = "0x600D2CA")]
	[Address(RVA = "0x2B55738", Offset = "0x2B55738", VA = "0x2B55738")]
	private void OnUpdateAwakenData(object[] param)
	{
	}

	[Token(Token = "0x600D2CB")]
	[Address(RVA = "0x2B558C4", Offset = "0x2B558C4", VA = "0x2B558C4")]
	private void RefreshOnlyAvatar(uint avarid)
	{
	}

	[Token(Token = "0x600D2CC")]
	[Address(RVA = "0x2B55E7C", Offset = "0x2B55E7C", VA = "0x2B55E7C")]
	private void StartSuitPreview(uint avatarId, uint[] clothsIds)
	{
	}

	[Token(Token = "0x600D2CD")]
	[Address(RVA = "0x2B561C0", Offset = "0x2B561C0", VA = "0x2B561C0")]
	private void OnTweenAnimationFinish()
	{
	}

	[Token(Token = "0x600D2CE")]
	[Address(RVA = "0x2B56B24", Offset = "0x2B56B24", VA = "0x2B56B24")]
	private void Update()
	{
	}

	[Token(Token = "0x600D2CF")]
	[Address(RVA = "0x2B56E08", Offset = "0x2B56E08", VA = "0x2B56E08")]
	public bool ShowAvatarGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x600D2D0")]
	[Address(RVA = "0x2B577BC", Offset = "0x2B577BC", VA = "0x2B577BC")]
	private void SetCommonGuide(int guideType, string guideLabel, bool isForce)
	{
	}

	[Token(Token = "0x600D2D1")]
	[Address(RVA = "0x2B57438", Offset = "0x2B57438", VA = "0x2B57438")]
	private void SetAvatarGuide()
	{
	}

	[Token(Token = "0x600D2D2")]
	[Address(RVA = "0x2B57D50", Offset = "0x2B57D50", VA = "0x2B57D50")]
	private AvatarListItemData GetNeedGuideAvatarData()
	{
		return null;
	}

	[Token(Token = "0x600D2D3")]
	[Address(RVA = "0x2B58298", Offset = "0x2B58298", VA = "0x2B58298")]
	public void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600D2D4")]
	[Address(RVA = "0x2B58824", Offset = "0x2B58824", VA = "0x2B58824")]
	public void InitAvatarTween()
	{
	}

	[Token(Token = "0x600D2D5")]
	[Address(RVA = "0x2B58D98", Offset = "0x2B58D98", VA = "0x2B58D98")]
	private bool CheckHasTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D2D6")]
	[Address(RVA = "0x2B58E68", Offset = "0x2B58E68", VA = "0x2B58E68")]
	private bool CheckHasAwakenTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D2D7")]
	[Address(RVA = "0x2B58FFC", Offset = "0x2B58FFC", VA = "0x2B58FFC")]
	private void RefreshRedTips()
	{
	}

	[Token(Token = "0x600D2D8")]
	[Address(RVA = "0x2B5908C", Offset = "0x2B5908C", VA = "0x2B5908C")]
	private void OnUpdateRedTips(object[] data)
	{
	}

	[Token(Token = "0x600D2D9")]
	[Address(RVA = "0x2B590F4", Offset = "0x2B590F4", VA = "0x2B590F4")]
	private void OnUpdateAvatarAWAKEN(object[] data)
	{
	}

	[Token(Token = "0x600D2DA")]
	[Address(RVA = "0x2B59150", Offset = "0x2B59150", VA = "0x2B59150")]
	private int GetStrIndex(string str)
	{
		return default(int);
	}

	[Token(Token = "0x600D2DB")]
	[Address(RVA = "0x2B592B8", Offset = "0x2B592B8", VA = "0x2B592B8")]
	private void GeneratePopList()
	{
	}

	[Token(Token = "0x600D2DC")]
	[Address(RVA = "0x2B58A78", Offset = "0x2B58A78", VA = "0x2B58A78")]
	public void UpdateSelectState(int index)
	{
	}

	[Token(Token = "0x600D2DD")]
	[Address(RVA = "0x2B59690", Offset = "0x2B59690", VA = "0x2B59690")]
	private string GetSpriteNameByStr(string str)
	{
		return null;
	}

	[Token(Token = "0x600D2DE")]
	[Address(RVA = "0x2B599D0", Offset = "0x2B599D0", VA = "0x2B599D0")]
	private void OnSelectCallback(object obj)
	{
	}

	[Token(Token = "0x600D2DF")]
	[Address(RVA = "0x2B59F34", Offset = "0x2B59F34", VA = "0x2B59F34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D2E0")]
	[Address(RVA = "0x2B5A2FC", Offset = "0x2B5A2FC", VA = "0x2B5A2FC")]
	private void ShowProfileAvatarID(object[] args)
	{
	}

	[Token(Token = "0x600D2E1")]
	[Address(RVA = "0x2B5A77C", Offset = "0x2B5A77C", VA = "0x2B5A77C")]
	private int CalcAvatarIndex(uint avid)
	{
		return default(int);
	}

	[Token(Token = "0x600D2E2")]
	[Address(RVA = "0x2B5A920", Offset = "0x2B5A920", VA = "0x2B5A920", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600D2E3")]
	[Address(RVA = "0x2B5AA18", Offset = "0x2B5AA18", VA = "0x2B5AA18", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600D2E4")]
	[Address(RVA = "0x2B5AA94", Offset = "0x2B5AA94", VA = "0x2B5AA94")]
	private int GetPositiveVal(AvatarListItemData a)
	{
		return default(int);
	}

	[Token(Token = "0x600D2E5")]
	[Address(RVA = "0x2B5AB74", Offset = "0x2B5AB74", VA = "0x2B5AB74")]
	private int GetSpecialPositiveVal(AvatarListItemData a)
	{
		return default(int);
	}

	[Token(Token = "0x600D2E6")]
	[Address(RVA = "0x2B5B1F8", Offset = "0x2B5B1F8", VA = "0x2B5B1F8")]
	private int GetAwakenVal(AvatarListItemData a)
	{
		return default(int);
	}

	[Token(Token = "0x600D2E7")]
	[Address(RVA = "0x2B586F8", Offset = "0x2B586F8", VA = "0x2B586F8")]
	private int CalcAvatarIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600D2E8")]
	[Address(RVA = "0x2B59BCC", Offset = "0x2B59BCC", VA = "0x2B59BCC")]
	private void SortAvatarItem(AvatarSortType type, bool forcerefresh = false)
	{
	}

	[Token(Token = "0x600D2E9")]
	[Address(RVA = "0x2B5B3F8", Offset = "0x2B5B3F8", VA = "0x2B5B3F8")]
	public void RefreshEasyListView()
	{
	}

	[Token(Token = "0x600D2EA")]
	[Address(RVA = "0x2B5B67C", Offset = "0x2B5B67C", VA = "0x2B5B67C")]
	public List<AvatarProfile> GetCurrentAvatarProflieList()
	{
		return null;
	}

	[Token(Token = "0x600D2EB")]
	[Address(RVA = "0x2B54674", Offset = "0x2B54674", VA = "0x2B54674")]
	public uint GetCurrentShowAvatarId()
	{
		return default(uint);
	}

	[Token(Token = "0x600D2EC")]
	[Address(RVA = "0x2B5B6D4", Offset = "0x2B5B6D4", VA = "0x2B5B6D4")]
	public void RefreshAllUI()
	{
	}

	[Token(Token = "0x600D2ED")]
	[Address(RVA = "0x2B5C088", Offset = "0x2B5C088", VA = "0x2B5C088")]
	private void RefreshAwakenData(bool flag = true)
	{
	}

	[Token(Token = "0x600D2EE")]
	[Address(RVA = "0x2B5C3C4", Offset = "0x2B5C3C4", VA = "0x2B5C3C4")]
	public void SetCurrentAwakenSelect(uint avatarID, bool flag = true)
	{
	}

	[Token(Token = "0x600D2EF")]
	[Address(RVA = "0x2B56668", Offset = "0x2B56668", VA = "0x2B56668")]
	private void RefreshData()
	{
	}

	[Token(Token = "0x600D2F1")]
	[Address(RVA = "0x2B5C904", Offset = "0x2B5C904", VA = "0x2B5C904")]
	private static bool _003CRefreshOnlyAvatar_003Em__0(AvatarSuit x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D2F2")]
	[Address(RVA = "0x2B5C928", Offset = "0x2B5C928", VA = "0x2B5C928")]
	private static void _003COnTweenAnimationFinish_003Em__1()
	{
	}

	[Token(Token = "0x600D2F3")]
	[Address(RVA = "0x2B5C92C", Offset = "0x2B5C92C", VA = "0x2B5C92C")]
	private int _003CSortAvatarItem_003Em__2(AvatarListItemData a, AvatarListItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x600D2F4")]
	[Address(RVA = "0x2B5C958", Offset = "0x2B5C958", VA = "0x2B5C958")]
	private int _003CSortAvatarItem_003Em__3(AvatarListItemData a, AvatarListItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x600D2F5")]
	[Address(RVA = "0x2B5C984", Offset = "0x2B5C984", VA = "0x2B5C984")]
	private int _003CRefreshEasyListView_003Em__4(AvatarListItemData a, AvatarListItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x600D2F6")]
	[Address(RVA = "0x2B5C9B0", Offset = "0x2B5C9B0", VA = "0x2B5C9B0")]
	private int _003CRefreshEasyListView_003Em__5(AvatarListItemData a, AvatarListItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x600D2F7")]
	[Address(RVA = "0x2B5C9DC", Offset = "0x2B5C9DC", VA = "0x2B5C9DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D2F8")]
	[Address(RVA = "0x2B5C9E4", Offset = "0x2B5C9E4", VA = "0x2B5C9E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
