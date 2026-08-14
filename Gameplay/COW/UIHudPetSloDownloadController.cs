using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027F6")]
public class UIHudPetSloDownloadController : UIBaseController
{
	[Token(Token = "0x400F696")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPetSlotDownloadView m_View;

	[Token(Token = "0x600F82C")]
	[Address(RVA = "0x1853F38", Offset = "0x1853F38", VA = "0x1853F38")]
	public UIHudPetSloDownloadController()
	{
	}

	[Token(Token = "0x600F82D")]
	[Address(RVA = "0x1853FBC", Offset = "0x1853FBC", VA = "0x1853FBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F82E")]
	[Address(RVA = "0x1854060", Offset = "0x1854060", VA = "0x1854060", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F82F")]
	[Address(RVA = "0x185411C", Offset = "0x185411C", VA = "0x185411C")]
	public void SetDownloadPosition()
	{
	}

	[Token(Token = "0x600F830")]
	[Address(RVA = "0x1854228", Offset = "0x1854228", VA = "0x1854228")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
