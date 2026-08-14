using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002318")]
internal class UIRuleVScrollTableContainerController : UIBaseController
{
	[Token(Token = "0x400DAD6")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleVScrollTableContainerView m_View;

	[Token(Token = "0x400DAD7")]
	[FieldOffset(Offset = "0x2C")]
	private float m_Width;

	[Token(Token = "0x400DAD8")]
	[FieldOffset(Offset = "0x30")]
	public CVScrollTableContainerData Data;

	[Token(Token = "0x600C241")]
	[Address(RVA = "0x1428A64", Offset = "0x1428A64", VA = "0x1428A64")]
	public UIRuleVScrollTableContainerController()
	{
	}

	[Token(Token = "0x600C242")]
	[Address(RVA = "0x1428AE8", Offset = "0x1428AE8", VA = "0x1428AE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C243")]
	[Address(RVA = "0x1428B90", Offset = "0x1428B90", VA = "0x1428B90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C244")]
	[Address(RVA = "0x1428C4C", Offset = "0x1428C4C", VA = "0x1428C4C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C245")]
	[Address(RVA = "0x1428CB0", Offset = "0x1428CB0", VA = "0x1428CB0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C246")]
	[Address(RVA = "0x1428D14", Offset = "0x1428D14", VA = "0x1428D14", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C247")]
	[Address(RVA = "0x1428D78", Offset = "0x1428D78", VA = "0x1428D78")]
	public void SetViewData(CVScrollTableContainerData data, float width)
	{
	}

	[Token(Token = "0x600C248")]
	[Address(RVA = "0x14292A0", Offset = "0x14292A0", VA = "0x14292A0")]
	private void BuildChildComponent(Transform container, IModeEditComponentData componentData, bool isLastOne)
	{
	}

	[Token(Token = "0x600C249")]
	[Address(RVA = "0x142968C", Offset = "0x142968C", VA = "0x142968C")]
	private void Reposition()
	{
	}

	[Token(Token = "0x600C24A")]
	[Address(RVA = "0x1429720", Offset = "0x1429720", VA = "0x1429720")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C24B")]
	[Address(RVA = "0x1429728", Offset = "0x1429728", VA = "0x1429728")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C24C")]
	[Address(RVA = "0x1429730", Offset = "0x1429730", VA = "0x1429730")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C24D")]
	[Address(RVA = "0x1429738", Offset = "0x1429738", VA = "0x1429738")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
