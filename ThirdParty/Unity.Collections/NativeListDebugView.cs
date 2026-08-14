using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2003D05")]
internal sealed class NativeListDebugView<T> where T : struct
{
	[Token(Token = "0x4019E5F")]
	[FieldOffset(Offset = "0x0")]
	private NativeList<T> m_Array;

	[Token(Token = "0x170019CD")]
	public T[] Items
	{
		[Token(Token = "0x60186FA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60186F9")]
	public NativeListDebugView(NativeList<T> array)
	{
	}
}
