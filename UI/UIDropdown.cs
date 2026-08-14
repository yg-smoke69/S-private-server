using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200413B")]
public class UIDropdown : MonoBehaviour
{
	[Token(Token = "0x200413C")]
	protected internal class UIDropdownItem : MonoBehaviour
	{
		[Token(Token = "0x401B62D")]
		[FieldOffset(Offset = "0xC")]
		public UILabel Label;

		[Token(Token = "0x401B62E")]
		[FieldOffset(Offset = "0x10")]
		public UIToggle Toggle;

		[Token(Token = "0x601AA7D")]
		[Address(RVA = "0x1473774", Offset = "0x1473774", VA = "0x1473774")]
		public UIDropdownItem()
		{
		}
	}

	[Token(Token = "0x200413D")]
	private sealed class _003CShow_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B62F")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x401B630")]
		[FieldOffset(Offset = "0xC")]
		internal UIDropdown _0024this;

		[Token(Token = "0x601AA7E")]
		[Address(RVA = "0x1473150", Offset = "0x1473150", VA = "0x1473150")]
		public _003CShow_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601AA7F")]
		[Address(RVA = "0x1473724", Offset = "0x1473724", VA = "0x1473724")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401B61F")]
	[FieldOffset(Offset = "0xC")]
	public Action<int> onValueChanged;

	[Token(Token = "0x401B620")]
	[FieldOffset(Offset = "0x10")]
	private UILabel m_CaptionLabel;

	[Token(Token = "0x401B621")]
	[FieldOffset(Offset = "0x14")]
	private UIButton m_Button;

	[Token(Token = "0x401B622")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_ListRoot;

	[Token(Token = "0x401B623")]
	[FieldOffset(Offset = "0x1C")]
	private UIButton m_Block;

	[Token(Token = "0x401B624")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_ItemContent;

	[Token(Token = "0x401B625")]
	[FieldOffset(Offset = "0x24")]
	private GameObject m_ItemTemplate;

	[Token(Token = "0x401B626")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_ItemLabel;

	[Token(Token = "0x401B627")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Value;

	[Token(Token = "0x401B628")]
	[FieldOffset(Offset = "0x30")]
	private bool m_ValidTemplate;

	[Token(Token = "0x401B629")]
	[FieldOffset(Offset = "0x31")]
	private bool m_InitFinished;

	[Token(Token = "0x401B62A")]
	[FieldOffset(Offset = "0x32")]
	private bool m_IsExpand;

	[Token(Token = "0x401B62B")]
	[FieldOffset(Offset = "0x34")]
	private List<string> m_Options;

	[Token(Token = "0x401B62C")]
	[FieldOffset(Offset = "0x38")]
	private List<UIDropdownItem> m_Items;

	[Token(Token = "0x17001D5C")]
	public int Value
	{
		[Token(Token = "0x601AA72")]
		[Address(RVA = "0x1472668", Offset = "0x1472668", VA = "0x1472668")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601AA73")]
		[Address(RVA = "0x1472670", Offset = "0x1472670", VA = "0x1472670")]
		set
		{
		}
	}

	[Token(Token = "0x601AA71")]
	[Address(RVA = "0x14725A8", Offset = "0x14725A8", VA = "0x14725A8")]
	public UIDropdown()
	{
	}

	[Token(Token = "0x601AA74")]
	[Address(RVA = "0x14728CC", Offset = "0x14728CC", VA = "0x14728CC")]
	public void SetOpentions(List<string> options)
	{
	}

	[Token(Token = "0x601AA75")]
	[Address(RVA = "0x1472ED0", Offset = "0x1472ED0", VA = "0x1472ED0")]
	public void Show()
	{
	}

	[Token(Token = "0x601AA76")]
	[Address(RVA = "0x1473158", Offset = "0x1473158", VA = "0x1473158")]
	public void Hide()
	{
	}

	[Token(Token = "0x601AA77")]
	[Address(RVA = "0x1473190", Offset = "0x1473190", VA = "0x1473190")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AA78")]
	[Address(RVA = "0x1473408", Offset = "0x1473408", VA = "0x1473408")]
	private void OnClickButton()
	{
	}

	[Token(Token = "0x601AA79")]
	[Address(RVA = "0x14727A4", Offset = "0x14727A4", VA = "0x14727A4")]
	private void RefreshShowValue()
	{
	}

	[Token(Token = "0x601AA7A")]
	[Address(RVA = "0x1473194", Offset = "0x1473194", VA = "0x1473194")]
	private void Init()
	{
	}

	[Token(Token = "0x601AA7B")]
	[Address(RVA = "0x147341C", Offset = "0x147341C", VA = "0x147341C")]
	private void SetupTemplate()
	{
	}

	[Token(Token = "0x601AA7C")]
	[Address(RVA = "0x1472988", Offset = "0x1472988", VA = "0x1472988")]
	private void InitDropdownItems()
	{
	}
}
