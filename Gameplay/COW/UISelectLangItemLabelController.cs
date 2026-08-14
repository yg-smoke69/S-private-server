using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B16")]
public class UISelectLangItemLabelController : UISelectLangItemController
{
	[Token(Token = "0x4010858")]
	[FieldOffset(Offset = "0x30")]
	private UIToggleItemView m_View;

	[Token(Token = "0x4010859")]
	[FieldOffset(Offset = "0x34")]
	private PopMenuData m_Data;

	[Token(Token = "0x170012E1")]
	protected UILabel m_SelectLabel
	{
		[Token(Token = "0x6011B56")]
		[Address(RVA = "0x1A51798", Offset = "0x1A51798", VA = "0x1A51798")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E2")]
	protected UILabel m_UnSelectLabel
	{
		[Token(Token = "0x6011B57")]
		[Address(RVA = "0x1A51808", Offset = "0x1A51808", VA = "0x1A51808")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6011B55")]
	[Address(RVA = "0x1A51790", Offset = "0x1A51790", VA = "0x1A51790")]
	public UISelectLangItemLabelController()
	{
	}

	[Token(Token = "0x6011B58")]
	[Address(RVA = "0x1A51878", Offset = "0x1A51878", VA = "0x1A51878")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B59")]
	[Address(RVA = "0x1A5191C", Offset = "0x1A5191C", VA = "0x1A5191C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B5A")]
	[Address(RVA = "0x1A51A78", Offset = "0x1A51A78", VA = "0x1A51A78", Slot = "31")]
	public override void SetData(PopMenuData data, int groupID)
	{
	}

	[Token(Token = "0x6011B5B")]
	[Address(RVA = "0x1A51C88", Offset = "0x1A51C88", VA = "0x1A51C88", Slot = "32")]
	public override void RefreshToggleValue()
	{
	}

	[Token(Token = "0x6011B5C")]
	[Address(RVA = "0x1A51D38", Offset = "0x1A51D38", VA = "0x1A51D38")]
	private void OnChange()
	{
	}

	[Token(Token = "0x6011B5D")]
	[Address(RVA = "0x1A51ED8", Offset = "0x1A51ED8", VA = "0x1A51ED8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011B5E")]
	[Address(RVA = "0x1A51EE0", Offset = "0x1A51EE0", VA = "0x1A51EE0")]
	public new void _003C_003EiFixBaseProxy_SetData(PopMenuData P0, int P1)
	{
	}

	[Token(Token = "0x6011B5F")]
	[Address(RVA = "0x1A51EE4", Offset = "0x1A51EE4", VA = "0x1A51EE4")]
	public void _003C_003EiFixBaseProxy_RefreshToggleValue()
	{
	}
}
