using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002252")]
public class UIHudSingleFightMatchResultItemController : UIHudMatchResultItemBaseController
{
	[Token(Token = "0x400D6E2")]
	[FieldOffset(Offset = "0xDC")]
	protected UIHudSingleFightMatchResultItemView m_View;

	[Token(Token = "0x600BB17")]
	[Address(RVA = "0x16BEFAC", Offset = "0x16BEFAC", VA = "0x16BEFAC")]
	public UIHudSingleFightMatchResultItemController()
	{
	}

	[Token(Token = "0x600BB18")]
	[Address(RVA = "0x16BEFB4", Offset = "0x16BEFB4", VA = "0x16BEFB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB19")]
	[Address(RVA = "0x16BF05C", Offset = "0x16BF05C", VA = "0x16BF05C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BB1A")]
	[Address(RVA = "0x16BF358", Offset = "0x16BF358", VA = "0x16BF358", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BB1B")]
	[Address(RVA = "0x16BF4F0", Offset = "0x16BF4F0", VA = "0x16BF4F0", Slot = "40")]
	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x600BB1C")]
	[Address(RVA = "0x16BF648", Offset = "0x16BF648", VA = "0x16BF648", Slot = "49")]
	protected virtual void UpdatePlayerData(TeammateStats player)
	{
	}

	[Token(Token = "0x600BB1D")]
	[Address(RVA = "0x16BFEE0", Offset = "0x16BFEE0", VA = "0x16BFEE0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BB1E")]
	[Address(RVA = "0x16BFEE8", Offset = "0x16BFEE8", VA = "0x16BFEE8")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600BB1F")]
	[Address(RVA = "0x16BFEF0", Offset = "0x16BFEF0", VA = "0x16BFEF0")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}
}
