using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A13")]
public class UIPaymentBundleContentItemController : UIBaseController
{
	[Token(Token = "0x40102C5")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentBundleContentItemView m_View;

	[Token(Token = "0x40102C6")]
	[FieldOffset(Offset = "0x2C")]
	private AwardDesc m_Data;

	[Token(Token = "0x601103B")]
	[Address(RVA = "0x286A25C", Offset = "0x286A25C", VA = "0x286A25C")]
	public UIPaymentBundleContentItemController()
	{
	}

	[Token(Token = "0x601103C")]
	[Address(RVA = "0x286A2E0", Offset = "0x286A2E0", VA = "0x286A2E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601103D")]
	[Address(RVA = "0x286A388", Offset = "0x286A388", VA = "0x286A388", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601103E")]
	[Address(RVA = "0x286A4E4", Offset = "0x286A4E4", VA = "0x286A4E4")]
	public void SetData(AwardDesc desc)
	{
	}

	[Token(Token = "0x601103F")]
	[Address(RVA = "0x286A6F0", Offset = "0x286A6F0", VA = "0x286A6F0")]
	public void SetDragScrollView(UIScrollView scrollView)
	{
	}

	[Token(Token = "0x6011040")]
	[Address(RVA = "0x286A77C", Offset = "0x286A77C", VA = "0x286A77C")]
	private void OnItemViewClick()
	{
	}

	[Token(Token = "0x6011041")]
	[Address(RVA = "0x286A928", Offset = "0x286A928", VA = "0x286A928")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
