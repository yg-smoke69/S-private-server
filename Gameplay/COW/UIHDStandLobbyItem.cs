using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002130")]
public class UIHDStandLobbyItem : MonoBehaviour
{
	[Token(Token = "0x2002131")]
	public enum EHDStandLobbyItemType
	{
		[Token(Token = "0x400CFEA")]
		None,
		[Token(Token = "0x400CFEB")]
		EP,
		[Token(Token = "0x400CFEC")]
		WeaponRack,
		[Token(Token = "0x400CFED")]
		Vehicle,
		[Token(Token = "0x400CFEE")]
		IceWall,
		[Token(Token = "0x400CFEF")]
		Skyboard,
		[Token(Token = "0x400CFF0")]
		IPMusic,
		[Token(Token = "0x400CFF1")]
		DigitaluniverseBLobbyEgg
	}

	[Token(Token = "0x400CFE1")]
	[FieldOffset(Offset = "0xC")]
	private EHDStandLobbyItemType m_Type;

	[Token(Token = "0x400CFE2")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsInTeam;

	[Token(Token = "0x400CFE3")]
	[FieldOffset(Offset = "0x11")]
	private bool m_IsClickSelf;

	[Token(Token = "0x400CFE4")]
	[FieldOffset(Offset = "0x14")]
	private float m_DeltaTime;

	[Token(Token = "0x400CFE5")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 m_ClickPos;

	[Token(Token = "0x400CFE6")]
	[FieldOffset(Offset = "0x20")]
	private float m_DpiFactor;

	[Token(Token = "0x400CFE7")]
	private const float IPHONE_DPI = 326f;

	[Token(Token = "0x400CFE8")]
	[FieldOffset(Offset = "0x24")]
	private UIHDStandLobbyManager m_Manager;

	[Token(Token = "0x600ADD5")]
	[Address(RVA = "0x203988C", Offset = "0x203988C", VA = "0x203988C")]
	public UIHDStandLobbyItem()
	{
	}

	[Token(Token = "0x600ADD6")]
	[Address(RVA = "0x203989C", Offset = "0x203989C", VA = "0x203989C")]
	private void Start()
	{
	}

	[Token(Token = "0x600ADD7")]
	[Address(RVA = "0x2039C6C", Offset = "0x2039C6C", VA = "0x2039C6C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600ADD8")]
	[Address(RVA = "0x2039E54", Offset = "0x2039E54", VA = "0x2039E54")]
	private void Update()
	{
	}

	[Token(Token = "0x600ADD9")]
	[Address(RVA = "0x203A324", Offset = "0x203A324", VA = "0x203A324")]
	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADDA")]
	[Address(RVA = "0x203A488", Offset = "0x203A488", VA = "0x203A488")]
	private bool CheckIsTouchSelf(Vector2 touchPos)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADDB")]
	[Address(RVA = "0x203A8F0", Offset = "0x203A8F0", VA = "0x203A8F0")]
	private void OnClickItem()
	{
	}

	[Token(Token = "0x600ADDC")]
	[Address(RVA = "0x203B6A0", Offset = "0x203B6A0", VA = "0x203B6A0")]
	private void OnLobbyGroupEnter(object[] data)
	{
	}

	[Token(Token = "0x600ADDD")]
	[Address(RVA = "0x203B708", Offset = "0x203B708", VA = "0x203B708")]
	private void OnGroupQuit(object[] data)
	{
	}
}
