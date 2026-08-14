using System;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003EC9")]
public class LoadingProcessManager
{
	[Token(Token = "0x401A848")]
	[FieldOffset(Offset = "0x8")]
	private LoadingProcess[] m_Processes;

	[Token(Token = "0x401A849")]
	[FieldOffset(Offset = "0xC")]
	private int m_LastMainProcessIndex;

	[Token(Token = "0x401A84A")]
	[FieldOffset(Offset = "0x10")]
	private Action<bool, int> m_FinshedHandler;

	[Token(Token = "0x60198EF")]
	[Address(RVA = "0x32BD124", Offset = "0x32BD124", VA = "0x32BD124")]
	public LoadingProcessManager()
	{
	}

	[Token(Token = "0x60198F0")]
	[Address(RVA = "0x32BD134", Offset = "0x32BD134", VA = "0x32BD134")]
	public void Start(LoadingProcess[] processes, Action<bool, int> finishedHandler)
	{
	}

	[Token(Token = "0x60198F1")]
	[Address(RVA = "0x32BD4FC", Offset = "0x32BD4FC", VA = "0x32BD4FC")]
	public void Update()
	{
	}

	[Token(Token = "0x60198F2")]
	[Address(RVA = "0x32BD38C", Offset = "0x32BD38C", VA = "0x32BD38C")]
	private void StartNextProcess()
	{
	}

	[Token(Token = "0x60198F3")]
	[Address(RVA = "0x32BD244", Offset = "0x32BD244", VA = "0x32BD244")]
	private void DispachFinishedEvent(bool result, int exceptionProcessIndex = -1)
	{
	}

	[Token(Token = "0x60198F4")]
	[Address(RVA = "0x32BD234", Offset = "0x32BD234", VA = "0x32BD234")]
	private bool HasProcesses()
	{
		return default(bool);
	}
}
