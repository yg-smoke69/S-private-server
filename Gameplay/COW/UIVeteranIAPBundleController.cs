using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002BDE")]
public class UIVeteranIAPBundleController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002BDF")]
	private sealed class _003CShowItemControlers_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010C10")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__0;

		[Token(Token = "0x4010C11")]
		[FieldOffset(Offset = "0xC")]
		internal Transform[] _0024locvar0;

		[Token(Token = "0x4010C12")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024locvar1;

		[Token(Token = "0x4010C13")]
		[FieldOffset(Offset = "0x14")]
		internal UIVeteranIAPBundleController _0024this;

		[Token(Token = "0x4010C14")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4010C15")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x4010C16")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700130F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60122C2")]
			[Address(RVA = "0x285D4F4", Offset = "0x285D4F4", VA = "0x285D4F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001310")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60122C3")]
			[Address(RVA = "0x285D4FC", Offset = "0x285D4FC", VA = "0x285D4FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60122C0")]
		[Address(RVA = "0x285C810", Offset = "0x285C810", VA = "0x285C810")]
		public _003CShowItemControlers_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60122C1")]
		[Address(RVA = "0x285D0A4", Offset = "0x285D0A4", VA = "0x285D0A4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60122C4")]
		[Address(RVA = "0x285D504", Offset = "0x285D504", VA = "0x285D504", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60122C5")]
		[Address(RVA = "0x285D518", Offset = "0x285D518", VA = "0x285D518", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010C04")]
	private const string VETERANBUNDLEFIRSTSHOW = "VeteranBundleFirstShow_{0}_{1}";

	[Token(Token = "0x4010C05")]
	[FieldOffset(Offset = "0x46")]
	private bool m_IsCloseState;

	[Token(Token = "0x4010C06")]
	[FieldOffset(Offset = "0x48")]
	private UIModelVeteranBundle m_Model;

	[Token(Token = "0x4010C07")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelIAPBundle m_ModelIAPBundle;

	[Token(Token = "0x4010C08")]
	[FieldOffset(Offset = "0x50")]
	private UIVeteranIAPBundleView m_View;

	[Token(Token = "0x4010C09")]
	[FieldOffset(Offset = "0x54")]
	private IAPBundleStoreData m_Data;

	[Token(Token = "0x4010C0A")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsFirstShow;

	[Token(Token = "0x4010C0B")]
	[FieldOffset(Offset = "0x59")]
	private bool m_HasPlayedAnimation;

	[Token(Token = "0x4010C0C")]
	private const int MAX_ITEM = 5;

	[Token(Token = "0x4010C0D")]
	[FieldOffset(Offset = "0x5C")]
	private Transform[] m_ItemRoots;

	[Token(Token = "0x4010C0E")]
	[FieldOffset(Offset = "0x60")]
	private List<UIVeteranBundleItemController> m_GridItemControllers;

	[Token(Token = "0x4010C0F")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<KeyValuePair<uint, List<BundleShowData>>, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60122A7")]
	[Address(RVA = "0x28589A8", Offset = "0x28589A8", VA = "0x28589A8")]
	public UIVeteranIAPBundleController()
	{
	}

	[Token(Token = "0x60122A8")]
	[Address(RVA = "0x2858A34", Offset = "0x2858A34", VA = "0x2858A34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60122A9")]
	[Address(RVA = "0x2858AD8", Offset = "0x2858AD8", VA = "0x2858AD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60122AA")]
	[Address(RVA = "0x2859100", Offset = "0x2859100", VA = "0x2859100", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60122AB")]
	[Address(RVA = "0x2859094", Offset = "0x2859094", VA = "0x2859094")]
	public void SetData(IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60122AC")]
	[Address(RVA = "0x2859310", Offset = "0x2859310", VA = "0x2859310")]
	private void ShowFirstItem()
	{
	}

	[Token(Token = "0x60122AD")]
	[Address(RVA = "0x28592A8", Offset = "0x28592A8", VA = "0x28592A8")]
	private void ShowInternal()
	{
	}

	[Token(Token = "0x60122AE")]
	[Address(RVA = "0x285924C", Offset = "0x285924C", VA = "0x285924C")]
	private void HideInternal()
	{
	}

	[Token(Token = "0x60122AF")]
	[Address(RVA = "0x285AD38", Offset = "0x285AD38", VA = "0x285AD38", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60122B0")]
	[Address(RVA = "0x285ADCC", Offset = "0x285ADCC", VA = "0x285ADCC")]
	private void OnClickPurchase()
	{
	}

	[Token(Token = "0x60122B1")]
	[Address(RVA = "0x285AFAC", Offset = "0x285AFAC", VA = "0x285AFAC")]
	private void ToggleUI(bool show)
	{
	}

	[Token(Token = "0x60122B2")]
	[Address(RVA = "0x2859430", Offset = "0x2859430", VA = "0x2859430")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x60122B3")]
	[Address(RVA = "0x285C5F8", Offset = "0x285C5F8", VA = "0x285C5F8")]
	private bool ShowPurchaseBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x60122B4")]
	[Address(RVA = "0x285B16C", Offset = "0x285B16C", VA = "0x285B16C")]
	private void UpdateItemControllers(List<BundleShowData> bundleShowDataList)
	{
	}

	[Token(Token = "0x60122B5")]
	[Address(RVA = "0x285C744", Offset = "0x285C744", VA = "0x285C744")]
	private IEnumerator ShowItemControlers()
	{
		return null;
	}

	[Token(Token = "0x60122B6")]
	[Address(RVA = "0x285C818", Offset = "0x285C818", VA = "0x285C818")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x60122B7")]
	[Address(RVA = "0x285CB18", Offset = "0x285CB18", VA = "0x285CB18", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60122B8")]
	[Address(RVA = "0x285CBAC", Offset = "0x285CBAC", VA = "0x285CBAC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60122B9")]
	[Address(RVA = "0x285CDC8", Offset = "0x285CDC8", VA = "0x285CDC8", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60122BA")]
	[Address(RVA = "0x285CEC0", Offset = "0x285CEC0", VA = "0x285CEC0", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60122BB")]
	[Address(RVA = "0x285CF3C", Offset = "0x285CF3C", VA = "0x285CF3C")]
	private static string _003CUpdateView_003Em__0(KeyValuePair<uint, List<BundleShowData>> p)
	{
		return null;
	}

	[Token(Token = "0x60122BC")]
	[Address(RVA = "0x285CFBC", Offset = "0x285CFBC", VA = "0x285CFBC")]
	private void _003CUpdateView_003Em__1()
	{
	}

	[Token(Token = "0x60122BD")]
	[Address(RVA = "0x285D08C", Offset = "0x285D08C", VA = "0x285D08C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60122BE")]
	[Address(RVA = "0x285D094", Offset = "0x285D094", VA = "0x285D094")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60122BF")]
	[Address(RVA = "0x285D09C", Offset = "0x285D09C", VA = "0x285D09C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
