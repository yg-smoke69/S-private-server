using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A94")]
public class SimpleTabView : MonoBehaviour
{
	[Token(Token = "0x2003A95")]
	private sealed class _003CSetData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4018E99")]
		[FieldOffset(Offset = "0x8")]
		internal Action<bool> onChange;

		[Token(Token = "0x4018E9A")]
		[FieldOffset(Offset = "0xC")]
		internal SimpleTabView _0024this;

		[Token(Token = "0x6017368")]
		[Address(RVA = "0x20E6E60", Offset = "0x20E6E60", VA = "0x20E6E60")]
		public _003CSetData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6017369")]
		[Address(RVA = "0x20E7080", Offset = "0x20E7080", VA = "0x20E7080")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x601736A")]
		[Address(RVA = "0x20E7134", Offset = "0x20E7134", VA = "0x20E7134")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x4018E94")]
	[FieldOffset(Offset = "0xC")]
	private UILabel m_EnableTitleLabel;

	[Token(Token = "0x4018E95")]
	[FieldOffset(Offset = "0x10")]
	private UILabel m_DisableTitleLabel;

	[Token(Token = "0x4018E96")]
	[FieldOffset(Offset = "0x14")]
	private UIToggle m_Toggle;

	[Token(Token = "0x4018E97")]
	[FieldOffset(Offset = "0x18")]
	private UIGrid m_SubContentGrid;

	[Token(Token = "0x4018E98")]
	[FieldOffset(Offset = "0x1C")]
	private Callback m_OnChange;

	[Token(Token = "0x170016D6")]
	public UIGrid SubContentGrid
	{
		[Token(Token = "0x6017364")]
		[Address(RVA = "0x20E6AE8", Offset = "0x20E6AE8", VA = "0x20E6AE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017363")]
	[Address(RVA = "0x20E6AE0", Offset = "0x20E6AE0", VA = "0x20E6AE0")]
	public SimpleTabView()
	{
	}

	[Token(Token = "0x6017365")]
	[Address(RVA = "0x20E6B40", Offset = "0x20E6B40", VA = "0x20E6B40")]
	public void SetData(string title, Action<bool> onChange)
	{
	}

	[Token(Token = "0x6017366")]
	[Address(RVA = "0x20E6E68", Offset = "0x20E6E68", VA = "0x20E6E68")]
	public void ClearData()
	{
	}

	[Token(Token = "0x6017367")]
	[Address(RVA = "0x20E6F48", Offset = "0x20E6F48", VA = "0x20E6F48")]
	public void SetToggleStatus(bool status)
	{
	}
}
