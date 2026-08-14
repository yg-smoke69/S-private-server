using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2004180")]
public class BindableProperty<T> where T : IEquatable<T>
{
	[Token(Token = "0x401B762")]
	[FieldOffset(Offset = "0x0")]
	private T m_Value;

	[Token(Token = "0x401B763")]
	[FieldOffset(Offset = "0x0")]
	public Action<T> OnValueChanged;

	[Token(Token = "0x17001D81")]
	public T Value
	{
		[Token(Token = "0x601AC21")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x601AC22")]
		set
		{
		}
	}

	[Token(Token = "0x601AC20")]
	public BindableProperty()
	{
	}
}
