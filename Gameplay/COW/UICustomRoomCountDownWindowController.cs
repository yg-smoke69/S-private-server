using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025C3")]
public class UICustomRoomCountDownWindowController : UIPopupWindowController
{
	[Token(Token = "0x400E9A6")]
	[FieldOffset(Offset = "0x48")]
	private UICustomRoomCountDownWindowView m_View;

	[Token(Token = "0x400E9A7")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelCustomRoom m_Model;

	[Token(Token = "0x400E9A8")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_CountDownTimeStampMS;

	[Token(Token = "0x400E9A9")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CountDownTime;

	[Token(Token = "0x400E9AA")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_CurrentCountDownTime;

	[Token(Token = "0x400E9AB")]
	[FieldOffset(Offset = "0x60")]
	private uint m_LastCountDownTime;

	[Token(Token = "0x400E9AC")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsRoomOwner;

	[Token(Token = "0x600DDC9")]
	[Address(RVA = "0x11EBFC8", Offset = "0x11EBFC8", VA = "0x11EBFC8")]
	public UICustomRoomCountDownWindowController()
	{
	}

	[Token(Token = "0x600DDCA")]
	[Address(RVA = "0x11EBFDC", Offset = "0x11EBFDC", VA = "0x11EBFDC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DDCB")]
	[Address(RVA = "0x11EC080", Offset = "0x11EC080", VA = "0x11EC080", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DDCC")]
	[Address(RVA = "0x11EC290", Offset = "0x11EC290", VA = "0x11EC290", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDCD")]
	[Address(RVA = "0x11EC2E8", Offset = "0x11EC2E8", VA = "0x11EC2E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600DDCE")]
	[Address(RVA = "0x11EC644", Offset = "0x11EC644", VA = "0x11EC644")]
	public void SetCountDownTime(uint time)
	{
	}

	[Token(Token = "0x600DDCF")]
	[Address(RVA = "0x11EC884", Offset = "0x11EC884", VA = "0x11EC884", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DDD0")]
	[Address(RVA = "0x11EC8E8", Offset = "0x11EC8E8", VA = "0x11EC8E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DDD1")]
	[Address(RVA = "0x11EC8F0", Offset = "0x11EC8F0", VA = "0x11EC8F0")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDD2")]
	[Address(RVA = "0x11EC8F8", Offset = "0x11EC8F8", VA = "0x11EC8F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
