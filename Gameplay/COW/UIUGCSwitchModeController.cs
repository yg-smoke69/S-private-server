using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BC3")]
internal class UIUGCSwitchModeController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002BC4")]
	private sealed class _003CSetUI_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010B7B")]
		[FieldOffset(Offset = "0x8")]
		internal uint template;

		[Token(Token = "0x4010B7C")]
		[FieldOffset(Offset = "0xC")]
		internal uint mode;

		[Token(Token = "0x6012190")]
		[Address(RVA = "0xF42504", Offset = "0xF42504", VA = "0xF42504")]
		public _003CSetUI_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012191")]
		[Address(RVA = "0xF42C84", Offset = "0xF42C84", VA = "0xF42C84")]
		internal bool _003C_003Em__0(WorkshopCreateNewConfigData e)
		{
			return default(bool);
		}

		[Token(Token = "0x6012192")]
		[Address(RVA = "0xF42CBC", Offset = "0xF42CBC", VA = "0xF42CBC")]
		internal bool _003C_003Em__1(WorkshopCreateNewConfigData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010B75")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCSwitchModeView m_View;

	[Token(Token = "0x4010B76")]
	[FieldOffset(Offset = "0x4C")]
	private WorkshopCreateNewManager m_Mgr;

	[Token(Token = "0x4010B77")]
	[FieldOffset(Offset = "0x50")]
	private Action<WorkshopCreateNewConfigData> m_SelectedCallBack;

	[Token(Token = "0x4010B78")]
	[FieldOffset(Offset = "0x54")]
	private WorkshopCreateNewConfigData m_CurSelected;

	[Token(Token = "0x4010B79")]
	[FieldOffset(Offset = "0x58")]
	private List<WorkshopCreateNewConfigData> m_ClassicModeList;

	[Token(Token = "0x4010B7A")]
	[FieldOffset(Offset = "0x5C")]
	private List<WorkshopCreateNewConfigData> m_TemplateModeList;

	[Token(Token = "0x6012184")]
	[Address(RVA = "0xF41B48", Offset = "0xF41B48", VA = "0xF41B48")]
	public UIUGCSwitchModeController()
	{
	}

	[Token(Token = "0x6012185")]
	[Address(RVA = "0xF41BEC", Offset = "0xF41BEC", VA = "0xF41BEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012186")]
	[Address(RVA = "0xF41C94", Offset = "0xF41C94", VA = "0xF41C94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012187")]
	[Address(RVA = "0xF421A0", Offset = "0xF421A0", VA = "0xF421A0")]
	public void SetUI(uint selected, Action<WorkshopCreateNewConfigData> action)
	{
	}

	[Token(Token = "0x6012188")]
	[Address(RVA = "0xF4250C", Offset = "0xF4250C", VA = "0xF4250C")]
	private void OnModeSelected(object[] data)
	{
	}

	[Token(Token = "0x6012189")]
	[Address(RVA = "0xF426E4", Offset = "0xF426E4", VA = "0xF426E4")]
	private void OnCloseUI(object[] data)
	{
	}

	[Token(Token = "0x601218A")]
	[Address(RVA = "0xF42750", Offset = "0xF42750", VA = "0xF42750")]
	private void OnBtnApplyClick()
	{
	}

	[Token(Token = "0x601218B")]
	[Address(RVA = "0xF42808", Offset = "0xF42808", VA = "0xF42808")]
	private void OnBtnClassicClick()
	{
	}

	[Token(Token = "0x601218C")]
	[Address(RVA = "0xF42988", Offset = "0xF42988", VA = "0xF42988")]
	private void OnBtnTemplateClick()
	{
	}

	[Token(Token = "0x601218D")]
	[Address(RVA = "0xF42B08", Offset = "0xF42B08", VA = "0xF42B08", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601218E")]
	[Address(RVA = "0xF42C00", Offset = "0xF42C00", VA = "0xF42C00", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601218F")]
	[Address(RVA = "0xF42C7C", Offset = "0xF42C7C", VA = "0xF42C7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
