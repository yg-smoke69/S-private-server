using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021D5")]
public class UIMallController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x20021D6")]
	private sealed class _003CPopMysteryCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D3A9")]
		[FieldOffset(Offset = "0x8")]
		internal object _0024current;

		[Token(Token = "0x400D3AA")]
		[FieldOffset(Offset = "0xC")]
		internal bool _0024disposing;

		[Token(Token = "0x400D3AB")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x1700102E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600B597")]
			[Address(RVA = "0x23A4DB0", Offset = "0x23A4DB0", VA = "0x23A4DB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700102F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600B598")]
			[Address(RVA = "0x23A4DB8", Offset = "0x23A4DB8", VA = "0x23A4DB8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600B595")]
		[Address(RVA = "0x239DAE0", Offset = "0x239DAE0", VA = "0x239DAE0")]
		public _003CPopMysteryCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600B596")]
		[Address(RVA = "0x23A4D50", Offset = "0x23A4D50", VA = "0x23A4D50", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600B599")]
		[Address(RVA = "0x23A4DC0", Offset = "0x23A4DC0", VA = "0x23A4DC0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600B59A")]
		[Address(RVA = "0x23A4DD4", Offset = "0x23A4DD4", VA = "0x23A4DD4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D37D")]
	private const uint MALLCDNBGNEARSUBTYPE = 4u;

	[Token(Token = "0x400D37E")]
	private const uint MALLCDNBGMIDDLESUBTYPE = 5u;

	[Token(Token = "0x400D37F")]
	private const uint MALLCDNBGFARSUBTYPE = 6u;

	[Token(Token = "0x400D380")]
	[FieldOffset(Offset = "0x7C")]
	private List<FriendInfo> m_SelectFriendList;

	[Token(Token = "0x400D381")]
	[FieldOffset(Offset = "0x80")]
	private EGiftStore_BuddyType m_FriendType;

	[Token(Token = "0x400D382")]
	[FieldOffset(Offset = "0x84")]
	private CollectionDataManager.ECollectionWeaponType m_WeaponPageFilterType;

	[Token(Token = "0x400D383")]
	[FieldOffset(Offset = "0x88")]
	private uint m_WeaponPageFilterId;

	[Token(Token = "0x400D384")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_WeaponClickId;

	[Token(Token = "0x400D385")]
	[FieldOffset(Offset = "0x90")]
	private UIMallViewExt m_View;

	[Token(Token = "0x400D386")]
	[FieldOffset(Offset = "0x94")]
	private bool m_ADDataInitialized;

	[Token(Token = "0x400D387")]
	[FieldOffset(Offset = "0x95")]
	private bool m_DataInitialized;

	[Token(Token = "0x400D388")]
	[FieldOffset(Offset = "0x96")]
	private bool m_GiftDataInitialized;

	[Token(Token = "0x400D389")]
	[FieldOffset(Offset = "0x97")]
	private bool m_ExchangeDataInitialized;

	[Token(Token = "0x400D38A")]
	[FieldOffset(Offset = "0x98")]
	private bool m_GiftRankDescDataInitialized;

	[Token(Token = "0x400D38B")]
	[FieldOffset(Offset = "0x99")]
	private bool m_DiscountDataInitialized;

	[Token(Token = "0x400D38C")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_InstallmentDataInitialized;

	[Token(Token = "0x400D38D")]
	[FieldOffset(Offset = "0x9C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400D38E")]
	[FieldOffset(Offset = "0xA0")]
	private UINavigationData m_LastNavigationData;

	[Token(Token = "0x400D38F")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_HasUnFinishNavigation;

	[Token(Token = "0x400D390")]
	[FieldOffset(Offset = "0xA8")]
	private UINavigationUtil.UINavigationMallType navMallType;

	[Token(Token = "0x400D391")]
	[FieldOffset(Offset = "0xAC")]
	private uint navMallTabType;

	[Token(Token = "0x400D392")]
	[FieldOffset(Offset = "0xB0")]
	private uint navMallSubTabType;

	[Token(Token = "0x400D393")]
	[FieldOffset(Offset = "0xB4")]
	private uint navMallItemId;

	[Token(Token = "0x400D394")]
	[FieldOffset(Offset = "0xB8")]
	private List<uint> navMallItemIdList;

	[Token(Token = "0x400D395")]
	[FieldOffset(Offset = "0xBC")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400D396")]
	[FieldOffset(Offset = "0xC0")]
	private UIModelGift m_ModelGift;

	[Token(Token = "0x400D397")]
	[FieldOffset(Offset = "0xC4")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x400D398")]
	[FieldOffset(Offset = "0xC8")]
	private UIModelCDNAd m_ModelCdnAd;

	[Token(Token = "0x400D399")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_InitMall;

	[Token(Token = "0x400D39A")]
	[FieldOffset(Offset = "0xD0")]
	private uint m_SelectedItemId;

	[Token(Token = "0x400D39B")]
	[FieldOffset(Offset = "0xD4")]
	private List<UIMallDetailBaseController> m_MallList;

	[Token(Token = "0x400D39C")]
	[FieldOffset(Offset = "0xD8")]
	private UIMallDetailBaseController m_CurrentMallController;

	[Token(Token = "0x400D39D")]
	[FieldOffset(Offset = "0xDC")]
	private Dictionary<uint, UIToggleButton> m_MallToggleDict;

	[Token(Token = "0x400D39E")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsInMall;

	[Token(Token = "0x400D39F")]
	[FieldOffset(Offset = "0xE4")]
	private FullscreenCgDesc m_AnimData;

	[Token(Token = "0x400D3A0")]
	[FieldOffset(Offset = "0xE8")]
	private List<string> m_URLList;

	[Token(Token = "0x400D3A1")]
	[FieldOffset(Offset = "0xEC")]
	private uint m_LastAvatarId;

	[Token(Token = "0x400D3A2")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_ChangeAvatar;

	[Token(Token = "0x400D3A3")]
	[FieldOffset(Offset = "0xF4")]
	private GameObject m_MallGround;

	[Token(Token = "0x400D3A4")]
	[FieldOffset(Offset = "0xF8")]
	private Dictionary<string, uint> m_MallItemClickLogCache;

	[Token(Token = "0x400D3A5")]
	[FieldOffset(Offset = "0xFC")]
	private Dictionary<uint, string> m_MallCdnDic;

	[Token(Token = "0x400D3A6")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D3A7")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400D3A8")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x1700102D")]
	public EGiftStore_BuddyType FriendType
	{
		[Token(Token = "0x600B54B")]
		[Address(RVA = "0x2399BC4", Offset = "0x2399BC4", VA = "0x2399BC4")]
		get
		{
			return default(EGiftStore_BuddyType);
		}
		[Token(Token = "0x600B54C")]
		[Address(RVA = "0x2399C1C", Offset = "0x2399C1C", VA = "0x2399C1C")]
		set
		{
		}
	}

	[Token(Token = "0x600B54A")]
	[Address(RVA = "0x2399A2C", Offset = "0x2399A2C", VA = "0x2399A2C")]
	public UIMallController()
	{
	}

	[Token(Token = "0x600B54D")]
	[Address(RVA = "0x2399C7C", Offset = "0x2399C7C", VA = "0x2399C7C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B54E")]
	[Address(RVA = "0x2399D20", Offset = "0x2399D20", VA = "0x2399D20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B54F")]
	[Address(RVA = "0x239AEAC", Offset = "0x239AEAC", VA = "0x239AEAC")]
	private void InitProcessCdnBg()
	{
	}

	[Token(Token = "0x600B550")]
	[Address(RVA = "0x239B288", Offset = "0x239B288", VA = "0x239B288")]
	private void DownLoadCDNTexture()
	{
	}

	[Token(Token = "0x600B551")]
	[Address(RVA = "0x239AC7C", Offset = "0x239AC7C", VA = "0x239AC7C")]
	private void InitToggleDict()
	{
	}

	[Token(Token = "0x600B552")]
	[Address(RVA = "0x239BA68", Offset = "0x239BA68", VA = "0x239BA68", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600B553")]
	[Address(RVA = "0x239DA28", Offset = "0x239DA28", VA = "0x239DA28")]
	private IEnumerator PopMysteryCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600B554")]
	[Address(RVA = "0x239D878", Offset = "0x239D878", VA = "0x239D878")]
	private void RefreshMallView()
	{
	}

	[Token(Token = "0x600B555")]
	[Address(RVA = "0x239CF24", Offset = "0x239CF24", VA = "0x239CF24")]
	private void NavigationToItemOnShowed()
	{
	}

	[Token(Token = "0x600B556")]
	[Address(RVA = "0x239C7F0", Offset = "0x239C7F0", VA = "0x239C7F0")]
	private void ShowAvatarInternal()
	{
	}

	[Token(Token = "0x600B557")]
	[Address(RVA = "0x239BE48", Offset = "0x239BE48", VA = "0x239BE48")]
	private void SetNavigationData(UINavigationData navigationData)
	{
	}

	[Token(Token = "0x600B558")]
	[Address(RVA = "0x239E8DC", Offset = "0x239E8DC", VA = "0x239E8DC", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600B559")]
	[Address(RVA = "0x239EBBC", Offset = "0x239EBBC", VA = "0x239EBBC")]
	private void ClickBundleItem(object[] data)
	{
	}

	[Token(Token = "0x600B55A")]
	[Address(RVA = "0x239EC74", Offset = "0x239EC74", VA = "0x239EC74", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B55B")]
	[Address(RVA = "0x239ED94", Offset = "0x239ED94", VA = "0x239ED94")]
	private void SendMallItemClickLog()
	{
	}

	[Token(Token = "0x600B55C")]
	[Address(RVA = "0x239F354", Offset = "0x239F354", VA = "0x239F354", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B55D")]
	[Address(RVA = "0x239F934", Offset = "0x239F934", VA = "0x239F934")]
	private void OnChooseHyperBook()
	{
	}

	[Token(Token = "0x600B55E")]
	[Address(RVA = "0x239FBA4", Offset = "0x239FBA4", VA = "0x239FBA4")]
	private void OnVaultBtnClick()
	{
	}

	[Token(Token = "0x600B55F")]
	[Address(RVA = "0x239FDDC", Offset = "0x239FDDC", VA = "0x239FDDC")]
	private void OnChooseCharacter()
	{
	}

	[Token(Token = "0x600B560")]
	[Address(RVA = "0x239DCC0", Offset = "0x239DCC0", VA = "0x239DCC0")]
	public void NavigationToItem(UINavigationUtil.UINavigationMallType mallType, uint storeID)
	{
	}

	[Token(Token = "0x600B561")]
	[Address(RVA = "0x239DAE8", Offset = "0x239DAE8", VA = "0x239DAE8")]
	public void NavigationToItem(UINavigationUtil.UINavigationMallType mallType, uint mallTabType, uint subTabType, uint storeID)
	{
	}

	[Token(Token = "0x600B562")]
	[Address(RVA = "0x23A004C", Offset = "0x23A004C", VA = "0x23A004C")]
	private void OnLabelModelHintChange(object[] data)
	{
	}

	[Token(Token = "0x600B563")]
	[Address(RVA = "0x23A0128", Offset = "0x23A0128", VA = "0x23A0128")]
	private void OnItemClick(object[] data)
	{
	}

	[Token(Token = "0x600B564")]
	[Address(RVA = "0x23A0620", Offset = "0x23A0620", VA = "0x23A0620")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B565")]
	[Address(RVA = "0x23A0BE4", Offset = "0x23A0BE4", VA = "0x23A0BE4")]
	private void PlayFullScreenAnim(FullscreenCgDesc animData)
	{
	}

	[Token(Token = "0x600B566")]
	[Address(RVA = "0x23A0E54", Offset = "0x23A0E54", VA = "0x23A0E54")]
	private void OnAvatarUpdate(object[] data)
	{
	}

	[Token(Token = "0x600B567")]
	[Address(RVA = "0x23A12E8", Offset = "0x23A12E8", VA = "0x23A12E8")]
	private void ShowMallItemTypeError(object[] data)
	{
	}

	[Token(Token = "0x600B568")]
	[Address(RVA = "0x23A15D8", Offset = "0x23A15D8", VA = "0x23A15D8")]
	private void RefreshClothPreviewTab(object[] data)
	{
	}

	[Token(Token = "0x600B569")]
	[Address(RVA = "0x23A1834", Offset = "0x23A1834", VA = "0x23A1834")]
	private void OnHideClothesSlot(object[] data)
	{
	}

	[Token(Token = "0x600B56A")]
	[Address(RVA = "0x23A1B30", Offset = "0x23A1B30", VA = "0x23A1B30", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B56B")]
	[Address(RVA = "0x23A1C0C", Offset = "0x23A1C0C", VA = "0x23A1C0C", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B56C")]
	[Address(RVA = "0x239CC20", Offset = "0x239CC20", VA = "0x239CC20")]
	private void InitMallView(bool refreshCurrentMallCtrl = false)
	{
	}

	[Token(Token = "0x600B56D")]
	[Address(RVA = "0x239C748", Offset = "0x239C748", VA = "0x239C748")]
	private bool IsDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600B56E")]
	[Address(RVA = "0x23A2408", Offset = "0x23A2408", VA = "0x23A2408")]
	private void UpdateTabs()
	{
	}

	[Token(Token = "0x600B56F")]
	[Address(RVA = "0x23A2AA4", Offset = "0x23A2AA4", VA = "0x23A2AA4")]
	private bool IsOpenNavToggle(UINavigationUtil.UINavigationMallType type)
	{
		return default(bool);
	}

	[Token(Token = "0x600B570")]
	[Address(RVA = "0x23A2B08", Offset = "0x23A2B08", VA = "0x23A2B08")]
	public static void SetSpriteWithStoreInfo(uint itemId, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	[Token(Token = "0x600B571")]
	[Address(RVA = "0x23A2F64", Offset = "0x23A2F64", VA = "0x23A2F64", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600B572")]
	[Address(RVA = "0x23A30EC", Offset = "0x23A30EC", VA = "0x23A30EC")]
	private void OnAnimPlayBtnClick()
	{
	}

	[Token(Token = "0x600B573")]
	[Address(RVA = "0x23A3524", Offset = "0x23A3524", VA = "0x23A3524")]
	private void OnNormalMallToggleClick()
	{
	}

	[Token(Token = "0x600B574")]
	[Address(RVA = "0x23A3698", Offset = "0x23A3698", VA = "0x23A3698")]
	private void OnWeaponMallToggleClick()
	{
	}

	[Token(Token = "0x600B575")]
	[Address(RVA = "0x23A380C", Offset = "0x23A380C", VA = "0x23A380C")]
	private void OnBoxMallToggleClick()
	{
	}

	[Token(Token = "0x600B576")]
	[Address(RVA = "0x23A3980", Offset = "0x23A3980", VA = "0x23A3980")]
	private void OnGiftMallToggleClick()
	{
	}

	[Token(Token = "0x600B577")]
	[Address(RVA = "0x23A3AF4", Offset = "0x23A3AF4", VA = "0x23A3AF4")]
	private void OnExchangeMallToggleClick()
	{
	}

	[Token(Token = "0x600B578")]
	[Address(RVA = "0x239D1B8", Offset = "0x239D1B8", VA = "0x239D1B8")]
	private void SelectMall(UINavigationUtil.UINavigationMallType mallType)
	{
	}

	[Token(Token = "0x600B579")]
	[Address(RVA = "0x23A3FC4", Offset = "0x23A3FC4", VA = "0x23A3FC4")]
	private UIMallDetailBaseController CreateMallDetailController(UINavigationUtil.UINavigationMallType mallType)
	{
		return null;
	}

	[Token(Token = "0x600B57A")]
	[Address(RVA = "0x23A3C68", Offset = "0x23A3C68", VA = "0x23A3C68")]
	public void IsShowHyperBookBtn(bool show)
	{
	}

	[Token(Token = "0x600B57B")]
	[Address(RVA = "0x23A42A0", Offset = "0x23A42A0", VA = "0x23A42A0")]
	public void IsShowMallToggle(bool show)
	{
	}

	[Token(Token = "0x600B57C")]
	[Address(RVA = "0x23A4358", Offset = "0x23A4358", VA = "0x23A4358")]
	public void IsShowTopBar(bool show)
	{
	}

	[Token(Token = "0x600B57D")]
	[Address(RVA = "0x23A43F0", Offset = "0x23A43F0", VA = "0x23A43F0")]
	public void IsShowAnimPlayBtn(bool show)
	{
	}

	[Token(Token = "0x600B57E")]
	[Address(RVA = "0x23A44A8", Offset = "0x23A44A8", VA = "0x23A44A8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B57F")]
	[Address(RVA = "0x23A4678", Offset = "0x23A4678", VA = "0x23A4678", Slot = "37")]
	protected override bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600B580")]
	[Address(RVA = "0x23A46D0", Offset = "0x23A46D0", VA = "0x23A46D0")]
	private void OnHairUpdate(object[] data)
	{
	}

	[Token(Token = "0x600B581")]
	[Address(RVA = "0x23A475C", Offset = "0x23A475C", VA = "0x23A475C", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600B582")]
	[Address(RVA = "0x23A47CC", Offset = "0x23A47CC", VA = "0x23A47CC", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600B583")]
	[Address(RVA = "0x23A4824", Offset = "0x23A4824", VA = "0x23A4824", Slot = "47")]
	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x600B584")]
	[Address(RVA = "0x23A48DC", Offset = "0x23A48DC", VA = "0x23A48DC")]
	public FrontEndPreviewComponent GetFrontEndPreviewComponentInternal()
	{
		return null;
	}

	[Token(Token = "0x600B585")]
	[Address(RVA = "0x23A4934", Offset = "0x23A4934", VA = "0x23A4934", Slot = "44")]
	protected override bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x600B586")]
	[Address(RVA = "0x23A498C", Offset = "0x23A498C", VA = "0x23A498C", Slot = "63")]
	protected override void SetBgByCameraType(object[] param)
	{
	}

	[Token(Token = "0x600B587")]
	[Address(RVA = "0x23A4C68", Offset = "0x23A4C68", VA = "0x23A4C68")]
	private static bool _003CInitProcessCdnBg_003Em__0(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600B588")]
	[Address(RVA = "0x23A4C98", Offset = "0x23A4C98", VA = "0x23A4C98")]
	private static bool _003CInitProcessCdnBg_003Em__1(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600B589")]
	[Address(RVA = "0x23A4CC8", Offset = "0x23A4CC8", VA = "0x23A4CC8")]
	private static bool _003CInitProcessCdnBg_003Em__2(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600B58A")]
	[Address(RVA = "0x23A4CF8", Offset = "0x23A4CF8", VA = "0x23A4CF8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B58B")]
	[Address(RVA = "0x23A4D00", Offset = "0x23A4D00", VA = "0x23A4D00")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600B58C")]
	[Address(RVA = "0x23A4D08", Offset = "0x23A4D08", VA = "0x23A4D08")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600B58D")]
	[Address(RVA = "0x23A4D10", Offset = "0x23A4D10", VA = "0x23A4D10")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600B58E")]
	[Address(RVA = "0x23A4D18", Offset = "0x23A4D18", VA = "0x23A4D18")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B58F")]
	[Address(RVA = "0x23A4D20", Offset = "0x23A4D20", VA = "0x23A4D20")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600B590")]
	[Address(RVA = "0x23A4D28", Offset = "0x23A4D28", VA = "0x23A4D28")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B591")]
	[Address(RVA = "0x23A4D30", Offset = "0x23A4D30", VA = "0x23A4D30")]
	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600B592")]
	[Address(RVA = "0x23A4D38", Offset = "0x23A4D38", VA = "0x23A4D38")]
	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x600B593")]
	[Address(RVA = "0x23A4D40", Offset = "0x23A4D40", VA = "0x23A4D40")]
	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x600B594")]
	[Address(RVA = "0x23A4D48", Offset = "0x23A4D48", VA = "0x23A4D48")]
	public void _003C_003EiFixBaseProxy_SetBgByCameraType(object[] P0)
	{
	}
}
