using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002216")]
internal class UIHudBanknoteMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x600B88F")]
	[Address(RVA = "0x1718758", Offset = "0x1718758", VA = "0x1718758")]
	public UIHudBanknoteMatchResultController()
	{
	}

	[Token(Token = "0x600B890")]
	[Address(RVA = "0x1718760", Offset = "0x1718760", VA = "0x1718760")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B891")]
	[Address(RVA = "0x1718808", Offset = "0x1718808", VA = "0x1718808", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B892")]
	[Address(RVA = "0x17188D8", Offset = "0x17188D8", VA = "0x17188D8", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x600B893")]
	[Address(RVA = "0x1718954", Offset = "0x1718954", VA = "0x1718954")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B894")]
	[Address(RVA = "0x171895C", Offset = "0x171895C", VA = "0x171895C")]
	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}
}
