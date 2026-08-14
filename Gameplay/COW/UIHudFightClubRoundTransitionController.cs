using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002050")]
internal class UIHudFightClubRoundTransitionController : UIBaseController
{
	[Token(Token = "0x400CA8D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRoundTransitionView m_View;

	[Token(Token = "0x400CA8E")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CA8F")]
	[FieldOffset(Offset = "0x30")]
	private BPBDKNHJODF mGame;

	[Token(Token = "0x400CA90")]
	[FieldOffset(Offset = "0x34")]
	private int m_ScoreCached;

	[Token(Token = "0x400CA91")]
	[FieldOffset(Offset = "0x38")]
	private float m_Time;

	[Token(Token = "0x400CA92")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_ScoreAnimTick;

	[Token(Token = "0x600A4C0")]
	[Address(RVA = "0x1B9F420", Offset = "0x1B9F420", VA = "0x1B9F420")]
	public UIHudFightClubRoundTransitionController()
	{
	}

	[Token(Token = "0x600A4C1")]
	[Address(RVA = "0x1B9F4A4", Offset = "0x1B9F4A4", VA = "0x1B9F4A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A4C2")]
	[Address(RVA = "0x1B9F54C", Offset = "0x1B9F54C", VA = "0x1B9F54C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A4C3")]
	[Address(RVA = "0x1BA014C", Offset = "0x1BA014C", VA = "0x1BA014C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600A4C4")]
	[Address(RVA = "0x1BA0628", Offset = "0x1BA0628", VA = "0x1BA0628", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A4C5")]
	[Address(RVA = "0x1BA0EA8", Offset = "0x1BA0EA8", VA = "0x1BA0EA8")]
	private void Update()
	{
	}

	[Token(Token = "0x600A4C6")]
	[Address(RVA = "0x1BA0B50", Offset = "0x1BA0B50", VA = "0x1BA0B50")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600A4C7")]
	[Address(RVA = "0x1BA13DC", Offset = "0x1BA13DC", VA = "0x1BA13DC")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600A4C8")]
	[Address(RVA = "0x1BA0F3C", Offset = "0x1BA0F3C", VA = "0x1BA0F3C")]
	private void ShowScores()
	{
	}

	[Token(Token = "0x600A4C9")]
	[Address(RVA = "0x1BA0E40", Offset = "0x1BA0E40", VA = "0x1BA0E40")]
	private void ResetScoreAnimation()
	{
	}

	[Token(Token = "0x600A4CA")]
	[Address(RVA = "0x1BA15CC", Offset = "0x1BA15CC", VA = "0x1BA15CC")]
	private void OnLocalPlayerJoin(object[] data)
	{
	}

	[Token(Token = "0x600A4CB")]
	[Address(RVA = "0x1B9FF98", Offset = "0x1B9FF98", VA = "0x1B9FF98")]
	private void OnFactionIDChanged(object[] data)
	{
	}

	[Token(Token = "0x600A4CC")]
	[Address(RVA = "0x1BA1628", Offset = "0x1BA1628", VA = "0x1BA1628")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600A4CD")]
	[Address(RVA = "0x1BA1C94", Offset = "0x1BA1C94", VA = "0x1BA1C94")]
	private void OnMatchPoint(object[] data)
	{
	}

	[Token(Token = "0x600A4CE")]
	[Address(RVA = "0x1BA18B0", Offset = "0x1BA18B0", VA = "0x1BA18B0")]
	private void RefreshMatchPointNode()
	{
	}

	[Token(Token = "0x600A4CF")]
	[Address(RVA = "0x1BA1CFC", Offset = "0x1BA1CFC", VA = "0x1BA1CFC")]
	private void OnAnimEventGridReposition(object[] data)
	{
	}

	[Token(Token = "0x600A4D0")]
	[Address(RVA = "0x1BA1D98", Offset = "0x1BA1D98", VA = "0x1BA1D98")]
	private void OnAnimEventShowMatchPoint(object[] data)
	{
	}

	[Token(Token = "0x600A4D1")]
	[Address(RVA = "0x1BA1EFC", Offset = "0x1BA1EFC", VA = "0x1BA1EFC")]
	private void OnAnimEventShowLastRound(object[] data)
	{
	}

	[Token(Token = "0x600A4D2")]
	[Address(RVA = "0x1BA20DC", Offset = "0x1BA20DC", VA = "0x1BA20DC")]
	private void OnTransitionAppear(object[] data)
	{
	}

	[Token(Token = "0x600A4D3")]
	[Address(RVA = "0x1BA2218", Offset = "0x1BA2218", VA = "0x1BA2218")]
	private void OnGameZoneIndexChanged(object[] data)
	{
	}

	[Token(Token = "0x600A4D4")]
	[Address(RVA = "0x1BA25CC", Offset = "0x1BA25CC", VA = "0x1BA25CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A4D5")]
	[Address(RVA = "0x1BA25D4", Offset = "0x1BA25D4", VA = "0x1BA25D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600A4D6")]
	[Address(RVA = "0x1BA25DC", Offset = "0x1BA25DC", VA = "0x1BA25DC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
