using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200221D")]
internal class UIHudGiantMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x600B8BB")]
	[Address(RVA = "0x1897118", Offset = "0x1897118", VA = "0x1897118")]
	public UIHudGiantMatchResultController()
	{
	}

	[Token(Token = "0x600B8BC")]
	[Address(RVA = "0x1897120", Offset = "0x1897120", VA = "0x1897120")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B8BD")]
	[Address(RVA = "0x18971C8", Offset = "0x18971C8", VA = "0x18971C8", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B8BE")]
	[Address(RVA = "0x1897298", Offset = "0x1897298", VA = "0x1897298")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}
}
