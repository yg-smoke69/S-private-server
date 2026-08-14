using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200244D")]
public class UIHUDUGC_FactionInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E197")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_FactionInfoView m_View;

	[Token(Token = "0x400E198")]
	[FieldOffset(Offset = "0x2C")]
	private FactionInfoHudEntity m_ViewData;

	[Token(Token = "0x400E199")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CE20")]
	[Address(RVA = "0x222CC38", Offset = "0x222CC38", VA = "0x222CC38")]
	public UIHUDUGC_FactionInfoController()
	{
	}

	[Token(Token = "0x600CE21")]
	[Address(RVA = "0x222CCBC", Offset = "0x222CCBC", VA = "0x222CCBC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE22")]
	[Address(RVA = "0x222CD64", Offset = "0x222CD64", VA = "0x222CD64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE23")]
	[Address(RVA = "0x222CE20", Offset = "0x222CE20", VA = "0x222CE20", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CE24")]
	[Address(RVA = "0x222CF00", Offset = "0x222CF00", VA = "0x222CF00", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CE25")]
	[Address(RVA = "0x222CE8C", Offset = "0x222CE8C", VA = "0x222CE8C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CE26")]
	[Address(RVA = "0x222D248", Offset = "0x222D248", VA = "0x222D248")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CE27")]
	[Address(RVA = "0x222D2D0", Offset = "0x222D2D0", VA = "0x222D2D0")]
	private void OnLeftTeammateAliveCountChangeEvent(int old, int cur)
	{
	}

	[Token(Token = "0x600CE28")]
	[Address(RVA = "0x222D394", Offset = "0x222D394", VA = "0x222D394")]
	private void OnRightTeammateAliveCountChangeEvent(int old, int cur)
	{
	}

	[Token(Token = "0x600CE29")]
	[Address(RVA = "0x222D458", Offset = "0x222D458", VA = "0x222D458")]
	private void OnLeftBgColorChangeEvent(int old, int cur)
	{
	}

	[Token(Token = "0x600CE2A")]
	[Address(RVA = "0x222D53C", Offset = "0x222D53C", VA = "0x222D53C")]
	private void OnRightBgColorChangeEvent(int old, int cur)
	{
	}

	[Token(Token = "0x600CE2B")]
	[Address(RVA = "0x222D620", Offset = "0x222D620", VA = "0x222D620")]
	private void OnLeftIconSpriteNameChangeEvent(string old, string cur)
	{
	}

	[Token(Token = "0x600CE2C")]
	[Address(RVA = "0x222D790", Offset = "0x222D790", VA = "0x222D790")]
	private void OnRightIconSpriteNameChangeEvent(string old, string cur)
	{
	}

	[Token(Token = "0x600CE2D")]
	[Address(RVA = "0x222D900", Offset = "0x222D900", VA = "0x222D900")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CE2E")]
	[Address(RVA = "0x222D908", Offset = "0x222D908", VA = "0x222D908")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
