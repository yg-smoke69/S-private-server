using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002416")]
public class UIUGCHudWidgetAttributeSliderController : UIUGCHudWidgetAttributeController<int>
{
	[Token(Token = "0x400E0C5")]
	[FieldOffset(Offset = "0x34")]
	private UIUGCHudWidgetAttributeSliderView m_View;

	[Token(Token = "0x400E0C6")]
	[FieldOffset(Offset = "0x38")]
	private int m_MinValue;

	[Token(Token = "0x400E0C7")]
	[FieldOffset(Offset = "0x3C")]
	private int m_MaxValue;

	[Token(Token = "0x400E0C8")]
	[FieldOffset(Offset = "0x40")]
	private int m_Length;

	[Token(Token = "0x170010FE")]
	public override int AttributeData
	{
		[Token(Token = "0x600CBF1")]
		[Address(RVA = "0x2FF73E0", Offset = "0x2FF73E0", VA = "0x2FF73E0", Slot = "36")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600CBF2")]
		[Address(RVA = "0x2FF7438", Offset = "0x2FF7438", VA = "0x2FF7438", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CBEB")]
	[Address(RVA = "0x2FF6E58", Offset = "0x2FF6E58", VA = "0x2FF6E58")]
	public UIUGCHudWidgetAttributeSliderController()
	{
	}

	[Token(Token = "0x600CBEC")]
	[Address(RVA = "0x2FF6EBC", Offset = "0x2FF6EBC", VA = "0x2FF6EBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CBED")]
	[Address(RVA = "0x2FF6F60", Offset = "0x2FF6F60", VA = "0x2FF6F60", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CBEE")]
	[Address(RVA = "0x2FF7120", Offset = "0x2FF7120", VA = "0x2FF7120")]
	public void SetViewData(string title, int MinValue, int MaxValue, int step = 0)
	{
	}

	[Token(Token = "0x600CBEF")]
	[Address(RVA = "0x2FF7214", Offset = "0x2FF7214", VA = "0x2FF7214", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CBF0")]
	[Address(RVA = "0x2FF726C", Offset = "0x2FF726C", VA = "0x2FF726C", Slot = "38")]
	public override void InitAttribute(int data)
	{
	}

	[Token(Token = "0x600CBF3")]
	[Address(RVA = "0x2FF74C4", Offset = "0x2FF74C4", VA = "0x2FF74C4")]
	public void SetViewData(string title)
	{
	}

	[Token(Token = "0x600CBF4")]
	[Address(RVA = "0x2FF755C", Offset = "0x2FF755C", VA = "0x2FF755C")]
	private void OnSliderChanged()
	{
	}

	[Token(Token = "0x600CBF5")]
	[Address(RVA = "0x2FF76F8", Offset = "0x2FF76F8", VA = "0x2FF76F8")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x600CBF6")]
	[Address(RVA = "0x2FF7758", Offset = "0x2FF7758", VA = "0x2FF7758")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
