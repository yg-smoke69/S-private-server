using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200204B")]
internal class UIHudCSRoundResultController : UIHudBaseCSRoundResultController
{
	[Token(Token = "0x400CA66")]
	[FieldOffset(Offset = "0x3C")]
	private UIHudCSRoundResultView m_View;

	[Token(Token = "0x600A44D")]
	[Address(RVA = "0x1F19C14", Offset = "0x1F19C14", VA = "0x1F19C14")]
	public UIHudCSRoundResultController()
	{
	}

	[Token(Token = "0x600A44E")]
	[Address(RVA = "0x1F19C1C", Offset = "0x1F19C1C", VA = "0x1F19C1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A44F")]
	[Address(RVA = "0x1F19CC4", Offset = "0x1F19CC4", VA = "0x1F19CC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A450")]
	[Address(RVA = "0x1F19FE4", Offset = "0x1F19FE4", VA = "0x1F19FE4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A451")]
	[Address(RVA = "0x1F1A118", Offset = "0x1F1A118", VA = "0x1F1A118", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A452")]
	[Address(RVA = "0x1F1AEE8", Offset = "0x1F1AEE8", VA = "0x1F1AEE8")]
	private void OnEarnedCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x600A453")]
	[Address(RVA = "0x1F1A194", Offset = "0x1F1A194", VA = "0x1F1A194")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A454")]
	[Address(RVA = "0x1F1B104", Offset = "0x1F1B104", VA = "0x1F1B104")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A455")]
	[Address(RVA = "0x1F1B10C", Offset = "0x1F1B10C", VA = "0x1F1B10C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A456")]
	[Address(RVA = "0x1F1B114", Offset = "0x1F1B114", VA = "0x1F1B114")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
