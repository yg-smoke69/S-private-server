using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A95")]
public class UIProfileDocumentRuleItemController : UIBaseController
{
	[Token(Token = "0x2002A96")]
	public enum ProfileDocumentRuleType
	{
		[Token(Token = "0x40105C1")]
		BR,
		[Token(Token = "0x40105C2")]
		CS
	}

	[Token(Token = "0x40105BD")]
	[FieldOffset(Offset = "0x28")]
	public int AdIndex;

	[Token(Token = "0x40105BE")]
	[FieldOffset(Offset = "0x2C")]
	private ProfileDocumentRuleType m_RuleType;

	[Token(Token = "0x40105BF")]
	[FieldOffset(Offset = "0x30")]
	private UIProfileDocumentRuleItemView m_View;

	[Token(Token = "0x6011642")]
	[Address(RVA = "0x16D3B3C", Offset = "0x16D3B3C", VA = "0x16D3B3C")]
	public UIProfileDocumentRuleItemController()
	{
	}

	[Token(Token = "0x6011643")]
	[Address(RVA = "0x16D3BC0", Offset = "0x16D3BC0", VA = "0x16D3BC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011644")]
	[Address(RVA = "0x16D3C64", Offset = "0x16D3C64", VA = "0x16D3C64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011645")]
	[Address(RVA = "0x16D3DD0", Offset = "0x16D3DD0", VA = "0x16D3DD0")]
	public void SetType(ProfileDocumentRuleType ruleType)
	{
	}

	[Token(Token = "0x6011646")]
	[Address(RVA = "0x16D4090", Offset = "0x16D4090", VA = "0x16D4090")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
