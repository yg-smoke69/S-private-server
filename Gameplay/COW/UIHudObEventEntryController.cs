using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027DA")]
public class UIHudObEventEntryController : UIBaseController
{
	[Token(Token = "0x400F613")]
	[FieldOffset(Offset = "0x28")]
	private UIHudObEventEntryView m_View;

	[Token(Token = "0x600F6F4")]
	[Address(RVA = "0x1F5B700", Offset = "0x1F5B700", VA = "0x1F5B700")]
	public UIHudObEventEntryController()
	{
	}

	[Token(Token = "0x600F6F5")]
	[Address(RVA = "0x1F5B784", Offset = "0x1F5B784", VA = "0x1F5B784")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F6F6")]
	[Address(RVA = "0x1F5B82C", Offset = "0x1F5B82C", VA = "0x1F5B82C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F6F7")]
	[Address(RVA = "0x1F5BACC", Offset = "0x1F5BACC", VA = "0x1F5BACC", Slot = "31")]
	protected virtual void OnGlobalEventBtnClick()
	{
	}

	[Token(Token = "0x600F6F8")]
	[Address(RVA = "0x1F5BC68", Offset = "0x1F5BC68", VA = "0x1F5BC68", Slot = "32")]
	protected virtual void OnLocalEventBtnClick()
	{
	}

	[Token(Token = "0x600F6F9")]
	[Address(RVA = "0x1F5BE04", Offset = "0x1F5BE04", VA = "0x1F5BE04")]
	private void OnEntryShow(object[] data)
	{
	}

	[Token(Token = "0x600F6FA")]
	[Address(RVA = "0x1F5BF34", Offset = "0x1F5BF34", VA = "0x1F5BF34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
