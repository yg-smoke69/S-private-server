using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20024D0")]
public class UIAvatarProfileNavigationController : UINavigationController, _Attribute
{
	[Token(Token = "0x20024D1")]
	private sealed class _003COnNavigationShowed_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E44B")]
		[FieldOffset(Offset = "0x8")]
		internal uint tempid;

		[Token(Token = "0x600D3C9")]
		[Address(RVA = "0x2F871D0", Offset = "0x2F871D0", VA = "0x2F871D0")]
		public _003COnNavigationShowed_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600D3CA")]
		[Address(RVA = "0x2F8E504", Offset = "0x2F8E504", VA = "0x2F8E504")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20024D2")]
	private sealed class _003CCoResetAvatarIdle_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E44C")]
		[FieldOffset(Offset = "0x8")]
		internal UIMaleAvatar _003Cavatar_003E__0;

		[Token(Token = "0x400E44D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E44E")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E44F")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001134")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600D3CD")]
			[Address(RVA = "0x2F8E458", Offset = "0x2F8E458", VA = "0x2F8E458", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001135")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600D3CE")]
			[Address(RVA = "0x2F8E460", Offset = "0x2F8E460", VA = "0x2F8E460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600D3CB")]
		[Address(RVA = "0x2F89F68", Offset = "0x2F89F68", VA = "0x2F89F68")]
		public _003CCoResetAvatarIdle_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600D3CC")]
		[Address(RVA = "0x2F8E310", Offset = "0x2F8E310", VA = "0x2F8E310", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600D3CF")]
		[Address(RVA = "0x2F8E468", Offset = "0x2F8E468", VA = "0x2F8E468", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600D3D0")]
		[Address(RVA = "0x2F8E47C", Offset = "0x2F8E47C", VA = "0x2F8E47C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E438")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CurrentShowAvatarID;

	[Token(Token = "0x400E439")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_SendAvatarId;

	[Token(Token = "0x400E43A")]
	[FieldOffset(Offset = "0x70")]
	private uint m_CurrentShowSuitID;

	[Token(Token = "0x400E43B")]
	[FieldOffset(Offset = "0x74")]
	private UIAvatarProfileNavigationView m_View;

	[Token(Token = "0x400E43C")]
	[FieldOffset(Offset = "0x78")]
	private UIAvatarProfileController m_AvatarProfileCtrl;

	[Token(Token = "0x400E43D")]
	[FieldOffset(Offset = "0x7C")]
	private UIChooseSkillWindowController m_ChooseSkillCtrl;

	[Token(Token = "0x400E43E")]
	[FieldOffset(Offset = "0x80")]
	private UIModelAvatarProfile m_AvatarProfileModel;

	[Token(Token = "0x400E43F")]
	[FieldOffset(Offset = "0x84")]
	private LinkProfile m_LinkProfile;

	[Token(Token = "0x400E440")]
	[FieldOffset(Offset = "0x88")]
	private UINavigationData m_CacheNavigationData;

	[Token(Token = "0x400E441")]
	[FieldOffset(Offset = "0x8C")]
	private UICommonGuideController m_LinkGuideCtr;

	[Token(Token = "0x400E442")]
	[FieldOffset(Offset = "0x90")]
	private bool m_IsOtherGuideShow;

	[Token(Token = "0x400E443")]
	private const string m_DebrisTipKey = "TXT_PROFILE_DEBRIS_TIP";

	[Token(Token = "0x400E444")]
	private const string VISIT_AVATAR_LIST = "VISIT_AVATAR_LIST";

	[Token(Token = "0x400E445")]
	public const string FIRST_CHARA_KEY = "HAS_SEEN_CHARACTER";

	[Token(Token = "0x400E446")]
	[FieldOffset(Offset = "0x94")]
	private UICommonGuideController m_CommonGuideCtrl;

	[Token(Token = "0x400E447")]
	[FieldOffset(Offset = "0x98")]
	private uint m_PlayVoiceDelayCall;

	[Token(Token = "0x400E448")]
	[FieldOffset(Offset = "0x9C")]
	private UIAvatarListShowController m_AvatarListShowCtrl;

	[Token(Token = "0x400E449")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_FirstEntered;

	[Token(Token = "0x400E44A")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AvatarSuit> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001132")]
	public int CurrentPanelMaxDepth
	{
		[Token(Token = "0x600D380")]
		[Address(RVA = "0x2F84F70", Offset = "0x2F84F70", VA = "0x2F84F70")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001133")]
	public uint GetCurrentShowAvatarId
	{
		[Token(Token = "0x600D381")]
		[Address(RVA = "0x2F85068", Offset = "0x2F85068", VA = "0x2F85068")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600D37F")]
	[Address(RVA = "0x2F84EE4", Offset = "0x2F84EE4", VA = "0x2F84EE4")]
	public UIAvatarProfileNavigationController()
	{
	}

	[Token(Token = "0x600D382")]
	[Address(RVA = "0x2F850C0", Offset = "0x2F850C0", VA = "0x2F850C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D383")]
	[Address(RVA = "0x2F85164", Offset = "0x2F85164", VA = "0x2F85164", Slot = "37")]
	protected override bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600D384")]
	[Address(RVA = "0x2F851BC", Offset = "0x2F851BC", VA = "0x2F851BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D385")]
	[Address(RVA = "0x2F86040", Offset = "0x2F86040", VA = "0x2F86040")]
	private void InitTab()
	{
	}

	[Token(Token = "0x600D386")]
	[Address(RVA = "0x2F86094", Offset = "0x2F86094", VA = "0x2F86094")]
	private void IniTabState()
	{
	}

	[Token(Token = "0x600D387")]
	[Address(RVA = "0x2F861BC", Offset = "0x2F861BC", VA = "0x2F861BC")]
	private void RefreshAvatarExpireInfo()
	{
	}

	[Token(Token = "0x600D388")]
	[Address(RVA = "0x2F86100", Offset = "0x2F86100", VA = "0x2F86100")]
	private void RefreshContainerState(bool optionNotify = false)
	{
	}

	[Token(Token = "0x600D389")]
	[Address(RVA = "0x2F86168", Offset = "0x2F86168", VA = "0x2F86168")]
	private void UpdateSpecialTabRedDot()
	{
	}

	[Token(Token = "0x600D38A")]
	[Address(RVA = "0x2F86678", Offset = "0x2F86678", VA = "0x2F86678")]
	private void RefreshTabVisible()
	{
	}

	[Token(Token = "0x600D38B")]
	[Address(RVA = "0x2F866CC", Offset = "0x2F866CC", VA = "0x2F866CC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600D38C")]
	[Address(RVA = "0x2F87338", Offset = "0x2F87338", VA = "0x2F87338")]
	private void UpdateRealAvatarList()
	{
	}

	[Token(Token = "0x600D38D")]
	[Address(RVA = "0x2F87E68", Offset = "0x2F87E68", VA = "0x2F87E68")]
	private void UpdateAvatarList(object[] data)
	{
	}

	[Token(Token = "0x600D38E")]
	[Address(RVA = "0x2F872E4", Offset = "0x2F872E4", VA = "0x2F872E4")]
	private void TryShowReCommendSuit()
	{
	}

	[Token(Token = "0x600D38F")]
	[Address(RVA = "0x2F871D8", Offset = "0x2F871D8", VA = "0x2F871D8")]
	private void TryShowGuide()
	{
	}

	[Token(Token = "0x600D390")]
	[Address(RVA = "0x2F87F90", Offset = "0x2F87F90", VA = "0x2F87F90", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600D391")]
	[Address(RVA = "0x2F880EC", Offset = "0x2F880EC", VA = "0x2F880EC", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600D392")]
	[Address(RVA = "0x2F88D10", Offset = "0x2F88D10", VA = "0x2F88D10", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D393")]
	[Address(RVA = "0x2F89578", Offset = "0x2F89578", VA = "0x2F89578")]
	private void StopNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x600D394")]
	[Address(RVA = "0x2F89684", Offset = "0x2F89684", VA = "0x2F89684")]
	private bool IsBackNavigation(UINavigationData navigationData)
	{
		return default(bool);
	}

	[Token(Token = "0x600D395")]
	[Address(RVA = "0x2F896FC", Offset = "0x2F896FC", VA = "0x2F896FC")]
	private void OnSelectAvatar(object[] data)
	{
	}

	[Token(Token = "0x600D396")]
	[Address(RVA = "0x2F89758", Offset = "0x2F89758", VA = "0x2F89758")]
	private void OnResetAvatarModel(object[] data)
	{
	}

	[Token(Token = "0x600D397")]
	[Address(RVA = "0x2F898B8", Offset = "0x2F898B8", VA = "0x2F898B8")]
	private void OnFullScreenPreviewClose(object[] data)
	{
	}

	[Token(Token = "0x600D398")]
	[Address(RVA = "0x2F89914", Offset = "0x2F89914", VA = "0x2F89914")]
	private void OnSelctedAvatarUpdate(object[] data)
	{
	}

	[Token(Token = "0x600D399")]
	[Address(RVA = "0x2F874F8", Offset = "0x2F874F8", VA = "0x2F874F8")]
	private void OnSwitchShowAvatar(object[] data)
	{
	}

	[Token(Token = "0x600D39A")]
	[Address(RVA = "0x2F89F0C", Offset = "0x2F89F0C", VA = "0x2F89F0C")]
	private void ShowAwakenAvatarExchangeView(bool forceHide = false)
	{
	}

	[Token(Token = "0x600D39B")]
	[Address(RVA = "0x2F8722C", Offset = "0x2F8722C", VA = "0x2F8722C")]
	private IEnumerator CoResetAvatarIdle()
	{
		return null;
	}

	[Token(Token = "0x600D39C")]
	[Address(RVA = "0x2F89988", Offset = "0x2F89988", VA = "0x2F89988")]
	private void StartSuitPreview(uint avatarId, uint[] clothsIds)
	{
	}

	[Token(Token = "0x600D39D")]
	[Address(RVA = "0x2F8A340", Offset = "0x2F8A340", VA = "0x2F8A340")]
	private void OnSwitchSuit(object[] data)
	{
	}

	[Token(Token = "0x600D39E")]
	[Address(RVA = "0x2F8A39C", Offset = "0x2F8A39C", VA = "0x2F8A39C")]
	private void ShowDebrisSourceTip(object[] data)
	{
	}

	[Token(Token = "0x600D39F")]
	[Address(RVA = "0x2F8A600", Offset = "0x2F8A600", VA = "0x2F8A600", Slot = "43")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D3A0")]
	[Address(RVA = "0x2F8A6DC", Offset = "0x2F8A6DC", VA = "0x2F8A6DC")]
	private void RefreshListShow(bool flag = false)
	{
	}

	[Token(Token = "0x600D3A1")]
	[Address(RVA = "0x2F8A96C", Offset = "0x2F8A96C", VA = "0x2F8A96C", Slot = "42")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D3A2")]
	[Address(RVA = "0x2F8B260", Offset = "0x2F8B260", VA = "0x2F8B260")]
	private void RefreshSpecialInfo()
	{
	}

	[Token(Token = "0x600D3A3")]
	[Address(RVA = "0x2F8B38C", Offset = "0x2F8B38C", VA = "0x2F8B38C")]
	private void OnEquipSkill(object[] data)
	{
	}

	[Token(Token = "0x600D3A4")]
	[Address(RVA = "0x2F8B4D0", Offset = "0x2F8B4D0", VA = "0x2F8B4D0")]
	private void OnUnlockProfile(object[] data)
	{
	}

	[Token(Token = "0x600D3A5")]
	[Address(RVA = "0x2F8B52C", Offset = "0x2F8B52C", VA = "0x2F8B52C")]
	private void OnOpenAvatarList(object[] data)
	{
	}

	[Token(Token = "0x600D3A6")]
	[Address(RVA = "0x2F8B594", Offset = "0x2F8B594", VA = "0x2F8B594")]
	private void OnChooseAvatarClick()
	{
	}

	[Token(Token = "0x600D3A7")]
	[Address(RVA = "0x2F8B5E8", Offset = "0x2F8B5E8", VA = "0x2F8B5E8")]
	private void OnOpenAvatarListForLatest(object[] data)
	{
	}

	[Token(Token = "0x600D3A8")]
	[Address(RVA = "0x2F8B644", Offset = "0x2F8B644", VA = "0x2F8B644")]
	private void OnOpenSkillList(object[] data)
	{
	}

	[Token(Token = "0x600D3A9")]
	[Address(RVA = "0x2F8B87C", Offset = "0x2F8B87C", VA = "0x2F8B87C")]
	private void OnOpenProfileDetail(object[] data)
	{
	}

	[Token(Token = "0x600D3AA")]
	[Address(RVA = "0x2F89D40", Offset = "0x2F89D40", VA = "0x2F89D40")]
	private void RefreshAvatarProfileAndSuit(bool flag = true, bool fromSwitch = false)
	{
	}

	[Token(Token = "0x600D3AB")]
	[Address(RVA = "0x2F8B8D8", Offset = "0x2F8B8D8", VA = "0x2F8B8D8")]
	private void UpdateAvatarProfile(object[] data)
	{
	}

	[Token(Token = "0x600D3AC")]
	[Address(RVA = "0x2F8BA2C", Offset = "0x2F8BA2C", VA = "0x2F8BA2C")]
	private void OnSelectClick()
	{
	}

	[Token(Token = "0x600D3AD")]
	[Address(RVA = "0x2F86568", Offset = "0x2F86568", VA = "0x2F86568")]
	private void SendOnlyMsg()
	{
	}

	[Token(Token = "0x600D3AE")]
	[Address(RVA = "0x2F88C50", Offset = "0x2F88C50", VA = "0x2F88C50")]
	public void SendSelectedMsg()
	{
	}

	[Token(Token = "0x600D3AF")]
	[Address(RVA = "0x2F87AFC", Offset = "0x2F87AFC", VA = "0x2F87AFC")]
	private void RefreshBottomBtnGroup()
	{
	}

	[Token(Token = "0x600D3B0")]
	[Address(RVA = "0x2F8BA80", Offset = "0x2F8BA80", VA = "0x2F8BA80")]
	private void OnGainAvatarClick()
	{
	}

	[Token(Token = "0x600D3B1")]
	[Address(RVA = "0x2F8C238", Offset = "0x2F8C238", VA = "0x2F8C238")]
	private void OnGainAvatarByLinkClick()
	{
	}

	[Token(Token = "0x600D3B2")]
	[Address(RVA = "0x2F8C498", Offset = "0x2F8C498", VA = "0x2F8C498")]
	private void OnExChangeAwakenAvatar(uint toAvatarID)
	{
	}

	[Token(Token = "0x600D3B3")]
	[Address(RVA = "0x2F8C694", Offset = "0x2F8C694", VA = "0x2F8C694")]
	private void OnExchangeToAwakenAvatar()
	{
	}

	[Token(Token = "0x600D3B4")]
	[Address(RVA = "0x2F8C750", Offset = "0x2F8C750", VA = "0x2F8C750")]
	private void OnExchangeToOriAvatar()
	{
	}

	[Token(Token = "0x600D3B5")]
	[Address(RVA = "0x2F8BF9C", Offset = "0x2F8BF9C", VA = "0x2F8BF9C")]
	private void GainAvatar()
	{
	}

	[Token(Token = "0x600D3B6")]
	[Address(RVA = "0x2F8C80C", Offset = "0x2F8C80C", VA = "0x2F8C80C")]
	private void OnGainBundleBtnClick()
	{
	}

	[Token(Token = "0x600D3B7")]
	[Address(RVA = "0x2F8CD44", Offset = "0x2F8CD44", VA = "0x2F8CD44")]
	private void onDressClick()
	{
	}

	[Token(Token = "0x600D3B8")]
	[Address(RVA = "0x2F8D438", Offset = "0x2F8D438", VA = "0x2F8D438")]
	private void OnUseClick()
	{
	}

	[Token(Token = "0x600D3B9")]
	[Address(RVA = "0x2F8D49C", Offset = "0x2F8D49C", VA = "0x2F8D49C")]
	private void OnUseEx(bool callFromAvatarList = false)
	{
	}

	[Token(Token = "0x600D3BA")]
	[Address(RVA = "0x2F8D530", Offset = "0x2F8D530", VA = "0x2F8D530")]
	private void OnVaultBtnClick()
	{
	}

	[Token(Token = "0x600D3BB")]
	[Address(RVA = "0x2F8D668", Offset = "0x2F8D668", VA = "0x2F8D668")]
	private void OnProfileBtnClick()
	{
	}

	[Token(Token = "0x600D3BC")]
	[Address(RVA = "0x2F86624", Offset = "0x2F86624", VA = "0x2F86624")]
	private void RefreshVoiceBtnState()
	{
	}

	[Token(Token = "0x600D3BD")]
	[Address(RVA = "0x2F8D1EC", Offset = "0x2F8D1EC", VA = "0x2F8D1EC")]
	private bool CanChangeClothes()
	{
		return default(bool);
	}

	[Token(Token = "0x600D3BE")]
	[Address(RVA = "0x2F8DBB8", Offset = "0x2F8DBB8", VA = "0x2F8DBB8")]
	private void OnResetCurrentPreviewClothes(object[] param)
	{
	}

	[Token(Token = "0x600D3BF")]
	[Address(RVA = "0x2F8DDA8", Offset = "0x2F8DDA8", VA = "0x2F8DDA8")]
	private bool CheckSuitIsABReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600D3C0")]
	[Address(RVA = "0x2F8DF10", Offset = "0x2F8DF10", VA = "0x2F8DF10", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600D3C1")]
	[Address(RVA = "0x2F8E2B4", Offset = "0x2F8E2B4", VA = "0x2F8E2B4")]
	private static bool _003COnSwitchShowAvatar_003Em__0(AvatarSuit x)
	{
		return default(bool);
	}

	[Token(Token = "0x600D3C2")]
	[Address(RVA = "0x2F8E2D8", Offset = "0x2F8E2D8", VA = "0x2F8E2D8")]
	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600D3C3")]
	[Address(RVA = "0x2F8E2E0", Offset = "0x2F8E2E0", VA = "0x2F8E2E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D3C4")]
	[Address(RVA = "0x2F8E2E8", Offset = "0x2F8E2E8", VA = "0x2F8E2E8")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600D3C5")]
	[Address(RVA = "0x2F8E2F0", Offset = "0x2F8E2F0", VA = "0x2F8E2F0")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600D3C6")]
	[Address(RVA = "0x2F8E2F8", Offset = "0x2F8E2F8", VA = "0x2F8E2F8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600D3C7")]
	[Address(RVA = "0x2F8E300", Offset = "0x2F8E300", VA = "0x2F8E300")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D3C8")]
	[Address(RVA = "0x2F8E308", Offset = "0x2F8E308", VA = "0x2F8E308")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}
}
