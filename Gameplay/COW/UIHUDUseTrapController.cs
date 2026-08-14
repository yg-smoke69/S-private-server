using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C3E")]
public class UIHUDUseTrapController : UIBaseController
{
	[Token(Token = "0x4010DF6")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUseTrapView m_View;

	[Token(Token = "0x6012720")]
	[Address(RVA = "0x2933FEC", Offset = "0x2933FEC", VA = "0x2933FEC")]
	public UIHUDUseTrapController()
	{
	}

	[Token(Token = "0x6012721")]
	[Address(RVA = "0x2934070", Offset = "0x2934070", VA = "0x2934070")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012722")]
	[Address(RVA = "0x2934118", Offset = "0x2934118", VA = "0x2934118", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012723")]
	[Address(RVA = "0x2934274", Offset = "0x2934274", VA = "0x2934274")]
	public void UpdateTrapCount(int count)
	{
	}

	[Token(Token = "0x6012724")]
	[Address(RVA = "0x293436C", Offset = "0x293436C", VA = "0x293436C")]
	private void OnUseTrap()
	{
	}

	[Token(Token = "0x6012725")]
	[Address(RVA = "0x2934474", Offset = "0x2934474", VA = "0x2934474")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
