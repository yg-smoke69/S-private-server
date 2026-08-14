using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026D4")]
internal class UIHudAOHLevelUpHintController : UIBaseController
{
	[Token(Token = "0x400EFF0")]
	[FieldOffset(Offset = "0x28")]
	private UIHudAOHLevelUpHintView m_View;

	[Token(Token = "0x400EFF1")]
	[FieldOffset(Offset = "0x2C")]
	private BigHeadDataConfig m_BigHeadDataConfig;

	[Token(Token = "0x400EFF2")]
	[FieldOffset(Offset = "0x30")]
	private uint m_HideDelayCall;

	[Token(Token = "0x600EAE6")]
	[Address(RVA = "0x163B0C0", Offset = "0x163B0C0", VA = "0x163B0C0")]
	public UIHudAOHLevelUpHintController()
	{
	}

	[Token(Token = "0x600EAE7")]
	[Address(RVA = "0x163B144", Offset = "0x163B144", VA = "0x163B144")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EAE8")]
	[Address(RVA = "0x163B1EC", Offset = "0x163B1EC", VA = "0x163B1EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EAE9")]
	[Address(RVA = "0x163B49C", Offset = "0x163B49C", VA = "0x163B49C", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600EAEA")]
	[Address(RVA = "0x163B638", Offset = "0x163B638", VA = "0x163B638")]
	private void OnBigHeadLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600EAEB")]
	[Address(RVA = "0x163B948", Offset = "0x163B948", VA = "0x163B948")]
	private void OnAOHPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x600EAEC")]
	[Address(RVA = "0x163BDCC", Offset = "0x163BDCC", VA = "0x163BDCC", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600EAED")]
	[Address(RVA = "0x163BFA0", Offset = "0x163BFA0", VA = "0x163BFA0")]
	private void _003CShow_003Em__0()
	{
	}

	[Token(Token = "0x600EAEE")]
	[Address(RVA = "0x163BFB0", Offset = "0x163BFB0", VA = "0x163BFB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EAEF")]
	[Address(RVA = "0x163BFB8", Offset = "0x163BFB8", VA = "0x163BFB8")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600EAF0")]
	[Address(RVA = "0x163BFC0", Offset = "0x163BFC0", VA = "0x163BFC0")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
