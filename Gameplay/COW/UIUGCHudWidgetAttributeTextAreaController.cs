using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200241C")]
public class UIUGCHudWidgetAttributeTextAreaController : UIUGCHudWidgetAttributeController<string>
{
	[Token(Token = "0x400E0D1")]
	[FieldOffset(Offset = "0x34")]
	private UIUGCHudWidgetAttributeTextAreaView m_View;

	[Token(Token = "0x400E0D2")]
	[FieldOffset(Offset = "0x38")]
	private int m_CharLimit;

	[Token(Token = "0x17001101")]
	public override string AttributeData
	{
		[Token(Token = "0x600CC22")]
		[Address(RVA = "0x2FFA238", Offset = "0x2FFA238", VA = "0x2FFA238", Slot = "36")]
		get
		{
			return null;
		}
		[Token(Token = "0x600CC23")]
		[Address(RVA = "0x2FFA290", Offset = "0x2FFA290", VA = "0x2FFA290", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CC1F")]
	[Address(RVA = "0x2FFA0D8", Offset = "0x2FFA0D8", VA = "0x2FFA0D8")]
	public UIUGCHudWidgetAttributeTextAreaController()
	{
	}

	[Token(Token = "0x600CC20")]
	[Address(RVA = "0x2FFA13C", Offset = "0x2FFA13C", VA = "0x2FFA13C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CC21")]
	[Address(RVA = "0x2FFA1E0", Offset = "0x2FFA1E0", VA = "0x2FFA1E0", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CC24")]
	[Address(RVA = "0x2FFA394", Offset = "0x2FFA394", VA = "0x2FFA394", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CC25")]
	[Address(RVA = "0x2FFA554", Offset = "0x2FFA554", VA = "0x2FFA554", Slot = "38")]
	public override void InitAttribute(string data)
	{
	}

	[Token(Token = "0x600CC26")]
	[Address(RVA = "0x2FFA644", Offset = "0x2FFA644", VA = "0x2FFA644")]
	public void SetViewData(string title, int charLimit, string defaultValue = "")
	{
	}

	[Token(Token = "0x600CC27")]
	[Address(RVA = "0x2FFA8B0", Offset = "0x2FFA8B0", VA = "0x2FFA8B0")]
	private void OnInputChanged()
	{
	}

	[Token(Token = "0x600CC28")]
	[Address(RVA = "0x2FFAA80", Offset = "0x2FFAA80", VA = "0x2FFAA80")]
	private void OnInputLostFocus()
	{
	}

	[Token(Token = "0x600CC29")]
	[Address(RVA = "0x2FFAAE0", Offset = "0x2FFAAE0", VA = "0x2FFAAE0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
