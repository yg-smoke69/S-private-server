using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040A5")]
internal class UDPReliableTracking
{
	[Token(Token = "0x20040A6")]
	public class CircularValue
	{
		[Token(Token = "0x601A4E2")]
		[Address(RVA = "0x324717C", Offset = "0x324717C", VA = "0x324717C")]
		public CircularValue()
		{
		}

		[Token(Token = "0x601A4E3")]
		[Address(RVA = "0x32469F0", Offset = "0x32469F0", VA = "0x32469F0")]
		public static ushort Inc(ushort v, ushort step, ushort maxValue = ushort.MaxValue)
		{
			return default(ushort);
		}

		[Token(Token = "0x601A4E4")]
		[Address(RVA = "0x3245AF0", Offset = "0x3245AF0", VA = "0x3245AF0")]
		public static bool Greater(ushort v1, ushort v2, ushort maxValue = ushort.MaxValue)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20040A7")]
	public enum RECVRET
	{
		[Token(Token = "0x401B291")]
		ENQUEUE,
		[Token(Token = "0x401B292")]
		PENDING,
		[Token(Token = "0x401B293")]
		DROP
	}

	[Token(Token = "0x20040A8")]
	private class PacketTrackingDataComparer : _Attribute
	{
		[Token(Token = "0x601A4E5")]
		[Address(RVA = "0x3247174", Offset = "0x3247174", VA = "0x3247174")]
		public PacketTrackingDataComparer()
		{
		}

		[Token(Token = "0x601A4E6")]
		[Address(RVA = "0x3247184", Offset = "0x3247184", VA = "0x3247184", Slot = "4")]
		public int Compare(UDPMsgPacketTrackingData x, UDPMsgPacketTrackingData y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x401B284")]
	public const ushort MAX_SEQUENCE_ID = ushort.MaxValue;

	[Token(Token = "0x401B285")]
	public const ushort MAX_ORDER_ID = ushort.MaxValue;

	[Token(Token = "0x401B286")]
	[FieldOffset(Offset = "0x8")]
	private ushort m_LocalSequenceID;

	[Token(Token = "0x401B287")]
	[FieldOffset(Offset = "0xA")]
	private ushort m_LocalOrderID;

	[Token(Token = "0x401B288")]
	[FieldOffset(Offset = "0xC")]
	private ushort m_RequiredOrderID;

	[Token(Token = "0x401B289")]
	[FieldOffset(Offset = "0x10")]
	private object m_Locker;

	[Token(Token = "0x401B28A")]
	[FieldOffset(Offset = "0x14")]
	private bool m_FlushForLongDeactiveTime;

	[Token(Token = "0x401B28B")]
	[FieldOffset(Offset = "0x18")]
	private double m_LastFlushTime;

	[Token(Token = "0x401B28C")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<UDPMsgPacket, UDPMsgPacketResendInfo> m_ResendPacketInfo;

	[Token(Token = "0x401B28D")]
	[FieldOffset(Offset = "0x24")]
	private LinkedList<UDPMsgPacketTrackingData> m_PendingAckPacket;

	[Token(Token = "0x401B28E")]
	[FieldOffset(Offset = "0x28")]
	private LinkedList<ushort> m_AckSent;

	[Token(Token = "0x401B28F")]
	[FieldOffset(Offset = "0x0")]
	private static PacketTrackingDataComparer m_PacketTrackingDataComparer;

	[Token(Token = "0x17001CC6")]
	public bool NeedFlushForLongDeactiveTime
	{
		[Token(Token = "0x601A4D2")]
		[Address(RVA = "0x3244CD0", Offset = "0x3244CD0", VA = "0x3244CD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A4D1")]
	[Address(RVA = "0x3244BAC", Offset = "0x3244BAC", VA = "0x3244BAC")]
	public UDPReliableTracking()
	{
	}

	[Token(Token = "0x601A4D3")]
	[Address(RVA = "0x3244CD8", Offset = "0x3244CD8", VA = "0x3244CD8")]
	public bool Update(ref List<UDPMsgPacket> packetToResend)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4D4")]
	[Address(RVA = "0x3245C74", Offset = "0x3245C74", VA = "0x3245C74")]
	private void FastResendOldRUDP(UDPMsgPacket msg)
	{
	}

	[Token(Token = "0x601A4D5")]
	[Address(RVA = "0x3245F10", Offset = "0x3245F10", VA = "0x3245F10")]
	private bool CheckAck(ushort seq, ushort ack, uint ackBits)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4D6")]
	[Address(RVA = "0x3245FBC", Offset = "0x3245FBC", VA = "0x3245FBC")]
	public void HandleAck(ushort ack, uint ackBits)
	{
	}

	[Token(Token = "0x601A4D7")]
	[Address(RVA = "0x3246618", Offset = "0x3246618", VA = "0x3246618")]
	public void AckSent(ushort sequenceID)
	{
	}

	[Token(Token = "0x601A4D8")]
	[Address(RVA = "0x32468DC", Offset = "0x32468DC", VA = "0x32468DC")]
	public RECVRET PacketRecv(UDPMsgPacket packet)
	{
		return default(RECVRET);
	}

	[Token(Token = "0x601A4D9")]
	[Address(RVA = "0x3246A10", Offset = "0x3246A10", VA = "0x3246A10")]
	public void ApplyReliableInfo(UDPMsgPacket packet)
	{
	}

	[Token(Token = "0x601A4DA")]
	[Address(RVA = "0x3245F80", Offset = "0x3245F80", VA = "0x3245F80")]
	private int bitIndexForSequence(ushort seq, ushort ack)
	{
		return default(int);
	}

	[Token(Token = "0x601A4DB")]
	[Address(RVA = "0x3245F98", Offset = "0x3245F98", VA = "0x3245F98")]
	private bool checkAckBits(uint ackBits, int bitIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x601A4DC")]
	[Address(RVA = "0x3246DF8", Offset = "0x3246DF8", VA = "0x3246DF8")]
	private uint addAckBits(uint ackBits, int bitIndex)
	{
		return default(uint);
	}

	[Token(Token = "0x601A4DD")]
	[Address(RVA = "0x3246E10", Offset = "0x3246E10", VA = "0x3246E10")]
	public uint GenAckBits(ushort ack)
	{
		return default(uint);
	}

	[Token(Token = "0x601A4DE")]
	[Address(RVA = "0x3247058", Offset = "0x3247058", VA = "0x3247058")]
	public void UpdateActiveTime(double last, double current)
	{
	}

	[Token(Token = "0x601A4DF")]
	[Address(RVA = "0x3245B2C", Offset = "0x3245B2C", VA = "0x3245B2C")]
	public static void SortByTrackingID(LinkedList<UDPMsgPacketTrackingData> list)
	{
	}

	[Token(Token = "0x601A4E0")]
	private static void Sort<T>(LinkedListNode<T> head, LinkedListNode<T> tail, IComparer<T> comparer)
	{
	}

	[Token(Token = "0x601A4E1")]
	private static void Swap<T>(LinkedListNode<T> a, LinkedListNode<T> b)
	{
	}
}
