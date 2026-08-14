using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200202F")]
public class UIChampionshipTeamRecordItemController : UIEasyListItemController
{
	[Token(Token = "0x400CA07")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipTeamRecordItemView m_View;

	[Token(Token = "0x400CA08")]
	[FieldOffset(Offset = "0x3C")]
	private TeamChampionshipMatchData m_MatchData;

	[Token(Token = "0x400CA09")]
	[FieldOffset(Offset = "0x40")]
	private TeamChampionshipMatchStats m_MatchStats;

	[Token(Token = "0x600A34D")]
	[Address(RVA = "0x2621F40", Offset = "0x2621F40", VA = "0x2621F40")]
	public UIChampionshipTeamRecordItemController()
	{
	}

	[Token(Token = "0x600A34E")]
	[Address(RVA = "0x2621F48", Offset = "0x2621F48", VA = "0x2621F48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A34F")]
	[Address(RVA = "0x2621FEC", Offset = "0x2621FEC", VA = "0x2621FEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A350")]
	[Address(RVA = "0x26220A8", Offset = "0x26220A8", VA = "0x26220A8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A351")]
	[Address(RVA = "0x2622590", Offset = "0x2622590", VA = "0x2622590")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
