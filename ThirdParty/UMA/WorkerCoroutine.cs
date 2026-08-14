using System.Collections;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003CFD")]
public abstract class WorkerCoroutine
{
	[Token(Token = "0x4019E4E")]
	[FieldOffset(Offset = "0x8")]
	private IEnumerator workerInstance;

	[Token(Token = "0x4019E4F")]
	[FieldOffset(Offset = "0xC")]
	private WorkerCoroutine subWorker;

	[Token(Token = "0x4019E50")]
	[FieldOffset(Offset = "0x10")]
	public int TimeHint;

	[Token(Token = "0x4019E51")]
	[FieldOffset(Offset = "0x14")]
	public WorkerCoroutine lastWorker;

	[Token(Token = "0x4019E52")]
	[FieldOffset(Offset = "0x18")]
	public int lastWorkerCount;

	[Token(Token = "0x60186CD")]
	[Address(RVA = "0x35DC958", Offset = "0x35DC958", VA = "0x35DC958")]
	protected WorkerCoroutine()
	{
	}

	[Token(Token = "0x60186CE")]
	protected abstract void Start();

	[Token(Token = "0x60186CF")]
	protected abstract IEnumerator workerMethod();

	[Token(Token = "0x60186D0")]
	protected abstract void Stop();

	[Token(Token = "0x60186D1")]
	[Address(RVA = "0x35EF774", Offset = "0x35EF774", VA = "0x35EF774")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60186D2")]
	[Address(RVA = "0x35EF7A4", Offset = "0x35EF7A4", VA = "0x35EF7A4")]
	public bool Work()
	{
		return default(bool);
	}
}
