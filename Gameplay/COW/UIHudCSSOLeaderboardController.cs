using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002057")]
internal class UIHudCSSOLeaderboardController : UIBaseController
{
	[Token(Token = "0x2002058")]
	private sealed class _003CShowNewRoundStart_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CAB7")]
		[FieldOffset(Offset = "0x8")]
		internal int delayTime;

		[Token(Token = "0x400CAB8")]
		[FieldOffset(Offset = "0xC")]
		internal int phaseEndTime;

		[Token(Token = "0x400CAB9")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudCSSOLeaderboardController _0024this;

		[Token(Token = "0x600A536")]
		[Address(RVA = "0x1F1D170", Offset = "0x1F1D170", VA = "0x1F1D170")]
		public _003CShowNewRoundStart_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600A537")]
		[Address(RVA = "0x1F1D188", Offset = "0x1F1D188", VA = "0x1F1D188")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400CAB1")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCSSOLeaderboardView m_View;

	[Token(Token = "0x400CAB2")]
	[FieldOffset(Offset = "0x2C")]
	private BIKDLLIBDKE m_Game;

	[Token(Token = "0x400CAB3")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayCallID;

	[Token(Token = "0x400CAB4")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400CAB5")]
	private const string DELAYTIMEKEY = "({0}s)";

	[Token(Token = "0x400CAB6")]
	[FieldOffset(Offset = "0x38")]
	private int m_CurrRound;

	[Token(Token = "0x600A529")]
	[Address(RVA = "0x1F1BC40", Offset = "0x1F1BC40", VA = "0x1F1BC40")]
	public UIHudCSSOLeaderboardController()
	{
	}

	[Token(Token = "0x600A52A")]
	[Address(RVA = "0x1F1BCC4", Offset = "0x1F1BCC4", VA = "0x1F1BCC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A52B")]
	[Address(RVA = "0x1F1BD6C", Offset = "0x1F1BD6C", VA = "0x1F1BD6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A52C")]
	[Address(RVA = "0x1F1C084", Offset = "0x1F1C084", VA = "0x1F1C084", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A52D")]
	[Address(RVA = "0x1F1C200", Offset = "0x1F1C200", VA = "0x1F1C200")]
	public void NewRoundStart()
	{
	}

	[Token(Token = "0x600A52E")]
	[Address(RVA = "0x1F1C8F4", Offset = "0x1F1C8F4", VA = "0x1F1C8F4")]
	public void ShowLeaderBoard()
	{
	}

	[Token(Token = "0x600A52F")]
	[Address(RVA = "0x1F1C2E0", Offset = "0x1F1C2E0", VA = "0x1F1C2E0")]
	private void CreateItemCtrl(bool newRoundStart)
	{
	}

	[Token(Token = "0x600A530")]
	[Address(RVA = "0x1F1C87C", Offset = "0x1F1C87C", VA = "0x1F1C87C")]
	public void RefreshRoundInfo(bool newRoundStart)
	{
	}

	[Token(Token = "0x600A531")]
	[Address(RVA = "0x1F1C9D4", Offset = "0x1F1C9D4", VA = "0x1F1C9D4")]
	private void ShowNewRoundStart()
	{
	}

	[Token(Token = "0x600A532")]
	[Address(RVA = "0x1F1CF18", Offset = "0x1F1CF18", VA = "0x1F1CF18")]
	private void ShowCurrRoundInfo()
	{
	}

	[Token(Token = "0x600A533")]
	[Address(RVA = "0x1F1C0F0", Offset = "0x1F1C0F0", VA = "0x1F1C0F0")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600A534")]
	[Address(RVA = "0x1F1D178", Offset = "0x1F1D178", VA = "0x1F1D178")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A535")]
	[Address(RVA = "0x1F1D180", Offset = "0x1F1D180", VA = "0x1F1D180")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
