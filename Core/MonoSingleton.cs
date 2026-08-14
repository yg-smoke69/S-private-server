using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F91")]
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	[Token(Token = "0x401AC93")]
	[FieldOffset(Offset = "0x0")]
	private static T m_Instance;

	[Token(Token = "0x17001C3D")]
	public static T instance
	{
		[Token(Token = "0x6019DE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C3E")]
	public static bool hasInstance
	{
		[Token(Token = "0x6019DE9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019DE7")]
	protected MonoSingleton()
	{
	}

	[Token(Token = "0x6019DEA")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6019DEB")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6019DEC")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6019DED")]
	private void OnApplicationQuit()
	{
	}
}
