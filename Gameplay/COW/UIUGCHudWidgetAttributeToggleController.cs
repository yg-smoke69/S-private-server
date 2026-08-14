using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200241D")]
public class UIUGCHudWidgetAttributeToggleController : UIUGCHudWidgetAttributeController<bool>
{
	[Token(Token = "0x400E0D3")]
	[FieldOffset(Offset = "0x34")]
	private UIUGCHudWidgetAttributeToggleView m_View;

	[Token(Token = "0x17001102")]
	public override bool AttributeData
	{
		[Token(Token = "0x600CC2D")]
		[Address(RVA = "0x2FFAEC0", Offset = "0x2FFAEC0", VA = "0x2FFAEC0", Slot = "36")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600CC2E")]
		[Address(RVA = "0x2FFAF18", Offset = "0x2FFAF18", VA = "0x2FFAF18", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CC2A")]
	[Address(RVA = "0x2FFAD60", Offset = "0x2FFAD60", VA = "0x2FFAD60")]
	public UIUGCHudWidgetAttributeToggleController()
	{
	}

	[Token(Token = "0x600CC2B")]
	[Address(RVA = "0x2FFADC4", Offset = "0x2FFADC4", VA = "0x2FFADC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CC2C")]
	[Address(RVA = "0x2FFAE68", Offset = "0x2FFAE68", VA = "0x2FFAE68", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CC2F")]
	[Address(RVA = "0x2FFAFA4", Offset = "0x2FFAFA4", VA = "0x2FFAFA4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CC30")]
	[Address(RVA = "0x2FFB100", Offset = "0x2FFB100", VA = "0x2FFB100", Slot = "38")]
	public override void InitAttribute(bool data)
	{
	}

	[Token(Token = "0x600CC31")]
	[Address(RVA = "0x2FFB1F0", Offset = "0x2FFB1F0", VA = "0x2FFB1F0")]
	public void SetViewData(string title)
	{
	}

	[Token(Token = "0x600CC32")]
	[Address(RVA = "0x2FFB288", Offset = "0x2FFB288", VA = "0x2FFB288")]
	private void OnToggleValueChanged()
	{
	}

	[Token(Token = "0x600CC33")]
	[Address(RVA = "0x2FFB32C", Offset = "0x2FFB32C", VA = "0x2FFB32C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
