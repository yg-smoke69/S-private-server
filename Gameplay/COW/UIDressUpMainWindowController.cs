using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025D3")]
public class UIDressUpMainWindowController : UIPreviewNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x20025D4")]
	public enum EquipState
	{
		[Token(Token = "0x400E9F3")]
		Common,
		[Token(Token = "0x400E9F4")]
		Disable,
		[Token(Token = "0x400E9F5")]
		AlreadyEquip
	}

	[Token(Token = "0x20025D5")]
	private sealed class _003CManualGotoOtherFunc_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E9F6")]
		[FieldOffset(Offset = "0x8")]
		internal Action callback;

		[Token(Token = "0x400E9F7")]
		[FieldOffset(Offset = "0xC")]
		internal UIDressUpMainWindowController _0024this;

		[Token(Token = "0x600DEAF")]
		[Address(RVA = "0x2B97A00", Offset = "0x2B97A00", VA = "0x2B97A00")]
		public _003CManualGotoOtherFunc_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600DEB0")]
		[Address(RVA = "0x2B97A08", Offset = "0x2B97A08", VA = "0x2B97A08")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600DEB1")]
		[Address(RVA = "0x2B97A34", Offset = "0x2B97A34", VA = "0x2B97A34")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x600DEB2")]
		[Address(RVA = "0x2B97D74", Offset = "0x2B97D74", VA = "0x2B97D74")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x600DEB3")]
		[Address(RVA = "0x2B97DA0", Offset = "0x2B97DA0", VA = "0x2B97DA0")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x20025D6")]
	private sealed class _003CMovePanelShowColor_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E9F8")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CminDelta_003E__0;

		[Token(Token = "0x400E9F9")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CmoveSpeed_003E__0;

		[Token(Token = "0x400E9FA")]
		[FieldOffset(Offset = "0x10")]
		internal int posY;

		[Token(Token = "0x400E9FB")]
		[FieldOffset(Offset = "0x14")]
		internal Vector2 _003Coffset_003E__1;

		[Token(Token = "0x400E9FC")]
		[FieldOffset(Offset = "0x1C")]
		internal int _003Cadd_003E__1;

		[Token(Token = "0x400E9FD")]
		[FieldOffset(Offset = "0x20")]
		internal UIDressUpMainWindowController _0024this;

		[Token(Token = "0x400E9FE")]
		[FieldOffset(Offset = "0x24")]
		internal object _0024current;

		[Token(Token = "0x400E9FF")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x400EA00")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x17001152")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600DEB6")]
			[Address(RVA = "0x2B98340", Offset = "0x2B98340", VA = "0x2B98340", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001153")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600DEB7")]
			[Address(RVA = "0x2B98348", Offset = "0x2B98348", VA = "0x2B98348", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600DEB4")]
		[Address(RVA = "0x2B98068", Offset = "0x2B98068", VA = "0x2B98068")]
		public _003CMovePanelShowColor_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600DEB5")]
		[Address(RVA = "0x2B98070", Offset = "0x2B98070", VA = "0x2B98070", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600DEB8")]
		[Address(RVA = "0x2B98350", Offset = "0x2B98350", VA = "0x2B98350", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600DEB9")]
		[Address(RVA = "0x2B98364", Offset = "0x2B98364", VA = "0x2B98364", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E9D9")]
	[FieldOffset(Offset = "0x7C")]
	private UIDressUpMainWindowView m_View;

	[Token(Token = "0x400E9DA")]
	[FieldOffset(Offset = "0x80")]
	private UIModelDressUp m_model;

	[Token(Token = "0x400E9DB")]
	[FieldOffset(Offset = "0x84")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x400E9DC")]
	[FieldOffset(Offset = "0x88")]
	private EquipState m_state;

	[Token(Token = "0x400E9DD")]
	private const string WEBVIEWTUTORIALKEY = "WebViewTutorialKeyDressUp";

	[Token(Token = "0x400E9DE")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_DelayCallShow;

	[Token(Token = "0x400E9DF")]
	[FieldOffset(Offset = "0x90")]
	private uint m_DelayCallAvatarShow;

	[Token(Token = "0x400E9E0")]
	[FieldOffset(Offset = "0x94")]
	private bool m_IsHideBackpack;

	[Token(Token = "0x400E9E1")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<int, List<int>> m_dicSortItems;

	[Token(Token = "0x400E9E2")]
	[FieldOffset(Offset = "0x9C")]
	private UIDressUpVaultSecondTabController m_TabCtrl;

	[Token(Token = "0x400E9E3")]
	[FieldOffset(Offset = "0xA0")]
	private FrontEndPreviewComponent_Dressup m_FrontEndPreviewComponent_Dressup;

	[Token(Token = "0x400E9E4")]
	[FieldOffset(Offset = "0xA4")]
	private List<int> m_showlist;

	[Token(Token = "0x400E9E5")]
	[FieldOffset(Offset = "0xA8")]
	private UIModelNewVault.eSecondTab m_CurrentTab;

	[Token(Token = "0x400E9E6")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_ForceRefreshTab;

	[Token(Token = "0x400E9E7")]
	[FieldOffset(Offset = "0xB0")]
	private List<UIDressUpSlotItemController> m_DressUpSlotItemListCtrl;

	[Token(Token = "0x400E9E8")]
	[FieldOffset(Offset = "0xB4")]
	private List<UIDressUpExchangeItemController> m_DressUpExchangeItemListCtrl;

	[Token(Token = "0x400E9E9")]
	[FieldOffset(Offset = "0xB8")]
	private ShowBoostAvatarParams m_ShowBoostAvatarParams;

	[Token(Token = "0x400E9EA")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_firsttime;

	[Token(Token = "0x400E9EB")]
	[FieldOffset(Offset = "0xBD")]
	private bool m_IsColorPanelShow;

	[Token(Token = "0x400E9EC")]
	[FieldOffset(Offset = "0xC0")]
	private Coroutine m_CoroutineMovePanelShowColor;

	[Token(Token = "0x400E9ED")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E9EE")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400E9EF")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400E9F0")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<uint, int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400E9F1")]
	[FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x600DE6A")]
	[Address(RVA = "0x276BCA8", Offset = "0x276BCA8", VA = "0x276BCA8")]
	public UIDressUpMainWindowController()
	{
	}

	[Token(Token = "0x600DE6B")]
	[Address(RVA = "0x276BF70", Offset = "0x276BF70", VA = "0x276BF70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DE6C")]
	[Address(RVA = "0x276C014", Offset = "0x276C014", VA = "0x276C014", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DE6D")]
	[Address(RVA = "0x276CA54", Offset = "0x276CA54", VA = "0x276CA54", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600DE6E")]
	[Address(RVA = "0x276D0B4", Offset = "0x276D0B4", VA = "0x276D0B4")]
	public void ManualGotoOtherFunc(Action callback)
	{
	}

	[Token(Token = "0x600DE6F")]
	[Address(RVA = "0x276CAB8", Offset = "0x276CAB8", VA = "0x276CAB8")]
	public void OvrideNavgateCloseFunc()
	{
	}

	[Token(Token = "0x600DE70")]
	[Address(RVA = "0x276C6E8", Offset = "0x276C6E8", VA = "0x276C6E8")]
	private void InitUIData()
	{
	}

	[Token(Token = "0x600DE71")]
	[Address(RVA = "0x276D4C4", Offset = "0x276D4C4", VA = "0x276D4C4")]
	private void OnCloseTips(UIModelNewVault.eSecondTab obj)
	{
	}

	[Token(Token = "0x600DE72")]
	[Address(RVA = "0x276D520", Offset = "0x276D520", VA = "0x276D520")]
	private void OnIfLegendItemChosen(object[] data)
	{
	}

	[Token(Token = "0x600DE73")]
	[Address(RVA = "0x276E308", Offset = "0x276E308", VA = "0x276E308")]
	private void OnBtnColorPanelClick()
	{
	}

	[Token(Token = "0x600DE74")]
	[Address(RVA = "0x276E054", Offset = "0x276E054", VA = "0x276E054")]
	private void ScrollColorPanel(bool show)
	{
	}

	[Token(Token = "0x600DE75")]
	[Address(RVA = "0x276E384", Offset = "0x276E384", VA = "0x276E384")]
	private void SetPanelColorShow(int posY)
	{
	}

	[Token(Token = "0x600DE76")]
	[Address(RVA = "0x276E41C", Offset = "0x276E41C", VA = "0x276E41C")]
	private IEnumerator MovePanelShowColor(int posY)
	{
		return null;
	}

	[Token(Token = "0x600DE77")]
	[Address(RVA = "0x276D968", Offset = "0x276D968", VA = "0x276D968")]
	private void RefreshColorPanel(uint legendId)
	{
	}

	[Token(Token = "0x600DE78")]
	[Address(RVA = "0x276E508", Offset = "0x276E508", VA = "0x276E508")]
	public void ForceRefreshTab()
	{
	}

	[Token(Token = "0x600DE79")]
	[Address(RVA = "0x276E564", Offset = "0x276E564", VA = "0x276E564")]
	private void OnBagShowClick()
	{
	}

	[Token(Token = "0x600DE7A")]
	[Address(RVA = "0x276E60C", Offset = "0x276E60C", VA = "0x276E60C")]
	private void OnClickFirstTab(int index)
	{
	}

	[Token(Token = "0x600DE7B")]
	[Address(RVA = "0x276F1F4", Offset = "0x276F1F4", VA = "0x276F1F4")]
	private void OnClickItemData(int id)
	{
	}

	[Token(Token = "0x600DE7C")]
	[Address(RVA = "0x276F6D8", Offset = "0x276F6D8", VA = "0x276F6D8")]
	private void OnlyRefreshFirstTab()
	{
	}

	[Token(Token = "0x600DE7D")]
	[Address(RVA = "0x276FDB0", Offset = "0x276FDB0", VA = "0x276FDB0")]
	private void OnHelpBtnClick(object[] data)
	{
	}

	[Token(Token = "0x600DE7E")]
	[Address(RVA = "0x277000C", Offset = "0x277000C", VA = "0x277000C")]
	public void RefreshLeftUI()
	{
	}

	[Token(Token = "0x600DE7F")]
	[Address(RVA = "0x277008C", Offset = "0x277008C", VA = "0x277008C")]
	public void RefreshRightUI()
	{
	}

	[Token(Token = "0x600DE80")]
	[Address(RVA = "0x27704DC", Offset = "0x27704DC", VA = "0x27704DC")]
	private void RefreshExchangeUIList()
	{
	}

	[Token(Token = "0x600DE81")]
	[Address(RVA = "0x2770108", Offset = "0x2770108", VA = "0x2770108")]
	private void RefreshSlotUIList(bool doanimation = false)
	{
	}

	[Token(Token = "0x600DE82")]
	[Address(RVA = "0x2770928", Offset = "0x2770928", VA = "0x2770928")]
	private void RefreshItemById(object[] data)
	{
	}

	[Token(Token = "0x600DE83")]
	[Address(RVA = "0x27713AC", Offset = "0x27713AC", VA = "0x27713AC")]
	private List<uint> TempEquipCacheItemid(uint id)
	{
		return null;
	}

	[Token(Token = "0x600DE84")]
	[Address(RVA = "0x27712F4", Offset = "0x27712F4", VA = "0x27712F4")]
	private void RefreshCollection(uint id)
	{
	}

	[Token(Token = "0x600DE85")]
	[Address(RVA = "0x2771728", Offset = "0x2771728", VA = "0x2771728")]
	private void OnRefreshCollection(object[] data)
	{
	}

	[Token(Token = "0x600DE86")]
	[Address(RVA = "0x277187C", Offset = "0x277187C", VA = "0x277187C")]
	private void OnRefreshRightUI(object[] data)
	{
	}

	[Token(Token = "0x600DE87")]
	[Address(RVA = "0x27718E4", Offset = "0x27718E4", VA = "0x27718E4")]
	private void RefreshEquipAvatar(object[] data)
	{
	}

	[Token(Token = "0x600DE88")]
	[Address(RVA = "0x2771D00", Offset = "0x2771D00", VA = "0x2771D00")]
	private void RefreshDressupAvatar(object[] data)
	{
	}

	[Token(Token = "0x600DE89")]
	[Address(RVA = "0x27720F8", Offset = "0x27720F8", VA = "0x27720F8")]
	private void OnRefreshHair(object[] data)
	{
	}

	[Token(Token = "0x600DE8A")]
	[Address(RVA = "0x276ECF0", Offset = "0x276ECF0", VA = "0x276ECF0")]
	public void ReFreshAvatar(uint tempItemID = 0u, uint overridebackpackid = 0u)
	{
	}

	[Token(Token = "0x600DE8B")]
	[Address(RVA = "0x27726E8", Offset = "0x27726E8", VA = "0x27726E8")]
	private void OnEquipClick()
	{
	}

	[Token(Token = "0x600DE8C")]
	[Address(RVA = "0x2772C28", Offset = "0x2772C28", VA = "0x2772C28")]
	private void OnSaveClick()
	{
	}

	[Token(Token = "0x600DE8D")]
	[Address(RVA = "0x276F500", Offset = "0x276F500", VA = "0x276F500")]
	public void RefreshEquipState()
	{
	}

	[Token(Token = "0x600DE8E")]
	[Address(RVA = "0x276F3A4", Offset = "0x276F3A4", VA = "0x276F3A4")]
	public void RefreshSaveState()
	{
	}

	[Token(Token = "0x600DE8F")]
	[Address(RVA = "0x2773148", Offset = "0x2773148", VA = "0x2773148")]
	private void TryShowTutorial()
	{
	}

	[Token(Token = "0x600DE90")]
	[Address(RVA = "0x2773440", Offset = "0x2773440", VA = "0x2773440", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600DE91")]
	[Address(RVA = "0x2773734", Offset = "0x2773734", VA = "0x2773734")]
	private void OnRefreshAllDressUp(object[] data)
	{
	}

	[Token(Token = "0x600DE92")]
	[Address(RVA = "0x277388C", Offset = "0x277388C", VA = "0x277388C")]
	private void OnRefreshBackPack(object[] data)
	{
	}

	[Token(Token = "0x600DE93")]
	[Address(RVA = "0x2773A1C", Offset = "0x2773A1C", VA = "0x2773A1C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DE94")]
	[Address(RVA = "0x2773AB8", Offset = "0x2773AB8", VA = "0x2773AB8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DE95")]
	[Address(RVA = "0x2773B1C", Offset = "0x2773B1C", VA = "0x2773B1C", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600DE96")]
	[Address(RVA = "0x2773CE0", Offset = "0x2773CE0", VA = "0x2773CE0")]
	private void OnPreviewDownloadFinished(object[] data)
	{
	}

	[Token(Token = "0x600DE97")]
	[Address(RVA = "0x2773E54", Offset = "0x2773E54", VA = "0x2773E54", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DE98")]
	[Address(RVA = "0x2774000", Offset = "0x2774000", VA = "0x2774000", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DE99")]
	[Address(RVA = "0x2774094", Offset = "0x2774094", VA = "0x2774094", Slot = "66")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DE9A")]
	[Address(RVA = "0x2774250", Offset = "0x2774250", VA = "0x2774250", Slot = "67")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600DE9B")]
	[Address(RVA = "0x27742CC", Offset = "0x27742CC", VA = "0x27742CC", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600DE9C")]
	[Address(RVA = "0x277433C", Offset = "0x277433C", VA = "0x277433C", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600DE9D")]
	[Address(RVA = "0x2774394", Offset = "0x2774394", VA = "0x2774394", Slot = "47")]
	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x600DE9E")]
	[Address(RVA = "0x2774450", Offset = "0x2774450", VA = "0x2774450")]
	private static void _003COvrideNavgateCloseFunc_003Em__0()
	{
	}

	[Token(Token = "0x600DE9F")]
	[Address(RVA = "0x27744F4", Offset = "0x27744F4", VA = "0x27744F4")]
	private void _003COvrideNavgateCloseFunc_003Em__1()
	{
	}

	[Token(Token = "0x600DEA0")]
	[Address(RVA = "0x27745A4", Offset = "0x27745A4", VA = "0x27745A4")]
	private static void _003COvrideNavgateCloseFunc_003Em__2()
	{
	}

	[Token(Token = "0x600DEA1")]
	[Address(RVA = "0x2774648", Offset = "0x2774648", VA = "0x2774648")]
	private void _003COvrideNavgateCloseFunc_003Em__3()
	{
	}

	[Token(Token = "0x600DEA2")]
	[Address(RVA = "0x2774964", Offset = "0x2774964", VA = "0x2774964")]
	private static void _003COvrideNavgateCloseFunc_003Em__4()
	{
	}

	[Token(Token = "0x600DEA3")]
	[Address(RVA = "0x2774A08", Offset = "0x2774A08", VA = "0x2774A08")]
	private void _003COvrideNavgateCloseFunc_003Em__5()
	{
	}

	[Token(Token = "0x600DEA4")]
	[Address(RVA = "0x2774CD4", Offset = "0x2774CD4", VA = "0x2774CD4")]
	private static int _003CInitUIData_003Em__6(uint n)
	{
		return default(int);
	}

	[Token(Token = "0x600DEA5")]
	[Address(RVA = "0x2774CD8", Offset = "0x2774CD8", VA = "0x2774CD8")]
	private void _003CRefreshColorPanel_003Em__7()
	{
	}

	[Token(Token = "0x600DEA6")]
	[Address(RVA = "0x2774CE0", Offset = "0x2774CE0", VA = "0x2774CE0")]
	private static void _003CTryShowTutorial_003Em__8()
	{
	}

	[Token(Token = "0x600DEA7")]
	[Address(RVA = "0x2774F9C", Offset = "0x2774F9C", VA = "0x2774F9C")]
	private void _003COnNavigationShowed_003Em__9()
	{
	}

	[Token(Token = "0x600DEA8")]
	[Address(RVA = "0x2774FA8", Offset = "0x2774FA8", VA = "0x2774FA8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DEA9")]
	[Address(RVA = "0x2774FB0", Offset = "0x2774FB0", VA = "0x2774FB0")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600DEAA")]
	[Address(RVA = "0x2774FB8", Offset = "0x2774FB8", VA = "0x2774FB8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600DEAB")]
	[Address(RVA = "0x2774FC0", Offset = "0x2774FC0", VA = "0x2774FC0")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600DEAC")]
	[Address(RVA = "0x2774FC8", Offset = "0x2774FC8", VA = "0x2774FC8")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600DEAD")]
	[Address(RVA = "0x2774FD0", Offset = "0x2774FD0", VA = "0x2774FD0")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600DEAE")]
	[Address(RVA = "0x2774FD8", Offset = "0x2774FD8", VA = "0x2774FD8")]
	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}
}
