using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AF4")]
public class UIRoomModeSelectPopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x40107AB")]
	[FieldOffset(Offset = "0x48")]
	private UIRoomModeSelectPopupWindowView m_View;

	[Token(Token = "0x40107AC")]
	[FieldOffset(Offset = "0x4C")]
	private Action OnApplyCallBackFn;

	[Token(Token = "0x40107AD")]
	[FieldOffset(Offset = "0x50")]
	private List<UIRoomModeSelectPopupItemController> m_GroupModes;

	[Token(Token = "0x40107AE")]
	[FieldOffset(Offset = "0x54")]
	private UIWidget m_PasswordWidget;

	[Token(Token = "0x40107AF")]
	[FieldOffset(Offset = "0x58")]
	private UIWidget m_SimulatorWidget;

	[Token(Token = "0x40107B0")]
	[FieldOffset(Offset = "0x5C")]
	private List<string> m_PasswordIDs;

	[Token(Token = "0x40107B1")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_SimulatorIDs;

	[Token(Token = "0x40107B2")]
	[FieldOffset(Offset = "0x64")]
	private List<string> m_PasswordAllIDs;

	[Token(Token = "0x40107B3")]
	[FieldOffset(Offset = "0x68")]
	private List<string> m_SimulatorAllIDs;

	[Token(Token = "0x40107B4")]
	[FieldOffset(Offset = "0x6C")]
	private List<MultiPopMenuListData> m_PopMenuListPasswords;

	[Token(Token = "0x40107B5")]
	[FieldOffset(Offset = "0x70")]
	private List<MultiPopMenuListData> m_PopMenuListSimulators;

	[Token(Token = "0x40107B6")]
	[FieldOffset(Offset = "0x0")]
	private static bool[] m_LastSelectGameModes;

	[Token(Token = "0x40107B7")]
	[FieldOffset(Offset = "0x4")]
	private static int m_LastSelectPasswordIndex;

	[Token(Token = "0x40107B8")]
	[FieldOffset(Offset = "0x8")]
	private static int m_LastSelectSimulatorIndex;

	[Token(Token = "0x6011A07")]
	[Address(RVA = "0x23D3598", Offset = "0x23D3598", VA = "0x23D3598")]
	public UIRoomModeSelectPopupWindowController()
	{
	}

	[Token(Token = "0x6011A08")]
	[Address(RVA = "0x23D38A0", Offset = "0x23D38A0", VA = "0x23D38A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A09")]
	[Address(RVA = "0x23CB17C", Offset = "0x23CB17C", VA = "0x23CB17C")]
	public static void ClearSavedData()
	{
	}

	[Token(Token = "0x6011A0A")]
	[Address(RVA = "0x23D3944", Offset = "0x23D3944", VA = "0x23D3944")]
	public void SetApplyCallBackFn(Action callback)
	{
	}

	[Token(Token = "0x6011A0B")]
	[Address(RVA = "0x23D39A4", Offset = "0x23D39A4", VA = "0x23D39A4", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011A0C")]
	[Address(RVA = "0x23D3A20", Offset = "0x23D3A20", VA = "0x23D3A20", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011A0D")]
	[Address(RVA = "0x23D3B18", Offset = "0x23D3B18", VA = "0x23D3B18")]
	public void SetItemsData(List<FRoomModeSelectData> list, string countDownTxt = "")
	{
	}

	[Token(Token = "0x6011A0E")]
	[Address(RVA = "0x23CBAD8", Offset = "0x23CBAD8", VA = "0x23CBAD8")]
	public void OnCountDownStarted()
	{
	}

	[Token(Token = "0x6011A0F")]
	[Address(RVA = "0x23CBCA4", Offset = "0x23CBCA4", VA = "0x23CBCA4")]
	public void OnCountDownUpdate(string countDownTxt)
	{
	}

	[Token(Token = "0x6011A10")]
	[Address(RVA = "0x23CBD3C", Offset = "0x23CBD3C", VA = "0x23CBD3C")]
	public void OnCountDownFinished()
	{
	}

	[Token(Token = "0x6011A11")]
	[Address(RVA = "0x23D3CC4", Offset = "0x23D3CC4", VA = "0x23D3CC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A12")]
	[Address(RVA = "0x23D4A0C", Offset = "0x23D4A0C", VA = "0x23D4A0C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011A13")]
	[Address(RVA = "0x23D4DE8", Offset = "0x23D4DE8", VA = "0x23D4DE8")]
	private void UpdateGroupMode()
	{
	}

	[Token(Token = "0x6011A14")]
	[Address(RVA = "0x23D4FA0", Offset = "0x23D4FA0", VA = "0x23D4FA0")]
	public void OnClickPassword()
	{
	}

	[Token(Token = "0x6011A15")]
	[Address(RVA = "0x23D479C", Offset = "0x23D479C", VA = "0x23D479C")]
	private void UpdatePasswordView()
	{
	}

	[Token(Token = "0x6011A16")]
	[Address(RVA = "0x23D51AC", Offset = "0x23D51AC", VA = "0x23D51AC")]
	public void OnClickSimulator()
	{
	}

	[Token(Token = "0x6011A17")]
	[Address(RVA = "0x23D48D4", Offset = "0x23D48D4", VA = "0x23D48D4")]
	private void UpdateSimulatorView()
	{
	}

	[Token(Token = "0x6011A18")]
	[Address(RVA = "0x23D53B8", Offset = "0x23D53B8", VA = "0x23D53B8")]
	private void OnClickApplyBtn()
	{
	}

	[Token(Token = "0x6011A1A")]
	[Address(RVA = "0x23D54C8", Offset = "0x23D54C8", VA = "0x23D54C8")]
	private void _003COnClickPassword_003Em__0(List<string> ids)
	{
	}

	[Token(Token = "0x6011A1B")]
	[Address(RVA = "0x23D54D0", Offset = "0x23D54D0", VA = "0x23D54D0")]
	private void _003COnClickSimulator_003Em__1(List<string> ids)
	{
	}

	[Token(Token = "0x6011A1C")]
	[Address(RVA = "0x23D54D8", Offset = "0x23D54D8", VA = "0x23D54D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A1D")]
	[Address(RVA = "0x23D54E0", Offset = "0x23D54E0", VA = "0x23D54E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
