using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FDE")]
public class UIAvatarStateTriggerValue<T> where T : struct
{
	[Token(Token = "0x400C864")]
	[FieldOffset(Offset = "0x0")]
	private T m_value;

	[Token(Token = "0x600A07E")]
	public UIAvatarStateTriggerValue()
	{
	}

	[Token(Token = "0x600A07F")]
	public void Set(T t)
	{
	}

	[Token(Token = "0x600A080")]
	public T GetAndReset()
	{
		return (T)null;
	}

	[Token(Token = "0x600A081")]
	public void CloneTo(UIAvatarStateTriggerValue<T> s)
	{
	}
}
