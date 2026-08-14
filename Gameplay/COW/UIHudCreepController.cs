using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002718")]
internal class UIHudCreepController : UIHudButtonBaseController
{
	[Token(Token = "0x400F137")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCreepView m_View;

	[Token(Token = "0x400F138")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsHighlight;

	[Token(Token = "0x600ED9E")]
	[Address(RVA = "0x136944C", Offset = "0x136944C", VA = "0x136944C")]
	public UIHudCreepController()
	{
	}

	[Token(Token = "0x600ED9F")]
	[Address(RVA = "0x1369454", Offset = "0x1369454", VA = "0x1369454")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EDA0")]
	[Address(RVA = "0x13694F8", Offset = "0x13694F8", VA = "0x13694F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EDA1")]
	[Address(RVA = "0x13695D8", Offset = "0x13695D8", VA = "0x13695D8", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EDA2")]
	[Address(RVA = "0x136967C", Offset = "0x136967C", VA = "0x136967C")]
	private void Update()
	{
	}

	[Token(Token = "0x600EDA3")]
	[Address(RVA = "0x13697CC", Offset = "0x13697CC", VA = "0x13697CC")]
	private void SetHightlight(bool highlight)
	{
	}

	[Token(Token = "0x600EDA4")]
	[Address(RVA = "0x136995C", Offset = "0x136995C", VA = "0x136995C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
