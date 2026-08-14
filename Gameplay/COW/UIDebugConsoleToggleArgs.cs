using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020AA")]
public class UIDebugConsoleToggleArgs : UIBaseController, _Attribute
{
	[Token(Token = "0x20020AB")]
	public class Data
	{
		[Token(Token = "0x400CCB0")]
		[FieldOffset(Offset = "0x8")]
		public int index;

		[Token(Token = "0x400CCB1")]
		[FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x400CCB2")]
		[FieldOffset(Offset = "0x10")]
		public string cmd;

		[Token(Token = "0x400CCB3")]
		[FieldOffset(Offset = "0x14")]
		public bool defaultValue;

		[Token(Token = "0x400CCB4")]
		[FieldOffset(Offset = "0x18")]
		public string[] argLabels;

		[Token(Token = "0x400CCB5")]
		[FieldOffset(Offset = "0x1C")]
		public string[] argValues;

		[Token(Token = "0x600A87F")]
		[Address(RVA = "0x2D7C31C", Offset = "0x2D7C31C", VA = "0x2D7C31C")]
		public Data()
		{
		}
	}

	[Token(Token = "0x20020AC")]
	public delegate void OnRunCmd(string cmd, int index, bool togglevalue, object[] args);

	[Token(Token = "0x400CCAA")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugConsoleToggleArgsView m_View;

	[Token(Token = "0x400CCAB")]
	[FieldOffset(Offset = "0x2C")]
	private Data m_Data;

	[Token(Token = "0x400CCAC")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_ArgInputGameObject;

	[Token(Token = "0x400CCAD")]
	private const float ARG_ITEM_OFFSET_Y = 65f;

	[Token(Token = "0x400CCAE")]
	private const float TOGGLE_OFFSET_X = -465f;

	[Token(Token = "0x400CCAF")]
	[FieldOffset(Offset = "0x34")]
	public OnRunCmd OnRunCmdHandler;

	[Token(Token = "0x600A875")]
	[Address(RVA = "0x2D7ACF8", Offset = "0x2D7ACF8", VA = "0x2D7ACF8")]
	public UIDebugConsoleToggleArgs()
	{
	}

	[Token(Token = "0x600A876")]
	[Address(RVA = "0x2D7ADB0", Offset = "0x2D7ADB0", VA = "0x2D7ADB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A877")]
	[Address(RVA = "0x2D7AE58", Offset = "0x2D7AE58", VA = "0x2D7AE58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A878")]
	[Address(RVA = "0x2D7B00C", Offset = "0x2D7B00C", VA = "0x2D7B00C", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600A879")]
	[Address(RVA = "0x2D7B950", Offset = "0x2D7B950", VA = "0x2D7B950")]
	private void RefreshArgsValues()
	{
	}

	[Token(Token = "0x600A87A")]
	[Address(RVA = "0x2D7B1CC", Offset = "0x2D7B1CC", VA = "0x2D7B1CC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A87B")]
	[Address(RVA = "0x2D7C0F0", Offset = "0x2D7C0F0", VA = "0x2D7C0F0", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600A87C")]
	[Address(RVA = "0x2D7C218", Offset = "0x2D7C218", VA = "0x2D7C218", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600A87D")]
	[Address(RVA = "0x2D7C2A8", Offset = "0x2D7C2A8", VA = "0x2D7C2A8")]
	public void OnToggleValueChange()
	{
	}

	[Token(Token = "0x600A87E")]
	[Address(RVA = "0x2D7C314", Offset = "0x2D7C314", VA = "0x2D7C314")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
