using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200229C")]
internal class UIHudPDMLeaderBoardItemController : UIHUDSingleFightLeaderBoardItemBaseController
{
	[Token(Token = "0x400D8BE")]
	[FieldOffset(Offset = "0x0")]
	private static bool TargetScoreReachSoonPlayed;

	[Token(Token = "0x400D8BF")]
	[FieldOffset(Offset = "0x48")]
	private byte m_TargetScore;

	[Token(Token = "0x600BE26")]
	[Address(RVA = "0x1836938", Offset = "0x1836938", VA = "0x1836938")]
	public UIHudPDMLeaderBoardItemController()
	{
	}

	[Token(Token = "0x600BE27")]
	[Address(RVA = "0x1836940", Offset = "0x1836940", VA = "0x1836940")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE28")]
	[Address(RVA = "0x18369E8", Offset = "0x18369E8", VA = "0x18369E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BE29")]
	[Address(RVA = "0x1836C34", Offset = "0x1836C34", VA = "0x1836C34", Slot = "34")]
	protected override bool ShowDeadBg()
	{
		return default(bool);
	}

	[Token(Token = "0x600BE2A")]
	[Address(RVA = "0x1836C8C", Offset = "0x1836C8C", VA = "0x1836C8C", Slot = "36")]
	public override void SetRank(uint rank)
	{
	}

	[Token(Token = "0x600BE2B")]
	[Address(RVA = "0x1837510", Offset = "0x1837510", VA = "0x1837510")]
	protected void OnTargetScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600BE2D")]
	[Address(RVA = "0x18375EC", Offset = "0x18375EC", VA = "0x18375EC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BE2E")]
	[Address(RVA = "0x18375F4", Offset = "0x18375F4", VA = "0x18375F4")]
	public bool _003C_003EiFixBaseProxy_ShowDeadBg()
	{
		return default(bool);
	}

	[Token(Token = "0x600BE2F")]
	[Address(RVA = "0x18375FC", Offset = "0x18375FC", VA = "0x18375FC")]
	public void _003C_003EiFixBaseProxy_SetRank(uint P0)
	{
	}
}
