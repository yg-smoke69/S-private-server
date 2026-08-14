using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004095")]
public class TCPSession : NetworkSession
{
	[Token(Token = "0x401B226")]
	[FieldOffset(Offset = "0x38")]
	private TcpClient m_TCPConnection;

	[Token(Token = "0x401B227")]
	[FieldOffset(Offset = "0x3C")]
	private NetworkByteStream m_RecvBuffer;

	[Token(Token = "0x401B228")]
	[FieldOffset(Offset = "0x40")]
	private MemoryStream m_RecvRemainingBuffer;

	[Token(Token = "0x401B229")]
	[FieldOffset(Offset = "0x44")]
	private object m_ConnectedRetRequiredLock;

	[Token(Token = "0x401B22A")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HasConnectedRetRequired;

	[Token(Token = "0x401B22B")]
	[FieldOffset(Offset = "0x50")]
	private double m_KeepAliveInterval;

	[Token(Token = "0x401B22C")]
	[FieldOffset(Offset = "0x58")]
	private double m_MaxDeactiveTime;

	[Token(Token = "0x401B22D")]
	[FieldOffset(Offset = "0x60")]
	private object m_LastAliveTimeLock;

	[Token(Token = "0x401B22E")]
	[FieldOffset(Offset = "0x68")]
	private double m_LastAliveTime;

	[Token(Token = "0x401B22F")]
	[FieldOffset(Offset = "0x70")]
	private Thread m_KeepAliveThread;

	[Token(Token = "0x401B230")]
	[FieldOffset(Offset = "0x74")]
	private AutoResetEvent m_KeepAliveSignalEvent;

	[Token(Token = "0x401B231")]
	[FieldOffset(Offset = "0x78")]
	private int m_ReceiveBufferSize;

	[Token(Token = "0x401B232")]
	[FieldOffset(Offset = "0x7C")]
	private int m_SendBufferSize;

	[Token(Token = "0x401B233")]
	[FieldOffset(Offset = "0x80")]
	private string m_Token;

	[Token(Token = "0x401B234")]
	[FieldOffset(Offset = "0x84")]
	private Queue<TCPMsgPacket> m_SendPacketQueue;

	[Token(Token = "0x401B235")]
	[FieldOffset(Offset = "0x88")]
	private Queue<TCPMsgPacket> m_RecvPacketQueue;

	[Token(Token = "0x401B236")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_ServerConfirmed;

	[Token(Token = "0x401B237")]
	[FieldOffset(Offset = "0x8D")]
	private bool m_IsPaused;

	[Token(Token = "0x401B238")]
	[FieldOffset(Offset = "0x90")]
	private double m_LastPausedTime;

	[Token(Token = "0x401B239")]
	[FieldOffset(Offset = "0x98")]
	private double m_MaxBackgroundDeactiveTime;

	[Token(Token = "0x401B23A")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_IsInBackGround;

	[Token(Token = "0x401B23B")]
	[FieldOffset(Offset = "0xA4")]
	private AesManaged m_Aes;

	[Token(Token = "0x601A483")]
	[Address(RVA = "0x3231198", Offset = "0x3231198", VA = "0x3231198")]
	public TCPSession(string token, [Optional] ISessionHanlder cb)
	{
	}

	[Token(Token = "0x601A484")]
	[Address(RVA = "0x32398C8", Offset = "0x32398C8", VA = "0x32398C8")]
	private AesManaged CreateAes()
	{
		return null;
	}

	[Token(Token = "0x601A485")]
	[Address(RVA = "0x32321A8", Offset = "0x32321A8", VA = "0x32321A8")]
	public void GetTCPPackets(Queue<TCPMsgPacket> outPackets)
	{
	}

	[Token(Token = "0x601A486")]
	[Address(RVA = "0x3231BB0", Offset = "0x3231BB0", VA = "0x3231BB0")]
	public void Send(byte cmd, byte[] data, int byteCount, byte region)
	{
	}

	[Token(Token = "0x601A487")]
	[Address(RVA = "0x323A2CC", Offset = "0x323A2CC", VA = "0x323A2CC")]
	private void CreateHeartBeatThread()
	{
	}

	[Token(Token = "0x601A488")]
	[Address(RVA = "0x323A404", Offset = "0x323A404", VA = "0x323A404", Slot = "5")]
	protected override bool OnConnect(string serverAddr, int port)
	{
		return default(bool);
	}

	[Token(Token = "0x601A489")]
	[Address(RVA = "0x323AA6C", Offset = "0x323AA6C", VA = "0x323AA6C", Slot = "6")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x601A48A")]
	[Address(RVA = "0x323AC38", Offset = "0x323AC38", VA = "0x323AC38", Slot = "7")]
	protected override void OnClose()
	{
	}

	[Token(Token = "0x601A48B")]
	[Address(RVA = "0x323AE0C", Offset = "0x323AE0C", VA = "0x323AE0C")]
	private void OnConnected(IAsyncResult ar)
	{
	}

	[Token(Token = "0x601A48C")]
	[Address(RVA = "0x323B174", Offset = "0x323B174", VA = "0x323B174")]
	private void OnRecvDataThread()
	{
	}

	[Token(Token = "0x601A48D")]
	[Address(RVA = "0x323C1E8", Offset = "0x323C1E8", VA = "0x323C1E8")]
	private void OnSendDataThread()
	{
	}

	[Token(Token = "0x601A48E")]
	[Address(RVA = "0x323C9E4", Offset = "0x323C9E4", VA = "0x323C9E4")]
	private void OnKeepAliveThread()
	{
	}

	[Token(Token = "0x601A48F")]
	[Address(RVA = "0x3232320", Offset = "0x3232320", VA = "0x3232320")]
	public void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x601A490")]
	[Address(RVA = "0x3239F2C", Offset = "0x3239F2C", VA = "0x3239F2C")]
	public byte[] Encrypt(AesManaged aes, byte[] data)
	{
		return null;
	}

	[Token(Token = "0x601A491")]
	[Address(RVA = "0x323D160", Offset = "0x323D160", VA = "0x323D160")]
	public byte[] Decrypt(AesManaged aes, byte[] data)
	{
		return null;
	}
}
