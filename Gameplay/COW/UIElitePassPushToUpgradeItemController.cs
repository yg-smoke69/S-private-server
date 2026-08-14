using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025F3")]
public class UIElitePassPushToUpgradeItemController : UIEasyListItemController
{
	[Token(Token = "0x400EA98")]
	[FieldOffset(Offset = "0x38")]
	private UICommonRewardItemView m_View;

	[Token(Token = "0x400EA99")]
	[FieldOffset(Offset = "0x3C")]
	public CommonRewardItemInfo m_Info;

	[Token(Token = "0x400EA9A")]
	[FieldOffset(Offset = "0x40")]
	private UIStandardItemMAXBController m_childController;

	[Token(Token = "0x600E020")]
	[Address(RVA = "0x305F8E4", Offset = "0x305F8E4", VA = "0x305F8E4")]
	public UIElitePassPushToUpgradeItemController()
	{
	}

	[Token(Token = "0x600E021")]
	[Address(RVA = "0x305F8EC", Offset = "0x305F8EC", VA = "0x305F8EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E022")]
	[Address(RVA = "0x305FC50", Offset = "0x305FC50", VA = "0x305FC50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E023")]
	[Address(RVA = "0x305FCF4", Offset = "0x305FCF4", VA = "0x305FCF4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E024")]
	[Address(RVA = "0x3060194", Offset = "0x3060194", VA = "0x3060194")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
