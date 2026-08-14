using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027E9")]
public class UIHudPartyGameSoloDanceController : UIBaseController
{
	[Token(Token = "0x20027EA")]
	public enum ViewBit
	{
		[Token(Token = "0x400F663")]
		None,
		[Token(Token = "0x400F664")]
		ScoreInfo,
		[Token(Token = "0x400F665")]
		BtnQuitGame,
		[Token(Token = "0x400F666")]
		GoWaitingTip,
		[Token(Token = "0x400F667")]
		BtnInvite,
		[Token(Token = "0x400F668")]
		GoInvitePanel,
		[Token(Token = "0x400F669")]
		TrCountDownDuringGame,
		[Token(Token = "0x400F66A")]
		GoCountDownOnStarting
	}

	[Token(Token = "0x400F65F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPartyGameSoloDanceView m_View;

	[Token(Token = "0x400F660")]
	[FieldOffset(Offset = "0x2C")]
	private float m_BattleEndTime;

	[Token(Token = "0x400F661")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x600F78E")]
	[Address(RVA = "0x183EB74", Offset = "0x183EB74", VA = "0x183EB74")]
	public UIHudPartyGameSoloDanceController()
	{
	}

	[Token(Token = "0x600F78F")]
	[Address(RVA = "0x183EBF8", Offset = "0x183EBF8", VA = "0x183EBF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F790")]
	[Address(RVA = "0x183EC9C", Offset = "0x183EC9C", VA = "0x183EC9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F791")]
	[Address(RVA = "0x183F080", Offset = "0x183F080", VA = "0x183F080", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F792")]
	[Address(RVA = "0x183F1B4", Offset = "0x183F1B4", VA = "0x183F1B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600F793")]
	[Address(RVA = "0x183F70C", Offset = "0x183F70C", VA = "0x183F70C")]
	public void CleanData()
	{
	}

	[Token(Token = "0x600F794")]
	[Address(RVA = "0x183F7E4", Offset = "0x183F7E4", VA = "0x183F7E4")]
	public void RefreshView(object[] data)
	{
	}

	[Token(Token = "0x600F795")]
	[Address(RVA = "0x183FBDC", Offset = "0x183FBDC", VA = "0x183FBDC")]
	private void RefreshViewByBit(short viewBits)
	{
	}

	[Token(Token = "0x600F796")]
	[Address(RVA = "0x183F93C", Offset = "0x183F93C", VA = "0x183F93C")]
	private void ResetView()
	{
	}

	[Token(Token = "0x600F797")]
	[Address(RVA = "0x183F2D0", Offset = "0x183F2D0", VA = "0x183F2D0")]
	private void CalculateCountDownDuringBattle()
	{
	}

	[Token(Token = "0x600F798")]
	[Address(RVA = "0x183F5A0", Offset = "0x183F5A0", VA = "0x183F5A0")]
	private void CalculateAndShowBtnInviteCD()
	{
	}

	[Token(Token = "0x600F799")]
	[Address(RVA = "0x183FE74", Offset = "0x183FE74", VA = "0x183FE74")]
	private void OnRefreshScore(object[] data)
	{
	}

	[Token(Token = "0x600F79A")]
	[Address(RVA = "0x183FF98", Offset = "0x183FF98", VA = "0x183FF98")]
	public void SetBattleCountDown(float endTime)
	{
	}

	[Token(Token = "0x600F79B")]
	[Address(RVA = "0x1840008", Offset = "0x1840008", VA = "0x1840008")]
	private void OnClickBtnQuitGame()
	{
	}

	[Token(Token = "0x600F79C")]
	[Address(RVA = "0x1840154", Offset = "0x1840154", VA = "0x1840154")]
	private void OnClickBtnInvite()
	{
	}

	[Token(Token = "0x600F79D")]
	[Address(RVA = "0x1840324", Offset = "0x1840324", VA = "0x1840324")]
	private void OnClickBtnInviteAll()
	{
	}

	[Token(Token = "0x600F79E")]
	[Address(RVA = "0x1840690", Offset = "0x1840690", VA = "0x1840690")]
	private void OnClickBtnInviteFriends()
	{
	}

	[Token(Token = "0x600F79F")]
	[Address(RVA = "0x1840494", Offset = "0x1840494", VA = "0x1840494")]
	private void InviteOpponent(bool onlyFriend)
	{
	}

	[Token(Token = "0x600F7A0")]
	[Address(RVA = "0x1840800", Offset = "0x1840800", VA = "0x1840800")]
	private void OnClickBtnCloseInvite()
	{
	}

	[Token(Token = "0x600F7A1")]
	[Address(RVA = "0x184092C", Offset = "0x184092C", VA = "0x184092C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F7A2")]
	[Address(RVA = "0x1840934", Offset = "0x1840934", VA = "0x1840934")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
