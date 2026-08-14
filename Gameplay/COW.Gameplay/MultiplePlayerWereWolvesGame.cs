using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.Gameplay;

[Token(Token = "0x200085A")]
internal class MultiplePlayerWereWolvesGame : HBNIDAFBOBL
{
	[Token(Token = "0x200085B")]
	public enum EChatShowType
	{
		[Token(Token = "0x4005257")]
		Normal,
		[Token(Token = "0x4005258")]
		Vote,
		[Token(Token = "0x4005259")]
		DeadInfo,
		[Token(Token = "0x400525A")]
		RoundInfo
	}

	[Token(Token = "0x200085C")]
	public class WereWolvesChatEasyListInfo
	{
		[Token(Token = "0x400525B")]
		[FieldOffset(Offset = "0x8")]
		public IHAAMHPPLMG PlayerId;

		[Token(Token = "0x400525C")]
		[FieldOffset(Offset = "0x20")]
		public string ChatString;

		[Token(Token = "0x400525D")]
		[FieldOffset(Offset = "0x24")]
		public int SendTime;

		[Token(Token = "0x400525E")]
		[FieldOffset(Offset = "0x28")]
		public EChatShowType ChatShowType;

		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x24A9C54", Offset = "0x24A9C54", VA = "0x24A9C54")]
		public WereWolvesChatEasyListInfo()
		{
		}
	}

	[Token(Token = "0x200085D")]
	private sealed class _003CFilterInvalidChatInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400525F")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG playerId;

