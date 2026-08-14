using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002878")]
public class UIHudTestRecipeWardrobeBtn : MonoBehaviour
{
	[Token(Token = "0x400F96F")]
	[FieldOffset(Offset = "0xC")]
	public int WardrobeType;

	[Token(Token = "0x400F970")]
	[FieldOffset(Offset = "0x10")]
	public Action<int> m_ClickCB;

	[Token(Token = "0x600FDC8")]
	[Address(RVA = "0x1579DF8", Offset = "0x1579DF8", VA = "0x1579DF8")]
	public UIHudTestRecipeWardrobeBtn()
	{
	}

	[Token(Token = "0x600FDC9")]
	[Address(RVA = "0x1579E00", Offset = "0x1579E00", VA = "0x1579E00")]
	public void SetWardrobeType(int wt, Action<int> cb)
	{
	}

	[Token(Token = "0x600FDCA")]
	[Address(RVA = "0x157A00C", Offset = "0x157A00C", VA = "0x157A00C")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600FDCB")]
	[Address(RVA = "0x157A0C4", Offset = "0x157A0C4", VA = "0x157A0C4")]
	private void Destroy()
	{
	}
}
