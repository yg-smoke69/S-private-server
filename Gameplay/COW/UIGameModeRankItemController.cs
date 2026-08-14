using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002698")]
internal class UIGameModeRankItemController : UIGameModeBaseItemController
{
	[Token(Token = "0x400EE1E")]
	[FieldOffset(Offset = "0x68")]
	private UIModelMapOpeningInfo m_ModelInfo;

	[Token(Token = "0x400EE1F")]
	[FieldOffset(Offset = "0x6C")]
	private JOKABEAPNPP m_GameMode;

	[Token(Token = "0x400EE20")]
	[FieldOffset(Offset = "0x70")]
	private DGNDKMLMLPM m_MatchMode;

	[Token(Token = "0x400EE21")]
	[FieldOffset(Offset = "0x0")]
	private static bool m_LockShow;

	[Token(Token = "0x400EE22")]
	[FieldOffset(Offset = "0x74")]
	private bool m_isGuest;

	[Token(Token = "0x400EE23")]
	[FieldOffset(Offset = "0x4")]
	private static string NewPlayerInRank;

	[Token(Token = "0x400EE24")]
	[FieldOffset(Offset = "0x8")]
	private static string NewPlayerInCSRank;

	[Token(Token = "0x400EE25")]
	[FieldOffset(Offset = "0x78")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400EE26")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_DataInit;

	[Token(Token = "0x600E816")]
	[Address(RVA = "0x2193520", Offset = "0x2193520", VA = "0x2193520")]
	public UIGameModeRankItemController()
	{
	}

	[Token(Token = "0x600E817")]
	[Address(RVA = "0x2193528", Offset = "0x2193528", VA = "0x2193528")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E818")]
	[Address(RVA = "0x21935D0", Offset = "0x21935D0", VA = "0x21935D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E819")]
	[Address(RVA = "0x2193920", Offset = "0x2193920", VA = "0x2193920")]
	public void AddBindAccoutCheck()
	{
	}

	[Token(Token = "0x600E81A")]
	[Address(RVA = "0x218226C", Offset = "0x218226C", VA = "0x218226C")]
	public void CheckLevelLock()
	{
	}

	[Token(Token = "0x600E81B")]
	[Address(RVA = "0x2194140", Offset = "0x2194140", VA = "0x2194140")]
	private void OnShowBindAccount()
	{
	}

	[Token(Token = "0x600E81C")]
	[Address(RVA = "0x21945CC", Offset = "0x21945CC", VA = "0x21945CC", Slot = "33")]
	public override void OnModeBtnClick()
	{
	}

	[Token(Token = "0x600E81D")]
	[Address(RVA = "0x2193C70", Offset = "0x2193C70", VA = "0x2193C70")]
	private int GetNewPlayerEffectShow()
	{
		return default(int);
	}

	[Token(Token = "0x600E81E")]
	[Address(RVA = "0x2193F90", Offset = "0x2193F90", VA = "0x2193F90")]
	private void SetNewPlayerInRankShow(int state)
	{
	}

	[Token(Token = "0x600E820")]
	[Address(RVA = "0x21949B8", Offset = "0x21949B8", VA = "0x21949B8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E821")]
	[Address(RVA = "0x21949C0", Offset = "0x21949C0", VA = "0x21949C0")]
	public void _003C_003EiFixBaseProxy_OnModeBtnClick()
	{
	}
}
