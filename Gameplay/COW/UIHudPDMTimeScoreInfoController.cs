using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200229F")]
public class UIHudPDMTimeScoreInfoController : UIBaseController
{
	[Token(Token = "0x400D8C0")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPDMTimeScoreInfoView m_View;

	[Token(Token = "0x400D8C1")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x600BE43")]
	[Address(RVA = "0x1837F68", Offset = "0x1837F68", VA = "0x1837F68")]
	public UIHudPDMTimeScoreInfoController()
	{
	}

	[Token(Token = "0x600BE44")]
	[Address(RVA = "0x1837FEC", Offset = "0x1837FEC", VA = "0x1837FEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE45")]
	[Address(RVA = "0x1838094", Offset = "0x1838094", VA = "0x1838094", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BE46")]
	[Address(RVA = "0x1838424", Offset = "0x1838424", VA = "0x1838424")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600BE47")]
	[Address(RVA = "0x183857C", Offset = "0x183857C", VA = "0x183857C")]
	private void OnPhaseTimeChange(object[] data)
	{
	}

	[Token(Token = "0x600BE48")]
	[Address(RVA = "0x1838600", Offset = "0x1838600", VA = "0x1838600")]
	private void Update()
	{
	}

	[Token(Token = "0x600BE49")]
	[Address(RVA = "0x1838678", Offset = "0x1838678", VA = "0x1838678")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600BE4A")]
	[Address(RVA = "0x18387A0", Offset = "0x18387A0", VA = "0x18387A0")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x600BE4B")]
	[Address(RVA = "0x1838870", Offset = "0x1838870", VA = "0x1838870")]
	private void OnLocalPlayerSetRank(object[] data)
	{
	}

	[Token(Token = "0x600BE4C")]
	[Address(RVA = "0x1838A40", Offset = "0x1838A40", VA = "0x1838A40")]
	private void OnFirstPlacePlayerSetKillCnt(object[] data)
	{
	}

	[Token(Token = "0x600BE4D")]
	[Address(RVA = "0x1838B20", Offset = "0x1838B20", VA = "0x1838B20")]
	private void OnShowGuide(object[] data)
	{
	}

	[Token(Token = "0x600BE4E")]
	[Address(RVA = "0x1838D18", Offset = "0x1838D18", VA = "0x1838D18")]
	protected void OnTargetScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600BE4F")]
	[Address(RVA = "0x1838F9C", Offset = "0x1838F9C", VA = "0x1838F9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
