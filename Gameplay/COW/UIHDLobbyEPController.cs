using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002121")]
public class UIHDLobbyEPController : MonoBehaviour
{
	[Token(Token = "0x400CF82")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_Root;

	[Token(Token = "0x400CF83")]
	[FieldOffset(Offset = "0x10")]
	public Transform m_VfxRoot;

	[Token(Token = "0x400CF84")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID m_CurrentVfx;

	[Token(Token = "0x400CF85")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsInTeam;

	[Token(Token = "0x600AD66")]
	[Address(RVA = "0x202C610", Offset = "0x202C610", VA = "0x202C610")]
	public UIHDLobbyEPController()
	{
	}

	[Token(Token = "0x600AD67")]
	[Address(RVA = "0x202C6B0", Offset = "0x202C6B0", VA = "0x202C6B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600AD68")]
	[Address(RVA = "0x202D060", Offset = "0x202D060", VA = "0x202D060")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600AD69")]
	[Address(RVA = "0x202CA9C", Offset = "0x202CA9C", VA = "0x202CA9C")]
	private void OnEpChanged(object[] data)
	{
	}

	[Token(Token = "0x600AD6A")]
	[Address(RVA = "0x202D380", Offset = "0x202D380", VA = "0x202D380")]
	private void OnEPShowed(object[] data)
	{
	}

	[Token(Token = "0x600AD6B")]
	[Address(RVA = "0x202D488", Offset = "0x202D488", VA = "0x202D488")]
	private void OnLobbyControllerVisibleChanged(object[] data)
	{
	}

	[Token(Token = "0x600AD6C")]
	[Address(RVA = "0x202D66C", Offset = "0x202D66C", VA = "0x202D66C")]
	private void OnLobbyGroupEnter(object[] data)
	{
	}

	[Token(Token = "0x600AD6D")]
	[Address(RVA = "0x202D77C", Offset = "0x202D77C", VA = "0x202D77C")]
	private void OnGroupQuit(object[] data)
	{
	}
}
