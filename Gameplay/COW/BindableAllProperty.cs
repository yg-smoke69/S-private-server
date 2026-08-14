using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200417F")]
public class BindableAllProperty<T>
{
	[Token(Token = "0x401B760")]
	[FieldOffset(Offset = "0x0")]
	private T m_Value;

	[Token(Token = "0x401B761")]
	[FieldOffset(Offset = "0x0")]
	public Action<T> OnValueChanged;

	[Token(Token = "0x17001D80")]
	public T Value
	{
		[Token(Token = "0x601AC1E")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x601AC1F")]
		set
		{
		}
	}

	[Token(Token = "0x601AC1D")]
	public BindableAllProperty()
	{
	}
}
