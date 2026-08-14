using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029F5")]
public class UINewVaultController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x20029F6")]
	private sealed class _003COnClickEmoteSlot_003Ec__AnonStorey1
	{
		[Token(Token = "0x401025B")]
		[FieldOffset(Offset = "0x8")]
		internal uint emoteID;

		[Token(Token = "0x6010F1A")]
		[Address(RVA = "0x2C05050", Offset = "0x2C05050", VA = "0x2C05050")]
		public _003COnClickEmoteSlot_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010F1B")]
		[Address(RVA = "0x2C1B434", Offset = "0x2C1B434", VA = "0x2C1B434")]
		internal bool _003C_003Em__0(UINewVaultEmoteItemController item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20029F7")]
	private sealed class _003CRefreshShowData_003Ec__AnonStorey2
	{
		[Token(Token = "0x401025C")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x401025D")]
		[FieldOffset(Offset = "0xC")]
		internal UINewVaultController _0024this;

		[Token(Token = "0x6010F1C")]
		[Address(RVA = "0x2C0A414", Offset = "0x2C0A414", VA = "0x2C0A414")]
		public _003CRefreshShowData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6010F1D")]
		[Address(RVA = "0x2C1B4F0", Offset = "0x2C1B4F0", VA = "0x2C1B4F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20029F8")]
	private sealed class _003CMovePanelShowColor_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401025E")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CminDelta_003E__0;

		[Token(Token = "0x401025F")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CmoveSpeed_003E__0;

		[Token(Token = "0x4010260")]
		[FieldOffset(Offset = "0x10")]
		internal int posY;

		[Token(Token = "0x4010261")]
		[FieldOffset(Offset = "0x14")]
		internal Vector2 _003Coffset_003E__1;

		[Token(Token = "0x4010262")]
		[FieldOffset(Offset = "0x1C")]
		internal int _003Cadd_003E__1;

		[Token(Token = "0x4010263")]
		[FieldOffset(Offset = "0x20")]
		internal UINewVaultController _0024this;

		[Token(Token = "0x4010264")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x4010265")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x4010266")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17001273")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010F20")]
			[Address(RVA = "0x2C1B388", Offset = "0x2C1B388", VA = "0x2C1B388", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001274")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010F21")]
			[Address(RVA = "0x2C1B390", Offset = "0x2C1B390", VA = "0x2C1B390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010F1E")]
		[Address(RVA = "0x2C14C0C", Offset = "0x2C14C0C", VA = "0x2C14C0C")]
		public _003CMovePanelShowColor_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010F1F")]
		[Address(RVA = "0x2C1B0B8", Offset = "0x2C1B0B8", VA = "0x2C1B0B8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010F22")]
		[Address(RVA = "0x2C1B398", Offset = "0x2C1B398", VA = "0x2C1B398", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010F23")]
		[Address(RVA = "0x2C1B3AC", Offset = "0x2C1B3AC", VA = "0x2C1B3AC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401020D")]
	[FieldOffset(Offset = "0x7C")]
	private UINewVaultView m_View;

	[Token(Token = "0x401020E")]
	[FieldOffset(Offset = "0x80")]
	private UIModelNewVault m_modelNewVault;

	[Token(Token = "0x401020F")]
	[FieldOffset(Offset = "0x84")]
	private UIModelCollection m_modelCollection;

	[Token(Token = "0x4010210")]
	[FieldOffset(Offset = "0x88")]
	private UIModelInventory m_modelInventory;

	[Token(Token = "0x4010211")]
	[FieldOffset(Offset = "0x8C")]
	private UIModelLadderMatch m_modelLadder;

	[Token(Token = "0x4010212")]
	[FieldOffset(Offset = "0x90")]
	private UIModelOptionalDownload m_modelOptionalDownload;

	[Token(Token = "0x4010213")]
	[FieldOffset(Offset = "0x94")]
	private UIStandardTabController m_TabCtrl;

	[Token(Token = "0x4010214")]
	[FieldOffset(Offset = "0x98")]
	private UINewVaultSecondTabController m_secondTabCtrl;

	[Token(Token = "0x4010215")]
	[FieldOffset(Offset = "0x9C")]
	private List<int> m_listSortedFirstTabID;

	[Token(Token = "0x4010216")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<int, List<int>> m_dicShowTabs;

	[Token(Token = "0x4010217")]
	[FieldOffset(Offset = "0xA4")]
	private uint[] m_curSortedItemIDs;

	[Token(Token = "0x4010218")]
	[FieldOffset(Offset = "0xA8")]
	private List<UINewVaultItemViewData> m_curSortedItemViewDatas;

	[Token(Token = "0x4010219")]
	[FieldOffset(Offset = "0xAC")]
	private List<StandardTabItemViewData> m_listFirstTabViewData;

	[Token(Token = "0x401021A")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<int, List<UINewVaultSecondTabItemViewData>> m_dicSecondTabViewData;

	[Token(Token = "0x401021B")]
	[FieldOffset(Offset = "0xB4")]
	private UINewVaultEmoteSlotController[] m_emoteSlotControllerArray;

	[Token(Token = "0x401021C")]
	[FieldOffset(Offset = "0xB8")]
	private UINewVaultEmoteSlotController m_curSelectEmoteSlot;

	[Token(Token = "0x401021D")]
	[FieldOffset(Offset = "0xBC")]
	private UINewVaultNormalContainerController m_normalContainer;

	[Token(Token = "0x401021E")]
	[FieldOffset(Offset = "0xC0")]
	private UINewVaultBannerContainerController m_bannerContainer;

	[Token(Token = "0x401021F")]
	[FieldOffset(Offset = "0xC4")]
	private UINewVaultEmoteContainerController m_emoteContainer;

	[Token(Token = "0x4010220")]
	[FieldOffset(Offset = "0xC8")]
	private UINewVaultHeadPicContainerController m_headPicContainer;

	[Token(Token = "0x4010221")]
	[FieldOffset(Offset = "0xCC")]
	private UINewVaultMusicContainerController m_musicContainer;

	[Token(Token = "0x4010222")]
	[FieldOffset(Offset = "0xD0")]
	private UINewVaultInstallmentContainerController m_installmentContainer;

	[Token(Token = "0x4010223")]
	[FieldOffset(Offset = "0xD4")]
	private UINewVaultHeadPreviewController m_headPreviewCtrl;

	[Token(Token = "0x4010224")]
	[FieldOffset(Offset = "0xD8")]
	private UINewVaultClothSetRecommendController m_ClothSetRecommendCtrl;

	[Token(Token = "0x4010225")]
	private const string DressUpEffectKey = "DressUpFirstShowEffect";

	[Token(Token = "0x4010226")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_bIsClickCloth;

	[Token(Token = "0x4010227")]
	[FieldOffset(Offset = "0xDD")]
	private bool m_DefaultMusicCheckState;

	[Token(Token = "0x4010228")]
	[FieldOffset(Offset = "0xE0")]
	private AvatarWardrobeData m_ClothesDataForHideBackpack;

	[Token(Token = "0x4010229")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_bIsBagShowInGame;

	[Token(Token = "0x401022A")]
	[FieldOffset(Offset = "0xE8")]
	private Coroutine m_CorShowEmote;

	[Token(Token = "0x401022B")]
	[FieldOffset(Offset = "0xEC")]
	private Coroutine m_CorShowFinishAnim;

	[Token(Token = "0x401022C")]
	[FieldOffset(Offset = "0xF0")]
	private int m_nTempEquipItemID;

	[Token(Token = "0x401022D")]
	[FieldOffset(Offset = "0xF4")]
	private int m_nCurFirstTabID;

	[Token(Token = "0x401022E")]
	[FieldOffset(Offset = "0xF8")]
	private int m_nCurFirstIndex;

	[Token(Token = "0x401022F")]
	[FieldOffset(Offset = "0xFC")]
	private int m_nCurSecondTabID;

	[Token(Token = "0x4010230")]
	[FieldOffset(Offset = "0x100")]
	private int m_nCurSecondTabIndex;

	[Token(Token = "0x4010231")]
	[FieldOffset(Offset = "0x104")]
	private int m_nCurSelectItemID;

	[Token(Token = "0x4010232")]
	[FieldOffset(Offset = "0x108")]
	private int m_nCurSelectItemIndex;

	[Token(Token = "0x4010233")]
	[FieldOffset(Offset = "0x10C")]
	private int m_nLastFirstTabID;

	[Token(Token = "0x4010234")]
	[FieldOffset(Offset = "0x110")]
	private int m_nLastFirstIndex;

	[Token(Token = "0x4010235")]
	[FieldOffset(Offset = "0x114")]
	private int m_nLastSecondTabID;

	[Token(Token = "0x4010236")]
	[FieldOffset(Offset = "0x118")]
	private int m_nLastSecondTabIndex;

	[Token(Token = "0x4010237")]
	[FieldOffset(Offset = "0x11C")]
	private int m_nLastSelectItemID;

	[Token(Token = "0x4010238")]
	[FieldOffset(Offset = "0x120")]
	private int m_nLastSelectItemIndex;

	[Token(Token = "0x4010239")]
	[FieldOffset(Offset = "0x124")]
	private int m_nSelectEmoteSlotBagIndex;

	[Token(Token = "0x401023A")]
	[FieldOffset(Offset = "0x128")]
	private bool m_bIsNewVaultModelInit;

	[Token(Token = "0x401023B")]
	[FieldOffset(Offset = "0x129")]
	private bool m_bIsInventoryModelInit;

	[Token(Token = "0x401023C")]
	[FieldOffset(Offset = "0x12A")]
	private bool m_bIsInstallmentInit;

	[Token(Token = "0x401023D")]
	[FieldOffset(Offset = "0x12B")]
	private bool m_bIsShowNavigationInit;

	[Token(Token = "0x401023E")]
	[FieldOffset(Offset = "0x12C")]
	private bool m_bIsInit;

	[Token(Token = "0x401023F")]
	[FieldOffset(Offset = "0x12D")]
	private bool m_IsColorPanelShow;

	[Token(Token = "0x4010240")]
	[FieldOffset(Offset = "0x130")]
	private Coroutine m_CoroutineMovePanelShowColor;

	[Token(Token = "0x4010241")]
	[FieldOffset(Offset = "0x134")]
	private bool m_bIsNeedHandleJump;

	[Token(Token = "0x4010242")]
	[FieldOffset(Offset = "0x138")]
	private int m_nJumpFirstTabId;

	[Token(Token = "0x4010243")]
	[FieldOffset(Offset = "0x13C")]
	private int m_nJumpSecondTabId;

	[Token(Token = "0x4010244")]
	[FieldOffset(Offset = "0x140")]
	private int m_nJumpItemId;

	[Token(Token = "0x4010245")]
	[FieldOffset(Offset = "0x144")]
	private int m_nLastNavigationCloseFirstTabID;

	[Token(Token = "0x4010246")]
	[FieldOffset(Offset = "0x148")]
	private int m_nLastNavigationCloseSecondTabID;

	[Token(Token = "0x4010247")]
	[FieldOffset(Offset = "0x14C")]
	private uint m_GuideDelayCall;

	[Token(Token = "0x4010248")]
	[FieldOffset(Offset = "0x150")]
	private uint m_RepositionDelayCall;

	[Token(Token = "0x4010249")]
	private const int STAGE_FIRST_TAB = 1;

	[Token(Token = "0x401024A")]
	private const int STAGE_COLLECTION = 2;

	[Token(Token = "0x401024B")]
	private const int STAGE_SECOND_TAB = 3;

	[Token(Token = "0x401024C")]
	private const string DEFAULT_NEW_VAULT_GOTO_KEY = "T_32_LC_NEWVAULT_GOTO";

	[Token(Token = "0x401024D")]
	[FieldOffset(Offset = "0x154")]
	private bool m_bIsWaitingHttp;

	[Token(Token = "0x401024E")]
	[FieldOffset(Offset = "0x158")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x401024F")]
	[FieldOffset(Offset = "0x15C")]
	private readonly uint[] m_DefaultSortIDs;

	[Token(Token = "0x4010250")]
	[FieldOffset(Offset = "0x160")]
	private UIModelAvatar m_modelAvatar;

	[Token(Token = "0x4010251")]
	[FieldOffset(Offset = "0x164")]
	private uint m_unRefreshPageDelayCall;

	[Token(Token = "0x4010252")]
	[FieldOffset(Offset = "0x168")]
	private uint m_unRefreshAvatarPos;

	[Token(Token = "0x4010253")]
	[FieldOffset(Offset = "0x16C")]
	private UIHudTestInGameVaultSearchController testInGameVaultSearchController;

	[Token(Token = "0x4010254")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<UIEasyListItemController, UINewVaultEmoteItemController> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010255")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4010256")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4010257")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4010258")]
	[FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4010259")]
	[FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x401025A")]
	[FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cache6;

	[Token(Token = "0x6010E8C")]
	[Address(RVA = "0x2C0335C", Offset = "0x2C0335C", VA = "0x2C0335C")]
	public UINewVaultController()
	{
	}

	[Token(Token = "0x6010E8D")]
	[Address(RVA = "0x2C03478", Offset = "0x2C03478", VA = "0x2C03478")]
	private int SecondTabID2FirstTabID(int secondTabID)
	{
		return default(int);
	}

	[Token(Token = "0x6010E8E")]
	[Address(RVA = "0x2C03720", Offset = "0x2C03720", VA = "0x2C03720")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E8F")]
	[Address(RVA = "0x2C037C8", Offset = "0x2C037C8", VA = "0x2C037C8", Slot = "44")]
	protected override bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x6010E90")]
	[Address(RVA = "0x2C03820", Offset = "0x2C03820", VA = "0x2C03820")]
	private Transform GetSlotParentNodeByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6010E91")]
	[Address(RVA = "0x2C03994", Offset = "0x2C03994", VA = "0x2C03994")]
	private void LoadContainer()
	{
	}

	[Token(Token = "0x6010E92")]
	[Address(RVA = "0x2C041FC", Offset = "0x2C041FC", VA = "0x2C041FC")]
	private void OnSwitchSecondTabModifyEasyContainer()
	{
	}

	[Token(Token = "0x6010E93")]
	[Address(RVA = "0x2C045E8", Offset = "0x2C045E8", VA = "0x2C045E8")]
	private UIEasyList GetCurEasyList()
	{
		return null;
	}

	[Token(Token = "0x6010E94")]
	[Address(RVA = "0x2C047D0", Offset = "0x2C047D0", VA = "0x2C047D0")]
	private void LoadEmoteSlots()
	{
	}

	[Token(Token = "0x6010E95")]
	[Address(RVA = "0x2C049E8", Offset = "0x2C049E8", VA = "0x2C049E8")]
	private void RefreshEmoteBooyahCheck()
	{
	}

	[Token(Token = "0x6010E96")]
	[Address(RVA = "0x2C04C0C", Offset = "0x2C04C0C", VA = "0x2C04C0C")]
	private void OnClickEmoteSlot(int index, bool isSelectItem)
	{
	}

	[Token(Token = "0x6010E97")]
	[Address(RVA = "0x2C051A4", Offset = "0x2C051A4", VA = "0x2C051A4")]
	private void RefreshEmoteEquipBtnAndUnEquipBtnState()
	{
	}

	[Token(Token = "0x6010E98")]
	[Address(RVA = "0x2C0548C", Offset = "0x2C0548C", VA = "0x2C0548C")]
	private void RefreshEmoteSlots()
	{
	}

	[Token(Token = "0x6010E99")]
	[Address(RVA = "0x2C05740", Offset = "0x2C05740", VA = "0x2C05740")]
	private void RefreshEmoteLabel()
	{
	}

	[Token(Token = "0x6010E9A")]
	[Address(RVA = "0x2C05A00", Offset = "0x2C05A00", VA = "0x2C05A00")]
	private void OnSlotStartDrag()
	{
	}

	[Token(Token = "0x6010E9B")]
	[Address(RVA = "0x2C05A90", Offset = "0x2C05A90", VA = "0x2C05A90")]
	private void OnSlotEndDrag()
	{
	}

	[Token(Token = "0x6010E9C")]
	[Address(RVA = "0x2C05B20", Offset = "0x2C05B20", VA = "0x2C05B20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E9D")]
	[Address(RVA = "0x2C06EA4", Offset = "0x2C06EA4", VA = "0x2C06EA4")]
	private void OnEmoteUpdate(object[] data)
	{
	}

	[Token(Token = "0x6010E9E")]
	[Address(RVA = "0x2C06F14", Offset = "0x2C06F14", VA = "0x2C06F14")]
	private void OnCallsignBtnToggled()
	{
	}

	[Token(Token = "0x6010E9F")]
	[Address(RVA = "0x2C07BDC", Offset = "0x2C07BDC", VA = "0x2C07BDC")]
	private void OnHelpButtonClicked()
	{
	}

	[Token(Token = "0x6010EA0")]
	[Address(RVA = "0x2C07E38", Offset = "0x2C07E38", VA = "0x2C07E38")]
	private void OnBtnRepayClick()
	{
	}

	[Token(Token = "0x6010EA1")]
	[Address(RVA = "0x2C0806C", Offset = "0x2C0806C", VA = "0x2C0806C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010EA2")]
	[Address(RVA = "0x2C080D0", Offset = "0x2C080D0", VA = "0x2C080D0")]
	private void OnEmoteCheckClick()
	{
	}

	[Token(Token = "0x6010EA3")]
	[Address(RVA = "0x2C08548", Offset = "0x2C08548", VA = "0x2C08548")]
	private void OnClickBtnGoToDressUp()
	{
	}

	[Token(Token = "0x6010EA4")]
	[Address(RVA = "0x2C087D4", Offset = "0x2C087D4", VA = "0x2C087D4")]
	private void RepositionTopItems()
	{
	}

	[Token(Token = "0x6010EA5")]
	[Address(RVA = "0x2C08A50", Offset = "0x2C08A50", VA = "0x2C08A50", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6010EA6")]
	[Address(RVA = "0x2C091C4", Offset = "0x2C091C4", VA = "0x2C091C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6010EA7")]
	[Address(RVA = "0x2C094D8", Offset = "0x2C094D8", VA = "0x2C094D8", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6010EA8")]
	[Address(RVA = "0x2C092DC", Offset = "0x2C092DC", VA = "0x2C092DC")]
	private bool IsHttpWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x6010EA9")]
	[Address(RVA = "0x2C097E8", Offset = "0x2C097E8", VA = "0x2C097E8", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010EAA")]
	[Address(RVA = "0x2C09B3C", Offset = "0x2C09B3C", VA = "0x2C09B3C")]
	private void RefreshShowData(bool isForce = false)
	{
	}

	[Token(Token = "0x6010EAB")]
	[Address(RVA = "0x2C0A41C", Offset = "0x2C0A41C", VA = "0x2C0A41C")]
	private void OnCloseTips(UIModelNewVault.eSecondTab obj)
	{
	}

	[Token(Token = "0x6010EAC")]
	[Address(RVA = "0x2C0A478", Offset = "0x2C0A478", VA = "0x2C0A478")]
	private void OnRefreshSecondIcon(UIModelNewVault.eSecondTab tab, UINewVaultSecondTabItemController ctrl)
	{
	}

	[Token(Token = "0x6010EAD")]
	[Address(RVA = "0x2C0A4E8", Offset = "0x2C0A4E8", VA = "0x2C0A4E8")]
	private void OnClickSecondTab(int index)
	{
	}

	[Token(Token = "0x6010EAE")]
	[Address(RVA = "0x2C0A6C8", Offset = "0x2C0A6C8", VA = "0x2C0A6C8")]
	private int ItemId2Index(int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x6010EAF")]
	[Address(RVA = "0x2C0A7FC", Offset = "0x2C0A7FC", VA = "0x2C0A7FC")]
	private void OnClickItem(int index)
	{
	}

	[Token(Token = "0x6010EB0")]
	[Address(RVA = "0x2C0B88C", Offset = "0x2C0B88C", VA = "0x2C0B88C")]
	private void ClearTempEquipID()
	{
	}

	[Token(Token = "0x6010EB1")]
	[Address(RVA = "0x2C0B8E8", Offset = "0x2C0B8E8", VA = "0x2C0B8E8")]
	private void RefreshLocalEquipState()
	{
	}

	[Token(Token = "0x6010EB2")]
	[Address(RVA = "0x2C0C1A8", Offset = "0x2C0C1A8", VA = "0x2C0C1A8")]
	private UINewVaultSecondTabItemViewData GetCurSecondTabViewData()
	{
		return null;
	}

	[Token(Token = "0x6010EB3")]
	[Address(RVA = "0x2C0C308", Offset = "0x2C0C308", VA = "0x2C0C308")]
	private void RecordTempEquipID(int selectItemID)
	{
	}

	[Token(Token = "0x6010EB4")]
	[Address(RVA = "0x2C0B2FC", Offset = "0x2C0B2FC", VA = "0x2C0B2FC")]
	private void OnItemEnter()
	{
	}

	[Token(Token = "0x6010EB5")]
	[Address(RVA = "0x2C0AAC4", Offset = "0x2C0AAC4", VA = "0x2C0AAC4")]
	private void OnItemExit()
	{
	}

	[Token(Token = "0x6010EB6")]
	[Address(RVA = "0x2C0C9F4", Offset = "0x2C0C9F4", VA = "0x2C0C9F4")]
	private void OnlyShowItemToPreview(int index = 0)
	{
	}

	[Token(Token = "0x6010EB7")]
	[Address(RVA = "0x2C0D8E4", Offset = "0x2C0D8E4", VA = "0x2C0D8E4")]
	private void OnEquipVehicle(int itemID)
	{
	}

	[Token(Token = "0x6010EB8")]
	[Address(RVA = "0x2C0DAB4", Offset = "0x2C0DAB4", VA = "0x2C0DAB4")]
	private void RequestChooseItem(UIModelNewVault.eSecondTab secondTab, int itemID, Action callback)
	{
	}

	[Token(Token = "0x6010EB9")]
	[Address(RVA = "0x2C07328", Offset = "0x2C07328", VA = "0x2C07328")]
	private void RequestChooseItem(UIModelNewVault.eSecondTab secondTab, int itemID)
	{
	}

	[Token(Token = "0x6010EBA")]
	[Address(RVA = "0x2C0DED8", Offset = "0x2C0DED8", VA = "0x2C0DED8")]
	public void RemoteConsoleShowCollection(uint itemID)
	{
	}

	[Token(Token = "0x6010EBB")]
	[Address(RVA = "0x2C0E1D4", Offset = "0x2C0E1D4", VA = "0x2C0E1D4")]
	private void OnlyRefreshTabRedPoint(object[] data)
	{
	}

	[Token(Token = "0x6010EBC")]
	[Address(RVA = "0x2C0ABC4", Offset = "0x2C0ABC4", VA = "0x2C0ABC4")]
	private void OnClickItemByID(int itemID)
	{
	}

	[Token(Token = "0x6010EBD")]
	[Address(RVA = "0x2C0D120", Offset = "0x2C0D120", VA = "0x2C0D120")]
	private void RefreshBGMPreview(uint itemId)
	{
	}

	[Token(Token = "0x6010EBE")]
	[Address(RVA = "0x2C0E7A0", Offset = "0x2C0E7A0", VA = "0x2C0E7A0")]
	private void UpdateNewGet(int itemId)
	{
	}

	[Token(Token = "0x6010EBF")]
	[Address(RVA = "0x2C0EF58", Offset = "0x2C0EF58", VA = "0x2C0EF58")]
	private void RefreshClothSecondTab()
	{
	}

	[Token(Token = "0x6010EC0")]
	[Address(RVA = "0x2C0F8E8", Offset = "0x2C0F8E8", VA = "0x2C0F8E8")]
	private void OnOthersSecondTabsExit()
	{
	}

	[Token(Token = "0x6010EC1")]
	[Address(RVA = "0x2C0C488", Offset = "0x2C0C488", VA = "0x2C0C488")]
	private void RefreshGotoBtn()
	{
	}

	[Token(Token = "0x6010EC2")]
	[Address(RVA = "0x2C0F134", Offset = "0x2C0F134", VA = "0x2C0F134")]
	private void RefreshClothItemEquipState()
	{
	}

	[Token(Token = "0x6010EC3")]
	[Address(RVA = "0x2C0F30C", Offset = "0x2C0F30C", VA = "0x2C0F30C")]
	private void RefreshClothSetBtnState()
	{
	}

	[Token(Token = "0x6010EC4")]
	[Address(RVA = "0x2C0C430", Offset = "0x2C0C430", VA = "0x2C0C430")]
	private UIModelNewVault.eSecondTab GetCurSecondTab()
	{
		return default(UIModelNewVault.eSecondTab);
	}

	[Token(Token = "0x6010EC5")]
	[Address(RVA = "0x2C0AA1C", Offset = "0x2C0AA1C", VA = "0x2C0AA1C")]
	private int Index2ItemID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6010EC6")]
	[Address(RVA = "0x2C0FA48", Offset = "0x2C0FA48", VA = "0x2C0FA48")]
	private UIModelNewVault.eSecondTab Index2SecondTab(int index)
	{
		return default(UIModelNewVault.eSecondTab);
	}

	[Token(Token = "0x6010EC7")]
	[Address(RVA = "0x2C096A8", Offset = "0x2C096A8", VA = "0x2C096A8")]
	private void SwitchSecondTab(int index, bool isForce = false)
	{
	}

	[Token(Token = "0x6010EC8")]
	[Address(RVA = "0x2C0FCF0", Offset = "0x2C0FCF0", VA = "0x2C0FCF0")]
	private void RefreshCurSortedItemData()
	{
	}

	[Token(Token = "0x6010EC9")]
	[Address(RVA = "0x2C10DA8", Offset = "0x2C10DA8", VA = "0x2C10DA8")]
	private void OnSecondTabEnter()
	{
	}

	[Token(Token = "0x6010ECA")]
	[Address(RVA = "0x2C113F8", Offset = "0x2C113F8", VA = "0x2C113F8")]
	private void OnFashionSecondTabExit()
	{
	}

	[Token(Token = "0x6010ECB")]
	[Address(RVA = "0x2C100AC", Offset = "0x2C100AC", VA = "0x2C100AC")]
	private void OnSecondTabExit()
	{
	}

	[Token(Token = "0x6010ECC")]
	[Address(RVA = "0x2C11F34", Offset = "0x2C11F34", VA = "0x2C11F34")]
	private void RequestChooseBagShow(bool isBagShowInGame, int itemID)
	{
	}

	[Token(Token = "0x6010ECD")]
	[Address(RVA = "0x2C1194C", Offset = "0x2C1194C", VA = "0x2C1194C")]
	private void CloseTipBySecondTabExit()
	{
	}

	[Token(Token = "0x6010ECE")]
	[Address(RVA = "0x2C12274", Offset = "0x2C12274", VA = "0x2C12274")]
	public void SelectItemByIndex(int index)
	{
	}

	[Token(Token = "0x6010ECF")]
	[Address(RVA = "0x2C08EBC", Offset = "0x2C08EBC", VA = "0x2C08EBC")]
	private void Init()
	{
	}

	[Token(Token = "0x6010ED0")]
	[Address(RVA = "0x2C0FB9C", Offset = "0x2C0FB9C", VA = "0x2C0FB9C")]
	private int SecondTabIndex2SecondTab(int secondIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6010ED1")]
	[Address(RVA = "0x2C124C8", Offset = "0x2C124C8", VA = "0x2C124C8")]
	private int SecondTabId2Index(int secondTabId)
	{
		return default(int);
	}

	[Token(Token = "0x6010ED2")]
	[Address(RVA = "0x2C12640", Offset = "0x2C12640", VA = "0x2C12640")]
	private int FirstTabIndex2FirstTabID(int index)
	{
		return default(int);
	}

	[Token(Token = "0x6010ED3")]
	[Address(RVA = "0x2C12158", Offset = "0x2C12158", VA = "0x2C12158")]
	private int FirstTabID2Index(int tabId)
	{
		return default(int);
	}

	[Token(Token = "0x6010ED4")]
	[Address(RVA = "0x2C0957C", Offset = "0x2C0957C", VA = "0x2C0957C")]
	private void SwitchFirstTab(int index, bool isForce = false)
	{
	}

	[Token(Token = "0x6010ED5")]
	[Address(RVA = "0x2C12E54", Offset = "0x2C12E54", VA = "0x2C12E54")]
	private void OnFirstTabEnter()
	{
	}

	[Token(Token = "0x6010ED6")]
	[Address(RVA = "0x2C0683C", Offset = "0x2C0683C", VA = "0x2C0683C")]
	private void ClearAllRightNode()
	{
	}

	[Token(Token = "0x6010ED7")]
	[Address(RVA = "0x2C12744", Offset = "0x2C12744", VA = "0x2C12744")]
	private void OnFirstTabExit()
	{
	}

	[Token(Token = "0x6010ED8")]
	[Address(RVA = "0x2C138B0", Offset = "0x2C138B0", VA = "0x2C138B0")]
	private void CloseFirstTip(int index)
	{
	}

	[Token(Token = "0x6010ED9")]
	[Address(RVA = "0x2C13A14", Offset = "0x2C13A14", VA = "0x2C13A14")]
	private void OnClickFirstTab(int index)
	{
	}

	[Token(Token = "0x6010EDA")]
	[Address(RVA = "0x2C12304", Offset = "0x2C12304", VA = "0x2C12304")]
	private void OnlyRefreshFirstTab()
	{
	}

	[Token(Token = "0x6010EDB")]
	[Address(RVA = "0x2C12AFC", Offset = "0x2C12AFC", VA = "0x2C12AFC")]
	private void OnlyRefreshSecondTab()
	{
	}

	[Token(Token = "0x6010EDC")]
	[Address(RVA = "0x2C10CAC", Offset = "0x2C10CAC", VA = "0x2C10CAC")]
	private void OnlyRefreshItemRenderer()
	{
	}

	[Token(Token = "0x6010EDD")]
	[Address(RVA = "0x2C09AE8", Offset = "0x2C09AE8", VA = "0x2C09AE8")]
	private void RecycleEmoteAvatar()
	{
	}

	[Token(Token = "0x6010EDE")]
	[Address(RVA = "0x2C13BF4", Offset = "0x2C13BF4", VA = "0x2C13BF4")]
	private void OnIfLegendItemChosen(object[] data)
	{
	}

	[Token(Token = "0x6010EDF")]
	[Address(RVA = "0x2C14728", Offset = "0x2C14728", VA = "0x2C14728")]
	private void OnBtnColorPanelClick()
	{
	}

	[Token(Token = "0x6010EE0")]
	[Address(RVA = "0x2C147A4", Offset = "0x2C147A4", VA = "0x2C147A4")]
	private void OnSwitchColor(object[] data)
	{
	}

	[Token(Token = "0x6010EE1")]
	[Address(RVA = "0x2C11698", Offset = "0x2C11698", VA = "0x2C11698")]
	private void ScrollColorPanel(bool show)
	{
	}

	[Token(Token = "0x6010EE2")]
	[Address(RVA = "0x2C14A88", Offset = "0x2C14A88", VA = "0x2C14A88")]
	private void SetPanelColorShow(int posY)
	{
	}

	[Token(Token = "0x6010EE3")]
	[Address(RVA = "0x2C14B20", Offset = "0x2C14B20", VA = "0x2C14B20")]
	private IEnumerator MovePanelShowColor(int posY)
	{
		return null;
	}

	[Token(Token = "0x6010EE4")]
	[Address(RVA = "0x2C1403C", Offset = "0x2C1403C", VA = "0x2C1403C")]
	private void RefreshColorPanel(uint legendId)
	{
	}

	[Token(Token = "0x6010EE5")]
	[Address(RVA = "0x2C14C14", Offset = "0x2C14C14", VA = "0x2C14C14")]
	private void OnClothSetRecommendClick()
	{
	}

	[Token(Token = "0x6010EE6")]
	[Address(RVA = "0x2C0D534", Offset = "0x2C0D534", VA = "0x2C0D534")]
	private void RefreshSwitchBackpack(uint id)
	{
	}

	[Token(Token = "0x6010EE7")]
	[Address(RVA = "0x2C150B0", Offset = "0x2C150B0", VA = "0x2C150B0")]
	private void OnHideBackpackChange()
	{
	}

	[Token(Token = "0x6010EE8")]
	[Address(RVA = "0x2C15658", Offset = "0x2C15658", VA = "0x2C15658")]
	private void OnClothSetRecommendClose()
	{
	}

	[Token(Token = "0x6010EE9")]
	[Address(RVA = "0x2C157B8", Offset = "0x2C157B8", VA = "0x2C157B8")]
	private void OnGotoAvatarProfileBtn()
	{
	}

	[Token(Token = "0x6010EEA")]
	[Address(RVA = "0x2C1596C", Offset = "0x2C1596C", VA = "0x2C1596C")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010EEB")]
	[Address(RVA = "0x2C159E8", Offset = "0x2C159E8", VA = "0x2C159E8")]
	private void OnOpenBtnClick()
	{
	}

	[Token(Token = "0x6010EEC")]
	[Address(RVA = "0x2C16194", Offset = "0x2C16194", VA = "0x2C16194")]
	private bool CheckUseRank(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6010EED")]
	[Address(RVA = "0x2C165A8", Offset = "0x2C165A8", VA = "0x2C165A8")]
	private void OnGotoBtnClick()
	{
	}

	[Token(Token = "0x6010EEE")]
	[Address(RVA = "0x2C169B4", Offset = "0x2C169B4", VA = "0x2C169B4")]
	private void DefaultGotoHandler(uint itemId)
	{
	}

	[Token(Token = "0x6010EEF")]
	[Address(RVA = "0x2C1703C", Offset = "0x2C1703C", VA = "0x2C1703C")]
	private int GetGachaIDByItemID(uint itemId)
	{
		return default(int);
	}

	[Token(Token = "0x6010EF0")]
	[Address(RVA = "0x2C1748C", Offset = "0x2C1748C", VA = "0x2C1748C")]
	private void OnEquipBtnClick()
	{
	}

	[Token(Token = "0x6010EF1")]
	[Address(RVA = "0x2C17658", Offset = "0x2C17658", VA = "0x2C17658")]
	private void OnUnEquipBtnClick()
	{
	}

	[Token(Token = "0x6010EF2")]
	[Address(RVA = "0x2C0F4FC", Offset = "0x2C0F4FC", VA = "0x2C0F4FC")]
	private void RefreshShowBagCheck(int id)
	{
	}

	[Token(Token = "0x6010EF3")]
	[Address(RVA = "0x2C176E4", Offset = "0x2C176E4", VA = "0x2C176E4")]
	private void OnBagShowBtnClick()
	{
	}

	[Token(Token = "0x6010EF4")]
	[Address(RVA = "0x2C178FC", Offset = "0x2C178FC", VA = "0x2C178FC", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010EF5")]
	[Address(RVA = "0x2C180E0", Offset = "0x2C180E0", VA = "0x2C180E0")]
	private void OnOptionalDownloadRefreshAssetRefreshItemRenderer()
	{
	}

	[Token(Token = "0x6010EF6")]
	[Address(RVA = "0x2C0D784", Offset = "0x2C0D784", VA = "0x2C0D784")]
	private void RefreshAvatar()
	{
	}

	[Token(Token = "0x6010EF7")]
	[Address(RVA = "0x2C17D88", Offset = "0x2C17D88", VA = "0x2C17D88")]
	private void RefreshAllPage(int firstTabID, int secondTabID, [Optional] int? selectItemID)
	{
	}

	[Token(Token = "0x6010EF8")]
	[Address(RVA = "0x2C18C34", Offset = "0x2C18C34", VA = "0x2C18C34", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010EF9")]
	[Address(RVA = "0x2C18D34", Offset = "0x2C18D34", VA = "0x2C18D34")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010EFA")]
	[Address(RVA = "0x2C18F34", Offset = "0x2C18F34", VA = "0x2C18F34")]
	private UINewVaultClothItemController GetUINewVaultClothItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010EFB")]
	[Address(RVA = "0x2C19188", Offset = "0x2C19188", VA = "0x2C19188", Slot = "47")]
	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x6010EFC")]
	[Address(RVA = "0x2C19240", Offset = "0x2C19240", VA = "0x2C19240", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6010EFD")]
	[Address(RVA = "0x2C192B0", Offset = "0x2C192B0", VA = "0x2C192B0", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6010EFE")]
	[Address(RVA = "0x2C190A4", Offset = "0x2C190A4", VA = "0x2C190A4")]
	public FrontEndPreviewComponent_NewVault GetFrontEndPreviewComponentInternal()
	{
		return null;
	}

	[Token(Token = "0x6010EFF")]
	[Address(RVA = "0x2C19308", Offset = "0x2C19308", VA = "0x2C19308")]
	public void Test_HideAndShowNewVault()
	{
	}

	[Token(Token = "0x6010F00")]
	[Address(RVA = "0x2C193CC", Offset = "0x2C193CC", VA = "0x2C193CC")]
	public void Test_InitInGameVault()
	{
	}

	[Token(Token = "0x6010F01")]
	[Address(RVA = "0x2C19784", Offset = "0x2C19784", VA = "0x2C19784")]
	private void Test_OnSearchInputChanged(object[] data)
	{
	}

	[Token(Token = "0x6010F02")]
	[Address(RVA = "0x2C0A968", Offset = "0x2C0A968", VA = "0x2C0A968")]
	private void Test_OnClickItem(int index)
	{
	}

	[Token(Token = "0x6010F03")]
	[Address(RVA = "0x2C19668", Offset = "0x2C19668", VA = "0x2C19668")]
	private void Test_RemoveMixCameraPostEffectManager()
	{
	}

	[Token(Token = "0x6010F04")]
	[Address(RVA = "0x2C1943C", Offset = "0x2C1943C", VA = "0x2C1943C")]
	private void Test_InitSearchController()
	{
	}

	[Token(Token = "0x6010F05")]
	[Address(RVA = "0x2C195B8", Offset = "0x2C195B8", VA = "0x2C195B8")]
	private void Test_HideVaultViewTable()
	{
	}

	[Token(Token = "0x6010F06")]
	[Address(RVA = "0x2C1A1B8", Offset = "0x2C1A1B8", VA = "0x2C1A1B8")]
	private void Test_UpdateCloth(int itemID)
	{
	}

	[Token(Token = "0x6010F07")]
	[Address(RVA = "0x2C1A7E8", Offset = "0x2C1A7E8", VA = "0x2C1A7E8")]
	private void Test_UpdateFirstTabDepth(int newDepth)
	{
	}

	[Token(Token = "0x6010F08")]
	[Address(RVA = "0x2C1A8F0", Offset = "0x2C1A8F0", VA = "0x2C1A8F0")]
	private void Test_UpdateSecondTabDepth(int newDepth)
	{
	}

	[Token(Token = "0x6010F09")]
	[Address(RVA = "0x2C19F38", Offset = "0x2C19F38", VA = "0x2C19F38")]
	private void Test_OnClickItemByIDInGaming(int itemID)
	{
	}

	[Token(Token = "0x6010F0A")]
	[Address(RVA = "0x2C1A9F8", Offset = "0x2C1A9F8", VA = "0x2C1A9F8")]
	private static UINewVaultEmoteItemController _003COnClickEmoteSlot_003Em__0(UIEasyListItemController item)
	{
		return null;
	}

	[Token(Token = "0x6010F0B")]
	[Address(RVA = "0x2C1AA8C", Offset = "0x2C1AA8C", VA = "0x2C1AA8C")]
	private static void _003COnFashionSecondTabExit_003Em__1()
	{
	}

	[Token(Token = "0x6010F0C")]
	[Address(RVA = "0x2C1AB4C", Offset = "0x2C1AB4C", VA = "0x2C1AB4C")]
	private static void _003COnSecondTabExit_003Em__2()
	{
	}

	[Token(Token = "0x6010F0D")]
	[Address(RVA = "0x2C1AC0C", Offset = "0x2C1AC0C", VA = "0x2C1AC0C")]
	private static void _003COnSecondTabExit_003Em__3()
	{
	}

	[Token(Token = "0x6010F0E")]
	[Address(RVA = "0x2C1ACCC", Offset = "0x2C1ACCC", VA = "0x2C1ACCC")]
	private static void _003COnSecondTabExit_003Em__4()
	{
	}

	[Token(Token = "0x6010F0F")]
	[Address(RVA = "0x2C1AD8C", Offset = "0x2C1AD8C", VA = "0x2C1AD8C")]
	private static void _003COnSecondTabExit_003Em__5()
	{
	}

	[Token(Token = "0x6010F10")]
	[Address(RVA = "0x2C1AE4C", Offset = "0x2C1AE4C", VA = "0x2C1AE4C")]
	private static void _003COnSecondTabExit_003Em__6()
	{
	}

	[Token(Token = "0x6010F11")]
	[Address(RVA = "0x2C1AF0C", Offset = "0x2C1AF0C", VA = "0x2C1AF0C")]
	private void _003CInit_003Em__7()
	{
	}

	[Token(Token = "0x6010F12")]
	[Address(RVA = "0x2C1B078", Offset = "0x2C1B078", VA = "0x2C1B078")]
	private void _003CRefreshColorPanel_003Em__8()
	{
	}

	[Token(Token = "0x6010F13")]
	[Address(RVA = "0x2C1B080", Offset = "0x2C1B080", VA = "0x2C1B080")]
	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x6010F14")]
	[Address(RVA = "0x2C1B088", Offset = "0x2C1B088", VA = "0x2C1B088")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010F15")]
	[Address(RVA = "0x2C1B090", Offset = "0x2C1B090", VA = "0x2C1B090")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010F16")]
	[Address(RVA = "0x2C1B098", Offset = "0x2C1B098", VA = "0x2C1B098")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010F17")]
	[Address(RVA = "0x2C1B0A0", Offset = "0x2C1B0A0", VA = "0x2C1B0A0")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6010F18")]
	[Address(RVA = "0x2C1B0A8", Offset = "0x2C1B0A8", VA = "0x2C1B0A8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010F19")]
	[Address(RVA = "0x2C1B0B0", Offset = "0x2C1B0B0", VA = "0x2C1B0B0")]
	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}
}
