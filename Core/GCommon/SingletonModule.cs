using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E8D")]
public abstract class SingletonModule<T> : _Attribute where T : SingletonModule<T>, new()
{
	[Token(Token = "0x401A6BE")]
	[FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x401A6BF")]
	[FieldOffset(Offset = "0x0")]
	private bool m_HasInited;

	[Token(Token = "0x401A6C0")]
	[FieldOffset(Offset = "0x0")]
	private bool m_HasUnloadPartialMemory;

	[Token(Token = "0x17001BC6")]
	public static T instance
	{
		[Token(Token = "0x6019749")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019748")]
	public SingletonModule()
	{
	}

	[Token(Token = "0x601974A")]
	public void Init()
	{
	}

	[Token(Token = "0x601974B")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x601974C")]
	protected abstract void OnInit();

	[Token(Token = "0x601974D")]
	protected abstract void OnCleanup();

	[Token(Token = "0x601974E")]
	public void UnLoadMemoryIfNecessary()
	{
	}

	[Token(Token = "0x601974F")]
	public void ReloadMemoryIfNecessary()
	{
	}

	[Token(Token = "0x6019750")]
	protected virtual void OnUnloadMemeory()
	{
	}

	[Token(Token = "0x6019751")]
	protected virtual void OnReloadMemory()
	{
	}
}
