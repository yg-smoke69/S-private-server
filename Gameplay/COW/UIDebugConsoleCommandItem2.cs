using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002099")]
public class UIDebugConsoleCommandItem2 : UIBaseController, _Attribute
{
	[Token(Token = "0x200209A")]
	public class Data
	{
		[Token(Token = "0x400CC39")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400CC3A")]
		[FieldOffset(Offset = "0xC")]
		public string cmd;

		[Token(Token = "0x400CC3B")]
		[FieldOffset(Offset = "0x10")]
		public string arg1Name;

		[Token(Token = "0x400CC3C")]
		[FieldOffset(Offset = "0x14")]
		public string arg2Name;

		[Token(Token = "0x400CC3D")]
		[FieldOffset(Offset = "0x18")]
		public string arg1Value;

		[Token(Token = "0x400CC3E")]
		[FieldOffset(Offset = "0x1C")]
		public string arg2Value;

		[Token(Token = "0x400CC3F")]
		[FieldOffset(Offset = "0x20")]
		public string arg1ValueChangeCmd;

		[Token(Token = "0x400CC40")]
		[FieldOffset(Offset = "0x24")]
		public string arg2ValueChangeCmd;

		[Token(Token = "0x600A7F8")]
		[Address(RVA = "0x11F816C", Offset = "0x11F816C", VA = "0x11F816C")]
		public Data()
		{
		}
	}

	[Token(Token = "0x200209B")]
	public delegate void OnRunCmd(string cmd, string arg1, string arg2);

	[Token(Token = "0x400CC36")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugConsoleCommandItem2View m_View;

	[Token(Token = "0x400CC37")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_Data;

	[Token(Token = "0x400CC38")]
	[FieldOffset(Offset = "0x30")]
	public OnRunCmd OnRunCmdHandler;

	[Token(Token = "0x600A7EE")]
	[Address(RVA = "0x11F7110", Offset = "0x11F7110", VA = "0x11F7110")]
	public UIDebugConsoleCommandItem2()
	{
	}

	[Token(Token = "0x600A7EF")]
	[Address(RVA = "0x11F7194", Offset = "0x11F7194", VA = "0x11F7194")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A7F0")]
	[Address(RVA = "0x11F723C", Offset = "0x11F723C", VA = "0x11F723C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A7F1")]
	[Address(RVA = "0x11F7480", Offset = "0x11F7480", VA = "0x11F7480", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600A7F2")]
	[Address(RVA = "0x11F7720", Offset = "0x11F7720", VA = "0x11F7720", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600A7F3")]
	[Address(RVA = "0x11F7848", Offset = "0x11F7848", VA = "0x11F7848", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600A7F4")]
	[Address(RVA = "0x11F78D8", Offset = "0x11F78D8", VA = "0x11F78D8")]
	private void OnCmdClick()
	{
	}

	[Token(Token = "0x600A7F5")]
	[Address(RVA = "0x11F7E04", Offset = "0x11F7E04", VA = "0x11F7E04")]
	private void OnArg1Change()
	{
	}

	[Token(Token = "0x600A7F6")]
	[Address(RVA = "0x11F7FB4", Offset = "0x11F7FB4", VA = "0x11F7FB4")]
	private void OnArg2Change()
	{
	}

	[Token(Token = "0x600A7F7")]
	[Address(RVA = "0x11F8164", Offset = "0x11F8164", VA = "0x11F8164")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
