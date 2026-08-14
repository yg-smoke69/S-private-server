using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CE1")]
public class GameMissionPlayerRangeObject
{
	[Token(Token = "0x40111F8")]
	[FieldOffset(Offset = "0x8")]
	private GameMissionPlayerRangeView m_View;

	[Token(Token = "0x40111F9")]
	[FieldOffset(Offset = "0xC")]
	private uint m_GameMissionID;

	[Token(Token = "0x40111FA")]
	[FieldOffset(Offset = "0x10")]
	private IHAAMHPPLMG m_WantedPlayerID;

	[Token(Token = "0x40111FB")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_WantedDeltaPosition;

	[Token(Token = "0x40111FC")]
	[FieldOffset(Offset = "0x34")]
	private bool m_Recycled;

	[Token(Token = "0x40111FD")]
	[FieldOffset(Offset = "0x38")]
	private float m_CountDown;

	[Token(Token = "0x40111FE")]
	[FieldOffset(Offset = "0x3C")]
	private float m_RefreshCD;

	[Token(Token = "0x6012C7D")]
	[Address(RVA = "0x1DD474C", Offset = "0x1DD474C", VA = "0x1DD474C")]
	public GameMissionPlayerRangeObject()
	{
	}

	[Token(Token = "0x6012C7E")]
	[Address(RVA = "0x1DD4848", Offset = "0x1DD4848", VA = "0x1DD4848")]
	public void OnUIInit(GameMissionPlayerRangeView view)
	{
	}

	[Token(Token = "0x6012C7F")]
	[Address(RVA = "0x1DD4A4C", Offset = "0x1DD4A4C", VA = "0x1DD4A4C")]
	public void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012C80")]
	[Address(RVA = "0x1DD4C44", Offset = "0x1DD4C44", VA = "0x1DD4C44")]
	public void StartMission(uint missionID, IHAAMHPPLMG playerID, Vector3 deltaPos, float refreshCD)
	{
	}

	[Token(Token = "0x6012C81")]
	[Address(RVA = "0x1DD4E60", Offset = "0x1DD4E60", VA = "0x1DD4E60")]
	public void UpdateMissionWantedPlayerPosition(float deltaTime)
	{
	}

	[Token(Token = "0x6012C82")]
	[Address(RVA = "0x1DD5234", Offset = "0x1DD5234", VA = "0x1DD5234")]
	private void OnNeedWantedRangeChange(object[] data)
	{
	}

	[Token(Token = "0x6012C83")]
	[Address(RVA = "0x1DD53C0", Offset = "0x1DD53C0", VA = "0x1DD53C0")]
	private void OnPlayerIDChange(object[] data)
	{
	}

	[Token(Token = "0x6012C84")]
	[Address(RVA = "0x1DD54E0", Offset = "0x1DD54E0", VA = "0x1DD54E0")]
	private void OnMissionEnd(object[] data)
	{
	}

	[Token(Token = "0x6012C85")]
	[Address(RVA = "0x1DD5704", Offset = "0x1DD5704", VA = "0x1DD5704")]
	public bool IsRecycled()
	{
		return default(bool);
	}
}
