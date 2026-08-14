using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200241B")]
public class UIUGCHudWidgetAttributeTextAlignmentController : UIUGCHudWidgetAttributeController<Alignment>
{
	[Token(Token = "0x400E0D0")]
	[FieldOffset(Offset = "0x34")]
	private UIUGCHudWidgetAttributeTextAlignmentView m_View;

	[Token(Token = "0x17001100")]
	public override Alignment AttributeData
	{
		[Token(Token = "0x600CC18")]
		[Address(RVA = "0x2FF9A70", Offset = "0x2FF9A70", VA = "0x2FF9A70", Slot = "36")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Alignment);
		}
		[Token(Token = "0x600CC19")]
		[Address(RVA = "0x2FF9AC8", Offset = "0x2FF9AC8", VA = "0x2FF9AC8", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CC13")]
	[Address(RVA = "0x2FF9498", Offset = "0x2FF9498", VA = "0x2FF9498")]
	public UIUGCHudWidgetAttributeTextAlignmentController()
	{
	}

	[Token(Token = "0x600CC14")]
	[Address(RVA = "0x2FF94FC", Offset = "0x2FF94FC", VA = "0x2FF94FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CC15")]
	[Address(RVA = "0x2FF95A0", Offset = "0x2FF95A0", VA = "0x2FF95A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CC16")]
	[Address(RVA = "0x2FF98A0", Offset = "0x2FF98A0", VA = "0x2FF98A0", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CC17")]
	[Address(RVA = "0x2FF98F8", Offset = "0x2FF98F8", VA = "0x2FF98F8", Slot = "38")]
	public override void InitAttribute(Alignment data)
	{
	}

	[Token(Token = "0x600CC1A")]
	[Address(RVA = "0x2FF9B5C", Offset = "0x2FF9B5C", VA = "0x2FF9B5C")]
	public void SetViewData(string title)
	{
	}

	[Token(Token = "0x600CC1B")]
	[Address(RVA = "0x2FF9BF4", Offset = "0x2FF9BF4", VA = "0x2FF9BF4")]
	private void OnLeftChanged()
	{
	}

	[Token(Token = "0x600CC1C")]
	[Address(RVA = "0x2FF9CA0", Offset = "0x2FF9CA0", VA = "0x2FF9CA0")]
	private void OnCenterChanged()
	{
	}

	[Token(Token = "0x600CC1D")]
	[Address(RVA = "0x2FF9D4C", Offset = "0x2FF9D4C", VA = "0x2FF9D4C")]
	private void OnRightChanged()
	{
	}

	[Token(Token = "0x600CC1E")]
	[Address(RVA = "0x2FF9DF8", Offset = "0x2FF9DF8", VA = "0x2FF9DF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
