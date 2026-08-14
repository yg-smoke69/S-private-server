using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B9E")]
internal class UIUGCCreateNewWorkshopController : UIPopupWindowController
{
	[Token(Token = "0x2002B9F")]
	private class UIUGCCreateMapSelectItemEasyList : _Attribute
	{
		[Token(Token = "0x4010AE8")]
		[FieldOffset(Offset = "0x8")]
		private UIUGCCreateNewWorkshopController m_Ctrl;

		[Token(Token = "0x6012071")]
		[Address(RVA = "0x2B8D700", Offset = "0x2B8D700", VA = "0x2B8D700")]
		public UIUGCCreateMapSelectItemEasyList(UIUGCCreateNewWorkshopController ctrl)
		{
		}

		[Token(Token = "0x6012072")]
		[Address(RVA = "0x2B8E28C", Offset = "0x2B8E28C", VA = "0x2B8E28C", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6012073")]
		[Address(RVA = "0x2B8E398", Offset = "0x2B8E398", VA = "0x2B8E398", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	[Token(Token = "0x2002BA0")]
	private class UIUGCCreateModeSelectItemEasyList : _Attribute
	{
		[Token(Token = "0x4010AE9")]
		[FieldOffset(Offset = "0x8")]
		private UIUGCCreateNewWorkshopController m_Ctrl;

		[Token(Token = "0x6012074")]
		[Address(RVA = "0x2B8D6E0", Offset = "0x2B8D6E0", VA = "0x2B8D6E0")]
		public UIUGCCreateModeSelectItemEasyList(UIUGCCreateNewWorkshopController ctrl)
		{
		}

		[Token(Token = "0x6012075")]
		[Address(RVA = "0x2B8E414", Offset = "0x2B8E414", VA = "0x2B8E414", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6012076")]
		[Address(RVA = "0x2B8E520", Offset = "0x2B8E520", VA = "0x2B8E520", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	[Token(Token = "0x4010ADF")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCCreateNewWorkshopView m_View;

	[Token(Token = "0x4010AE0")]
	[FieldOffset(Offset = "0x4C")]
	private WorkshopCreateNewManager m_Mgr;

	[Token(Token = "0x4010AE1")]
	[FieldOffset(Offset = "0x50")]
	private List<WorkshopCreateNewConfigData> m_ClassicModeList;

	[Token(Token = "0x4010AE2")]
	[FieldOffset(Offset = "0x54")]
	private List<WorkshopCreateNewConfigData> m_TemplateModeList;

	[Token(Token = "0x4010AE3")]
	[FieldOffset(Offset = "0x58")]
	private List<WorkshopCreateNewConfigData> m_MapList;

	[Token(Token = "0x4010AE4")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_SelectedMap;

	[Token(Token = "0x4010AE5")]
	[FieldOffset(Offset = "0x60")]
	private uint m_SelectedModeWithTemplate;

	[Token(Token = "0x4010AE6")]
	[FieldOffset(Offset = "0x64")]
	private uint m_SelecteSlotId;

	[Token(Token = "0x4010AE7")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsClassicTab;

	[Token(Token = "0x6012064")]
	[Address(RVA = "0x2B8CCEC", Offset = "0x2B8CCEC", VA = "0x2B8CCEC")]
	public UIUGCCreateNewWorkshopController()
	{
	}

	[Token(Token = "0x6012065")]
	[Address(RVA = "0x2B8CDA8", Offset = "0x2B8CDA8", VA = "0x2B8CDA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012066")]
	[Address(RVA = "0x2B8CE50", Offset = "0x2B8CE50", VA = "0x2B8CE50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012067")]
	[Address(RVA = "0x2B8D720", Offset = "0x2B8D720", VA = "0x2B8D720")]
	private void OnBtnClassicClick()
	{
	}

	[Token(Token = "0x6012068")]
	[Address(RVA = "0x2B8D8B4", Offset = "0x2B8D8B4", VA = "0x2B8D8B4")]
	private void OnBtnTemplateClick()
	{
	}

	[Token(Token = "0x6012069")]
	[Address(RVA = "0x2B8DA48", Offset = "0x2B8DA48", VA = "0x2B8DA48")]
	public void SetViewData(uint seleceted)
	{
	}

	[Token(Token = "0x601206A")]
	[Address(RVA = "0x2B8DAA8", Offset = "0x2B8DAA8", VA = "0x2B8DAA8")]
	public void OnMapSelected(object[] data)
	{
	}

	[Token(Token = "0x601206B")]
	[Address(RVA = "0x2B8DBB8", Offset = "0x2B8DBB8", VA = "0x2B8DBB8")]
	public void OnModeSelected(object[] data)
	{
	}

	[Token(Token = "0x601206C")]
	[Address(RVA = "0x2B8DFB0", Offset = "0x2B8DFB0", VA = "0x2B8DFB0")]
	private void OnBtnApplyClick()
	{
	}

	[Token(Token = "0x601206D")]
	[Address(RVA = "0x2B8E144", Offset = "0x2B8E144", VA = "0x2B8E144", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x601206E")]
	[Address(RVA = "0x2B8E19C", Offset = "0x2B8E19C", VA = "0x2B8E19C")]
	private void _003COnModeSelected_003Em__0()
	{
	}

	[Token(Token = "0x601206F")]
	[Address(RVA = "0x2B8E27C", Offset = "0x2B8E27C", VA = "0x2B8E27C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012070")]
	[Address(RVA = "0x2B8E284", Offset = "0x2B8E284", VA = "0x2B8E284")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
