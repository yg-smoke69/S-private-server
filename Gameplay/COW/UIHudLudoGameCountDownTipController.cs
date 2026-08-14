using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002195")]
internal class UIHudLudoGameCountDownTipController : UIBaseController
{
	[Token(Token = "0x400D26F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLudoGameCountDownTipView m_View;

	[Token(Token = "0x400D270")]
	[FieldOffset(Offset = "0x2C")]
	private float m_EndTime;

	[Token(Token = "0x400D271")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallID;

	[Token(Token = "0x400D272")]
	[FieldOffset(Offset = "0x34")]
	private int m_TotalTime;

	[Token(Token = "0x400D273")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastLeftTimeCeil;

	[Token(Token = "0x400D274")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsNeedUpdateOneSecond;

	[Token(Token = "0x600B23E")]
	[Address(RVA = "0xFF3C30", Offset = "0xFF3C30", VA = "0xFF3C30")]
	public UIHudLudoGameCountDownTipController()
	{
	}

	[Token(Token = "0x600B23F")]
	[Address(RVA = "0xFF3CB4", Offset = "0xFF3CB4", VA = "0xFF3CB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B240")]
	[Address(RVA = "0xFF3D58", Offset = "0xFF3D58", VA = "0xFF3D58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B241")]
	[Address(RVA = "0xFF3EE8", Offset = "0xFF3EE8", VA = "0xFF3EE8")]
	private void Update()
	{
	}

	[Token(Token = "0x600B242")]
	[Address(RVA = "0xFF41CC", Offset = "0xFF41CC", VA = "0xFF41CC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B243")]
	[Address(RVA = "0xFF4320", Offset = "0xFF4320", VA = "0xFF4320")]
	public void SetEndTime(float endTime)
	{
	}

	[Token(Token = "0x600B244")]
	[Address(RVA = "0xFF4570", Offset = "0xFF4570", VA = "0xFF4570")]
	private void _003CSetEndTime_003Em__0()
	{
	}

	[Token(Token = "0x600B245")]
	[Address(RVA = "0xFF459C", Offset = "0xFF459C", VA = "0xFF459C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B246")]
	[Address(RVA = "0xFF45A4", Offset = "0xFF45A4", VA = "0xFF45A4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
