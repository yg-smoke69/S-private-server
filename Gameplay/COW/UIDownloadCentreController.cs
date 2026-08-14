using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020BD")]
public class UIDownloadCentreController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x20020BE")]
	private sealed class _003CScrollerToSpecificTab_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CD1F")]
		[FieldOffset(Offset = "0x8")]
		internal uint patchOptionalTypeId;

		[Token(Token = "0x600A924")]
		[Address(RVA = "0x276459C", Offset = "0x276459C", VA = "0x276459C")]
		public _003CScrollerToSpecificTab_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A925")]
		[Address(RVA = "0x27654B8", Offset = "0x27654B8", VA = "0x27654B8")]
		internal bool _003C_003Em__0(uint x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CD12")]
	[FieldOffset(Offset = "0x48")]
	private UIDownloadCentreView m_View;

	[Token(Token = "0x400CD13")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelOptionalDownload m_Model;

	[Token(Token = "0x400CD14")]
	[FieldOffset(Offset = "0x50")]
	private EModelDownloadState m_LastShowedState;

	[Token(Token = "0x400CD15")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CurrentSelectTabTypeId;

	[Token(Token = "0x400CD16")]
	[FieldOffset(Offset = "0x58")]
	private uint m_GridTabTypeId;

	[Token(Token = "0x400CD17")]
	[FieldOffset(Offset = "0x5C")]
	private List<uint> m_TabDownloadTypeList;

	[Token(Token = "0x400CD18")]
	[FieldOffset(Offset = "0x60")]
	private List<UIDownloadCentreTabItemController> m_TabItems;

	[Token(Token = "0x400CD19")]
	[FieldOffset(Offset = "0x64")]
	private DownloadCentreContentItemShowType m_ShowType;

	[Token(Token = "0x400CD1A")]
	[FieldOffset(Offset = "0x68")]
	private List<uint> m_DownloadInfoShowTagList;

	[Token(Token = "0x400CD1B")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_HitnLabelPosition;

	[Token(Token = "0x400CD1C")]
	public const int MAXLEFTTABGRID = 5;

	[Token(Token = "0x400CD1D")]
	[FieldOffset(Offset = "0x78")]
	private bool m_showLogin;

	[Token(Token = "0x400CD1E")]
	[FieldOffset(Offset = "0x7C")]
	private float TotalTimeForNetState;

	[Token(Token = "0x17000FE3")]
	public bool SHOWINLOGIN
	{
		[Token(Token = "0x600A909")]
		[Address(RVA = "0x27620C0", Offset = "0x27620C0", VA = "0x27620C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A90A")]
		[Address(RVA = "0x2762118", Offset = "0x2762118", VA = "0x2762118")]
		set
		{
		}
	}

	[Token(Token = "0x600A908")]
	[Address(RVA = "0x2761FE0", Offset = "0x2761FE0", VA = "0x2761FE0")]
	public UIDownloadCentreController()
	{
	}

	[Token(Token = "0x600A90B")]
	[Address(RVA = "0x2762260", Offset = "0x2762260", VA = "0x2762260")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A90C")]
	[Address(RVA = "0x2762308", Offset = "0x2762308", VA = "0x2762308", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x600A90D")]
	[Address(RVA = "0x276241C", Offset = "0x276241C", VA = "0x276241C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A90E")]
	[Address(RVA = "0x2763968", Offset = "0x2763968", VA = "0x2763968", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A90F")]
	[Address(RVA = "0x2763AE0", Offset = "0x2763AE0", VA = "0x2763AE0")]
	private void Update()
	{
	}

	[Token(Token = "0x600A910")]
	[Address(RVA = "0x2763DF4", Offset = "0x2763DF4", VA = "0x2763DF4", Slot = "24")]
	protected override void RefreshVisibility()
	{
	}

	[Token(Token = "0x600A911")]
	[Address(RVA = "0x2763E94", Offset = "0x2763E94", VA = "0x2763E94")]
	private void TabItemClick(object[] data)
	{
	}

	[Token(Token = "0x600A912")]
	[Address(RVA = "0x2763F70", Offset = "0x2763F70", VA = "0x2763F70")]
	public void GotoSpeicficTab(uint patchOptionalTypeId)
	{
	}

	[Token(Token = "0x600A913")]
	[Address(RVA = "0x2764148", Offset = "0x2764148", VA = "0x2764148")]
	public void ScrollerToSpecificTab(uint patchOptionalTypeId)
	{
	}

	[Token(Token = "0x600A914")]
	[Address(RVA = "0x27645A4", Offset = "0x27645A4", VA = "0x27645A4")]
	private void InitTabCtrlState()
	{
	}

	[Token(Token = "0x600A915")]
	[Address(RVA = "0x2762BFC", Offset = "0x2762BFC", VA = "0x2762BFC")]
	private void TabDataControllerInit()
	{
	}

	[Token(Token = "0x600A916")]
	[Address(RVA = "0x27647BC", Offset = "0x27647BC", VA = "0x27647BC")]
	private UIDownloadCentreTabItemController OpenNewDownloadCentreTabItemController()
	{
		return null;
	}

	[Token(Token = "0x600A917")]
	[Address(RVA = "0x27632E0", Offset = "0x27632E0", VA = "0x27632E0")]
	private void RefreshNowContentShowType()
	{
	}

	[Token(Token = "0x600A918")]
	[Address(RVA = "0x2762A00", Offset = "0x2762A00", VA = "0x2762A00")]
	private void SetNowNewState()
	{
	}

	[Token(Token = "0x600A919")]
	[Address(RVA = "0x2764E64", Offset = "0x2764E64", VA = "0x2764E64")]
	private void OnDownloadAllClick()
	{
	}

	[Token(Token = "0x600A91A")]
	[Address(RVA = "0x27650D0", Offset = "0x27650D0", VA = "0x27650D0", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A91B")]
	[Address(RVA = "0x27651C4", Offset = "0x27651C4", VA = "0x27651C4")]
	public void RefreshDownloadCentreItemShow()
	{
	}

	[Token(Token = "0x600A91C")]
	[Address(RVA = "0x276525C", Offset = "0x276525C", VA = "0x276525C", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A91D")]
	[Address(RVA = "0x27652F0", Offset = "0x27652F0", VA = "0x27652F0", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A91E")]
	[Address(RVA = "0x276541C", Offset = "0x276541C", VA = "0x276541C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A91F")]
	[Address(RVA = "0x27636D0", Offset = "0x27636D0", VA = "0x27636D0")]
	private void DownloadAllBtnStateInit()
	{
	}

	[Token(Token = "0x600A920")]
	[Address(RVA = "0x2765498", Offset = "0x2765498", VA = "0x2765498")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x600A921")]
	[Address(RVA = "0x27654A0", Offset = "0x27654A0", VA = "0x27654A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A922")]
	[Address(RVA = "0x27654A8", Offset = "0x27654A8", VA = "0x27654A8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A923")]
	[Address(RVA = "0x27654B0", Offset = "0x27654B0", VA = "0x27654B0")]
	public void _003C_003EiFixBaseProxy_RefreshVisibility()
	{
	}
}
