using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200230D")]
internal class UIRuleSlidableNumericSettingController : UIBaseController
{
	[Token(Token = "0x400DAA4")]
	[FieldOffset(Offset = "0x28")]
	protected UIRuleSlidableNumericSettingView m_View;

	[Token(Token = "0x400DAA5")]
	[FieldOffset(Offset = "0x2C")]
	public CRangeData Data;

	[Token(Token = "0x400DAA6")]
	[FieldOffset(Offset = "0x30")]
	public UIModeEditGeneralComponentHelper GeneralHelper;

	[Token(Token = "0x400DAA7")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsSliderChangedInternally;

	[Token(Token = "0x400DAA8")]
	[FieldOffset(Offset = "0x38")]
	private string unitText;

	[Token(Token = "0x600C1C8")]
	[Address(RVA = "0x2BFE570", Offset = "0x2BFE570", VA = "0x2BFE570")]
	public UIRuleSlidableNumericSettingController()
	{
	}

	[Token(Token = "0x600C1C9")]
	[Address(RVA = "0x2C00658", Offset = "0x2C00658", VA = "0x2C00658")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C1CA")]
	[Address(RVA = "0x2BFE754", Offset = "0x2BFE754", VA = "0x2BFE754", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C1CB")]
	[Address(RVA = "0x2BFE9F0", Offset = "0x2BFE9F0", VA = "0x2BFE9F0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C1CC")]
	[Address(RVA = "0x2BFEAB4", Offset = "0x2BFEAB4", VA = "0x2BFEAB4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C1CD")]
	[Address(RVA = "0x2C00700", Offset = "0x2C00700", VA = "0x2C00700")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x600C1CE")]
	[Address(RVA = "0x2BFEB78", Offset = "0x2BFEB78", VA = "0x2BFEB78", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C1CF")]
	[Address(RVA = "0x2BFED4C", Offset = "0x2BFED4C", VA = "0x2BFED4C")]
	public void SetViewData(CRangeData data, float width)
	{
	}

	[Token(Token = "0x600C1D0")]
	[Address(RVA = "0x2C0104C", Offset = "0x2C0104C", VA = "0x2C0104C")]
	private void OnPlusBtnClick()
	{
	}

	[Token(Token = "0x600C1D1")]
	[Address(RVA = "0x2C011B4", Offset = "0x2C011B4", VA = "0x2C011B4")]
	private void OnSubBtnClick()
	{
	}

	[Token(Token = "0x600C1D2")]
	[Address(RVA = "0x2BFF8A8", Offset = "0x2BFF8A8", VA = "0x2BFF8A8", Slot = "31")]
	protected virtual void OnSliderChanged()
	{
	}

	[Token(Token = "0x600C1D3")]
	[Address(RVA = "0x2C0131C", Offset = "0x2C0131C", VA = "0x2C0131C")]
	private void UpdateValueText()
	{
	}

	[Token(Token = "0x600C1D4")]
	[Address(RVA = "0x2C007B0", Offset = "0x2C007B0", VA = "0x2C007B0")]
	protected void SetFloatValue(float newValue)
	{
	}

	[Token(Token = "0x600C1D5")]
	[Address(RVA = "0x2C009F0", Offset = "0x2C009F0", VA = "0x2C009F0")]
	protected void SetIntValue(int newValue)
	{
	}

	[Token(Token = "0x600C1D6")]
	[Address(RVA = "0x2C00BF8", Offset = "0x2C00BF8", VA = "0x2C00BF8")]
	protected void OnValueChanged()
	{
	}

	[Token(Token = "0x600C1D7")]
	[Address(RVA = "0x2C01680", Offset = "0x2C01680", VA = "0x2C01680")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C1D8")]
	[Address(RVA = "0x2C01688", Offset = "0x2C01688", VA = "0x2C01688")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C1D9")]
	[Address(RVA = "0x2C01690", Offset = "0x2C01690", VA = "0x2C01690")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C1DA")]
	[Address(RVA = "0x2C01698", Offset = "0x2C01698", VA = "0x2C01698")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
