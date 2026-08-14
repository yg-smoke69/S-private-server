using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20028D6")]
public class UIIAPBundleController : UIPreviewPopUpWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x20028D7")]
	private sealed class _003CShowItemControlers_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FB37")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__0;

		[Token(Token = "0x400FB38")]
		[FieldOffset(Offset = "0xC")]
		internal Transform[] _0024locvar0;

		[Token(Token = "0x400FB39")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024locvar1;

		[Token(Token = "0x400FB3A")]
		[FieldOffset(Offset = "0x14")]
		internal UIIAPBundleController _0024this;

		[Token(Token = "0x400FB3B")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400FB3C")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400FB3D")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700120A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60101C0")]
			[Address(RVA = "0xD3F7E0", Offset = "0xD3F7E0", VA = "0xD3F7E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700120B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60101C1")]
			[Address(RVA = "0xD3F7E8", Offset = "0xD3F7E8", VA = "0xD3F7E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60101BE")]
		[Address(RVA = "0xD3F0EC", Offset = "0xD3F0EC", VA = "0xD3F0EC")]
		public _003CShowItemControlers_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60101BF")]
		[Address(RVA = "0xD3F390", Offset = "0xD3F390", VA = "0xD3F390", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60101C2")]
		[Address(RVA = "0xD3F7F0", Offset = "0xD3F7F0", VA = "0xD3F7F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60101C3")]
		[Address(RVA = "0xD3F804", Offset = "0xD3F804", VA = "0xD3F804", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400FB2B")]
	private const string IAPBUNDLEFIRSTSHOW = "IapBundleFirstShow_{0}_{1}";

	[Token(Token = "0x400FB2C")]
	[FieldOffset(Offset = "0x5C")]
	private UIIAPBundleView m_View;

	[Token(Token = "0x400FB2D")]
	[FieldOffset(Offset = "0x60")]
	private UIModelIAPBundle m_Model;

	[Token(Token = "0x400FB2E")]
	[FieldOffset(Offset = "0x64")]
	private IAPBundleStoreData m_Data;

	[Token(Token = "0x400FB2F")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsFirstShow;

	[Token(Token = "0x400FB30")]
	[FieldOffset(Offset = "0x69")]
	private bool m_HasPlayedAnimation;

	[Token(Token = "0x400FB31")]
	private const int MAX_ITEM = 5;

	[Token(Token = "0x400FB32")]
	[FieldOffset(Offset = "0x6C")]
	private Transform[] m_ItemRoots;

	[Token(Token = "0x400FB33")]
	[FieldOffset(Offset = "0x70")]
	private uint m_ItemID;

	[Token(Token = "0x400FB34")]
	[FieldOffset(Offset = "0x74")]
	private List<UIIAPBundleContentItemController> m_GridItemControllers;

	[Token(Token = "0x400FB35")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FB36")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<KeyValuePair<uint, List<BundleShowData>>, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6010199")]
	[Address(RVA = "0xD39888", Offset = "0xD39888", VA = "0xD39888")]
	public UIIAPBundleController()
	{
	}

	[Token(Token = "0x601019A")]
	[Address(RVA = "0xD39914", Offset = "0xD39914", VA = "0xD39914")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601019B")]
	[Address(RVA = "0xD399BC", Offset = "0xD399BC", VA = "0xD399BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601019C")]
	[Address(RVA = "0xD3A2AC", Offset = "0xD3A2AC", VA = "0xD3A2AC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601019D")]
	[Address(RVA = "0xD3A3F0", Offset = "0xD3A3F0", VA = "0xD3A3F0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601019E")]
	[Address(RVA = "0xD3A768", Offset = "0xD3A768", VA = "0xD3A768")]
	private void OnClickHint()
	{
	}

	[Token(Token = "0x601019F")]
	[Address(RVA = "0xD3A9B0", Offset = "0xD3A9B0", VA = "0xD3A9B0")]
	public void SetData(IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60101A0")]
	[Address(RVA = "0xD3AA84", Offset = "0xD3AA84", VA = "0xD3AA84")]
	private void ShowFirstItem()
	{
	}

	[Token(Token = "0x60101A1")]
	[Address(RVA = "0xD3AA24", Offset = "0xD3AA24", VA = "0xD3AA24")]
	private void ShowInternal()
	{
	}

	[Token(Token = "0x60101A2")]
	[Address(RVA = "0xD3A714", Offset = "0xD3A714", VA = "0xD3A714")]
	private void HideInternal()
	{
	}

	[Token(Token = "0x60101A3")]
	[Address(RVA = "0xD3CAC4", Offset = "0xD3CAC4", VA = "0xD3CAC4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60101A4")]
	[Address(RVA = "0xD3CB58", Offset = "0xD3CB58", VA = "0xD3CB58")]
	public void SetItemID(uint id)
	{
	}

	[Token(Token = "0x60101A5")]
	[Address(RVA = "0xD3CBB8", Offset = "0xD3CBB8", VA = "0xD3CBB8")]
	public void OnPurchaseButtonClick()
	{
	}

	[Token(Token = "0x60101A6")]
	[Address(RVA = "0xD3CDE0", Offset = "0xD3CDE0", VA = "0xD3CDE0")]
	public void OnDiamondPurchaseButtonClick()
	{
	}

	[Token(Token = "0x60101A7")]
	[Address(RVA = "0xD3D180", Offset = "0xD3D180", VA = "0xD3D180", Slot = "68")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60101A8")]
	[Address(RVA = "0xD3D214", Offset = "0xD3D214", VA = "0xD3D214", Slot = "67")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60101A9")]
	[Address(RVA = "0xD3D48C", Offset = "0xD3D48C", VA = "0xD3D48C")]
	private void UpdateItemControllers(List<BundleShowData> bundleShowDataList)
	{
	}

	[Token(Token = "0x60101AA")]
	[Address(RVA = "0xD3E9E4", Offset = "0xD3E9E4", VA = "0xD3E9E4")]
	private void ToggleUI(bool show)
	{
	}

	[Token(Token = "0x60101AB")]
	[Address(RVA = "0xD39F10", Offset = "0xD39F10", VA = "0xD39F10")]
	private void ShowNameContent()
	{
	}

	[Token(Token = "0x60101AC")]
	[Address(RVA = "0xD3EC34", Offset = "0xD3EC34", VA = "0xD3EC34")]
	private void OnSuccessfullyDownloadTitleCDN()
	{
	}

	[Token(Token = "0x60101AD")]
	[Address(RVA = "0xD3ABA4", Offset = "0xD3ABA4", VA = "0xD3ABA4")]
	private void UpdateData()
	{
	}

	[Token(Token = "0x60101AE")]
	[Address(RVA = "0xD3EF3C", Offset = "0xD3EF3C", VA = "0xD3EF3C", Slot = "69")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60101AF")]
	[Address(RVA = "0xD3F070", Offset = "0xD3F070", VA = "0xD3F070", Slot = "70")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60101B0")]
	[Address(RVA = "0xD3ED3C", Offset = "0xD3ED3C", VA = "0xD3ED3C")]
	private bool ShowDiamondPurchaseBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x60101B1")]
	[Address(RVA = "0xD3EDF0", Offset = "0xD3EDF0", VA = "0xD3EDF0")]
	private bool ShowPurchaseBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x60101B2")]
	[Address(RVA = "0xD3E918", Offset = "0xD3E918", VA = "0xD3E918")]
	private IEnumerator ShowItemControlers()
	{
		return null;
	}

	[Token(Token = "0x60101B3")]
	[Address(RVA = "0xD3F0F4", Offset = "0xD3F0F4", VA = "0xD3F0F4", Slot = "46")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x60101B4")]
	[Address(RVA = "0xD3F14C", Offset = "0xD3F14C", VA = "0xD3F14C", Slot = "47")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x60101B5")]
	[Address(RVA = "0xD39234", Offset = "0xD39234", VA = "0xD39234")]
	public void ShowPreviewInternal(BundleShowData bBundleData)
	{
	}

	[Token(Token = "0x60101B6")]
	[Address(RVA = "0xD3F1BC", Offset = "0xD3F1BC", VA = "0xD3F1BC")]
	private void _003COnDiamondPurchaseButtonClick_003Em__0()
	{
	}

	[Token(Token = "0x60101B7")]
	[Address(RVA = "0xD3F1F0", Offset = "0xD3F1F0", VA = "0xD3F1F0")]
	private static bool _003CShowNameContent_003Em__1(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60101B8")]
	[Address(RVA = "0xD3F220", Offset = "0xD3F220", VA = "0xD3F220")]
	private static string _003CUpdateData_003Em__2(KeyValuePair<uint, List<BundleShowData>> p)
	{
		return null;
	}

	[Token(Token = "0x60101B9")]
	[Address(RVA = "0xD3F2A0", Offset = "0xD3F2A0", VA = "0xD3F2A0")]
	private void _003CUpdateData_003Em__3()
	{
	}

	[Token(Token = "0x60101BA")]
	[Address(RVA = "0xD3F370", Offset = "0xD3F370", VA = "0xD3F370")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60101BB")]
	[Address(RVA = "0xD3F378", Offset = "0xD3F378", VA = "0xD3F378")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60101BC")]
	[Address(RVA = "0xD3F380", Offset = "0xD3F380", VA = "0xD3F380")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60101BD")]
	[Address(RVA = "0xD3F388", Offset = "0xD3F388", VA = "0xD3F388")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
