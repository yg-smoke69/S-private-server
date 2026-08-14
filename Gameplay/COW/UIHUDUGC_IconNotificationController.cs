using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200244E")]
public class UIHUDUGC_IconNotificationController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E19A")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_IconNotificationView m_View;

	[Token(Token = "0x400E19B")]
	[FieldOffset(Offset = "0x2C")]
	private IconNotificationHudEntity m_ViewData;

	[Token(Token = "0x400E19C")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CE2F")]
	[Address(RVA = "0x222DCA8", Offset = "0x222DCA8", VA = "0x222DCA8")]
	public UIHUDUGC_IconNotificationController()
	{
	}

	[Token(Token = "0x600CE30")]
	[Address(RVA = "0x222DD2C", Offset = "0x222DD2C", VA = "0x222DD2C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE31")]
	[Address(RVA = "0x222DDD4", Offset = "0x222DDD4", VA = "0x222DDD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE32")]
	[Address(RVA = "0x222DE90", Offset = "0x222DE90", VA = "0x222DE90", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CE33")]
	[Address(RVA = "0x222DF70", Offset = "0x222DF70", VA = "0x222DF70", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CE34")]
	[Address(RVA = "0x222DEFC", Offset = "0x222DEFC", VA = "0x222DEFC", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CE35")]
	[Address(RVA = "0x222E1A4", Offset = "0x222E1A4", VA = "0x222E1A4")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CE36")]
	[Address(RVA = "0x222E22C", Offset = "0x222E22C", VA = "0x222E22C")]
	private void OnIconSpriteNameChangeEvent(string old, string cur)
	{
	}

	[Token(Token = "0x600CE37")]
	[Address(RVA = "0x222E39C", Offset = "0x222E39C", VA = "0x222E39C")]
	private void OnBgIconSpriteNameChangeEvent(string old, string cur)
	{
	}

	[Token(Token = "0x600CE38")]
	[Address(RVA = "0x222E50C", Offset = "0x222E50C", VA = "0x222E50C")]
	private void OnDescriptionChangeEvent(string old, string cur)
	{
	}

	[Token(Token = "0x600CE39")]
	[Address(RVA = "0x222E688", Offset = "0x222E688", VA = "0x222E688")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CE3A")]
	[Address(RVA = "0x222E690", Offset = "0x222E690", VA = "0x222E690")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
