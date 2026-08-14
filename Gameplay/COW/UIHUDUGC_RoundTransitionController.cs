using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002470")]
public class UIHUDUGC_RoundTransitionController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002471")]
	private enum EResultType
	{
		[Token(Token = "0x400E230")]
		Win = 1,
		[Token(Token = "0x400E231")]
		Lose
	}

	[Token(Token = "0x2002472")]
	private enum ETransitionStage
	{
		[Token(Token = "0x400E233")]
		CurRound,
		[Token(Token = "0x400E234")]
		NextRound
	}

	[Token(Token = "0x2002473")]
	private struct RoundIncomeData
	{
		[Token(Token = "0x400E235")]
		[FieldOffset(Offset = "0x0")]
		public string title;

		[Token(Token = "0x400E236")]
		[FieldOffset(Offset = "0x4")]
		public int incomeValue;
	}

	[Token(Token = "0x400E227")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRoundTransitionView m_View;

	[Token(Token = "0x400E228")]
	[FieldOffset(Offset = "0x2C")]
	private RoundTransitionHudEntity m_ViewData;

	[Token(Token = "0x400E229")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x400E22A")]
	[FieldOffset(Offset = "0x34")]
	private int m_MyScoreCached;

	[Token(Token = "0x400E22B")]
	[FieldOffset(Offset = "0x38")]
	private int m_OppoScoreCached;

	[Token(Token = "0x400E22C")]
	[FieldOffset(Offset = "0x3C")]
	private float m_Time;

	[Token(Token = "0x400E22D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ScoreAnimTick;

	[Token(Token = "0x400E22E")]
	[FieldOffset(Offset = "0x44")]
	private List<GameObject> m_IncomeItemList;

	[Token(Token = "0x600CF91")]
	[Address(RVA = "0x29187FC", Offset = "0x29187FC", VA = "0x29187FC")]
	public UIHUDUGC_RoundTransitionController()
	{
	}

	[Token(Token = "0x600CF92")]
	[Address(RVA = "0x29188B4", Offset = "0x29188B4", VA = "0x29188B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF93")]
	[Address(RVA = "0x291895C", Offset = "0x291895C", VA = "0x291895C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF94")]
	[Address(RVA = "0x2918BD0", Offset = "0x2918BD0", VA = "0x2918BD0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CF95")]
	[Address(RVA = "0x2918CB0", Offset = "0x2918CB0", VA = "0x2918CB0", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF96")]
	[Address(RVA = "0x2918C3C", Offset = "0x2918C3C", VA = "0x2918C3C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF97")]
	[Address(RVA = "0x2919448", Offset = "0x2919448", VA = "0x2919448", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CF98")]
	[Address(RVA = "0x29199B0", Offset = "0x29199B0", VA = "0x29199B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600CF99")]
	[Address(RVA = "0x2919A58", Offset = "0x2919A58", VA = "0x2919A58")]
	private void ShowScores()
	{
	}

	[Token(Token = "0x600CF9A")]
	[Address(RVA = "0x2919950", Offset = "0x2919950", VA = "0x2919950")]
	private void ResetScoreAnimation()
	{
	}

	[Token(Token = "0x600CF9B")]
	[Address(RVA = "0x2919E9C", Offset = "0x2919E9C", VA = "0x2919E9C")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CF9C")]
	[Address(RVA = "0x2919F24", Offset = "0x2919F24", VA = "0x2919F24")]
	private void OnTransitionStageChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF9D")]
	[Address(RVA = "0x291A02C", Offset = "0x291A02C", VA = "0x291A02C")]
	private void OnLeftTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF9E")]
	[Address(RVA = "0x291A0F4", Offset = "0x291A0F4", VA = "0x291A0F4")]
	private void OnRightTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF9F")]
	[Address(RVA = "0x291A1BC", Offset = "0x291A1BC", VA = "0x291A1BC")]
	private void OnLeftTeamNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFA0")]
	[Address(RVA = "0x291A374", Offset = "0x291A374", VA = "0x291A374")]
	private void OnRightTeamNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFA1")]
	[Address(RVA = "0x291A52C", Offset = "0x291A52C", VA = "0x291A52C")]
	private void OnLeftIconSpriteNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFA2")]
	[Address(RVA = "0x291A69C", Offset = "0x291A69C", VA = "0x291A69C")]
	private void OnRightIconSpriteNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFA3")]
	[Address(RVA = "0x291A80C", Offset = "0x291A80C", VA = "0x291A80C")]
	private void OnResultTypeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CFA4")]
	[Address(RVA = "0x291A944", Offset = "0x291A944", VA = "0x291A944")]
	private void OnWinLocChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFA5")]
	[Address(RVA = "0x291AB6C", Offset = "0x291AB6C", VA = "0x291AB6C")]
	private void OnLoseLocChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFA6")]
	[Address(RVA = "0x291AD94", Offset = "0x291AD94", VA = "0x291AD94")]
	private void OnRoundIncomeTitleChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFA7")]
	[Address(RVA = "0x291AF08", Offset = "0x291AF08", VA = "0x291AF08")]
	private void OnRoundIncomeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CFA8")]
	[Address(RVA = "0x291AFCC", Offset = "0x291AFCC", VA = "0x291AFCC")]
	private void OnRoundIncomeDetailTitleListChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CFA9")]
	[Address(RVA = "0x291B03C", Offset = "0x291B03C", VA = "0x291B03C")]
	private void OnRoundIncomeDetailListChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CFAA")]
	[Address(RVA = "0x291B710", Offset = "0x291B710", VA = "0x291B710")]
	private void OnMVPChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600CFAB")]
	[Address(RVA = "0x291B7F8", Offset = "0x291B7F8", VA = "0x291B7F8")]
	private void OnNextRoundIndexChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CFAC")]
	[Address(RVA = "0x291B9D8", Offset = "0x291B9D8", VA = "0x291B9D8")]
	private void OnIsMatchPointChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CFAD")]
	[Address(RVA = "0x291BC14", Offset = "0x291BC14", VA = "0x291BC14")]
	private void OnIsLastRoundChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CFAE")]
	[Address(RVA = "0x291BDC0", Offset = "0x291BDC0", VA = "0x291BDC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CFAF")]
	[Address(RVA = "0x291BDC8", Offset = "0x291BDC8", VA = "0x291BDC8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600CFB0")]
	[Address(RVA = "0x291BDD0", Offset = "0x291BDD0", VA = "0x291BDD0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
