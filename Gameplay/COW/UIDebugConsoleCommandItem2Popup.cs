using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200209C")]
public class UIDebugConsoleCommandItem2Popup : UIBaseController, _Attribute
{
	[Token(Token = "0x200209D")]
	public class Data
	{
		[Token(Token = "0x400CC48")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400CC49")]
		[FieldOffset(Offset = "0xC")]
		public string cmd;

		[Token(Token = "0x400CC4A")]
		[FieldOffset(Offset = "0x10")]
		public string arg1Name;

		[Token(Token = "0x400CC4B")]
		[FieldOffset(Offset = "0x14")]
		public string arg2Name;

		[Token(Token = "0x400CC4C")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<string>> argValueMap;

		[Token(Token = "0x600A80B")]
		[Address(RVA = "0x11F9A24", Offset = "0x11F9A24", VA = "0x11F9A24")]
		public Data()
		{
		}
	}

	[Token(Token = "0x200209E")]
	public delegate void OnRunCmd(string cmd, string arg1, string arg2);

	[Token(Token = "0x400CC41")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugConsoleCommandItem2PopupView m_View;

	[Token(Token = "0x400CC42")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_Data;

	[Token(Token = "0x400CC43")]
	[FieldOffset(Offset = "0x30")]
	private UIPopMenuSmallControler m_Arg1Popup;

	[Token(Token = "0x400CC44")]
	[FieldOffset(Offset = "0x34")]
	private UIPopMenuSmallControler m_Arg2Popup;

	[Token(Token = "0x400CC45")]
	[FieldOffset(Offset = "0x38")]
	private string m_CurArg1Value;

	[Token(Token = "0x400CC46")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CurArg2Value;

	[Token(Token = "0x400CC47")]
	[FieldOffset(Offset = "0x40")]
	public OnRunCmd OnRunCmdHandler;

	[Token(Token = "0x600A7FD")]
	[Address(RVA = "0x11F8278", Offset = "0x11F8278", VA = "0x11F8278")]
	public UIDebugConsoleCommandItem2Popup()
	{
	}

	[Token(Token = "0x600A7FE")]
	[Address(RVA = "0x11F82FC", Offset = "0x11F82FC", VA = "0x11F82FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A7FF")]
	[Address(RVA = "0x11F83A4", Offset = "0x11F83A4", VA = "0x11F83A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A800")]
	[Address(RVA = "0x11F8500", Offset = "0x11F8500", VA = "0x11F8500", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600A801")]
	[Address(RVA = "0x11F8ABC", Offset = "0x11F8ABC", VA = "0x11F8ABC", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600A802")]
	[Address(RVA = "0x11F8BE4", Offset = "0x11F8BE4", VA = "0x11F8BE4", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600A803")]
	[Address(RVA = "0x11F8C74", Offset = "0x11F8C74", VA = "0x11F8C74")]
	private void OnArg1PopupClick()
	{
	}

	[Token(Token = "0x600A804")]
	[Address(RVA = "0x11F8E20", Offset = "0x11F8E20", VA = "0x11F8E20")]
	private void UpdateArg1Type(object targetArg1Type)
	{
	}

	[Token(Token = "0x600A805")]
	[Address(RVA = "0x11F8F48", Offset = "0x11F8F48", VA = "0x11F8F48")]
	private void OnArg2PopupClick()
	{
	}

	[Token(Token = "0x600A806")]
	[Address(RVA = "0x11F910C", Offset = "0x11F910C", VA = "0x11F910C")]
	private void UpdateArg2Type(object targetArg2Type)
	{
	}

	[Token(Token = "0x600A807")]
	[Address(RVA = "0x11F9234", Offset = "0x11F9234", VA = "0x11F9234")]
	private void OnCmdClick()
	{
	}

	[Token(Token = "0x600A808")]
	[Address(RVA = "0x11F96EC", Offset = "0x11F96EC", VA = "0x11F96EC")]
	private PopMenuData _003COnArg1PopupClick_003Em__0(string item)
	{
		return null;
	}

	[Token(Token = "0x600A809")]
	[Address(RVA = "0x11F9884", Offset = "0x11F9884", VA = "0x11F9884")]
	private PopMenuData _003COnArg2PopupClick_003Em__1(string item)
	{
		return null;
	}

	[Token(Token = "0x600A80A")]
	[Address(RVA = "0x11F9A1C", Offset = "0x11F9A1C", VA = "0x11F9A1C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
