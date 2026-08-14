using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003FC4")]
public class RemoteConsoleBase : MonoBehaviour
{
	[Token(Token = "0x2003FC5")]
	public delegate void ConsoleCommand(string param);

	[Token(Token = "0x401AD58")]
	[FieldOffset(Offset = "0x0")]
	public static RemoteConsoleBase instance;

	[Token(Token = "0x401AD59")]
	[FieldOffset(Offset = "0xC")]
	private UdpClient m_UDPClient;

	[Token(Token = "0x401AD5A")]
	[FieldOffset(Offset = "0x10")]
	public int m_LocalPort;

	[Token(Token = "0x401AD5B")]
	[FieldOffset(Offset = "0x14")]
	protected EndPoint m_ReceivedEP;

	[Token(Token = "0x401AD5C")]
	[FieldOffset(Offset = "0x18")]
	protected EndPoint m_RemoteEP;

	[Token(Token = "0x401AD5D")]
	[FieldOffset(Offset = "0x1C")]
	private Thread m_RecvThread;

	[Token(Token = "0x401AD5E")]
	[FieldOffset(Offset = "0x20")]
	private byte[] mReceiveByteData;

	[Token(Token = "0x401AD5F")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<string, ConsoleCommand> m_ConsoleCommands;

	[Token(Token = "0x401AD60")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, string> m_ConsoleCommandsDesc;

	[Token(Token = "0x401AD61")]
	[FieldOffset(Offset = "0x2C")]
	private NetworkByteStream m_RecvBuffer;

	[Token(Token = "0x401AD62")]
	[FieldOffset(Offset = "0x30")]
	private string ConnectCMD;

	[Token(Token = "0x401AD63")]
	[FieldOffset(Offset = "0x34")]
	private Socket mUDPServer;

	[Token(Token = "0x401AD64")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder m_LocalStream;

	[Token(Token = "0x401AD65")]
	[FieldOffset(Offset = "0x3C")]
	private string m_LocalAddr;

	[Token(Token = "0x401AD66")]
	[FieldOffset(Offset = "0x40")]
	private List<string> _m_PendingCommands;

	[Token(Token = "0x401AD67")]
	[FieldOffset(Offset = "0x44")]
	protected string m_PrintIndent;

	[Token(Token = "0x401AD68")]
	[FieldOffset(Offset = "0x48")]
	protected int m_PrintIndentLevel;

	[Token(Token = "0x17001C56")]
	public string LocalAddr
	{
		[Token(Token = "0x6019F4F")]
		[Address(RVA = "0x33268F4", Offset = "0x33268F4", VA = "0x33268F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C57")]
	protected int PrintIndentLevel
	{
		[Token(Token = "0x6019F66")]
		[Address(RVA = "0x332AE10", Offset = "0x332AE10", VA = "0x332AE10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019F67")]
		[Address(RVA = "0x332AE18", Offset = "0x332AE18", VA = "0x332AE18")]
		set
		{
		}
	}

	[Token(Token = "0x6019F4D")]
	[Address(RVA = "0x3326610", Offset = "0x3326610", VA = "0x3326610")]
	public RemoteConsoleBase()
	{
	}

	[Token(Token = "0x6019F4E")]
	[Address(RVA = "0x3326784", Offset = "0x3326784", VA = "0x3326784")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019F50")]
	[Address(RVA = "0x3326B04", Offset = "0x3326B04", VA = "0x3326B04")]
	public void InitRemoteConsoleServer()
	{
	}

	[Token(Token = "0x6019F51")]
	[Address(RVA = "0x3326B30", Offset = "0x3326B30", VA = "0x3326B30")]
	public void InitUDPClient()
	{
	}

	[Token(Token = "0x6019F52")]
	[Address(RVA = "0x3326F2C", Offset = "0x3326F2C", VA = "0x3326F2C")]
	private void OnRecvDataThread()
	{
	}

	[Token(Token = "0x6019F53")]
	[Address(RVA = "0x3327A84", Offset = "0x3327A84", VA = "0x3327A84")]
	public void UpdatePendingCommands()
	{
	}

	[Token(Token = "0x6019F54")]
	[Address(RVA = "0x3327BF0", Offset = "0x3327BF0", VA = "0x3327BF0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6019F55")]
	[Address(RVA = "0x3327C1C", Offset = "0x3327C1C", VA = "0x3327C1C")]
	private void OnDestory()
	{
	}

	[Token(Token = "0x6019F56")]
	[Address(RVA = "0x3327C5C", Offset = "0x3327C5C", VA = "0x3327C5C")]
	public void Send(string msg)
	{
	}

	[Token(Token = "0x6019F57")]
	[Address(RVA = "0x33279A8", Offset = "0x33279A8", VA = "0x33279A8")]
	private void ThreadSafeAddPendingCommand(string s)
	{
	}

	[Token(Token = "0x6019F58")]
	[Address(RVA = "0x3327A88", Offset = "0x3327A88", VA = "0x3327A88")]
	private void ThreadSafeExecutePendingCommands()
	{
	}

	[Token(Token = "0x6019F59")]
	[Address(RVA = "0x3327D84", Offset = "0x3327D84", VA = "0x3327D84", Slot = "4")]
	protected virtual void ExecuteCommand(string cmdline)
	{
	}

	[Token(Token = "0x6019F5A")]
	[Address(RVA = "0x33285E0", Offset = "0x33285E0", VA = "0x33285E0")]
	public string ExecuteCommandLocalCall(string cmd)
	{
		return null;
	}

	[Token(Token = "0x6019F5B")]
	[Address(RVA = "0x332886C", Offset = "0x332886C", VA = "0x332886C")]
	public static string Echo(object o)
	{
		return null;
	}

	[Token(Token = "0x6019F5C")]
	[Address(RVA = "0x33288E8", Offset = "0x33288E8", VA = "0x33288E8")]
	private static void ReceiveCallback(IAsyncResult ar)
	{
	}

	[Token(Token = "0x6019F5D")]
	[Address(RVA = "0x3328D70", Offset = "0x3328D70", VA = "0x3328D70")]
	public void DefCommand(string cmdStr, ConsoleCommand cmd, string description = "")
	{
	}

	[Token(Token = "0x6019F5E")]
	[Address(RVA = "0x3328E50", Offset = "0x3328E50", VA = "0x3328E50", Slot = "5")]
	protected virtual void InitializeConsoleCommands()
	{
	}

	[Token(Token = "0x6019F5F")]
	[Address(RVA = "0x3329108", Offset = "0x3329108", VA = "0x3329108")]
	private void CmdPing(string param)
	{
	}

	[Token(Token = "0x6019F60")]
	[Address(RVA = "0x33291AC", Offset = "0x33291AC", VA = "0x33291AC")]
	private void CmdList(string param)
	{
	}

	[Token(Token = "0x6019F61")]
	[Address(RVA = "0x3329480", Offset = "0x3329480", VA = "0x3329480")]
	private void CmdConnect(string param)
	{
	}

	[Token(Token = "0x6019F62")]
	[Address(RVA = "0x332952C", Offset = "0x332952C", VA = "0x332952C")]
	private void CmdSetStatic(string param)
	{
	}

	[Token(Token = "0x6019F63")]
	[Address(RVA = "0x332A214", Offset = "0x332A214", VA = "0x332A214")]
	private void CmdGetStatic(string param)
	{
	}

	[Token(Token = "0x6019F64")]
	[Address(RVA = "0x3329AA4", Offset = "0x3329AA4", VA = "0x3329AA4")]
	private object ParseValue(Type fType, string valueStr)
	{
		return null;
	}

	[Token(Token = "0x6019F65")]
	[Address(RVA = "0x332A640", Offset = "0x332A640", VA = "0x332A640")]
	private void CmdCallStatic(string param)
	{
	}

	[Token(Token = "0x6019F68")]
	[Address(RVA = "0x332AF68", Offset = "0x332AF68", VA = "0x332AF68")]
	public void Print(string s)
	{
	}

	[Token(Token = "0x6019F69")]
	[Address(RVA = "0x332B05C", Offset = "0x332B05C", VA = "0x332B05C")]
	public void PrintTransforms(Transform t, bool rec = true)
	{
	}

	[Token(Token = "0x6019F6A")]
	[Address(RVA = "0x332B420", Offset = "0x332B420", VA = "0x332B420")]
	protected void PrintTransform(Transform t)
	{
	}
}
