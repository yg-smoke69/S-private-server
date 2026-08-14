using Il2CppDummyDll;
using Unity.Jobs;

namespace COW;

[Token(Token = "0x2003F66")]
internal class JobPair<T> where T : struct, IJob, IReset
{
	[Token(Token = "0x401ABD9")]
	[FieldOffset(Offset = "0x0")]
	public T Job;

	[Token(Token = "0x401ABDA")]
	[FieldOffset(Offset = "0x0")]
	public JobHandle Handle;

	[Token(Token = "0x401ABDB")]
	[FieldOffset(Offset = "0x0")]
	public EJobPairState State;

	[Token(Token = "0x17001C33")]
	public bool IsCompleted
	{
		[Token(Token = "0x6019D1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019D1B")]
	public JobPair()
	{
	}

	[Token(Token = "0x6019D1D")]
	private bool CheckState(EJobPairState desired, bool logErr = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6019D1E")]
	public bool Schedule()
	{
		return default(bool);
	}

	[Token(Token = "0x6019D1F")]
	public bool Complete()
	{
		return default(bool);
	}

	[Token(Token = "0x6019D20")]
	public void Reset()
	{
	}
}
