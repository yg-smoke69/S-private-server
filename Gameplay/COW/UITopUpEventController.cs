using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B6D")]
public class UITopUpEventController : UIPreviewBaseController, _Attribute
{
	[Token(Token = "0x2002B6E")]
	public enum TopUpEventPageType
	{
		[Token(Token = "0x4010A1C")]
		Payment,
		[Token(Token = "0x4010A1D")]
		Activity
	}

	[Token(Token = "0x2002B6F")]
	private sealed class _003CIERefreshArrowObject_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010A1E")]
		[FieldOffset(Offset = "0x8")]
		internal UITopUpEventController _0024this;

		[Token(Token = "0x4010A1F")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010A20")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010A21")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170012E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011EA6")]
			[Address(RVA = "0x2AF6B88", Offset = "0x2AF6B88", VA = "0x2AF6B88", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011EA7")]
			[Address(RVA = "0x2AF6B90", Offset = "0x2AF6B90", VA = "0x2AF6B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011EA4")]
		[Address(RVA = "0x2AF67FC", Offset = "0x2AF67FC", VA = "0x2AF67FC")]
		public _003CIERefreshArrowObject_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6011EA5")]
		[Address(RVA = "0x2AF6ACC", Offset = "0x2AF6ACC", VA = "0x2AF6ACC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6011EA8")]
		[Address(RVA = "0x2AF6B98", Offset = "0x2AF6B98", VA = "0x2AF6B98", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6011EA9")]
		[Address(RVA = "0x2AF6BAC", Offset = "0x2AF6BAC", VA = "0x2AF6BAC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4010A0F")]
	private const uint TOTALWIDTH = 510u;

	[Token(Token = "0x4010A10")]
	private const uint AWARDEXPRESSION = 1u;

	[Token(Token = "0x4010A11")]
	[FieldOffset(Offset = "0x38")]
	private TopUpEventPageType m_TopUpEventPageType;

	[Token(Token = "0x4010A12")]
	[FieldOffset(Offset = "0x3C")]
	private int m_CurrentSubTabIndex;

	[Token(Token = "0x4010A13")]
	[FieldOffset(Offset = "0x40")]
	private AwardDesc m_CurrentPreviewItem;

	[Token(Token = "0x4010A14")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsInPreview;

	[Token(Token = "0x4010A15")]
	[FieldOffset(Offset = "0x48")]
	private ActivityGroupDesc m_GroupDesc;

	[Token(Token = "0x4010A16")]
	[FieldOffset(Offset = "0x4C")]
	private List<UITopUpEventItemController> m_ItemControllers;

	[Token(Token = "0x4010A17")]
	[FieldOffset(Offset = "0x50")]
	private List<UITopUpEventProgressItemController> m_ProgressItemControllers;

	[Token(Token = "0x4010A18")]
	[FieldOffset(Offset = "0x54")]
	private UITopUpEventView m_View;

	[Token(Token = "0x4010A19")]
	[FieldOffset(Offset = "0x58")]
	private UIModelActivity m_Model;

	[Token(Token = "0x4010A1A")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_ShowModel;

	[Token(Token = "0x6011E8B")]
	[Address(RVA = "0x2AF3C70", Offset = "0x2AF3C70", VA = "0x2AF3C70")]
	public UITopUpEventController()
	{
	}

	[Token(Token = "0x6011E8C")]
	[Address(RVA = "0x2AF3D38", Offset = "0x2AF3D38", VA = "0x2AF3D38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E8D")]
	[Address(RVA = "0x2AF3DE0", Offset = "0x2AF3DE0", VA = "0x2AF3DE0", Slot = "31")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6011E8E")]
	[Address(RVA = "0x2AF3E80", Offset = "0x2AF3E80", VA = "0x2AF3E80", Slot = "32")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6011E8F")]
	[Address(RVA = "0x2AF3ED8", Offset = "0x2AF3ED8", VA = "0x2AF3ED8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011E90")]
	[Address(RVA = "0x2AF3964", Offset = "0x2AF3964", VA = "0x2AF3964")]
	public void OnPreviewStateChange(bool needShow, bool needRefresh = false)
	{
	}

	[Token(Token = "0x6011E91")]
	[Address(RVA = "0x2AF4454", Offset = "0x2AF4454", VA = "0x2AF4454")]
	private void OpenPreviewInternal()
	{
	}

	[Token(Token = "0x6011E92")]
	[Address(RVA = "0x2AF43D4", Offset = "0x2AF43D4", VA = "0x2AF43D4")]
	private void ClosePreviewInternal()
	{
	}

	[Token(Token = "0x6011E93")]
	[Address(RVA = "0x2AF44D4", Offset = "0x2AF44D4", VA = "0x2AF44D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011E94")]
	[Address(RVA = "0x2AF40DC", Offset = "0x2AF40DC", VA = "0x2AF40DC")]
	private void RefreshPreviewItem()
	{
	}

	[Token(Token = "0x6011E95")]
	[Address(RVA = "0x2AF462C", Offset = "0x2AF462C", VA = "0x2AF462C", Slot = "33")]
	protected override bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x6011E96")]
	[Address(RVA = "0x2AF4684", Offset = "0x2AF4684", VA = "0x2AF4684")]
	private void ShowPreview(object[] parameters)
	{
	}

	[Token(Token = "0x6011E97")]
	[Address(RVA = "0x2AF4948", Offset = "0x2AF4948", VA = "0x2AF4948")]
	public void RefreshContent()
	{
	}

	[Token(Token = "0x6011E98")]
	[Address(RVA = "0x2AF4AA8", Offset = "0x2AF4AA8", VA = "0x2AF4AA8")]
	private void RefreshViewInternal()
	{
	}

	[Token(Token = "0x6011E99")]
	[Address(RVA = "0x2AF4B18", Offset = "0x2AF4B18", VA = "0x2AF4B18")]
	public void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
	{
	}

	[Token(Token = "0x6011E9A")]
	[Address(RVA = "0x2AF1C58", Offset = "0x2AF1C58", VA = "0x2AF1C58")]
	public void SetViewData(ActivityGroupDesc activityGroupDesc, bool isInternal = false)
	{
	}

	[Token(Token = "0x6011E9B")]
	[Address(RVA = "0x2AF6730", Offset = "0x2AF6730", VA = "0x2AF6730")]
	private IEnumerator IERefreshArrowObject()
	{
		return null;
	}

	[Token(Token = "0x6011E9C")]
	[Address(RVA = "0x2AF6804", Offset = "0x2AF6804", VA = "0x2AF6804")]
	private void OnCDNLoaded()
	{
	}

	[Token(Token = "0x6011E9D")]
	[Address(RVA = "0x2AF1AAC", Offset = "0x2AF1AAC", VA = "0x2AF1AAC")]
	public void SetPageType(TopUpEventPageType type)
	{
	}

	[Token(Token = "0x6011E9E")]
	[Address(RVA = "0x2AF68C0", Offset = "0x2AF68C0", VA = "0x2AF68C0", Slot = "52")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011E9F")]
	[Address(RVA = "0x2AF6954", Offset = "0x2AF6954", VA = "0x2AF6954", Slot = "51")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011EA0")]
	[Address(RVA = "0x2AF6A08", Offset = "0x2AF6A08", VA = "0x2AF6A08")]
	private int SortByCondtionValue(ClientActivityDesc a, ClientActivityDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6011EA1")]
	[Address(RVA = "0x2AF6AB4", Offset = "0x2AF6AB4", VA = "0x2AF6AB4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011EA2")]
	[Address(RVA = "0x2AF6ABC", Offset = "0x2AF6ABC", VA = "0x2AF6ABC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011EA3")]
	[Address(RVA = "0x2AF6AC4", Offset = "0x2AF6AC4", VA = "0x2AF6AC4")]
	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}
}
