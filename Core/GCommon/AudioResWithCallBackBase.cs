using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E4F")]
public class AudioResWithCallBackBase : ObjectPoolCallbackBase
{
	[Token(Token = "0x401A599")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID AudioID;

	[Token(Token = "0x401A59A")]
	[FieldOffset(Offset = "0x10")]
	public float TargetVolume;

	[Token(Token = "0x401A59B")]
	[FieldOffset(Offset = "0x14")]
	public AudioEndInternalCallBack EndCallBack;

	[Token(Token = "0x401A59C")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsFromStop;

	[Token(Token = "0x6019513")]
	[Address(RVA = "0x3078644", Offset = "0x3078644", VA = "0x3078644")]
	public AudioResWithCallBackBase()
	{
	}

	[Token(Token = "0x6019514")]
	[Address(RVA = "0x307864C", Offset = "0x307864C", VA = "0x307864C", Slot = "8")]
	public override void OnCollected()
	{
	}

	[Token(Token = "0x6019515")]
	[Address(RVA = "0x3078740", Offset = "0x3078740", VA = "0x3078740", Slot = "10")]
	protected virtual void OnOnCollected()
	{
	}

	[Token(Token = "0x6019516")]
	[Address(RVA = "0x3078744", Offset = "0x3078744", VA = "0x3078744")]
	public void MarkIsFromStop()
	{
	}

	[Token(Token = "0x6019517")]
	[Address(RVA = "0x3078750", Offset = "0x3078750", VA = "0x3078750", Slot = "11")]
	public virtual void ReturnToPool()
	{
	}
}
