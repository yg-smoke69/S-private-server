using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200269A")]
internal class UIGameModeCSRankItemController : UIGameModeBaseItemController
{
	[Token(Token = "0x400EE27")]
	[FieldOffset(Offset = "0x0")]
	public static bool m_LockShow;

	[Token(Token = "0x400EE28")]
	[FieldOffset(Offset = "0x68")]
	private UIModelMapOpeningInfo m_ModelInfo;

	[Token(Token = "0x400EE29")]
	[FieldOffset(Offset = "0x6C")]
	private JOKABEAPNPP m_GameMode;

	[Token(Token = "0x400EE2A")]
	[FieldOffset(Offset = "0x70")]
	private DGNDKMLMLPM m_MatchMode;

	[Token(Token = "0x400EE2B")]
	[FieldOffset(Offset = "0x74")]
	private bool m_isGuest;

	[Token(Token = "0x400EE2C")]
	[FieldOffset(Offset = "0x4")]
	private static string NewPlayerInCSRank;

	[Token(Token = "0x400EE2D")]
	[FieldOffset(Offset = "0x8")]
	private static string NewPlayerInRank;

	[Token(Token = "0x400EE2E")]
	[FieldOffset(Offset = "0x78")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400EE2F")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_DataInit;

	[Token(Token = "0x600E824")]
	[Address(RVA = "0x2469158", Offset = "0x2469158", VA = "0x2469158")]
	public UIGameModeCSRankItemController()
	{
	}

	[Token(Token = "0x600E825")]
	[Address(RVA = "0x246915C", Offset = "0x246915C", VA = "0x246915C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E826")]
	[Address(RVA = "0x2469204", Offset = "0x2469204", VA = "0x2469204", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E827")]
	[Address(RVA = "0x24694A0", Offset = "0x24694A0", VA = "0x24694A0")]
	public void CheckLevelLock()
	{
	}

	[Token(Token = "0x600E828")]
	[Address(RVA = "0x246A098", Offset = "0x246A098", VA = "0x246A098", Slot = "33")]
	public override void OnModeBtnClick()
	{
	}

	[Token(Token = "0x600E829")]
	[Address(RVA = "0x2469BC8", Offset = "0x2469BC8", VA = "0x2469BC8")]
	private int GetNewPlayerEffectShow()
	{
		return default(int);
	}

	[Token(Token = "0x600E82A")]
	[Address(RVA = "0x2469EE8", Offset = "0x2469EE8", VA = "0x2469EE8")]
	private void SetNewPlayerInRankShow(int state)
	{
	}

	[Token(Token = "0x600E82C")]
	[Address(RVA = "0x246A480", Offset = "0x246A480", VA = "0x246A480")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E82D")]
	[Address(RVA = "0x246A484", Offset = "0x246A484", VA = "0x246A484")]
	public void _003C_003EiFixBaseProxy_OnModeBtnClick()
	{
	}
}
