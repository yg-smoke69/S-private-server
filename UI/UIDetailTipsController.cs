using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20020B3")]
public class UIDetailTipsController : UIPopupWindowController
{
	[Token(Token = "0x20020B4")]
	private sealed class _003CSetPosition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CCD9")]
		[FieldOffset(Offset = "0x8")]
		internal Transform _003CcontentTr_003E__0;

		[Token(Token = "0x400CCDA")]
		[FieldOffset(Offset = "0xC")]
		internal Vector3 itemPos;

		[Token(Token = "0x400CCDB")]
		[FieldOffset(Offset = "0x18")]
		internal Vector3 _003Ccenter_003E__0;

		[Token(Token = "0x400CCDC")]
		[FieldOffset(Offset = "0x24")]
		internal Bounds _003Cbounds_003E__0;

		[Token(Token = "0x400CCDD")]
		[FieldOffset(Offset = "0x3C")]
		internal Vector3 _003CcontentLocalPos_003E__0;

		[Token(Token = "0x400CCDE")]
		[FieldOffset(Offset = "0x48")]
		internal UIDetailTipsController _0024this;

		[Token(Token = "0x400CCDF")]
		[FieldOffset(Offset = "0x4C")]
		internal object _0024current;

		[Token(Token = "0x400CCE0")]
		[FieldOffset(Offset = "0x50")]
		internal bool _0024disposing;

		[Token(Token = "0x400CCE1")]
		[FieldOffset(Offset = "0x54")]
		internal int _0024PC;

