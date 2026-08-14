using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20029D0")]
public class UIMultiPopMenuController : UIPopupWindowController
{
	[Token(Token = "0x20029D1")]
	private sealed class _003CSetData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010130")]
		[FieldOffset(Offset = "0x8")]
		internal int curLayer;

		[Token(Token = "0x6010D35")]
		[Address(RVA = "0x222E720", Offset = "0x222E720", VA = "0x222E720")]
		public _003CSetData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010D36")]
		[Address(RVA = "0x222E728", Offset = "0x222E728", VA = "0x222E728")]
		internal bool _003C_003Em__0(MultiPopMenuListData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20029D2")]
	private sealed class _003COnChange_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010131")]
		[FieldOffset(Offset = "0x8")]
		internal int currentSelectCount;

		[Token(Token = "0x4010132")]
		[FieldOffset(Offset = "0xC")]
		internal UIMultiPopMenuController _0024this;

		[Token(Token = "0x6010D37")]
		[Address(RVA = "0x222E698", Offset = "0x222E698", VA = "0x222E698")]
		public _003COnChange_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010D38")]
		[Address(RVA = "0x222E6A0", Offset = "0x222E6A0", VA = "0x222E6A0")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x20029D3")]
	private sealed class _003COnClickMenuItem_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010133")]
		[FieldOffset(Offset = "0x8")]
		internal int currentSelectCount;

		[Token(Token = "0x4010134")]
		[FieldOffset(Offset = "0xC")]
		internal UIMultiPopMenuController _0024this;

		[Token(Token = "0x6010D39")]
		[Address(RVA = "0x222E6DC", Offset = "0x222E6DC", VA = "0x222E6DC")]
		public _003COnClickMenuItem_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6010D3A")]
		[Address(RVA = "0x222E6E4", Offset = "0x222E6E4", VA = "0x222E6E4")]
		internal void _003C_003Em__0(object obj)
		{
		}
	}

	[Token(Token = "0x4010123")]
	private const float MAX_ITEM_COUNT = 4.5f;

	[Token(Token = "0x4010124")]
	public const string DEFAULT_LABELSTRING = "TXT_BANNER_NAME_DEFAULT";

	[Token(Token = "0x4010125")]
	[FieldOffset(Offset = "0x48")]
	private UIWidget m_Widget;

	[Token(Token = "0x4010126")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIPopMenuController> m_SubMenus;

	[Token(Token = "0x4010127")]
	[FieldOffset(Offset = "0x50")]
	private List<string> m_DecisionContents;

	[Token(Token = "0x4010128")]
	[FieldOffset(Offset = "0x54")]
	private List<string> m_TempSelection;

	[Token(Token = "0x4010129")]
	[FieldOffset(Offset = "0x58")]
	private Func<Transform, Vector3, UIPopMenuController> m_OnOpenMenu;

	[Token(Token = "0x401012A")]
	[FieldOffset(Offset = "0x5C")]
	private List<MultiPopMenuData> m_Contents;

	[Token(Token = "0x401012B")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 m_StartOffset;

	[Token(Token = "0x401012C")]
	[FieldOffset(Offset = "0x6C")]
	private Action<List<string>> m_OnChoose;

	[Token(Token = "0x401012D")]
	[FieldOffset(Offset = "0x70")]
	private UIMultiPopMenuView m_View;

	[Token(Token = "0x401012E")]
	[FieldOffset(Offset = "0x0")]
	private static PopMenuDelegate _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401012F")]
	[FieldOffset(Offset = "0x4")]
	private static PopMenuDelegate _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6010D23")]
	[Address(RVA = "0x148BFA4", Offset = "0x148BFA4", VA = "0x148BFA4")]
	public UIMultiPopMenuController()
	{
	}

	[Token(Token = "0x6010D24")]
	[Address(RVA = "0x148C07C", Offset = "0x148C07C", VA = "0x148C07C", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6010D25")]
	[Address(RVA = "0x148C084", Offset = "0x148C084", VA = "0x148C084")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D26")]
	[Address(RVA = "0x148C0E8", Offset = "0x148C0E8", VA = "0x148C0E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D27")]
	[Address(RVA = "0x148C1FC", Offset = "0x148C1FC", VA = "0x148C1FC")]
	private void OnClickeMask()
	{
	}

	[Token(Token = "0x6010D28")]
	[Address(RVA = "0x148C340", Offset = "0x148C340", VA = "0x148C340")]
	private void OnChoose()
	{
	}

	[Token(Token = "0x6010D29")]
	[Address(RVA = "0x148C21C", Offset = "0x148C21C", VA = "0x148C21C")]
	private void Clear()
	{
	}

	[Token(Token = "0x6010D2A")]
	[Address(RVA = "0x148C7EC", Offset = "0x148C7EC", VA = "0x148C7EC")]
	public void SetData(UIWidget widget, Action<List<string>> onChoose, List<MultiPopMenuListData> contents, Vector3 startOffset, bool needDefault = true, string[] defaultIDs)
	{
	}

	[Token(Token = "0x6010D2B")]
	[Address(RVA = "0x148CE94", Offset = "0x148CE94", VA = "0x148CE94")]
	public void SetData(UIWidget widget, Action<List<string>> onChoose, List<MultiPopMenuData> contents, Vector3 startOffset, bool needDefault = true, string[] defaultIDs)
	{
	}

	[Token(Token = "0x6010D2C")]
	[Address(RVA = "0x148D1D0", Offset = "0x148D1D0", VA = "0x148D1D0")]
	private void ModifyStartPosition(Vector3 offset)
	{
	}

	[Token(Token = "0x6010D2D")]
	[Address(RVA = "0x148D1DC", Offset = "0x148D1DC", VA = "0x148D1DC")]
	private void OnChange()
	{
	}

	[Token(Token = "0x6010D2E")]
	[Address(RVA = "0x148DA44", Offset = "0x148DA44", VA = "0x148DA44")]
	private void OnClickMenuItem(int parentIndex, object data)
	{
	}

	[Token(Token = "0x6010D2F")]
	[Address(RVA = "0x148E984", Offset = "0x148E984", VA = "0x148E984")]
	private bool IsInUse(string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6010D30")]
	[Address(RVA = "0x148E6E8", Offset = "0x148E6E8", VA = "0x148E6E8")]
	private List<MultiPopMenuData> GetContent()
	{
		return null;
	}

	[Token(Token = "0x6010D31")]
	[Address(RVA = "0x148C3D0", Offset = "0x148C3D0", VA = "0x148C3D0")]
	private List<string> GetDestString()
	{
		return null;
	}

	[Token(Token = "0x6010D32")]
	[Address(RVA = "0x148EC00", Offset = "0x148EC00", VA = "0x148EC00")]
	private UIPopMenuController _003CSetData_003Em__0(Transform parent, Vector3 offset)
	{
		return null;
	}

	[Token(Token = "0x6010D33")]
	[Address(RVA = "0x148EE54", Offset = "0x148EE54", VA = "0x148EE54")]
	private static void _003COnChange_003Em__1()
	{
	}

	[Token(Token = "0x6010D34")]
	[Address(RVA = "0x148EE58", Offset = "0x148EE58", VA = "0x148EE58")]
	private static void _003COnClickMenuItem_003Em__2()
	{
	}
}
