using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002215")]
internal class UIHudADSMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x600B88B")]
	[Address(RVA = "0x1637740", Offset = "0x1637740", VA = "0x1637740")]
	public UIHudADSMatchResultController()
	{
	}

	[Token(Token = "0x600B88C")]
	[Address(RVA = "0x1637748", Offset = "0x1637748", VA = "0x1637748")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B88D")]
	[Address(RVA = "0x16377F0", Offset = "0x16377F0", VA = "0x16377F0", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B88E")]
	[Address(RVA = "0x16378C0", Offset = "0x16378C0", VA = "0x16378C0")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}
}
