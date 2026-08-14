using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003349")]
public class UIHudBanknoteMatchTimeScoreController : UIBaseController
{
	[Token(Token = "0x401389B")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBanknoteMatchTimeScoreView m_View;

	[Token(Token = "0x401389C")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x401389D")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x401389E")]
	[FieldOffset(Offset = "0x34")]
	private uint m_CurrentPointID;

	[Token(Token = "0x401389F")]
	[FieldOffset(Offset = "0x38")]
	private int targetScore;

	[Token(Token = "0x40138A0")]
	[FieldOffset(Offset = "0x3C")]
	private float m_LastOpenLBTime;

	[Token(Token = "0x40138A1")]
	[FieldOffset(Offset = "0x40")]
	private uint m_LocalScoreChangeCall;

	[Token(Token = "0x40138A2")]
	[FieldOffset(Offset = "0x44")]
	private uint m_OppScoreChangeCall;

	[Token(Token = "0x40138A3")]
	private const int OPEN_LB_CD = 5;

	[Token(Token = "0x40138A4")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsInScambleState;

	[Token(Token = "0x6015CA3")]
	[Address(RVA = "0x1718964", Offset = "0x1718964", VA = "0x1718964")]
	public UIHudBanknoteMatchTimeScoreController()
	{
	}

	[Token(Token = "0x6015CA4")]
	[Address(RVA = "0x17189E8", Offset = "0x17189E8", VA = "0x17189E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015CA5")]
	[Address(RVA = "0x1718A8C", Offset = "0x1718A8C", VA = "0x1718A8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015CA6")]
	[Address(RVA = "0x1719150", Offset = "0x1719150", VA = "0x1719150")]
	private void InitScoreUI()
	{
	}

	[Token(Token = "0x6015CA7")]
	[Address(RVA = "0x1719510", Offset = "0x1719510", VA = "0x1719510", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6015CA8")]
	[Address(RVA = "0x171984C", Offset = "0x171984C", VA = "0x171984C")]
	private void OnPhaseTimeChange(object[] data)
	{
	}

	[Token(Token = "0x6015CA9")]
	[Address(RVA = "0x17198D0", Offset = "0x17198D0", VA = "0x17198D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6015CAA")]
	[Address(RVA = "0x1719948", Offset = "0x1719948", VA = "0x1719948")]
	private void OnLeaderBoardClick()
	{
	}

	[Token(Token = "0x6015CAB")]
	[Address(RVA = "0x1719B54", Offset = "0x1719B54", VA = "0x1719B54")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x6015CAC")]
	[Address(RVA = "0x171A170", Offset = "0x171A170", VA = "0x171A170")]
	private void OnPickupAmount(object[] data)
	{
	}

	[Token(Token = "0x6015CAD")]
	[Address(RVA = "0x171A404", Offset = "0x171A404", VA = "0x171A404")]
	private void OnControlPointChange(object[] data)
	{
	}

	[Token(Token = "0x6015CAE")]
	[Address(RVA = "0x17193D4", Offset = "0x17193D4", VA = "0x17193D4")]
	private void ClearUIShow()
	{
	}

	[Token(Token = "0x6015CAF")]
	[Address(RVA = "0x171A9B8", Offset = "0x171A9B8", VA = "0x171A9B8")]
	private void OnOccupateTeamChange(object[] data)
	{
	}

	[Token(Token = "0x6015CB0")]
	[Address(RVA = "0x171AD88", Offset = "0x171AD88", VA = "0x171AD88")]
	private void OnPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x6015CB1")]
	[Address(RVA = "0x171AECC", Offset = "0x171AECC", VA = "0x171AECC")]
	private void OnRestAmountChange(object[] data)
	{
	}

	[Token(Token = "0x6015CB2")]
	[Address(RVA = "0x171B180", Offset = "0x171B180", VA = "0x171B180")]
	private void _003COnTeamScoreChange_003Em__0()
	{
	}

	[Token(Token = "0x6015CB3")]
	[Address(RVA = "0x171B24C", Offset = "0x171B24C", VA = "0x171B24C")]
	private void _003COnTeamScoreChange_003Em__1()
	{
	}

	[Token(Token = "0x6015CB4")]
	[Address(RVA = "0x171B318", Offset = "0x171B318", VA = "0x171B318")]
	private void _003COnPickupAmount_003Em__2()
	{
	}

	[Token(Token = "0x6015CB5")]
	[Address(RVA = "0x171B3E4", Offset = "0x171B3E4", VA = "0x171B3E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015CB6")]
	[Address(RVA = "0x171B3EC", Offset = "0x171B3EC", VA = "0x171B3EC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
