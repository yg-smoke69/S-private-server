using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027AF")]
internal class UIHudMatchEndShowTimeController : UIHudMatchEndShowTimeControllerBase
{
	[Token(Token = "0x400F4F0")]
	[FieldOffset(Offset = "0x34")]
	private UIHudMatchEndShowTimeView m_View;

	[Token(Token = "0x600F4E4")]
	[Address(RVA = "0xFFB814", Offset = "0xFFB814", VA = "0xFFB814")]
	public UIHudMatchEndShowTimeController()
	{
	}

	[Token(Token = "0x600F4E5")]
	[Address(RVA = "0xFFB818", Offset = "0xFFB818", VA = "0xFFB818")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F4E6")]
	[Address(RVA = "0xFFB8C0", Offset = "0xFFB8C0", VA = "0xFFB8C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F4E7")]
	[Address(RVA = "0xFFC4F4", Offset = "0xFFC4F4", VA = "0xFFC4F4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F4E8")]
	[Address(RVA = "0xFFC628", Offset = "0xFFC628", VA = "0xFFC628")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600F4E9")]
	[Address(RVA = "0xFFBD58", Offset = "0xFFBD58", VA = "0xFFBD58")]
	private void FillMatchResultInfo(bool win)
	{
	}

	[Token(Token = "0x600F4EA")]
	[Address(RVA = "0xFFC0A8", Offset = "0xFFC0A8", VA = "0xFFC0A8")]
	private void FillTeamScoreInfo(bool isTeamA, int leftScore, int rightScore)
	{
	}

	[Token(Token = "0x600F4EB")]
	[Address(RVA = "0xFFCF2C", Offset = "0xFFCF2C", VA = "0xFFCF2C")]
	private void ShowTeamIcon(bool isTeamA)
	{
	}

	[Token(Token = "0x600F4EC")]
	[Address(RVA = "0xFFC7EC", Offset = "0xFFC7EC", VA = "0xFFC7EC")]
	private bool NeedShowDefeatedGameMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600F4ED")]
	[Address(RVA = "0xFFCB8C", Offset = "0xFFCB8C", VA = "0xFFCB8C")]
	private bool NeedShowScoreGameMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600F4EE")]
	[Address(RVA = "0xFFD968", Offset = "0xFFD968", VA = "0xFFD968")]
	public void ShowShowResultBtn(bool show)
	{
	}

	[Token(Token = "0x600F4EF")]
	[Address(RVA = "0xFFDA20", Offset = "0xFFDA20", VA = "0xFFDA20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F4F0")]
	[Address(RVA = "0xFFDA28", Offset = "0xFFDA28", VA = "0xFFDA28")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
