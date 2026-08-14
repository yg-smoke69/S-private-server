using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FE0")]
public class UIAvatarState : UIAvatarStateBase
{
	[Token(Token = "0x400C871")]
	[FieldOffset(Offset = "0x30")]
	public UIAvatarStateTriggerValue<uint> CurrentSelectClothes;

	[Token(Token = "0x400C872")]
	[FieldOffset(Offset = "0x34")]
	public bool HidingSet;

	[Token(Token = "0x400C873")]
	[FieldOffset(Offset = "0x38")]
	public string HidingSlot;

	[Token(Token = "0x600A086")]
	[Address(RVA = "0x2FA1C4C", Offset = "0x2FA1C4C", VA = "0x2FA1C4C")]
	public UIAvatarState()
	{
	}

	[Token(Token = "0x600A087")]
	[Address(RVA = "0x2FA1D6C", Offset = "0x2FA1D6C", VA = "0x2FA1D6C")]
	public void CloneTo(UIAvatarState s)
	{
	}

	[Token(Token = "0x600A088")]
	[Address(RVA = "0x2FA1F8C", Offset = "0x2FA1F8C", VA = "0x2FA1F8C", Slot = "4")]
	public override void ResetOnceValues()
	{
	}

	[Token(Token = "0x600A089")]
	[Address(RVA = "0x2FA204C", Offset = "0x2FA204C", VA = "0x2FA204C")]
	public void _003C_003EiFixBaseProxy_ResetOnceValues()
	{
	}
}
