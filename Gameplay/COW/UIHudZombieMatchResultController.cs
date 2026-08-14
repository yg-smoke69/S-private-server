using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002260")]
internal class UIHudZombieMatchResultController : UIHudNormalMatchResultController
{
	[Token(Token = "0x600BBC8")]
	[Address(RVA = "0x2944DF8", Offset = "0x2944DF8", VA = "0x2944DF8")]
	public UIHudZombieMatchResultController()
	{
	}

	[Token(Token = "0x600BBC9")]
	[Address(RVA = "0x2944E00", Offset = "0x2944E00", VA = "0x2944E00")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BBCA")]
	[Address(RVA = "0x2944EA8", Offset = "0x2944EA8", VA = "0x2944EA8", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BBCB")]
	[Address(RVA = "0x2944F78", Offset = "0x2944F78", VA = "0x2944F78")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}
}
