using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020A7")]
public class UIDebugConsoleToggle : UIBaseController, _Attribute
{
	[Token(Token = "0x20020A8")]
	public class Data
	{
		[Token(Token = "0x400CCA7")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400CCA8")]
		[FieldOffset(Offset = "0xC")]
		public string cmd;

		[Token(Token = "0x400CCA9")]
		[FieldOffset(Offset = "0x10")]
		public bool defaultValue;

		[Token(Token = "0x600A870")]
		[Address(RVA = "0x2D7AC30", Offset = "0x2D7AC30", VA = "0x2D7AC30")]
		public Data()
		{
		}
	}

	[Token(Token = "0x20020A9")]
	public delegate void OnRunCmd(string cmd, bool toggleValue);

	[Token(Token = "0x400CCA4")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugConsoleToggleView m_View;

	[Token(Token = "0x400CCA5")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_Data;

	[Token(Token = "0x400CCA6")]
	[FieldOffset(Offset = "0x30")]
	public OnRunCmd OnRunCmdHandler;

	[Token(Token = "0x600A868")]
	[Address(RVA = "0x2D7A198", Offset = "0x2D7A198", VA = "0x2D7A198")]
	public UIDebugConsoleToggle()
	{
	}

	[Token(Token = "0x600A869")]
	[Address(RVA = "0x2D7A21C", Offset = "0x2D7A21C", VA = "0x2D7A21C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A86A")]
	[Address(RVA = "0x2D7A2C4", Offset = "0x2D7A2C4", VA = "0x2D7A2C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A86B")]
	[Address(RVA = "0x2D7A420", Offset = "0x2D7A420", VA = "0x2D7A420", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600A86C")]
	[Address(RVA = "0x2D7A5D8", Offset = "0x2D7A5D8", VA = "0x2D7A5D8", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600A86D")]
	[Address(RVA = "0x2D7A700", Offset = "0x2D7A700", VA = "0x2D7A700", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600A86E")]
	[Address(RVA = "0x2D7A790", Offset = "0x2D7A790", VA = "0x2D7A790")]
	public void OnToggleValueChange()
	{
	}

	[Token(Token = "0x600A86F")]
	[Address(RVA = "0x2D7AC28", Offset = "0x2D7AC28", VA = "0x2D7AC28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
