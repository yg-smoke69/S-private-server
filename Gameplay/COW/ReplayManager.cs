using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000A62")]
internal class ReplayManager : SingletonModule<ReplayManager>
{
	[Token(Token = "0x4005C00")]
	private const int MS_TO_TICK = 10000;

	[Token(Token = "0x4005C01")]
	private const float S_TO_MS = 1000f;

	[Token(Token = "0x4005C02")]
	[FieldOffset(Offset = "0xC")]
	private FileStream m_ReplayFileStream;

	[Token(Token = "0x4005C03")]
	[FieldOffset(Offset = "0x10")]
	private BinaryWriter m_ReplayBinaryWriter;

	[Token(Token = "0x4005C04")]
	[FieldOffset(Offset = "0x14")]
	private BinaryReader m_ReplayBinaryReader;

	[Token(Token = "0x4005C05")]
	[FieldOffset(Offset = "0x18")]
	private ReplayData m_ReplayData;

	[Token(Token = "0x4005C06")]
	[FieldOffset(Offset = "0x1C")]
	private ReplayInfo m_CurReplayInfo;

	[Token(Token = "0x4005C07")]
	[FieldOffset(Offset = "0x20")]
	private long m_GameTotalTimeMS;

	[Token(Token = "0x4005C08")]
	[FieldOffset(Offset = "0x28")]
	private EReplayState m_CurState;

	[Token(Token = "0x4005C09")]
	[FieldOffset(Offset = "0x30")]
	private long m_StartTimeMS;

	[Token(Token = "0x4005C0A")]
	[FieldOffset(Offset = "0x38")]
	private string m_MatchDateTime;

	[Token(Token = "0x4005C0B")]
	[FieldOffset(Offset = "0x3C")]
	private Action m_ReplayJumpCallBack;

	[Token(Token = "0x4005C0C")]
	[FieldOffset(Offset = "0x40")]
	private long m_ReplayTimeMS;

