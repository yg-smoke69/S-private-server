using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002452")]
public class UIHUDUGC_LeaderboardButtonController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E1A0")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_LeaderboardButtonView m_View;

	[Token(Token = "0x400E1A1")]
	[FieldOffset(Offset = "0x2C")]
	private LeaderboardButtonHudEntity m_ViewData;

	[Token(Token = "0x400E1A2")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CE4C")]
	[Address(RVA = "0x2E0AD40", Offset = "0x2E0AD40", VA = "0x2E0AD40")]
	public UIHUDUGC_LeaderboardButtonController()
	{
	}

	[Token(Token = "0x600CE4D")]
	[Address(RVA = "0x2E0ADC4", Offset = "0x2E0ADC4", VA = "0x2E0ADC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE4E")]
	[Address(RVA = "0x2E0AE68", Offset = "0x2E0AE68", VA = "0x2E0AE68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE4F")]
	[Address(RVA = "0x2E0AFC4", Offset = "0x2E0AFC4", VA = "0x2E0AFC4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CE50")]
	[Address(RVA = "0x2E0B0A4", Offset = "0x2E0B0A4", VA = "0x2E0B0A4", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CE51")]
	[Address(RVA = "0x2E0B030", Offset = "0x2E0B030", VA = "0x2E0B030", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CE52")]
	[Address(RVA = "0x2E0B1C4", Offset = "0x2E0B1C4", VA = "0x2E0B1C4")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CE53")]
	[Address(RVA = "0x2E0B24C", Offset = "0x2E0B24C", VA = "0x2E0B24C")]
	private void OnClickButton()
	{
	}

	[Token(Token = "0x600CE54")]
	[Address(RVA = "0x2E0B44C", Offset = "0x2E0B44C", VA = "0x2E0B44C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CE55")]
	[Address(RVA = "0x2E0B454", Offset = "0x2E0B454", VA = "0x2E0B454")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
