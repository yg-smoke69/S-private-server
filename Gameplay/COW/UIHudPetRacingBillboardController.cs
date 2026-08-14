using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002281")]
internal class UIHudPetRacingBillboardController : UIBaseController
{
	[Token(Token = "0x400D7F6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPetRacingBillboardView m_View;

	[Token(Token = "0x400D7F7")]
	[FieldOffset(Offset = "0x2C")]
	private UITimeLabelHelper m_PrepareCountDownLabel;

	[Token(Token = "0x400D7F8")]
	[FieldOffset(Offset = "0x30")]
	private UITimeLabelHelper m_NewRoundContDownLabel;

	[Token(Token = "0x400D7F9")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHudPetRacerView> racerList;

	[Token(Token = "0x400D7FA")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, uint> racerIDs;

	[Token(Token = "0x400D7FB")]
	[FieldOffset(Offset = "0x3C")]
	private int votedIndex;

	[Token(Token = "0x600BD2E")]
	[Address(RVA = "0x184F004", Offset = "0x184F004", VA = "0x184F004")]
	public UIHudPetRacingBillboardController()
	{
	}

	[Token(Token = "0x600BD2F")]
	[Address(RVA = "0x184F0C4", Offset = "0x184F0C4", VA = "0x184F0C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BD30")]
	[Address(RVA = "0x184F16C", Offset = "0x184F16C", VA = "0x184F16C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BD31")]
	[Address(RVA = "0x184F610", Offset = "0x184F610", VA = "0x184F610", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600BD32")]
	[Address(RVA = "0x184F8E4", Offset = "0x184F8E4", VA = "0x184F8E4")]
	private void OnPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x600BD33")]
	[Address(RVA = "0x1850730", Offset = "0x1850730", VA = "0x1850730")]
	private void Update()
	{
	}

	[Token(Token = "0x600BD34")]
	[Address(RVA = "0x1850884", Offset = "0x1850884", VA = "0x1850884")]
	private void OnAddPetRacer(object[] data)
	{
	}

	[Token(Token = "0x600BD35")]
	[Address(RVA = "0x1850CE0", Offset = "0x1850CE0", VA = "0x1850CE0")]
	private void OnPetVoted(object[] data)
	{
	}

	[Token(Token = "0x600BD36")]
	[Address(RVA = "0x1850F64", Offset = "0x1850F64", VA = "0x1850F64")]
	private void OnEnterVoteTrigger(object[] data)
	{
	}

	[Token(Token = "0x600BD37")]
	[Address(RVA = "0x18513E0", Offset = "0x18513E0", VA = "0x18513E0")]
	private void OnRacingResult(object[] data)
	{
	}

	[Token(Token = "0x600BD38")]
	[Address(RVA = "0x1851774", Offset = "0x1851774", VA = "0x1851774")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BD39")]
	[Address(RVA = "0x185177C", Offset = "0x185177C", VA = "0x185177C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
