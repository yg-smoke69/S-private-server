using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F9D")]
public class PingCounter : MonoBehaviour
{
	[Token(Token = "0x401ACC3")]
	[FieldOffset(Offset = "0x0")]
	public static PingCounter instance;

	[Token(Token = "0x401ACC4")]
	[FieldOffset(Offset = "0xC")]
	private Queue<int> m_PingQueue;

	[Token(Token = "0x401ACC5")]
	[FieldOffset(Offset = "0x10")]
	private int m_TotalPingValue;

	[Token(Token = "0x401ACC6")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurPingValue;

	[Token(Token = "0x401ACC7")]
	[FieldOffset(Offset = "0x18")]
	private int m_TotalServerPingLag;

	[Token(Token = "0x401ACC8")]
	[FieldOffset(Offset = "0x1C")]
	private int m_TotalServerPingCount;

	[Token(Token = "0x401ACC9")]
	[FieldOffset(Offset = "0x20")]
	private int m_TotalServerPingLagB500;

	[Token(Token = "0x401ACCA")]
	[FieldOffset(Offset = "0x24")]
	private int m_TotalServerPingCountB500;

	[Token(Token = "0x401ACCB")]
	[FieldOffset(Offset = "0x28")]
	private int m_TotalServerPingLag100_200;

	[Token(Token = "0x401ACCC")]
	[FieldOffset(Offset = "0x2C")]
	private int m_TotalServerPingCount100_200;

	[Token(Token = "0x401ACCD")]
	[FieldOffset(Offset = "0x30")]
	private int m_TotalServerPingLag200_300;

	[Token(Token = "0x401ACCE")]
	[FieldOffset(Offset = "0x34")]
	private int m_TotalServerPingCount200_300;

	[Token(Token = "0x401ACCF")]
	[FieldOffset(Offset = "0x38")]
	private int m_TotalServerPingLag300_400;

	[Token(Token = "0x401ACD0")]
	[FieldOffset(Offset = "0x3C")]
	private int m_TotalServerPingCount300_400;

	[Token(Token = "0x401ACD1")]
	[FieldOffset(Offset = "0x40")]
	private int m_TotalServerPingLag400_500;

	[Token(Token = "0x401ACD2")]
	[FieldOffset(Offset = "0x44")]
	private int m_TotalServerPingCount400_500;

	[Token(Token = "0x401ACD3")]
	[FieldOffset(Offset = "0x48")]
	private int m_TotalServerPingLagA500;

	[Token(Token = "0x401ACD4")]
	[FieldOffset(Offset = "0x4C")]
	private int m_TotalServerPingCountA500;

	[Token(Token = "0x401ACD5")]
	[FieldOffset(Offset = "0x50")]
	private int m_MaxServerPing;

	[Token(Token = "0x401ACD6")]
	[FieldOffset(Offset = "0x54")]
	private bool m_StartToCollectPing;

	[Token(Token = "0x401ACD7")]
	[FieldOffset(Offset = "0x58")]
	private float m_StartShowTime;

	[Token(Token = "0x401ACD8")]
	[FieldOffset(Offset = "0x5C")]
	private int m_LastSendPingCount;

	[Token(Token = "0x401ACD9")]
	[FieldOffset(Offset = "0x60")]
	private bool m_LastPingBack;

	[Token(Token = "0x401ACDA")]
	[FieldOffset(Offset = "0x4")]
	public static int PING_COUNT;

	[Token(Token = "0x401ACDB")]
	[FieldOffset(Offset = "0x8")]
	public static int PING_MAXVALUE;

	[Token(Token = "0x6019E1A")]
	[Address(RVA = "0x2982FC0", Offset = "0x2982FC0", VA = "0x2982FC0")]
	public PingCounter()
	{
	}

	[Token(Token = "0x6019E1B")]
	[Address(RVA = "0x298304C", Offset = "0x298304C", VA = "0x298304C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019E1C")]
	[Address(RVA = "0x2983128", Offset = "0x2983128", VA = "0x2983128")]
	public void PingSent(int sendCount)
	{
	}

	[Token(Token = "0x6019E1D")]
	[Address(RVA = "0x29835C8", Offset = "0x29835C8", VA = "0x29835C8")]
	public void PushPingPack(int sendCount)
	{
	}

	[Token(Token = "0x6019E1E")]
	[Address(RVA = "0x29831DC", Offset = "0x29831DC", VA = "0x29831DC")]
	public void PushPingValue(int value)
	{
	}

	[Token(Token = "0x6019E1F")]
	[Address(RVA = "0x298375C", Offset = "0x298375C", VA = "0x298375C")]
	public int CurrentPingValue()
	{
		return default(int);
	}

	[Token(Token = "0x6019E20")]
	[Address(RVA = "0x298379C", Offset = "0x298379C", VA = "0x298379C")]
	public void StartCountToServer()
	{
	}

	[Token(Token = "0x6019E21")]
	[Address(RVA = "0x29837A8", Offset = "0x29837A8", VA = "0x29837A8")]
	public void PopPingToServer(out int average, out int max, out int avgB500, out int count100200, out int count200300, out int count300400, out int count400500, out int countA500, out int total)
	{
	}

	[Token(Token = "0x6019E22")]
	[Address(RVA = "0x2983894", Offset = "0x2983894", VA = "0x2983894")]
	public void Clear()
	{
	}
}
