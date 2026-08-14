using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200243F")]
public class UIUGCSelectSpriteNamePopupWindowController : UIPopupWindowController
{
	[Token(Token = "0x2002440")]
	protected internal class SpriteItem : MonoBehaviour
	{
		[Token(Token = "0x400E171")]
		[FieldOffset(Offset = "0xC")]
		public UISprite Image;

		[Token(Token = "0x400E172")]
		[FieldOffset(Offset = "0x10")]
		public UIToggle Toggle;

		[Token(Token = "0x400E173")]
		[FieldOffset(Offset = "0x14")]
		private int _003CIndex_003Ek__BackingField;

		[Token(Token = "0x17001117")]
		public int Index
		{
			[Token(Token = "0x600CDA8")]
			[Address(RVA = "0xF3F688", Offset = "0xF3F688", VA = "0xF3F688")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600CDA9")]
			[Address(RVA = "0xF3F698", Offset = "0xF3F698", VA = "0xF3F698")]
			private set
			{
			}
		}

		[Token(Token = "0x600CDA7")]
		[Address(RVA = "0xF3F690", Offset = "0xF3F690", VA = "0xF3F690")]
		public SpriteItem()
		{
		}

		[Token(Token = "0x600CDAA")]
		[Address(RVA = "0xF3F2C8", Offset = "0xF3F2C8", VA = "0xF3F2C8")]
		public void SetViewData(string data, int data_index)
		{
		}

		[Token(Token = "0x600CDAB")]
		[Address(RVA = "0xF3F430", Offset = "0xF3F430", VA = "0xF3F430")]
		public void SetItemSelectState(bool selected)
		{
		}
	}

	[Token(Token = "0x2002441")]
	private sealed class _003CSetData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E174")]
		[FieldOffset(Offset = "0x8")]
		internal string currentSpriteName;

		[Token(Token = "0x600CDAC")]
		[Address(RVA = "0xF3ECB0", Offset = "0xF3ECB0", VA = "0xF3ECB0")]
		public _003CSetData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CDAD")]
		[Address(RVA = "0xF3F5B4", Offset = "0xF3F5B4", VA = "0xF3F5B4")]
		internal bool _003C_003Em__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002442")]
	private sealed class _003CSetData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E175")]
		[FieldOffset(Offset = "0x8")]
		internal SpriteItem item;

		[Token(Token = "0x400E176")]
		[FieldOffset(Offset = "0xC")]
		internal UIUGCSelectSpriteNamePopupWindowController _0024this;

		[Token(Token = "0x600CDAE")]
		[Address(RVA = "0xF3F2C0", Offset = "0xF3F2C0", VA = "0xF3F2C0")]
		public _003CSetData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600CDAF")]
		[Address(RVA = "0xF3F644", Offset = "0xF3F644", VA = "0xF3F644")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400E16B")]
	[FieldOffset(Offset = "0x48")]
	public Action<int> onSelected;

	[Token(Token = "0x400E16C")]
	[FieldOffset(Offset = "0x4C")]
	public Action onClosed;

	[Token(Token = "0x400E16D")]
	[FieldOffset(Offset = "0x50")]
	private UIUGCSelectSpriteNamePopupWindowView m_View;

	[Token(Token = "0x400E16E")]
	[FieldOffset(Offset = "0x54")]
	private List<string> m_SpriteNames;

	[Token(Token = "0x400E16F")]
	[FieldOffset(Offset = "0x58")]
	private int m_SelectedIndex;

	[Token(Token = "0x400E170")]
	[FieldOffset(Offset = "0x5C")]
	private List<SpriteItem> m_Items;

	[Token(Token = "0x17001116")]
	public int CurrentIndex
	{
		[Token(Token = "0x600CD9D")]
		[Address(RVA = "0xF3E5B4", Offset = "0xF3E5B4", VA = "0xF3E5B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600CD9E")]
		[Address(RVA = "0xF3E60C", Offset = "0xF3E60C", VA = "0xF3E60C")]
		protected set
		{
		}
	}

	[Token(Token = "0x600CD9B")]
	[Address(RVA = "0xF3E484", Offset = "0xF3E484", VA = "0xF3E484")]
	public UIUGCSelectSpriteNamePopupWindowController()
	{
	}

	[Token(Token = "0x600CD9C")]
	[Address(RVA = "0xF3E510", Offset = "0xF3E510", VA = "0xF3E510")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CD9F")]
	[Address(RVA = "0xF3E6E0", Offset = "0xF3E6E0", VA = "0xF3E6E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CDA0")]
	[Address(RVA = "0xF3EA94", Offset = "0xF3EA94", VA = "0xF3EA94", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600CDA1")]
	[Address(RVA = "0xF3EB0C", Offset = "0xF3EB0C", VA = "0xF3EB0C")]
	public void SetData(string currentSpriteName, List<string> spriteNames)
	{
	}

	[Token(Token = "0x600CDA2")]
	[Address(RVA = "0xF3ECB8", Offset = "0xF3ECB8", VA = "0xF3ECB8")]
	public void SetData(int currentSpriteNameIndex, List<string> spriteNames)
	{
	}

	[Token(Token = "0x600CDA3")]
	[Address(RVA = "0xF3E844", Offset = "0xF3E844", VA = "0xF3E844")]
	private void SetupTemplate()
	{
	}

	[Token(Token = "0x600CDA4")]
	[Address(RVA = "0xF3F538", Offset = "0xF3F538", VA = "0xF3F538")]
	private void OnSelectItem(int index)
	{
	}

	[Token(Token = "0x600CDA5")]
	[Address(RVA = "0xF3F5A4", Offset = "0xF3F5A4", VA = "0xF3F5A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CDA6")]
	[Address(RVA = "0xF3F5AC", Offset = "0xF3F5AC", VA = "0xF3F5AC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
