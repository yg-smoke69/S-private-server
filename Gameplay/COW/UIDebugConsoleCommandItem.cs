using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002093")]
public class UIDebugConsoleCommandItem : UIBaseController, _Attribute
{
	[Token(Token = "0x2002094")]
	public class Data
	{
		[Token(Token = "0x400CC2C")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400CC2D")]
		[FieldOffset(Offset = "0xC")]
		public string cmd;

		[Token(Token = "0x600A7DB")]
		[Address(RVA = "0x11F60C8", Offset = "0x11F60C8", VA = "0x11F60C8")]
		public Data()
		{
		}
	}

	[Token(Token = "0x2002095")]
	public delegate void OnRunCmd(string cmd);

	[Token(Token = "0x400CC29")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugConsoleCommandItemView m_View;

	[Token(Token = "0x400CC2A")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_Data;

	[Token(Token = "0x400CC2B")]
	[FieldOffset(Offset = "0x30")]
	public OnRunCmd OnRunCmdHandler;

	[Token(Token = "0x600A7D3")]
	[Address(RVA = "0x11F56E8", Offset = "0x11F56E8", VA = "0x11F56E8")]
	public UIDebugConsoleCommandItem()
	{
	}

	[Token(Token = "0x600A7D4")]
	[Address(RVA = "0x11F576C", Offset = "0x11F576C", VA = "0x11F576C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A7D5")]
	[Address(RVA = "0x11F5814", Offset = "0x11F5814", VA = "0x11F5814", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A7D6")]
	[Address(RVA = "0x11F5970", Offset = "0x11F5970", VA = "0x11F5970", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600A7D7")]
	[Address(RVA = "0x11F5AD0", Offset = "0x11F5AD0", VA = "0x11F5AD0", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600A7D8")]
	[Address(RVA = "0x11F5BF8", Offset = "0x11F5BF8", VA = "0x11F5BF8", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600A7D9")]
	[Address(RVA = "0x11F5C88", Offset = "0x11F5C88", VA = "0x11F5C88")]
	private void OnCmdClick()
	{
	}

	[Token(Token = "0x600A7DA")]
	[Address(RVA = "0x11F60C0", Offset = "0x11F60C0", VA = "0x11F60C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