		[Token(Token = "0x17000FDF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A8C4")]
			[Address(RVA = "0x14724F4", Offset = "0x14724F4", VA = "0x14724F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FE0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A8C5")]
			[Address(RVA = "0x14724FC", Offset = "0x14724FC", VA = "0x14724FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A8C2")]
		[Address(RVA = "0x14718B0", Offset = "0x14718B0", VA = "0x14718B0")]
		public _003CSetPosition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A8C3")]
		[Address(RVA = "0x14720E0", Offset = "0x14720E0", VA = "0x14720E0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A8C6")]
		[Address(RVA = "0x1472504", Offset = "0x1472504", VA = "0x1472504", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A8C7")]
		[Address(RVA = "0x1472518", Offset = "0x1472518", VA = "0x1472518", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20020B5")]
	private sealed class _003CCreateShowProbabilityTipsBtnItem_003Ec__AnonStorey1
	{
		[Token(Token = "0x400CCE2")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemId;

		[Token(Token = "0x400CCE3")]
		[FieldOffset(Offset = "0xC")]
		internal UIDetailTipsController _0024this;

		[Token(Token = "0x600A8C8")]
		[Address(RVA = "0x1471AE0", Offset = "0x1471AE0", VA = "0x1471AE0")]
		public _003CCreateShowProbabilityTipsBtnItem_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600A8C9")]
		[Address(RVA = "0x1471FD0", Offset = "0x1471FD0", VA = "0x1471FD0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400CCCF")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Vector3 s_offset;

	[Token(Token = "0x400CCD0")]
	private const float m_HeightSpace = 40f;

	[Token(Token = "0x400CCD1")]
	private const int m_DefaultMaxLine = 24;

	[Token(Token = "0x400CCD2")]
	[FieldOffset(Offset = "0x48")]
	public Action<UIDetailTipsController> _onClose;

	[Token(Token = "0x400CCD3")]
	[FieldOffset(Offset = "0x4C")]
	private UIDetailTipsView m_View;

	[Token(Token = "0x400CCD4")]
	[FieldOffset(Offset = "0x50")]
	protected EDetailTipsStyle m_TipsStyle;

	[Token(Token = "0x400CCD5")]
	[FieldOffset(Offset = "0x54")]
	private bool m_CloseWithCollider;

	[Token(Token = "0x400CCD6")]
	[FieldOffset(Offset = "0x58")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400CCD7")]
	[FieldOffset(Offset = "0x5C")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400CCD8")]
	[FieldOffset(Offset = "0x60")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x600A8A5")]
	[Address(RVA = "0x146CF8C", Offset = "0x146CF8C", VA = "0x146CF8C")]
	public UIDetailTipsController()
	{
	}

	[Token(Token = "0x600A8A6")]
	[Address(RVA = "0x146CF94", Offset = "0x146CF94", VA = "0x146CF94")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A8A7")]
	[Address(RVA = "0x146CFF8", Offset = "0x146CFF8", VA = "0x146CFF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A8A8")]
	[Address(RVA = "0x146D440", Offset = "0x146D440", VA = "0x146D440")]
	private void SetItemInfoActive(bool v)
	{
	}

	[Token(Token = "0x600A8A9")]
	[Address(RVA = "0x146D31C", Offset = "0x146D31C", VA = "0x146D31C")]
	private void SetGainInfoActive(bool v)
	{
	}

	[Token(Token = "0x600A8AA")]
	[Address(RVA = "0x146D3F8", Offset = "0x146D3F8", VA = "0x146D3F8")]
	private void SetFakeItemInfoActive(bool v)
	{
	}

	[Token(Token = "0x600A8AB")]
	[Address(RVA = "0x146D4C4", Offset = "0x146D4C4", VA = "0x146D4C4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A8AC")]
	[Address(RVA = "0x146D5B0", Offset = "0x146D5B0", VA = "0x146D5B0", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600A8AD")]
	[Address(RVA = "0x146D5B8", Offset = "0x146D5B8", VA = "0x146D5B8", Slot = "35")]
	public override int MinGroupDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600A8AE")]
	[Address(RVA = "0x146D5D0", Offset = "0x146D5D0", VA = "0x146D5D0")]
	public void SetTipsStype(EDetailTipsStyle style)
	{
	}

	[Token(Token = "0x600A8AF")]
	[Address(RVA = "0x146D5D8", Offset = "0x146D5D8", VA = "0x146D5D8")]
	public void SetData(Vector3 itemPos, string title, string descrip)
	{
	}

	[Token(Token = "0x600A8B0")]
	[Address(RVA = "0x146FD44", Offset = "0x146FD44", VA = "0x146FD44")]
	public void SetData(Vector3 itemPos, string title, string descrip, List<ResourceID> spriteResIds, bool needResize = false)
	{
	}

	[Token(Token = "0x600A8B1")]
	[Address(RVA = "0x1470174", Offset = "0x1470174", VA = "0x1470174")]
	public void SetData(Vector3 itemPos, uint id)
	{
	}

	[Token(Token = "0x600A8B2")]
	[Address(RVA = "0x14704AC", Offset = "0x14704AC", VA = "0x14704AC")]
	public void SetData(Vector3 itemPos, BaseItemInfo info)
	{
	}

	[Token(Token = "0x600A8B3")]
	[Address(RVA = "0x14705B0", Offset = "0x14705B0", VA = "0x14705B0")]
	public void SetCountDownInfo(ulong endTime, bool closeOnFinish = true, string prefix = "", [Optional] OnFinished cb, uint color = uint.MaxValue)
	{
	}

	[Token(Token = "0x600A8B4")]
	[Address(RVA = "0x146D698", Offset = "0x146D698", VA = "0x146D698")]
	public void SetData(Vector3 itemPos, BaseItemInfo info, string name, string descrip, Vector3 offset, bool use_collider, EArrowFixedType arrowFixedType)
	{
	}

	[Token(Token = "0x600A8B5")]
	[Address(RVA = "0x1471030", Offset = "0x1471030", VA = "0x1471030")]
	public void InitHyperLevelShowForRampage(uint hyper_level, uint hyper_experience, uint oneLevel_experience)
	{
	}

	[Token(Token = "0x600A8B6")]
	[Address(RVA = "0x1471504", Offset = "0x1471504", VA = "0x1471504")]
	public void SetFakeItemData(Vector3 itemPos, string name, string descrip, ResourceID iconRes, bool use_collider = false)
	{
	}

	[Token(Token = "0x600A8B7")]
	[Address(RVA = "0x1470F84", Offset = "0x1470F84", VA = "0x1470F84")]
	private IEnumerator SetPosition(Vector3 itemPos)
	{
		return null;
	}

	[Token(Token = "0x600A8B8")]
	[Address(RVA = "0x1470E84", Offset = "0x1470E84", VA = "0x1470E84")]
	private void FixDescriptionScrollViewSize()
	{
	}

	[Token(Token = "0x600A8B9")]
	[Address(RVA = "0x1470A10", Offset = "0x1470A10", VA = "0x1470A10")]
	private void OpenDetailTipsItem(List<UIModelBigEvent.TokenTipsData> tokenTipsDataList)
	{
	}

	[Token(Token = "0x600A8BA")]
	[Address(RVA = "0x1470D20", Offset = "0x1470D20", VA = "0x1470D20")]
	private void AddShowProbabilityBtnItem(CSSharedItemData itData)
	{
	}

	[Token(Token = "0x600A8BB")]
	[Address(RVA = "0x14718B8", Offset = "0x14718B8", VA = "0x14718B8")]
	private void CreateShowProbabilityTipsBtnItem(uint itemId)
	{
	}

	[Token(Token = "0x600A8BC")]
	[Address(RVA = "0x1471AE8", Offset = "0x1471AE8", VA = "0x1471AE8")]
	private void CloseWithCollider()
	{
	}

	[Token(Token = "0x600A8BD")]
	[Address(RVA = "0x1471AFC", Offset = "0x1471AFC", VA = "0x1471AFC")]
	public string GetTipsDescrtion()
	{
		return null;
	}

	[Token(Token = "0x600A8BE")]
	[Address(RVA = "0x1471C24", Offset = "0x1471C24", VA = "0x1471C24")]
	private void _OnClose(object[] args)
	{
	}

	[Token(Token = "0x600A8BF")]
	[Address(RVA = "0x1471D4C", Offset = "0x1471D4C", VA = "0x1471D4C")]
	private void OnNavigationPused(object[] args)
	{
	}

	[Token(Token = "0x600A8C0")]
	[Address(RVA = "0x1471D60", Offset = "0x1471D60", VA = "0x1471D60")]
	public void SetBGBySpriteName(string spriteName)
	{
	}
}
