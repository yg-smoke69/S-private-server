using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002317")]
internal class UIRuleToggleSettingV2Controller : UIBaseController
{
	[Token(Token = "0x400DAD3")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleToggleSettingV2View m_View;

	[Token(Token = "0x400DAD4")]
	[FieldOffset(Offset = "0x2C")]
	public CToggleData Data;

	[Token(Token = "0x400DAD5")]
	[FieldOffset(Offset = "0x30")]
	public UIModeEditGeneralComponentHelper GeneralHelper;

	[Token(Token = "0x600C233")]
	[Address(RVA = "0x1427A7C", Offset = "0x1427A7C", VA = "0x1427A7C")]
	public UIRuleToggleSettingV2Controller()
	{
	}

	[Token(Token = "0x600C234")]
	[Address(RVA = "0x1427B00", Offset = "0x1427B00", VA = "0x1427B00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C235")]
	[Address(RVA = "0x1427BA8", Offset = "0x1427BA8", VA = "0x1427BA8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C236")]
	[Address(RVA = "0x1427C64", Offset = "0x1427C64", VA = "0x1427C64", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C237")]
	[Address(RVA = "0x1427CC8", Offset = "0x1427CC8", VA = "0x1427CC8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C238")]
	[Address(RVA = "0x1427D2C", Offset = "0x1427D2C", VA = "0x1427D2C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C239")]
	[Address(RVA = "0x142281C", Offset = "0x142281C", VA = "0x142281C")]
	public void SetViewData(CToggleData data, float width)
	{
	}

	[Token(Token = "0x600C23A")]
	[Address(RVA = "0x1427FDC", Offset = "0x1427FDC", VA = "0x1427FDC")]
	private void OnToggle(UIToggleButton btn)
	{
	}

	[Token(Token = "0x600C23B")]
	[Address(RVA = "0x14280D8", Offset = "0x14280D8", VA = "0x14280D8")]
	private void SetValue(bool newValue)
	{
	}

	[Token(Token = "0x600C23C")]
	[Address(RVA = "0x1427E5C", Offset = "0x1427E5C", VA = "0x1427E5C")]
	private void OnValueChanged()
	{
	}

	[Token(Token = "0x600C23D")]
	[Address(RVA = "0x14281F4", Offset = "0x14281F4", VA = "0x14281F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C23E")]
	[Address(RVA = "0x14281FC", Offset = "0x14281FC", VA = "0x14281FC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C23F")]
	[Address(RVA = "0x1428204", Offset = "0x1428204", VA = "0x1428204")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C240")]
	[Address(RVA = "0x142820C", Offset = "0x142820C", VA = "0x142820C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
