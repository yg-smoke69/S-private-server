using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200271F")]
internal class UIHudCrouchController : UIHudButtonBaseController
{
	[Token(Token = "0x400F17B")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCrouchView m_View;

	[Token(Token = "0x400F17C")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsHighlight;

	[Token(Token = "0x600EDE6")]
	[Address(RVA = "0x1376E70", Offset = "0x1376E70", VA = "0x1376E70")]
	public UIHudCrouchController()
	{
	}

	[Token(Token = "0x600EDE7")]
	[Address(RVA = "0x1376E78", Offset = "0x1376E78", VA = "0x1376E78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EDE8")]
	[Address(RVA = "0x1376F1C", Offset = "0x1376F1C", VA = "0x1376F1C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EDE9")]
	[Address(RVA = "0x1377054", Offset = "0x1377054", VA = "0x1377054", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EDEA")]
	[Address(RVA = "0x13770F8", Offset = "0x13770F8", VA = "0x13770F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600EDEB")]
	[Address(RVA = "0x1377248", Offset = "0x1377248", VA = "0x1377248")]
	private void SetHightlight(bool highlight)
	{
	}

	[Token(Token = "0x600EDEC")]
	[Address(RVA = "0x13773D8", Offset = "0x13773D8", VA = "0x13773D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
