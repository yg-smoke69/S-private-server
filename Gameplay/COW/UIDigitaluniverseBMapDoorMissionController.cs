using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EE1")]
internal class UIDigitaluniverseBMapDoorMissionController : UIBaseController
{
	[Token(Token = "0x400C273")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBMapDoorMissionItemView m_View;

	[Token(Token = "0x400C274")]
	[FieldOffset(Offset = "0x2C")]
	private DigitaluniverseBMapMissionDesc m_data;

	[Token(Token = "0x400C275")]
	[FieldOffset(Offset = "0x30")]
	private UIModelActivity m_ModelAactivity;

	[Token(Token = "0x400C276")]
	[FieldOffset(Offset = "0x34")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x600969D")]
	[Address(RVA = "0x2F7CD7C", Offset = "0x2F7CD7C", VA = "0x2F7CD7C")]
	public UIDigitaluniverseBMapDoorMissionController()
	{
	}

	[Token(Token = "0x600969E")]
	[Address(RVA = "0x2F7CE00", Offset = "0x2F7CE00", VA = "0x2F7CE00")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600969F")]
	[Address(RVA = "0x2F7CEA8", Offset = "0x2F7CEA8", VA = "0x2F7CEA8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60096A0")]
	[Address(RVA = "0x2F78CE0", Offset = "0x2F78CE0", VA = "0x2F78CE0")]
	public void SetUIData(DigitaluniverseBMapMissionDesc digitaluniverseBMapMissionDesc, uint missionClaimed, bool hack)
	{
	}

	[Token(Token = "0x60096A1")]
	[Address(RVA = "0x2F7AD00", Offset = "0x2F7AD00", VA = "0x2F7AD00")]
	public void IncreaseDepth()
	{
	}

	[Token(Token = "0x60096A2")]
	[Address(RVA = "0x2F79DA0", Offset = "0x2F79DA0", VA = "0x2F79DA0")]
	public void ShowClaimVfx(uint activityId)
	{
	}

	[Token(Token = "0x60096A3")]
	[Address(RVA = "0x2F7D018", Offset = "0x2F7D018", VA = "0x2F7D018")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