	[Token(Token = "0x4005C0D")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Started;

	[Token(Token = "0x4005C0E")]
	[FieldOffset(Offset = "0x4C")]
	private Queue<ReplayData> m_ReplayDataQueue;

	[Token(Token = "0x4005C0F")]
	[FieldOffset(Offset = "0x50")]
	private ReplayCamState m_ReplayCamState;

	[Token(Token = "0x4005C10")]
	[FieldOffset(Offset = "0x90")]
	private bool m_HasMatchEnd;

	[Token(Token = "0x4005C11")]
	[FieldOffset(Offset = "0x94")]
	private List<ReplayInfo> m_CachedReplayInfo;

	[Token(Token = "0x4005C12")]
	[FieldOffset(Offset = "0x98")]
	private bool m_Changed;

	[Token(Token = "0x4005C13")]
	[FieldOffset(Offset = "0x99")]
	private bool m_ReplayPaused;

	[Token(Token = "0x4005C14")]
	[FieldOffset(Offset = "0x9C")]
	private int m_CurSpeed;

	[Token(Token = "0x4005C15")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_IsJumping;

	[Token(Token = "0x4005C16")]
	[FieldOffset(Offset = "0xA8")]
	private long m_DestTimeMS;

	[Token(Token = "0x4005C17")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<int, float> m_LevelSpeedDic;

	[Token(Token = "0x17000637")]
	public bool IsJumping
	{
		[Token(Token = "0x6005070")]
		[Address(RVA = "0x240465C", Offset = "0x240465C", VA = "0x240465C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600505B")]
	[Address(RVA = "0x2401054", Offset = "0x2401054", VA = "0x2401054")]
	public ReplayManager()
	{
	}

	[Token(Token = "0x600505C")]
	[Address(RVA = "0x2401284", Offset = "0x2401284", VA = "0x2401284", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600505D")]
	[Address(RVA = "0x2401430", Offset = "0x2401430", VA = "0x2401430", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600505E")]
	[Address(RVA = "0x2401528", Offset = "0x2401528", VA = "0x2401528")]
	public void OnStarted()
	{
	}

	[Token(Token = "0x600505F")]
	[Address(RVA = "0x240272C", Offset = "0x240272C", VA = "0x240272C")]
	public void OnEnded()
	{
	}

	[Token(Token = "0x6005060")]
	[Address(RVA = "0x240182C", Offset = "0x240182C", VA = "0x240182C")]
	private void OnRecordStarted()
	{
	}

	[Token(Token = "0x6005061")]
	[Address(RVA = "0x24032F8", Offset = "0x24032F8", VA = "0x24032F8")]
	public void OnMatchEnd()
	{
	}

	[Token(Token = "0x6005062")]
	[Address(RVA = "0x24027D4", Offset = "0x24027D4", VA = "0x24027D4")]
	public void OnRecordEnded()
	{
	}

	[Token(Token = "0x6005063")]
	[Address(RVA = "0x2403368", Offset = "0x2403368", VA = "0x2403368")]
	public void RecordPackets(Queue<UDPMsgPacket> queue)
	{
	}

	[Token(Token = "0x6005064")]
	[Address(RVA = "0x2403538", Offset = "0x2403538", VA = "0x2403538")]
	public float CurTimeSec()
	{
		return default(float);
	}

	[Token(Token = "0x6005065")]
	[Address(RVA = "0x24031F4", Offset = "0x24031F4", VA = "0x24031F4")]
	private long GetNowTimeMS()
	{
		return default(long);
	}

	[Token(Token = "0x6005066")]
	[Address(RVA = "0x24016C0", Offset = "0x24016C0", VA = "0x24016C0")]
	private void OnReplayStarted()
	{
	}

	[Token(Token = "0x6005067")]
	[Address(RVA = "0x2403078", Offset = "0x2403078", VA = "0x2403078")]
	private void OnReplayEnded()
	{
	}

	[Token(Token = "0x6005068")]
	[Address(RVA = "0x24035BC", Offset = "0x24035BC", VA = "0x24035BC")]
	public void GetReplayPackets(Queue<UDPMsgPacket> outPackets)
	{
	}

	[Token(Token = "0x6005069")]
	[Address(RVA = "0x24039B8", Offset = "0x24039B8", VA = "0x24039B8")]
	public ulong GetReplayMatchID()
	{
		return default(ulong);
	}

	[Token(Token = "0x600506A")]
	[Address(RVA = "0x2403A2C", Offset = "0x2403A2C", VA = "0x2403A2C")]
	public List<ReplayInfo> GetReplayList()
	{
		return null;
	}

	[Token(Token = "0x600506B")]
	[Address(RVA = "0x2403B0C", Offset = "0x2403B0C", VA = "0x2403B0C")]
	private void ReadReplayList()
	{
	}

	[Token(Token = "0x600506C")]
	[Address(RVA = "0x2403E34", Offset = "0x2403E34", VA = "0x2403E34")]
	public ReplayInfo ReadReplayInfoByFilePath(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600506D")]
	[Address(RVA = "0x2403F0C", Offset = "0x2403F0C", VA = "0x2403F0C")]
	public void DelReplay(ReplayInfo info)
	{
	}

	[Token(Token = "0x600506E")]
	[Address(RVA = "0x2404098", Offset = "0x2404098", VA = "0x2404098")]
	public void ResetReplay()
	{
	}

	[Token(Token = "0x600506F")]
	[Address(RVA = "0x24040F4", Offset = "0x24040F4", VA = "0x24040F4")]
	public void StartReplay(ReplayInfo info)
	{
	}

	[Token(Token = "0x6005071")]
	[Address(RVA = "0x24046B4", Offset = "0x24046B4", VA = "0x24046B4")]
	public void PauseReplay(bool pause)
	{
	}

	[Token(Token = "0x6005072")]
	[Address(RVA = "0x24047C0", Offset = "0x24047C0", VA = "0x24047C0")]
	public void SetPlaySpeed(bool fast)
	{
	}

	[Token(Token = "0x6005073")]
	[Address(RVA = "0x2400730", Offset = "0x2400730", VA = "0x2400730")]
	public void GoToTimePoint(float value, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6005074")]
	[Address(RVA = "0x2404CD8", Offset = "0x2404CD8", VA = "0x2404CD8")]
	public long CurrentGameTime()
	{
		return default(long);
	}

	[Token(Token = "0x6005075")]
	[Address(RVA = "0x2404D30", Offset = "0x2404D30", VA = "0x2404D30")]
	public float CurrentProgress()
	{
		return default(float);
	}

	[Token(Token = "0x6005076")]
	[Address(RVA = "0x2404C50", Offset = "0x2404C50", VA = "0x2404C50")]
	public long GetGameTimeMS(float value)
	{
		return default(long);
	}

	[Token(Token = "0x6005077")]
	[Address(RVA = "0x2404DB4", Offset = "0x2404DB4", VA = "0x2404DB4")]
	public float GetTimeRatio(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6005078")]
	[Address(RVA = "0x2404E44", Offset = "0x2404E44", VA = "0x2404E44")]
	public void SetState(EReplayState state)
	{
	}

	[Token(Token = "0x6005079")]
	[Address(RVA = "0x24017C8", Offset = "0x24017C8", VA = "0x24017C8")]
	public bool IsRecordState()
	{
		return default(bool);
	}

	[Token(Token = "0x600507A")]
	[Address(RVA = "0x2401654", Offset = "0x2401654", VA = "0x2401654")]
	public bool IsReplayState()
	{
		return default(bool);
	}

	[Token(Token = "0x600507B")]
	[Address(RVA = "0x2404EA4", Offset = "0x2404EA4", VA = "0x2404EA4")]
	public List<ReplayEvent> GetReplayEventList()
	{
		return null;
	}

	[Token(Token = "0x600507C")]
	[Address(RVA = "0x2404F14", Offset = "0x2404F14", VA = "0x2404F14")]
	private void _003CGoToTimePoint_003Em__0()
	{
	}
}
