using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200230C")]
internal class UIRuleSafeZoneSettingV2Controller : UIRuleSlidableNumericSettingController
{
	[Token(Token = "0x400DAA2")]
	[FieldOffset(Offset = "0x3C")]
	private UIRuleSafeZoneSettingV2View m_SafeZoneView;

	[Token(Token = "0x400DAA3")]
	[FieldOffset(Offset = "0x40")]
	public CSafeZoneData SafeZoneData;

	[Token(Token = "0x600C1BA")]
	[Address(RVA = "0x2BFE56C", Offset = "0x2BFE56C", VA = "0x2BFE56C")]
	public UIRuleSafeZoneSettingV2Controller()
	{
	}

	[Token(Token = "0x600C1BB")]
	[Address(RVA = "0x2BFE5F4", Offset = "0x2BFE5F4", VA = "0x2BFE5F4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C1BC")]
	[Address(RVA = "0x2BFE69C", Offset = "0x2BFE69C", VA = "0x2BFE69C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C1BD")]
	[Address(RVA = "0x2BFE990", Offset = "0x2BFE990", VA = "0x2BFE990", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C1BE")]
	[Address(RVA = "0x2BFEA54", Offset = "0x2BFEA54", VA = "0x2BFEA54", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C1BF")]
	[Address(RVA = "0x2BFEB18", Offset = "0x2BFEB18", VA = "0x2BFEB18", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C1C0")]
	[Address(RVA = "0x2BFECA8", Offset = "0x2BFECA8", VA = "0x2BFECA8")]
	public void SetViewData(CSafeZoneData data, float width)
	{
	}

	[Token(Token = "0x600C1C1")]
	[Address(RVA = "0x2BFF6C8", Offset = "0x2BFF6C8", VA = "0x2BFF6C8", Slot = "31")]
	protected override void OnSliderChanged()
	{
	}

	[Token(Token = "0x600C1C2")]
	[Address(RVA = "0x2BFF494", Offset = "0x2BFF494", VA = "0x2BFF494")]
	public void RefreshSceneObject()
	{
	}

	[Token(Token = "0x600C1C3")]
	[Address(RVA = "0x2BFFB6C", Offset = "0x2BFFB6C", VA = "0x2BFFB6C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C1C4")]
	[Address(RVA = "0x2BFFB70", Offset = "0x2BFFB70", VA = "0x2BFFB70")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C1C5")]
	[Address(RVA = "0x2BFFB74", Offset = "0x2BFFB74", VA = "0x2BFFB74")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C1C6")]
	[Address(RVA = "0x2BFFB78", Offset = "0x2BFFB78", VA = "0x2BFFB78")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600C1C7")]
	[Address(RVA = "0x2BFFB7C", Offset = "0x2BFFB7C", VA = "0x2BFFB7C")]
	public void _003C_003EiFixBaseProxy_OnSliderChanged()
	{
	}
}
