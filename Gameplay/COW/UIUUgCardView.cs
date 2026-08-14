using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D53")]
public class UIUUgCardView : MonoBehaviour
{
	[Token(Token = "0x4011647")]
	[FieldOffset(Offset = "0xC")]
	public UISprite cardsprite;

	[Token(Token = "0x4011648")]
	[FieldOffset(Offset = "0x10")]
	public UILabel cardcount;

	[Token(Token = "0x4011649")]
	[FieldOffset(Offset = "0x14")]
	public UIButton cardbtn;

	[Token(Token = "0x401164A")]
	[FieldOffset(Offset = "0x18")]
	private CSSharedItemData ItemData;

	[Token(Token = "0x401164B")]
	[FieldOffset(Offset = "0x1C")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x6012F77")]
	[Address(RVA = "0xF4BAE0", Offset = "0xF4BAE0", VA = "0xF4BAE0")]
	public UIUUgCardView()
	{
	}

	[Token(Token = "0x6012F78")]
	[Address(RVA = "0xF4BAE8", Offset = "0xF4BAE8", VA = "0xF4BAE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012F79")]
	[Address(RVA = "0xF44DAC", Offset = "0xF44DAC", VA = "0xF44DAC")]
	public void UpdateView(uint id)
	{
	}

	[Token(Token = "0x6012F7A")]
	[Address(RVA = "0xF4C2D0", Offset = "0xF4C2D0", VA = "0xF4C2D0")]
	private void OnBtnClick()
	{
	}
}
