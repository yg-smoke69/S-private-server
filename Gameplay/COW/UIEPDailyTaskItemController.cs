using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020D0")]
public class UIEPDailyTaskItemController : UIEasyListItemController
{
	[Token(Token = "0x400CD6E")]
	[FieldOffset(Offset = "0x38")]
	private UIEPDailyTaskItemView m_View;

	[Token(Token = "0x400CD6F")]
	[FieldOffset(Offset = "0x3C")]
	private EPDailyQuestInfo m_Data;

	[Token(Token = "0x600A9B6")]
	[Address(RVA = "0x2BA6604", Offset = "0x2BA6604", VA = "0x2BA6604")]
	public UIEPDailyTaskItemController()
	{
	}

	[Token(Token = "0x600A9B7")]
	[Address(RVA = "0x2BA660C", Offset = "0x2BA660C", VA = "0x2BA660C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A9B8")]
	[Address(RVA = "0x2BA680C", Offset = "0x2BA680C", VA = "0x2BA680C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A9B9")]
	[Address(RVA = "0x2BA6940", Offset = "0x2BA6940", VA = "0x2BA6940")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A9BA")]
	[Address(RVA = "0x2BA69E4", Offset = "0x2BA69E4", VA = "0x2BA69E4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A9BB")]
	[Address(RVA = "0x2BA6E70", Offset = "0x2BA6E70", VA = "0x2BA6E70")]
	private string GetQuestDesc(EPDailyQuestInfo dInfo)
	{
		return null;
	}

	[Token(Token = "0x600A9BC")]
	[Address(RVA = "0x2BA781C", Offset = "0x2BA781C", VA = "0x2BA781C")]
	private void OnEPDailyTaskStateUpdate(object[] data)
	{
	}

	[Token(Token = "0x600A9BD")]
	[Address(RVA = "0x2BA7468", Offset = "0x2BA7468", VA = "0x2BA7468")]
	private void SetEffect()
	{
	}

	[Token(Token = "0x600A9BE")]
	[Address(RVA = "0x2BA7B64", Offset = "0x2BA7B64", VA = "0x2BA7B64")]
	private void _003COnEPDailyTaskStateUpdate_003Em__0()
	{
	}

	[Token(Token = "0x600A9BF")]
	[Address(RVA = "0x2BA7CC4", Offset = "0x2BA7CC4", VA = "0x2BA7CC4")]
	private void _003CSetEffect_003Em__1()
	{
	}

	[Token(Token = "0x600A9C0")]
	[Address(RVA = "0x2BA7E24", Offset = "0x2BA7E24", VA = "0x2BA7E24")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A9C1")]
	[Address(RVA = "0x2BA7E2C", Offset = "0x2BA7E2C", VA = "0x2BA7E2C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
