using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004158")]
public class UIMenuItem : MonoBehaviour
{
	[Token(Token = "0x2004159")]
	private sealed class _003CSetClickCallback_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B6B2")]
		[FieldOffset(Offset = "0x8")]
		internal Action<UIMenuItem> onClick;

		[Token(Token = "0x401B6B3")]
		[FieldOffset(Offset = "0xC")]
		internal UIMenuItem _0024this;

		[Token(Token = "0x601AB1F")]
		[Address(RVA = "0x2CA7B20", Offset = "0x2CA7B20", VA = "0x2CA7B20")]
		public _003CSetClickCallback_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601AB20")]
		[Address(RVA = "0x2CA7B28", Offset = "0x2CA7B28", VA = "0x2CA7B28")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401B6A9")]
	[FieldOffset(Offset = "0xC")]
	public UILabel[] titles;

	[Token(Token = "0x401B6AA")]
	[FieldOffset(Offset = "0x10")]
	public GameObject select;

	[Token(Token = "0x401B6AB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject unSelect;

	[Token(Token = "0x401B6AC")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget size;

	[Token(Token = "0x401B6AD")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton button;

	[Token(Token = "0x401B6AE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] exObjects;

	[Token(Token = "0x401B6AF")]
	[FieldOffset(Offset = "0x24")]
	private bool m_Selected;

	[Token(Token = "0x401B6B0")]
	[FieldOffset(Offset = "0x28")]
	private UIMenuItem m_ParentMenu;

	[Token(Token = "0x401B6B1")]
	[FieldOffset(Offset = "0x2C")]
	private UIMenuItemData m_MenuData;

	[Token(Token = "0x601AB13")]
	[Address(RVA = "0x2CA7AF4", Offset = "0x2CA7AF4", VA = "0x2CA7AF4")]
	public UIMenuItem()
	{
	}

	[Token(Token = "0x601AB14")]
	[Address(RVA = "0x2CA7AFC", Offset = "0x2CA7AFC", VA = "0x2CA7AFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AB15")]
	[Address(RVA = "0x2CA7B00", Offset = "0x2CA7B00", VA = "0x2CA7B00")]
	private void Start()
	{
	}

	[Token(Token = "0x601AB16")]
	[Address(RVA = "0x2CA7B04", Offset = "0x2CA7B04", VA = "0x2CA7B04")]
	private void Update()
	{
	}

	[Token(Token = "0x601AB17")]
	[Address(RVA = "0x2CA6C14", Offset = "0x2CA6C14", VA = "0x2CA6C14")]
	public void SetMenuData(UIMenuItemData menuData)
	{
	}

	[Token(Token = "0x601AB18")]
	[Address(RVA = "0x2CA79C0", Offset = "0x2CA79C0", VA = "0x2CA79C0")]
	public bool IsMenu(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x601AB19")]
	[Address(RVA = "0x2CA774C", Offset = "0x2CA774C", VA = "0x2CA774C")]
	public void SetSelected(bool value)
	{
	}

	[Token(Token = "0x601AB1A")]
	[Address(RVA = "0x2CA6844", Offset = "0x2CA6844", VA = "0x2CA6844")]
	public void DirectlyRunSelectCallback()
	{
	}

	[Token(Token = "0x601AB1B")]
	[Address(RVA = "0x2CA7B08", Offset = "0x2CA7B08", VA = "0x2CA7B08")]
	public bool Selected()
	{
		return default(bool);
	}

	[Token(Token = "0x601AB1C")]
	[Address(RVA = "0x2CA7B10", Offset = "0x2CA7B10", VA = "0x2CA7B10")]
	public void SetParentMenu(UIMenuItem parentMenu)
	{
	}

	[Token(Token = "0x601AB1D")]
	[Address(RVA = "0x2CA7B18", Offset = "0x2CA7B18", VA = "0x2CA7B18")]
	public UIMenuItem ParentMenu()
	{
		return null;
	}

	[Token(Token = "0x601AB1E")]
	[Address(RVA = "0x2CA6AEC", Offset = "0x2CA6AEC", VA = "0x2CA6AEC")]
	public void SetClickCallback(Action<UIMenuItem> onClick)
	{
	}
}
