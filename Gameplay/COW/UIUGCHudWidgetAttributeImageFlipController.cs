using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002415")]
public class UIUGCHudWidgetAttributeImageFlipController : UIUGCHudWidgetAttributeController<Flip>
{
	[Token(Token = "0x400E0C4")]
	[FieldOffset(Offset = "0x34")]
	private UIUGCHudWidgetAttributeImageFlipView m_View;

	[Token(Token = "0x170010FD")]
	public override Flip AttributeData
	{
		[Token(Token = "0x600CBE7")]
		[Address(RVA = "0x2FF6A54", Offset = "0x2FF6A54", VA = "0x2FF6A54", Slot = "36")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Flip);
		}
		[Token(Token = "0x600CBE8")]
		[Address(RVA = "0x2FF6AAC", Offset = "0x2FF6AAC", VA = "0x2FF6AAC", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CBDF")]
	[Address(RVA = "0x2FF6434", Offset = "0x2FF6434", VA = "0x2FF6434")]
	public UIUGCHudWidgetAttributeImageFlipController()
	{
	}

	[Token(Token = "0x600CBE0")]
	[Address(RVA = "0x2FF6498", Offset = "0x2FF6498", VA = "0x2FF6498")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CBE1")]
	[Address(RVA = "0x2FF653C", Offset = "0x2FF653C", VA = "0x2FF653C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CBE2")]
	[Address(RVA = "0x2FF670C", Offset = "0x2FF670C", VA = "0x2FF670C")]
	private void OnHorizontalChanged()
	{
	}

	[Token(Token = "0x600CBE3")]
	[Address(RVA = "0x2FF685C", Offset = "0x2FF685C", VA = "0x2FF685C")]
	private void OnVerticalChanged()
	{
	}

	[Token(Token = "0x600CBE4")]
	[Address(RVA = "0x2FF676C", Offset = "0x2FF676C", VA = "0x2FF676C")]
	private void UpdateFlip()
	{
	}

	[Token(Token = "0x600CBE5")]
	[Address(RVA = "0x2FF68BC", Offset = "0x2FF68BC", VA = "0x2FF68BC", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CBE6")]
	[Address(RVA = "0x2FF6914", Offset = "0x2FF6914", VA = "0x2FF6914", Slot = "38")]
	public override void InitAttribute(Flip data)
	{
	}

	[Token(Token = "0x600CBE9")]
	[Address(RVA = "0x2FF6B40", Offset = "0x2FF6B40", VA = "0x2FF6B40")]
	public void SetViewData(string title)
	{
	}

	[Token(Token = "0x600CBEA")]
	[Address(RVA = "0x2FF6BD8", Offset = "0x2FF6BD8", VA = "0x2FF6BD8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
