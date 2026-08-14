using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026E2")]
internal class UIHudBanknoteMatchTimeScoreTipsController : UIBaseController
{
	[Token(Token = "0x400F033")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBanknoteMatchTimeScoreTipsView m_View;

	[Token(Token = "0x400F034")]
	[FieldOffset(Offset = "0x2C")]
	private string m_PreviousShowName;

	[Token(Token = "0x400F035")]
	[FieldOffset(Offset = "0x30")]
	private uint m_PreviousPointID;

	[Token(Token = "0x600EB8F")]
	[Address(RVA = "0x171B3F4", Offset = "0x171B3F4", VA = "0x171B3F4")]
	public UIHudBanknoteMatchTimeScoreTipsController()
	{
	}

	[Token(Token = "0x600EB90")]
	[Address(RVA = "0x171B4C0", Offset = "0x171B4C0", VA = "0x171B4C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB91")]
	[Address(RVA = "0x171B564", Offset = "0x171B564", VA = "0x171B564", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB92")]
	[Address(RVA = "0x171B6B4", Offset = "0x171B6B4", VA = "0x171B6B4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EB93")]
	[Address(RVA = "0x171B718", Offset = "0x171B718", VA = "0x171B718", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600EB94")]
	[Address(RVA = "0x171B77C", Offset = "0x171B77C", VA = "0x171B77C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EB95")]
	[Address(RVA = "0x171B7E0", Offset = "0x171B7E0", VA = "0x171B7E0")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x600EB96")]
	[Address(RVA = "0x171B834", Offset = "0x171B834", VA = "0x171B834")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EB97")]
	[Address(RVA = "0x171BA18", Offset = "0x171BA18", VA = "0x171BA18")]
	private void OnControlPointChange(object[] data)
	{
	}

	[Token(Token = "0x600EB98")]
	[Address(RVA = "0x171BFE4", Offset = "0x171BFE4", VA = "0x171BFE4")]
	private void _003COnControlPointChange_003Em__0()
	{
	}

	[Token(Token = "0x600EB99")]
	[Address(RVA = "0x171BFF4", Offset = "0x171BFF4", VA = "0x171BFF4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB9A")]
	[Address(RVA = "0x171BFFC", Offset = "0x171BFFC", VA = "0x171BFFC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EB9B")]
	[Address(RVA = "0x171C004", Offset = "0x171C004", VA = "0x171C004")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600EB9C")]
	[Address(RVA = "0x171C00C", Offset = "0x171C00C", VA = "0x171C00C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
