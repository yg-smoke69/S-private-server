using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028D4")]
internal class UIHudZombieModeBuffItemController : UIBaseController
{
	[Token(Token = "0x400FB24")]
	[FieldOffset(Offset = "0x28")]
	private UIHudZombieModeBuffItemView m_View;

	[Token(Token = "0x400FB25")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_CurBuffIndex;

	[Token(Token = "0x400FB26")]
	public const uint Buff1ID = 120u;

	[Token(Token = "0x400FB27")]
	public const uint Buff2ID = 121u;

	[Token(Token = "0x400FB28")]
	public const uint Buff3ID = 122u;

	[Token(Token = "0x400FB29")]
	public const uint Buff4ID = 123u;

	[Token(Token = "0x601018A")]
	[Address(RVA = "0x2945870", Offset = "0x2945870", VA = "0x2945870")]
	public UIHudZombieModeBuffItemController()
	{
	}

	[Token(Token = "0x601018B")]
	[Address(RVA = "0x29458F4", Offset = "0x29458F4", VA = "0x29458F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601018C")]
	[Address(RVA = "0x294599C", Offset = "0x294599C", VA = "0x294599C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601018D")]
	[Address(RVA = "0x294532C", Offset = "0x294532C", VA = "0x294532C")]
	public void SetView(uint buffIndex)
	{
	}

	[Token(Token = "0x601018E")]
	[Address(RVA = "0x2945AF8", Offset = "0x2945AF8", VA = "0x2945AF8")]
	private void OnBtnSelectClick()
	{
	}

	[Token(Token = "0x601018F")]
	[Address(RVA = "0x2945C40", Offset = "0x2945C40", VA = "0x2945C40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
