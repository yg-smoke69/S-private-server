using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E8F")]
public class TimeService
{
	[Token(Token = "0x401A6C2")]
	[FieldOffset(Offset = "0x8")]
	private float m_GameTime;

	[Token(Token = "0x401A6C3")]
	[FieldOffset(Offset = "0xC")]
	private float m_LastGameTime;

	[Token(Token = "0x401A6C4")]
	[FieldOffset(Offset = "0x10")]
	private float m_DeltaTime;

	[Token(Token = "0x401A6C5")]
	[FieldOffset(Offset = "0x14")]
	private uint m_DeltaTickCount;

	[Token(Token = "0x401A6C6")]
	[FieldOffset(Offset = "0x18")]
	private uint m_TickCount;

	[Token(Token = "0x401A6C7")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_UsingFixedDeltaTime;

	[Token(Token = "0x401A6C8")]
	[FieldOffset(Offset = "0x20")]
	private float m_FixedDeltaTime;

	[Token(Token = "0x17001BC7")]
	public float GameTime
	{
		[Token(Token = "0x6019758")]
		[Address(RVA = "0x323D678", Offset = "0x323D678", VA = "0x323D678")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BC8")]
	public float LastGameTime
	{
		[Token(Token = "0x6019759")]
		[Address(RVA = "0x323D680", Offset = "0x323D680", VA = "0x323D680")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BC9")]
	public float FixedDeltaTime
	{
		[Token(Token = "0x601975A")]
		[Address(RVA = "0x323D688", Offset = "0x323D688", VA = "0x323D688")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BCA")]
	public float DeltaTime
	{
		[Token(Token = "0x601975B")]
		[Address(RVA = "0x323D690", Offset = "0x323D690", VA = "0x323D690")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BCB")]
	public uint DeltaTickCount
	{
		[Token(Token = "0x601975C")]
		[Address(RVA = "0x323D698", Offset = "0x323D698", VA = "0x323D698")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001BCC")]
	public uint TickCount
	{
		[Token(Token = "0x601975D")]
		[Address(RVA = "0x323D6A0", Offset = "0x323D6A0", VA = "0x323D6A0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6019757")]
	[Address(RVA = "0x323D670", Offset = "0x323D670", VA = "0x323D670")]
	public TimeService()
	{
	}

	[Token(Token = "0x601975E")]
	[Address(RVA = "0x323D6A8", Offset = "0x323D6A8", VA = "0x323D6A8")]
	public void Reset()
	{
	}

	[Token(Token = "0x601975F")]
	[Address(RVA = "0x323D6C0", Offset = "0x323D6C0", VA = "0x323D6C0")]
	public void UseFixedDeltaTime(float fixedDeltaTime)
	{
	}

	[Token(Token = "0x6019760")]
	[Address(RVA = "0x323D6D0", Offset = "0x323D6D0", VA = "0x323D6D0")]
	public void UpdateTime()
	{
	}

	[Token(Token = "0x6019761")]
	[Address(RVA = "0x323D75C", Offset = "0x323D75C", VA = "0x323D75C")]
	public void ClearDeltaTime()
	{
	}
}
