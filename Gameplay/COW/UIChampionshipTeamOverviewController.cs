using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002027")]
public class UIChampionshipTeamOverviewController : UIBaseController
{
	[Token(Token = "0x400C9E6")]
	[FieldOffset(Offset = "0x28")]
	private UIChampionshipTeamOverviewView m_View;

	[Token(Token = "0x400C9E7")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9E8")]
	[FieldOffset(Offset = "0x30")]
	private EChampionship.TeamScaleType m_TeamScale;

	[Token(Token = "0x600A30B")]
	[Address(RVA = "0x2618E58", Offset = "0x2618E58", VA = "0x2618E58")]
	public UIChampionshipTeamOverviewController()
	{
	}

	[Token(Token = "0x600A30C")]
	[Address(RVA = "0x2618EDC", Offset = "0x2618EDC", VA = "0x2618EDC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A30D")]
	[Address(RVA = "0x2618F80", Offset = "0x2618F80", VA = "0x2618F80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A30E")]
	[Address(RVA = "0x2619380", Offset = "0x2619380", VA = "0x2619380")]
	public void SetData(TeamInfo teamInfo, uint championshipType, bool showEditButton = false)
	{
	}

	[Token(Token = "0x600A30F")]
	[Address(RVA = "0x2619DB0", Offset = "0x2619DB0", VA = "0x2619DB0")]
	public void SetNationFlag(UISprite flagSprite, TeamInfo teamInfo)
	{
	}

	[Token(Token = "0x600A310")]
	[Address(RVA = "0x261A0F4", Offset = "0x261A0F4", VA = "0x261A0F4")]
	protected void EditInfo()
	{
	}

	[Token(Token = "0x600A311")]
	[Address(RVA = "0x261A204", Offset = "0x261A204", VA = "0x261A204")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
