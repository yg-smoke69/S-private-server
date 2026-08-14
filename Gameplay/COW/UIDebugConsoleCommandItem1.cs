using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002096")]
public class UIDebugConsoleCommandItem1 : UIBaseController, _Attribute
{
	[Token(Token = "0x2002097")]
	public class Data
	{
		[Token(Token = "0x400CC31")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400CC32")]
		[FieldOffset(Offset = "0xC")]
		public string cmd;

		[Token(Token = "0x400CC33")]
		[FieldOffset(Offset = "0x10")]
		public string argName;

		[Token(Token = "0x400CC34")]
		[FieldOffset(Offset = "0x14")]
		public string argValue;

		[Token(Token = "0x400CC35")]
		[FieldOffset(Offset = "0x18")]
		public string arg1ValueChangeCmd;

		[Token(Token = "0x600A7E9")]
		[Address(RVA = "0x11F6DD8", Offset = "0x11F6DD8", VA = "0x11F6DD8")]
		public Data()
		{
		}
	}

	[Token(Token = "0x2002098")]
	public delegate void OnRunCmd(string cmd, string arg);

	[Token(Token = "0x400CC2E")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugConsoleCommandItem1View m_View;

	[Token(Token = "0x400CC2F")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_Data;

	[Token(Token = "0x400CC30")]
	[FieldOffset(Offset = "0x30")]
	public OnRunCmd OnRunCmdHandler;

	[Token(Token = "0x600A7E0")]
	[Address(RVA = "0x11F611C", Offset = "0x11F611C", VA = "0x11F611C")]
	public UIDebugConsoleCommandItem1()
	{
	}

	[Token(Token = "0x600A7E1")]
	[Address(RVA = "0x11F61A0", Offset = "0x11F61A0", VA = "0x11F61A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A7E2")]
	[Address(RVA = "0x11F6248", Offset = "0x11F6248", VA = "0x11F6248", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A7E3")]
	[Address(RVA = "0x11F6418", Offset = "0x11F6418", VA = "0x11F6418", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600A7E4")]
	[Address(RVA = "0x11F6618", Offset = "0x11F6618", VA = "0x11F6618", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600A7E5")]
	[Address(RVA = "0x11F6740", Offset = "0x11F6740", VA = "0x11F6740", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600A7E6")]
	[Address(RVA = "0x11F67D0", Offset = "0x11F67D0", VA = "0x11F67D0")]
	private void OnCmdClick()
	{
	}

	[Token(Token = "0x600A7E7")]
	[Address(RVA = "0x11F6C68", Offset = "0x11F6C68", VA = "0x11F6C68")]
	private void OnArg1Change()
	{
	}

	[Token(Token = "0x600A7E8")]
	[Address(RVA = "0x11F6DD0", Offset = "0x11F6DD0", VA = "0x11F6DD0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
