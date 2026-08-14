using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200400B")]
public class Timer
{
	[Token(Token = "0x401AF01")]
	[FieldOffset(Offset = "0x8")]
	protected float m_ExpiredTime;

	[Token(Token = "0x601A145")]
	[Address(RVA = "0x323D76C", Offset = "0x323D76C", VA = "0x323D76C")]
	public Timer()
	{
	}

	[Token(Token = "0x601A146")]
	[Address(RVA = "0x323D774", Offset = "0x323D774", VA = "0x323D774")]
	public void Reset()
	{
	}

	[Token(Token = "0x601A147")]
	[Address(RVA = "0x323D784", Offset = "0x323D784", VA = "0x323D784")]
	public void SetExpiredTime(float expiredTime)
	{
	}

	[Token(Token = "0x601A148")]
	[Address(RVA = "0x323D78C", Offset = "0x323D78C", VA = "0x323D78C")]
	public bool IsExpired(float gameTime)
	{
		return default(bool);
	}

	[Token(Token = "0x601A149")]
	[Address(RVA = "0x323D7BC", Offset = "0x323D7BC", VA = "0x323D7BC")]
	public void Copy(Timer t)
	{
	}
}
