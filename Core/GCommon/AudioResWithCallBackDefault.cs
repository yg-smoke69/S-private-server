using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E50")]
public class AudioResWithCallBackDefault : AudioResWithCallBackBase
{
	[Token(Token = "0x401A59D")]
	[FieldOffset(Offset = "0x1C")]
	public AudioSource Audio;

	[Token(Token = "0x401A59E")]
	[FieldOffset(Offset = "0x20")]
	public bool IsNeedUnloadAudioData;

	[Token(Token = "0x401A59F")]
	[FieldOffset(Offset = "0x24")]
	public ObjectPool<AudioResWithCallBackDefault> OwnedPool;

	[Token(Token = "0x6019518")]
	[Address(RVA = "0x3078754", Offset = "0x3078754", VA = "0x3078754")]
	public AudioResWithCallBackDefault()
	{
	}

	[Token(Token = "0x6019519")]
	[Address(RVA = "0x307875C", Offset = "0x307875C", VA = "0x307875C", Slot = "10")]
	protected override void OnOnCollected()
	{
	}

	[Token(Token = "0x601951A")]
	[Address(RVA = "0x307876C", Offset = "0x307876C", VA = "0x307876C")]
	public void UnloadAudioData()
	{
	}

	[Token(Token = "0x601951B")]
	[Address(RVA = "0x307893C", Offset = "0x307893C", VA = "0x307893C", Slot = "11")]
	public override void ReturnToPool()
	{
	}
}
