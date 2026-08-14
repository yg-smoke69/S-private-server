using COW;
using GCommon;
using Il2CppDummyDll;
using message;

[Token(Token = "0x20022E5")]
public class UIHUDRushingPetsCountDownTipController : UIBaseController
{
	[Token(Token = "0x400D9DA")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDRushingPetsCountDownTipView m_View;

	[Token(Token = "0x400D9DB")]
	[FieldOffset(Offset = "0x2C")]
	private JCBFLBIIDCJ m_CurPhaseType;

	[Token(Token = "0x400D9DC")]
	[FieldOffset(Offset = "0x30")]
	private float m_EndTime;

	[Token(Token = "0x400D9DD")]
	[FieldOffset(Offset = "0x34")]
	private uint m_GoShowDelayID;

	[Token(Token = "0x400D9DE")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastLeftTimeCeil;

	[Token(Token = "0x400D9DF")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsNeedUpdateOneSecond;

	[Token(Token = "0x600C02A")]
	[Address(RVA = "0x147ECC0", Offset = "0x147ECC0", VA = "0x147ECC0")]
	public UIHUDRushingPetsCountDownTipController()
	{
	}

	[Token(Token = "0x600C02B")]
	[Address(RVA = "0x147ED44", Offset = "0x147ED44", VA = "0x147ED44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C02C")]
	[Address(RVA = "0x147EDEC", Offset = "0x147EDEC", VA = "0x147EDEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C02D")]
	[Address(RVA = "0x147EF94", Offset = "0x147EF94", VA = "0x147EF94", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C02E")]
	[Address(RVA = "0x147F16C", Offset = "0x147F16C", VA = "0x147F16C")]
	private void OnNewPhase(object[] data)
	{
	}

	[Token(Token = "0x600C02F")]
	[Address(RVA = "0x147F5B8", Offset = "0x147F5B8", VA = "0x147F5B8")]
	private void OnPhaseEndTimeCome(object[] data)
	{
	}

	[Token(Token = "0x600C030")]
	[Address(RVA = "0x147F644", Offset = "0x147F644", VA = "0x147F644")]
	private void Update()
	{
	}

	[Token(Token = "0x600C031")]
	[Address(RVA = "0x147F648", Offset = "0x147F648", VA = "0x147F648")]
	private void UpdateLeftTimeShow()
	{
	}

	[Token(Token = "0x600C032")]
	[Address(RVA = "0x147FC50", Offset = "0x147FC50", VA = "0x147FC50")]
	private void _003COnNewPhase_003Em__0()
	{
	}
}
