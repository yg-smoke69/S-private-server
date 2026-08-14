using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D1A")]
public class UIHudKillNotificationMiniItem : UIHudKillNotificationItem
{
	[Token(Token = "0x401137C")]
	[FieldOffset(Offset = "0x30")]
	public UISprite killIcon;

	[Token(Token = "0x6012DAE")]
	[Address(RVA = "0x1BBB0C4", Offset = "0x1BBB0C4", VA = "0x1BBB0C4")]
	public UIHudKillNotificationMiniItem()
	{
	}

	[Token(Token = "0x6012DAF")]
	[Address(RVA = "0x1BBB0C8", Offset = "0x1BBB0C8", VA = "0x1BBB0C8", Slot = "4")]
	public override void SetKillInfo(float gameTime, PendingNotification notification)
	{
	}

	[Token(Token = "0x6012DB0")]
	[Address(RVA = "0x1BBB194", Offset = "0x1BBB194", VA = "0x1BBB194")]
	public void _003C_003EiFixBaseProxy_SetKillInfo(float P0, PendingNotification P1)
	{
	}
}
