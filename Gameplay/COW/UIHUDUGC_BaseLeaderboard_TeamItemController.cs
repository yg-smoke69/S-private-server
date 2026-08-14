using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002444")]
internal abstract class UIHUDUGC_BaseLeaderboard_TeamItemController : UIBaseController
{
	[Token(Token = "0x600CDB2")]
	[Address(RVA = "0x22254CC", Offset = "0x22254CC", VA = "0x22254CC")]
	protected UIHUDUGC_BaseLeaderboard_TeamItemController()
	{
	}

	[Token(Token = "0x600CDB3")]
	public abstract UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player);

	[Token(Token = "0x600CDB4")]
	[Address(RVA = "0x2225550", Offset = "0x2225550", VA = "0x2225550")]
	protected string GetInfoTitle(CBNPMCENMKE infoType)
	{
		return null;
	}
}
