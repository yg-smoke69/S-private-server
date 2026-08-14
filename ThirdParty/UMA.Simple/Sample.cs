using System.Diagnostics;
using Il2CppDummyDll;

namespace UMA.Simple;

[Token(Token = "0x2003C82")]
public class Sample
{
	[Token(Token = "0x4019B60")]
	[FieldOffset(Offset = "0x0")]
	private static Stopwatch m_Watch;

	[Token(Token = "0x4019B61")]
	[FieldOffset(Offset = "0x8")]
	public string Name;

	[Token(Token = "0x4019B62")]
	[FieldOffset(Offset = "0xC")]
	public bool Async;

	[Token(Token = "0x4019B63")]
	[FieldOffset(Offset = "0x10")]
	public int Count;

	[Token(Token = "0x4019B64")]
	[FieldOffset(Offset = "0x18")]
	public long Ticks;

	[Token(Token = "0x4019B65")]
	[FieldOffset(Offset = "0x20")]
	public long MaxTicks;

	[Token(Token = "0x4019B66")]
	[FieldOffset(Offset = "0x28")]
	public int Frames;

	[Token(Token = "0x4019B67")]
	[FieldOffset(Offset = "0x2C")]
	public int MaxFrames;

	[Token(Token = "0x4019B68")]
	[FieldOffset(Offset = "0x30")]
	private long m_StartTicks;

	[Token(Token = "0x4019B69")]
	[FieldOffset(Offset = "0x38")]
	private int m_StartFrame;

	[Token(Token = "0x60182F0")]
	[Address(RVA = "0x2D55934", Offset = "0x2D55934", VA = "0x2D55934")]
	public Sample()
	{
	}

	[Token(Token = "0x60182F1")]
	[Address(RVA = "0x2D55C80", Offset = "0x2D55C80", VA = "0x2D55C80")]
	public Sample(string name, bool async)
	{
	}

	[Token(Token = "0x60182F2")]
	[Address(RVA = "0x2D5596C", Offset = "0x2D5596C", VA = "0x2D5596C")]
	public void Begin()
	{
	}

	[Token(Token = "0x60182F3")]
	[Address(RVA = "0x2D55B30", Offset = "0x2D55B30", VA = "0x2D55B30")]
	public long End()
	{
		return default(long);
	}

	[Token(Token = "0x60182F4")]
	[Address(RVA = "0x2D55CA8", Offset = "0x2D55CA8", VA = "0x2D55CA8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60182F5")]
	[Address(RVA = "0x2D56488", Offset = "0x2D56488", VA = "0x2D56488")]
	public void Merge(Sample s)
	{
	}
}
