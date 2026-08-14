using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200225D")]
public class UIHudUGCOneTeamMatchResultItemController : UIHudMatchResultItemBaseController
{
	[Token(Token = "0x400D702")]
	[FieldOffset(Offset = "0xDC")]
	private UIHudSingleFightMatchResultItemView m_View;

	[Token(Token = "0x400D703")]
	[FieldOffset(Offset = "0xE0")]
	private ulong _003CAccountID_003Ek__BackingField;

	[Token(Token = "0x17001086")]
	public ulong AccountID
	{
		[Token(Token = "0x600BBAA")]
		[Address(RVA = "0x1A66114", Offset = "0x1A66114", VA = "0x1A66114")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600BBAB")]
		[Address(RVA = "0x1A66A50", Offset = "0x1A66A50", VA = "0x1A66A50")]
		private set
		{
		}
	}

	[Token(Token = "0x600BBA9")]
	[Address(RVA = "0x1A66A48", Offset = "0x1A66A48", VA = "0x1A66A48")]
	public UIHudUGCOneTeamMatchResultItemController()
	{
	}

	[Token(Token = "0x600BBAC")]
	[Address(RVA = "0x1A66A60", Offset = "0x1A66A60", VA = "0x1A66A60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BBAD")]
	[Address(RVA = "0x1A66B08", Offset = "0x1A66B08", VA = "0x1A66B08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BBAE")]
	[Address(RVA = "0x1A66E04", Offset = "0x1A66E04", VA = "0x1A66E04", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BBAF")]
	[Address(RVA = "0x1A66F18", Offset = "0x1A66F18", VA = "0x1A66F18", Slot = "44")]
	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	[Token(Token = "0x600BBB0")]
	[Address(RVA = "0x1A670B8", Offset = "0x1A670B8", VA = "0x1A670B8")]
	private void UpdatePlayerInnerUI(UGCPlayerStats playerStats)
	{
	}

	[Token(Token = "0x600BBB1")]
	[Address(RVA = "0x1A6772C", Offset = "0x1A6772C", VA = "0x1A6772C")]
	private void ShowBannerVFX(bool show)
	{
	}

	[Token(Token = "0x600BBB2")]
	[Address(RVA = "0x1A67898", Offset = "0x1A67898", VA = "0x1A67898")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BBB3")]
	[Address(RVA = "0x1A678A0", Offset = "0x1A678A0", VA = "0x1A678A0")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600BBB4")]
	[Address(RVA = "0x1A678A8", Offset = "0x1A678A8", VA = "0x1A678A8")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}
}
