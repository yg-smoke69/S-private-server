using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F50")]
public abstract class UIActivityBaseController : UIBaseController
{
	[Token(Token = "0x400C4CD")]
	[FieldOffset(Offset = "0x0")]
	private static Func<UIPanel, int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009AC2")]
	[Address(RVA = "0x2A03FFC", Offset = "0x2A03FFC", VA = "0x2A03FFC")]
	protected UIActivityBaseController()
	{
	}

	[Token(Token = "0x6009AC3")]
	[Address(RVA = "0x2A06800", Offset = "0x2A06800", VA = "0x2A06800", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6009AC4")]
	[Address(RVA = "0x2A062A4", Offset = "0x2A062A4", VA = "0x2A062A4", Slot = "31")]
	public virtual void SetData(object data)
	{
	}

	[Token(Token = "0x6009AC5")]
	[Address(RVA = "0x2A06244", Offset = "0x2A06244", VA = "0x2A06244", Slot = "32")]
	public virtual void SelectItem(uint id)
	{
	}

	[Token(Token = "0x6009AC6")]
	[Address(RVA = "0x2A06C30", Offset = "0x2A06C30", VA = "0x2A06C30", Slot = "33")]
	public virtual void OnPanelDepthChanged()
	{
	}

	[Token(Token = "0x6009AC7")]
	[Address(RVA = "0x2A06C84", Offset = "0x2A06C84", VA = "0x2A06C84", Slot = "34")]
	public virtual void Reload()
	{
	}

	[Token(Token = "0x6009AC8")]
	[Address(RVA = "0x2A06918", Offset = "0x2A06918", VA = "0x2A06918")]
	protected void FixPanelDepth(GameObject target, int baseDepth)
	{
	}

	[Token(Token = "0x6009AC9")]
	[Address(RVA = "0x2A06CD8", Offset = "0x2A06CD8", VA = "0x2A06CD8", Slot = "35")]
	public virtual void OnPopUpWindowListChange(bool isCovered)
	{
	}

	[Token(Token = "0x6009ACA")]
	[Address(RVA = "0x2A06D34", Offset = "0x2A06D34", VA = "0x2A06D34", Slot = "36")]
	public virtual void OnVisibilityChange(bool isVisible)
	{
	}

	[Token(Token = "0x6009ACB")]
	[Address(RVA = "0x2A06D90", Offset = "0x2A06D90", VA = "0x2A06D90")]
	private static int _003CFixPanelDepth_003Em__0(UIPanel e)
	{
		return default(int);
	}

	[Token(Token = "0x6009ACC")]
	[Address(RVA = "0x2A06DBC", Offset = "0x2A06DBC", VA = "0x2A06DBC")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
