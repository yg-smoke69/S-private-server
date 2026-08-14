using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200221F")]
internal class UIHudTokenMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x600B8C9")]
	[Address(RVA = "0x1583820", Offset = "0x1583820", VA = "0x1583820")]
	public UIHudTokenMatchResultController()
	{
	}

	[Token(Token = "0x600B8CA")]
	[Address(RVA = "0x1583828", Offset = "0x1583828", VA = "0x1583828")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B8CB")]
	[Address(RVA = "0x15838D0", Offset = "0x15838D0", VA = "0x15838D0", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B8CC")]
	[Address(RVA = "0x15839A0", Offset = "0x15839A0", VA = "0x15839A0")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}
}
