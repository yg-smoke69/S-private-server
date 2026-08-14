using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002767")]
internal class UIHudGiantMatchInfoController : UIBaseController
{
	[Token(Token = "0x400F32E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGiantMatchInfoView m_View;

	[Token(Token = "0x400F32F")]
	[FieldOffset(Offset = "0x2C")]
	private int mSeconds;

	[Token(Token = "0x400F330")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder m_Timer;

	[Token(Token = "0x400F331")]
	[FieldOffset(Offset = "0x34")]
	private uint min;

	[Token(Token = "0x400F332")]
	[FieldOffset(Offset = "0x38")]
	private uint sec;

	[Token(Token = "0x400F333")]
	[FieldOffset(Offset = "0x3C")]
	private POECKIDCBKC mGame;

	[Token(Token = "0x400F334")]
	[FieldOffset(Offset = "0x40")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F335")]
	private const uint TEAMCOUNT = 4u;

	[Token(Token = "0x400F336")]
	private const string EMPTY_DIST = "---";

	[Token(Token = "0x400F337")]
	private const string ZERO_DIST = "0m";

	[Token(Token = "0x600F0DD")]
	[Address(RVA = "0x18947BC", Offset = "0x18947BC", VA = "0x18947BC")]
	public UIHudGiantMatchInfoController()
	{
	}

	[Token(Token = "0x600F0DE")]
	[Address(RVA = "0x1894840", Offset = "0x1894840", VA = "0x1894840")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F0DF")]
	[Address(RVA = "0x18948E8", Offset = "0x18948E8", VA = "0x18948E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F0E0")]
	[Address(RVA = "0x18951A0", Offset = "0x18951A0", VA = "0x18951A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F0E1")]
	[Address(RVA = "0x18955AC", Offset = "0x18955AC", VA = "0x18955AC")]
	private void OnBtnLeaderboardClick()
	{
	}

	[Token(Token = "0x600F0E2")]
	[Address(RVA = "0x1895704", Offset = "0x1895704", VA = "0x1895704")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x600F0E3")]
	[Address(RVA = "0x1895840", Offset = "0x1895840", VA = "0x1895840")]
	private void Update()
	{
	}

	[Token(Token = "0x600F0E4")]
	[Address(RVA = "0x1895AE0", Offset = "0x1895AE0", VA = "0x1895AE0")]
	private void UpdateTimeTxt(int seconds)
	{
	}

	[Token(Token = "0x600F0E5")]
	[Address(RVA = "0x1895DBC", Offset = "0x1895DBC", VA = "0x1895DBC")]
	private void OnCurrentRoundChanged(object[] data)
	{
	}

	[Token(Token = "0x600F0E6")]
	[Address(RVA = "0x1894F38", Offset = "0x1894F38", VA = "0x1894F38")]
	private void UpdateTeamScore()
	{
	}

	[Token(Token = "0x600F0E7")]
	[Address(RVA = "0x1895E24", Offset = "0x1895E24", VA = "0x1895E24")]
	private void OnTeamIconChanged(object[] data)
	{
	}

	[Token(Token = "0x600F0E8")]
	[Address(RVA = "0x18960B8", Offset = "0x18960B8", VA = "0x18960B8")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600F0E9")]
	[Address(RVA = "0x18964B4", Offset = "0x18964B4", VA = "0x18964B4")]
	private void OnLastTeamScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600F0EA")]
	[Address(RVA = "0x1896738", Offset = "0x1896738", VA = "0x1896738")]
	private void OnCurrentMoveDistanceChanged(object[] data)
	{
	}

	[Token(Token = "0x600F0EB")]
	[Address(RVA = "0x18969BC", Offset = "0x18969BC", VA = "0x18969BC")]
	private void OnTotalDistanceChanged(object[] data)
	{
	}

	[Token(Token = "0x600F0EC")]
	[Address(RVA = "0x18957EC", Offset = "0x18957EC", VA = "0x18957EC")]
	private void SetRoundInfoUI()
	{
	}

	[Token(Token = "0x600F0ED")]
	[Address(RVA = "0x1896B48", Offset = "0x1896B48", VA = "0x1896B48", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F0EE")]
	[Address(RVA = "0x1896C1C", Offset = "0x1896C1C", VA = "0x1896C1C")]
	private void SetUIData(object[] data)
	{
	}

	[Token(Token = "0x600F0EF")]
	[Address(RVA = "0x1896C98", Offset = "0x1896C98", VA = "0x1896C98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F0F0")]
	[Address(RVA = "0x1896CA0", Offset = "0x1896CA0", VA = "0x1896CA0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F0F1")]
	[Address(RVA = "0x1896CA8", Offset = "0x1896CA8", VA = "0x1896CA8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
