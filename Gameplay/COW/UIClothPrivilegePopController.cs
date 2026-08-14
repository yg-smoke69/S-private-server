using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002571")]
internal class UIClothPrivilegePopController : UIPopupWindowController
{
	[Token(Token = "0x400E7BE")]
	[FieldOffset(Offset = "0x48")]
	private UIClothPrivilegePopView m_View;

	[Token(Token = "0x400E7BF")]
	private const int BottomBorder = 25;

	[Token(Token = "0x400E7C0")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_ItemId;

	[Token(Token = "0x400E7C1")]
	[FieldOffset(Offset = "0x50")]
	private List<UIClothPrivilegeController> m_UIClothPrivilegeControllers;

	[Token(Token = "0x600DAD7")]
	[Address(RVA = "0x2CD235C", Offset = "0x2CD235C", VA = "0x2CD235C")]
	public UIClothPrivilegePopController()
	{
	}

	[Token(Token = "0x600DAD8")]
	[Address(RVA = "0x2CD23E8", Offset = "0x2CD23E8", VA = "0x2CD23E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DAD9")]
	[Address(RVA = "0x2CD2490", Offset = "0x2CD2490", VA = "0x2CD2490", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DADA")]
	[Address(RVA = "0x2CD2554", Offset = "0x2CD2554", VA = "0x2CD2554", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600DADB")]
	[Address(RVA = "0x2CD2688", Offset = "0x2CD2688", VA = "0x2CD2688")]
	public void SetData(Vector3 pos, uint Id)
	{
	}

	[Token(Token = "0x600DADC")]
	[Address(RVA = "0x2CD2BD8", Offset = "0x2CD2BD8", VA = "0x2CD2BD8")]
	private void SetPos(Vector3 pos, int height)
	{
	}

	[Token(Token = "0x600DADD")]
	[Address(RVA = "0x2CD3218", Offset = "0x2CD3218", VA = "0x2CD3218")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DADE")]
	[Address(RVA = "0x2CD3220", Offset = "0x2CD3220", VA = "0x2CD3220")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
