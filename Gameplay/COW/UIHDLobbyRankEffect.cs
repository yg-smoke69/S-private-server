using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002123")]
public class UIHDLobbyRankEffect : MonoBehaviour
{
	[Token(Token = "0x2002124")]
	public enum EHDShowRank
	{
		[Token(Token = "0x400CF9A")]
		BR = 1,
		[Token(Token = "0x400CF9B")]
		CS
	}

	[Token(Token = "0x2002125")]
	private sealed class _003CRecordCaptainInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CF9C")]
		[FieldOffset(Offset = "0x8")]
		internal ulong captainId;

		[Token(Token = "0x600AD89")]
		[Address(RVA = "0x2031E54", Offset = "0x2031E54", VA = "0x2031E54")]
		public _003CRecordCaptainInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600AD8A")]
		[Address(RVA = "0x2032044", Offset = "0x2032044", VA = "0x2032044")]
		internal bool _003C_003Em__0(GroupMemberInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CF8C")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_MeshRoot;

	[Token(Token = "0x400CF8D")]
	[FieldOffset(Offset = "0x10")]
	public ParticleSystem m_ChangeVFX;

	[Token(Token = "0x400CF8E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_BRRank;

	[Token(Token = "0x400CF8F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_CSRank;

	[Token(Token = "0x400CF90")]
	[FieldOffset(Offset = "0x1C")]
	private int m_fingerIndex;

	[Token(Token = "0x400CF91")]
	[FieldOffset(Offset = "0x20")]
	private bool m_HasBRRank;

	[Token(Token = "0x400CF92")]
	[FieldOffset(Offset = "0x21")]
	private bool m_HasCSRank;

	[Token(Token = "0x400CF93")]
	public const string HDSHOWRANKTYPE = "HDSHOWRANKTYPE_";

	[Token(Token = "0x400CF94")]
	[FieldOffset(Offset = "0x24")]
	private EHDShowRank m_CurrentType;

	[Token(Token = "0x400CF95")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_deltaPosition;

	[Token(Token = "0x400CF96")]
	[FieldOffset(Offset = "0x34")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400CF97")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_captainId;

	[Token(Token = "0x400CF98")]
	[FieldOffset(Offset = "0x40")]
	private bool showCaptainLobby;

	[Token(Token = "0x600AD7B")]
	[Address(RVA = "0x202FC80", Offset = "0x202FC80", VA = "0x202FC80")]
	public UIHDLobbyRankEffect()
	{
	}

	[Token(Token = "0x600AD7C")]
	[Address(RVA = "0x202FCF0", Offset = "0x202FCF0", VA = "0x202FCF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600AD7D")]
	[Address(RVA = "0x2030F60", Offset = "0x2030F60", VA = "0x2030F60")]
	private void Start()
	{
	}

	[Token(Token = "0x600AD7E")]
	[Address(RVA = "0x2031130", Offset = "0x2031130", VA = "0x2031130")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600AD7F")]
	[Address(RVA = "0x2030A98", Offset = "0x2030A98", VA = "0x2030A98")]
	private void OnLadderRankChange(object[] data)
	{
	}

	[Token(Token = "0x600AD80")]
	[Address(RVA = "0x2030CFC", Offset = "0x2030CFC", VA = "0x2030CFC")]
	private void OnCSRankChange(object[] data)
	{
	}

	[Token(Token = "0x600AD81")]
	[Address(RVA = "0x203173C", Offset = "0x203173C", VA = "0x203173C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600AD82")]
	[Address(RVA = "0x20319FC", Offset = "0x20319FC", VA = "0x20319FC")]
	public void OnRankIconClick()
	{
	}

	[Token(Token = "0x600AD83")]
	[Address(RVA = "0x2031390", Offset = "0x2031390", VA = "0x2031390")]
	private void OnInitShowRank()
	{
	}

	[Token(Token = "0x600AD84")]
	[Address(RVA = "0x203026C", Offset = "0x203026C", VA = "0x203026C")]
	private bool InCaptainLobbyGroupState()
	{
		return default(bool);
	}

	[Token(Token = "0x600AD85")]
	[Address(RVA = "0x2031C14", Offset = "0x2031C14", VA = "0x2031C14")]
	private bool InGroupState()
	{
		return default(bool);
	}

	[Token(Token = "0x600AD86")]
	[Address(RVA = "0x2031D38", Offset = "0x2031D38", VA = "0x2031D38")]
	private void ShowCaptainHighLadder(object[] data)
	{
	}

	[Token(Token = "0x600AD87")]
	[Address(RVA = "0x20303B8", Offset = "0x20303B8", VA = "0x20303B8")]
	private void RecordCaptainInfo(ulong captainId)
	{
	}

	[Token(Token = "0x600AD88")]
	[Address(RVA = "0x2031E5C", Offset = "0x2031E5C", VA = "0x2031E5C")]
	private void LeaveGroup(object[] data)
	{
	}
}
