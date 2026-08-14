using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A40")]
public class UIPaymentSubTabItemController : UIBaseController
{
	[Token(Token = "0x40103C4")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentSubTabItemView m_View;

	[Token(Token = "0x40103C5")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Index;

	[Token(Token = "0x40103C6")]
	[FieldOffset(Offset = "0x30")]
	private ActivityGroupDesc m_ActivityGroupDesc;

	[Token(Token = "0x40103C7")]
	[FieldOffset(Offset = "0x34")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x6011242")]
	[Address(RVA = "0x29DE5B0", Offset = "0x29DE5B0", VA = "0x29DE5B0")]
	public UIPaymentSubTabItemController()
	{
	}

	[Token(Token = "0x6011243")]
	[Address(RVA = "0x29DE634", Offset = "0x29DE634", VA = "0x29DE634")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011244")]
	[Address(RVA = "0x29DE6DC", Offset = "0x29DE6DC", VA = "0x29DE6DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011245")]
	[Address(RVA = "0x29DE958", Offset = "0x29DE958", VA = "0x29DE958", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011246")]
	[Address(RVA = "0x29DE9BC", Offset = "0x29DE9BC", VA = "0x29DE9BC")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x6011247")]
	[Address(RVA = "0x29DEF74", Offset = "0x29DEF74", VA = "0x29DEF74")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6011248")]
	[Address(RVA = "0x29DF318", Offset = "0x29DF318", VA = "0x29DF318")]
	public void ResetSelectedState()
	{
	}

	[Token(Token = "0x6011249")]
	[Address(RVA = "0x29DF420", Offset = "0x29DF420", VA = "0x29DF420")]
	public void SetViewData(ActivityGroupDesc desc, int index)
	{
	}

	[Token(Token = "0x601124A")]
	[Address(RVA = "0x29DF798", Offset = "0x29DF798", VA = "0x29DF798")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601124B")]
	[Address(RVA = "0x29DF7A0", Offset = "0x29DF7A0", VA = "0x29DF7A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
