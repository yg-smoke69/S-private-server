using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029CB")]
public class UIMissionAwardItemController : UIBaseController
{
	[Token(Token = "0x401010C")]
	[FieldOffset(Offset = "0x28")]
	private UIMissionAwardItemView m_View;

	[Token(Token = "0x6010D02")]
	[Address(RVA = "0x130824C", Offset = "0x130824C", VA = "0x130824C")]
	public UIMissionAwardItemController()
	{
	}

	[Token(Token = "0x6010D03")]
	[Address(RVA = "0x13082D0", Offset = "0x13082D0", VA = "0x13082D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D04")]
	[Address(RVA = "0x1308374", Offset = "0x1308374", VA = "0x1308374", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D05")]
	[Address(RVA = "0x1308430", Offset = "0x1308430", VA = "0x1308430")]
	public void SetData(BaseItemInfo item)
	{
	}

	[Token(Token = "0x6010D06")]
	[Address(RVA = "0x13084D0", Offset = "0x13084D0", VA = "0x13084D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
