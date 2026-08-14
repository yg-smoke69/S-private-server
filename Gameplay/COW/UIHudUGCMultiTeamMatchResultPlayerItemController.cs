using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002259")]
public class UIHudUGCMultiTeamMatchResultPlayerItemController : UIHudMatchResultItemBaseController
{
	[Token(Token = "0x400D6F8")]
	[FieldOffset(Offset = "0xDC")]
	private UIHudUGCMultiTeamMatchResultPlayerItemView m_View;

	[Token(Token = "0x600BB80")]
	[Address(RVA = "0x1A61A98", Offset = "0x1A61A98", VA = "0x1A61A98")]
	public UIHudUGCMultiTeamMatchResultPlayerItemController()
	{
	}

	[Token(Token = "0x600BB81")]
	[Address(RVA = "0x1A61AA0", Offset = "0x1A61AA0", VA = "0x1A61AA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB82")]
	[Address(RVA = "0x1A61B48", Offset = "0x1A61B48", VA = "0x1A61B48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BB83")]
	[Address(RVA = "0x1A61E9C", Offset = "0x1A61E9C", VA = "0x1A61E9C", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600BB84")]
	[Address(RVA = "0x1A61FD0", Offset = "0x1A61FD0", VA = "0x1A61FD0", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600BB85")]
	[Address(RVA = "0x1A62104", Offset = "0x1A62104", VA = "0x1A62104", Slot = "44")]
	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	[Token(Token = "0x600BB86")]
	[Address(RVA = "0x1A6226C", Offset = "0x1A6226C", VA = "0x1A6226C")]
	private void UpdatePlayerData(UGCPlayerStats playerStats)
	{
	}

	[Token(Token = "0x600BB87")]
	[Address(RVA = "0x1A62A28", Offset = "0x1A62A28", VA = "0x1A62A28")]
	private void onUIShowPlayerBannerVFX(object[] data)
	{
	}

	[Token(Token = "0x600BB88")]
	[Address(RVA = "0x1A628BC", Offset = "0x1A628BC", VA = "0x1A628BC")]
	private void ShowBannerVFX(bool show)
	{
	}

	[Token(Token = "0x600BB89")]
	[Address(RVA = "0x1A62B00", Offset = "0x1A62B00", VA = "0x1A62B00")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BB8A")]
	[Address(RVA = "0x1A62B08", Offset = "0x1A62B08", VA = "0x1A62B08")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x600BB8B")]
	[Address(RVA = "0x1A62B10", Offset = "0x1A62B10", VA = "0x1A62B10")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600BB8C")]
	[Address(RVA = "0x1A62B18", Offset = "0x1A62B18", VA = "0x1A62B18")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}
}