		[Token(Token = "0x6003AA5")]
		[Address(RVA = "0x24AB478", Offset = "0x24AB478", VA = "0x24AB478")]
		public _003CFilterInvalidChatInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6003AA6")]
		[Address(RVA = "0x24AB644", Offset = "0x24AB644", VA = "0x24AB644")]
		internal bool _003C_003Em__0(WereWolvesChatEasyListInfo chatInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4005242")]
	[FieldOffset(Offset = "0xDC")]
	public Dictionary<int, Color32> PlayerColorMap;

	[Token(Token = "0x4005243")]
	[FieldOffset(Offset = "0xE0")]
	private NBKFCALDDNN m_TaskManager;

	[Token(Token = "0x4005244")]
	[FieldOffset(Offset = "0xE4")]
	private WereWolvesBodyManager m_BodyManager;

	[Token(Token = "0x4005245")]
	[FieldOffset(Offset = "0xE8")]
	private List<WereWolvesChatEasyListInfo> m_ChatInfos;

	[Token(Token = "0x4005246")]
	[FieldOffset(Offset = "0xEC")]
	private AKKLKEIAKEO m_VoteManager;

	[Token(Token = "0x4005247")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<string, WereWolvesRoleData> m_RoleMap;

	[Token(Token = "0x4005248")]
	[FieldOffset(Offset = "0xF4")]
	private List<WereWolvesQuickChatData> m_QuickChatList;

	[Token(Token = "0x4005249")]
	[FieldOffset(Offset = "0xF8")]
	private Dictionary<uint, WereWolvesQuickChatData> m_QuickChatDataDic;

	[Token(Token = "0x400524A")]
	[FieldOffset(Offset = "0xFC")]
	private List<WereWolvesQuickChatData> m_QuickChatNoTargetList;

	[Token(Token = "0x400524B")]
	[FieldOffset(Offset = "0x100")]
	private List<WereWolvesQuickChatData> m_QuickChatTargetList;

	[Token(Token = "0x400524C")]
	[FieldOffset(Offset = "0x104")]
	private float m_LastChatTime;

	[Token(Token = "0x400524D")]
	[FieldOffset(Offset = "0x108")]
	private bool m_IsPlayerManualMute;

	[Token(Token = "0x400524E")]
	[FieldOffset(Offset = "0x109")]
	private bool m_IsInitedCameraPivot;

	[Token(Token = "0x400524F")]
	[FieldOffset(Offset = "0x10C")]
	private GameObject m_LocalPlayerCircleEffect;

	[Token(Token = "0x4005250")]
	[FieldOffset(Offset = "0x110")]
	private int m_ClientChatRound;

	[Token(Token = "0x4005251")]
	[FieldOffset(Offset = "0x114")]
	private AudioResource m_loopAlertSound;

	[Token(Token = "0x4005252")]
	[FieldOffset(Offset = "0x118")]
	private List<PreparePhaseCameraPivot> m_PreparePhaseCameraPivotList;

	[Token(Token = "0x4005253")]
	[FieldOffset(Offset = "0x11C")]
	private OOFDPCCNDJO m_CachedMatchEndInfo;

	[Token(Token = "0x4005254")]
	[FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<IHAAMHPPLMG, Player>, PlayerWereWolves> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4005255")]
	[FieldOffset(Offset = "0x4")]
	private static Func<PlayerWereWolves, bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17000405")]
	public List<WereWolvesChatEasyListInfo> ChatInfos
	{
		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x24A5568", Offset = "0x24A5568", VA = "0x24A5568")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000406")]
	public WereWolvesBodyManager BodyManager
	{
		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x24A5570", Offset = "0x24A5570", VA = "0x24A5570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000407")]
	public Dictionary<string, WereWolvesRoleData> RoleDatas
	{
		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x24A5588", Offset = "0x24A5588", VA = "0x24A5588")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000408")]
	public MMOHBDPIKLC GameOverFlag
	{
		[Token(Token = "0x6003A70")]
		[Address(RVA = "0x24A5590", Offset = "0x24A5590", VA = "0x24A5590")]
		get
		{
			return default(MMOHBDPIKLC);
		}
	}

	[Token(Token = "0x17000409")]
	public List<WereWolvesQuickChatData> QuickChatList
	{
		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x24A56FC", Offset = "0x24A56FC", VA = "0x24A56FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040A")]
	public List<WereWolvesQuickChatData> QuickChatNoTargetList
	{
		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x24A5704", Offset = "0x24A5704", VA = "0x24A5704")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040B")]
	public List<WereWolvesQuickChatData> QuickChatTargetList
	{
		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x24A570C", Offset = "0x24A570C", VA = "0x24A570C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040C")]
	public bool InChatCD
	{
		[Token(Token = "0x6003A75")]
		[Address(RVA = "0x24A5714", Offset = "0x24A5714", VA = "0x24A5714")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700040D")]
	public bool IsPlayerManualMute
	{
		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x24A582C", Offset = "0x24A582C", VA = "0x24A582C")]
		set
		{
		}
	}

	[Token(Token = "0x1700040E")]
	public OOFDPCCNDJO CachedMatchEndInfo
	{
		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x24AB3C4", Offset = "0x24AB3C4", VA = "0x24AB3C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003A6A")]
	[Address(RVA = "0x24A5034", Offset = "0x24A5034", VA = "0x24A5034")]
	public MultiplePlayerWereWolvesGame()
	{
	}

	[Token(Token = "0x6003A6D")]
	[Address(RVA = "0x24A5578", Offset = "0x24A5578", VA = "0x24A5578")]
	public NBKFCALDDNN GetTaskManager()
	{
		return null;
	}

	[Token(Token = "0x6003A6E")]
	[Address(RVA = "0x24A5580", Offset = "0x24A5580", VA = "0x24A5580")]
	public AKKLKEIAKEO GetVoteManager()
	{
		return null;
	}

	[Token(Token = "0x6003A71")]
	[Address(RVA = "0x24A566C", Offset = "0x24A566C", VA = "0x24A566C", Slot = "19")]
	public override Type GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x6003A77")]
	[Address(RVA = "0x24A5834", Offset = "0x24A5834", VA = "0x24A5834", Slot = "8")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6003A78")]
	[Address(RVA = "0x24A611C", Offset = "0x24A611C", VA = "0x24A611C", Slot = "54")]
	public override void OnAddPlayer(Player p)
	{
	}

	[Token(Token = "0x6003A79")]
	[Address(RVA = "0x24A68EC", Offset = "0x24A68EC", VA = "0x24A68EC", Slot = "20")]
	public override ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x6003A7A")]
	[Address(RVA = "0x24A68F4", Offset = "0x24A68F4", VA = "0x24A68F4", Slot = "21")]
	public override ResourceID[] GetAudioPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x6003A7B")]
	[Address(RVA = "0x24A68FC", Offset = "0x24A68FC", VA = "0x24A68FC", Slot = "22")]
	public override IEnumerator PreloadUmas()
	{
		return null;
	}

	[Token(Token = "0x6003A7C")]
	[Address(RVA = "0x24A62B0", Offset = "0x24A62B0", VA = "0x24A62B0")]
	private void ChooseLocalPlayerPrepareCameraPivot(Vector3 playerForward)
	{
	}

	[Token(Token = "0x6003A7D")]
	[Address(RVA = "0x24A66C0", Offset = "0x24A66C0", VA = "0x24A66C0")]
	private void SpawnLocalPlayerCircleEffect(Transform playerTrans)
	{
	}

	[Token(Token = "0x6003A7E")]
	[Address(RVA = "0x24A5ED8", Offset = "0x24A5ED8", VA = "0x24A5ED8")]
	private void InitRoleData()
	{
	}

	[Token(Token = "0x6003A7F")]
	[Address(RVA = "0x24A6904", Offset = "0x24A6904", VA = "0x24A6904")]
	public uint GetCurrentWolfCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6003A80")]
	[Address(RVA = "0x24A69E0", Offset = "0x24A69E0", VA = "0x24A69E0")]
	public uint GetAllWolfCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6003A81")]
	[Address(RVA = "0x24A6ABC", Offset = "0x24A6ABC", VA = "0x24A6ABC")]
	public uint GetCurrentPoint()
	{
		return default(uint);
	}

	[Token(Token = "0x6003A82")]
	[Address(RVA = "0x24A6B98", Offset = "0x24A6B98", VA = "0x24A6B98")]
	public uint GetCivilWinPoint()
	{
		return default(uint);
	}

	[Token(Token = "0x6003A83")]
	[Address(RVA = "0x24A6C74", Offset = "0x24A6C74", VA = "0x24A6C74")]
	public int GetVoteCenterCDEndTimeMs()
	{
		return default(int);
	}

	[Token(Token = "0x6003A84")]
	[Address(RVA = "0x24A6D50", Offset = "0x24A6D50", VA = "0x24A6D50")]
	public int GetGameEndTimeMs()
	{
		return default(int);
	}

	[Token(Token = "0x6003A85")]
	[Address(RVA = "0x24A6E2C", Offset = "0x24A6E2C", VA = "0x24A6E2C")]
	public uint GetCurrentPhase()
	{
		return default(uint);
	}

	[Token(Token = "0x6003A86")]
	[Address(RVA = "0x24A6F0C", Offset = "0x24A6F0C", VA = "0x24A6F0C", Slot = "46")]
	protected override void InitGRIData()
	{
	}

	[Token(Token = "0x6003A87")]
	[Address(RVA = "0x24A7CE0", Offset = "0x24A7CE0", VA = "0x24A7CE0")]
	private void OnPhaseChanged(uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x6003A88")]
	[Address(RVA = "0x24A8A10", Offset = "0x24A8A10", VA = "0x24A8A10")]
	private void OnPointChanged(uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x6003A89")]
	[Address(RVA = "0x24A8AD0", Offset = "0x24A8AD0", VA = "0x24A8AD0", Slot = "53")]
	public override Player CreatePlayer(Transform container, ulong userID, ulong serviceGroupID, IHAAMHPPLMG playerID, bool isAI = false, [Optional] object syncInfo)
	{
		return null;
	}

	[Token(Token = "0x6003A8A")]
	[Address(RVA = "0x24A8C58", Offset = "0x24A8C58", VA = "0x24A8C58")]
	public int GetAlivePlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003A8B")]
	[Address(RVA = "0x24A8E38", Offset = "0x24A8E38", VA = "0x24A8E38")]
	public void OnKillCDChange(int oldValue, int newValue)
	{
	}

	[Token(Token = "0x6003A8C")]
	[Address(RVA = "0x24A90D4", Offset = "0x24A90D4", VA = "0x24A90D4")]
	private void OnAllWolfCountChange(uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x6003A8D")]
	[Address(RVA = "0x24A9194", Offset = "0x24A9194", VA = "0x24A9194")]
	private void OnCurrentWolfCountChange(uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x6003A8E")]
	[Address(RVA = "0x24A9254", Offset = "0x24A9254", VA = "0x24A9254")]
	public void OnSkillCDChange(int oldValue, int newValue)
	{
	}

	[Token(Token = "0x6003A8F")]
	[Address(RVA = "0x24A94F0", Offset = "0x24A94F0", VA = "0x24A94F0", Slot = "12")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003A90")]
	[Address(RVA = "0x24A9710", Offset = "0x24A9710", VA = "0x24A9710")]
	private void OnDelPlayer(object[] data)
	{
	}

	[Token(Token = "0x6003A91")]
	[Address(RVA = "0x24A99AC", Offset = "0x24A99AC", VA = "0x24A99AC")]
	public void OnAddVoteChat(IHAAMHPPLMG playerId, int votedTime, EChatShowType showType, bool needRefresh)
	{
	}

	[Token(Token = "0x6003A92")]
	[Address(RVA = "0x24A9C5C", Offset = "0x24A9C5C", VA = "0x24A9C5C")]
	private void PlayAlertSound()
	{
	}

	[Token(Token = "0x6003A93")]
	[Address(RVA = "0x24A9D38", Offset = "0x24A9D38", VA = "0x24A9D38")]
	private void StopPlayAlertSound()
	{
	}

	[Token(Token = "0x6003A94")]
	[Address(RVA = "0x24A9E0C", Offset = "0x24A9E0C", VA = "0x24A9E0C")]
	public void OnSyncTaskAlert(NNKEDHAMEIB msg)
	{
	}

	[Token(Token = "0x6003A95")]
	[Address(RVA = "0x24AA2E8", Offset = "0x24AA2E8", VA = "0x24AA2E8")]
	public void OnSyncQuickChat(JOCAAKBJEBI msg)
	{
	}

	[Token(Token = "0x6003A96")]
	[Address(RVA = "0x24AA720", Offset = "0x24AA720", VA = "0x24AA720")]
	public void OnSyncChat(KGMDIDOCBHE msg)
	{
	}

	[Token(Token = "0x6003A97")]
	[Address(RVA = "0x24AAA90", Offset = "0x24AAA90", VA = "0x24AAA90")]
	private int ChatCmp(WereWolvesChatEasyListInfo a, WereWolvesChatEasyListInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6003A98")]
	[Address(RVA = "0x24AAC9C", Offset = "0x24AAC9C", VA = "0x24AAC9C")]
	public void OnSyncVoice(EAMJPLPGGLG msg)
	{
	}

	[Token(Token = "0x6003A99")]
	[Address(RVA = "0x24AB0FC", Offset = "0x24AB0FC", VA = "0x24AB0FC")]
	private void OnMicrophoneChanged(object[] data)
	{
	}

	[Token(Token = "0x6003A9A")]
	[Address(RVA = "0x24AB1F8", Offset = "0x24AB1F8", VA = "0x24AB1F8")]
	public void RegistPreparePhaseCameraPivot(PreparePhaseCameraPivot pivot)
	{
	}

	[Token(Token = "0x6003A9B")]
	[Address(RVA = "0x24AB278", Offset = "0x24AB278", VA = "0x24AB278")]
	private void OnGameOverFlagCome(uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x6003A9D")]
	[Address(RVA = "0x24AB3CC", Offset = "0x24AB3CC", VA = "0x24AB3CC")]
	public void CachMatchEndInfo(OOFDPCCNDJO msg)
	{
	}

	[Token(Token = "0x6003A9E")]
	[Address(RVA = "0x24AB3D4", Offset = "0x24AB3D4", VA = "0x24AB3D4")]
	public void RefreshChatCD()
	{
	}

	[Token(Token = "0x6003A9F")]
	[Address(RVA = "0x24A8850", Offset = "0x24A8850", VA = "0x24A8850")]
	private void BeginTutorial()
	{
	}

	[Token(Token = "0x6003AA0")]
	[Address(RVA = "0x24A987C", Offset = "0x24A987C", VA = "0x24A987C")]
	private void FilterInvalidChatInfo(IHAAMHPPLMG playerId)
	{
	}

	[Token(Token = "0x6003AA1")]
	[Address(RVA = "0x24A8688", Offset = "0x24A8688", VA = "0x24A8688")]
	private void InsertRoundInfoToChatInfo()
	{
	}

	[Token(Token = "0x6003AA2")]
	[Address(RVA = "0x24AB480", Offset = "0x24AB480", VA = "0x24AB480")]
	private static PlayerWereWolves _003CGetAlivePlayerCount_003Em__0(KeyValuePair<IHAAMHPPLMG, Player> playerPair)
	{
		return null;
	}

	[Token(Token = "0x6003AA3")]
	[Address(RVA = "0x24AB55C", Offset = "0x24AB55C", VA = "0x24AB55C")]
	private static bool _003CGetAlivePlayerCount_003Em__1(PlayerWereWolves wPlayer)
	{
		return default(bool);
	}
}
