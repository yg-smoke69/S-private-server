using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200222F")]
public class UIHudMatchResultStateMachine
{
	[Token(Token = "0x400D543")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, UIHudMatchResultStateBase> m_States;

	[Token(Token = "0x400D544")]
	[FieldOffset(Offset = "0xC")]
	private UIHudMatchResultStateBase m_CurrentState;

	[Token(Token = "0x400D545")]
	[FieldOffset(Offset = "0x10")]
	private MatchStats m_MatchStatsData;

	[Token(Token = "0x400D546")]
	[FieldOffset(Offset = "0x14")]
	private MatchIncome m_MatchIncomeData;

	[Token(Token = "0x400D547")]
	[FieldOffset(Offset = "0x18")]
	private bool m_HasShowMVP;

	[Token(Token = "0x400D548")]
	[FieldOffset(Offset = "0x1C")]
	private TeammateStats m_MVPData;

	[Token(Token = "0x400D549")]
	[FieldOffset(Offset = "0x20")]
	private UIMaleAvatar m_MVPAvatar;

	[Token(Token = "0x400D54A")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsWin;

	[Token(Token = "0x400D54B")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_ResultBGCamera;

	[Token(Token = "0x400D54C")]
	[FieldOffset(Offset = "0x2C")]
	private Camera m_ResultAvatarCamera;

	[Token(Token = "0x400D54D")]
	[FieldOffset(Offset = "0x30")]
	private Camera m_ResultMVPCamera;

	[Token(Token = "0x400D54E")]
	[FieldOffset(Offset = "0x34")]
	private GameObject m_MVPRoomOB;

	[Token(Token = "0x400D54F")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_MVPCameraOB;

	[Token(Token = "0x400D550")]
	[FieldOffset(Offset = "0x3C")]
	private UIHudMatchResultStateMachineFinishDelegate fnStateMachineFinish;

	[Token(Token = "0x1700103B")]
	private Dictionary<int, UIHudMatchResultStateBase> States
	{
		[Token(Token = "0x600B93F")]
		[Address(RVA = "0x19C0984", Offset = "0x19C0984", VA = "0x19C0984")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103C")]
	public UIHudMatchResultStateBase CurrentState
	{
		[Token(Token = "0x600B940")]
		[Address(RVA = "0x19C0A5C", Offset = "0x19C0A5C", VA = "0x19C0A5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103D")]
	public MatchStats StatsData
	{
		[Token(Token = "0x600B941")]
		[Address(RVA = "0x19B1928", Offset = "0x19B1928", VA = "0x19B1928")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103E")]
	public MatchIncome IncomeData
	{
		[Token(Token = "0x600B942")]
		[Address(RVA = "0x19B1240", Offset = "0x19B1240", VA = "0x19B1240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700103F")]
	public bool HasShowMVP
	{
		[Token(Token = "0x600B943")]
		[Address(RVA = "0x19C0AB4", Offset = "0x19C0AB4", VA = "0x19C0AB4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B944")]
		[Address(RVA = "0x19BEEA4", Offset = "0x19BEEA4", VA = "0x19BEEA4")]
		set
		{
		}
	}

	[Token(Token = "0x17001040")]
	public TeammateStats MVPData
	{
		[Token(Token = "0x600B945")]
		[Address(RVA = "0x19BEDF4", Offset = "0x19BEDF4", VA = "0x19BEDF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001041")]
	public UIMaleAvatar MVPAvatar
	{
		[Token(Token = "0x600B946")]
		[Address(RVA = "0x19BEF84", Offset = "0x19BEF84", VA = "0x19BEF84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001042")]
	public bool IsWin
	{
		[Token(Token = "0x600B947")]
		[Address(RVA = "0x19BEE4C", Offset = "0x19BEE4C", VA = "0x19BEE4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001043")]
	public Camera ResultBGCamera
	{
		[Token(Token = "0x600B948")]
		[Address(RVA = "0x19C0B0C", Offset = "0x19C0B0C", VA = "0x19C0B0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001044")]
	public Camera ResultAvatarCamera
	{
		[Token(Token = "0x600B949")]
		[Address(RVA = "0x19C0B64", Offset = "0x19C0B64", VA = "0x19C0B64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001045")]
	public Camera ResultMVPCamera
	{
		[Token(Token = "0x600B94A")]
		[Address(RVA = "0x19C0BBC", Offset = "0x19C0BBC", VA = "0x19C0BBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B93E")]
	[Address(RVA = "0x19C02F8", Offset = "0x19C02F8", VA = "0x19C02F8")]
	public UIHudMatchResultStateMachine(MatchStats stats, MatchIncome income)
	{
	}

	[Token(Token = "0x600B94B")]
	[Address(RVA = "0x19B13C8", Offset = "0x19B13C8", VA = "0x19B13C8")]
	public void GoTo(EUIHudMatchResultState state)
	{
	}

	[Token(Token = "0x600B94C")]
	[Address(RVA = "0x19C0D50", Offset = "0x19C0D50", VA = "0x19C0D50")]
	public void InitData(TeammateStats mvpData, UIMaleAvatar avatar, Camera bgCamera, Camera avatarCamera, bool win, UIHudMatchResultStateMachineFinishDelegate fnFinish)
	{
	}

	[Token(Token = "0x600B94D")]
	[Address(RVA = "0x19BEFDC", Offset = "0x19BEFDC", VA = "0x19BEFDC")]
	public void SetMVPRoomObject(GameObject mvpRoom, GameObject mvpCameraOB)
	{
	}

	[Token(Token = "0x600B94E")]
	[Address(RVA = "0x19C0F94", Offset = "0x19C0F94", VA = "0x19C0F94")]
	public void DestroyMVPRoomObject()
	{
	}

	[Token(Token = "0x600B94F")]
	[Address(RVA = "0x19BD754", Offset = "0x19BD754", VA = "0x19BD754")]
	public bool CanShowMVP()
	{
		return default(bool);
	}

	[Token(Token = "0x600B950")]
	[Address(RVA = "0x19C0E00", Offset = "0x19C0E00", VA = "0x19C0E00")]
	public void EnableResultCamera(bool enable)
	{
	}

	[Token(Token = "0x600B951")]
	[Address(RVA = "0x19C0330", Offset = "0x19C0330", VA = "0x19C0330")]
	private void InitStates()
	{
	}

	[Token(Token = "0x600B952")]
	[Address(RVA = "0x19C085C", Offset = "0x19C085C", VA = "0x19C085C")]
	private void EnterStateMachine()
	{
	}

	[Token(Token = "0x600B953")]
	[Address(RVA = "0x19C0C14", Offset = "0x19C0C14", VA = "0x19C0C14")]
	private void ExitStateMachine()
	{
	}

	[Token(Token = "0x600B954")]
	[Address(RVA = "0x19C14C8", Offset = "0x19C14C8", VA = "0x19C14C8")]
	private void OnHandleStateFinish(object[] param)
	{
	}
}
