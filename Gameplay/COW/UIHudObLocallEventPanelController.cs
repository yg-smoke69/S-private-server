using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027E4")]
public class UIHudObLocallEventPanelController : UIBaseController
{
	[Token(Token = "0x20027E5")]
	private struct LocalEventItem
	{
		[Token(Token = "0x400F64C")]
		[FieldOffset(Offset = "0x0")]
		public GameObject gray;

		[Token(Token = "0x400F64D")]
		[FieldOffset(Offset = "0x4")]
		public UISprite icon;

		[Token(Token = "0x400F64E")]
		[FieldOffset(Offset = "0x8")]
		public UILabel name;

		[Token(Token = "0x400F64F")]
		[FieldOffset(Offset = "0xC")]
		public int eventID;

		[Token(Token = "0x400F650")]
		[FieldOffset(Offset = "0x10")]
		public UIToggleButton toggle;
	}

	[Token(Token = "0x400F645")]
	[FieldOffset(Offset = "0x28")]
	private UIHudObLocallEventPanelView m_View;

	[Token(Token = "0x400F646")]
	[FieldOffset(Offset = "0x2C")]
	private List<LocalEventItem> m_EventData;

	[Token(Token = "0x400F647")]
	[FieldOffset(Offset = "0x30")]
	private int m_EventIdSelected;

	[Token(Token = "0x400F648")]
	[FieldOffset(Offset = "0x34")]
	private LocalEventItem m_EventItemSelected;

	[Token(Token = "0x400F649")]
	[FieldOffset(Offset = "0x48")]
	private LDAFPHICDJJ m_EventManager;

	[Token(Token = "0x400F64A")]
	[FieldOffset(Offset = "0x4C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F64B")]
	[FieldOffset(Offset = "0x50")]
	private bool isCD;

	[Token(Token = "0x600F74D")]
	[Address(RVA = "0x182D24C", Offset = "0x182D24C", VA = "0x182D24C")]
	public UIHudObLocallEventPanelController()
	{
	}

	[Token(Token = "0x600F74E")]
	[Address(RVA = "0x182D304", Offset = "0x182D304", VA = "0x182D304")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F74F")]
	[Address(RVA = "0x182D3AC", Offset = "0x182D3AC", VA = "0x182D3AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F750")]
	[Address(RVA = "0x182E698", Offset = "0x182E698", VA = "0x182E698", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F751")]
	[Address(RVA = "0x182D830", Offset = "0x182D830", VA = "0x182D830")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600F752")]
	[Address(RVA = "0x182EB24", Offset = "0x182EB24", VA = "0x182EB24")]
	private void RefreshCD()
	{
	}

	[Token(Token = "0x600F753")]
	[Address(RVA = "0x182F548", Offset = "0x182F548", VA = "0x182F548")]
	private void OnCDEndNtf(object[] data)
	{
	}

	[Token(Token = "0x600F754")]
	[Address(RVA = "0x182F730", Offset = "0x182F730", VA = "0x182F730")]
	private void Update()
	{
	}

	[Token(Token = "0x600F755")]
	[Address(RVA = "0x182F030", Offset = "0x182F030", VA = "0x182F030")]
	private void OnToggleBtnClick(object obj, int idx)
	{
	}

	[Token(Token = "0x600F756")]
	[Address(RVA = "0x182F7E8", Offset = "0x182F7E8", VA = "0x182F7E8")]
	private void OnEventConfirm(object[] data)
	{
	}

	[Token(Token = "0x600F757")]
	[Address(RVA = "0x182FD20", Offset = "0x182FD20", VA = "0x182FD20")]
	private void OnShowLocalEventPanel(object[] data)
	{
	}

	[Token(Token = "0x600F758")]
	[Address(RVA = "0x182FF34", Offset = "0x182FF34", VA = "0x182FF34")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F759")]
	[Address(RVA = "0x1830108", Offset = "0x1830108", VA = "0x1830108")]
	private void OnBigmapClose(object[] data)
	{
	}

	[Token(Token = "0x600F75A")]
	[Address(RVA = "0x1830208", Offset = "0x1830208", VA = "0x1830208")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F75B")]
	[Address(RVA = "0x1830210", Offset = "0x1830210", VA = "0x1830210")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
