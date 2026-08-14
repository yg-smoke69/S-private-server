using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C3A")]
public class TStaticHelperBase<T> : TSingleton<T> where T : class, new()
{
	[Token(Token = "0x4019A2B")]
	[FieldOffset(Offset = "0x0")]
	private bool _003ChasInited_003Ek__BackingField;

	[Token(Token = "0x17001977")]
	protected bool hasInited
	{
		[Token(Token = "0x6018078")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018077")]
		private set
		{
		}
	}

	[Token(Token = "0x6018072")]
	public TStaticHelperBase()
	{
	}

	[Token(Token = "0x6018073")]
	public void Init()
	{
	}

	[Token(Token = "0x6018074")]
	public void Uninit()
	{
	}

	[Token(Token = "0x6018075")]
	protected virtual void onInit()
	{
	}

	[Token(Token = "0x6018076")]
	protected virtual void onUninit()
	{
	}
}
