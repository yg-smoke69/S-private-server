using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003EC1")]
public abstract class BaseGameContext
{
	[Token(Token = "0x401A7FC")]
	[FieldOffset(Offset = "0x8")]
	private bool m_HasInit;

	[Token(Token = "0x401A7FD")]
	[FieldOffset(Offset = "0xC")]
	private BaseGame _003CCurrentGame_003Ek__BackingField;

	[Token(Token = "0x17001BE0")]
	public BaseGame CurrentGame
	{
		[Token(Token = "0x60198B0")]
		[Address(RVA = "0x307CCB4", Offset = "0x307CCB4", VA = "0x307CCB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60198B1")]
		[Address(RVA = "0x307AAC0", Offset = "0x307AAC0", VA = "0x307AAC0")]
		internal set
		{
		}
	}

	[Token(Token = "0x60198AF")]
	[Address(RVA = "0x307CCAC", Offset = "0x307CCAC", VA = "0x307CCAC")]
	protected BaseGameContext()
	{
	}

	[Token(Token = "0x60198B2")]
	[Address(RVA = "0x307AAC8", Offset = "0x307AAC8", VA = "0x307AAC8")]
	public void Init()
	{
	}

	[Token(Token = "0x60198B3")]
	[Address(RVA = "0x307CCBC", Offset = "0x307CCBC", VA = "0x307CCBC")]
	public void Destory()
	{
	}

	[Token(Token = "0x60198B4")]
	[Address(RVA = "0x307CCF4", Offset = "0x307CCF4", VA = "0x307CCF4", Slot = "4")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x60198B5")]
	[Address(RVA = "0x307CCF8", Offset = "0x307CCF8", VA = "0x307CCF8", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}
}
