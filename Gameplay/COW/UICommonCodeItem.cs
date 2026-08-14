using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002579")]
internal class UICommonCodeItem : MonoBehaviour
{
	[Token(Token = "0x200257A")]
	private sealed class _003CSetUIData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E7EC")]
		[FieldOffset(Offset = "0x8")]
		internal Action<object> callback;

		[Token(Token = "0x400E7ED")]
		[FieldOffset(Offset = "0xC")]
		internal UICommonCodeItem _0024this;

		[Token(Token = "0x600DB1A")]
		[Address(RVA = "0x2CDDDB0", Offset = "0x2CDDDB0", VA = "0x2CDDDB0")]
		public _003CSetUIData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DB1B")]
		[Address(RVA = "0x2CDDE3C", Offset = "0x2CDDE3C", VA = "0x2CDDE3C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E7E0")]
	[FieldOffset(Offset = "0xC")]
	public UIToggleButton Toggle;

	[Token(Token = "0x400E7E1")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Code;

	[Token(Token = "0x400E7E2")]
	[FieldOffset(Offset = "0x14")]
	public UISprite IconSprite;

	[Token(Token = "0x400E7E3")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BgSprite;

	[Token(Token = "0x400E7E4")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite GreenSprite;

	[Token(Token = "0x400E7E5")]
	[FieldOffset(Offset = "0x20")]
	private int m_Index;

	[Token(Token = "0x400E7E6")]
	[FieldOffset(Offset = "0x0")]
	public static int INPUT_DELETE_INDEX;

	[Token(Token = "0x400E7E7")]
	[FieldOffset(Offset = "0x4")]
	public static int INPUT_ZERO_INDEX;

	[Token(Token = "0x400E7E8")]
	[FieldOffset(Offset = "0x8")]
	public static int INPUT_CONFIRM_INDEX;

	[Token(Token = "0x400E7E9")]
	private const uint CODE_BG_COLOR = 3705265151u;

	[Token(Token = "0x400E7EA")]
	private const uint ICON_BG_COLOR = 4290380031u;

	[Token(Token = "0x400E7EB")]
	private const uint ICON_BG_COLOR_DISABLE = 2456420607u;

	[Token(Token = "0x600DB15")]
	[Address(RVA = "0x2CDDDA8", Offset = "0x2CDDDA8", VA = "0x2CDDDA8")]
	public UICommonCodeItem()
	{
	}

	[Token(Token = "0x600DB16")]
	[Address(RVA = "0x2CDB788", Offset = "0x2CDB788", VA = "0x2CDB788")]
	public void SetUIData(int index, [Optional] Action<object> callback)
	{
	}

	[Token(Token = "0x600DB17")]
	[Address(RVA = "0x2CDCC0C", Offset = "0x2CDCC0C", VA = "0x2CDCC0C")]
	public static string GetInputCodeString(int index)
	{
		return null;
	}

	[Token(Token = "0x600DB18")]
	[Address(RVA = "0x2CDD07C", Offset = "0x2CDD07C", VA = "0x2CDD07C")]
	public void ButtonColorHL(bool v)
	{
	}
}
