using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002227")]
public class UIHudMatchResultMVPState : UIHudMatchResultStateBase
{
	[Token(Token = "0x400D52D")]
	[FieldOffset(Offset = "0x14")]
	private Animation m_CameraAnimation;

	[Token(Token = "0x400D52E")]
	[FieldOffset(Offset = "0x18")]
	private float m_MVPUIEnterDelayTime;

	[Token(Token = "0x400D52F")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_NeedShowDownload;

	[Token(Token = "0x600B902")]
	[Address(RVA = "0x19BD6A0", Offset = "0x19BD6A0", VA = "0x19BD6A0")]
	public UIHudMatchResultMVPState(UIHudMatchResultStateMachine machine)
	{
	}

	[Token(Token = "0x600B903")]
	[Address(RVA = "0x19BD6D8", Offset = "0x19BD6D8", VA = "0x19BD6D8", Slot = "5")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B904")]
	[Address(RVA = "0x19BD8B4", Offset = "0x19BD8B4", VA = "0x19BD8B4", Slot = "6")]
	protected override bool OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B905")]
	[Address(RVA = "0x19BEF04", Offset = "0x19BEF04", VA = "0x19BEF04", Slot = "7")]
	protected override void OnFinish()
	{
	}

	[Token(Token = "0x600B906")]
	[Address(RVA = "0x19BDBB0", Offset = "0x19BDBB0", VA = "0x19BDBB0")]
	private bool CreateMVPRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x600B907")]
	[Address(RVA = "0x19BF1B0", Offset = "0x19BF1B0", VA = "0x19BF1B0")]
	private void SkipMVPAnim()
	{
	}

	[Token(Token = "0x600B908")]
	[Address(RVA = "0x19BF2C8", Offset = "0x19BF2C8", VA = "0x19BF2C8")]
	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600B909")]
	[Address(RVA = "0x19BF2CC", Offset = "0x19BF2CC", VA = "0x19BF2CC")]
	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return default(bool);
	}

	[Token(Token = "0x600B90A")]
	[Address(RVA = "0x19BF2D0", Offset = "0x19BF2D0", VA = "0x19BF2D0")]
	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}
}
