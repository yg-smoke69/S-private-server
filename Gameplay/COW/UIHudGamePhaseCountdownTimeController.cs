using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200275E")]
internal class UIHudGamePhaseCountdownTimeController : UIBaseController
{
	[Token(Token = "0x400F316")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGamePhaseCountdownHintView m_View;

	[Token(Token = "0x400F317")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F318")]
	[FieldOffset(Offset = "0x30")]
	private GamePhaseCountdownData m_ViewData;

	[Token(Token = "0x600F08A")]
	[Address(RVA = "0x188BDCC", Offset = "0x188BDCC", VA = "0x188BDCC")]
	public UIHudGamePhaseCountdownTimeController()
	{
	}

	[Token(Token = "0x600F08B")]
	[Address(RVA = "0x188BE50", Offset = "0x188BE50", VA = "0x188BE50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F08C")]
	[Address(RVA = "0x188BEF8", Offset = "0x188BEF8", VA = "0x188BEF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F08D")]
	[Address(RVA = "0x188C194", Offset = "0x188C194", VA = "0x188C194", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F08E")]
	[Address(RVA = "0x188C2C8", Offset = "0x188C2C8", VA = "0x188C2C8")]
	private void OnPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x600F08F")]
	[Address(RVA = "0x188CA04", Offset = "0x188CA04", VA = "0x188CA04")]
	private void Update()
	{
	}

	[Token(Token = "0x600F090")]
	[Address(RVA = "0x188CD98", Offset = "0x188CD98", VA = "0x188CD98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F091")]
	[Address(RVA = "0x188CDA0", Offset = "0x188CDA0", VA = "0x188CDA0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
