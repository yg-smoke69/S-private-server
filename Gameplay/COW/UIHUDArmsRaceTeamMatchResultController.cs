using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001FA8")]
internal class UIHUDArmsRaceTeamMatchResultController : UIHudTeamBattleMatchResultController
{
	[Token(Token = "0x6009DDD")]
	[Address(RVA = "0x1673130", Offset = "0x1673130", VA = "0x1673130")]
	public UIHUDArmsRaceTeamMatchResultController()
	{
	}

	[Token(Token = "0x6009DDE")]
	[Address(RVA = "0x1673138", Offset = "0x1673138", VA = "0x1673138")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DDF")]
	[Address(RVA = "0x16731E0", Offset = "0x16731E0", VA = "0x16731E0", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x6009DE0")]
	[Address(RVA = "0x16732B0", Offset = "0x16732B0", VA = "0x16732B0", Slot = "48")]
	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	[Token(Token = "0x6009DE1")]
	[Address(RVA = "0x1673328", Offset = "0x1673328", VA = "0x1673328")]
	private void ShowTeamInfo()
	{
	}

	[Token(Token = "0x6009DE2")]
	[Address(RVA = "0x16736E0", Offset = "0x16736E0", VA = "0x16736E0")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x6009DE3")]
	[Address(RVA = "0x16736E8", Offset = "0x16736E8", VA = "0x16736E8")]
	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}
}
