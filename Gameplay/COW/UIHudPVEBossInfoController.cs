using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022B3")]
internal class UIHudPVEBossInfoController : UIBaseController
{
	[Token(Token = "0x400D911")]
	private const byte MAX_TURN_COUNT = 4;

	[Token(Token = "0x400D912")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPVEBossInfoView m_View;

	[Token(Token = "0x400D913")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_delcayCall;

	[Token(Token = "0x600BED4")]
	[Address(RVA = "0x183AB64", Offset = "0x183AB64", VA = "0x183AB64")]
	public UIHudPVEBossInfoController()
	{
	}

	[Token(Token = "0x600BED5")]
	[Address(RVA = "0x183ABE8", Offset = "0x183ABE8", VA = "0x183ABE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BED6")]
	[Address(RVA = "0x183AC8C", Offset = "0x183AC8C", VA = "0x183AC8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BED7")]
	[Address(RVA = "0x183AE4C", Offset = "0x183AE4C", VA = "0x183AE4C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BED8")]
	[Address(RVA = "0x183AFF4", Offset = "0x183AFF4", VA = "0x183AFF4")]
	private void OnInWarningRegion(object[] data)
	{
	}

	[Token(Token = "0x600BED9")]
	[Address(RVA = "0x183B108", Offset = "0x183B108", VA = "0x183B108")]
	private void OnNewRoundStart(object[] data)
	{
	}

	[Token(Token = "0x600BEDA")]
	[Address(RVA = "0x183B550", Offset = "0x183B550", VA = "0x183B550")]
	private void OnBossSpawn(object[] data)
	{
	}

	[Token(Token = "0x600BEDB")]
	[Address(RVA = "0x183B344", Offset = "0x183B344", VA = "0x183B344")]
	private void ShowWarningText(float delayTime, string text_content)
	{
	}

	[Token(Token = "0x600BEDC")]
	[Address(RVA = "0x183B78C", Offset = "0x183B78C", VA = "0x183B78C")]
	private void OnBossDead(object[] data)
	{
	}

	[Token(Token = "0x600BEDD")]
	[Address(RVA = "0x183B824", Offset = "0x183B824", VA = "0x183B824")]
	private void _003CShowWarningText_003Em__0()
	{
	}

	[Token(Token = "0x600BEDE")]
	[Address(RVA = "0x183B874", Offset = "0x183B874", VA = "0x183B874")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BEDF")]
	[Address(RVA = "0x183B87C", Offset = "0x183B87C", VA = "0x183B87C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
