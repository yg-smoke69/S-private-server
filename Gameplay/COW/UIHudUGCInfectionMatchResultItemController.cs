using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002257")]
public class UIHudUGCInfectionMatchResultItemController : UIHudSingleFightMatchResultItemController
{
	[Token(Token = "0x400D6F1")]
	[FieldOffset(Offset = "0xE0")]
	private UIHudUGCInfectionMatchResultController m_parentController;

	[Token(Token = "0x400D6F2")]
	[FieldOffset(Offset = "0xE4")]
	private UGCPlayerStats m_PlayerStats;

	[Token(Token = "0x600BB64")]
	[Address(RVA = "0x1A5F25C", Offset = "0x1A5F25C", VA = "0x1A5F25C")]
	public UIHudUGCInfectionMatchResultItemController()
	{
	}

	[Token(Token = "0x600BB65")]
	[Address(RVA = "0x1A5F264", Offset = "0x1A5F264", VA = "0x1A5F264")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB66")]
	[Address(RVA = "0x1A5F30C", Offset = "0x1A5F30C", VA = "0x1A5F30C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BB67")]
	[Address(RVA = "0x1A5F4AC", Offset = "0x1A5F4AC", VA = "0x1A5F4AC")]
	public ulong GetPlayerUID()
	{
		return default(ulong);
	}

	[Token(Token = "0x600BB68")]
	[Address(RVA = "0x1A5F520", Offset = "0x1A5F520", VA = "0x1A5F520", Slot = "44")]
	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	[Token(Token = "0x600BB69")]
	[Address(RVA = "0x1A5F688", Offset = "0x1A5F688", VA = "0x1A5F688")]
	private void UpdatePlayerData(UGCPlayerStats playerStats)
	{
	}

	[Token(Token = "0x600BB6A")]
	[Address(RVA = "0x1A5FD74", Offset = "0x1A5FD74", VA = "0x1A5FD74")]
	private void ShowBannerVFX(bool show)
	{
	}

	[Token(Token = "0x600BB6B")]
	[Address(RVA = "0x1A5FEE0", Offset = "0x1A5FEE0", VA = "0x1A5FEE0")]
	internal void SetParentController(UIHudUGCInfectionMatchResultController parentController)
	{
	}

	[Token(Token = "0x600BB6C")]
	[Address(RVA = "0x1A5FF40", Offset = "0x1A5FF40", VA = "0x1A5FF40")]
	public new void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600BB6D")]
	[Address(RVA = "0x1A5FF48", Offset = "0x1A5FF48", VA = "0x1A5FF48")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}
}
