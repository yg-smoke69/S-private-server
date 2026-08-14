using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B0A")]
public class UISceneEditSubscriptionSlotItemController : UIBaseController
{
	[Token(Token = "0x2002B0B")]
	private enum ESUBSCRIPTION_SLOT_TYPE
	{
		[Token(Token = "0x401081F")]
		ESUBSCRIPTION,
		[Token(Token = "0x4010820")]
		EUPDATED
	}

	[Token(Token = "0x401081A")]
	[FieldOffset(Offset = "0x28")]
	private UISceneEditSubscriptionSlotItemView m_View;

	[Token(Token = "0x401081B")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x401081C")]
	[FieldOffset(Offset = "0x30")]
	private SceneEditSlotInfo m_Info;

	[Token(Token = "0x401081D")]
	[FieldOffset(Offset = "0x34")]
	private ESUBSCRIPTION_SLOT_TYPE m_SlotType;

	[Token(Token = "0x6011AD8")]
	[Address(RVA = "0x2DB29C4", Offset = "0x2DB29C4", VA = "0x2DB29C4")]
	public UISceneEditSubscriptionSlotItemController()
	{
	}

	[Token(Token = "0x6011AD9")]
	[Address(RVA = "0x2DB2A48", Offset = "0x2DB2A48", VA = "0x2DB2A48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011ADA")]
	[Address(RVA = "0x2DB2AF0", Offset = "0x2DB2AF0", VA = "0x2DB2AF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011ADB")]
	[Address(RVA = "0x2DB1018", Offset = "0x2DB1018", VA = "0x2DB1018")]
	public void SetSubscriptionUIData(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x6011ADC")]
	[Address(RVA = "0x2DB16E4", Offset = "0x2DB16E4", VA = "0x2DB16E4")]
	public void SetUpdatedUIData(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x6011ADD")]
	[Address(RVA = "0x2DB2CBC", Offset = "0x2DB2CBC", VA = "0x2DB2CBC")]
	private void RefreshCdnIcon(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x6011ADE")]
	[Address(RVA = "0x2DB3394", Offset = "0x2DB3394", VA = "0x2DB3394")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x6011ADF")]
	[Address(RVA = "0x2DB3A3C", Offset = "0x2DB3A3C", VA = "0x2DB3A3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
