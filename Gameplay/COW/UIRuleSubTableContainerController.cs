using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002310")]
internal class UIRuleSubTableContainerController : UIRuleTableContainerController
{
	[Token(Token = "0x400DAAF")]
	[FieldOffset(Offset = "0x5C")]
	private UIRuleSubTableContainerView m_SubView;

	[Token(Token = "0x400DAB0")]
	[FieldOffset(Offset = "0x60")]
	public CSubTableContainerData SubData;

	[Token(Token = "0x600C1E7")]
	[Address(RVA = "0x14210DC", Offset = "0x14210DC", VA = "0x14210DC")]
	public UIRuleSubTableContainerController()
	{
	}

	[Token(Token = "0x600C1E8")]
	[Address(RVA = "0x1421164", Offset = "0x1421164", VA = "0x1421164")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C1E9")]
	[Address(RVA = "0x142120C", Offset = "0x142120C", VA = "0x142120C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C1EA")]
	[Address(RVA = "0x14213F8", Offset = "0x14213F8", VA = "0x14213F8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C1EB")]
	[Address(RVA = "0x14214BC", Offset = "0x14214BC", VA = "0x14214BC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C1EC")]
	[Address(RVA = "0x1421580", Offset = "0x1421580", VA = "0x1421580", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C1ED")]
	[Address(RVA = "0x1421664", Offset = "0x1421664", VA = "0x1421664")]
	public void SetViewData(CSubTableContainerData data, float width, float height)
	{
	}

	[Token(Token = "0x600C1EE")]
	[Address(RVA = "0x14220D8", Offset = "0x14220D8", VA = "0x14220D8", Slot = "31")]
	protected override UIBaseController BuildChildComponent(Transform container, IModeEditComponentData data)
	{
		return null;
	}

	[Token(Token = "0x600C1EF")]
	[Address(RVA = "0x1422AE8", Offset = "0x1422AE8", VA = "0x1422AE8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C1F0")]
	[Address(RVA = "0x1422AEC", Offset = "0x1422AEC", VA = "0x1422AEC")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C1F1")]
	[Address(RVA = "0x1422AF0", Offset = "0x1422AF0", VA = "0x1422AF0")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C1F2")]
	[Address(RVA = "0x1422AF4", Offset = "0x1422AF4", VA = "0x1422AF4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600C1F3")]
	[Address(RVA = "0x1422AF8", Offset = "0x1422AF8", VA = "0x1422AF8")]
	public UIBaseController _003C_003EiFixBaseProxy_BuildChildComponent(Transform P0, IModeEditComponentData P1)
	{
		return null;
	}
}
