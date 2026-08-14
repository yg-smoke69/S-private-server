using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200285E")]
internal class UIHudSuicideController : UIBaseController
{
	[Token(Token = "0x400F917")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSuicideView m_View;

	[Token(Token = "0x400F918")]
	[FieldOffset(Offset = "0x2C")]
	private float m_SuicideEndTime;

	[Token(Token = "0x600FCA9")]
	[Address(RVA = "0x1FEE650", Offset = "0x1FEE650", VA = "0x1FEE650")]
	public UIHudSuicideController()
	{
	}

	[Token(Token = "0x600FCAA")]
	[Address(RVA = "0x1FEE6D4", Offset = "0x1FEE6D4", VA = "0x1FEE6D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCAB")]
	[Address(RVA = "0x1FEE778", Offset = "0x1FEE778", VA = "0x1FEE778", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCAC")]
	[Address(RVA = "0x1FEEAF4", Offset = "0x1FEEAF4", VA = "0x1FEEAF4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FCAD")]
	[Address(RVA = "0x1FEECC8", Offset = "0x1FEECC8", VA = "0x1FEECC8")]
	private void Update()
	{
	}

	[Token(Token = "0x600FCAE")]
	[Address(RVA = "0x1FEF108", Offset = "0x1FEF108", VA = "0x1FEF108")]
	public float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x600FCAF")]
	[Address(RVA = "0x1FEF4B8", Offset = "0x1FEF4B8", VA = "0x1FEF4B8")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600FCB0")]
	[Address(RVA = "0x1FEF760", Offset = "0x1FEF760", VA = "0x1FEF760")]
	private void OnCancelBtnClick()
	{
	}

	[Token(Token = "0x600FCB1")]
	[Address(RVA = "0x1FEF7C0", Offset = "0x1FEF7C0", VA = "0x1FEF7C0")]
	private void OnPreparationCancel(object[] param)
	{
	}

	[Token(Token = "0x600FCB2")]
	[Address(RVA = "0x1FEF2F0", Offset = "0x1FEF2F0", VA = "0x1FEF2F0")]
	private void OnExecuteSuicide()
	{
	}

	[Token(Token = "0x600FCB3")]
	[Address(RVA = "0x1FEE9E4", Offset = "0x1FEE9E4", VA = "0x1FEE9E4")]
	private void ResetStatus()
	{
	}

	[Token(Token = "0x600FCB4")]
	[Address(RVA = "0x1FEF828", Offset = "0x1FEF828", VA = "0x1FEF828")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FCB5")]
	[Address(RVA = "0x1FEF830", Offset = "0x1FEF830", VA = "0x1FEF830")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
