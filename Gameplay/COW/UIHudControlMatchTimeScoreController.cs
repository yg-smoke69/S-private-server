using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200334F")]
public class UIHudControlMatchTimeScoreController : UIBaseController
{
	[Token(Token = "0x40138B4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudControlMatchTimeScoreView m_View;

	[Token(Token = "0x40138B5")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x40138B6")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x40138B7")]
	[FieldOffset(Offset = "0x34")]
	private uint m_CurrentPointID;

	[Token(Token = "0x40138B8")]
	[FieldOffset(Offset = "0x38")]
	private byte m_OccuTeamID;

	[Token(Token = "0x40138B9")]
	[FieldOffset(Offset = "0x3C")]
	private int targetScore;

	[Token(Token = "0x40138BA")]
	[FieldOffset(Offset = "0x40")]
	private float m_LastOpenLBTime;

	[Token(Token = "0x40138BB")]
	private const int OPEN_LB_CD = 5;

	[Token(Token = "0x40138BC")]
	private const uint NO_OCCUPY_COLOR = 4289440683u;

	[Token(Token = "0x40138BD")]
	private const uint LOCAL_OCCUPY_COLOR = 4279274166u;

	[Token(Token = "0x40138BE")]
	private const uint OPP_OCCUPY_COLOR = 4290989341u;

	[Token(Token = "0x40138BF")]
	private const uint NO_OCCUPY_LIGHT = 4278190080u;

	[Token(Token = "0x40138C0")]
	private const uint LOCAL_OCCYPY_LIGHT = 4284004299u;

	[Token(Token = "0x40138C1")]
	private const uint OPP_OCCUPY_LIGHT = 4294946304u;

	[Token(Token = "0x6015CF3")]
	[Address(RVA = "0x1363144", Offset = "0x1363144", VA = "0x1363144")]
	public UIHudControlMatchTimeScoreController()
	{
	}

	[Token(Token = "0x6015CF4")]
	[Address(RVA = "0x13631C8", Offset = "0x13631C8", VA = "0x13631C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015CF5")]
	[Address(RVA = "0x136326C", Offset = "0x136326C", VA = "0x136326C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015CF6")]
	[Address(RVA = "0x13638A0", Offset = "0x13638A0", VA = "0x13638A0")]
	private void InitScoreUI()
	{
	}

	[Token(Token = "0x6015CF7")]
	[Address(RVA = "0x1363CD4", Offset = "0x1363CD4", VA = "0x1363CD4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6015CF8")]
	[Address(RVA = "0x1364010", Offset = "0x1364010", VA = "0x1364010")]
	private void OnPhaseTimeChange(object[] data)
	{
	}

	[Token(Token = "0x6015CF9")]
	[Address(RVA = "0x1364094", Offset = "0x1364094", VA = "0x1364094")]
	private void Update()
	{
	}

	[Token(Token = "0x6015CFA")]
	[Address(RVA = "0x136410C", Offset = "0x136410C", VA = "0x136410C")]
	private void OnLeaderBoardClick()
	{
	}

	[Token(Token = "0x6015CFB")]
	[Address(RVA = "0x1364318", Offset = "0x1364318", VA = "0x1364318")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x6015CFC")]
	[Address(RVA = "0x1364580", Offset = "0x1364580", VA = "0x1364580")]
	private void OnControlPointChange(object[] data)
	{
	}

	[Token(Token = "0x6015CFD")]
	[Address(RVA = "0x1363A2C", Offset = "0x1363A2C", VA = "0x1363A2C")]
	private void ClearUIShow()
	{
	}

	[Token(Token = "0x6015CFE")]
	[Address(RVA = "0x1364928", Offset = "0x1364928", VA = "0x1364928")]
	private void OnOccupateTeamChange(object[] data)
	{
	}

	[Token(Token = "0x6015CFF")]
	[Address(RVA = "0x1365088", Offset = "0x1365088", VA = "0x1365088")]
	private void OnPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x6015D00")]
	[Address(RVA = "0x1364D48", Offset = "0x1364D48", VA = "0x1364D48")]
	private void PlayLocalOccupyEffect()
	{
	}

	[Token(Token = "0x6015D01")]
	[Address(RVA = "0x1364EE8", Offset = "0x1364EE8", VA = "0x1364EE8")]
	private void PlayOppOccupyEffect()
	{
	}

	[Token(Token = "0x6015D02")]
	[Address(RVA = "0x13651CC", Offset = "0x13651CC", VA = "0x13651CC")]
	private void OnFactionIDChanged(object[] data)
	{
	}

	[Token(Token = "0x6015D03")]
	[Address(RVA = "0x1365394", Offset = "0x1365394", VA = "0x1365394")]
	private void _003CPlayLocalOccupyEffect_003Em__0()
	{
	}

	[Token(Token = "0x6015D04")]
	[Address(RVA = "0x1365438", Offset = "0x1365438", VA = "0x1365438")]
	private void _003CPlayOppOccupyEffect_003Em__1()
	{
	}

	[Token(Token = "0x6015D05")]
	[Address(RVA = "0x13654DC", Offset = "0x13654DC", VA = "0x13654DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015D06")]
	[Address(RVA = "0x13654E4", Offset = "0x13654E4", VA = "0x13654E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
