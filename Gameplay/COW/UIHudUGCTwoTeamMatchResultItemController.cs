using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200225F")]
public class UIHudUGCTwoTeamMatchResultItemController : UIHudTeamBattleMatchResultItemController
{
	[Token(Token = "0x600BBC3")]
	[Address(RVA = "0x1A68C0C", Offset = "0x1A68C0C", VA = "0x1A68C0C")]
	public UIHudUGCTwoTeamMatchResultItemController()
	{
	}

	[Token(Token = "0x600BBC4")]
	[Address(RVA = "0x1A68C14", Offset = "0x1A68C14", VA = "0x1A68C14")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BBC5")]
	[Address(RVA = "0x1A68CBC", Offset = "0x1A68CBC", VA = "0x1A68CBC", Slot = "44")]
	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	[Token(Token = "0x600BBC6")]
	[Address(RVA = "0x1A68DDC", Offset = "0x1A68DDC", VA = "0x1A68DDC")]
	private void UpdatePlayerData(UGCPlayerStats playerStats)
	{
	}

	[Token(Token = "0x600BBC7")]
	[Address(RVA = "0x1A694D0", Offset = "0x1A694D0", VA = "0x1A694D0")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}
}
