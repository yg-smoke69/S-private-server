using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002816")]
public class UIHudQuickChatItemController : UIBaseController
{
	[Token(Token = "0x400F779")]
	[FieldOffset(Offset = "0x28")]
	private UIHudQuickChatItemView m_View;

	[Token(Token = "0x400F77A")]
	[FieldOffset(Offset = "0x2C")]
	private IngameQuickChatData m_QuickChatData;

	[Token(Token = "0x600F993")]
	[Address(RVA = "0x1FCA658", Offset = "0x1FCA658", VA = "0x1FCA658")]
	public UIHudQuickChatItemController()
	{
	}

	[Token(Token = "0x600F994")]
	[Address(RVA = "0x1FCA6DC", Offset = "0x1FCA6DC", VA = "0x1FCA6DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F995")]
	[Address(RVA = "0x1FCA780", Offset = "0x1FCA780", VA = "0x1FCA780", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F996")]
	[Address(RVA = "0x1FCA8DC", Offset = "0x1FCA8DC", VA = "0x1FCA8DC")]
	public void SetUIData(IngameQuickChatData data)
	{
	}

	[Token(Token = "0x600F997")]
	[Address(RVA = "0x1FCAA54", Offset = "0x1FCAA54", VA = "0x1FCAA54")]
	public void SetEnable(bool enable)
	{
	}

	[Token(Token = "0x600F998")]
	[Address(RVA = "0x1FCAB50", Offset = "0x1FCAB50", VA = "0x1FCAB50")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600F999")]
	[Address(RVA = "0x1FCAD38", Offset = "0x1FCAD38", VA = "0x1FCAD38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
