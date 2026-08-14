using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002455")]
internal class UIHUDUGC_MatchInfoTitle_TeammateController : UIBaseController
{
	[Token(Token = "0x400E1AA")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_MatchInfoTitle_TeammateView m_View;

	[Token(Token = "0x600CE6D")]
	[Address(RVA = "0x2E14470", Offset = "0x2E14470", VA = "0x2E14470")]
	public UIHUDUGC_MatchInfoTitle_TeammateController()
	{
	}

	[Token(Token = "0x600CE6E")]
	[Address(RVA = "0x2E144F4", Offset = "0x2E144F4", VA = "0x2E144F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE6F")]
	[Address(RVA = "0x2E14598", Offset = "0x2E14598", VA = "0x2E14598", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE70")]
	[Address(RVA = "0x2E11F68", Offset = "0x2E11F68", VA = "0x2E11F68")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x600CE71")]
	[Address(RVA = "0x2E122C0", Offset = "0x2E122C0", VA = "0x2E122C0")]
	public void SetTeammateState(ETeammateState status)
	{
	}

	[Token(Token = "0x600CE72")]
	[Address(RVA = "0x2E1243C", Offset = "0x2E1243C", VA = "0x2E1243C")]
	public void SetFlagState(bool actived)
	{
	}

	[Token(Token = "0x600CE73")]
	[Address(RVA = "0x2E14660", Offset = "0x2E14660", VA = "0x2E14660")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
