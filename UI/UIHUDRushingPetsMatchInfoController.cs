using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using message;

[Token(Token = "0x20022E9")]
public class UIHUDRushingPetsMatchInfoController : UIBaseController
{
	[Token(Token = "0x400D9F6")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDRushingPetsMatchInfoView m_View;

	[Token(Token = "0x400D9F7")]
	[FieldOffset(Offset = "0x2C")]
	private JCBFLBIIDCJ m_CurPhaseType;

	[Token(Token = "0x400D9F8")]
	[FieldOffset(Offset = "0x30")]
	private float m_EndTime;

	[Token(Token = "0x400D9F9")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<string, RushingPetsLevelData> m_LevelMap;

	[Token(Token = "0x400D9FA")]
	[FieldOffset(Offset = "0x38")]
	private float m_LastSecond;

	[Token(Token = "0x600C050")]
	[Address(RVA = "0x147FCB4", Offset = "0x147FCB4", VA = "0x147FCB4")]
	public UIHUDRushingPetsMatchInfoController()
	{
	}

	[Token(Token = "0x600C051")]
	[Address(RVA = "0x147FD6C", Offset = "0x147FD6C", VA = "0x147FD6C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C052")]
	[Address(RVA = "0x147FE14", Offset = "0x147FE14", VA = "0x147FE14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C053")]
	[Address(RVA = "0x14804C4", Offset = "0x14804C4", VA = "0x14804C4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C054")]
	[Address(RVA = "0x1480750", Offset = "0x1480750", VA = "0x1480750")]
	private void OnNewPhase(object[] data)
	{
	}

	[Token(Token = "0x600C055")]
	[Address(RVA = "0x1480CC0", Offset = "0x1480CC0", VA = "0x1480CC0")]
	private void OnPhaseEndTimeCome(object[] data)
	{
	}

	[Token(Token = "0x600C056")]
	[Address(RVA = "0x1480D4C", Offset = "0x1480D4C", VA = "0x1480D4C")]
	private void OnRoundAndTypeCome(object[] data)
	{
	}

	[Token(Token = "0x600C057")]
	[Address(RVA = "0x1481670", Offset = "0x1481670", VA = "0x1481670")]
	private void OnRoundPlayerCountCome(object[] data)
	{
	}

	[Token(Token = "0x600C058")]
	[Address(RVA = "0x14817F4", Offset = "0x14817F4", VA = "0x14817F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600C059")]
	[Address(RVA = "0x1481A84", Offset = "0x1481A84", VA = "0x1481A84")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600C05A")]
	[Address(RVA = "0x1480280", Offset = "0x1480280", VA = "0x1480280")]
	private void InitLevelData()
	{
	}
}
